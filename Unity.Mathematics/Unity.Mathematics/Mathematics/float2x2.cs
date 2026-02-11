using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Unity.Mathematics
{
	// Token: 0x0200001E RID: 30
	[Serializable]
	[StructLayout(2)]
	public struct float2x2
	{
		// Token: 0x060010F8 RID: 4344 RVA: 0x0005CB9C File Offset: 0x0005AD9C
		// Note: this type is marked as 'beforefieldinit'.
		static float2x2()
		{
			Il2CppClassPointerStore<float2x2>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Mathematics.dll", "Unity.Mathematics", "float2x2");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<float2x2>.NativeClassPtr);
			float2x2.NativeFieldInfoPtr_c0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<float2x2>.NativeClassPtr, "c0");
			float2x2.NativeFieldInfoPtr_c1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<float2x2>.NativeClassPtr, "c1");
			float2x2.NativeFieldInfoPtr_identity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<float2x2>.NativeClassPtr, "identity");
			float2x2.NativeFieldInfoPtr_zero = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<float2x2>.NativeClassPtr, "zero");
			float2x2.NativeMethodInfoPtr__ctor_Public_Void_float2_float2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float2x2>.NativeClassPtr, 100667518);
			float2x2.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float2x2>.NativeClassPtr, 100667519);
			float2x2.NativeMethodInfoPtr__ctor_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float2x2>.NativeClassPtr, 100667520);
			float2x2.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float2x2>.NativeClassPtr, 100667521);
			float2x2.NativeMethodInfoPtr__ctor_Public_Void_bool2x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float2x2>.NativeClassPtr, 100667522);
			float2x2.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float2x2>.NativeClassPtr, 100667523);
			float2x2.NativeMethodInfoPtr__ctor_Public_Void_int2x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float2x2>.NativeClassPtr, 100667524);
			float2x2.NativeMethodInfoPtr__ctor_Public_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float2x2>.NativeClassPtr, 100667525);
			float2x2.NativeMethodInfoPtr__ctor_Public_Void_uint2x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float2x2>.NativeClassPtr, 100667526);
			float2x2.NativeMethodInfoPtr__ctor_Public_Void_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float2x2>.NativeClassPtr, 100667527);
			float2x2.NativeMethodInfoPtr__ctor_Public_Void_double2x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float2x2>.NativeClassPtr, 100667528);
			float2x2.NativeMethodInfoPtr_op_Implicit_Public_Static_float2x2_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float2x2>.NativeClassPtr, 100667529);
			float2x2.NativeMethodInfoPtr_op_Explicit_Public_Static_float2x2_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float2x2>.NativeClassPtr, 100667530);
			float2x2.NativeMethodInfoPtr_op_Explicit_Public_Static_float2x2_bool2x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float2x2>.NativeClassPtr, 100667531);
			float2x2.NativeMethodInfoPtr_op_Implicit_Public_Static_float2x2_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float2x2>.NativeClassPtr, 100667532);
			float2x2.NativeMethodInfoPtr_op_Implicit_Public_Static_float2x2_int2x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float2x2>.NativeClassPtr, 100667533);
			float2x2.NativeMethodInfoPtr_op_Implicit_Public_Static_float2x2_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float2x2>.NativeClassPtr, 100667534);
			float2x2.NativeMethodInfoPtr_op_Implicit_Public_Static_float2x2_uint2x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float2x2>.NativeClassPtr, 100667535);
			float2x2.NativeMethodInfoPtr_op_Explicit_Public_Static_float2x2_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float2x2>.NativeClassPtr, 100667536);
			float2x2.NativeMethodInfoPtr_op_Explicit_Public_Static_float2x2_double2x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float2x2>.NativeClassPtr, 100667537);
			float2x2.NativeMethodInfoPtr_op_Multiply_Public_Static_float2x2_float2x2_float2x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float2x2>.NativeClassPtr, 100667538);
			float2x2.NativeMethodInfoPtr_op_Multiply_Public_Static_float2x2_float2x2_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float2x2>.NativeClassPtr, 100667539);
			float2x2.NativeMethodInfoPtr_op_Multiply_Public_Static_float2x2_Single_float2x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float2x2>.NativeClassPtr, 100667540);
			float2x2.NativeMethodInfoPtr_op_Addition_Public_Static_float2x2_float2x2_float2x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float2x2>.NativeClassPtr, 100667541);
			float2x2.NativeMethodInfoPtr_op_Addition_Public_Static_float2x2_float2x2_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float2x2>.NativeClassPtr, 100667542);
			float2x2.NativeMethodInfoPtr_op_Addition_Public_Static_float2x2_Single_float2x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float2x2>.NativeClassPtr, 100667543);
			float2x2.NativeMethodInfoPtr_op_Subtraction_Public_Static_float2x2_float2x2_float2x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float2x2>.NativeClassPtr, 100667544);
			float2x2.NativeMethodInfoPtr_op_Subtraction_Public_Static_float2x2_float2x2_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float2x2>.NativeClassPtr, 100667545);
			float2x2.NativeMethodInfoPtr_op_Subtraction_Public_Static_float2x2_Single_float2x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float2x2>.NativeClassPtr, 100667546);
			float2x2.NativeMethodInfoPtr_op_Division_Public_Static_float2x2_float2x2_float2x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float2x2>.NativeClassPtr, 100667547);
			float2x2.NativeMethodInfoPtr_op_Division_Public_Static_float2x2_float2x2_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float2x2>.NativeClassPtr, 100667548);
			float2x2.NativeMethodInfoPtr_op_Division_Public_Static_float2x2_Single_float2x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float2x2>.NativeClassPtr, 100667549);
			float2x2.NativeMethodInfoPtr_op_Modulus_Public_Static_float2x2_float2x2_float2x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float2x2>.NativeClassPtr, 100667550);
			float2x2.NativeMethodInfoPtr_op_Modulus_Public_Static_float2x2_float2x2_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float2x2>.NativeClassPtr, 100667551);
			float2x2.NativeMethodInfoPtr_op_Modulus_Public_Static_float2x2_Single_float2x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float2x2>.NativeClassPtr, 100667552);
			float2x2.NativeMethodInfoPtr_op_Increment_Public_Static_float2x2_float2x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float2x2>.NativeClassPtr, 100667553);
			float2x2.NativeMethodInfoPtr_op_Decrement_Public_Static_float2x2_float2x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float2x2>.NativeClassPtr, 100667554);
			float2x2.NativeMethodInfoPtr_op_LessThan_Public_Static_bool2x2_float2x2_float2x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float2x2>.NativeClassPtr, 100667555);
			float2x2.NativeMethodInfoPtr_op_LessThan_Public_Static_bool2x2_float2x2_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float2x2>.NativeClassPtr, 100667556);
			float2x2.NativeMethodInfoPtr_op_LessThan_Public_Static_bool2x2_Single_float2x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float2x2>.NativeClassPtr, 100667557);
			float2x2.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool2x2_float2x2_float2x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float2x2>.NativeClassPtr, 100667558);
			float2x2.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool2x2_float2x2_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float2x2>.NativeClassPtr, 100667559);
			float2x2.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool2x2_Single_float2x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float2x2>.NativeClassPtr, 100667560);
			float2x2.NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool2x2_float2x2_float2x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float2x2>.NativeClassPtr, 100667561);
			float2x2.NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool2x2_float2x2_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float2x2>.NativeClassPtr, 100667562);
			float2x2.NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool2x2_Single_float2x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float2x2>.NativeClassPtr, 100667563);
			float2x2.NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool2x2_float2x2_float2x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float2x2>.NativeClassPtr, 100667564);
			float2x2.NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool2x2_float2x2_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float2x2>.NativeClassPtr, 100667565);
			float2x2.NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool2x2_Single_float2x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float2x2>.NativeClassPtr, 100667566);
			float2x2.NativeMethodInfoPtr_op_UnaryNegation_Public_Static_float2x2_float2x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float2x2>.NativeClassPtr, 100667567);
			float2x2.NativeMethodInfoPtr_op_UnaryPlus_Public_Static_float2x2_float2x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float2x2>.NativeClassPtr, 100667568);
			float2x2.NativeMethodInfoPtr_op_Equality_Public_Static_bool2x2_float2x2_float2x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float2x2>.NativeClassPtr, 100667569);
			float2x2.NativeMethodInfoPtr_op_Equality_Public_Static_bool2x2_float2x2_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float2x2>.NativeClassPtr, 100667570);
			float2x2.NativeMethodInfoPtr_op_Equality_Public_Static_bool2x2_Single_float2x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float2x2>.NativeClassPtr, 100667571);
			float2x2.NativeMethodInfoPtr_op_Inequality_Public_Static_bool2x2_float2x2_float2x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float2x2>.NativeClassPtr, 100667572);
			float2x2.NativeMethodInfoPtr_op_Inequality_Public_Static_bool2x2_float2x2_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float2x2>.NativeClassPtr, 100667573);
			float2x2.NativeMethodInfoPtr_op_Inequality_Public_Static_bool2x2_Single_float2x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float2x2>.NativeClassPtr, 100667574);
			float2x2.NativeMethodInfoPtr_get_Item_Public_get_byref_float2_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float2x2>.NativeClassPtr, 100667575);
			float2x2.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_float2x2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float2x2>.NativeClassPtr, 100667576);
			float2x2.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float2x2>.NativeClassPtr, 100667577);
			float2x2.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float2x2>.NativeClassPtr, 100667578);
			float2x2.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float2x2>.NativeClassPtr, 100667579);
			float2x2.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float2x2>.NativeClassPtr, 100667580);
			float2x2.NativeMethodInfoPtr_Rotate_Public_Static_float2x2_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float2x2>.NativeClassPtr, 100667581);
			float2x2.NativeMethodInfoPtr_Scale_Public_Static_float2x2_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float2x2>.NativeClassPtr, 100667582);
			float2x2.NativeMethodInfoPtr_Scale_Public_Static_float2x2_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float2x2>.NativeClassPtr, 100667583);
			float2x2.NativeMethodInfoPtr_Scale_Public_Static_float2x2_float2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float2x2>.NativeClassPtr, 100667584);
		}

		// Token: 0x060010F9 RID: 4345 RVA: 0x0005D158 File Offset: 0x0005B358
		[CallerCount(21)]
		[CachedScanResults(RefRangeStart = 636721, RefRangeEnd = 636742, XrefRangeStart = 636721, XrefRangeEnd = 636721, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float2x2(float2 c0, float2 c1)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref c0;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref c1;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float2x2.NativeMethodInfoPtr__ctor_Public_Void_float2_float2_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010FA RID: 4346 RVA: 0x0005D198 File Offset: 0x0005B398
		[CallerCount(0)]
		public unsafe float2x2(float m00, float m01, float m10, float m11)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref m00;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref m01;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref m10;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref m11;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float2x2.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_Single_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010FB RID: 4347 RVA: 0x0005D1F4 File Offset: 0x0005B3F4
		[CallerCount(0)]
		public unsafe float2x2(float v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float2x2.NativeMethodInfoPtr__ctor_Public_Void_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060010FC RID: 4348 RVA: 0x0005D228 File Offset: 0x0005B428
		[CallerCount(0)]
		public unsafe float2x2(bool v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float2x2.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060010FD RID: 4349 RVA: 0x0005D25C File Offset: 0x0005B45C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 636742, XrefRangeEnd = 636745, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float2x2(bool2x2 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float2x2.NativeMethodInfoPtr__ctor_Public_Void_bool2x2_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060010FE RID: 4350 RVA: 0x0005D290 File Offset: 0x0005B490
		[CallerCount(0)]
		public unsafe float2x2(int v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float2x2.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060010FF RID: 4351 RVA: 0x0005D2C4 File Offset: 0x0005B4C4
		[CallerCount(0)]
		public unsafe float2x2(int2x2 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float2x2.NativeMethodInfoPtr__ctor_Public_Void_int2x2_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001100 RID: 4352 RVA: 0x0005D2F8 File Offset: 0x0005B4F8
		[CallerCount(0)]
		public unsafe float2x2(uint v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float2x2.NativeMethodInfoPtr__ctor_Public_Void_UInt32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001101 RID: 4353 RVA: 0x0005D32C File Offset: 0x0005B52C
		[CallerCount(0)]
		public unsafe float2x2(uint2x2 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float2x2.NativeMethodInfoPtr__ctor_Public_Void_uint2x2_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001102 RID: 4354 RVA: 0x0005D360 File Offset: 0x0005B560
		[CallerCount(0)]
		public unsafe float2x2(double v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float2x2.NativeMethodInfoPtr__ctor_Public_Void_Double_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001103 RID: 4355 RVA: 0x0005D394 File Offset: 0x0005B594
		[CallerCount(0)]
		public unsafe float2x2(double2x2 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float2x2.NativeMethodInfoPtr__ctor_Public_Void_double2x2_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001104 RID: 4356 RVA: 0x0005D3C8 File Offset: 0x0005B5C8
		[CallerCount(0)]
		public unsafe static implicit operator float2x2(float v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float2x2.NativeMethodInfoPtr_op_Implicit_Public_Static_float2x2_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001105 RID: 4357 RVA: 0x0005D408 File Offset: 0x0005B608
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator float2x2(bool v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float2x2.NativeMethodInfoPtr_op_Explicit_Public_Static_float2x2_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001106 RID: 4358 RVA: 0x0005D448 File Offset: 0x0005B648
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator float2x2(bool2x2 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float2x2.NativeMethodInfoPtr_op_Explicit_Public_Static_float2x2_bool2x2_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001107 RID: 4359 RVA: 0x0005D488 File Offset: 0x0005B688
		[CallerCount(0)]
		public unsafe static implicit operator float2x2(int v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float2x2.NativeMethodInfoPtr_op_Implicit_Public_Static_float2x2_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001108 RID: 4360 RVA: 0x0005D4C8 File Offset: 0x0005B6C8
		[CallerCount(0)]
		public unsafe static implicit operator float2x2(int2x2 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float2x2.NativeMethodInfoPtr_op_Implicit_Public_Static_float2x2_int2x2_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001109 RID: 4361 RVA: 0x0005D508 File Offset: 0x0005B708
		[CallerCount(0)]
		public unsafe static implicit operator float2x2(uint v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float2x2.NativeMethodInfoPtr_op_Implicit_Public_Static_float2x2_UInt32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600110A RID: 4362 RVA: 0x0005D548 File Offset: 0x0005B748
		[CallerCount(0)]
		public unsafe static implicit operator float2x2(uint2x2 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float2x2.NativeMethodInfoPtr_op_Implicit_Public_Static_float2x2_uint2x2_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600110B RID: 4363 RVA: 0x0005D588 File Offset: 0x0005B788
		[CallerCount(0)]
		public unsafe static explicit operator float2x2(double v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float2x2.NativeMethodInfoPtr_op_Explicit_Public_Static_float2x2_Double_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600110C RID: 4364 RVA: 0x0005D5C8 File Offset: 0x0005B7C8
		[CallerCount(0)]
		public unsafe static explicit operator float2x2(double2x2 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float2x2.NativeMethodInfoPtr_op_Explicit_Public_Static_float2x2_double2x2_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600110D RID: 4365 RVA: 0x0005D608 File Offset: 0x0005B808
		[CallerCount(0)]
		public unsafe static float2x2 operator *(float2x2 lhs, float2x2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float2x2.NativeMethodInfoPtr_op_Multiply_Public_Static_float2x2_float2x2_float2x2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600110E RID: 4366 RVA: 0x0005D654 File Offset: 0x0005B854
		[CallerCount(0)]
		public unsafe static float2x2 operator *(float2x2 lhs, float rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float2x2.NativeMethodInfoPtr_op_Multiply_Public_Static_float2x2_float2x2_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600110F RID: 4367 RVA: 0x0005D6A0 File Offset: 0x0005B8A0
		[CallerCount(0)]
		public unsafe static float2x2 operator *(float lhs, float2x2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float2x2.NativeMethodInfoPtr_op_Multiply_Public_Static_float2x2_Single_float2x2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001110 RID: 4368 RVA: 0x0005D6EC File Offset: 0x0005B8EC
		[CallerCount(0)]
		public unsafe static float2x2 operator +(float2x2 lhs, float2x2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float2x2.NativeMethodInfoPtr_op_Addition_Public_Static_float2x2_float2x2_float2x2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001111 RID: 4369 RVA: 0x0005D738 File Offset: 0x0005B938
		[CallerCount(0)]
		public unsafe static float2x2 operator +(float2x2 lhs, float rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float2x2.NativeMethodInfoPtr_op_Addition_Public_Static_float2x2_float2x2_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001112 RID: 4370 RVA: 0x0005D784 File Offset: 0x0005B984
		[CallerCount(0)]
		public unsafe static float2x2 operator +(float lhs, float2x2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float2x2.NativeMethodInfoPtr_op_Addition_Public_Static_float2x2_Single_float2x2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001113 RID: 4371 RVA: 0x0005D7D0 File Offset: 0x0005B9D0
		[CallerCount(0)]
		public unsafe static float2x2 operator -(float2x2 lhs, float2x2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float2x2.NativeMethodInfoPtr_op_Subtraction_Public_Static_float2x2_float2x2_float2x2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001114 RID: 4372 RVA: 0x0005D81C File Offset: 0x0005BA1C
		[CallerCount(0)]
		public unsafe static float2x2 operator -(float2x2 lhs, float rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float2x2.NativeMethodInfoPtr_op_Subtraction_Public_Static_float2x2_float2x2_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001115 RID: 4373 RVA: 0x0005D868 File Offset: 0x0005BA68
		[CallerCount(0)]
		public unsafe static float2x2 operator -(float lhs, float2x2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float2x2.NativeMethodInfoPtr_op_Subtraction_Public_Static_float2x2_Single_float2x2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001116 RID: 4374 RVA: 0x0005D8B4 File Offset: 0x0005BAB4
		[CallerCount(0)]
		public unsafe static float2x2 operator /(float2x2 lhs, float2x2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float2x2.NativeMethodInfoPtr_op_Division_Public_Static_float2x2_float2x2_float2x2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001117 RID: 4375 RVA: 0x0005D900 File Offset: 0x0005BB00
		[CallerCount(0)]
		public unsafe static float2x2 operator /(float2x2 lhs, float rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float2x2.NativeMethodInfoPtr_op_Division_Public_Static_float2x2_float2x2_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001118 RID: 4376 RVA: 0x0005D94C File Offset: 0x0005BB4C
		[CallerCount(0)]
		public unsafe static float2x2 operator /(float lhs, float2x2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float2x2.NativeMethodInfoPtr_op_Division_Public_Static_float2x2_Single_float2x2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001119 RID: 4377 RVA: 0x0005D998 File Offset: 0x0005BB98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 636745, XrefRangeEnd = 636749, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float2x2 operator %(float2x2 lhs, float2x2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float2x2.NativeMethodInfoPtr_op_Modulus_Public_Static_float2x2_float2x2_float2x2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600111A RID: 4378 RVA: 0x0005D9E4 File Offset: 0x0005BBE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 636749, XrefRangeEnd = 636753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float2x2 operator %(float2x2 lhs, float rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float2x2.NativeMethodInfoPtr_op_Modulus_Public_Static_float2x2_float2x2_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600111B RID: 4379 RVA: 0x0005DA30 File Offset: 0x0005BC30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 636753, XrefRangeEnd = 636757, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float2x2 operator %(float lhs, float2x2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float2x2.NativeMethodInfoPtr_op_Modulus_Public_Static_float2x2_Single_float2x2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600111C RID: 4380 RVA: 0x0005DA7C File Offset: 0x0005BC7C
		[CallerCount(0)]
		public unsafe static float2x2 operator ++(float2x2 val)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float2x2.NativeMethodInfoPtr_op_Increment_Public_Static_float2x2_float2x2_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600111D RID: 4381 RVA: 0x0005DABC File Offset: 0x0005BCBC
		[CallerCount(0)]
		public unsafe static float2x2 operator --(float2x2 val)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float2x2.NativeMethodInfoPtr_op_Decrement_Public_Static_float2x2_float2x2_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600111E RID: 4382 RVA: 0x0005DAFC File Offset: 0x0005BCFC
		[CallerCount(0)]
		public unsafe static bool2x2 operator <(float2x2 lhs, float2x2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float2x2.NativeMethodInfoPtr_op_LessThan_Public_Static_bool2x2_float2x2_float2x2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600111F RID: 4383 RVA: 0x0005DB48 File Offset: 0x0005BD48
		[CallerCount(0)]
		public unsafe static bool2x2 operator <(float2x2 lhs, float rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float2x2.NativeMethodInfoPtr_op_LessThan_Public_Static_bool2x2_float2x2_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001120 RID: 4384 RVA: 0x0005DB94 File Offset: 0x0005BD94
		[CallerCount(0)]
		public unsafe static bool2x2 operator <(float lhs, float2x2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float2x2.NativeMethodInfoPtr_op_LessThan_Public_Static_bool2x2_Single_float2x2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001121 RID: 4385 RVA: 0x0005DBE0 File Offset: 0x0005BDE0
		[CallerCount(0)]
		public unsafe static bool2x2 operator <=(float2x2 lhs, float2x2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float2x2.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool2x2_float2x2_float2x2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001122 RID: 4386 RVA: 0x0005DC2C File Offset: 0x0005BE2C
		[CallerCount(0)]
		public unsafe static bool2x2 operator <=(float2x2 lhs, float rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float2x2.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool2x2_float2x2_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001123 RID: 4387 RVA: 0x0005DC78 File Offset: 0x0005BE78
		[CallerCount(0)]
		public unsafe static bool2x2 operator <=(float lhs, float2x2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float2x2.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool2x2_Single_float2x2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001124 RID: 4388 RVA: 0x0005DCC4 File Offset: 0x0005BEC4
		[CallerCount(0)]
		public unsafe static bool2x2 operator >(float2x2 lhs, float2x2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float2x2.NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool2x2_float2x2_float2x2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001125 RID: 4389 RVA: 0x0005DD10 File Offset: 0x0005BF10
		[CallerCount(0)]
		public unsafe static bool2x2 operator >(float2x2 lhs, float rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float2x2.NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool2x2_float2x2_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001126 RID: 4390 RVA: 0x0005DD5C File Offset: 0x0005BF5C
		[CallerCount(0)]
		public unsafe static bool2x2 operator >(float lhs, float2x2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float2x2.NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool2x2_Single_float2x2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001127 RID: 4391 RVA: 0x0005DDA8 File Offset: 0x0005BFA8
		[CallerCount(0)]
		public unsafe static bool2x2 operator >=(float2x2 lhs, float2x2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float2x2.NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool2x2_float2x2_float2x2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001128 RID: 4392 RVA: 0x0005DDF4 File Offset: 0x0005BFF4
		[CallerCount(0)]
		public unsafe static bool2x2 operator >=(float2x2 lhs, float rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float2x2.NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool2x2_float2x2_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001129 RID: 4393 RVA: 0x0005DE40 File Offset: 0x0005C040
		[CallerCount(0)]
		public unsafe static bool2x2 operator >=(float lhs, float2x2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float2x2.NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool2x2_Single_float2x2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600112A RID: 4394 RVA: 0x0005DE8C File Offset: 0x0005C08C
		[CallerCount(0)]
		public unsafe static float2x2 operator -(float2x2 val)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float2x2.NativeMethodInfoPtr_op_UnaryNegation_Public_Static_float2x2_float2x2_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600112B RID: 4395 RVA: 0x0005DECC File Offset: 0x0005C0CC
		[CallerCount(0)]
		public unsafe static float2x2 operator +(float2x2 val)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float2x2.NativeMethodInfoPtr_op_UnaryPlus_Public_Static_float2x2_float2x2_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600112C RID: 4396 RVA: 0x0005DF0C File Offset: 0x0005C10C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 636757, XrefRangeEnd = 636761, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool2x2 operator ==(float2x2 lhs, float2x2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float2x2.NativeMethodInfoPtr_op_Equality_Public_Static_bool2x2_float2x2_float2x2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600112D RID: 4397 RVA: 0x0005DF58 File Offset: 0x0005C158
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 636761, XrefRangeEnd = 636765, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool2x2 operator ==(float2x2 lhs, float rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float2x2.NativeMethodInfoPtr_op_Equality_Public_Static_bool2x2_float2x2_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600112E RID: 4398 RVA: 0x0005DFA4 File Offset: 0x0005C1A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 636765, XrefRangeEnd = 636768, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool2x2 operator ==(float lhs, float2x2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float2x2.NativeMethodInfoPtr_op_Equality_Public_Static_bool2x2_Single_float2x2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600112F RID: 4399 RVA: 0x0005DFF0 File Offset: 0x0005C1F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 636768, XrefRangeEnd = 636772, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool2x2 operator !=(float2x2 lhs, float2x2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float2x2.NativeMethodInfoPtr_op_Inequality_Public_Static_bool2x2_float2x2_float2x2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001130 RID: 4400 RVA: 0x0005E03C File Offset: 0x0005C23C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 636772, XrefRangeEnd = 636776, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool2x2 operator !=(float2x2 lhs, float rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float2x2.NativeMethodInfoPtr_op_Inequality_Public_Static_bool2x2_float2x2_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001131 RID: 4401 RVA: 0x0005E088 File Offset: 0x0005C288
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 636776, XrefRangeEnd = 636779, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool2x2 operator !=(float lhs, float2x2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float2x2.NativeMethodInfoPtr_op_Inequality_Public_Static_bool2x2_Single_float2x2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000420 RID: 1056
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float2x2.NativeMethodInfoPtr_get_Item_Public_get_byref_float2_Int32_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return intPtr;
				}
			}
		}

		// Token: 0x06001133 RID: 4403 RVA: 0x0005E108 File Offset: 0x0005C308
		[CallerCount(0)]
		public unsafe bool Equals(float2x2 rhs)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref rhs;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float2x2.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_float2x2_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001134 RID: 4404 RVA: 0x0005E148 File Offset: 0x0005C348
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 636779, XrefRangeEnd = 636782, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object o)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(o);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float2x2.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001135 RID: 4405 RVA: 0x0005E18C File Offset: 0x0005C38C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 636782, XrefRangeEnd = 636783, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float2x2.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001136 RID: 4406 RVA: 0x0005E1BC File Offset: 0x0005C3BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 636783, XrefRangeEnd = 636806, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float2x2.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001137 RID: 4407 RVA: 0x0005E1E8 File Offset: 0x0005C3E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 636806, XrefRangeEnd = 636834, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float2x2.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001138 RID: 4408 RVA: 0x0005E238 File Offset: 0x0005C438
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 636834, XrefRangeEnd = 636842, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float2x2 Rotate(float angle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref angle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float2x2.NativeMethodInfoPtr_Rotate_Public_Static_float2x2_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001139 RID: 4409 RVA: 0x0005E278 File Offset: 0x0005C478
		[CallerCount(0)]
		public unsafe static float2x2 Scale(float s)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref s;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float2x2.NativeMethodInfoPtr_Scale_Public_Static_float2x2_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600113A RID: 4410 RVA: 0x0005E2B8 File Offset: 0x0005C4B8
		[CallerCount(0)]
		public unsafe static float2x2 Scale(float x, float y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float2x2.NativeMethodInfoPtr_Scale_Public_Static_float2x2_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600113B RID: 4411 RVA: 0x0005E304 File Offset: 0x0005C504
		[CallerCount(0)]
		public unsafe static float2x2 Scale(float2 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float2x2.NativeMethodInfoPtr_Scale_Public_Static_float2x2_float2_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600113C RID: 4412 RVA: 0x0000247A File Offset: 0x0000067A
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<float2x2>.NativeClassPtr, ref this));
		}

		// Token: 0x1700041E RID: 1054
		// (get) Token: 0x0600113D RID: 4413 RVA: 0x0005E344 File Offset: 0x0005C544
		// (set) Token: 0x0600113E RID: 4414 RVA: 0x0000248C File Offset: 0x0000068C
		public unsafe static float2x2 identity
		{
			get
			{
				float2x2 float2x;
				IL2CPP.il2cpp_field_static_get_value(float2x2.NativeFieldInfoPtr_identity, (void*)(&float2x));
				return float2x;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(float2x2.NativeFieldInfoPtr_identity, (void*)(&value));
			}
		}

		// Token: 0x1700041F RID: 1055
		// (get) Token: 0x0600113F RID: 4415 RVA: 0x0005E360 File Offset: 0x0005C560
		// (set) Token: 0x06001140 RID: 4416 RVA: 0x0000249A File Offset: 0x0000069A
		public unsafe static float2x2 zero
		{
			get
			{
				float2x2 float2x;
				IL2CPP.il2cpp_field_static_get_value(float2x2.NativeFieldInfoPtr_zero, (void*)(&float2x));
				return float2x;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(float2x2.NativeFieldInfoPtr_zero, (void*)(&value));
			}
		}

		// Token: 0x0400112E RID: 4398
		private static readonly IntPtr NativeFieldInfoPtr_c0;

		// Token: 0x0400112F RID: 4399
		private static readonly IntPtr NativeFieldInfoPtr_c1;

		// Token: 0x04001130 RID: 4400
		private static readonly IntPtr NativeFieldInfoPtr_identity;

		// Token: 0x04001131 RID: 4401
		private static readonly IntPtr NativeFieldInfoPtr_zero;

		// Token: 0x04001132 RID: 4402
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_float2_float2_0;

		// Token: 0x04001133 RID: 4403
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_Single_0;

		// Token: 0x04001134 RID: 4404
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_0;

		// Token: 0x04001135 RID: 4405
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_0;

		// Token: 0x04001136 RID: 4406
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_bool2x2_0;

		// Token: 0x04001137 RID: 4407
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x04001138 RID: 4408
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_int2x2_0;

		// Token: 0x04001139 RID: 4409
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_UInt32_0;

		// Token: 0x0400113A RID: 4410
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_uint2x2_0;

		// Token: 0x0400113B RID: 4411
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Double_0;

		// Token: 0x0400113C RID: 4412
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_double2x2_0;

		// Token: 0x0400113D RID: 4413
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_float2x2_Single_0;

		// Token: 0x0400113E RID: 4414
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_float2x2_Boolean_0;

		// Token: 0x0400113F RID: 4415
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_float2x2_bool2x2_0;

		// Token: 0x04001140 RID: 4416
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_float2x2_Int32_0;

		// Token: 0x04001141 RID: 4417
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_float2x2_int2x2_0;

		// Token: 0x04001142 RID: 4418
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_float2x2_UInt32_0;

		// Token: 0x04001143 RID: 4419
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_float2x2_uint2x2_0;

		// Token: 0x04001144 RID: 4420
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_float2x2_Double_0;

		// Token: 0x04001145 RID: 4421
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_float2x2_double2x2_0;

		// Token: 0x04001146 RID: 4422
		private static readonly IntPtr NativeMethodInfoPtr_op_Multiply_Public_Static_float2x2_float2x2_float2x2_0;

		// Token: 0x04001147 RID: 4423
		private static readonly IntPtr NativeMethodInfoPtr_op_Multiply_Public_Static_float2x2_float2x2_Single_0;

		// Token: 0x04001148 RID: 4424
		private static readonly IntPtr NativeMethodInfoPtr_op_Multiply_Public_Static_float2x2_Single_float2x2_0;

		// Token: 0x04001149 RID: 4425
		private static readonly IntPtr NativeMethodInfoPtr_op_Addition_Public_Static_float2x2_float2x2_float2x2_0;

		// Token: 0x0400114A RID: 4426
		private static readonly IntPtr NativeMethodInfoPtr_op_Addition_Public_Static_float2x2_float2x2_Single_0;

		// Token: 0x0400114B RID: 4427
		private static readonly IntPtr NativeMethodInfoPtr_op_Addition_Public_Static_float2x2_Single_float2x2_0;

		// Token: 0x0400114C RID: 4428
		private static readonly IntPtr NativeMethodInfoPtr_op_Subtraction_Public_Static_float2x2_float2x2_float2x2_0;

		// Token: 0x0400114D RID: 4429
		private static readonly IntPtr NativeMethodInfoPtr_op_Subtraction_Public_Static_float2x2_float2x2_Single_0;

		// Token: 0x0400114E RID: 4430
		private static readonly IntPtr NativeMethodInfoPtr_op_Subtraction_Public_Static_float2x2_Single_float2x2_0;

		// Token: 0x0400114F RID: 4431
		private static readonly IntPtr NativeMethodInfoPtr_op_Division_Public_Static_float2x2_float2x2_float2x2_0;

		// Token: 0x04001150 RID: 4432
		private static readonly IntPtr NativeMethodInfoPtr_op_Division_Public_Static_float2x2_float2x2_Single_0;

		// Token: 0x04001151 RID: 4433
		private static readonly IntPtr NativeMethodInfoPtr_op_Division_Public_Static_float2x2_Single_float2x2_0;

		// Token: 0x04001152 RID: 4434
		private static readonly IntPtr NativeMethodInfoPtr_op_Modulus_Public_Static_float2x2_float2x2_float2x2_0;

		// Token: 0x04001153 RID: 4435
		private static readonly IntPtr NativeMethodInfoPtr_op_Modulus_Public_Static_float2x2_float2x2_Single_0;

		// Token: 0x04001154 RID: 4436
		private static readonly IntPtr NativeMethodInfoPtr_op_Modulus_Public_Static_float2x2_Single_float2x2_0;

		// Token: 0x04001155 RID: 4437
		private static readonly IntPtr NativeMethodInfoPtr_op_Increment_Public_Static_float2x2_float2x2_0;

		// Token: 0x04001156 RID: 4438
		private static readonly IntPtr NativeMethodInfoPtr_op_Decrement_Public_Static_float2x2_float2x2_0;

		// Token: 0x04001157 RID: 4439
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThan_Public_Static_bool2x2_float2x2_float2x2_0;

		// Token: 0x04001158 RID: 4440
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThan_Public_Static_bool2x2_float2x2_Single_0;

		// Token: 0x04001159 RID: 4441
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThan_Public_Static_bool2x2_Single_float2x2_0;

		// Token: 0x0400115A RID: 4442
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool2x2_float2x2_float2x2_0;

		// Token: 0x0400115B RID: 4443
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool2x2_float2x2_Single_0;

		// Token: 0x0400115C RID: 4444
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool2x2_Single_float2x2_0;

		// Token: 0x0400115D RID: 4445
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool2x2_float2x2_float2x2_0;

		// Token: 0x0400115E RID: 4446
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool2x2_float2x2_Single_0;

		// Token: 0x0400115F RID: 4447
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool2x2_Single_float2x2_0;

		// Token: 0x04001160 RID: 4448
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool2x2_float2x2_float2x2_0;

		// Token: 0x04001161 RID: 4449
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool2x2_float2x2_Single_0;

		// Token: 0x04001162 RID: 4450
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool2x2_Single_float2x2_0;

		// Token: 0x04001163 RID: 4451
		private static readonly IntPtr NativeMethodInfoPtr_op_UnaryNegation_Public_Static_float2x2_float2x2_0;

		// Token: 0x04001164 RID: 4452
		private static readonly IntPtr NativeMethodInfoPtr_op_UnaryPlus_Public_Static_float2x2_float2x2_0;

		// Token: 0x04001165 RID: 4453
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_bool2x2_float2x2_float2x2_0;

		// Token: 0x04001166 RID: 4454
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_bool2x2_float2x2_Single_0;

		// Token: 0x04001167 RID: 4455
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_bool2x2_Single_float2x2_0;

		// Token: 0x04001168 RID: 4456
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_bool2x2_float2x2_float2x2_0;

		// Token: 0x04001169 RID: 4457
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_bool2x2_float2x2_Single_0;

		// Token: 0x0400116A RID: 4458
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_bool2x2_Single_float2x2_0;

		// Token: 0x0400116B RID: 4459
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_get_byref_float2_Int32_0;

		// Token: 0x0400116C RID: 4460
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_float2x2_0;

		// Token: 0x0400116D RID: 4461
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x0400116E RID: 4462
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x0400116F RID: 4463
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04001170 RID: 4464
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0;

		// Token: 0x04001171 RID: 4465
		private static readonly IntPtr NativeMethodInfoPtr_Rotate_Public_Static_float2x2_Single_0;

		// Token: 0x04001172 RID: 4466
		private static readonly IntPtr NativeMethodInfoPtr_Scale_Public_Static_float2x2_Single_0;

		// Token: 0x04001173 RID: 4467
		private static readonly IntPtr NativeMethodInfoPtr_Scale_Public_Static_float2x2_Single_Single_0;

		// Token: 0x04001174 RID: 4468
		private static readonly IntPtr NativeMethodInfoPtr_Scale_Public_Static_float2x2_float2_0;

		// Token: 0x04001175 RID: 4469
		[FieldOffset(0)]
		public float2 c0;

		// Token: 0x04001176 RID: 4470
		[FieldOffset(8)]
		public float2 c1;
	}
}
