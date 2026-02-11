using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Unity.Mathematics
{
	// Token: 0x0200001B RID: 27
	[Serializable]
	[StructLayout(2)]
	public struct double4x3
	{
		// Token: 0x06001008 RID: 4104 RVA: 0x00057CCC File Offset: 0x00055ECC
		// Note: this type is marked as 'beforefieldinit'.
		static double4x3()
		{
			Il2CppClassPointerStore<double4x3>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Mathematics.dll", "Unity.Mathematics", "double4x3");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<double4x3>.NativeClassPtr);
			double4x3.NativeFieldInfoPtr_c0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<double4x3>.NativeClassPtr, "c0");
			double4x3.NativeFieldInfoPtr_c1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<double4x3>.NativeClassPtr, "c1");
			double4x3.NativeFieldInfoPtr_c2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<double4x3>.NativeClassPtr, "c2");
			double4x3.NativeFieldInfoPtr_zero = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<double4x3>.NativeClassPtr, "zero");
			double4x3.NativeMethodInfoPtr__ctor_Public_Void_double4_double4_double4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4x3>.NativeClassPtr, 100667290);
			double4x3.NativeMethodInfoPtr__ctor_Public_Void_Double_Double_Double_Double_Double_Double_Double_Double_Double_Double_Double_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4x3>.NativeClassPtr, 100667291);
			double4x3.NativeMethodInfoPtr__ctor_Public_Void_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4x3>.NativeClassPtr, 100667292);
			double4x3.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4x3>.NativeClassPtr, 100667293);
			double4x3.NativeMethodInfoPtr__ctor_Public_Void_bool4x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4x3>.NativeClassPtr, 100667294);
			double4x3.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4x3>.NativeClassPtr, 100667295);
			double4x3.NativeMethodInfoPtr__ctor_Public_Void_int4x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4x3>.NativeClassPtr, 100667296);
			double4x3.NativeMethodInfoPtr__ctor_Public_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4x3>.NativeClassPtr, 100667297);
			double4x3.NativeMethodInfoPtr__ctor_Public_Void_uint4x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4x3>.NativeClassPtr, 100667298);
			double4x3.NativeMethodInfoPtr__ctor_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4x3>.NativeClassPtr, 100667299);
			double4x3.NativeMethodInfoPtr__ctor_Public_Void_float4x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4x3>.NativeClassPtr, 100667300);
			double4x3.NativeMethodInfoPtr_op_Implicit_Public_Static_double4x3_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4x3>.NativeClassPtr, 100667301);
			double4x3.NativeMethodInfoPtr_op_Explicit_Public_Static_double4x3_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4x3>.NativeClassPtr, 100667302);
			double4x3.NativeMethodInfoPtr_op_Explicit_Public_Static_double4x3_bool4x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4x3>.NativeClassPtr, 100667303);
			double4x3.NativeMethodInfoPtr_op_Implicit_Public_Static_double4x3_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4x3>.NativeClassPtr, 100667304);
			double4x3.NativeMethodInfoPtr_op_Implicit_Public_Static_double4x3_int4x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4x3>.NativeClassPtr, 100667305);
			double4x3.NativeMethodInfoPtr_op_Implicit_Public_Static_double4x3_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4x3>.NativeClassPtr, 100667306);
			double4x3.NativeMethodInfoPtr_op_Implicit_Public_Static_double4x3_uint4x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4x3>.NativeClassPtr, 100667307);
			double4x3.NativeMethodInfoPtr_op_Implicit_Public_Static_double4x3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4x3>.NativeClassPtr, 100667308);
			double4x3.NativeMethodInfoPtr_op_Implicit_Public_Static_double4x3_float4x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4x3>.NativeClassPtr, 100667309);
			double4x3.NativeMethodInfoPtr_op_Multiply_Public_Static_double4x3_double4x3_double4x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4x3>.NativeClassPtr, 100667310);
			double4x3.NativeMethodInfoPtr_op_Multiply_Public_Static_double4x3_double4x3_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4x3>.NativeClassPtr, 100667311);
			double4x3.NativeMethodInfoPtr_op_Multiply_Public_Static_double4x3_Double_double4x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4x3>.NativeClassPtr, 100667312);
			double4x3.NativeMethodInfoPtr_op_Addition_Public_Static_double4x3_double4x3_double4x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4x3>.NativeClassPtr, 100667313);
			double4x3.NativeMethodInfoPtr_op_Addition_Public_Static_double4x3_double4x3_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4x3>.NativeClassPtr, 100667314);
			double4x3.NativeMethodInfoPtr_op_Addition_Public_Static_double4x3_Double_double4x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4x3>.NativeClassPtr, 100667315);
			double4x3.NativeMethodInfoPtr_op_Subtraction_Public_Static_double4x3_double4x3_double4x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4x3>.NativeClassPtr, 100667316);
			double4x3.NativeMethodInfoPtr_op_Subtraction_Public_Static_double4x3_double4x3_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4x3>.NativeClassPtr, 100667317);
			double4x3.NativeMethodInfoPtr_op_Subtraction_Public_Static_double4x3_Double_double4x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4x3>.NativeClassPtr, 100667318);
			double4x3.NativeMethodInfoPtr_op_Division_Public_Static_double4x3_double4x3_double4x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4x3>.NativeClassPtr, 100667319);
			double4x3.NativeMethodInfoPtr_op_Division_Public_Static_double4x3_double4x3_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4x3>.NativeClassPtr, 100667320);
			double4x3.NativeMethodInfoPtr_op_Division_Public_Static_double4x3_Double_double4x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4x3>.NativeClassPtr, 100667321);
			double4x3.NativeMethodInfoPtr_op_Modulus_Public_Static_double4x3_double4x3_double4x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4x3>.NativeClassPtr, 100667322);
			double4x3.NativeMethodInfoPtr_op_Modulus_Public_Static_double4x3_double4x3_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4x3>.NativeClassPtr, 100667323);
			double4x3.NativeMethodInfoPtr_op_Modulus_Public_Static_double4x3_Double_double4x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4x3>.NativeClassPtr, 100667324);
			double4x3.NativeMethodInfoPtr_op_Increment_Public_Static_double4x3_double4x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4x3>.NativeClassPtr, 100667325);
			double4x3.NativeMethodInfoPtr_op_Decrement_Public_Static_double4x3_double4x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4x3>.NativeClassPtr, 100667326);
			double4x3.NativeMethodInfoPtr_op_LessThan_Public_Static_bool4x3_double4x3_double4x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4x3>.NativeClassPtr, 100667327);
			double4x3.NativeMethodInfoPtr_op_LessThan_Public_Static_bool4x3_double4x3_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4x3>.NativeClassPtr, 100667328);
			double4x3.NativeMethodInfoPtr_op_LessThan_Public_Static_bool4x3_Double_double4x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4x3>.NativeClassPtr, 100667329);
			double4x3.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool4x3_double4x3_double4x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4x3>.NativeClassPtr, 100667330);
			double4x3.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool4x3_double4x3_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4x3>.NativeClassPtr, 100667331);
			double4x3.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool4x3_Double_double4x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4x3>.NativeClassPtr, 100667332);
			double4x3.NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool4x3_double4x3_double4x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4x3>.NativeClassPtr, 100667333);
			double4x3.NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool4x3_double4x3_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4x3>.NativeClassPtr, 100667334);
			double4x3.NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool4x3_Double_double4x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4x3>.NativeClassPtr, 100667335);
			double4x3.NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool4x3_double4x3_double4x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4x3>.NativeClassPtr, 100667336);
			double4x3.NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool4x3_double4x3_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4x3>.NativeClassPtr, 100667337);
			double4x3.NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool4x3_Double_double4x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4x3>.NativeClassPtr, 100667338);
			double4x3.NativeMethodInfoPtr_op_UnaryNegation_Public_Static_double4x3_double4x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4x3>.NativeClassPtr, 100667339);
			double4x3.NativeMethodInfoPtr_op_UnaryPlus_Public_Static_double4x3_double4x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4x3>.NativeClassPtr, 100667340);
			double4x3.NativeMethodInfoPtr_op_Equality_Public_Static_bool4x3_double4x3_double4x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4x3>.NativeClassPtr, 100667341);
			double4x3.NativeMethodInfoPtr_op_Equality_Public_Static_bool4x3_double4x3_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4x3>.NativeClassPtr, 100667342);
			double4x3.NativeMethodInfoPtr_op_Equality_Public_Static_bool4x3_Double_double4x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4x3>.NativeClassPtr, 100667343);
			double4x3.NativeMethodInfoPtr_op_Inequality_Public_Static_bool4x3_double4x3_double4x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4x3>.NativeClassPtr, 100667344);
			double4x3.NativeMethodInfoPtr_op_Inequality_Public_Static_bool4x3_double4x3_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4x3>.NativeClassPtr, 100667345);
			double4x3.NativeMethodInfoPtr_op_Inequality_Public_Static_bool4x3_Double_double4x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4x3>.NativeClassPtr, 100667346);
			double4x3.NativeMethodInfoPtr_get_Item_Public_get_byref_double4_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4x3>.NativeClassPtr, 100667347);
			double4x3.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_double4x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4x3>.NativeClassPtr, 100667348);
			double4x3.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4x3>.NativeClassPtr, 100667349);
			double4x3.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4x3>.NativeClassPtr, 100667350);
			double4x3.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4x3>.NativeClassPtr, 100667351);
			double4x3.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<double4x3>.NativeClassPtr, 100667352);
		}

		// Token: 0x06001009 RID: 4105 RVA: 0x00058238 File Offset: 0x00056438
		[CallerCount(0)]
		public unsafe double4x3(double4 c0, double4 c1, double4 c2)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4x3.NativeMethodInfoPtr__ctor_Public_Void_double4_double4_double4_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600100A RID: 4106 RVA: 0x00058288 File Offset: 0x00056488
		[CallerCount(0)]
		public unsafe double4x3(double m00, double m01, double m02, double m10, double m11, double m12, double m20, double m21, double m22, double m30, double m31, double m32)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4x3.NativeMethodInfoPtr__ctor_Public_Void_Double_Double_Double_Double_Double_Double_Double_Double_Double_Double_Double_Double_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600100B RID: 4107 RVA: 0x00058358 File Offset: 0x00056558
		[CallerCount(0)]
		public unsafe double4x3(double v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4x3.NativeMethodInfoPtr__ctor_Public_Void_Double_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600100C RID: 4108 RVA: 0x0005838C File Offset: 0x0005658C
		[CallerCount(0)]
		public unsafe double4x3(bool v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4x3.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600100D RID: 4109 RVA: 0x000583C0 File Offset: 0x000565C0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 636119, RefRangeEnd = 636121, XrefRangeStart = 636107, XrefRangeEnd = 636119, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe double4x3(bool4x3 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4x3.NativeMethodInfoPtr__ctor_Public_Void_bool4x3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600100E RID: 4110 RVA: 0x000583F4 File Offset: 0x000565F4
		[CallerCount(0)]
		public unsafe double4x3(int v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4x3.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600100F RID: 4111 RVA: 0x00058428 File Offset: 0x00056628
		[CallerCount(0)]
		public unsafe double4x3(int4x3 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4x3.NativeMethodInfoPtr__ctor_Public_Void_int4x3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001010 RID: 4112 RVA: 0x0005845C File Offset: 0x0005665C
		[CallerCount(0)]
		public unsafe double4x3(uint v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4x3.NativeMethodInfoPtr__ctor_Public_Void_UInt32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001011 RID: 4113 RVA: 0x00058490 File Offset: 0x00056690
		[CallerCount(0)]
		public unsafe double4x3(uint4x3 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4x3.NativeMethodInfoPtr__ctor_Public_Void_uint4x3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001012 RID: 4114 RVA: 0x000584C4 File Offset: 0x000566C4
		[CallerCount(0)]
		public unsafe double4x3(float v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4x3.NativeMethodInfoPtr__ctor_Public_Void_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001013 RID: 4115 RVA: 0x000584F8 File Offset: 0x000566F8
		[CallerCount(0)]
		public unsafe double4x3(float4x3 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4x3.NativeMethodInfoPtr__ctor_Public_Void_float4x3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001014 RID: 4116 RVA: 0x0005852C File Offset: 0x0005672C
		[CallerCount(0)]
		public unsafe static implicit operator double4x3(double v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4x3.NativeMethodInfoPtr_op_Implicit_Public_Static_double4x3_Double_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001015 RID: 4117 RVA: 0x0005856C File Offset: 0x0005676C
		[CallerCount(0)]
		public unsafe static explicit operator double4x3(bool v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4x3.NativeMethodInfoPtr_op_Explicit_Public_Static_double4x3_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001016 RID: 4118 RVA: 0x000585AC File Offset: 0x000567AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator double4x3(bool4x3 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4x3.NativeMethodInfoPtr_op_Explicit_Public_Static_double4x3_bool4x3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001017 RID: 4119 RVA: 0x000585EC File Offset: 0x000567EC
		[CallerCount(0)]
		public unsafe static implicit operator double4x3(int v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4x3.NativeMethodInfoPtr_op_Implicit_Public_Static_double4x3_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001018 RID: 4120 RVA: 0x0005862C File Offset: 0x0005682C
		[CallerCount(0)]
		public unsafe static implicit operator double4x3(int4x3 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4x3.NativeMethodInfoPtr_op_Implicit_Public_Static_double4x3_int4x3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001019 RID: 4121 RVA: 0x0005866C File Offset: 0x0005686C
		[CallerCount(0)]
		public unsafe static implicit operator double4x3(uint v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4x3.NativeMethodInfoPtr_op_Implicit_Public_Static_double4x3_UInt32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600101A RID: 4122 RVA: 0x000586AC File Offset: 0x000568AC
		[CallerCount(0)]
		public unsafe static implicit operator double4x3(uint4x3 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4x3.NativeMethodInfoPtr_op_Implicit_Public_Static_double4x3_uint4x3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600101B RID: 4123 RVA: 0x000586EC File Offset: 0x000568EC
		[CallerCount(0)]
		public unsafe static implicit operator double4x3(float v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4x3.NativeMethodInfoPtr_op_Implicit_Public_Static_double4x3_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600101C RID: 4124 RVA: 0x0005872C File Offset: 0x0005692C
		[CallerCount(0)]
		public unsafe static implicit operator double4x3(float4x3 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4x3.NativeMethodInfoPtr_op_Implicit_Public_Static_double4x3_float4x3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600101D RID: 4125 RVA: 0x0005876C File Offset: 0x0005696C
		[CallerCount(0)]
		public unsafe static double4x3 operator *(double4x3 lhs, double4x3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4x3.NativeMethodInfoPtr_op_Multiply_Public_Static_double4x3_double4x3_double4x3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600101E RID: 4126 RVA: 0x000587B8 File Offset: 0x000569B8
		[CallerCount(0)]
		public unsafe static double4x3 operator *(double4x3 lhs, double rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4x3.NativeMethodInfoPtr_op_Multiply_Public_Static_double4x3_double4x3_Double_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600101F RID: 4127 RVA: 0x00058804 File Offset: 0x00056A04
		[CallerCount(0)]
		public unsafe static double4x3 operator *(double lhs, double4x3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4x3.NativeMethodInfoPtr_op_Multiply_Public_Static_double4x3_Double_double4x3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001020 RID: 4128 RVA: 0x00058850 File Offset: 0x00056A50
		[CallerCount(0)]
		public unsafe static double4x3 operator +(double4x3 lhs, double4x3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4x3.NativeMethodInfoPtr_op_Addition_Public_Static_double4x3_double4x3_double4x3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001021 RID: 4129 RVA: 0x0005889C File Offset: 0x00056A9C
		[CallerCount(0)]
		public unsafe static double4x3 operator +(double4x3 lhs, double rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4x3.NativeMethodInfoPtr_op_Addition_Public_Static_double4x3_double4x3_Double_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001022 RID: 4130 RVA: 0x000588E8 File Offset: 0x00056AE8
		[CallerCount(0)]
		public unsafe static double4x3 operator +(double lhs, double4x3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4x3.NativeMethodInfoPtr_op_Addition_Public_Static_double4x3_Double_double4x3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001023 RID: 4131 RVA: 0x00058934 File Offset: 0x00056B34
		[CallerCount(0)]
		public unsafe static double4x3 operator -(double4x3 lhs, double4x3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4x3.NativeMethodInfoPtr_op_Subtraction_Public_Static_double4x3_double4x3_double4x3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001024 RID: 4132 RVA: 0x00058980 File Offset: 0x00056B80
		[CallerCount(0)]
		public unsafe static double4x3 operator -(double4x3 lhs, double rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4x3.NativeMethodInfoPtr_op_Subtraction_Public_Static_double4x3_double4x3_Double_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001025 RID: 4133 RVA: 0x000589CC File Offset: 0x00056BCC
		[CallerCount(0)]
		public unsafe static double4x3 operator -(double lhs, double4x3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4x3.NativeMethodInfoPtr_op_Subtraction_Public_Static_double4x3_Double_double4x3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001026 RID: 4134 RVA: 0x00058A18 File Offset: 0x00056C18
		[CallerCount(0)]
		public unsafe static double4x3 operator /(double4x3 lhs, double4x3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4x3.NativeMethodInfoPtr_op_Division_Public_Static_double4x3_double4x3_double4x3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001027 RID: 4135 RVA: 0x00058A64 File Offset: 0x00056C64
		[CallerCount(0)]
		public unsafe static double4x3 operator /(double4x3 lhs, double rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4x3.NativeMethodInfoPtr_op_Division_Public_Static_double4x3_double4x3_Double_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001028 RID: 4136 RVA: 0x00058AB0 File Offset: 0x00056CB0
		[CallerCount(0)]
		public unsafe static double4x3 operator /(double lhs, double4x3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4x3.NativeMethodInfoPtr_op_Division_Public_Static_double4x3_Double_double4x3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001029 RID: 4137 RVA: 0x00058AFC File Offset: 0x00056CFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 636121, XrefRangeEnd = 636133, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static double4x3 operator %(double4x3 lhs, double4x3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4x3.NativeMethodInfoPtr_op_Modulus_Public_Static_double4x3_double4x3_double4x3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600102A RID: 4138 RVA: 0x00058B48 File Offset: 0x00056D48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 636133, XrefRangeEnd = 636145, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static double4x3 operator %(double4x3 lhs, double rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4x3.NativeMethodInfoPtr_op_Modulus_Public_Static_double4x3_double4x3_Double_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600102B RID: 4139 RVA: 0x00058B94 File Offset: 0x00056D94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 636145, XrefRangeEnd = 636157, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static double4x3 operator %(double lhs, double4x3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4x3.NativeMethodInfoPtr_op_Modulus_Public_Static_double4x3_Double_double4x3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600102C RID: 4140 RVA: 0x00058BE0 File Offset: 0x00056DE0
		[CallerCount(0)]
		public unsafe static double4x3 operator ++(double4x3 val)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4x3.NativeMethodInfoPtr_op_Increment_Public_Static_double4x3_double4x3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600102D RID: 4141 RVA: 0x00058C20 File Offset: 0x00056E20
		[CallerCount(0)]
		public unsafe static double4x3 operator --(double4x3 val)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4x3.NativeMethodInfoPtr_op_Decrement_Public_Static_double4x3_double4x3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600102E RID: 4142 RVA: 0x00058C60 File Offset: 0x00056E60
		[CallerCount(0)]
		public unsafe static bool4x3 operator <(double4x3 lhs, double4x3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4x3.NativeMethodInfoPtr_op_LessThan_Public_Static_bool4x3_double4x3_double4x3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600102F RID: 4143 RVA: 0x00058CAC File Offset: 0x00056EAC
		[CallerCount(0)]
		public unsafe static bool4x3 operator <(double4x3 lhs, double rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4x3.NativeMethodInfoPtr_op_LessThan_Public_Static_bool4x3_double4x3_Double_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001030 RID: 4144 RVA: 0x00058CF8 File Offset: 0x00056EF8
		[CallerCount(0)]
		public unsafe static bool4x3 operator <(double lhs, double4x3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4x3.NativeMethodInfoPtr_op_LessThan_Public_Static_bool4x3_Double_double4x3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001031 RID: 4145 RVA: 0x00058D44 File Offset: 0x00056F44
		[CallerCount(0)]
		public unsafe static bool4x3 operator <=(double4x3 lhs, double4x3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4x3.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool4x3_double4x3_double4x3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001032 RID: 4146 RVA: 0x00058D90 File Offset: 0x00056F90
		[CallerCount(0)]
		public unsafe static bool4x3 operator <=(double4x3 lhs, double rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4x3.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool4x3_double4x3_Double_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001033 RID: 4147 RVA: 0x00058DDC File Offset: 0x00056FDC
		[CallerCount(0)]
		public unsafe static bool4x3 operator <=(double lhs, double4x3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4x3.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool4x3_Double_double4x3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001034 RID: 4148 RVA: 0x00058E28 File Offset: 0x00057028
		[CallerCount(0)]
		public unsafe static bool4x3 operator >(double4x3 lhs, double4x3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4x3.NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool4x3_double4x3_double4x3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001035 RID: 4149 RVA: 0x00058E74 File Offset: 0x00057074
		[CallerCount(0)]
		public unsafe static bool4x3 operator >(double4x3 lhs, double rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4x3.NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool4x3_double4x3_Double_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001036 RID: 4150 RVA: 0x00058EC0 File Offset: 0x000570C0
		[CallerCount(0)]
		public unsafe static bool4x3 operator >(double lhs, double4x3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4x3.NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool4x3_Double_double4x3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001037 RID: 4151 RVA: 0x00058F0C File Offset: 0x0005710C
		[CallerCount(0)]
		public unsafe static bool4x3 operator >=(double4x3 lhs, double4x3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4x3.NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool4x3_double4x3_double4x3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001038 RID: 4152 RVA: 0x00058F58 File Offset: 0x00057158
		[CallerCount(0)]
		public unsafe static bool4x3 operator >=(double4x3 lhs, double rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4x3.NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool4x3_double4x3_Double_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001039 RID: 4153 RVA: 0x00058FA4 File Offset: 0x000571A4
		[CallerCount(0)]
		public unsafe static bool4x3 operator >=(double lhs, double4x3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4x3.NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool4x3_Double_double4x3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600103A RID: 4154 RVA: 0x00058FF0 File Offset: 0x000571F0
		[CallerCount(0)]
		public unsafe static double4x3 operator -(double4x3 val)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4x3.NativeMethodInfoPtr_op_UnaryNegation_Public_Static_double4x3_double4x3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600103B RID: 4155 RVA: 0x00059030 File Offset: 0x00057230
		[CallerCount(0)]
		public unsafe static double4x3 operator +(double4x3 val)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4x3.NativeMethodInfoPtr_op_UnaryPlus_Public_Static_double4x3_double4x3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600103C RID: 4156 RVA: 0x00059070 File Offset: 0x00057270
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 636157, XrefRangeEnd = 636169, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool4x3 operator ==(double4x3 lhs, double4x3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4x3.NativeMethodInfoPtr_op_Equality_Public_Static_bool4x3_double4x3_double4x3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600103D RID: 4157 RVA: 0x000590BC File Offset: 0x000572BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 636169, XrefRangeEnd = 636181, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool4x3 operator ==(double4x3 lhs, double rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4x3.NativeMethodInfoPtr_op_Equality_Public_Static_bool4x3_double4x3_Double_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600103E RID: 4158 RVA: 0x00059108 File Offset: 0x00057308
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 636181, XrefRangeEnd = 636193, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool4x3 operator ==(double lhs, double4x3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4x3.NativeMethodInfoPtr_op_Equality_Public_Static_bool4x3_Double_double4x3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600103F RID: 4159 RVA: 0x00059154 File Offset: 0x00057354
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 636193, XrefRangeEnd = 636205, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool4x3 operator !=(double4x3 lhs, double4x3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4x3.NativeMethodInfoPtr_op_Inequality_Public_Static_bool4x3_double4x3_double4x3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001040 RID: 4160 RVA: 0x000591A0 File Offset: 0x000573A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 636205, XrefRangeEnd = 636217, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool4x3 operator !=(double4x3 lhs, double rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4x3.NativeMethodInfoPtr_op_Inequality_Public_Static_bool4x3_double4x3_Double_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001041 RID: 4161 RVA: 0x000591EC File Offset: 0x000573EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 636217, XrefRangeEnd = 636229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool4x3 operator !=(double lhs, double4x3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4x3.NativeMethodInfoPtr_op_Inequality_Public_Static_bool4x3_Double_double4x3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x170003FC RID: 1020
		public unsafe ref double4 this[int index]
		{
			[CallerCount(0)]
			get
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref index;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4x3.NativeMethodInfoPtr_get_Item_Public_get_byref_double4_Int32_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return intPtr;
				}
			}
		}

		// Token: 0x06001043 RID: 4163 RVA: 0x0005926C File Offset: 0x0005746C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 636229, RefRangeEnd = 636230, XrefRangeStart = 636229, XrefRangeEnd = 636229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(double4x3 rhs)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref rhs;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4x3.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_double4x3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001044 RID: 4164 RVA: 0x000592AC File Offset: 0x000574AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 636230, XrefRangeEnd = 636234, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object o)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(o);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4x3.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001045 RID: 4165 RVA: 0x000592F0 File Offset: 0x000574F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 636234, XrefRangeEnd = 636235, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4x3.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001046 RID: 4166 RVA: 0x00059320 File Offset: 0x00057520
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 636235, XrefRangeEnd = 636290, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4x3.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001047 RID: 4167 RVA: 0x0005934C File Offset: 0x0005754C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 636290, XrefRangeEnd = 636358, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(double4x3.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001048 RID: 4168 RVA: 0x0000240C File Offset: 0x0000060C
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<double4x3>.NativeClassPtr, ref this));
		}

		// Token: 0x170003FB RID: 1019
		// (get) Token: 0x06001049 RID: 4169 RVA: 0x0005939C File Offset: 0x0005759C
		// (set) Token: 0x0600104A RID: 4170 RVA: 0x0000241E File Offset: 0x0000061E
		public unsafe static double4x3 zero
		{
			get
			{
				double4x3 double4x;
				IL2CPP.il2cpp_field_static_get_value(double4x3.NativeFieldInfoPtr_zero, (void*)(&double4x));
				return double4x;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(double4x3.NativeFieldInfoPtr_zero, (void*)(&value));
			}
		}

		// Token: 0x04001036 RID: 4150
		private static readonly IntPtr NativeFieldInfoPtr_c0;

		// Token: 0x04001037 RID: 4151
		private static readonly IntPtr NativeFieldInfoPtr_c1;

		// Token: 0x04001038 RID: 4152
		private static readonly IntPtr NativeFieldInfoPtr_c2;

		// Token: 0x04001039 RID: 4153
		private static readonly IntPtr NativeFieldInfoPtr_zero;

		// Token: 0x0400103A RID: 4154
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_double4_double4_double4_0;

		// Token: 0x0400103B RID: 4155
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Double_Double_Double_Double_Double_Double_Double_Double_Double_Double_Double_Double_0;

		// Token: 0x0400103C RID: 4156
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Double_0;

		// Token: 0x0400103D RID: 4157
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_0;

		// Token: 0x0400103E RID: 4158
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_bool4x3_0;

		// Token: 0x0400103F RID: 4159
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x04001040 RID: 4160
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_int4x3_0;

		// Token: 0x04001041 RID: 4161
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_UInt32_0;

		// Token: 0x04001042 RID: 4162
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_uint4x3_0;

		// Token: 0x04001043 RID: 4163
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_0;

		// Token: 0x04001044 RID: 4164
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_float4x3_0;

		// Token: 0x04001045 RID: 4165
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_double4x3_Double_0;

		// Token: 0x04001046 RID: 4166
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_double4x3_Boolean_0;

		// Token: 0x04001047 RID: 4167
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_double4x3_bool4x3_0;

		// Token: 0x04001048 RID: 4168
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_double4x3_Int32_0;

		// Token: 0x04001049 RID: 4169
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_double4x3_int4x3_0;

		// Token: 0x0400104A RID: 4170
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_double4x3_UInt32_0;

		// Token: 0x0400104B RID: 4171
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_double4x3_uint4x3_0;

		// Token: 0x0400104C RID: 4172
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_double4x3_Single_0;

		// Token: 0x0400104D RID: 4173
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_double4x3_float4x3_0;

		// Token: 0x0400104E RID: 4174
		private static readonly IntPtr NativeMethodInfoPtr_op_Multiply_Public_Static_double4x3_double4x3_double4x3_0;

		// Token: 0x0400104F RID: 4175
		private static readonly IntPtr NativeMethodInfoPtr_op_Multiply_Public_Static_double4x3_double4x3_Double_0;

		// Token: 0x04001050 RID: 4176
		private static readonly IntPtr NativeMethodInfoPtr_op_Multiply_Public_Static_double4x3_Double_double4x3_0;

		// Token: 0x04001051 RID: 4177
		private static readonly IntPtr NativeMethodInfoPtr_op_Addition_Public_Static_double4x3_double4x3_double4x3_0;

		// Token: 0x04001052 RID: 4178
		private static readonly IntPtr NativeMethodInfoPtr_op_Addition_Public_Static_double4x3_double4x3_Double_0;

		// Token: 0x04001053 RID: 4179
		private static readonly IntPtr NativeMethodInfoPtr_op_Addition_Public_Static_double4x3_Double_double4x3_0;

		// Token: 0x04001054 RID: 4180
		private static readonly IntPtr NativeMethodInfoPtr_op_Subtraction_Public_Static_double4x3_double4x3_double4x3_0;

		// Token: 0x04001055 RID: 4181
		private static readonly IntPtr NativeMethodInfoPtr_op_Subtraction_Public_Static_double4x3_double4x3_Double_0;

		// Token: 0x04001056 RID: 4182
		private static readonly IntPtr NativeMethodInfoPtr_op_Subtraction_Public_Static_double4x3_Double_double4x3_0;

		// Token: 0x04001057 RID: 4183
		private static readonly IntPtr NativeMethodInfoPtr_op_Division_Public_Static_double4x3_double4x3_double4x3_0;

		// Token: 0x04001058 RID: 4184
		private static readonly IntPtr NativeMethodInfoPtr_op_Division_Public_Static_double4x3_double4x3_Double_0;

		// Token: 0x04001059 RID: 4185
		private static readonly IntPtr NativeMethodInfoPtr_op_Division_Public_Static_double4x3_Double_double4x3_0;

		// Token: 0x0400105A RID: 4186
		private static readonly IntPtr NativeMethodInfoPtr_op_Modulus_Public_Static_double4x3_double4x3_double4x3_0;

		// Token: 0x0400105B RID: 4187
		private static readonly IntPtr NativeMethodInfoPtr_op_Modulus_Public_Static_double4x3_double4x3_Double_0;

		// Token: 0x0400105C RID: 4188
		private static readonly IntPtr NativeMethodInfoPtr_op_Modulus_Public_Static_double4x3_Double_double4x3_0;

		// Token: 0x0400105D RID: 4189
		private static readonly IntPtr NativeMethodInfoPtr_op_Increment_Public_Static_double4x3_double4x3_0;

		// Token: 0x0400105E RID: 4190
		private static readonly IntPtr NativeMethodInfoPtr_op_Decrement_Public_Static_double4x3_double4x3_0;

		// Token: 0x0400105F RID: 4191
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThan_Public_Static_bool4x3_double4x3_double4x3_0;

		// Token: 0x04001060 RID: 4192
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThan_Public_Static_bool4x3_double4x3_Double_0;

		// Token: 0x04001061 RID: 4193
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThan_Public_Static_bool4x3_Double_double4x3_0;

		// Token: 0x04001062 RID: 4194
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool4x3_double4x3_double4x3_0;

		// Token: 0x04001063 RID: 4195
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool4x3_double4x3_Double_0;

		// Token: 0x04001064 RID: 4196
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool4x3_Double_double4x3_0;

		// Token: 0x04001065 RID: 4197
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool4x3_double4x3_double4x3_0;

		// Token: 0x04001066 RID: 4198
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool4x3_double4x3_Double_0;

		// Token: 0x04001067 RID: 4199
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool4x3_Double_double4x3_0;

		// Token: 0x04001068 RID: 4200
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool4x3_double4x3_double4x3_0;

		// Token: 0x04001069 RID: 4201
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool4x3_double4x3_Double_0;

		// Token: 0x0400106A RID: 4202
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool4x3_Double_double4x3_0;

		// Token: 0x0400106B RID: 4203
		private static readonly IntPtr NativeMethodInfoPtr_op_UnaryNegation_Public_Static_double4x3_double4x3_0;

		// Token: 0x0400106C RID: 4204
		private static readonly IntPtr NativeMethodInfoPtr_op_UnaryPlus_Public_Static_double4x3_double4x3_0;

		// Token: 0x0400106D RID: 4205
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_bool4x3_double4x3_double4x3_0;

		// Token: 0x0400106E RID: 4206
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_bool4x3_double4x3_Double_0;

		// Token: 0x0400106F RID: 4207
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_bool4x3_Double_double4x3_0;

		// Token: 0x04001070 RID: 4208
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_bool4x3_double4x3_double4x3_0;

		// Token: 0x04001071 RID: 4209
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_bool4x3_double4x3_Double_0;

		// Token: 0x04001072 RID: 4210
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_bool4x3_Double_double4x3_0;

		// Token: 0x04001073 RID: 4211
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_get_byref_double4_Int32_0;

		// Token: 0x04001074 RID: 4212
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_double4x3_0;

		// Token: 0x04001075 RID: 4213
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04001076 RID: 4214
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04001077 RID: 4215
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04001078 RID: 4216
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0;

		// Token: 0x04001079 RID: 4217
		[FieldOffset(0)]
		public double4 c0;

		// Token: 0x0400107A RID: 4218
		[FieldOffset(32)]
		public double4 c1;

		// Token: 0x0400107B RID: 4219
		[FieldOffset(64)]
		public double4 c2;
	}
}
