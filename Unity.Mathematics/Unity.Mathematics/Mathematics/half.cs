using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Unity.Mathematics
{
	// Token: 0x02000029 RID: 41
	[Serializable]
	[StructLayout(2)]
	public struct half
	{
		// Token: 0x06001641 RID: 5697 RVA: 0x00077148 File Offset: 0x00075348
		// Note: this type is marked as 'beforefieldinit'.
		static half()
		{
			Il2CppClassPointerStore<half>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Mathematics.dll", "Unity.Mathematics", "half");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<half>.NativeClassPtr);
			half.NativeFieldInfoPtr_value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<half>.NativeClassPtr, "value");
			half.NativeFieldInfoPtr_zero = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<half>.NativeClassPtr, "zero");
			half.NativeMethodInfoPtr_get_MaxValue_Public_Static_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half>.NativeClassPtr, 100668826);
			half.NativeMethodInfoPtr_get_MinValue_Public_Static_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half>.NativeClassPtr, 100668827);
			half.NativeMethodInfoPtr_get_MaxValueAsHalf_Public_Static_get_half_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half>.NativeClassPtr, 100668828);
			half.NativeMethodInfoPtr_get_MinValueAsHalf_Public_Static_get_half_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half>.NativeClassPtr, 100668829);
			half.NativeMethodInfoPtr__ctor_Public_Void_half_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half>.NativeClassPtr, 100668830);
			half.NativeMethodInfoPtr__ctor_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half>.NativeClassPtr, 100668831);
			half.NativeMethodInfoPtr__ctor_Public_Void_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half>.NativeClassPtr, 100668832);
			half.NativeMethodInfoPtr_op_Explicit_Public_Static_half_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half>.NativeClassPtr, 100668833);
			half.NativeMethodInfoPtr_op_Explicit_Public_Static_half_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half>.NativeClassPtr, 100668834);
			half.NativeMethodInfoPtr_op_Implicit_Public_Static_Single_half_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half>.NativeClassPtr, 100668835);
			half.NativeMethodInfoPtr_op_Implicit_Public_Static_Double_half_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half>.NativeClassPtr, 100668836);
			half.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_half_half_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half>.NativeClassPtr, 100668837);
			half.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_half_half_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half>.NativeClassPtr, 100668838);
			half.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_half_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half>.NativeClassPtr, 100668839);
			half.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half>.NativeClassPtr, 100668840);
			half.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half>.NativeClassPtr, 100668841);
			half.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half>.NativeClassPtr, 100668842);
			half.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<half>.NativeClassPtr, 100668843);
		}

		// Token: 0x170005FD RID: 1533
		// (get) Token: 0x06001642 RID: 5698 RVA: 0x00077308 File Offset: 0x00075508
		public unsafe static float MaxValue
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half.NativeMethodInfoPtr_get_MaxValue_Public_Static_get_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170005FE RID: 1534
		// (get) Token: 0x06001643 RID: 5699 RVA: 0x00077338 File Offset: 0x00075538
		public unsafe static float MinValue
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 638951, RefRangeEnd = 638955, XrefRangeStart = 638951, XrefRangeEnd = 638951, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half.NativeMethodInfoPtr_get_MinValue_Public_Static_get_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170005FF RID: 1535
		// (get) Token: 0x06001644 RID: 5700 RVA: 0x00077368 File Offset: 0x00075568
		public unsafe static half MaxValueAsHalf
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 638955, XrefRangeEnd = 638956, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half.NativeMethodInfoPtr_get_MaxValueAsHalf_Public_Static_get_half_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000600 RID: 1536
		// (get) Token: 0x06001645 RID: 5701 RVA: 0x00077398 File Offset: 0x00075598
		public unsafe static half MinValueAsHalf
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 638956, XrefRangeEnd = 638957, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half.NativeMethodInfoPtr_get_MinValueAsHalf_Public_Static_get_half_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001646 RID: 5702 RVA: 0x000773C8 File Offset: 0x000755C8
		[CallerCount(0)]
		public unsafe half(half x)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half.NativeMethodInfoPtr__ctor_Public_Void_half_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001647 RID: 5703 RVA: 0x000773FC File Offset: 0x000755FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 638957, XrefRangeEnd = 638958, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe half(float v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half.NativeMethodInfoPtr__ctor_Public_Void_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001648 RID: 5704 RVA: 0x00077430 File Offset: 0x00075630
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 638958, XrefRangeEnd = 638959, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe half(double v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half.NativeMethodInfoPtr__ctor_Public_Void_Double_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001649 RID: 5705 RVA: 0x00077464 File Offset: 0x00075664
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator half(float v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half.NativeMethodInfoPtr_op_Explicit_Public_Static_half_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600164A RID: 5706 RVA: 0x000774A4 File Offset: 0x000756A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator half(double v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half.NativeMethodInfoPtr_op_Explicit_Public_Static_half_Double_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600164B RID: 5707 RVA: 0x000774E4 File Offset: 0x000756E4
		[CallerCount(0)]
		public unsafe static implicit operator float(half d)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref d;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half.NativeMethodInfoPtr_op_Implicit_Public_Static_Single_half_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600164C RID: 5708 RVA: 0x00077524 File Offset: 0x00075724
		[CallerCount(0)]
		public unsafe static implicit operator double(half d)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref d;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half.NativeMethodInfoPtr_op_Implicit_Public_Static_Double_half_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600164D RID: 5709 RVA: 0x00077564 File Offset: 0x00075764
		[CallerCount(0)]
		public unsafe static bool operator ==(half lhs, half rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_half_half_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600164E RID: 5710 RVA: 0x000775B0 File Offset: 0x000757B0
		[CallerCount(0)]
		public unsafe static bool operator !=(half lhs, half rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_half_half_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600164F RID: 5711 RVA: 0x000775FC File Offset: 0x000757FC
		[CallerCount(27)]
		[CachedScanResults(RefRangeStart = 638959, RefRangeEnd = 638986, XrefRangeStart = 638959, XrefRangeEnd = 638959, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(half rhs)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref rhs;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_half_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001650 RID: 5712 RVA: 0x0007763C File Offset: 0x0007583C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 638986, XrefRangeEnd = 638989, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object o)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(o);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001651 RID: 5713 RVA: 0x00077680 File Offset: 0x00075880
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 638989, RefRangeEnd = 639002, XrefRangeStart = 638989, XrefRangeEnd = 638989, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001652 RID: 5714 RVA: 0x000776B0 File Offset: 0x000758B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 639002, XrefRangeEnd = 639003, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001653 RID: 5715 RVA: 0x000776DC File Offset: 0x000758DC
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 639004, RefRangeEnd = 639013, XrefRangeStart = 639003, XrefRangeEnd = 639004, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(half.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001654 RID: 5716 RVA: 0x00002604 File Offset: 0x00000804
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<half>.NativeClassPtr, ref this));
		}

		// Token: 0x170005FC RID: 1532
		// (get) Token: 0x06001655 RID: 5717 RVA: 0x0007772C File Offset: 0x0007592C
		// (set) Token: 0x06001656 RID: 5718 RVA: 0x00002616 File Offset: 0x00000816
		public unsafe static half zero
		{
			get
			{
				half half;
				IL2CPP.il2cpp_field_static_get_value(half.NativeFieldInfoPtr_zero, (void*)(&half));
				return half;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(half.NativeFieldInfoPtr_zero, (void*)(&value));
			}
		}

		// Token: 0x04001697 RID: 5783
		private static readonly IntPtr NativeFieldInfoPtr_value;

		// Token: 0x04001698 RID: 5784
		private static readonly IntPtr NativeFieldInfoPtr_zero;

		// Token: 0x04001699 RID: 5785
		private static readonly IntPtr NativeMethodInfoPtr_get_MaxValue_Public_Static_get_Single_0;

		// Token: 0x0400169A RID: 5786
		private static readonly IntPtr NativeMethodInfoPtr_get_MinValue_Public_Static_get_Single_0;

		// Token: 0x0400169B RID: 5787
		private static readonly IntPtr NativeMethodInfoPtr_get_MaxValueAsHalf_Public_Static_get_half_0;

		// Token: 0x0400169C RID: 5788
		private static readonly IntPtr NativeMethodInfoPtr_get_MinValueAsHalf_Public_Static_get_half_0;

		// Token: 0x0400169D RID: 5789
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_half_0;

		// Token: 0x0400169E RID: 5790
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_0;

		// Token: 0x0400169F RID: 5791
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Double_0;

		// Token: 0x040016A0 RID: 5792
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_half_Single_0;

		// Token: 0x040016A1 RID: 5793
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_half_Double_0;

		// Token: 0x040016A2 RID: 5794
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_Single_half_0;

		// Token: 0x040016A3 RID: 5795
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_Double_half_0;

		// Token: 0x040016A4 RID: 5796
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_half_half_0;

		// Token: 0x040016A5 RID: 5797
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_half_half_0;

		// Token: 0x040016A6 RID: 5798
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_half_0;

		// Token: 0x040016A7 RID: 5799
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x040016A8 RID: 5800
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x040016A9 RID: 5801
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x040016AA RID: 5802
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0;

		// Token: 0x040016AB RID: 5803
		[FieldOffset(0)]
		public ushort value;
	}
}
