using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Unity.Mathematics
{
	// Token: 0x0200001F RID: 31
	[Serializable]
	[StructLayout(2)]
	public struct float2x3
	{
		// Token: 0x06001141 RID: 4417 RVA: 0x0005E37C File Offset: 0x0005C57C
		// Note: this type is marked as 'beforefieldinit'.
		static float2x3()
		{
			Il2CppClassPointerStore<float2x3>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Mathematics.dll", "Unity.Mathematics", "float2x3");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<float2x3>.NativeClassPtr);
			float2x3.NativeFieldInfoPtr_c0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<float2x3>.NativeClassPtr, "c0");
			float2x3.NativeFieldInfoPtr_c1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<float2x3>.NativeClassPtr, "c1");
			float2x3.NativeFieldInfoPtr_c2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<float2x3>.NativeClassPtr, "c2");
			float2x3.NativeFieldInfoPtr_zero = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<float2x3>.NativeClassPtr, "zero");
			float2x3.NativeMethodInfoPtr__ctor_Public_Void_float2_float2_float2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float2x3>.NativeClassPtr, 100667586);
			float2x3.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float2x3>.NativeClassPtr, 100667587);
			float2x3.NativeMethodInfoPtr__ctor_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float2x3>.NativeClassPtr, 100667588);
			float2x3.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float2x3>.NativeClassPtr, 100667589);
			float2x3.NativeMethodInfoPtr__ctor_Public_Void_bool2x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float2x3>.NativeClassPtr, 100667590);
			float2x3.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float2x3>.NativeClassPtr, 100667591);
			float2x3.NativeMethodInfoPtr__ctor_Public_Void_int2x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float2x3>.NativeClassPtr, 100667592);
			float2x3.NativeMethodInfoPtr__ctor_Public_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float2x3>.NativeClassPtr, 100667593);
			float2x3.NativeMethodInfoPtr__ctor_Public_Void_uint2x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float2x3>.NativeClassPtr, 100667594);
			float2x3.NativeMethodInfoPtr__ctor_Public_Void_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float2x3>.NativeClassPtr, 100667595);
			float2x3.NativeMethodInfoPtr__ctor_Public_Void_double2x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float2x3>.NativeClassPtr, 100667596);
			float2x3.NativeMethodInfoPtr_op_Implicit_Public_Static_float2x3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float2x3>.NativeClassPtr, 100667597);
			float2x3.NativeMethodInfoPtr_op_Explicit_Public_Static_float2x3_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float2x3>.NativeClassPtr, 100667598);
			float2x3.NativeMethodInfoPtr_op_Explicit_Public_Static_float2x3_bool2x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float2x3>.NativeClassPtr, 100667599);
			float2x3.NativeMethodInfoPtr_op_Implicit_Public_Static_float2x3_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float2x3>.NativeClassPtr, 100667600);
			float2x3.NativeMethodInfoPtr_op_Implicit_Public_Static_float2x3_int2x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float2x3>.NativeClassPtr, 100667601);
			float2x3.NativeMethodInfoPtr_op_Implicit_Public_Static_float2x3_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float2x3>.NativeClassPtr, 100667602);
			float2x3.NativeMethodInfoPtr_op_Implicit_Public_Static_float2x3_uint2x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float2x3>.NativeClassPtr, 100667603);
			float2x3.NativeMethodInfoPtr_op_Explicit_Public_Static_float2x3_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float2x3>.NativeClassPtr, 100667604);
			float2x3.NativeMethodInfoPtr_op_Explicit_Public_Static_float2x3_double2x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float2x3>.NativeClassPtr, 100667605);
			float2x3.NativeMethodInfoPtr_op_Multiply_Public_Static_float2x3_float2x3_float2x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float2x3>.NativeClassPtr, 100667606);
			float2x3.NativeMethodInfoPtr_op_Multiply_Public_Static_float2x3_float2x3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float2x3>.NativeClassPtr, 100667607);
			float2x3.NativeMethodInfoPtr_op_Multiply_Public_Static_float2x3_Single_float2x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float2x3>.NativeClassPtr, 100667608);
			float2x3.NativeMethodInfoPtr_op_Addition_Public_Static_float2x3_float2x3_float2x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float2x3>.NativeClassPtr, 100667609);
			float2x3.NativeMethodInfoPtr_op_Addition_Public_Static_float2x3_float2x3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float2x3>.NativeClassPtr, 100667610);
			float2x3.NativeMethodInfoPtr_op_Addition_Public_Static_float2x3_Single_float2x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float2x3>.NativeClassPtr, 100667611);
			float2x3.NativeMethodInfoPtr_op_Subtraction_Public_Static_float2x3_float2x3_float2x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float2x3>.NativeClassPtr, 100667612);
			float2x3.NativeMethodInfoPtr_op_Subtraction_Public_Static_float2x3_float2x3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float2x3>.NativeClassPtr, 100667613);
			float2x3.NativeMethodInfoPtr_op_Subtraction_Public_Static_float2x3_Single_float2x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float2x3>.NativeClassPtr, 100667614);
			float2x3.NativeMethodInfoPtr_op_Division_Public_Static_float2x3_float2x3_float2x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float2x3>.NativeClassPtr, 100667615);
			float2x3.NativeMethodInfoPtr_op_Division_Public_Static_float2x3_float2x3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float2x3>.NativeClassPtr, 100667616);
			float2x3.NativeMethodInfoPtr_op_Division_Public_Static_float2x3_Single_float2x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float2x3>.NativeClassPtr, 100667617);
			float2x3.NativeMethodInfoPtr_op_Modulus_Public_Static_float2x3_float2x3_float2x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float2x3>.NativeClassPtr, 100667618);
			float2x3.NativeMethodInfoPtr_op_Modulus_Public_Static_float2x3_float2x3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float2x3>.NativeClassPtr, 100667619);
			float2x3.NativeMethodInfoPtr_op_Modulus_Public_Static_float2x3_Single_float2x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float2x3>.NativeClassPtr, 100667620);
			float2x3.NativeMethodInfoPtr_op_Increment_Public_Static_float2x3_float2x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float2x3>.NativeClassPtr, 100667621);
			float2x3.NativeMethodInfoPtr_op_Decrement_Public_Static_float2x3_float2x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float2x3>.NativeClassPtr, 100667622);
			float2x3.NativeMethodInfoPtr_op_LessThan_Public_Static_bool2x3_float2x3_float2x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float2x3>.NativeClassPtr, 100667623);
			float2x3.NativeMethodInfoPtr_op_LessThan_Public_Static_bool2x3_float2x3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float2x3>.NativeClassPtr, 100667624);
			float2x3.NativeMethodInfoPtr_op_LessThan_Public_Static_bool2x3_Single_float2x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float2x3>.NativeClassPtr, 100667625);
			float2x3.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool2x3_float2x3_float2x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float2x3>.NativeClassPtr, 100667626);
			float2x3.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool2x3_float2x3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float2x3>.NativeClassPtr, 100667627);
			float2x3.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool2x3_Single_float2x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float2x3>.NativeClassPtr, 100667628);
			float2x3.NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool2x3_float2x3_float2x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float2x3>.NativeClassPtr, 100667629);
			float2x3.NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool2x3_float2x3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float2x3>.NativeClassPtr, 100667630);
			float2x3.NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool2x3_Single_float2x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float2x3>.NativeClassPtr, 100667631);
			float2x3.NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool2x3_float2x3_float2x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float2x3>.NativeClassPtr, 100667632);
			float2x3.NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool2x3_float2x3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float2x3>.NativeClassPtr, 100667633);
			float2x3.NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool2x3_Single_float2x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float2x3>.NativeClassPtr, 100667634);
			float2x3.NativeMethodInfoPtr_op_UnaryNegation_Public_Static_float2x3_float2x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float2x3>.NativeClassPtr, 100667635);
			float2x3.NativeMethodInfoPtr_op_UnaryPlus_Public_Static_float2x3_float2x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float2x3>.NativeClassPtr, 100667636);
			float2x3.NativeMethodInfoPtr_op_Equality_Public_Static_bool2x3_float2x3_float2x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float2x3>.NativeClassPtr, 100667637);
			float2x3.NativeMethodInfoPtr_op_Equality_Public_Static_bool2x3_float2x3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float2x3>.NativeClassPtr, 100667638);
			float2x3.NativeMethodInfoPtr_op_Equality_Public_Static_bool2x3_Single_float2x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float2x3>.NativeClassPtr, 100667639);
			float2x3.NativeMethodInfoPtr_op_Inequality_Public_Static_bool2x3_float2x3_float2x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float2x3>.NativeClassPtr, 100667640);
			float2x3.NativeMethodInfoPtr_op_Inequality_Public_Static_bool2x3_float2x3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float2x3>.NativeClassPtr, 100667641);
			float2x3.NativeMethodInfoPtr_op_Inequality_Public_Static_bool2x3_Single_float2x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float2x3>.NativeClassPtr, 100667642);
			float2x3.NativeMethodInfoPtr_get_Item_Public_get_byref_float2_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float2x3>.NativeClassPtr, 100667643);
			float2x3.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_float2x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float2x3>.NativeClassPtr, 100667644);
			float2x3.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float2x3>.NativeClassPtr, 100667645);
			float2x3.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float2x3>.NativeClassPtr, 100667646);
			float2x3.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float2x3>.NativeClassPtr, 100667647);
			float2x3.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float2x3>.NativeClassPtr, 100667648);
		}

		// Token: 0x06001142 RID: 4418 RVA: 0x0005E8E8 File Offset: 0x0005CAE8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 636842, RefRangeEnd = 636843, XrefRangeStart = 636842, XrefRangeEnd = 636842, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float2x3(float2 c0, float2 c1, float2 c2)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float2x3.NativeMethodInfoPtr__ctor_Public_Void_float2_float2_float2_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001143 RID: 4419 RVA: 0x0005E938 File Offset: 0x0005CB38
		[CallerCount(0)]
		public unsafe float2x3(float m00, float m01, float m02, float m10, float m11, float m12)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float2x3.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_Single_Single_Single_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001144 RID: 4420 RVA: 0x0005E9B0 File Offset: 0x0005CBB0
		[CallerCount(0)]
		public unsafe float2x3(float v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float2x3.NativeMethodInfoPtr__ctor_Public_Void_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001145 RID: 4421 RVA: 0x0005E9E4 File Offset: 0x0005CBE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 636843, XrefRangeEnd = 636844, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float2x3(bool v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float2x3.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001146 RID: 4422 RVA: 0x0005EA18 File Offset: 0x0005CC18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 636844, XrefRangeEnd = 636849, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float2x3(bool2x3 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float2x3.NativeMethodInfoPtr__ctor_Public_Void_bool2x3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001147 RID: 4423 RVA: 0x0005EA4C File Offset: 0x0005CC4C
		[CallerCount(0)]
		public unsafe float2x3(int v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float2x3.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001148 RID: 4424 RVA: 0x0005EA80 File Offset: 0x0005CC80
		[CallerCount(0)]
		public unsafe float2x3(int2x3 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float2x3.NativeMethodInfoPtr__ctor_Public_Void_int2x3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001149 RID: 4425 RVA: 0x0005EAB4 File Offset: 0x0005CCB4
		[CallerCount(0)]
		public unsafe float2x3(uint v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float2x3.NativeMethodInfoPtr__ctor_Public_Void_UInt32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600114A RID: 4426 RVA: 0x0005EAE8 File Offset: 0x0005CCE8
		[CallerCount(0)]
		public unsafe float2x3(uint2x3 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float2x3.NativeMethodInfoPtr__ctor_Public_Void_uint2x3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600114B RID: 4427 RVA: 0x0005EB1C File Offset: 0x0005CD1C
		[CallerCount(0)]
		public unsafe float2x3(double v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float2x3.NativeMethodInfoPtr__ctor_Public_Void_Double_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600114C RID: 4428 RVA: 0x0005EB50 File Offset: 0x0005CD50
		[CallerCount(0)]
		public unsafe float2x3(double2x3 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float2x3.NativeMethodInfoPtr__ctor_Public_Void_double2x3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600114D RID: 4429 RVA: 0x0005EB84 File Offset: 0x0005CD84
		[CallerCount(0)]
		public unsafe static implicit operator float2x3(float v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float2x3.NativeMethodInfoPtr_op_Implicit_Public_Static_float2x3_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600114E RID: 4430 RVA: 0x0005EBC4 File Offset: 0x0005CDC4
		[CallerCount(0)]
		public unsafe static explicit operator float2x3(bool v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float2x3.NativeMethodInfoPtr_op_Explicit_Public_Static_float2x3_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600114F RID: 4431 RVA: 0x0005EC04 File Offset: 0x0005CE04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator float2x3(bool2x3 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float2x3.NativeMethodInfoPtr_op_Explicit_Public_Static_float2x3_bool2x3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001150 RID: 4432 RVA: 0x0005EC44 File Offset: 0x0005CE44
		[CallerCount(0)]
		public unsafe static implicit operator float2x3(int v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float2x3.NativeMethodInfoPtr_op_Implicit_Public_Static_float2x3_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001151 RID: 4433 RVA: 0x0005EC84 File Offset: 0x0005CE84
		[CallerCount(0)]
		public unsafe static implicit operator float2x3(int2x3 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float2x3.NativeMethodInfoPtr_op_Implicit_Public_Static_float2x3_int2x3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001152 RID: 4434 RVA: 0x0005ECC4 File Offset: 0x0005CEC4
		[CallerCount(0)]
		public unsafe static implicit operator float2x3(uint v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float2x3.NativeMethodInfoPtr_op_Implicit_Public_Static_float2x3_UInt32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001153 RID: 4435 RVA: 0x0005ED04 File Offset: 0x0005CF04
		[CallerCount(0)]
		public unsafe static implicit operator float2x3(uint2x3 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float2x3.NativeMethodInfoPtr_op_Implicit_Public_Static_float2x3_uint2x3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001154 RID: 4436 RVA: 0x0005ED44 File Offset: 0x0005CF44
		[CallerCount(0)]
		public unsafe static explicit operator float2x3(double v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float2x3.NativeMethodInfoPtr_op_Explicit_Public_Static_float2x3_Double_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001155 RID: 4437 RVA: 0x0005ED84 File Offset: 0x0005CF84
		[CallerCount(0)]
		public unsafe static explicit operator float2x3(double2x3 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float2x3.NativeMethodInfoPtr_op_Explicit_Public_Static_float2x3_double2x3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001156 RID: 4438 RVA: 0x0005EDC4 File Offset: 0x0005CFC4
		[CallerCount(0)]
		public unsafe static float2x3 operator *(float2x3 lhs, float2x3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float2x3.NativeMethodInfoPtr_op_Multiply_Public_Static_float2x3_float2x3_float2x3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001157 RID: 4439 RVA: 0x0005EE10 File Offset: 0x0005D010
		[CallerCount(0)]
		public unsafe static float2x3 operator *(float2x3 lhs, float rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float2x3.NativeMethodInfoPtr_op_Multiply_Public_Static_float2x3_float2x3_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001158 RID: 4440 RVA: 0x0005EE5C File Offset: 0x0005D05C
		[CallerCount(0)]
		public unsafe static float2x3 operator *(float lhs, float2x3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float2x3.NativeMethodInfoPtr_op_Multiply_Public_Static_float2x3_Single_float2x3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001159 RID: 4441 RVA: 0x0005EEA8 File Offset: 0x0005D0A8
		[CallerCount(0)]
		public unsafe static float2x3 operator +(float2x3 lhs, float2x3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float2x3.NativeMethodInfoPtr_op_Addition_Public_Static_float2x3_float2x3_float2x3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600115A RID: 4442 RVA: 0x0005EEF4 File Offset: 0x0005D0F4
		[CallerCount(0)]
		public unsafe static float2x3 operator +(float2x3 lhs, float rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float2x3.NativeMethodInfoPtr_op_Addition_Public_Static_float2x3_float2x3_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600115B RID: 4443 RVA: 0x0005EF40 File Offset: 0x0005D140
		[CallerCount(0)]
		public unsafe static float2x3 operator +(float lhs, float2x3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float2x3.NativeMethodInfoPtr_op_Addition_Public_Static_float2x3_Single_float2x3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600115C RID: 4444 RVA: 0x0005EF8C File Offset: 0x0005D18C
		[CallerCount(0)]
		public unsafe static float2x3 operator -(float2x3 lhs, float2x3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float2x3.NativeMethodInfoPtr_op_Subtraction_Public_Static_float2x3_float2x3_float2x3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600115D RID: 4445 RVA: 0x0005EFD8 File Offset: 0x0005D1D8
		[CallerCount(0)]
		public unsafe static float2x3 operator -(float2x3 lhs, float rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float2x3.NativeMethodInfoPtr_op_Subtraction_Public_Static_float2x3_float2x3_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600115E RID: 4446 RVA: 0x0005F024 File Offset: 0x0005D224
		[CallerCount(0)]
		public unsafe static float2x3 operator -(float lhs, float2x3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float2x3.NativeMethodInfoPtr_op_Subtraction_Public_Static_float2x3_Single_float2x3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600115F RID: 4447 RVA: 0x0005F070 File Offset: 0x0005D270
		[CallerCount(0)]
		public unsafe static float2x3 operator /(float2x3 lhs, float2x3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float2x3.NativeMethodInfoPtr_op_Division_Public_Static_float2x3_float2x3_float2x3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001160 RID: 4448 RVA: 0x0005F0BC File Offset: 0x0005D2BC
		[CallerCount(0)]
		public unsafe static float2x3 operator /(float2x3 lhs, float rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float2x3.NativeMethodInfoPtr_op_Division_Public_Static_float2x3_float2x3_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001161 RID: 4449 RVA: 0x0005F108 File Offset: 0x0005D308
		[CallerCount(0)]
		public unsafe static float2x3 operator /(float lhs, float2x3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float2x3.NativeMethodInfoPtr_op_Division_Public_Static_float2x3_Single_float2x3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001162 RID: 4450 RVA: 0x0005F154 File Offset: 0x0005D354
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 636849, XrefRangeEnd = 636855, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float2x3 operator %(float2x3 lhs, float2x3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float2x3.NativeMethodInfoPtr_op_Modulus_Public_Static_float2x3_float2x3_float2x3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001163 RID: 4451 RVA: 0x0005F1A0 File Offset: 0x0005D3A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 636855, XrefRangeEnd = 636861, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float2x3 operator %(float2x3 lhs, float rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float2x3.NativeMethodInfoPtr_op_Modulus_Public_Static_float2x3_float2x3_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001164 RID: 4452 RVA: 0x0005F1EC File Offset: 0x0005D3EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 636861, XrefRangeEnd = 636867, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float2x3 operator %(float lhs, float2x3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float2x3.NativeMethodInfoPtr_op_Modulus_Public_Static_float2x3_Single_float2x3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001165 RID: 4453 RVA: 0x0005F238 File Offset: 0x0005D438
		[CallerCount(0)]
		public unsafe static float2x3 operator ++(float2x3 val)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float2x3.NativeMethodInfoPtr_op_Increment_Public_Static_float2x3_float2x3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001166 RID: 4454 RVA: 0x0005F278 File Offset: 0x0005D478
		[CallerCount(0)]
		public unsafe static float2x3 operator --(float2x3 val)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float2x3.NativeMethodInfoPtr_op_Decrement_Public_Static_float2x3_float2x3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001167 RID: 4455 RVA: 0x0005F2B8 File Offset: 0x0005D4B8
		[CallerCount(0)]
		public unsafe static bool2x3 operator <(float2x3 lhs, float2x3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float2x3.NativeMethodInfoPtr_op_LessThan_Public_Static_bool2x3_float2x3_float2x3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001168 RID: 4456 RVA: 0x0005F304 File Offset: 0x0005D504
		[CallerCount(0)]
		public unsafe static bool2x3 operator <(float2x3 lhs, float rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float2x3.NativeMethodInfoPtr_op_LessThan_Public_Static_bool2x3_float2x3_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001169 RID: 4457 RVA: 0x0005F350 File Offset: 0x0005D550
		[CallerCount(0)]
		public unsafe static bool2x3 operator <(float lhs, float2x3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float2x3.NativeMethodInfoPtr_op_LessThan_Public_Static_bool2x3_Single_float2x3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600116A RID: 4458 RVA: 0x0005F39C File Offset: 0x0005D59C
		[CallerCount(0)]
		public unsafe static bool2x3 operator <=(float2x3 lhs, float2x3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float2x3.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool2x3_float2x3_float2x3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600116B RID: 4459 RVA: 0x0005F3E8 File Offset: 0x0005D5E8
		[CallerCount(0)]
		public unsafe static bool2x3 operator <=(float2x3 lhs, float rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float2x3.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool2x3_float2x3_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600116C RID: 4460 RVA: 0x0005F434 File Offset: 0x0005D634
		[CallerCount(0)]
		public unsafe static bool2x3 operator <=(float lhs, float2x3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float2x3.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool2x3_Single_float2x3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600116D RID: 4461 RVA: 0x0005F480 File Offset: 0x0005D680
		[CallerCount(0)]
		public unsafe static bool2x3 operator >(float2x3 lhs, float2x3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float2x3.NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool2x3_float2x3_float2x3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600116E RID: 4462 RVA: 0x0005F4CC File Offset: 0x0005D6CC
		[CallerCount(0)]
		public unsafe static bool2x3 operator >(float2x3 lhs, float rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float2x3.NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool2x3_float2x3_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600116F RID: 4463 RVA: 0x0005F518 File Offset: 0x0005D718
		[CallerCount(0)]
		public unsafe static bool2x3 operator >(float lhs, float2x3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float2x3.NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool2x3_Single_float2x3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001170 RID: 4464 RVA: 0x0005F564 File Offset: 0x0005D764
		[CallerCount(0)]
		public unsafe static bool2x3 operator >=(float2x3 lhs, float2x3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float2x3.NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool2x3_float2x3_float2x3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001171 RID: 4465 RVA: 0x0005F5B0 File Offset: 0x0005D7B0
		[CallerCount(0)]
		public unsafe static bool2x3 operator >=(float2x3 lhs, float rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float2x3.NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool2x3_float2x3_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001172 RID: 4466 RVA: 0x0005F5FC File Offset: 0x0005D7FC
		[CallerCount(0)]
		public unsafe static bool2x3 operator >=(float lhs, float2x3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float2x3.NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool2x3_Single_float2x3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001173 RID: 4467 RVA: 0x0005F648 File Offset: 0x0005D848
		[CallerCount(0)]
		public unsafe static float2x3 operator -(float2x3 val)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float2x3.NativeMethodInfoPtr_op_UnaryNegation_Public_Static_float2x3_float2x3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001174 RID: 4468 RVA: 0x0005F688 File Offset: 0x0005D888
		[CallerCount(0)]
		public unsafe static float2x3 operator +(float2x3 val)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float2x3.NativeMethodInfoPtr_op_UnaryPlus_Public_Static_float2x3_float2x3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001175 RID: 4469 RVA: 0x0005F6C8 File Offset: 0x0005D8C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 636867, XrefRangeEnd = 636873, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool2x3 operator ==(float2x3 lhs, float2x3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float2x3.NativeMethodInfoPtr_op_Equality_Public_Static_bool2x3_float2x3_float2x3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001176 RID: 4470 RVA: 0x0005F714 File Offset: 0x0005D914
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 636873, XrefRangeEnd = 636879, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool2x3 operator ==(float2x3 lhs, float rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float2x3.NativeMethodInfoPtr_op_Equality_Public_Static_bool2x3_float2x3_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001177 RID: 4471 RVA: 0x0005F760 File Offset: 0x0005D960
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 636879, XrefRangeEnd = 636885, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool2x3 operator ==(float lhs, float2x3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float2x3.NativeMethodInfoPtr_op_Equality_Public_Static_bool2x3_Single_float2x3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001178 RID: 4472 RVA: 0x0005F7AC File Offset: 0x0005D9AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 636885, XrefRangeEnd = 636891, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool2x3 operator !=(float2x3 lhs, float2x3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float2x3.NativeMethodInfoPtr_op_Inequality_Public_Static_bool2x3_float2x3_float2x3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001179 RID: 4473 RVA: 0x0005F7F8 File Offset: 0x0005D9F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 636891, XrefRangeEnd = 636897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool2x3 operator !=(float2x3 lhs, float rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float2x3.NativeMethodInfoPtr_op_Inequality_Public_Static_bool2x3_float2x3_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600117A RID: 4474 RVA: 0x0005F844 File Offset: 0x0005DA44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 636897, XrefRangeEnd = 636903, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool2x3 operator !=(float lhs, float2x3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float2x3.NativeMethodInfoPtr_op_Inequality_Public_Static_bool2x3_Single_float2x3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000422 RID: 1058
		public unsafe ref float2 this[int index]
		{
			[CallerCount(0)]
			get
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref index;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float2x3.NativeMethodInfoPtr_get_Item_Public_get_byref_float2_Int32_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return intPtr;
				}
			}
		}

		// Token: 0x0600117C RID: 4476 RVA: 0x0005F8C4 File Offset: 0x0005DAC4
		[CallerCount(0)]
		public unsafe bool Equals(float2x3 rhs)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref rhs;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float2x3.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_float2x3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600117D RID: 4477 RVA: 0x0005F904 File Offset: 0x0005DB04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 636903, XrefRangeEnd = 636906, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object o)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(o);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float2x3.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600117E RID: 4478 RVA: 0x0005F948 File Offset: 0x0005DB48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 636906, XrefRangeEnd = 636907, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float2x3.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600117F RID: 4479 RVA: 0x0005F978 File Offset: 0x0005DB78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 636907, XrefRangeEnd = 636938, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float2x3.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001180 RID: 4480 RVA: 0x0005F9A4 File Offset: 0x0005DBA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 636938, XrefRangeEnd = 636976, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float2x3.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001181 RID: 4481 RVA: 0x000024A8 File Offset: 0x000006A8
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<float2x3>.NativeClassPtr, ref this));
		}

		// Token: 0x17000421 RID: 1057
		// (get) Token: 0x06001182 RID: 4482 RVA: 0x0005F9F4 File Offset: 0x0005DBF4
		// (set) Token: 0x06001183 RID: 4483 RVA: 0x000024BA File Offset: 0x000006BA
		public unsafe static float2x3 zero
		{
			get
			{
				float2x3 float2x;
				IL2CPP.il2cpp_field_static_get_value(float2x3.NativeFieldInfoPtr_zero, (void*)(&float2x));
				return float2x;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(float2x3.NativeFieldInfoPtr_zero, (void*)(&value));
			}
		}

		// Token: 0x04001177 RID: 4471
		private static readonly IntPtr NativeFieldInfoPtr_c0;

		// Token: 0x04001178 RID: 4472
		private static readonly IntPtr NativeFieldInfoPtr_c1;

		// Token: 0x04001179 RID: 4473
		private static readonly IntPtr NativeFieldInfoPtr_c2;

		// Token: 0x0400117A RID: 4474
		private static readonly IntPtr NativeFieldInfoPtr_zero;

		// Token: 0x0400117B RID: 4475
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_float2_float2_float2_0;

		// Token: 0x0400117C RID: 4476
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_Single_Single_Single_0;

		// Token: 0x0400117D RID: 4477
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_0;

		// Token: 0x0400117E RID: 4478
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_0;

		// Token: 0x0400117F RID: 4479
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_bool2x3_0;

		// Token: 0x04001180 RID: 4480
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x04001181 RID: 4481
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_int2x3_0;

		// Token: 0x04001182 RID: 4482
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_UInt32_0;

		// Token: 0x04001183 RID: 4483
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_uint2x3_0;

		// Token: 0x04001184 RID: 4484
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Double_0;

		// Token: 0x04001185 RID: 4485
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_double2x3_0;

		// Token: 0x04001186 RID: 4486
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_float2x3_Single_0;

		// Token: 0x04001187 RID: 4487
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_float2x3_Boolean_0;

		// Token: 0x04001188 RID: 4488
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_float2x3_bool2x3_0;

		// Token: 0x04001189 RID: 4489
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_float2x3_Int32_0;

		// Token: 0x0400118A RID: 4490
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_float2x3_int2x3_0;

		// Token: 0x0400118B RID: 4491
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_float2x3_UInt32_0;

		// Token: 0x0400118C RID: 4492
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_float2x3_uint2x3_0;

		// Token: 0x0400118D RID: 4493
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_float2x3_Double_0;

		// Token: 0x0400118E RID: 4494
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_float2x3_double2x3_0;

		// Token: 0x0400118F RID: 4495
		private static readonly IntPtr NativeMethodInfoPtr_op_Multiply_Public_Static_float2x3_float2x3_float2x3_0;

		// Token: 0x04001190 RID: 4496
		private static readonly IntPtr NativeMethodInfoPtr_op_Multiply_Public_Static_float2x3_float2x3_Single_0;

		// Token: 0x04001191 RID: 4497
		private static readonly IntPtr NativeMethodInfoPtr_op_Multiply_Public_Static_float2x3_Single_float2x3_0;

		// Token: 0x04001192 RID: 4498
		private static readonly IntPtr NativeMethodInfoPtr_op_Addition_Public_Static_float2x3_float2x3_float2x3_0;

		// Token: 0x04001193 RID: 4499
		private static readonly IntPtr NativeMethodInfoPtr_op_Addition_Public_Static_float2x3_float2x3_Single_0;

		// Token: 0x04001194 RID: 4500
		private static readonly IntPtr NativeMethodInfoPtr_op_Addition_Public_Static_float2x3_Single_float2x3_0;

		// Token: 0x04001195 RID: 4501
		private static readonly IntPtr NativeMethodInfoPtr_op_Subtraction_Public_Static_float2x3_float2x3_float2x3_0;

		// Token: 0x04001196 RID: 4502
		private static readonly IntPtr NativeMethodInfoPtr_op_Subtraction_Public_Static_float2x3_float2x3_Single_0;

		// Token: 0x04001197 RID: 4503
		private static readonly IntPtr NativeMethodInfoPtr_op_Subtraction_Public_Static_float2x3_Single_float2x3_0;

		// Token: 0x04001198 RID: 4504
		private static readonly IntPtr NativeMethodInfoPtr_op_Division_Public_Static_float2x3_float2x3_float2x3_0;

		// Token: 0x04001199 RID: 4505
		private static readonly IntPtr NativeMethodInfoPtr_op_Division_Public_Static_float2x3_float2x3_Single_0;

		// Token: 0x0400119A RID: 4506
		private static readonly IntPtr NativeMethodInfoPtr_op_Division_Public_Static_float2x3_Single_float2x3_0;

		// Token: 0x0400119B RID: 4507
		private static readonly IntPtr NativeMethodInfoPtr_op_Modulus_Public_Static_float2x3_float2x3_float2x3_0;

		// Token: 0x0400119C RID: 4508
		private static readonly IntPtr NativeMethodInfoPtr_op_Modulus_Public_Static_float2x3_float2x3_Single_0;

		// Token: 0x0400119D RID: 4509
		private static readonly IntPtr NativeMethodInfoPtr_op_Modulus_Public_Static_float2x3_Single_float2x3_0;

		// Token: 0x0400119E RID: 4510
		private static readonly IntPtr NativeMethodInfoPtr_op_Increment_Public_Static_float2x3_float2x3_0;

		// Token: 0x0400119F RID: 4511
		private static readonly IntPtr NativeMethodInfoPtr_op_Decrement_Public_Static_float2x3_float2x3_0;

		// Token: 0x040011A0 RID: 4512
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThan_Public_Static_bool2x3_float2x3_float2x3_0;

		// Token: 0x040011A1 RID: 4513
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThan_Public_Static_bool2x3_float2x3_Single_0;

		// Token: 0x040011A2 RID: 4514
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThan_Public_Static_bool2x3_Single_float2x3_0;

		// Token: 0x040011A3 RID: 4515
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool2x3_float2x3_float2x3_0;

		// Token: 0x040011A4 RID: 4516
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool2x3_float2x3_Single_0;

		// Token: 0x040011A5 RID: 4517
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool2x3_Single_float2x3_0;

		// Token: 0x040011A6 RID: 4518
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool2x3_float2x3_float2x3_0;

		// Token: 0x040011A7 RID: 4519
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool2x3_float2x3_Single_0;

		// Token: 0x040011A8 RID: 4520
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool2x3_Single_float2x3_0;

		// Token: 0x040011A9 RID: 4521
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool2x3_float2x3_float2x3_0;

		// Token: 0x040011AA RID: 4522
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool2x3_float2x3_Single_0;

		// Token: 0x040011AB RID: 4523
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool2x3_Single_float2x3_0;

		// Token: 0x040011AC RID: 4524
		private static readonly IntPtr NativeMethodInfoPtr_op_UnaryNegation_Public_Static_float2x3_float2x3_0;

		// Token: 0x040011AD RID: 4525
		private static readonly IntPtr NativeMethodInfoPtr_op_UnaryPlus_Public_Static_float2x3_float2x3_0;

		// Token: 0x040011AE RID: 4526
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_bool2x3_float2x3_float2x3_0;

		// Token: 0x040011AF RID: 4527
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_bool2x3_float2x3_Single_0;

		// Token: 0x040011B0 RID: 4528
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_bool2x3_Single_float2x3_0;

		// Token: 0x040011B1 RID: 4529
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_bool2x3_float2x3_float2x3_0;

		// Token: 0x040011B2 RID: 4530
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_bool2x3_float2x3_Single_0;

		// Token: 0x040011B3 RID: 4531
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_bool2x3_Single_float2x3_0;

		// Token: 0x040011B4 RID: 4532
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_get_byref_float2_Int32_0;

		// Token: 0x040011B5 RID: 4533
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_float2x3_0;

		// Token: 0x040011B6 RID: 4534
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x040011B7 RID: 4535
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x040011B8 RID: 4536
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x040011B9 RID: 4537
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0;

		// Token: 0x040011BA RID: 4538
		[FieldOffset(0)]
		public float2 c0;

		// Token: 0x040011BB RID: 4539
		[FieldOffset(8)]
		public float2 c1;

		// Token: 0x040011BC RID: 4540
		[FieldOffset(16)]
		public float2 c2;
	}
}
