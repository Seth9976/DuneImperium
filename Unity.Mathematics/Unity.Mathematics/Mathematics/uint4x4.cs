using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Unity.Mathematics
{
	// Token: 0x0200004A RID: 74
	[Serializable]
	[StructLayout(2)]
	public struct uint4x4
	{
		// Token: 0x06002527 RID: 9511 RVA: 0x000C02A4 File Offset: 0x000BE4A4
		// Note: this type is marked as 'beforefieldinit'.
		static uint4x4()
		{
			Il2CppClassPointerStore<uint4x4>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Mathematics.dll", "Unity.Mathematics", "uint4x4");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<uint4x4>.NativeClassPtr);
			uint4x4.NativeFieldInfoPtr_c0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<uint4x4>.NativeClassPtr, "c0");
			uint4x4.NativeFieldInfoPtr_c1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<uint4x4>.NativeClassPtr, "c1");
			uint4x4.NativeFieldInfoPtr_c2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<uint4x4>.NativeClassPtr, "c2");
			uint4x4.NativeFieldInfoPtr_c3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<uint4x4>.NativeClassPtr, "c3");
			uint4x4.NativeFieldInfoPtr_identity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<uint4x4>.NativeClassPtr, "identity");
			uint4x4.NativeFieldInfoPtr_zero = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<uint4x4>.NativeClassPtr, "zero");
			uint4x4.NativeMethodInfoPtr__ctor_Public_Void_uint4_uint4_uint4_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4x4>.NativeClassPtr, 100672523);
			uint4x4.NativeMethodInfoPtr__ctor_Public_Void_UInt32_UInt32_UInt32_UInt32_UInt32_UInt32_UInt32_UInt32_UInt32_UInt32_UInt32_UInt32_UInt32_UInt32_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4x4>.NativeClassPtr, 100672524);
			uint4x4.NativeMethodInfoPtr__ctor_Public_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4x4>.NativeClassPtr, 100672525);
			uint4x4.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4x4>.NativeClassPtr, 100672526);
			uint4x4.NativeMethodInfoPtr__ctor_Public_Void_bool4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4x4>.NativeClassPtr, 100672527);
			uint4x4.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4x4>.NativeClassPtr, 100672528);
			uint4x4.NativeMethodInfoPtr__ctor_Public_Void_int4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4x4>.NativeClassPtr, 100672529);
			uint4x4.NativeMethodInfoPtr__ctor_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4x4>.NativeClassPtr, 100672530);
			uint4x4.NativeMethodInfoPtr__ctor_Public_Void_float4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4x4>.NativeClassPtr, 100672531);
			uint4x4.NativeMethodInfoPtr__ctor_Public_Void_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4x4>.NativeClassPtr, 100672532);
			uint4x4.NativeMethodInfoPtr__ctor_Public_Void_double4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4x4>.NativeClassPtr, 100672533);
			uint4x4.NativeMethodInfoPtr_op_Implicit_Public_Static_uint4x4_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4x4>.NativeClassPtr, 100672534);
			uint4x4.NativeMethodInfoPtr_op_Explicit_Public_Static_uint4x4_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4x4>.NativeClassPtr, 100672535);
			uint4x4.NativeMethodInfoPtr_op_Explicit_Public_Static_uint4x4_bool4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4x4>.NativeClassPtr, 100672536);
			uint4x4.NativeMethodInfoPtr_op_Explicit_Public_Static_uint4x4_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4x4>.NativeClassPtr, 100672537);
			uint4x4.NativeMethodInfoPtr_op_Explicit_Public_Static_uint4x4_int4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4x4>.NativeClassPtr, 100672538);
			uint4x4.NativeMethodInfoPtr_op_Explicit_Public_Static_uint4x4_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4x4>.NativeClassPtr, 100672539);
			uint4x4.NativeMethodInfoPtr_op_Explicit_Public_Static_uint4x4_float4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4x4>.NativeClassPtr, 100672540);
			uint4x4.NativeMethodInfoPtr_op_Explicit_Public_Static_uint4x4_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4x4>.NativeClassPtr, 100672541);
			uint4x4.NativeMethodInfoPtr_op_Explicit_Public_Static_uint4x4_double4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4x4>.NativeClassPtr, 100672542);
			uint4x4.NativeMethodInfoPtr_op_Multiply_Public_Static_uint4x4_uint4x4_uint4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4x4>.NativeClassPtr, 100672543);
			uint4x4.NativeMethodInfoPtr_op_Multiply_Public_Static_uint4x4_uint4x4_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4x4>.NativeClassPtr, 100672544);
			uint4x4.NativeMethodInfoPtr_op_Multiply_Public_Static_uint4x4_UInt32_uint4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4x4>.NativeClassPtr, 100672545);
			uint4x4.NativeMethodInfoPtr_op_Addition_Public_Static_uint4x4_uint4x4_uint4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4x4>.NativeClassPtr, 100672546);
			uint4x4.NativeMethodInfoPtr_op_Addition_Public_Static_uint4x4_uint4x4_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4x4>.NativeClassPtr, 100672547);
			uint4x4.NativeMethodInfoPtr_op_Addition_Public_Static_uint4x4_UInt32_uint4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4x4>.NativeClassPtr, 100672548);
			uint4x4.NativeMethodInfoPtr_op_Subtraction_Public_Static_uint4x4_uint4x4_uint4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4x4>.NativeClassPtr, 100672549);
			uint4x4.NativeMethodInfoPtr_op_Subtraction_Public_Static_uint4x4_uint4x4_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4x4>.NativeClassPtr, 100672550);
			uint4x4.NativeMethodInfoPtr_op_Subtraction_Public_Static_uint4x4_UInt32_uint4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4x4>.NativeClassPtr, 100672551);
			uint4x4.NativeMethodInfoPtr_op_Division_Public_Static_uint4x4_uint4x4_uint4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4x4>.NativeClassPtr, 100672552);
			uint4x4.NativeMethodInfoPtr_op_Division_Public_Static_uint4x4_uint4x4_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4x4>.NativeClassPtr, 100672553);
			uint4x4.NativeMethodInfoPtr_op_Division_Public_Static_uint4x4_UInt32_uint4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4x4>.NativeClassPtr, 100672554);
			uint4x4.NativeMethodInfoPtr_op_Modulus_Public_Static_uint4x4_uint4x4_uint4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4x4>.NativeClassPtr, 100672555);
			uint4x4.NativeMethodInfoPtr_op_Modulus_Public_Static_uint4x4_uint4x4_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4x4>.NativeClassPtr, 100672556);
			uint4x4.NativeMethodInfoPtr_op_Modulus_Public_Static_uint4x4_UInt32_uint4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4x4>.NativeClassPtr, 100672557);
			uint4x4.NativeMethodInfoPtr_op_Increment_Public_Static_uint4x4_uint4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4x4>.NativeClassPtr, 100672558);
			uint4x4.NativeMethodInfoPtr_op_Decrement_Public_Static_uint4x4_uint4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4x4>.NativeClassPtr, 100672559);
			uint4x4.NativeMethodInfoPtr_op_LessThan_Public_Static_bool4x4_uint4x4_uint4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4x4>.NativeClassPtr, 100672560);
			uint4x4.NativeMethodInfoPtr_op_LessThan_Public_Static_bool4x4_uint4x4_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4x4>.NativeClassPtr, 100672561);
			uint4x4.NativeMethodInfoPtr_op_LessThan_Public_Static_bool4x4_UInt32_uint4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4x4>.NativeClassPtr, 100672562);
			uint4x4.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool4x4_uint4x4_uint4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4x4>.NativeClassPtr, 100672563);
			uint4x4.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool4x4_uint4x4_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4x4>.NativeClassPtr, 100672564);
			uint4x4.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool4x4_UInt32_uint4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4x4>.NativeClassPtr, 100672565);
			uint4x4.NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool4x4_uint4x4_uint4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4x4>.NativeClassPtr, 100672566);
			uint4x4.NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool4x4_uint4x4_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4x4>.NativeClassPtr, 100672567);
			uint4x4.NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool4x4_UInt32_uint4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4x4>.NativeClassPtr, 100672568);
			uint4x4.NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool4x4_uint4x4_uint4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4x4>.NativeClassPtr, 100672569);
			uint4x4.NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool4x4_uint4x4_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4x4>.NativeClassPtr, 100672570);
			uint4x4.NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool4x4_UInt32_uint4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4x4>.NativeClassPtr, 100672571);
			uint4x4.NativeMethodInfoPtr_op_UnaryNegation_Public_Static_uint4x4_uint4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4x4>.NativeClassPtr, 100672572);
			uint4x4.NativeMethodInfoPtr_op_UnaryPlus_Public_Static_uint4x4_uint4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4x4>.NativeClassPtr, 100672573);
			uint4x4.NativeMethodInfoPtr_op_LeftShift_Public_Static_uint4x4_uint4x4_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4x4>.NativeClassPtr, 100672574);
			uint4x4.NativeMethodInfoPtr_op_RightShift_Public_Static_uint4x4_uint4x4_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4x4>.NativeClassPtr, 100672575);
			uint4x4.NativeMethodInfoPtr_op_Equality_Public_Static_bool4x4_uint4x4_uint4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4x4>.NativeClassPtr, 100672576);
			uint4x4.NativeMethodInfoPtr_op_Equality_Public_Static_bool4x4_uint4x4_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4x4>.NativeClassPtr, 100672577);
			uint4x4.NativeMethodInfoPtr_op_Equality_Public_Static_bool4x4_UInt32_uint4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4x4>.NativeClassPtr, 100672578);
			uint4x4.NativeMethodInfoPtr_op_Inequality_Public_Static_bool4x4_uint4x4_uint4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4x4>.NativeClassPtr, 100672579);
			uint4x4.NativeMethodInfoPtr_op_Inequality_Public_Static_bool4x4_uint4x4_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4x4>.NativeClassPtr, 100672580);
			uint4x4.NativeMethodInfoPtr_op_Inequality_Public_Static_bool4x4_UInt32_uint4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4x4>.NativeClassPtr, 100672581);
			uint4x4.NativeMethodInfoPtr_op_OnesComplement_Public_Static_uint4x4_uint4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4x4>.NativeClassPtr, 100672582);
			uint4x4.NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_uint4x4_uint4x4_uint4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4x4>.NativeClassPtr, 100672583);
			uint4x4.NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_uint4x4_uint4x4_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4x4>.NativeClassPtr, 100672584);
			uint4x4.NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_uint4x4_UInt32_uint4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4x4>.NativeClassPtr, 100672585);
			uint4x4.NativeMethodInfoPtr_op_BitwiseOr_Public_Static_uint4x4_uint4x4_uint4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4x4>.NativeClassPtr, 100672586);
			uint4x4.NativeMethodInfoPtr_op_BitwiseOr_Public_Static_uint4x4_uint4x4_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4x4>.NativeClassPtr, 100672587);
			uint4x4.NativeMethodInfoPtr_op_BitwiseOr_Public_Static_uint4x4_UInt32_uint4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4x4>.NativeClassPtr, 100672588);
			uint4x4.NativeMethodInfoPtr_op_ExclusiveOr_Public_Static_uint4x4_uint4x4_uint4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4x4>.NativeClassPtr, 100672589);
			uint4x4.NativeMethodInfoPtr_op_ExclusiveOr_Public_Static_uint4x4_uint4x4_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4x4>.NativeClassPtr, 100672590);
			uint4x4.NativeMethodInfoPtr_op_ExclusiveOr_Public_Static_uint4x4_UInt32_uint4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4x4>.NativeClassPtr, 100672591);
			uint4x4.NativeMethodInfoPtr_get_Item_Public_get_byref_uint4_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4x4>.NativeClassPtr, 100672592);
			uint4x4.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_uint4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4x4>.NativeClassPtr, 100672593);
			uint4x4.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4x4>.NativeClassPtr, 100672594);
			uint4x4.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4x4>.NativeClassPtr, 100672595);
			uint4x4.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4x4>.NativeClassPtr, 100672596);
			uint4x4.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4x4>.NativeClassPtr, 100672597);
		}

		// Token: 0x06002528 RID: 9512 RVA: 0x000C0928 File Offset: 0x000BEB28
		[CallerCount(0)]
		public unsafe uint4x4(uint4 c0, uint4 c1, uint4 c2, uint4 c3)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4x4.NativeMethodInfoPtr__ctor_Public_Void_uint4_uint4_uint4_uint4_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002529 RID: 9513 RVA: 0x000C0984 File Offset: 0x000BEB84
		[CallerCount(0)]
		public unsafe uint4x4(uint m00, uint m01, uint m02, uint m03, uint m10, uint m11, uint m12, uint m13, uint m20, uint m21, uint m22, uint m23, uint m30, uint m31, uint m32, uint m33)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)16) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref m00;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref m01;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref m02;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref m03;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref m10;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref m11;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref m12;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref m13;
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref m20;
			ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref m21;
			ptr[checked(unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref m22;
			ptr[checked(unchecked((UIntPtr)11) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref m23;
			ptr[checked(unchecked((UIntPtr)12) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref m30;
			ptr[checked(unchecked((UIntPtr)13) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref m31;
			ptr[checked(unchecked((UIntPtr)14) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref m32;
			ptr[checked(unchecked((UIntPtr)15) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref m33;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4x4.NativeMethodInfoPtr__ctor_Public_Void_UInt32_UInt32_UInt32_UInt32_UInt32_UInt32_UInt32_UInt32_UInt32_UInt32_UInt32_UInt32_UInt32_UInt32_UInt32_UInt32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600252A RID: 9514 RVA: 0x000C0A90 File Offset: 0x000BEC90
		[CallerCount(0)]
		public unsafe uint4x4(uint v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4x4.NativeMethodInfoPtr__ctor_Public_Void_UInt32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600252B RID: 9515 RVA: 0x000C0AC4 File Offset: 0x000BECC4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 642578, RefRangeEnd = 642579, XrefRangeStart = 642575, XrefRangeEnd = 642578, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe uint4x4(bool v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4x4.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600252C RID: 9516 RVA: 0x000C0AF8 File Offset: 0x000BECF8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 640017, RefRangeEnd = 640019, XrefRangeStart = 640017, XrefRangeEnd = 640019, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe uint4x4(bool4x4 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4x4.NativeMethodInfoPtr__ctor_Public_Void_bool4x4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600252D RID: 9517 RVA: 0x000C0B2C File Offset: 0x000BED2C
		[CallerCount(0)]
		public unsafe uint4x4(int v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4x4.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600252E RID: 9518 RVA: 0x000C0B60 File Offset: 0x000BED60
		[CallerCount(0)]
		public unsafe uint4x4(int4x4 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4x4.NativeMethodInfoPtr__ctor_Public_Void_int4x4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600252F RID: 9519 RVA: 0x000C0B94 File Offset: 0x000BED94
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 642594, RefRangeEnd = 642596, XrefRangeStart = 642579, XrefRangeEnd = 642594, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe uint4x4(float v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4x4.NativeMethodInfoPtr__ctor_Public_Void_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002530 RID: 9520 RVA: 0x000C0BC8 File Offset: 0x000BEDC8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 642611, RefRangeEnd = 642613, XrefRangeStart = 642596, XrefRangeEnd = 642611, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe uint4x4(float4x4 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4x4.NativeMethodInfoPtr__ctor_Public_Void_float4x4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002531 RID: 9521 RVA: 0x000C0BFC File Offset: 0x000BEDFC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 642628, RefRangeEnd = 642630, XrefRangeStart = 642613, XrefRangeEnd = 642628, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe uint4x4(double v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4x4.NativeMethodInfoPtr__ctor_Public_Void_Double_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002532 RID: 9522 RVA: 0x000C0C30 File Offset: 0x000BEE30
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 642645, RefRangeEnd = 642647, XrefRangeStart = 642630, XrefRangeEnd = 642645, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe uint4x4(double4x4 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4x4.NativeMethodInfoPtr__ctor_Public_Void_double4x4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002533 RID: 9523 RVA: 0x000C0C64 File Offset: 0x000BEE64
		[CallerCount(0)]
		public unsafe static implicit operator uint4x4(uint v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4x4.NativeMethodInfoPtr_op_Implicit_Public_Static_uint4x4_UInt32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002534 RID: 9524 RVA: 0x000C0CA4 File Offset: 0x000BEEA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 642647, XrefRangeEnd = 642648, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator uint4x4(bool v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4x4.NativeMethodInfoPtr_op_Explicit_Public_Static_uint4x4_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002535 RID: 9525 RVA: 0x000C0CE4 File Offset: 0x000BEEE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator uint4x4(bool4x4 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4x4.NativeMethodInfoPtr_op_Explicit_Public_Static_uint4x4_bool4x4_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002536 RID: 9526 RVA: 0x000C0D24 File Offset: 0x000BEF24
		[CallerCount(0)]
		public unsafe static explicit operator uint4x4(int v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4x4.NativeMethodInfoPtr_op_Explicit_Public_Static_uint4x4_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002537 RID: 9527 RVA: 0x000C0D64 File Offset: 0x000BEF64
		[CallerCount(0)]
		public unsafe static explicit operator uint4x4(int4x4 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4x4.NativeMethodInfoPtr_op_Explicit_Public_Static_uint4x4_int4x4_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002538 RID: 9528 RVA: 0x000C0DA4 File Offset: 0x000BEFA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator uint4x4(float v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4x4.NativeMethodInfoPtr_op_Explicit_Public_Static_uint4x4_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002539 RID: 9529 RVA: 0x000C0DE4 File Offset: 0x000BEFE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator uint4x4(float4x4 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4x4.NativeMethodInfoPtr_op_Explicit_Public_Static_uint4x4_float4x4_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600253A RID: 9530 RVA: 0x000C0E24 File Offset: 0x000BF024
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator uint4x4(double v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4x4.NativeMethodInfoPtr_op_Explicit_Public_Static_uint4x4_Double_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600253B RID: 9531 RVA: 0x000C0E64 File Offset: 0x000BF064
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator uint4x4(double4x4 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4x4.NativeMethodInfoPtr_op_Explicit_Public_Static_uint4x4_double4x4_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600253C RID: 9532 RVA: 0x000C0EA4 File Offset: 0x000BF0A4
		[CallerCount(0)]
		public unsafe static uint4x4 operator *(uint4x4 lhs, uint4x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4x4.NativeMethodInfoPtr_op_Multiply_Public_Static_uint4x4_uint4x4_uint4x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600253D RID: 9533 RVA: 0x000C0EF0 File Offset: 0x000BF0F0
		[CallerCount(0)]
		public unsafe static uint4x4 operator *(uint4x4 lhs, uint rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4x4.NativeMethodInfoPtr_op_Multiply_Public_Static_uint4x4_uint4x4_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600253E RID: 9534 RVA: 0x000C0F3C File Offset: 0x000BF13C
		[CallerCount(0)]
		public unsafe static uint4x4 operator *(uint lhs, uint4x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4x4.NativeMethodInfoPtr_op_Multiply_Public_Static_uint4x4_UInt32_uint4x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600253F RID: 9535 RVA: 0x000C0F88 File Offset: 0x000BF188
		[CallerCount(0)]
		public unsafe static uint4x4 operator +(uint4x4 lhs, uint4x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4x4.NativeMethodInfoPtr_op_Addition_Public_Static_uint4x4_uint4x4_uint4x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002540 RID: 9536 RVA: 0x000C0FD4 File Offset: 0x000BF1D4
		[CallerCount(0)]
		public unsafe static uint4x4 operator +(uint4x4 lhs, uint rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4x4.NativeMethodInfoPtr_op_Addition_Public_Static_uint4x4_uint4x4_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002541 RID: 9537 RVA: 0x000C1020 File Offset: 0x000BF220
		[CallerCount(0)]
		public unsafe static uint4x4 operator +(uint lhs, uint4x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4x4.NativeMethodInfoPtr_op_Addition_Public_Static_uint4x4_UInt32_uint4x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002542 RID: 9538 RVA: 0x000C106C File Offset: 0x000BF26C
		[CallerCount(0)]
		public unsafe static uint4x4 operator -(uint4x4 lhs, uint4x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4x4.NativeMethodInfoPtr_op_Subtraction_Public_Static_uint4x4_uint4x4_uint4x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002543 RID: 9539 RVA: 0x000C10B8 File Offset: 0x000BF2B8
		[CallerCount(0)]
		public unsafe static uint4x4 operator -(uint4x4 lhs, uint rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4x4.NativeMethodInfoPtr_op_Subtraction_Public_Static_uint4x4_uint4x4_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002544 RID: 9540 RVA: 0x000C1104 File Offset: 0x000BF304
		[CallerCount(0)]
		public unsafe static uint4x4 operator -(uint lhs, uint4x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4x4.NativeMethodInfoPtr_op_Subtraction_Public_Static_uint4x4_UInt32_uint4x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002545 RID: 9541 RVA: 0x000C1150 File Offset: 0x000BF350
		[CallerCount(0)]
		public unsafe static uint4x4 operator /(uint4x4 lhs, uint4x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4x4.NativeMethodInfoPtr_op_Division_Public_Static_uint4x4_uint4x4_uint4x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002546 RID: 9542 RVA: 0x000C119C File Offset: 0x000BF39C
		[CallerCount(0)]
		public unsafe static uint4x4 operator /(uint4x4 lhs, uint rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4x4.NativeMethodInfoPtr_op_Division_Public_Static_uint4x4_uint4x4_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002547 RID: 9543 RVA: 0x000C11E8 File Offset: 0x000BF3E8
		[CallerCount(0)]
		public unsafe static uint4x4 operator /(uint lhs, uint4x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4x4.NativeMethodInfoPtr_op_Division_Public_Static_uint4x4_UInt32_uint4x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002548 RID: 9544 RVA: 0x000C1234 File Offset: 0x000BF434
		[CallerCount(0)]
		public unsafe static uint4x4 operator %(uint4x4 lhs, uint4x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4x4.NativeMethodInfoPtr_op_Modulus_Public_Static_uint4x4_uint4x4_uint4x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002549 RID: 9545 RVA: 0x000C1280 File Offset: 0x000BF480
		[CallerCount(0)]
		public unsafe static uint4x4 operator %(uint4x4 lhs, uint rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4x4.NativeMethodInfoPtr_op_Modulus_Public_Static_uint4x4_uint4x4_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600254A RID: 9546 RVA: 0x000C12CC File Offset: 0x000BF4CC
		[CallerCount(0)]
		public unsafe static uint4x4 operator %(uint lhs, uint4x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4x4.NativeMethodInfoPtr_op_Modulus_Public_Static_uint4x4_UInt32_uint4x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600254B RID: 9547 RVA: 0x000C1318 File Offset: 0x000BF518
		[CallerCount(0)]
		public unsafe static uint4x4 operator ++(uint4x4 val)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4x4.NativeMethodInfoPtr_op_Increment_Public_Static_uint4x4_uint4x4_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600254C RID: 9548 RVA: 0x000C1358 File Offset: 0x000BF558
		[CallerCount(0)]
		public unsafe static uint4x4 operator --(uint4x4 val)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4x4.NativeMethodInfoPtr_op_Decrement_Public_Static_uint4x4_uint4x4_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600254D RID: 9549 RVA: 0x000C1398 File Offset: 0x000BF598
		[CallerCount(0)]
		public unsafe static bool4x4 operator <(uint4x4 lhs, uint4x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4x4.NativeMethodInfoPtr_op_LessThan_Public_Static_bool4x4_uint4x4_uint4x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600254E RID: 9550 RVA: 0x000C13E4 File Offset: 0x000BF5E4
		[CallerCount(0)]
		public unsafe static bool4x4 operator <(uint4x4 lhs, uint rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4x4.NativeMethodInfoPtr_op_LessThan_Public_Static_bool4x4_uint4x4_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600254F RID: 9551 RVA: 0x000C1430 File Offset: 0x000BF630
		[CallerCount(0)]
		public unsafe static bool4x4 operator <(uint lhs, uint4x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4x4.NativeMethodInfoPtr_op_LessThan_Public_Static_bool4x4_UInt32_uint4x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002550 RID: 9552 RVA: 0x000C147C File Offset: 0x000BF67C
		[CallerCount(0)]
		public unsafe static bool4x4 operator <=(uint4x4 lhs, uint4x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4x4.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool4x4_uint4x4_uint4x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002551 RID: 9553 RVA: 0x000C14C8 File Offset: 0x000BF6C8
		[CallerCount(0)]
		public unsafe static bool4x4 operator <=(uint4x4 lhs, uint rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4x4.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool4x4_uint4x4_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002552 RID: 9554 RVA: 0x000C1514 File Offset: 0x000BF714
		[CallerCount(0)]
		public unsafe static bool4x4 operator <=(uint lhs, uint4x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4x4.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool4x4_UInt32_uint4x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002553 RID: 9555 RVA: 0x000C1560 File Offset: 0x000BF760
		[CallerCount(0)]
		public unsafe static bool4x4 operator >(uint4x4 lhs, uint4x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4x4.NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool4x4_uint4x4_uint4x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002554 RID: 9556 RVA: 0x000C15AC File Offset: 0x000BF7AC
		[CallerCount(0)]
		public unsafe static bool4x4 operator >(uint4x4 lhs, uint rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4x4.NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool4x4_uint4x4_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002555 RID: 9557 RVA: 0x000C15F8 File Offset: 0x000BF7F8
		[CallerCount(0)]
		public unsafe static bool4x4 operator >(uint lhs, uint4x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4x4.NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool4x4_UInt32_uint4x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002556 RID: 9558 RVA: 0x000C1644 File Offset: 0x000BF844
		[CallerCount(0)]
		public unsafe static bool4x4 operator >=(uint4x4 lhs, uint4x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4x4.NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool4x4_uint4x4_uint4x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002557 RID: 9559 RVA: 0x000C1690 File Offset: 0x000BF890
		[CallerCount(0)]
		public unsafe static bool4x4 operator >=(uint4x4 lhs, uint rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4x4.NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool4x4_uint4x4_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002558 RID: 9560 RVA: 0x000C16DC File Offset: 0x000BF8DC
		[CallerCount(0)]
		public unsafe static bool4x4 operator >=(uint lhs, uint4x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4x4.NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool4x4_UInt32_uint4x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002559 RID: 9561 RVA: 0x000C1728 File Offset: 0x000BF928
		[CallerCount(0)]
		public unsafe static uint4x4 operator -(uint4x4 val)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4x4.NativeMethodInfoPtr_op_UnaryNegation_Public_Static_uint4x4_uint4x4_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600255A RID: 9562 RVA: 0x000C1768 File Offset: 0x000BF968
		[CallerCount(0)]
		public unsafe static uint4x4 operator +(uint4x4 val)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4x4.NativeMethodInfoPtr_op_UnaryPlus_Public_Static_uint4x4_uint4x4_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600255B RID: 9563 RVA: 0x000C17A8 File Offset: 0x000BF9A8
		[CallerCount(0)]
		public unsafe static uint4x4 operator <<(uint4x4 x, int n)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref n;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4x4.NativeMethodInfoPtr_op_LeftShift_Public_Static_uint4x4_uint4x4_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600255C RID: 9564 RVA: 0x000C17F4 File Offset: 0x000BF9F4
		[CallerCount(0)]
		public unsafe static uint4x4 operator >>(uint4x4 x, int n)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref n;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4x4.NativeMethodInfoPtr_op_RightShift_Public_Static_uint4x4_uint4x4_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600255D RID: 9565 RVA: 0x000C1840 File Offset: 0x000BFA40
		[CallerCount(0)]
		public unsafe static bool4x4 operator ==(uint4x4 lhs, uint4x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4x4.NativeMethodInfoPtr_op_Equality_Public_Static_bool4x4_uint4x4_uint4x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600255E RID: 9566 RVA: 0x000C188C File Offset: 0x000BFA8C
		[CallerCount(0)]
		public unsafe static bool4x4 operator ==(uint4x4 lhs, uint rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4x4.NativeMethodInfoPtr_op_Equality_Public_Static_bool4x4_uint4x4_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600255F RID: 9567 RVA: 0x000C18D8 File Offset: 0x000BFAD8
		[CallerCount(0)]
		public unsafe static bool4x4 operator ==(uint lhs, uint4x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4x4.NativeMethodInfoPtr_op_Equality_Public_Static_bool4x4_UInt32_uint4x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002560 RID: 9568 RVA: 0x000C1924 File Offset: 0x000BFB24
		[CallerCount(0)]
		public unsafe static bool4x4 operator !=(uint4x4 lhs, uint4x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4x4.NativeMethodInfoPtr_op_Inequality_Public_Static_bool4x4_uint4x4_uint4x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002561 RID: 9569 RVA: 0x000C1970 File Offset: 0x000BFB70
		[CallerCount(0)]
		public unsafe static bool4x4 operator !=(uint4x4 lhs, uint rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4x4.NativeMethodInfoPtr_op_Inequality_Public_Static_bool4x4_uint4x4_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002562 RID: 9570 RVA: 0x000C19BC File Offset: 0x000BFBBC
		[CallerCount(0)]
		public unsafe static bool4x4 operator !=(uint lhs, uint4x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4x4.NativeMethodInfoPtr_op_Inequality_Public_Static_bool4x4_UInt32_uint4x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002563 RID: 9571 RVA: 0x000C1A08 File Offset: 0x000BFC08
		[CallerCount(0)]
		public unsafe static uint4x4 operator ~(uint4x4 val)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4x4.NativeMethodInfoPtr_op_OnesComplement_Public_Static_uint4x4_uint4x4_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002564 RID: 9572 RVA: 0x000C1A48 File Offset: 0x000BFC48
		[CallerCount(0)]
		public unsafe static uint4x4 operator &(uint4x4 lhs, uint4x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4x4.NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_uint4x4_uint4x4_uint4x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002565 RID: 9573 RVA: 0x000C1A94 File Offset: 0x000BFC94
		[CallerCount(0)]
		public unsafe static uint4x4 operator &(uint4x4 lhs, uint rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4x4.NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_uint4x4_uint4x4_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002566 RID: 9574 RVA: 0x000C1AE0 File Offset: 0x000BFCE0
		[CallerCount(0)]
		public unsafe static uint4x4 operator &(uint lhs, uint4x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4x4.NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_uint4x4_UInt32_uint4x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002567 RID: 9575 RVA: 0x000C1B2C File Offset: 0x000BFD2C
		[CallerCount(0)]
		public unsafe static uint4x4 operator |(uint4x4 lhs, uint4x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4x4.NativeMethodInfoPtr_op_BitwiseOr_Public_Static_uint4x4_uint4x4_uint4x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002568 RID: 9576 RVA: 0x000C1B78 File Offset: 0x000BFD78
		[CallerCount(0)]
		public unsafe static uint4x4 operator |(uint4x4 lhs, uint rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4x4.NativeMethodInfoPtr_op_BitwiseOr_Public_Static_uint4x4_uint4x4_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002569 RID: 9577 RVA: 0x000C1BC4 File Offset: 0x000BFDC4
		[CallerCount(0)]
		public unsafe static uint4x4 operator |(uint lhs, uint4x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4x4.NativeMethodInfoPtr_op_BitwiseOr_Public_Static_uint4x4_UInt32_uint4x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600256A RID: 9578 RVA: 0x000C1C10 File Offset: 0x000BFE10
		[CallerCount(0)]
		public unsafe static uint4x4 operator ^(uint4x4 lhs, uint4x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4x4.NativeMethodInfoPtr_op_ExclusiveOr_Public_Static_uint4x4_uint4x4_uint4x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600256B RID: 9579 RVA: 0x000C1C5C File Offset: 0x000BFE5C
		[CallerCount(0)]
		public unsafe static uint4x4 operator ^(uint4x4 lhs, uint rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4x4.NativeMethodInfoPtr_op_ExclusiveOr_Public_Static_uint4x4_uint4x4_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600256C RID: 9580 RVA: 0x000C1CA8 File Offset: 0x000BFEA8
		[CallerCount(0)]
		public unsafe static uint4x4 operator ^(uint lhs, uint4x4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4x4.NativeMethodInfoPtr_op_ExclusiveOr_Public_Static_uint4x4_UInt32_uint4x4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000BE1 RID: 3041
		public unsafe ref uint4 this[int index]
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 634855, RefRangeEnd = 634861, XrefRangeStart = 634855, XrefRangeEnd = 634861, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref index;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4x4.NativeMethodInfoPtr_get_Item_Public_get_byref_uint4_Int32_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return intPtr;
				}
			}
		}

		// Token: 0x0600256E RID: 9582 RVA: 0x000C1D28 File Offset: 0x000BFF28
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 640022, RefRangeEnd = 640024, XrefRangeStart = 640022, XrefRangeEnd = 640024, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(uint4x4 rhs)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref rhs;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4x4.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_uint4x4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600256F RID: 9583 RVA: 0x000C1D68 File Offset: 0x000BFF68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 642648, XrefRangeEnd = 642652, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object o)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(o);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4x4.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002570 RID: 9584 RVA: 0x000C1DAC File Offset: 0x000BFFAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 642652, XrefRangeEnd = 642653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4x4.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002571 RID: 9585 RVA: 0x000C1DDC File Offset: 0x000BFFDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 642653, XrefRangeEnd = 642724, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4x4.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06002572 RID: 9586 RVA: 0x000C1E08 File Offset: 0x000C0008
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 642724, XrefRangeEnd = 642814, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4x4.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06002573 RID: 9587 RVA: 0x00002A89 File Offset: 0x00000C89
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<uint4x4>.NativeClassPtr, ref this));
		}

		// Token: 0x17000BDF RID: 3039
		// (get) Token: 0x06002574 RID: 9588 RVA: 0x000C1E58 File Offset: 0x000C0058
		// (set) Token: 0x06002575 RID: 9589 RVA: 0x00002A9B File Offset: 0x00000C9B
		public unsafe static uint4x4 identity
		{
			get
			{
				uint4x4 uint4x;
				IL2CPP.il2cpp_field_static_get_value(uint4x4.NativeFieldInfoPtr_identity, (void*)(&uint4x));
				return uint4x;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(uint4x4.NativeFieldInfoPtr_identity, (void*)(&value));
			}
		}

		// Token: 0x17000BE0 RID: 3040
		// (get) Token: 0x06002576 RID: 9590 RVA: 0x000C1E74 File Offset: 0x000C0074
		// (set) Token: 0x06002577 RID: 9591 RVA: 0x00002AA9 File Offset: 0x00000CA9
		public unsafe static uint4x4 zero
		{
			get
			{
				uint4x4 uint4x;
				IL2CPP.il2cpp_field_static_get_value(uint4x4.NativeFieldInfoPtr_zero, (void*)(&uint4x));
				return uint4x;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(uint4x4.NativeFieldInfoPtr_zero, (void*)(&value));
			}
		}

		// Token: 0x040025BD RID: 9661
		private static readonly IntPtr NativeFieldInfoPtr_c0;

		// Token: 0x040025BE RID: 9662
		private static readonly IntPtr NativeFieldInfoPtr_c1;

		// Token: 0x040025BF RID: 9663
		private static readonly IntPtr NativeFieldInfoPtr_c2;

		// Token: 0x040025C0 RID: 9664
		private static readonly IntPtr NativeFieldInfoPtr_c3;

		// Token: 0x040025C1 RID: 9665
		private static readonly IntPtr NativeFieldInfoPtr_identity;

		// Token: 0x040025C2 RID: 9666
		private static readonly IntPtr NativeFieldInfoPtr_zero;

		// Token: 0x040025C3 RID: 9667
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_uint4_uint4_uint4_uint4_0;

		// Token: 0x040025C4 RID: 9668
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_UInt32_UInt32_UInt32_UInt32_UInt32_UInt32_UInt32_UInt32_UInt32_UInt32_UInt32_UInt32_UInt32_UInt32_UInt32_UInt32_0;

		// Token: 0x040025C5 RID: 9669
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_UInt32_0;

		// Token: 0x040025C6 RID: 9670
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_0;

		// Token: 0x040025C7 RID: 9671
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_bool4x4_0;

		// Token: 0x040025C8 RID: 9672
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x040025C9 RID: 9673
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_int4x4_0;

		// Token: 0x040025CA RID: 9674
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_0;

		// Token: 0x040025CB RID: 9675
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_float4x4_0;

		// Token: 0x040025CC RID: 9676
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Double_0;

		// Token: 0x040025CD RID: 9677
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_double4x4_0;

		// Token: 0x040025CE RID: 9678
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_uint4x4_UInt32_0;

		// Token: 0x040025CF RID: 9679
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_uint4x4_Boolean_0;

		// Token: 0x040025D0 RID: 9680
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_uint4x4_bool4x4_0;

		// Token: 0x040025D1 RID: 9681
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_uint4x4_Int32_0;

		// Token: 0x040025D2 RID: 9682
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_uint4x4_int4x4_0;

		// Token: 0x040025D3 RID: 9683
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_uint4x4_Single_0;

		// Token: 0x040025D4 RID: 9684
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_uint4x4_float4x4_0;

		// Token: 0x040025D5 RID: 9685
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_uint4x4_Double_0;

		// Token: 0x040025D6 RID: 9686
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_uint4x4_double4x4_0;

		// Token: 0x040025D7 RID: 9687
		private static readonly IntPtr NativeMethodInfoPtr_op_Multiply_Public_Static_uint4x4_uint4x4_uint4x4_0;

		// Token: 0x040025D8 RID: 9688
		private static readonly IntPtr NativeMethodInfoPtr_op_Multiply_Public_Static_uint4x4_uint4x4_UInt32_0;

		// Token: 0x040025D9 RID: 9689
		private static readonly IntPtr NativeMethodInfoPtr_op_Multiply_Public_Static_uint4x4_UInt32_uint4x4_0;

		// Token: 0x040025DA RID: 9690
		private static readonly IntPtr NativeMethodInfoPtr_op_Addition_Public_Static_uint4x4_uint4x4_uint4x4_0;

		// Token: 0x040025DB RID: 9691
		private static readonly IntPtr NativeMethodInfoPtr_op_Addition_Public_Static_uint4x4_uint4x4_UInt32_0;

		// Token: 0x040025DC RID: 9692
		private static readonly IntPtr NativeMethodInfoPtr_op_Addition_Public_Static_uint4x4_UInt32_uint4x4_0;

		// Token: 0x040025DD RID: 9693
		private static readonly IntPtr NativeMethodInfoPtr_op_Subtraction_Public_Static_uint4x4_uint4x4_uint4x4_0;

		// Token: 0x040025DE RID: 9694
		private static readonly IntPtr NativeMethodInfoPtr_op_Subtraction_Public_Static_uint4x4_uint4x4_UInt32_0;

		// Token: 0x040025DF RID: 9695
		private static readonly IntPtr NativeMethodInfoPtr_op_Subtraction_Public_Static_uint4x4_UInt32_uint4x4_0;

		// Token: 0x040025E0 RID: 9696
		private static readonly IntPtr NativeMethodInfoPtr_op_Division_Public_Static_uint4x4_uint4x4_uint4x4_0;

		// Token: 0x040025E1 RID: 9697
		private static readonly IntPtr NativeMethodInfoPtr_op_Division_Public_Static_uint4x4_uint4x4_UInt32_0;

		// Token: 0x040025E2 RID: 9698
		private static readonly IntPtr NativeMethodInfoPtr_op_Division_Public_Static_uint4x4_UInt32_uint4x4_0;

		// Token: 0x040025E3 RID: 9699
		private static readonly IntPtr NativeMethodInfoPtr_op_Modulus_Public_Static_uint4x4_uint4x4_uint4x4_0;

		// Token: 0x040025E4 RID: 9700
		private static readonly IntPtr NativeMethodInfoPtr_op_Modulus_Public_Static_uint4x4_uint4x4_UInt32_0;

		// Token: 0x040025E5 RID: 9701
		private static readonly IntPtr NativeMethodInfoPtr_op_Modulus_Public_Static_uint4x4_UInt32_uint4x4_0;

		// Token: 0x040025E6 RID: 9702
		private static readonly IntPtr NativeMethodInfoPtr_op_Increment_Public_Static_uint4x4_uint4x4_0;

		// Token: 0x040025E7 RID: 9703
		private static readonly IntPtr NativeMethodInfoPtr_op_Decrement_Public_Static_uint4x4_uint4x4_0;

		// Token: 0x040025E8 RID: 9704
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThan_Public_Static_bool4x4_uint4x4_uint4x4_0;

		// Token: 0x040025E9 RID: 9705
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThan_Public_Static_bool4x4_uint4x4_UInt32_0;

		// Token: 0x040025EA RID: 9706
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThan_Public_Static_bool4x4_UInt32_uint4x4_0;

		// Token: 0x040025EB RID: 9707
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool4x4_uint4x4_uint4x4_0;

		// Token: 0x040025EC RID: 9708
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool4x4_uint4x4_UInt32_0;

		// Token: 0x040025ED RID: 9709
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool4x4_UInt32_uint4x4_0;

		// Token: 0x040025EE RID: 9710
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool4x4_uint4x4_uint4x4_0;

		// Token: 0x040025EF RID: 9711
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool4x4_uint4x4_UInt32_0;

		// Token: 0x040025F0 RID: 9712
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool4x4_UInt32_uint4x4_0;

		// Token: 0x040025F1 RID: 9713
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool4x4_uint4x4_uint4x4_0;

		// Token: 0x040025F2 RID: 9714
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool4x4_uint4x4_UInt32_0;

		// Token: 0x040025F3 RID: 9715
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool4x4_UInt32_uint4x4_0;

		// Token: 0x040025F4 RID: 9716
		private static readonly IntPtr NativeMethodInfoPtr_op_UnaryNegation_Public_Static_uint4x4_uint4x4_0;

		// Token: 0x040025F5 RID: 9717
		private static readonly IntPtr NativeMethodInfoPtr_op_UnaryPlus_Public_Static_uint4x4_uint4x4_0;

		// Token: 0x040025F6 RID: 9718
		private static readonly IntPtr NativeMethodInfoPtr_op_LeftShift_Public_Static_uint4x4_uint4x4_Int32_0;

		// Token: 0x040025F7 RID: 9719
		private static readonly IntPtr NativeMethodInfoPtr_op_RightShift_Public_Static_uint4x4_uint4x4_Int32_0;

		// Token: 0x040025F8 RID: 9720
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_bool4x4_uint4x4_uint4x4_0;

		// Token: 0x040025F9 RID: 9721
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_bool4x4_uint4x4_UInt32_0;

		// Token: 0x040025FA RID: 9722
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_bool4x4_UInt32_uint4x4_0;

		// Token: 0x040025FB RID: 9723
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_bool4x4_uint4x4_uint4x4_0;

		// Token: 0x040025FC RID: 9724
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_bool4x4_uint4x4_UInt32_0;

		// Token: 0x040025FD RID: 9725
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_bool4x4_UInt32_uint4x4_0;

		// Token: 0x040025FE RID: 9726
		private static readonly IntPtr NativeMethodInfoPtr_op_OnesComplement_Public_Static_uint4x4_uint4x4_0;

		// Token: 0x040025FF RID: 9727
		private static readonly IntPtr NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_uint4x4_uint4x4_uint4x4_0;

		// Token: 0x04002600 RID: 9728
		private static readonly IntPtr NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_uint4x4_uint4x4_UInt32_0;

		// Token: 0x04002601 RID: 9729
		private static readonly IntPtr NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_uint4x4_UInt32_uint4x4_0;

		// Token: 0x04002602 RID: 9730
		private static readonly IntPtr NativeMethodInfoPtr_op_BitwiseOr_Public_Static_uint4x4_uint4x4_uint4x4_0;

		// Token: 0x04002603 RID: 9731
		private static readonly IntPtr NativeMethodInfoPtr_op_BitwiseOr_Public_Static_uint4x4_uint4x4_UInt32_0;

		// Token: 0x04002604 RID: 9732
		private static readonly IntPtr NativeMethodInfoPtr_op_BitwiseOr_Public_Static_uint4x4_UInt32_uint4x4_0;

		// Token: 0x04002605 RID: 9733
		private static readonly IntPtr NativeMethodInfoPtr_op_ExclusiveOr_Public_Static_uint4x4_uint4x4_uint4x4_0;

		// Token: 0x04002606 RID: 9734
		private static readonly IntPtr NativeMethodInfoPtr_op_ExclusiveOr_Public_Static_uint4x4_uint4x4_UInt32_0;

		// Token: 0x04002607 RID: 9735
		private static readonly IntPtr NativeMethodInfoPtr_op_ExclusiveOr_Public_Static_uint4x4_UInt32_uint4x4_0;

		// Token: 0x04002608 RID: 9736
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_get_byref_uint4_Int32_0;

		// Token: 0x04002609 RID: 9737
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_uint4x4_0;

		// Token: 0x0400260A RID: 9738
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x0400260B RID: 9739
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x0400260C RID: 9740
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x0400260D RID: 9741
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0;

		// Token: 0x0400260E RID: 9742
		[FieldOffset(0)]
		public uint4 c0;

		// Token: 0x0400260F RID: 9743
		[FieldOffset(16)]
		public uint4 c1;

		// Token: 0x04002610 RID: 9744
		[FieldOffset(32)]
		public uint4 c2;

		// Token: 0x04002611 RID: 9745
		[FieldOffset(48)]
		public uint4 c3;
	}
}
