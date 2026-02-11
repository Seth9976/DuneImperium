using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Unity.Mathematics
{
	// Token: 0x0200001D RID: 29
	[Serializable]
	[StructLayout(2)]
	public struct float2
	{
		// Token: 0x06001090 RID: 4240 RVA: 0x0005AB30 File Offset: 0x00058D30
		// Note: this type is marked as 'beforefieldinit'.
		static float2()
		{
			Il2CppClassPointerStore<float2>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Mathematics.dll", "Unity.Mathematics", "float2");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<float2>.NativeClassPtr);
			float2.NativeFieldInfoPtr_x = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<float2>.NativeClassPtr, "x");
			float2.NativeFieldInfoPtr_y = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<float2>.NativeClassPtr, "y");
			float2.NativeFieldInfoPtr_zero = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<float2>.NativeClassPtr, "zero");
			float2.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float2>.NativeClassPtr, 100667417);
			float2.NativeMethodInfoPtr__ctor_Public_Void_float2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float2>.NativeClassPtr, 100667418);
			float2.NativeMethodInfoPtr__ctor_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float2>.NativeClassPtr, 100667419);
			float2.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float2>.NativeClassPtr, 100667420);
			float2.NativeMethodInfoPtr__ctor_Public_Void_bool2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float2>.NativeClassPtr, 100667421);
			float2.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float2>.NativeClassPtr, 100667422);
			float2.NativeMethodInfoPtr__ctor_Public_Void_int2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float2>.NativeClassPtr, 100667423);
			float2.NativeMethodInfoPtr__ctor_Public_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float2>.NativeClassPtr, 100667424);
			float2.NativeMethodInfoPtr__ctor_Public_Void_uint2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float2>.NativeClassPtr, 100667425);
			float2.NativeMethodInfoPtr__ctor_Public_Void_half_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float2>.NativeClassPtr, 100667426);
			float2.NativeMethodInfoPtr__ctor_Public_Void_half2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float2>.NativeClassPtr, 100667427);
			float2.NativeMethodInfoPtr__ctor_Public_Void_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float2>.NativeClassPtr, 100667428);
			float2.NativeMethodInfoPtr__ctor_Public_Void_double2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float2>.NativeClassPtr, 100667429);
			float2.NativeMethodInfoPtr_op_Implicit_Public_Static_float2_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float2>.NativeClassPtr, 100667430);
			float2.NativeMethodInfoPtr_op_Explicit_Public_Static_float2_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float2>.NativeClassPtr, 100667431);
			float2.NativeMethodInfoPtr_op_Explicit_Public_Static_float2_bool2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float2>.NativeClassPtr, 100667432);
			float2.NativeMethodInfoPtr_op_Implicit_Public_Static_float2_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float2>.NativeClassPtr, 100667433);
			float2.NativeMethodInfoPtr_op_Implicit_Public_Static_float2_int2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float2>.NativeClassPtr, 100667434);
			float2.NativeMethodInfoPtr_op_Implicit_Public_Static_float2_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float2>.NativeClassPtr, 100667435);
			float2.NativeMethodInfoPtr_op_Implicit_Public_Static_float2_uint2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float2>.NativeClassPtr, 100667436);
			float2.NativeMethodInfoPtr_op_Implicit_Public_Static_float2_half_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float2>.NativeClassPtr, 100667437);
			float2.NativeMethodInfoPtr_op_Implicit_Public_Static_float2_half2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float2>.NativeClassPtr, 100667438);
			float2.NativeMethodInfoPtr_op_Explicit_Public_Static_float2_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float2>.NativeClassPtr, 100667439);
			float2.NativeMethodInfoPtr_op_Explicit_Public_Static_float2_double2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float2>.NativeClassPtr, 100667440);
			float2.NativeMethodInfoPtr_op_Multiply_Public_Static_float2_float2_float2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float2>.NativeClassPtr, 100667441);
			float2.NativeMethodInfoPtr_op_Multiply_Public_Static_float2_float2_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float2>.NativeClassPtr, 100667442);
			float2.NativeMethodInfoPtr_op_Multiply_Public_Static_float2_Single_float2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float2>.NativeClassPtr, 100667443);
			float2.NativeMethodInfoPtr_op_Addition_Public_Static_float2_float2_float2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float2>.NativeClassPtr, 100667444);
			float2.NativeMethodInfoPtr_op_Addition_Public_Static_float2_float2_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float2>.NativeClassPtr, 100667445);
			float2.NativeMethodInfoPtr_op_Addition_Public_Static_float2_Single_float2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float2>.NativeClassPtr, 100667446);
			float2.NativeMethodInfoPtr_op_Subtraction_Public_Static_float2_float2_float2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float2>.NativeClassPtr, 100667447);
			float2.NativeMethodInfoPtr_op_Subtraction_Public_Static_float2_float2_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float2>.NativeClassPtr, 100667448);
			float2.NativeMethodInfoPtr_op_Subtraction_Public_Static_float2_Single_float2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float2>.NativeClassPtr, 100667449);
			float2.NativeMethodInfoPtr_op_Division_Public_Static_float2_float2_float2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float2>.NativeClassPtr, 100667450);
			float2.NativeMethodInfoPtr_op_Division_Public_Static_float2_float2_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float2>.NativeClassPtr, 100667451);
			float2.NativeMethodInfoPtr_op_Division_Public_Static_float2_Single_float2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float2>.NativeClassPtr, 100667452);
			float2.NativeMethodInfoPtr_op_Modulus_Public_Static_float2_float2_float2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float2>.NativeClassPtr, 100667453);
			float2.NativeMethodInfoPtr_op_Modulus_Public_Static_float2_float2_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float2>.NativeClassPtr, 100667454);
			float2.NativeMethodInfoPtr_op_Modulus_Public_Static_float2_Single_float2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float2>.NativeClassPtr, 100667455);
			float2.NativeMethodInfoPtr_op_Increment_Public_Static_float2_float2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float2>.NativeClassPtr, 100667456);
			float2.NativeMethodInfoPtr_op_Decrement_Public_Static_float2_float2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float2>.NativeClassPtr, 100667457);
			float2.NativeMethodInfoPtr_op_LessThan_Public_Static_bool2_float2_float2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float2>.NativeClassPtr, 100667458);
			float2.NativeMethodInfoPtr_op_LessThan_Public_Static_bool2_float2_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float2>.NativeClassPtr, 100667459);
			float2.NativeMethodInfoPtr_op_LessThan_Public_Static_bool2_Single_float2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float2>.NativeClassPtr, 100667460);
			float2.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool2_float2_float2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float2>.NativeClassPtr, 100667461);
			float2.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool2_float2_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float2>.NativeClassPtr, 100667462);
			float2.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool2_Single_float2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float2>.NativeClassPtr, 100667463);
			float2.NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool2_float2_float2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float2>.NativeClassPtr, 100667464);
			float2.NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool2_float2_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float2>.NativeClassPtr, 100667465);
			float2.NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool2_Single_float2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float2>.NativeClassPtr, 100667466);
			float2.NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool2_float2_float2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float2>.NativeClassPtr, 100667467);
			float2.NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool2_float2_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float2>.NativeClassPtr, 100667468);
			float2.NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool2_Single_float2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float2>.NativeClassPtr, 100667469);
			float2.NativeMethodInfoPtr_op_UnaryNegation_Public_Static_float2_float2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float2>.NativeClassPtr, 100667470);
			float2.NativeMethodInfoPtr_op_UnaryPlus_Public_Static_float2_float2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float2>.NativeClassPtr, 100667471);
			float2.NativeMethodInfoPtr_op_Equality_Public_Static_bool2_float2_float2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float2>.NativeClassPtr, 100667472);
			float2.NativeMethodInfoPtr_op_Equality_Public_Static_bool2_float2_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float2>.NativeClassPtr, 100667473);
			float2.NativeMethodInfoPtr_op_Equality_Public_Static_bool2_Single_float2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float2>.NativeClassPtr, 100667474);
			float2.NativeMethodInfoPtr_op_Inequality_Public_Static_bool2_float2_float2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float2>.NativeClassPtr, 100667475);
			float2.NativeMethodInfoPtr_op_Inequality_Public_Static_bool2_float2_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float2>.NativeClassPtr, 100667476);
			float2.NativeMethodInfoPtr_op_Inequality_Public_Static_bool2_Single_float2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float2>.NativeClassPtr, 100667477);
			float2.NativeMethodInfoPtr_get_xxxx_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float2>.NativeClassPtr, 100667478);
			float2.NativeMethodInfoPtr_get_xxxy_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float2>.NativeClassPtr, 100667479);
			float2.NativeMethodInfoPtr_get_xxyx_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float2>.NativeClassPtr, 100667480);
			float2.NativeMethodInfoPtr_get_xxyy_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float2>.NativeClassPtr, 100667481);
			float2.NativeMethodInfoPtr_get_xyxx_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float2>.NativeClassPtr, 100667482);
			float2.NativeMethodInfoPtr_get_xyxy_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float2>.NativeClassPtr, 100667483);
			float2.NativeMethodInfoPtr_get_xyyx_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float2>.NativeClassPtr, 100667484);
			float2.NativeMethodInfoPtr_get_xyyy_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float2>.NativeClassPtr, 100667485);
			float2.NativeMethodInfoPtr_get_yxxx_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float2>.NativeClassPtr, 100667486);
			float2.NativeMethodInfoPtr_get_yxxy_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float2>.NativeClassPtr, 100667487);
			float2.NativeMethodInfoPtr_get_yxyx_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float2>.NativeClassPtr, 100667488);
			float2.NativeMethodInfoPtr_get_yxyy_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float2>.NativeClassPtr, 100667489);
			float2.NativeMethodInfoPtr_get_yyxx_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float2>.NativeClassPtr, 100667490);
			float2.NativeMethodInfoPtr_get_yyxy_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float2>.NativeClassPtr, 100667491);
			float2.NativeMethodInfoPtr_get_yyyx_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float2>.NativeClassPtr, 100667492);
			float2.NativeMethodInfoPtr_get_yyyy_Public_get_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float2>.NativeClassPtr, 100667493);
			float2.NativeMethodInfoPtr_get_xxx_Public_get_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float2>.NativeClassPtr, 100667494);
			float2.NativeMethodInfoPtr_get_xxy_Public_get_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float2>.NativeClassPtr, 100667495);
			float2.NativeMethodInfoPtr_get_xyx_Public_get_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float2>.NativeClassPtr, 100667496);
			float2.NativeMethodInfoPtr_get_xyy_Public_get_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float2>.NativeClassPtr, 100667497);
			float2.NativeMethodInfoPtr_get_yxx_Public_get_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float2>.NativeClassPtr, 100667498);
			float2.NativeMethodInfoPtr_get_yxy_Public_get_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float2>.NativeClassPtr, 100667499);
			float2.NativeMethodInfoPtr_get_yyx_Public_get_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float2>.NativeClassPtr, 100667500);
			float2.NativeMethodInfoPtr_get_yyy_Public_get_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float2>.NativeClassPtr, 100667501);
			float2.NativeMethodInfoPtr_get_xx_Public_get_float2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float2>.NativeClassPtr, 100667502);
			float2.NativeMethodInfoPtr_get_xy_Public_get_float2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float2>.NativeClassPtr, 100667503);
			float2.NativeMethodInfoPtr_set_xy_Public_set_Void_float2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float2>.NativeClassPtr, 100667504);
			float2.NativeMethodInfoPtr_get_yx_Public_get_float2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float2>.NativeClassPtr, 100667505);
			float2.NativeMethodInfoPtr_set_yx_Public_set_Void_float2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float2>.NativeClassPtr, 100667506);
			float2.NativeMethodInfoPtr_get_yy_Public_get_float2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float2>.NativeClassPtr, 100667507);
			float2.NativeMethodInfoPtr_get_Item_Public_get_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float2>.NativeClassPtr, 100667508);
			float2.NativeMethodInfoPtr_set_Item_Public_set_Void_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float2>.NativeClassPtr, 100667509);
			float2.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_float2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float2>.NativeClassPtr, 100667510);
			float2.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float2>.NativeClassPtr, 100667511);
			float2.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float2>.NativeClassPtr, 100667512);
			float2.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float2>.NativeClassPtr, 100667513);
			float2.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float2>.NativeClassPtr, 100667514);
			float2.NativeMethodInfoPtr_op_Implicit_Public_Static_Vector2_float2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float2>.NativeClassPtr, 100667515);
			float2.NativeMethodInfoPtr_op_Implicit_Public_Static_float2_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float2>.NativeClassPtr, 100667516);
		}

		// Token: 0x06001091 RID: 4241 RVA: 0x0005B36C File Offset: 0x0005956C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 611799, RefRangeEnd = 611804, XrefRangeStart = 611799, XrefRangeEnd = 611804, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float2(float x, float y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float2.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001092 RID: 4242 RVA: 0x0005B3AC File Offset: 0x000595AC
		[CallerCount(0)]
		public unsafe float2(float2 xy)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref xy;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float2.NativeMethodInfoPtr__ctor_Public_Void_float2_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001093 RID: 4243 RVA: 0x0005B3E0 File Offset: 0x000595E0
		[CallerCount(0)]
		public unsafe float2(float v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float2.NativeMethodInfoPtr__ctor_Public_Void_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001094 RID: 4244 RVA: 0x0005B414 File Offset: 0x00059614
		[CallerCount(0)]
		public unsafe float2(bool v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float2.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001095 RID: 4245 RVA: 0x0005B448 File Offset: 0x00059648
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 636694, XrefRangeEnd = 636695, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float2(bool2 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float2.NativeMethodInfoPtr__ctor_Public_Void_bool2_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001096 RID: 4246 RVA: 0x0005B47C File Offset: 0x0005967C
		[CallerCount(0)]
		public unsafe float2(int v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float2.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001097 RID: 4247 RVA: 0x0005B4B0 File Offset: 0x000596B0
		[CallerCount(0)]
		public unsafe float2(int2 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float2.NativeMethodInfoPtr__ctor_Public_Void_int2_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001098 RID: 4248 RVA: 0x0005B4E4 File Offset: 0x000596E4
		[CallerCount(0)]
		public unsafe float2(uint v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float2.NativeMethodInfoPtr__ctor_Public_Void_UInt32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001099 RID: 4249 RVA: 0x0005B518 File Offset: 0x00059718
		[CallerCount(0)]
		public unsafe float2(uint2 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float2.NativeMethodInfoPtr__ctor_Public_Void_uint2_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600109A RID: 4250 RVA: 0x0005B54C File Offset: 0x0005974C
		[CallerCount(0)]
		public unsafe float2(half v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float2.NativeMethodInfoPtr__ctor_Public_Void_half_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600109B RID: 4251 RVA: 0x0005B580 File Offset: 0x00059780
		[CallerCount(0)]
		public unsafe float2(half2 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float2.NativeMethodInfoPtr__ctor_Public_Void_half2_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600109C RID: 4252 RVA: 0x0005B5B4 File Offset: 0x000597B4
		[CallerCount(0)]
		public unsafe float2(double v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float2.NativeMethodInfoPtr__ctor_Public_Void_Double_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600109D RID: 4253 RVA: 0x0005B5E8 File Offset: 0x000597E8
		[CallerCount(0)]
		public unsafe float2(double2 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float2.NativeMethodInfoPtr__ctor_Public_Void_double2_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600109E RID: 4254 RVA: 0x0005B61C File Offset: 0x0005981C
		[CallerCount(0)]
		public unsafe static implicit operator float2(float v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float2.NativeMethodInfoPtr_op_Implicit_Public_Static_float2_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600109F RID: 4255 RVA: 0x0005B65C File Offset: 0x0005985C
		[CallerCount(0)]
		public unsafe static explicit operator float2(bool v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float2.NativeMethodInfoPtr_op_Explicit_Public_Static_float2_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060010A0 RID: 4256 RVA: 0x0005B69C File Offset: 0x0005989C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator float2(bool2 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float2.NativeMethodInfoPtr_op_Explicit_Public_Static_float2_bool2_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060010A1 RID: 4257 RVA: 0x0005B6DC File Offset: 0x000598DC
		[CallerCount(0)]
		public unsafe static implicit operator float2(int v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float2.NativeMethodInfoPtr_op_Implicit_Public_Static_float2_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060010A2 RID: 4258 RVA: 0x0005B71C File Offset: 0x0005991C
		[CallerCount(0)]
		public unsafe static implicit operator float2(int2 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float2.NativeMethodInfoPtr_op_Implicit_Public_Static_float2_int2_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060010A3 RID: 4259 RVA: 0x0005B75C File Offset: 0x0005995C
		[CallerCount(0)]
		public unsafe static implicit operator float2(uint v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float2.NativeMethodInfoPtr_op_Implicit_Public_Static_float2_UInt32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060010A4 RID: 4260 RVA: 0x0005B79C File Offset: 0x0005999C
		[CallerCount(0)]
		public unsafe static implicit operator float2(uint2 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float2.NativeMethodInfoPtr_op_Implicit_Public_Static_float2_uint2_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060010A5 RID: 4261 RVA: 0x0005B7DC File Offset: 0x000599DC
		[CallerCount(0)]
		public unsafe static implicit operator float2(half v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float2.NativeMethodInfoPtr_op_Implicit_Public_Static_float2_half_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060010A6 RID: 4262 RVA: 0x0005B81C File Offset: 0x00059A1C
		[CallerCount(0)]
		public unsafe static implicit operator float2(half2 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float2.NativeMethodInfoPtr_op_Implicit_Public_Static_float2_half2_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060010A7 RID: 4263 RVA: 0x0005B85C File Offset: 0x00059A5C
		[CallerCount(0)]
		public unsafe static explicit operator float2(double v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float2.NativeMethodInfoPtr_op_Explicit_Public_Static_float2_Double_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060010A8 RID: 4264 RVA: 0x0005B89C File Offset: 0x00059A9C
		[CallerCount(0)]
		public unsafe static explicit operator float2(double2 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float2.NativeMethodInfoPtr_op_Explicit_Public_Static_float2_double2_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060010A9 RID: 4265 RVA: 0x0005B8DC File Offset: 0x00059ADC
		[CallerCount(0)]
		public unsafe static float2 operator *(float2 lhs, float2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float2.NativeMethodInfoPtr_op_Multiply_Public_Static_float2_float2_float2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060010AA RID: 4266 RVA: 0x0005B928 File Offset: 0x00059B28
		[CallerCount(0)]
		public unsafe static float2 operator *(float2 lhs, float rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float2.NativeMethodInfoPtr_op_Multiply_Public_Static_float2_float2_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060010AB RID: 4267 RVA: 0x0005B974 File Offset: 0x00059B74
		[CallerCount(0)]
		public unsafe static float2 operator *(float lhs, float2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float2.NativeMethodInfoPtr_op_Multiply_Public_Static_float2_Single_float2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060010AC RID: 4268 RVA: 0x0005B9C0 File Offset: 0x00059BC0
		[CallerCount(0)]
		public unsafe static float2 operator +(float2 lhs, float2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float2.NativeMethodInfoPtr_op_Addition_Public_Static_float2_float2_float2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060010AD RID: 4269 RVA: 0x0005BA0C File Offset: 0x00059C0C
		[CallerCount(0)]
		public unsafe static float2 operator +(float2 lhs, float rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float2.NativeMethodInfoPtr_op_Addition_Public_Static_float2_float2_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060010AE RID: 4270 RVA: 0x0005BA58 File Offset: 0x00059C58
		[CallerCount(0)]
		public unsafe static float2 operator +(float lhs, float2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float2.NativeMethodInfoPtr_op_Addition_Public_Static_float2_Single_float2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060010AF RID: 4271 RVA: 0x0005BAA4 File Offset: 0x00059CA4
		[CallerCount(0)]
		public unsafe static float2 operator -(float2 lhs, float2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float2.NativeMethodInfoPtr_op_Subtraction_Public_Static_float2_float2_float2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060010B0 RID: 4272 RVA: 0x0005BAF0 File Offset: 0x00059CF0
		[CallerCount(0)]
		public unsafe static float2 operator -(float2 lhs, float rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float2.NativeMethodInfoPtr_op_Subtraction_Public_Static_float2_float2_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060010B1 RID: 4273 RVA: 0x0005BB3C File Offset: 0x00059D3C
		[CallerCount(0)]
		public unsafe static float2 operator -(float lhs, float2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float2.NativeMethodInfoPtr_op_Subtraction_Public_Static_float2_Single_float2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060010B2 RID: 4274 RVA: 0x0005BB88 File Offset: 0x00059D88
		[CallerCount(0)]
		public unsafe static float2 operator /(float2 lhs, float2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float2.NativeMethodInfoPtr_op_Division_Public_Static_float2_float2_float2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060010B3 RID: 4275 RVA: 0x0005BBD4 File Offset: 0x00059DD4
		[CallerCount(0)]
		public unsafe static float2 operator /(float2 lhs, float rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float2.NativeMethodInfoPtr_op_Division_Public_Static_float2_float2_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060010B4 RID: 4276 RVA: 0x0005BC20 File Offset: 0x00059E20
		[CallerCount(0)]
		public unsafe static float2 operator /(float lhs, float2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float2.NativeMethodInfoPtr_op_Division_Public_Static_float2_Single_float2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060010B5 RID: 4277 RVA: 0x0005BC6C File Offset: 0x00059E6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float2 operator %(float2 lhs, float2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float2.NativeMethodInfoPtr_op_Modulus_Public_Static_float2_float2_float2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060010B6 RID: 4278 RVA: 0x0005BCB8 File Offset: 0x00059EB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 636695, XrefRangeEnd = 636697, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float2 operator %(float2 lhs, float rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float2.NativeMethodInfoPtr_op_Modulus_Public_Static_float2_float2_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060010B7 RID: 4279 RVA: 0x0005BD04 File Offset: 0x00059F04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 636697, XrefRangeEnd = 636699, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float2 operator %(float lhs, float2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float2.NativeMethodInfoPtr_op_Modulus_Public_Static_float2_Single_float2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060010B8 RID: 4280 RVA: 0x0005BD50 File Offset: 0x00059F50
		[CallerCount(0)]
		public unsafe static float2 operator ++(float2 val)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float2.NativeMethodInfoPtr_op_Increment_Public_Static_float2_float2_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060010B9 RID: 4281 RVA: 0x0005BD90 File Offset: 0x00059F90
		[CallerCount(0)]
		public unsafe static float2 operator --(float2 val)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float2.NativeMethodInfoPtr_op_Decrement_Public_Static_float2_float2_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060010BA RID: 4282 RVA: 0x0005BDD0 File Offset: 0x00059FD0
		[CallerCount(0)]
		public unsafe static bool2 operator <(float2 lhs, float2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float2.NativeMethodInfoPtr_op_LessThan_Public_Static_bool2_float2_float2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060010BB RID: 4283 RVA: 0x0005BE1C File Offset: 0x0005A01C
		[CallerCount(0)]
		public unsafe static bool2 operator <(float2 lhs, float rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float2.NativeMethodInfoPtr_op_LessThan_Public_Static_bool2_float2_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060010BC RID: 4284 RVA: 0x0005BE68 File Offset: 0x0005A068
		[CallerCount(0)]
		public unsafe static bool2 operator <(float lhs, float2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float2.NativeMethodInfoPtr_op_LessThan_Public_Static_bool2_Single_float2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060010BD RID: 4285 RVA: 0x0005BEB4 File Offset: 0x0005A0B4
		[CallerCount(0)]
		public unsafe static bool2 operator <=(float2 lhs, float2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float2.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool2_float2_float2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060010BE RID: 4286 RVA: 0x0005BF00 File Offset: 0x0005A100
		[CallerCount(0)]
		public unsafe static bool2 operator <=(float2 lhs, float rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float2.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool2_float2_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060010BF RID: 4287 RVA: 0x0005BF4C File Offset: 0x0005A14C
		[CallerCount(0)]
		public unsafe static bool2 operator <=(float lhs, float2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float2.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool2_Single_float2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060010C0 RID: 4288 RVA: 0x0005BF98 File Offset: 0x0005A198
		[CallerCount(0)]
		public unsafe static bool2 operator >(float2 lhs, float2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float2.NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool2_float2_float2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060010C1 RID: 4289 RVA: 0x0005BFE4 File Offset: 0x0005A1E4
		[CallerCount(0)]
		public unsafe static bool2 operator >(float2 lhs, float rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float2.NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool2_float2_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060010C2 RID: 4290 RVA: 0x0005C030 File Offset: 0x0005A230
		[CallerCount(0)]
		public unsafe static bool2 operator >(float lhs, float2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float2.NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool2_Single_float2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060010C3 RID: 4291 RVA: 0x0005C07C File Offset: 0x0005A27C
		[CallerCount(0)]
		public unsafe static bool2 operator >=(float2 lhs, float2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float2.NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool2_float2_float2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060010C4 RID: 4292 RVA: 0x0005C0C8 File Offset: 0x0005A2C8
		[CallerCount(0)]
		public unsafe static bool2 operator >=(float2 lhs, float rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float2.NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool2_float2_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060010C5 RID: 4293 RVA: 0x0005C114 File Offset: 0x0005A314
		[CallerCount(0)]
		public unsafe static bool2 operator >=(float lhs, float2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float2.NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool2_Single_float2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060010C6 RID: 4294 RVA: 0x0005C160 File Offset: 0x0005A360
		[CallerCount(0)]
		public unsafe static float2 operator -(float2 val)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float2.NativeMethodInfoPtr_op_UnaryNegation_Public_Static_float2_float2_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060010C7 RID: 4295 RVA: 0x0005C1A0 File Offset: 0x0005A3A0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 630534, RefRangeEnd = 630538, XrefRangeStart = 630534, XrefRangeEnd = 630538, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float2 operator +(float2 val)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float2.NativeMethodInfoPtr_op_UnaryPlus_Public_Static_float2_float2_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060010C8 RID: 4296 RVA: 0x0005C1E0 File Offset: 0x0005A3E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 636699, XrefRangeEnd = 636700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool2 operator ==(float2 lhs, float2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float2.NativeMethodInfoPtr_op_Equality_Public_Static_bool2_float2_float2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060010C9 RID: 4297 RVA: 0x0005C22C File Offset: 0x0005A42C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 636700, XrefRangeEnd = 636701, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool2 operator ==(float2 lhs, float rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float2.NativeMethodInfoPtr_op_Equality_Public_Static_bool2_float2_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060010CA RID: 4298 RVA: 0x0005C278 File Offset: 0x0005A478
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 636701, XrefRangeEnd = 636702, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool2 operator ==(float lhs, float2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float2.NativeMethodInfoPtr_op_Equality_Public_Static_bool2_Single_float2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060010CB RID: 4299 RVA: 0x0005C2C4 File Offset: 0x0005A4C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 636702, XrefRangeEnd = 636703, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool2 operator !=(float2 lhs, float2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float2.NativeMethodInfoPtr_op_Inequality_Public_Static_bool2_float2_float2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060010CC RID: 4300 RVA: 0x0005C310 File Offset: 0x0005A510
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 636703, XrefRangeEnd = 636704, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool2 operator !=(float2 lhs, float rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float2.NativeMethodInfoPtr_op_Inequality_Public_Static_bool2_float2_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060010CD RID: 4301 RVA: 0x0005C35C File Offset: 0x0005A55C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 636704, XrefRangeEnd = 636705, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool2 operator !=(float lhs, float2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float2.NativeMethodInfoPtr_op_Inequality_Public_Static_bool2_Single_float2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000401 RID: 1025
		// (get) Token: 0x060010CE RID: 4302 RVA: 0x0005C3A8 File Offset: 0x0005A5A8
		public unsafe float4 xxxx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float2.NativeMethodInfoPtr_get_xxxx_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000402 RID: 1026
		// (get) Token: 0x060010CF RID: 4303 RVA: 0x0005C3D8 File Offset: 0x0005A5D8
		public unsafe float4 xxxy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float2.NativeMethodInfoPtr_get_xxxy_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000403 RID: 1027
		// (get) Token: 0x060010D0 RID: 4304 RVA: 0x0005C408 File Offset: 0x0005A608
		public unsafe float4 xxyx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float2.NativeMethodInfoPtr_get_xxyx_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000404 RID: 1028
		// (get) Token: 0x060010D1 RID: 4305 RVA: 0x0005C438 File Offset: 0x0005A638
		public unsafe float4 xxyy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float2.NativeMethodInfoPtr_get_xxyy_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000405 RID: 1029
		// (get) Token: 0x060010D2 RID: 4306 RVA: 0x0005C468 File Offset: 0x0005A668
		public unsafe float4 xyxx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float2.NativeMethodInfoPtr_get_xyxx_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000406 RID: 1030
		// (get) Token: 0x060010D3 RID: 4307 RVA: 0x0005C498 File Offset: 0x0005A698
		public unsafe float4 xyxy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float2.NativeMethodInfoPtr_get_xyxy_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000407 RID: 1031
		// (get) Token: 0x060010D4 RID: 4308 RVA: 0x0005C4C8 File Offset: 0x0005A6C8
		public unsafe float4 xyyx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float2.NativeMethodInfoPtr_get_xyyx_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000408 RID: 1032
		// (get) Token: 0x060010D5 RID: 4309 RVA: 0x0005C4F8 File Offset: 0x0005A6F8
		public unsafe float4 xyyy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float2.NativeMethodInfoPtr_get_xyyy_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000409 RID: 1033
		// (get) Token: 0x060010D6 RID: 4310 RVA: 0x0005C528 File Offset: 0x0005A728
		public unsafe float4 yxxx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float2.NativeMethodInfoPtr_get_yxxx_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700040A RID: 1034
		// (get) Token: 0x060010D7 RID: 4311 RVA: 0x0005C558 File Offset: 0x0005A758
		public unsafe float4 yxxy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float2.NativeMethodInfoPtr_get_yxxy_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700040B RID: 1035
		// (get) Token: 0x060010D8 RID: 4312 RVA: 0x0005C588 File Offset: 0x0005A788
		public unsafe float4 yxyx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float2.NativeMethodInfoPtr_get_yxyx_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700040C RID: 1036
		// (get) Token: 0x060010D9 RID: 4313 RVA: 0x0005C5B8 File Offset: 0x0005A7B8
		public unsafe float4 yxyy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float2.NativeMethodInfoPtr_get_yxyy_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700040D RID: 1037
		// (get) Token: 0x060010DA RID: 4314 RVA: 0x0005C5E8 File Offset: 0x0005A7E8
		public unsafe float4 yyxx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float2.NativeMethodInfoPtr_get_yyxx_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700040E RID: 1038
		// (get) Token: 0x060010DB RID: 4315 RVA: 0x0005C618 File Offset: 0x0005A818
		public unsafe float4 yyxy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float2.NativeMethodInfoPtr_get_yyxy_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700040F RID: 1039
		// (get) Token: 0x060010DC RID: 4316 RVA: 0x0005C648 File Offset: 0x0005A848
		public unsafe float4 yyyx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float2.NativeMethodInfoPtr_get_yyyx_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000410 RID: 1040
		// (get) Token: 0x060010DD RID: 4317 RVA: 0x0005C678 File Offset: 0x0005A878
		public unsafe float4 yyyy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float2.NativeMethodInfoPtr_get_yyyy_Public_get_float4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000411 RID: 1041
		// (get) Token: 0x060010DE RID: 4318 RVA: 0x0005C6A8 File Offset: 0x0005A8A8
		public unsafe float3 xxx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float2.NativeMethodInfoPtr_get_xxx_Public_get_float3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000412 RID: 1042
		// (get) Token: 0x060010DF RID: 4319 RVA: 0x0005C6D8 File Offset: 0x0005A8D8
		public unsafe float3 xxy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float2.NativeMethodInfoPtr_get_xxy_Public_get_float3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000413 RID: 1043
		// (get) Token: 0x060010E0 RID: 4320 RVA: 0x0005C708 File Offset: 0x0005A908
		public unsafe float3 xyx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float2.NativeMethodInfoPtr_get_xyx_Public_get_float3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000414 RID: 1044
		// (get) Token: 0x060010E1 RID: 4321 RVA: 0x0005C738 File Offset: 0x0005A938
		public unsafe float3 xyy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float2.NativeMethodInfoPtr_get_xyy_Public_get_float3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000415 RID: 1045
		// (get) Token: 0x060010E2 RID: 4322 RVA: 0x0005C768 File Offset: 0x0005A968
		public unsafe float3 yxx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float2.NativeMethodInfoPtr_get_yxx_Public_get_float3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000416 RID: 1046
		// (get) Token: 0x060010E3 RID: 4323 RVA: 0x0005C798 File Offset: 0x0005A998
		public unsafe float3 yxy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float2.NativeMethodInfoPtr_get_yxy_Public_get_float3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000417 RID: 1047
		// (get) Token: 0x060010E4 RID: 4324 RVA: 0x0005C7C8 File Offset: 0x0005A9C8
		public unsafe float3 yyx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float2.NativeMethodInfoPtr_get_yyx_Public_get_float3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000418 RID: 1048
		// (get) Token: 0x060010E5 RID: 4325 RVA: 0x0005C7F8 File Offset: 0x0005A9F8
		public unsafe float3 yyy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float2.NativeMethodInfoPtr_get_yyy_Public_get_float3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000419 RID: 1049
		// (get) Token: 0x060010E6 RID: 4326 RVA: 0x0005C828 File Offset: 0x0005AA28
		public unsafe float2 xx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float2.NativeMethodInfoPtr_get_xx_Public_get_float2_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700041A RID: 1050
		// (get) Token: 0x060010E7 RID: 4327 RVA: 0x0005C858 File Offset: 0x0005AA58
		// (set) Token: 0x060010E8 RID: 4328 RVA: 0x0005C888 File Offset: 0x0005AA88
		public unsafe float2 xy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float2.NativeMethodInfoPtr_get_xy_Public_get_float2_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float2.NativeMethodInfoPtr_set_xy_Public_set_Void_float2_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700041B RID: 1051
		// (get) Token: 0x060010E9 RID: 4329 RVA: 0x0005C8BC File Offset: 0x0005AABC
		// (set) Token: 0x060010EA RID: 4330 RVA: 0x0005C8EC File Offset: 0x0005AAEC
		public unsafe float2 yx
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float2.NativeMethodInfoPtr_get_yx_Public_get_float2_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float2.NativeMethodInfoPtr_set_yx_Public_set_Void_float2_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700041C RID: 1052
		// (get) Token: 0x060010EB RID: 4331 RVA: 0x0005C920 File Offset: 0x0005AB20
		public unsafe float2 yy
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float2.NativeMethodInfoPtr_get_yy_Public_get_float2_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700041D RID: 1053
		public unsafe float this[int index]
		{
			[CallerCount(16)]
			[CachedScanResults(RefRangeStart = 611804, RefRangeEnd = 611820, XrefRangeStart = 611804, XrefRangeEnd = 611820, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref index;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float2.NativeMethodInfoPtr_get_Item_Public_get_Single_Int32_0, ref this, (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float2.NativeMethodInfoPtr_set_Item_Public_set_Void_Int32_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060010EE RID: 4334 RVA: 0x0005C9D0 File Offset: 0x0005ABD0
		[CallerCount(0)]
		public unsafe bool Equals(float2 rhs)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref rhs;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float2.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_float2_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060010EF RID: 4335 RVA: 0x0005CA10 File Offset: 0x0005AC10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 636705, XrefRangeEnd = 636708, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(global::Il2CppSystem.Object o)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(o);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float2.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060010F0 RID: 4336 RVA: 0x0005CA54 File Offset: 0x0005AC54
		[CallerCount(0)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float2.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060010F1 RID: 4337 RVA: 0x0005CA84 File Offset: 0x0005AC84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 636708, XrefRangeEnd = 636716, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float2.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060010F2 RID: 4338 RVA: 0x0005CAB0 File Offset: 0x0005ACB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 636716, XrefRangeEnd = 636721, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float2.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060010F3 RID: 4339 RVA: 0x0005CB00 File Offset: 0x0005AD00
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 630534, RefRangeEnd = 630538, XrefRangeStart = 630534, XrefRangeEnd = 630538, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator Vector2(float2 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float2.NativeMethodInfoPtr_op_Implicit_Public_Static_Vector2_float2_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060010F4 RID: 4340 RVA: 0x0005CB40 File Offset: 0x0005AD40
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 630534, RefRangeEnd = 630538, XrefRangeStart = 630534, XrefRangeEnd = 630538, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator float2(Vector2 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float2.NativeMethodInfoPtr_op_Implicit_Public_Static_float2_Vector2_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060010F5 RID: 4341 RVA: 0x0000245A File Offset: 0x0000065A
		public global::Il2CppSystem.Object BoxIl2CppObject()
		{
			return new global::Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<float2>.NativeClassPtr, ref this));
		}

		// Token: 0x17000400 RID: 1024
		// (get) Token: 0x060010F6 RID: 4342 RVA: 0x0005CB80 File Offset: 0x0005AD80
		// (set) Token: 0x060010F7 RID: 4343 RVA: 0x0000246C File Offset: 0x0000066C
		public unsafe static float2 zero
		{
			get
			{
				float2 @float;
				IL2CPP.il2cpp_field_static_get_value(float2.NativeFieldInfoPtr_zero, (void*)(&@float));
				return @float;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(float2.NativeFieldInfoPtr_zero, (void*)(&value));
			}
		}

		// Token: 0x040010C5 RID: 4293
		private static readonly IntPtr NativeFieldInfoPtr_x;

		// Token: 0x040010C6 RID: 4294
		private static readonly IntPtr NativeFieldInfoPtr_y;

		// Token: 0x040010C7 RID: 4295
		private static readonly IntPtr NativeFieldInfoPtr_zero;

		// Token: 0x040010C8 RID: 4296
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_Single_0;

		// Token: 0x040010C9 RID: 4297
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_float2_0;

		// Token: 0x040010CA RID: 4298
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_0;

		// Token: 0x040010CB RID: 4299
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_0;

		// Token: 0x040010CC RID: 4300
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_bool2_0;

		// Token: 0x040010CD RID: 4301
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x040010CE RID: 4302
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_int2_0;

		// Token: 0x040010CF RID: 4303
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_UInt32_0;

		// Token: 0x040010D0 RID: 4304
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_uint2_0;

		// Token: 0x040010D1 RID: 4305
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_half_0;

		// Token: 0x040010D2 RID: 4306
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_half2_0;

		// Token: 0x040010D3 RID: 4307
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Double_0;

		// Token: 0x040010D4 RID: 4308
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_double2_0;

		// Token: 0x040010D5 RID: 4309
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_float2_Single_0;

		// Token: 0x040010D6 RID: 4310
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_float2_Boolean_0;

		// Token: 0x040010D7 RID: 4311
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_float2_bool2_0;

		// Token: 0x040010D8 RID: 4312
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_float2_Int32_0;

		// Token: 0x040010D9 RID: 4313
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_float2_int2_0;

		// Token: 0x040010DA RID: 4314
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_float2_UInt32_0;

		// Token: 0x040010DB RID: 4315
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_float2_uint2_0;

		// Token: 0x040010DC RID: 4316
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_float2_half_0;

		// Token: 0x040010DD RID: 4317
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_float2_half2_0;

		// Token: 0x040010DE RID: 4318
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_float2_Double_0;

		// Token: 0x040010DF RID: 4319
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_float2_double2_0;

		// Token: 0x040010E0 RID: 4320
		private static readonly IntPtr NativeMethodInfoPtr_op_Multiply_Public_Static_float2_float2_float2_0;

		// Token: 0x040010E1 RID: 4321
		private static readonly IntPtr NativeMethodInfoPtr_op_Multiply_Public_Static_float2_float2_Single_0;

		// Token: 0x040010E2 RID: 4322
		private static readonly IntPtr NativeMethodInfoPtr_op_Multiply_Public_Static_float2_Single_float2_0;

		// Token: 0x040010E3 RID: 4323
		private static readonly IntPtr NativeMethodInfoPtr_op_Addition_Public_Static_float2_float2_float2_0;

		// Token: 0x040010E4 RID: 4324
		private static readonly IntPtr NativeMethodInfoPtr_op_Addition_Public_Static_float2_float2_Single_0;

		// Token: 0x040010E5 RID: 4325
		private static readonly IntPtr NativeMethodInfoPtr_op_Addition_Public_Static_float2_Single_float2_0;

		// Token: 0x040010E6 RID: 4326
		private static readonly IntPtr NativeMethodInfoPtr_op_Subtraction_Public_Static_float2_float2_float2_0;

		// Token: 0x040010E7 RID: 4327
		private static readonly IntPtr NativeMethodInfoPtr_op_Subtraction_Public_Static_float2_float2_Single_0;

		// Token: 0x040010E8 RID: 4328
		private static readonly IntPtr NativeMethodInfoPtr_op_Subtraction_Public_Static_float2_Single_float2_0;

		// Token: 0x040010E9 RID: 4329
		private static readonly IntPtr NativeMethodInfoPtr_op_Division_Public_Static_float2_float2_float2_0;

		// Token: 0x040010EA RID: 4330
		private static readonly IntPtr NativeMethodInfoPtr_op_Division_Public_Static_float2_float2_Single_0;

		// Token: 0x040010EB RID: 4331
		private static readonly IntPtr NativeMethodInfoPtr_op_Division_Public_Static_float2_Single_float2_0;

		// Token: 0x040010EC RID: 4332
		private static readonly IntPtr NativeMethodInfoPtr_op_Modulus_Public_Static_float2_float2_float2_0;

		// Token: 0x040010ED RID: 4333
		private static readonly IntPtr NativeMethodInfoPtr_op_Modulus_Public_Static_float2_float2_Single_0;

		// Token: 0x040010EE RID: 4334
		private static readonly IntPtr NativeMethodInfoPtr_op_Modulus_Public_Static_float2_Single_float2_0;

		// Token: 0x040010EF RID: 4335
		private static readonly IntPtr NativeMethodInfoPtr_op_Increment_Public_Static_float2_float2_0;

		// Token: 0x040010F0 RID: 4336
		private static readonly IntPtr NativeMethodInfoPtr_op_Decrement_Public_Static_float2_float2_0;

		// Token: 0x040010F1 RID: 4337
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThan_Public_Static_bool2_float2_float2_0;

		// Token: 0x040010F2 RID: 4338
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThan_Public_Static_bool2_float2_Single_0;

		// Token: 0x040010F3 RID: 4339
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThan_Public_Static_bool2_Single_float2_0;

		// Token: 0x040010F4 RID: 4340
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool2_float2_float2_0;

		// Token: 0x040010F5 RID: 4341
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool2_float2_Single_0;

		// Token: 0x040010F6 RID: 4342
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool2_Single_float2_0;

		// Token: 0x040010F7 RID: 4343
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool2_float2_float2_0;

		// Token: 0x040010F8 RID: 4344
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool2_float2_Single_0;

		// Token: 0x040010F9 RID: 4345
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool2_Single_float2_0;

		// Token: 0x040010FA RID: 4346
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool2_float2_float2_0;

		// Token: 0x040010FB RID: 4347
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool2_float2_Single_0;

		// Token: 0x040010FC RID: 4348
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool2_Single_float2_0;

		// Token: 0x040010FD RID: 4349
		private static readonly IntPtr NativeMethodInfoPtr_op_UnaryNegation_Public_Static_float2_float2_0;

		// Token: 0x040010FE RID: 4350
		private static readonly IntPtr NativeMethodInfoPtr_op_UnaryPlus_Public_Static_float2_float2_0;

		// Token: 0x040010FF RID: 4351
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_bool2_float2_float2_0;

		// Token: 0x04001100 RID: 4352
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_bool2_float2_Single_0;

		// Token: 0x04001101 RID: 4353
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_bool2_Single_float2_0;

		// Token: 0x04001102 RID: 4354
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_bool2_float2_float2_0;

		// Token: 0x04001103 RID: 4355
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_bool2_float2_Single_0;

		// Token: 0x04001104 RID: 4356
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_bool2_Single_float2_0;

		// Token: 0x04001105 RID: 4357
		private static readonly IntPtr NativeMethodInfoPtr_get_xxxx_Public_get_float4_0;

		// Token: 0x04001106 RID: 4358
		private static readonly IntPtr NativeMethodInfoPtr_get_xxxy_Public_get_float4_0;

		// Token: 0x04001107 RID: 4359
		private static readonly IntPtr NativeMethodInfoPtr_get_xxyx_Public_get_float4_0;

		// Token: 0x04001108 RID: 4360
		private static readonly IntPtr NativeMethodInfoPtr_get_xxyy_Public_get_float4_0;

		// Token: 0x04001109 RID: 4361
		private static readonly IntPtr NativeMethodInfoPtr_get_xyxx_Public_get_float4_0;

		// Token: 0x0400110A RID: 4362
		private static readonly IntPtr NativeMethodInfoPtr_get_xyxy_Public_get_float4_0;

		// Token: 0x0400110B RID: 4363
		private static readonly IntPtr NativeMethodInfoPtr_get_xyyx_Public_get_float4_0;

		// Token: 0x0400110C RID: 4364
		private static readonly IntPtr NativeMethodInfoPtr_get_xyyy_Public_get_float4_0;

		// Token: 0x0400110D RID: 4365
		private static readonly IntPtr NativeMethodInfoPtr_get_yxxx_Public_get_float4_0;

		// Token: 0x0400110E RID: 4366
		private static readonly IntPtr NativeMethodInfoPtr_get_yxxy_Public_get_float4_0;

		// Token: 0x0400110F RID: 4367
		private static readonly IntPtr NativeMethodInfoPtr_get_yxyx_Public_get_float4_0;

		// Token: 0x04001110 RID: 4368
		private static readonly IntPtr NativeMethodInfoPtr_get_yxyy_Public_get_float4_0;

		// Token: 0x04001111 RID: 4369
		private static readonly IntPtr NativeMethodInfoPtr_get_yyxx_Public_get_float4_0;

		// Token: 0x04001112 RID: 4370
		private static readonly IntPtr NativeMethodInfoPtr_get_yyxy_Public_get_float4_0;

		// Token: 0x04001113 RID: 4371
		private static readonly IntPtr NativeMethodInfoPtr_get_yyyx_Public_get_float4_0;

		// Token: 0x04001114 RID: 4372
		private static readonly IntPtr NativeMethodInfoPtr_get_yyyy_Public_get_float4_0;

		// Token: 0x04001115 RID: 4373
		private static readonly IntPtr NativeMethodInfoPtr_get_xxx_Public_get_float3_0;

		// Token: 0x04001116 RID: 4374
		private static readonly IntPtr NativeMethodInfoPtr_get_xxy_Public_get_float3_0;

		// Token: 0x04001117 RID: 4375
		private static readonly IntPtr NativeMethodInfoPtr_get_xyx_Public_get_float3_0;

		// Token: 0x04001118 RID: 4376
		private static readonly IntPtr NativeMethodInfoPtr_get_xyy_Public_get_float3_0;

		// Token: 0x04001119 RID: 4377
		private static readonly IntPtr NativeMethodInfoPtr_get_yxx_Public_get_float3_0;

		// Token: 0x0400111A RID: 4378
		private static readonly IntPtr NativeMethodInfoPtr_get_yxy_Public_get_float3_0;

		// Token: 0x0400111B RID: 4379
		private static readonly IntPtr NativeMethodInfoPtr_get_yyx_Public_get_float3_0;

		// Token: 0x0400111C RID: 4380
		private static readonly IntPtr NativeMethodInfoPtr_get_yyy_Public_get_float3_0;

		// Token: 0x0400111D RID: 4381
		private static readonly IntPtr NativeMethodInfoPtr_get_xx_Public_get_float2_0;

		// Token: 0x0400111E RID: 4382
		private static readonly IntPtr NativeMethodInfoPtr_get_xy_Public_get_float2_0;

		// Token: 0x0400111F RID: 4383
		private static readonly IntPtr NativeMethodInfoPtr_set_xy_Public_set_Void_float2_0;

		// Token: 0x04001120 RID: 4384
		private static readonly IntPtr NativeMethodInfoPtr_get_yx_Public_get_float2_0;

		// Token: 0x04001121 RID: 4385
		private static readonly IntPtr NativeMethodInfoPtr_set_yx_Public_set_Void_float2_0;

		// Token: 0x04001122 RID: 4386
		private static readonly IntPtr NativeMethodInfoPtr_get_yy_Public_get_float2_0;

		// Token: 0x04001123 RID: 4387
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_get_Single_Int32_0;

		// Token: 0x04001124 RID: 4388
		private static readonly IntPtr NativeMethodInfoPtr_set_Item_Public_set_Void_Int32_Single_0;

		// Token: 0x04001125 RID: 4389
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_float2_0;

		// Token: 0x04001126 RID: 4390
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04001127 RID: 4391
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04001128 RID: 4392
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04001129 RID: 4393
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0;

		// Token: 0x0400112A RID: 4394
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_Vector2_float2_0;

		// Token: 0x0400112B RID: 4395
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_float2_Vector2_0;

		// Token: 0x0400112C RID: 4396
		[FieldOffset(0)]
		public float x;

		// Token: 0x0400112D RID: 4397
		[FieldOffset(4)]
		public float y;

		// Token: 0x0200005A RID: 90
		public sealed class DebuggerProxy : global::Il2CppSystem.Object
		{
			// Token: 0x060025EF RID: 9711 RVA: 0x000C34C4 File Offset: 0x000C16C4
			// Note: this type is marked as 'beforefieldinit'.
			static DebuggerProxy()
			{
				Il2CppClassPointerStore<float2.DebuggerProxy>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<float2>.NativeClassPtr, "DebuggerProxy");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<float2.DebuggerProxy>.NativeClassPtr);
				float2.DebuggerProxy.NativeFieldInfoPtr_x = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<float2.DebuggerProxy>.NativeClassPtr, "x");
				float2.DebuggerProxy.NativeFieldInfoPtr_y = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<float2.DebuggerProxy>.NativeClassPtr, "y");
				float2.DebuggerProxy.NativeMethodInfoPtr__ctor_Public_Void_float2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<float2.DebuggerProxy>.NativeClassPtr, 100667517);
			}

			// Token: 0x060025F0 RID: 9712 RVA: 0x000C352C File Offset: 0x000C172C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 636693, XrefRangeEnd = 636694, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe DebuggerProxy(float2 v)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<float2.DebuggerProxy>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref v;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(float2.DebuggerProxy.NativeMethodInfoPtr__ctor_Public_Void_float2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060025F1 RID: 9713 RVA: 0x00002DF3 File Offset: 0x00000FF3
			public DebuggerProxy(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000C03 RID: 3075
			// (get) Token: 0x060025F2 RID: 9714 RVA: 0x000C3574 File Offset: 0x000C1774
			// (set) Token: 0x060025F3 RID: 9715 RVA: 0x00002DFC File Offset: 0x00000FFC
			public unsafe float x
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(float2.DebuggerProxy.NativeFieldInfoPtr_x);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(float2.DebuggerProxy.NativeFieldInfoPtr_x)) = value;
				}
			}

			// Token: 0x17000C04 RID: 3076
			// (get) Token: 0x060025F4 RID: 9716 RVA: 0x000C359C File Offset: 0x000C179C
			// (set) Token: 0x060025F5 RID: 9717 RVA: 0x00002E17 File Offset: 0x00001017
			public unsafe float y
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(float2.DebuggerProxy.NativeFieldInfoPtr_y);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(float2.DebuggerProxy.NativeFieldInfoPtr_y)) = value;
				}
			}

			// Token: 0x04002674 RID: 9844
			private static readonly IntPtr NativeFieldInfoPtr_x;

			// Token: 0x04002675 RID: 9845
			private static readonly IntPtr NativeFieldInfoPtr_y;

			// Token: 0x04002676 RID: 9846
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_float2_0;
		}
	}
}
