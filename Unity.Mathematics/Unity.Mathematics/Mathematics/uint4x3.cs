using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Unity.Mathematics
{
	// Token: 0x02000049 RID: 73
	[Serializable]
	[StructLayout(2)]
	public struct uint4x3
	{
		// Token: 0x060024D8 RID: 9432 RVA: 0x000BE744 File Offset: 0x000BC944
		// Note: this type is marked as 'beforefieldinit'.
		static uint4x3()
		{
			Il2CppClassPointerStore<uint4x3>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Mathematics.dll", "Unity.Mathematics", "uint4x3");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<uint4x3>.NativeClassPtr);
			uint4x3.NativeFieldInfoPtr_c0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<uint4x3>.NativeClassPtr, "c0");
			uint4x3.NativeFieldInfoPtr_c1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<uint4x3>.NativeClassPtr, "c1");
			uint4x3.NativeFieldInfoPtr_c2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<uint4x3>.NativeClassPtr, "c2");
			uint4x3.NativeFieldInfoPtr_zero = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<uint4x3>.NativeClassPtr, "zero");
			uint4x3.NativeMethodInfoPtr__ctor_Public_Void_uint4_uint4_uint4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4x3>.NativeClassPtr, 100672448);
			uint4x3.NativeMethodInfoPtr__ctor_Public_Void_UInt32_UInt32_UInt32_UInt32_UInt32_UInt32_UInt32_UInt32_UInt32_UInt32_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4x3>.NativeClassPtr, 100672449);
			uint4x3.NativeMethodInfoPtr__ctor_Public_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4x3>.NativeClassPtr, 100672450);
			uint4x3.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4x3>.NativeClassPtr, 100672451);
			uint4x3.NativeMethodInfoPtr__ctor_Public_Void_bool4x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4x3>.NativeClassPtr, 100672452);
			uint4x3.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4x3>.NativeClassPtr, 100672453);
			uint4x3.NativeMethodInfoPtr__ctor_Public_Void_int4x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4x3>.NativeClassPtr, 100672454);
			uint4x3.NativeMethodInfoPtr__ctor_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4x3>.NativeClassPtr, 100672455);
			uint4x3.NativeMethodInfoPtr__ctor_Public_Void_float4x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4x3>.NativeClassPtr, 100672456);
			uint4x3.NativeMethodInfoPtr__ctor_Public_Void_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4x3>.NativeClassPtr, 100672457);
			uint4x3.NativeMethodInfoPtr__ctor_Public_Void_double4x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4x3>.NativeClassPtr, 100672458);
			uint4x3.NativeMethodInfoPtr_op_Implicit_Public_Static_uint4x3_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4x3>.NativeClassPtr, 100672459);
			uint4x3.NativeMethodInfoPtr_op_Explicit_Public_Static_uint4x3_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4x3>.NativeClassPtr, 100672460);
			uint4x3.NativeMethodInfoPtr_op_Explicit_Public_Static_uint4x3_bool4x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4x3>.NativeClassPtr, 100672461);
			uint4x3.NativeMethodInfoPtr_op_Explicit_Public_Static_uint4x3_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4x3>.NativeClassPtr, 100672462);
			uint4x3.NativeMethodInfoPtr_op_Explicit_Public_Static_uint4x3_int4x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4x3>.NativeClassPtr, 100672463);
			uint4x3.NativeMethodInfoPtr_op_Explicit_Public_Static_uint4x3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4x3>.NativeClassPtr, 100672464);
			uint4x3.NativeMethodInfoPtr_op_Explicit_Public_Static_uint4x3_float4x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4x3>.NativeClassPtr, 100672465);
			uint4x3.NativeMethodInfoPtr_op_Explicit_Public_Static_uint4x3_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4x3>.NativeClassPtr, 100672466);
			uint4x3.NativeMethodInfoPtr_op_Explicit_Public_Static_uint4x3_double4x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4x3>.NativeClassPtr, 100672467);
			uint4x3.NativeMethodInfoPtr_op_Multiply_Public_Static_uint4x3_uint4x3_uint4x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4x3>.NativeClassPtr, 100672468);
			uint4x3.NativeMethodInfoPtr_op_Multiply_Public_Static_uint4x3_uint4x3_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4x3>.NativeClassPtr, 100672469);
			uint4x3.NativeMethodInfoPtr_op_Multiply_Public_Static_uint4x3_UInt32_uint4x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4x3>.NativeClassPtr, 100672470);
			uint4x3.NativeMethodInfoPtr_op_Addition_Public_Static_uint4x3_uint4x3_uint4x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4x3>.NativeClassPtr, 100672471);
			uint4x3.NativeMethodInfoPtr_op_Addition_Public_Static_uint4x3_uint4x3_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4x3>.NativeClassPtr, 100672472);
			uint4x3.NativeMethodInfoPtr_op_Addition_Public_Static_uint4x3_UInt32_uint4x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4x3>.NativeClassPtr, 100672473);
			uint4x3.NativeMethodInfoPtr_op_Subtraction_Public_Static_uint4x3_uint4x3_uint4x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4x3>.NativeClassPtr, 100672474);
			uint4x3.NativeMethodInfoPtr_op_Subtraction_Public_Static_uint4x3_uint4x3_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4x3>.NativeClassPtr, 100672475);
			uint4x3.NativeMethodInfoPtr_op_Subtraction_Public_Static_uint4x3_UInt32_uint4x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4x3>.NativeClassPtr, 100672476);
			uint4x3.NativeMethodInfoPtr_op_Division_Public_Static_uint4x3_uint4x3_uint4x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4x3>.NativeClassPtr, 100672477);
			uint4x3.NativeMethodInfoPtr_op_Division_Public_Static_uint4x3_uint4x3_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4x3>.NativeClassPtr, 100672478);
			uint4x3.NativeMethodInfoPtr_op_Division_Public_Static_uint4x3_UInt32_uint4x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4x3>.NativeClassPtr, 100672479);
			uint4x3.NativeMethodInfoPtr_op_Modulus_Public_Static_uint4x3_uint4x3_uint4x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4x3>.NativeClassPtr, 100672480);
			uint4x3.NativeMethodInfoPtr_op_Modulus_Public_Static_uint4x3_uint4x3_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4x3>.NativeClassPtr, 100672481);
			uint4x3.NativeMethodInfoPtr_op_Modulus_Public_Static_uint4x3_UInt32_uint4x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4x3>.NativeClassPtr, 100672482);
			uint4x3.NativeMethodInfoPtr_op_Increment_Public_Static_uint4x3_uint4x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4x3>.NativeClassPtr, 100672483);
			uint4x3.NativeMethodInfoPtr_op_Decrement_Public_Static_uint4x3_uint4x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4x3>.NativeClassPtr, 100672484);
			uint4x3.NativeMethodInfoPtr_op_LessThan_Public_Static_bool4x3_uint4x3_uint4x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4x3>.NativeClassPtr, 100672485);
			uint4x3.NativeMethodInfoPtr_op_LessThan_Public_Static_bool4x3_uint4x3_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4x3>.NativeClassPtr, 100672486);
			uint4x3.NativeMethodInfoPtr_op_LessThan_Public_Static_bool4x3_UInt32_uint4x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4x3>.NativeClassPtr, 100672487);
			uint4x3.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool4x3_uint4x3_uint4x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4x3>.NativeClassPtr, 100672488);
			uint4x3.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool4x3_uint4x3_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4x3>.NativeClassPtr, 100672489);
			uint4x3.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool4x3_UInt32_uint4x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4x3>.NativeClassPtr, 100672490);
			uint4x3.NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool4x3_uint4x3_uint4x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4x3>.NativeClassPtr, 100672491);
			uint4x3.NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool4x3_uint4x3_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4x3>.NativeClassPtr, 100672492);
			uint4x3.NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool4x3_UInt32_uint4x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4x3>.NativeClassPtr, 100672493);
			uint4x3.NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool4x3_uint4x3_uint4x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4x3>.NativeClassPtr, 100672494);
			uint4x3.NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool4x3_uint4x3_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4x3>.NativeClassPtr, 100672495);
			uint4x3.NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool4x3_UInt32_uint4x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4x3>.NativeClassPtr, 100672496);
			uint4x3.NativeMethodInfoPtr_op_UnaryNegation_Public_Static_uint4x3_uint4x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4x3>.NativeClassPtr, 100672497);
			uint4x3.NativeMethodInfoPtr_op_UnaryPlus_Public_Static_uint4x3_uint4x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4x3>.NativeClassPtr, 100672498);
			uint4x3.NativeMethodInfoPtr_op_LeftShift_Public_Static_uint4x3_uint4x3_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4x3>.NativeClassPtr, 100672499);
			uint4x3.NativeMethodInfoPtr_op_RightShift_Public_Static_uint4x3_uint4x3_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4x3>.NativeClassPtr, 100672500);
			uint4x3.NativeMethodInfoPtr_op_Equality_Public_Static_bool4x3_uint4x3_uint4x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4x3>.NativeClassPtr, 100672501);
			uint4x3.NativeMethodInfoPtr_op_Equality_Public_Static_bool4x3_uint4x3_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4x3>.NativeClassPtr, 100672502);
			uint4x3.NativeMethodInfoPtr_op_Equality_Public_Static_bool4x3_UInt32_uint4x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4x3>.NativeClassPtr, 100672503);
			uint4x3.NativeMethodInfoPtr_op_Inequality_Public_Static_bool4x3_uint4x3_uint4x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4x3>.NativeClassPtr, 100672504);
			uint4x3.NativeMethodInfoPtr_op_Inequality_Public_Static_bool4x3_uint4x3_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4x3>.NativeClassPtr, 100672505);
			uint4x3.NativeMethodInfoPtr_op_Inequality_Public_Static_bool4x3_UInt32_uint4x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4x3>.NativeClassPtr, 100672506);
			uint4x3.NativeMethodInfoPtr_op_OnesComplement_Public_Static_uint4x3_uint4x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4x3>.NativeClassPtr, 100672507);
			uint4x3.NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_uint4x3_uint4x3_uint4x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4x3>.NativeClassPtr, 100672508);
			uint4x3.NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_uint4x3_uint4x3_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4x3>.NativeClassPtr, 100672509);
			uint4x3.NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_uint4x3_UInt32_uint4x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4x3>.NativeClassPtr, 100672510);
			uint4x3.NativeMethodInfoPtr_op_BitwiseOr_Public_Static_uint4x3_uint4x3_uint4x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4x3>.NativeClassPtr, 100672511);
			uint4x3.NativeMethodInfoPtr_op_BitwiseOr_Public_Static_uint4x3_uint4x3_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4x3>.NativeClassPtr, 100672512);
			uint4x3.NativeMethodInfoPtr_op_BitwiseOr_Public_Static_uint4x3_UInt32_uint4x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4x3>.NativeClassPtr, 100672513);
			uint4x3.NativeMethodInfoPtr_op_ExclusiveOr_Public_Static_uint4x3_uint4x3_uint4x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4x3>.NativeClassPtr, 100672514);
			uint4x3.NativeMethodInfoPtr_op_ExclusiveOr_Public_Static_uint4x3_uint4x3_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4x3>.NativeClassPtr, 100672515);
			uint4x3.NativeMethodInfoPtr_op_ExclusiveOr_Public_Static_uint4x3_UInt32_uint4x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4x3>.NativeClassPtr, 100672516);
			uint4x3.NativeMethodInfoPtr_get_Item_Public_get_byref_uint4_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4x3>.NativeClassPtr, 100672517);
			uint4x3.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_uint4x3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4x3>.NativeClassPtr, 100672518);
			uint4x3.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4x3>.NativeClassPtr, 100672519);
			uint4x3.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4x3>.NativeClassPtr, 100672520);
			uint4x3.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4x3>.NativeClassPtr, 100672521);
			uint4x3.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<uint4x3>.NativeClassPtr, 100672522);
		}

		// Token: 0x060024D9 RID: 9433 RVA: 0x000BEDA0 File Offset: 0x000BCFA0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 556238, RefRangeEnd = 556240, XrefRangeStart = 556238, XrefRangeEnd = 556240, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe uint4x3(uint4 c0, uint4 c1, uint4 c2)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4x3.NativeMethodInfoPtr__ctor_Public_Void_uint4_uint4_uint4_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060024DA RID: 9434 RVA: 0x000BEDF0 File Offset: 0x000BCFF0
		[CallerCount(0)]
		public unsafe uint4x3(uint m00, uint m01, uint m02, uint m10, uint m11, uint m12, uint m20, uint m21, uint m22, uint m30, uint m31, uint m32)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4x3.NativeMethodInfoPtr__ctor_Public_Void_UInt32_UInt32_UInt32_UInt32_UInt32_UInt32_UInt32_UInt32_UInt32_UInt32_UInt32_UInt32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060024DB RID: 9435 RVA: 0x000BEEC0 File Offset: 0x000BD0C0
		[CallerCount(0)]
		public unsafe uint4x3(uint v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4x3.NativeMethodInfoPtr__ctor_Public_Void_UInt32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060024DC RID: 9436 RVA: 0x000BEEF4 File Offset: 0x000BD0F4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 642395, RefRangeEnd = 642396, XrefRangeStart = 642393, XrefRangeEnd = 642395, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe uint4x3(bool v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4x3.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060024DD RID: 9437 RVA: 0x000BEF28 File Offset: 0x000BD128
		[CallerCount(0)]
		public unsafe uint4x3(bool4x3 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4x3.NativeMethodInfoPtr__ctor_Public_Void_bool4x3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060024DE RID: 9438 RVA: 0x000BEF5C File Offset: 0x000BD15C
		[CallerCount(0)]
		public unsafe uint4x3(int v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4x3.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060024DF RID: 9439 RVA: 0x000BEF90 File Offset: 0x000BD190
		[CallerCount(0)]
		public unsafe uint4x3(int4x3 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4x3.NativeMethodInfoPtr__ctor_Public_Void_int4x3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060024E0 RID: 9440 RVA: 0x000BEFC4 File Offset: 0x000BD1C4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 642407, RefRangeEnd = 642408, XrefRangeStart = 642396, XrefRangeEnd = 642407, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe uint4x3(float v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4x3.NativeMethodInfoPtr__ctor_Public_Void_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060024E1 RID: 9441 RVA: 0x000BEFF8 File Offset: 0x000BD1F8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 642419, RefRangeEnd = 642421, XrefRangeStart = 642408, XrefRangeEnd = 642419, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe uint4x3(float4x3 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4x3.NativeMethodInfoPtr__ctor_Public_Void_float4x3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060024E2 RID: 9442 RVA: 0x000BF02C File Offset: 0x000BD22C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 642432, RefRangeEnd = 642433, XrefRangeStart = 642421, XrefRangeEnd = 642432, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe uint4x3(double v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4x3.NativeMethodInfoPtr__ctor_Public_Void_Double_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060024E3 RID: 9443 RVA: 0x000BF060 File Offset: 0x000BD260
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 642444, RefRangeEnd = 642446, XrefRangeStart = 642433, XrefRangeEnd = 642444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe uint4x3(double4x3 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4x3.NativeMethodInfoPtr__ctor_Public_Void_double4x3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060024E4 RID: 9444 RVA: 0x000BF094 File Offset: 0x000BD294
		[CallerCount(0)]
		public unsafe static implicit operator uint4x3(uint v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4x3.NativeMethodInfoPtr_op_Implicit_Public_Static_uint4x3_UInt32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060024E5 RID: 9445 RVA: 0x000BF0D4 File Offset: 0x000BD2D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 642446, XrefRangeEnd = 642447, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator uint4x3(bool v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4x3.NativeMethodInfoPtr_op_Explicit_Public_Static_uint4x3_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060024E6 RID: 9446 RVA: 0x000BF114 File Offset: 0x000BD314
		[CallerCount(0)]
		public unsafe static explicit operator uint4x3(bool4x3 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4x3.NativeMethodInfoPtr_op_Explicit_Public_Static_uint4x3_bool4x3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060024E7 RID: 9447 RVA: 0x000BF154 File Offset: 0x000BD354
		[CallerCount(0)]
		public unsafe static explicit operator uint4x3(int v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4x3.NativeMethodInfoPtr_op_Explicit_Public_Static_uint4x3_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060024E8 RID: 9448 RVA: 0x000BF194 File Offset: 0x000BD394
		[CallerCount(0)]
		public unsafe static explicit operator uint4x3(int4x3 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4x3.NativeMethodInfoPtr_op_Explicit_Public_Static_uint4x3_int4x3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060024E9 RID: 9449 RVA: 0x000BF1D4 File Offset: 0x000BD3D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 642447, XrefRangeEnd = 642448, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator uint4x3(float v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4x3.NativeMethodInfoPtr_op_Explicit_Public_Static_uint4x3_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060024EA RID: 9450 RVA: 0x000BF214 File Offset: 0x000BD414
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator uint4x3(float4x3 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4x3.NativeMethodInfoPtr_op_Explicit_Public_Static_uint4x3_float4x3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060024EB RID: 9451 RVA: 0x000BF254 File Offset: 0x000BD454
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 642448, XrefRangeEnd = 642449, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator uint4x3(double v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4x3.NativeMethodInfoPtr_op_Explicit_Public_Static_uint4x3_Double_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060024EC RID: 9452 RVA: 0x000BF294 File Offset: 0x000BD494
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator uint4x3(double4x3 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4x3.NativeMethodInfoPtr_op_Explicit_Public_Static_uint4x3_double4x3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060024ED RID: 9453 RVA: 0x000BF2D4 File Offset: 0x000BD4D4
		[CallerCount(0)]
		public unsafe static uint4x3 operator *(uint4x3 lhs, uint4x3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4x3.NativeMethodInfoPtr_op_Multiply_Public_Static_uint4x3_uint4x3_uint4x3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060024EE RID: 9454 RVA: 0x000BF320 File Offset: 0x000BD520
		[CallerCount(0)]
		public unsafe static uint4x3 operator *(uint4x3 lhs, uint rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4x3.NativeMethodInfoPtr_op_Multiply_Public_Static_uint4x3_uint4x3_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060024EF RID: 9455 RVA: 0x000BF36C File Offset: 0x000BD56C
		[CallerCount(0)]
		public unsafe static uint4x3 operator *(uint lhs, uint4x3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4x3.NativeMethodInfoPtr_op_Multiply_Public_Static_uint4x3_UInt32_uint4x3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060024F0 RID: 9456 RVA: 0x000BF3B8 File Offset: 0x000BD5B8
		[CallerCount(0)]
		public unsafe static uint4x3 operator +(uint4x3 lhs, uint4x3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4x3.NativeMethodInfoPtr_op_Addition_Public_Static_uint4x3_uint4x3_uint4x3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060024F1 RID: 9457 RVA: 0x000BF404 File Offset: 0x000BD604
		[CallerCount(0)]
		public unsafe static uint4x3 operator +(uint4x3 lhs, uint rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4x3.NativeMethodInfoPtr_op_Addition_Public_Static_uint4x3_uint4x3_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060024F2 RID: 9458 RVA: 0x000BF450 File Offset: 0x000BD650
		[CallerCount(0)]
		public unsafe static uint4x3 operator +(uint lhs, uint4x3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4x3.NativeMethodInfoPtr_op_Addition_Public_Static_uint4x3_UInt32_uint4x3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060024F3 RID: 9459 RVA: 0x000BF49C File Offset: 0x000BD69C
		[CallerCount(0)]
		public unsafe static uint4x3 operator -(uint4x3 lhs, uint4x3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4x3.NativeMethodInfoPtr_op_Subtraction_Public_Static_uint4x3_uint4x3_uint4x3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060024F4 RID: 9460 RVA: 0x000BF4E8 File Offset: 0x000BD6E8
		[CallerCount(0)]
		public unsafe static uint4x3 operator -(uint4x3 lhs, uint rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4x3.NativeMethodInfoPtr_op_Subtraction_Public_Static_uint4x3_uint4x3_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060024F5 RID: 9461 RVA: 0x000BF534 File Offset: 0x000BD734
		[CallerCount(0)]
		public unsafe static uint4x3 operator -(uint lhs, uint4x3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4x3.NativeMethodInfoPtr_op_Subtraction_Public_Static_uint4x3_UInt32_uint4x3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060024F6 RID: 9462 RVA: 0x000BF580 File Offset: 0x000BD780
		[CallerCount(0)]
		public unsafe static uint4x3 operator /(uint4x3 lhs, uint4x3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4x3.NativeMethodInfoPtr_op_Division_Public_Static_uint4x3_uint4x3_uint4x3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060024F7 RID: 9463 RVA: 0x000BF5CC File Offset: 0x000BD7CC
		[CallerCount(0)]
		public unsafe static uint4x3 operator /(uint4x3 lhs, uint rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4x3.NativeMethodInfoPtr_op_Division_Public_Static_uint4x3_uint4x3_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060024F8 RID: 9464 RVA: 0x000BF618 File Offset: 0x000BD818
		[CallerCount(0)]
		public unsafe static uint4x3 operator /(uint lhs, uint4x3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4x3.NativeMethodInfoPtr_op_Division_Public_Static_uint4x3_UInt32_uint4x3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060024F9 RID: 9465 RVA: 0x000BF664 File Offset: 0x000BD864
		[CallerCount(0)]
		public unsafe static uint4x3 operator %(uint4x3 lhs, uint4x3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4x3.NativeMethodInfoPtr_op_Modulus_Public_Static_uint4x3_uint4x3_uint4x3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060024FA RID: 9466 RVA: 0x000BF6B0 File Offset: 0x000BD8B0
		[CallerCount(0)]
		public unsafe static uint4x3 operator %(uint4x3 lhs, uint rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4x3.NativeMethodInfoPtr_op_Modulus_Public_Static_uint4x3_uint4x3_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060024FB RID: 9467 RVA: 0x000BF6FC File Offset: 0x000BD8FC
		[CallerCount(0)]
		public unsafe static uint4x3 operator %(uint lhs, uint4x3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4x3.NativeMethodInfoPtr_op_Modulus_Public_Static_uint4x3_UInt32_uint4x3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060024FC RID: 9468 RVA: 0x000BF748 File Offset: 0x000BD948
		[CallerCount(0)]
		public unsafe static uint4x3 operator ++(uint4x3 val)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4x3.NativeMethodInfoPtr_op_Increment_Public_Static_uint4x3_uint4x3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060024FD RID: 9469 RVA: 0x000BF788 File Offset: 0x000BD988
		[CallerCount(0)]
		public unsafe static uint4x3 operator --(uint4x3 val)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4x3.NativeMethodInfoPtr_op_Decrement_Public_Static_uint4x3_uint4x3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060024FE RID: 9470 RVA: 0x000BF7C8 File Offset: 0x000BD9C8
		[CallerCount(0)]
		public unsafe static bool4x3 operator <(uint4x3 lhs, uint4x3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4x3.NativeMethodInfoPtr_op_LessThan_Public_Static_bool4x3_uint4x3_uint4x3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060024FF RID: 9471 RVA: 0x000BF814 File Offset: 0x000BDA14
		[CallerCount(0)]
		public unsafe static bool4x3 operator <(uint4x3 lhs, uint rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4x3.NativeMethodInfoPtr_op_LessThan_Public_Static_bool4x3_uint4x3_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002500 RID: 9472 RVA: 0x000BF860 File Offset: 0x000BDA60
		[CallerCount(0)]
		public unsafe static bool4x3 operator <(uint lhs, uint4x3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4x3.NativeMethodInfoPtr_op_LessThan_Public_Static_bool4x3_UInt32_uint4x3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002501 RID: 9473 RVA: 0x000BF8AC File Offset: 0x000BDAAC
		[CallerCount(0)]
		public unsafe static bool4x3 operator <=(uint4x3 lhs, uint4x3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4x3.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool4x3_uint4x3_uint4x3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002502 RID: 9474 RVA: 0x000BF8F8 File Offset: 0x000BDAF8
		[CallerCount(0)]
		public unsafe static bool4x3 operator <=(uint4x3 lhs, uint rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4x3.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool4x3_uint4x3_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002503 RID: 9475 RVA: 0x000BF944 File Offset: 0x000BDB44
		[CallerCount(0)]
		public unsafe static bool4x3 operator <=(uint lhs, uint4x3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4x3.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool4x3_UInt32_uint4x3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002504 RID: 9476 RVA: 0x000BF990 File Offset: 0x000BDB90
		[CallerCount(0)]
		public unsafe static bool4x3 operator >(uint4x3 lhs, uint4x3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4x3.NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool4x3_uint4x3_uint4x3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002505 RID: 9477 RVA: 0x000BF9DC File Offset: 0x000BDBDC
		[CallerCount(0)]
		public unsafe static bool4x3 operator >(uint4x3 lhs, uint rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4x3.NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool4x3_uint4x3_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002506 RID: 9478 RVA: 0x000BFA28 File Offset: 0x000BDC28
		[CallerCount(0)]
		public unsafe static bool4x3 operator >(uint lhs, uint4x3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4x3.NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool4x3_UInt32_uint4x3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002507 RID: 9479 RVA: 0x000BFA74 File Offset: 0x000BDC74
		[CallerCount(0)]
		public unsafe static bool4x3 operator >=(uint4x3 lhs, uint4x3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4x3.NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool4x3_uint4x3_uint4x3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002508 RID: 9480 RVA: 0x000BFAC0 File Offset: 0x000BDCC0
		[CallerCount(0)]
		public unsafe static bool4x3 operator >=(uint4x3 lhs, uint rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4x3.NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool4x3_uint4x3_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002509 RID: 9481 RVA: 0x000BFB0C File Offset: 0x000BDD0C
		[CallerCount(0)]
		public unsafe static bool4x3 operator >=(uint lhs, uint4x3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4x3.NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool4x3_UInt32_uint4x3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600250A RID: 9482 RVA: 0x000BFB58 File Offset: 0x000BDD58
		[CallerCount(0)]
		public unsafe static uint4x3 operator -(uint4x3 val)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4x3.NativeMethodInfoPtr_op_UnaryNegation_Public_Static_uint4x3_uint4x3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600250B RID: 9483 RVA: 0x000BFB98 File Offset: 0x000BDD98
		[CallerCount(0)]
		public unsafe static uint4x3 operator +(uint4x3 val)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4x3.NativeMethodInfoPtr_op_UnaryPlus_Public_Static_uint4x3_uint4x3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600250C RID: 9484 RVA: 0x000BFBD8 File Offset: 0x000BDDD8
		[CallerCount(0)]
		public unsafe static uint4x3 operator <<(uint4x3 x, int n)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref n;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4x3.NativeMethodInfoPtr_op_LeftShift_Public_Static_uint4x3_uint4x3_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600250D RID: 9485 RVA: 0x000BFC24 File Offset: 0x000BDE24
		[CallerCount(0)]
		public unsafe static uint4x3 operator >>(uint4x3 x, int n)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref n;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4x3.NativeMethodInfoPtr_op_RightShift_Public_Static_uint4x3_uint4x3_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600250E RID: 9486 RVA: 0x000BFC70 File Offset: 0x000BDE70
		[CallerCount(0)]
		public unsafe static bool4x3 operator ==(uint4x3 lhs, uint4x3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4x3.NativeMethodInfoPtr_op_Equality_Public_Static_bool4x3_uint4x3_uint4x3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600250F RID: 9487 RVA: 0x000BFCBC File Offset: 0x000BDEBC
		[CallerCount(0)]
		public unsafe static bool4x3 operator ==(uint4x3 lhs, uint rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4x3.NativeMethodInfoPtr_op_Equality_Public_Static_bool4x3_uint4x3_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002510 RID: 9488 RVA: 0x000BFD08 File Offset: 0x000BDF08
		[CallerCount(0)]
		public unsafe static bool4x3 operator ==(uint lhs, uint4x3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4x3.NativeMethodInfoPtr_op_Equality_Public_Static_bool4x3_UInt32_uint4x3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002511 RID: 9489 RVA: 0x000BFD54 File Offset: 0x000BDF54
		[CallerCount(0)]
		public unsafe static bool4x3 operator !=(uint4x3 lhs, uint4x3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4x3.NativeMethodInfoPtr_op_Inequality_Public_Static_bool4x3_uint4x3_uint4x3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002512 RID: 9490 RVA: 0x000BFDA0 File Offset: 0x000BDFA0
		[CallerCount(0)]
		public unsafe static bool4x3 operator !=(uint4x3 lhs, uint rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4x3.NativeMethodInfoPtr_op_Inequality_Public_Static_bool4x3_uint4x3_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002513 RID: 9491 RVA: 0x000BFDEC File Offset: 0x000BDFEC
		[CallerCount(0)]
		public unsafe static bool4x3 operator !=(uint lhs, uint4x3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4x3.NativeMethodInfoPtr_op_Inequality_Public_Static_bool4x3_UInt32_uint4x3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002514 RID: 9492 RVA: 0x000BFE38 File Offset: 0x000BE038
		[CallerCount(0)]
		public unsafe static uint4x3 operator ~(uint4x3 val)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4x3.NativeMethodInfoPtr_op_OnesComplement_Public_Static_uint4x3_uint4x3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002515 RID: 9493 RVA: 0x000BFE78 File Offset: 0x000BE078
		[CallerCount(0)]
		public unsafe static uint4x3 operator &(uint4x3 lhs, uint4x3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4x3.NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_uint4x3_uint4x3_uint4x3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002516 RID: 9494 RVA: 0x000BFEC4 File Offset: 0x000BE0C4
		[CallerCount(0)]
		public unsafe static uint4x3 operator &(uint4x3 lhs, uint rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4x3.NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_uint4x3_uint4x3_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002517 RID: 9495 RVA: 0x000BFF10 File Offset: 0x000BE110
		[CallerCount(0)]
		public unsafe static uint4x3 operator &(uint lhs, uint4x3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4x3.NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_uint4x3_UInt32_uint4x3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002518 RID: 9496 RVA: 0x000BFF5C File Offset: 0x000BE15C
		[CallerCount(0)]
		public unsafe static uint4x3 operator |(uint4x3 lhs, uint4x3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4x3.NativeMethodInfoPtr_op_BitwiseOr_Public_Static_uint4x3_uint4x3_uint4x3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002519 RID: 9497 RVA: 0x000BFFA8 File Offset: 0x000BE1A8
		[CallerCount(0)]
		public unsafe static uint4x3 operator |(uint4x3 lhs, uint rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4x3.NativeMethodInfoPtr_op_BitwiseOr_Public_Static_uint4x3_uint4x3_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600251A RID: 9498 RVA: 0x000BFFF4 File Offset: 0x000BE1F4
		[CallerCount(0)]
		public unsafe static uint4x3 operator |(uint lhs, uint4x3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4x3.NativeMethodInfoPtr_op_BitwiseOr_Public_Static_uint4x3_UInt32_uint4x3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600251B RID: 9499 RVA: 0x000C0040 File Offset: 0x000BE240
		[CallerCount(0)]
		public unsafe static uint4x3 operator ^(uint4x3 lhs, uint4x3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4x3.NativeMethodInfoPtr_op_ExclusiveOr_Public_Static_uint4x3_uint4x3_uint4x3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600251C RID: 9500 RVA: 0x000C008C File Offset: 0x000BE28C
		[CallerCount(0)]
		public unsafe static uint4x3 operator ^(uint4x3 lhs, uint rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4x3.NativeMethodInfoPtr_op_ExclusiveOr_Public_Static_uint4x3_uint4x3_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600251D RID: 9501 RVA: 0x000C00D8 File Offset: 0x000BE2D8
		[CallerCount(0)]
		public unsafe static uint4x3 operator ^(uint lhs, uint4x3 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4x3.NativeMethodInfoPtr_op_ExclusiveOr_Public_Static_uint4x3_UInt32_uint4x3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000BDE RID: 3038
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4x3.NativeMethodInfoPtr_get_Item_Public_get_byref_uint4_Int32_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return intPtr;
				}
			}
		}

		// Token: 0x0600251F RID: 9503 RVA: 0x000C0158 File Offset: 0x000BE358
		[CallerCount(0)]
		public unsafe bool Equals(uint4x3 rhs)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref rhs;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4x3.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_uint4x3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002520 RID: 9504 RVA: 0x000C0198 File Offset: 0x000BE398
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 642449, XrefRangeEnd = 642452, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object o)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(o);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4x3.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002521 RID: 9505 RVA: 0x000C01DC File Offset: 0x000BE3DC
		[CallerCount(0)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4x3.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002522 RID: 9506 RVA: 0x000C020C File Offset: 0x000BE40C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 642452, XrefRangeEnd = 642507, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4x3.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06002523 RID: 9507 RVA: 0x000C0238 File Offset: 0x000BE438
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 642507, XrefRangeEnd = 642575, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(uint4x3.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06002524 RID: 9508 RVA: 0x00002A69 File Offset: 0x00000C69
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<uint4x3>.NativeClassPtr, ref this));
		}

		// Token: 0x17000BDD RID: 3037
		// (get) Token: 0x06002525 RID: 9509 RVA: 0x000C0288 File Offset: 0x000BE488
		// (set) Token: 0x06002526 RID: 9510 RVA: 0x00002A7B File Offset: 0x00000C7B
		public unsafe static uint4x3 zero
		{
			get
			{
				uint4x3 uint4x;
				IL2CPP.il2cpp_field_static_get_value(uint4x3.NativeFieldInfoPtr_zero, (void*)(&uint4x));
				return uint4x;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(uint4x3.NativeFieldInfoPtr_zero, (void*)(&value));
			}
		}

		// Token: 0x0400256B RID: 9579
		private static readonly IntPtr NativeFieldInfoPtr_c0;

		// Token: 0x0400256C RID: 9580
		private static readonly IntPtr NativeFieldInfoPtr_c1;

		// Token: 0x0400256D RID: 9581
		private static readonly IntPtr NativeFieldInfoPtr_c2;

		// Token: 0x0400256E RID: 9582
		private static readonly IntPtr NativeFieldInfoPtr_zero;

		// Token: 0x0400256F RID: 9583
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_uint4_uint4_uint4_0;

		// Token: 0x04002570 RID: 9584
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_UInt32_UInt32_UInt32_UInt32_UInt32_UInt32_UInt32_UInt32_UInt32_UInt32_UInt32_UInt32_0;

		// Token: 0x04002571 RID: 9585
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_UInt32_0;

		// Token: 0x04002572 RID: 9586
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_0;

		// Token: 0x04002573 RID: 9587
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_bool4x3_0;

		// Token: 0x04002574 RID: 9588
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x04002575 RID: 9589
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_int4x3_0;

		// Token: 0x04002576 RID: 9590
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_0;

		// Token: 0x04002577 RID: 9591
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_float4x3_0;

		// Token: 0x04002578 RID: 9592
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Double_0;

		// Token: 0x04002579 RID: 9593
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_double4x3_0;

		// Token: 0x0400257A RID: 9594
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_uint4x3_UInt32_0;

		// Token: 0x0400257B RID: 9595
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_uint4x3_Boolean_0;

		// Token: 0x0400257C RID: 9596
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_uint4x3_bool4x3_0;

		// Token: 0x0400257D RID: 9597
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_uint4x3_Int32_0;

		// Token: 0x0400257E RID: 9598
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_uint4x3_int4x3_0;

		// Token: 0x0400257F RID: 9599
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_uint4x3_Single_0;

		// Token: 0x04002580 RID: 9600
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_uint4x3_float4x3_0;

		// Token: 0x04002581 RID: 9601
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_uint4x3_Double_0;

		// Token: 0x04002582 RID: 9602
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_uint4x3_double4x3_0;

		// Token: 0x04002583 RID: 9603
		private static readonly IntPtr NativeMethodInfoPtr_op_Multiply_Public_Static_uint4x3_uint4x3_uint4x3_0;

		// Token: 0x04002584 RID: 9604
		private static readonly IntPtr NativeMethodInfoPtr_op_Multiply_Public_Static_uint4x3_uint4x3_UInt32_0;

		// Token: 0x04002585 RID: 9605
		private static readonly IntPtr NativeMethodInfoPtr_op_Multiply_Public_Static_uint4x3_UInt32_uint4x3_0;

		// Token: 0x04002586 RID: 9606
		private static readonly IntPtr NativeMethodInfoPtr_op_Addition_Public_Static_uint4x3_uint4x3_uint4x3_0;

		// Token: 0x04002587 RID: 9607
		private static readonly IntPtr NativeMethodInfoPtr_op_Addition_Public_Static_uint4x3_uint4x3_UInt32_0;

		// Token: 0x04002588 RID: 9608
		private static readonly IntPtr NativeMethodInfoPtr_op_Addition_Public_Static_uint4x3_UInt32_uint4x3_0;

		// Token: 0x04002589 RID: 9609
		private static readonly IntPtr NativeMethodInfoPtr_op_Subtraction_Public_Static_uint4x3_uint4x3_uint4x3_0;

		// Token: 0x0400258A RID: 9610
		private static readonly IntPtr NativeMethodInfoPtr_op_Subtraction_Public_Static_uint4x3_uint4x3_UInt32_0;

		// Token: 0x0400258B RID: 9611
		private static readonly IntPtr NativeMethodInfoPtr_op_Subtraction_Public_Static_uint4x3_UInt32_uint4x3_0;

		// Token: 0x0400258C RID: 9612
		private static readonly IntPtr NativeMethodInfoPtr_op_Division_Public_Static_uint4x3_uint4x3_uint4x3_0;

		// Token: 0x0400258D RID: 9613
		private static readonly IntPtr NativeMethodInfoPtr_op_Division_Public_Static_uint4x3_uint4x3_UInt32_0;

		// Token: 0x0400258E RID: 9614
		private static readonly IntPtr NativeMethodInfoPtr_op_Division_Public_Static_uint4x3_UInt32_uint4x3_0;

		// Token: 0x0400258F RID: 9615
		private static readonly IntPtr NativeMethodInfoPtr_op_Modulus_Public_Static_uint4x3_uint4x3_uint4x3_0;

		// Token: 0x04002590 RID: 9616
		private static readonly IntPtr NativeMethodInfoPtr_op_Modulus_Public_Static_uint4x3_uint4x3_UInt32_0;

		// Token: 0x04002591 RID: 9617
		private static readonly IntPtr NativeMethodInfoPtr_op_Modulus_Public_Static_uint4x3_UInt32_uint4x3_0;

		// Token: 0x04002592 RID: 9618
		private static readonly IntPtr NativeMethodInfoPtr_op_Increment_Public_Static_uint4x3_uint4x3_0;

		// Token: 0x04002593 RID: 9619
		private static readonly IntPtr NativeMethodInfoPtr_op_Decrement_Public_Static_uint4x3_uint4x3_0;

		// Token: 0x04002594 RID: 9620
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThan_Public_Static_bool4x3_uint4x3_uint4x3_0;

		// Token: 0x04002595 RID: 9621
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThan_Public_Static_bool4x3_uint4x3_UInt32_0;

		// Token: 0x04002596 RID: 9622
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThan_Public_Static_bool4x3_UInt32_uint4x3_0;

		// Token: 0x04002597 RID: 9623
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool4x3_uint4x3_uint4x3_0;

		// Token: 0x04002598 RID: 9624
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool4x3_uint4x3_UInt32_0;

		// Token: 0x04002599 RID: 9625
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_bool4x3_UInt32_uint4x3_0;

		// Token: 0x0400259A RID: 9626
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool4x3_uint4x3_uint4x3_0;

		// Token: 0x0400259B RID: 9627
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool4x3_uint4x3_UInt32_0;

		// Token: 0x0400259C RID: 9628
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThan_Public_Static_bool4x3_UInt32_uint4x3_0;

		// Token: 0x0400259D RID: 9629
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool4x3_uint4x3_uint4x3_0;

		// Token: 0x0400259E RID: 9630
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool4x3_uint4x3_UInt32_0;

		// Token: 0x0400259F RID: 9631
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_bool4x3_UInt32_uint4x3_0;

		// Token: 0x040025A0 RID: 9632
		private static readonly IntPtr NativeMethodInfoPtr_op_UnaryNegation_Public_Static_uint4x3_uint4x3_0;

		// Token: 0x040025A1 RID: 9633
		private static readonly IntPtr NativeMethodInfoPtr_op_UnaryPlus_Public_Static_uint4x3_uint4x3_0;

		// Token: 0x040025A2 RID: 9634
		private static readonly IntPtr NativeMethodInfoPtr_op_LeftShift_Public_Static_uint4x3_uint4x3_Int32_0;

		// Token: 0x040025A3 RID: 9635
		private static readonly IntPtr NativeMethodInfoPtr_op_RightShift_Public_Static_uint4x3_uint4x3_Int32_0;

		// Token: 0x040025A4 RID: 9636
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_bool4x3_uint4x3_uint4x3_0;

		// Token: 0x040025A5 RID: 9637
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_bool4x3_uint4x3_UInt32_0;

		// Token: 0x040025A6 RID: 9638
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_bool4x3_UInt32_uint4x3_0;

		// Token: 0x040025A7 RID: 9639
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_bool4x3_uint4x3_uint4x3_0;

		// Token: 0x040025A8 RID: 9640
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_bool4x3_uint4x3_UInt32_0;

		// Token: 0x040025A9 RID: 9641
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_bool4x3_UInt32_uint4x3_0;

		// Token: 0x040025AA RID: 9642
		private static readonly IntPtr NativeMethodInfoPtr_op_OnesComplement_Public_Static_uint4x3_uint4x3_0;

		// Token: 0x040025AB RID: 9643
		private static readonly IntPtr NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_uint4x3_uint4x3_uint4x3_0;

		// Token: 0x040025AC RID: 9644
		private static readonly IntPtr NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_uint4x3_uint4x3_UInt32_0;

		// Token: 0x040025AD RID: 9645
		private static readonly IntPtr NativeMethodInfoPtr_op_BitwiseAnd_Public_Static_uint4x3_UInt32_uint4x3_0;

		// Token: 0x040025AE RID: 9646
		private static readonly IntPtr NativeMethodInfoPtr_op_BitwiseOr_Public_Static_uint4x3_uint4x3_uint4x3_0;

		// Token: 0x040025AF RID: 9647
		private static readonly IntPtr NativeMethodInfoPtr_op_BitwiseOr_Public_Static_uint4x3_uint4x3_UInt32_0;

		// Token: 0x040025B0 RID: 9648
		private static readonly IntPtr NativeMethodInfoPtr_op_BitwiseOr_Public_Static_uint4x3_UInt32_uint4x3_0;

		// Token: 0x040025B1 RID: 9649
		private static readonly IntPtr NativeMethodInfoPtr_op_ExclusiveOr_Public_Static_uint4x3_uint4x3_uint4x3_0;

		// Token: 0x040025B2 RID: 9650
		private static readonly IntPtr NativeMethodInfoPtr_op_ExclusiveOr_Public_Static_uint4x3_uint4x3_UInt32_0;

		// Token: 0x040025B3 RID: 9651
		private static readonly IntPtr NativeMethodInfoPtr_op_ExclusiveOr_Public_Static_uint4x3_UInt32_uint4x3_0;

		// Token: 0x040025B4 RID: 9652
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_get_byref_uint4_Int32_0;

		// Token: 0x040025B5 RID: 9653
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_uint4x3_0;

		// Token: 0x040025B6 RID: 9654
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x040025B7 RID: 9655
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x040025B8 RID: 9656
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x040025B9 RID: 9657
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0;

		// Token: 0x040025BA RID: 9658
		[FieldOffset(0)]
		public uint4 c0;

		// Token: 0x040025BB RID: 9659
		[FieldOffset(16)]
		public uint4 c1;

		// Token: 0x040025BC RID: 9660
		[FieldOffset(32)]
		public uint4 c2;
	}
}
