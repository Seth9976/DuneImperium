using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x02000101 RID: 257
	[StructLayout(2)]
	public struct Vector2
	{
		// Token: 0x060014EC RID: 5356 RVA: 0x000675C4 File Offset: 0x000657C4
		// Note: this type is marked as 'beforefieldinit'.
		static Vector2()
		{
			Il2CppClassPointerStore<Vector2>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "Vector2");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Vector2>.NativeClassPtr);
			Vector2.NativeFieldInfoPtr_x = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vector2>.NativeClassPtr, "x");
			Vector2.NativeFieldInfoPtr_y = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vector2>.NativeClassPtr, "y");
			Vector2.NativeFieldInfoPtr_zeroVector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vector2>.NativeClassPtr, "zeroVector");
			Vector2.NativeFieldInfoPtr_oneVector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vector2>.NativeClassPtr, "oneVector");
			Vector2.NativeFieldInfoPtr_upVector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vector2>.NativeClassPtr, "upVector");
			Vector2.NativeFieldInfoPtr_downVector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vector2>.NativeClassPtr, "downVector");
			Vector2.NativeFieldInfoPtr_leftVector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vector2>.NativeClassPtr, "leftVector");
			Vector2.NativeFieldInfoPtr_rightVector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vector2>.NativeClassPtr, "rightVector");
			Vector2.NativeFieldInfoPtr_positiveInfinityVector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vector2>.NativeClassPtr, "positiveInfinityVector");
			Vector2.NativeFieldInfoPtr_negativeInfinityVector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vector2>.NativeClassPtr, "negativeInfinityVector");
			Vector2.NativeFieldInfoPtr_kEpsilon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vector2>.NativeClassPtr, "kEpsilon");
			Vector2.NativeFieldInfoPtr_kEpsilonNormalSqrt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vector2>.NativeClassPtr, "kEpsilonNormalSqrt");
			Vector2.NativeMethodInfoPtr_get_Item_Public_get_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector2>.NativeClassPtr, 100666249);
			Vector2.NativeMethodInfoPtr_set_Item_Public_set_Void_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector2>.NativeClassPtr, 100666250);
			Vector2.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector2>.NativeClassPtr, 100666251);
			Vector2.NativeMethodInfoPtr_Set_Public_Void_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector2>.NativeClassPtr, 100666252);
			Vector2.NativeMethodInfoPtr_Lerp_Public_Static_Vector2_Vector2_Vector2_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector2>.NativeClassPtr, 100666253);
			Vector2.NativeMethodInfoPtr_LerpUnclamped_Public_Static_Vector2_Vector2_Vector2_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector2>.NativeClassPtr, 100666254);
			Vector2.NativeMethodInfoPtr_Scale_Public_Static_Vector2_Vector2_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector2>.NativeClassPtr, 100666255);
			Vector2.NativeMethodInfoPtr_Normalize_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector2>.NativeClassPtr, 100666256);
			Vector2.NativeMethodInfoPtr_get_normalized_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector2>.NativeClassPtr, 100666257);
			Vector2.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector2>.NativeClassPtr, 100666258);
			Vector2.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector2>.NativeClassPtr, 100666259);
			Vector2.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector2>.NativeClassPtr, 100666260);
			Vector2.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector2>.NativeClassPtr, 100666261);
			Vector2.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector2>.NativeClassPtr, 100666262);
			Vector2.NativeMethodInfoPtr_Dot_Public_Static_Single_Vector2_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector2>.NativeClassPtr, 100666263);
			Vector2.NativeMethodInfoPtr_get_magnitude_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector2>.NativeClassPtr, 100666264);
			Vector2.NativeMethodInfoPtr_get_sqrMagnitude_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector2>.NativeClassPtr, 100666265);
			Vector2.NativeMethodInfoPtr_Angle_Public_Static_Single_Vector2_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector2>.NativeClassPtr, 100666266);
			Vector2.NativeMethodInfoPtr_Distance_Public_Static_Single_Vector2_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector2>.NativeClassPtr, 100666267);
			Vector2.NativeMethodInfoPtr_SqrMagnitude_Public_Static_Single_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector2>.NativeClassPtr, 100666268);
			Vector2.NativeMethodInfoPtr_SqrMagnitude_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector2>.NativeClassPtr, 100666269);
			Vector2.NativeMethodInfoPtr_Min_Public_Static_Vector2_Vector2_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector2>.NativeClassPtr, 100666270);
			Vector2.NativeMethodInfoPtr_Max_Public_Static_Vector2_Vector2_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector2>.NativeClassPtr, 100666271);
			Vector2.NativeMethodInfoPtr_SmoothDamp_Public_Static_Vector2_Vector2_Vector2_byref_Vector2_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector2>.NativeClassPtr, 100666272);
			Vector2.NativeMethodInfoPtr_SmoothDamp_Public_Static_Vector2_Vector2_Vector2_byref_Vector2_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector2>.NativeClassPtr, 100666273);
			Vector2.NativeMethodInfoPtr_op_Addition_Public_Static_Vector2_Vector2_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector2>.NativeClassPtr, 100666274);
			Vector2.NativeMethodInfoPtr_op_Subtraction_Public_Static_Vector2_Vector2_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector2>.NativeClassPtr, 100666275);
			Vector2.NativeMethodInfoPtr_op_Multiply_Public_Static_Vector2_Vector2_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector2>.NativeClassPtr, 100666276);
			Vector2.NativeMethodInfoPtr_op_Division_Public_Static_Vector2_Vector2_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector2>.NativeClassPtr, 100666277);
			Vector2.NativeMethodInfoPtr_op_UnaryNegation_Public_Static_Vector2_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector2>.NativeClassPtr, 100666278);
			Vector2.NativeMethodInfoPtr_op_Multiply_Public_Static_Vector2_Vector2_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector2>.NativeClassPtr, 100666279);
			Vector2.NativeMethodInfoPtr_op_Multiply_Public_Static_Vector2_Single_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector2>.NativeClassPtr, 100666280);
			Vector2.NativeMethodInfoPtr_op_Division_Public_Static_Vector2_Vector2_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector2>.NativeClassPtr, 100666281);
			Vector2.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Vector2_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector2>.NativeClassPtr, 100666282);
			Vector2.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_Vector2_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector2>.NativeClassPtr, 100666283);
			Vector2.NativeMethodInfoPtr_op_Implicit_Public_Static_Vector2_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector2>.NativeClassPtr, 100666284);
			Vector2.NativeMethodInfoPtr_op_Implicit_Public_Static_Vector3_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector2>.NativeClassPtr, 100666285);
			Vector2.NativeMethodInfoPtr_get_zero_Public_Static_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector2>.NativeClassPtr, 100666286);
			Vector2.NativeMethodInfoPtr_get_one_Public_Static_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector2>.NativeClassPtr, 100666287);
			Vector2.NativeMethodInfoPtr_get_up_Public_Static_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector2>.NativeClassPtr, 100666288);
			Vector2.NativeMethodInfoPtr_get_down_Public_Static_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector2>.NativeClassPtr, 100666289);
			Vector2.NativeMethodInfoPtr_get_left_Public_Static_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector2>.NativeClassPtr, 100666290);
			Vector2.NativeMethodInfoPtr_get_right_Public_Static_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector2>.NativeClassPtr, 100666291);
			Vector2.NativeMethodInfoPtr_get_positiveInfinity_Public_Static_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector2>.NativeClassPtr, 100666292);
			Vector2.NativeMethodInfoPtr_get_negativeInfinity_Public_Static_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector2>.NativeClassPtr, 100666293);
		}

		// Token: 0x17000450 RID: 1104
		public unsafe float this[int index]
		{
			[CallerCount(43)]
			[CachedScanResults(RefRangeStart = 659584, RefRangeEnd = 659627, XrefRangeStart = 659584, XrefRangeEnd = 659584, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref index;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector2.NativeMethodInfoPtr_get_Item_Public_get_Single_Int32_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}
			[CallerCount(16)]
			[CachedScanResults(RefRangeStart = 659627, RefRangeEnd = 659643, XrefRangeStart = 659627, XrefRangeEnd = 659627, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector2.NativeMethodInfoPtr_set_Item_Public_set_Void_Int32_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060014EF RID: 5359 RVA: 0x00067AE8 File Offset: 0x00065CE8
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 611799, RefRangeEnd = 611804, XrefRangeStart = 611799, XrefRangeEnd = 611804, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector2(float x, float y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector2.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060014F0 RID: 5360 RVA: 0x00067B28 File Offset: 0x00065D28
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 611799, RefRangeEnd = 611804, XrefRangeStart = 611799, XrefRangeEnd = 611804, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Set(float newX, float newY)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref newX;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref newY;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector2.NativeMethodInfoPtr_Set_Public_Void_Single_Single_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060014F1 RID: 5361 RVA: 0x00067B68 File Offset: 0x00065D68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 659643, XrefRangeEnd = 659644, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector2 Lerp(Vector2 a, Vector2 b, float t)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref t;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector2.NativeMethodInfoPtr_Lerp_Public_Static_Vector2_Vector2_Vector2_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060014F2 RID: 5362 RVA: 0x00067BC4 File Offset: 0x00065DC4
		[CallerCount(0)]
		public unsafe static Vector2 LerpUnclamped(Vector2 a, Vector2 b, float t)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref t;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector2.NativeMethodInfoPtr_LerpUnclamped_Public_Static_Vector2_Vector2_Vector2_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060014F3 RID: 5363 RVA: 0x00067C20 File Offset: 0x00065E20
		[CallerCount(0)]
		public unsafe static Vector2 Scale(Vector2 a, Vector2 b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector2.NativeMethodInfoPtr_Scale_Public_Static_Vector2_Vector2_Vector2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060014F4 RID: 5364 RVA: 0x00067C6C File Offset: 0x00065E6C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 659647, RefRangeEnd = 659649, XrefRangeStart = 659644, XrefRangeEnd = 659647, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Normalize()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector2.NativeMethodInfoPtr_Normalize_Public_Void_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000451 RID: 1105
		// (get) Token: 0x060014F5 RID: 5365 RVA: 0x00067C94 File Offset: 0x00065E94
		public unsafe Vector2 normalized
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 659657, RefRangeEnd = 659659, XrefRangeStart = 659649, XrefRangeEnd = 659657, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector2.NativeMethodInfoPtr_get_normalized_Public_get_Vector2_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060014F6 RID: 5366 RVA: 0x00067CC4 File Offset: 0x00065EC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 659659, XrefRangeEnd = 659660, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector2.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060014F7 RID: 5367 RVA: 0x00067CF0 File Offset: 0x00065EF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 659660, XrefRangeEnd = 659694, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector2.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060014F8 RID: 5368 RVA: 0x00067D40 File Offset: 0x00065F40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 659694, XrefRangeEnd = 659696, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector2.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060014F9 RID: 5369 RVA: 0x00067D70 File Offset: 0x00065F70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 659696, XrefRangeEnd = 659699, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector2.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060014FA RID: 5370 RVA: 0x00067DB4 File Offset: 0x00065FB4
		[CallerCount(0)]
		public unsafe bool Equals(Vector2 other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector2.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Vector2_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060014FB RID: 5371 RVA: 0x00067DF4 File Offset: 0x00065FF4
		[CallerCount(0)]
		public unsafe static float Dot(Vector2 lhs, Vector2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector2.NativeMethodInfoPtr_Dot_Public_Static_Single_Vector2_Vector2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000452 RID: 1106
		// (get) Token: 0x060014FC RID: 5372 RVA: 0x00067E40 File Offset: 0x00066040
		public unsafe float magnitude
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 659699, XrefRangeEnd = 659704, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector2.NativeMethodInfoPtr_get_magnitude_Public_get_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000453 RID: 1107
		// (get) Token: 0x060014FD RID: 5373 RVA: 0x00067E70 File Offset: 0x00066070
		public unsafe float sqrMagnitude
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector2.NativeMethodInfoPtr_get_sqrMagnitude_Public_get_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060014FE RID: 5374 RVA: 0x00067EA0 File Offset: 0x000660A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 659704, XrefRangeEnd = 659713, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float Angle(Vector2 from, Vector2 to)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref from;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref to;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector2.NativeMethodInfoPtr_Angle_Public_Static_Single_Vector2_Vector2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060014FF RID: 5375 RVA: 0x00067EEC File Offset: 0x000660EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 659713, XrefRangeEnd = 659716, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float Distance(Vector2 a, Vector2 b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector2.NativeMethodInfoPtr_Distance_Public_Static_Single_Vector2_Vector2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001500 RID: 5376 RVA: 0x00067F38 File Offset: 0x00066138
		[CallerCount(0)]
		public unsafe static float SqrMagnitude(Vector2 a)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector2.NativeMethodInfoPtr_SqrMagnitude_Public_Static_Single_Vector2_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001501 RID: 5377 RVA: 0x00067F78 File Offset: 0x00066178
		[CallerCount(0)]
		public unsafe float SqrMagnitude()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector2.NativeMethodInfoPtr_SqrMagnitude_Public_Single_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001502 RID: 5378 RVA: 0x00067FA8 File Offset: 0x000661A8
		[CallerCount(0)]
		public unsafe static Vector2 Min(Vector2 lhs, Vector2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector2.NativeMethodInfoPtr_Min_Public_Static_Vector2_Vector2_Vector2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001503 RID: 5379 RVA: 0x00067FF4 File Offset: 0x000661F4
		[CallerCount(0)]
		public unsafe static Vector2 Max(Vector2 lhs, Vector2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector2.NativeMethodInfoPtr_Max_Public_Static_Vector2_Vector2_Vector2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001504 RID: 5380 RVA: 0x00068040 File Offset: 0x00066240
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 659716, XrefRangeEnd = 659719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector2 SmoothDamp(Vector2 current, Vector2 target, ref Vector2 currentVelocity, float smoothTime)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref current;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref target;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &currentVelocity;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref smoothTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector2.NativeMethodInfoPtr_SmoothDamp_Public_Static_Vector2_Vector2_Vector2_byref_Vector2_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001505 RID: 5381 RVA: 0x000680A8 File Offset: 0x000662A8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 659724, RefRangeEnd = 659726, XrefRangeStart = 659719, XrefRangeEnd = 659724, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector2 SmoothDamp(Vector2 current, Vector2 target, ref Vector2 currentVelocity, float smoothTime, float maxSpeed, float deltaTime)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref current;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref target;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &currentVelocity;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref smoothTime;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxSpeed;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref deltaTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector2.NativeMethodInfoPtr_SmoothDamp_Public_Static_Vector2_Vector2_Vector2_byref_Vector2_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001506 RID: 5382 RVA: 0x0006812C File Offset: 0x0006632C
		[CallerCount(0)]
		public unsafe static Vector2 operator +(Vector2 a, Vector2 b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector2.NativeMethodInfoPtr_op_Addition_Public_Static_Vector2_Vector2_Vector2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001507 RID: 5383 RVA: 0x00068178 File Offset: 0x00066378
		[CallerCount(0)]
		public unsafe static Vector2 operator -(Vector2 a, Vector2 b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector2.NativeMethodInfoPtr_op_Subtraction_Public_Static_Vector2_Vector2_Vector2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001508 RID: 5384 RVA: 0x000681C4 File Offset: 0x000663C4
		[CallerCount(0)]
		public unsafe static Vector2 operator *(Vector2 a, Vector2 b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector2.NativeMethodInfoPtr_op_Multiply_Public_Static_Vector2_Vector2_Vector2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001509 RID: 5385 RVA: 0x00068210 File Offset: 0x00066410
		[CallerCount(0)]
		public unsafe static Vector2 operator /(Vector2 a, Vector2 b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector2.NativeMethodInfoPtr_op_Division_Public_Static_Vector2_Vector2_Vector2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600150A RID: 5386 RVA: 0x0006825C File Offset: 0x0006645C
		[CallerCount(0)]
		public unsafe static Vector2 operator -(Vector2 a)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector2.NativeMethodInfoPtr_op_UnaryNegation_Public_Static_Vector2_Vector2_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600150B RID: 5387 RVA: 0x0006829C File Offset: 0x0006649C
		[CallerCount(0)]
		public unsafe static Vector2 operator *(Vector2 a, float d)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref d;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector2.NativeMethodInfoPtr_op_Multiply_Public_Static_Vector2_Vector2_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600150C RID: 5388 RVA: 0x000682E8 File Offset: 0x000664E8
		[CallerCount(0)]
		public unsafe static Vector2 operator *(float d, Vector2 a)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref d;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref a;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector2.NativeMethodInfoPtr_op_Multiply_Public_Static_Vector2_Single_Vector2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600150D RID: 5389 RVA: 0x00068334 File Offset: 0x00066534
		[CallerCount(0)]
		public unsafe static Vector2 operator /(Vector2 a, float d)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref d;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector2.NativeMethodInfoPtr_op_Division_Public_Static_Vector2_Vector2_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600150E RID: 5390 RVA: 0x00068380 File Offset: 0x00066580
		[CallerCount(0)]
		public unsafe static bool operator ==(Vector2 lhs, Vector2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector2.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Vector2_Vector2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600150F RID: 5391 RVA: 0x000683CC File Offset: 0x000665CC
		[CallerCount(0)]
		public unsafe static bool operator !=(Vector2 lhs, Vector2 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector2.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_Vector2_Vector2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001510 RID: 5392 RVA: 0x00068418 File Offset: 0x00066618
		[CallerCount(0)]
		public unsafe static implicit operator Vector2(Vector3 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector2.NativeMethodInfoPtr_op_Implicit_Public_Static_Vector2_Vector3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001511 RID: 5393 RVA: 0x00068458 File Offset: 0x00066658
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 659726, RefRangeEnd = 659739, XrefRangeStart = 659726, XrefRangeEnd = 659726, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator Vector3(Vector2 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector2.NativeMethodInfoPtr_op_Implicit_Public_Static_Vector3_Vector2_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000454 RID: 1108
		// (get) Token: 0x06001512 RID: 5394 RVA: 0x00068498 File Offset: 0x00066698
		public unsafe static Vector2 zero
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 659739, XrefRangeEnd = 659741, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector2.NativeMethodInfoPtr_get_zero_Public_Static_get_Vector2_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000455 RID: 1109
		// (get) Token: 0x06001513 RID: 5395 RVA: 0x000684C8 File Offset: 0x000666C8
		public unsafe static Vector2 one
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 659741, XrefRangeEnd = 659743, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector2.NativeMethodInfoPtr_get_one_Public_Static_get_Vector2_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000456 RID: 1110
		// (get) Token: 0x06001514 RID: 5396 RVA: 0x000684F8 File Offset: 0x000666F8
		public unsafe static Vector2 up
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 659743, XrefRangeEnd = 659745, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector2.NativeMethodInfoPtr_get_up_Public_Static_get_Vector2_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000457 RID: 1111
		// (get) Token: 0x06001515 RID: 5397 RVA: 0x00068528 File Offset: 0x00066728
		public unsafe static Vector2 down
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 659745, XrefRangeEnd = 659747, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector2.NativeMethodInfoPtr_get_down_Public_Static_get_Vector2_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000458 RID: 1112
		// (get) Token: 0x06001516 RID: 5398 RVA: 0x00068558 File Offset: 0x00066758
		public unsafe static Vector2 left
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 659747, XrefRangeEnd = 659749, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector2.NativeMethodInfoPtr_get_left_Public_Static_get_Vector2_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000459 RID: 1113
		// (get) Token: 0x06001517 RID: 5399 RVA: 0x00068588 File Offset: 0x00066788
		public unsafe static Vector2 right
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 659749, XrefRangeEnd = 659751, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector2.NativeMethodInfoPtr_get_right_Public_Static_get_Vector2_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700045A RID: 1114
		// (get) Token: 0x06001518 RID: 5400 RVA: 0x000685B8 File Offset: 0x000667B8
		public unsafe static Vector2 positiveInfinity
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 659751, XrefRangeEnd = 659753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector2.NativeMethodInfoPtr_get_positiveInfinity_Public_Static_get_Vector2_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700045B RID: 1115
		// (get) Token: 0x06001519 RID: 5401 RVA: 0x000685E8 File Offset: 0x000667E8
		public unsafe static Vector2 negativeInfinity
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 659753, XrefRangeEnd = 659755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector2.NativeMethodInfoPtr_get_negativeInfinity_Public_Static_get_Vector2_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600151A RID: 5402 RVA: 0x00008559 File Offset: 0x00006759
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Vector2>.NativeClassPtr, ref this));
		}

		// Token: 0x17000446 RID: 1094
		// (get) Token: 0x0600151B RID: 5403 RVA: 0x00068618 File Offset: 0x00066818
		// (set) Token: 0x0600151C RID: 5404 RVA: 0x0000856B File Offset: 0x0000676B
		public unsafe static Vector2 zeroVector
		{
			get
			{
				Vector2 vector;
				IL2CPP.il2cpp_field_static_get_value(Vector2.NativeFieldInfoPtr_zeroVector, (void*)(&vector));
				return vector;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Vector2.NativeFieldInfoPtr_zeroVector, (void*)(&value));
			}
		}

		// Token: 0x17000447 RID: 1095
		// (get) Token: 0x0600151D RID: 5405 RVA: 0x00068634 File Offset: 0x00066834
		// (set) Token: 0x0600151E RID: 5406 RVA: 0x00008579 File Offset: 0x00006779
		public unsafe static Vector2 oneVector
		{
			get
			{
				Vector2 vector;
				IL2CPP.il2cpp_field_static_get_value(Vector2.NativeFieldInfoPtr_oneVector, (void*)(&vector));
				return vector;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Vector2.NativeFieldInfoPtr_oneVector, (void*)(&value));
			}
		}

		// Token: 0x17000448 RID: 1096
		// (get) Token: 0x0600151F RID: 5407 RVA: 0x00068650 File Offset: 0x00066850
		// (set) Token: 0x06001520 RID: 5408 RVA: 0x00008587 File Offset: 0x00006787
		public unsafe static Vector2 upVector
		{
			get
			{
				Vector2 vector;
				IL2CPP.il2cpp_field_static_get_value(Vector2.NativeFieldInfoPtr_upVector, (void*)(&vector));
				return vector;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Vector2.NativeFieldInfoPtr_upVector, (void*)(&value));
			}
		}

		// Token: 0x17000449 RID: 1097
		// (get) Token: 0x06001521 RID: 5409 RVA: 0x0006866C File Offset: 0x0006686C
		// (set) Token: 0x06001522 RID: 5410 RVA: 0x00008595 File Offset: 0x00006795
		public unsafe static Vector2 downVector
		{
			get
			{
				Vector2 vector;
				IL2CPP.il2cpp_field_static_get_value(Vector2.NativeFieldInfoPtr_downVector, (void*)(&vector));
				return vector;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Vector2.NativeFieldInfoPtr_downVector, (void*)(&value));
			}
		}

		// Token: 0x1700044A RID: 1098
		// (get) Token: 0x06001523 RID: 5411 RVA: 0x00068688 File Offset: 0x00066888
		// (set) Token: 0x06001524 RID: 5412 RVA: 0x000085A3 File Offset: 0x000067A3
		public unsafe static Vector2 leftVector
		{
			get
			{
				Vector2 vector;
				IL2CPP.il2cpp_field_static_get_value(Vector2.NativeFieldInfoPtr_leftVector, (void*)(&vector));
				return vector;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Vector2.NativeFieldInfoPtr_leftVector, (void*)(&value));
			}
		}

		// Token: 0x1700044B RID: 1099
		// (get) Token: 0x06001525 RID: 5413 RVA: 0x000686A4 File Offset: 0x000668A4
		// (set) Token: 0x06001526 RID: 5414 RVA: 0x000085B1 File Offset: 0x000067B1
		public unsafe static Vector2 rightVector
		{
			get
			{
				Vector2 vector;
				IL2CPP.il2cpp_field_static_get_value(Vector2.NativeFieldInfoPtr_rightVector, (void*)(&vector));
				return vector;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Vector2.NativeFieldInfoPtr_rightVector, (void*)(&value));
			}
		}

		// Token: 0x1700044C RID: 1100
		// (get) Token: 0x06001527 RID: 5415 RVA: 0x000686C0 File Offset: 0x000668C0
		// (set) Token: 0x06001528 RID: 5416 RVA: 0x000085BF File Offset: 0x000067BF
		public unsafe static Vector2 positiveInfinityVector
		{
			get
			{
				Vector2 vector;
				IL2CPP.il2cpp_field_static_get_value(Vector2.NativeFieldInfoPtr_positiveInfinityVector, (void*)(&vector));
				return vector;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Vector2.NativeFieldInfoPtr_positiveInfinityVector, (void*)(&value));
			}
		}

		// Token: 0x1700044D RID: 1101
		// (get) Token: 0x06001529 RID: 5417 RVA: 0x000686DC File Offset: 0x000668DC
		// (set) Token: 0x0600152A RID: 5418 RVA: 0x000085CD File Offset: 0x000067CD
		public unsafe static Vector2 negativeInfinityVector
		{
			get
			{
				Vector2 vector;
				IL2CPP.il2cpp_field_static_get_value(Vector2.NativeFieldInfoPtr_negativeInfinityVector, (void*)(&vector));
				return vector;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Vector2.NativeFieldInfoPtr_negativeInfinityVector, (void*)(&value));
			}
		}

		// Token: 0x1700044E RID: 1102
		// (get) Token: 0x0600152B RID: 5419 RVA: 0x000686F8 File Offset: 0x000668F8
		// (set) Token: 0x0600152C RID: 5420 RVA: 0x000085DB File Offset: 0x000067DB
		public unsafe static float kEpsilon
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(Vector2.NativeFieldInfoPtr_kEpsilon, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Vector2.NativeFieldInfoPtr_kEpsilon, (void*)(&value));
			}
		}

		// Token: 0x1700044F RID: 1103
		// (get) Token: 0x0600152D RID: 5421 RVA: 0x00068714 File Offset: 0x00066914
		// (set) Token: 0x0600152E RID: 5422 RVA: 0x000085E9 File Offset: 0x000067E9
		public unsafe static float kEpsilonNormalSqrt
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(Vector2.NativeFieldInfoPtr_kEpsilonNormalSqrt, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Vector2.NativeFieldInfoPtr_kEpsilonNormalSqrt, (void*)(&value));
			}
		}

		// Token: 0x0600152F RID: 5423 RVA: 0x00068730 File Offset: 0x00066930
		public static Vector2 MoveTowards(Vector2 current, Vector2 target, float maxDistanceDelta)
		{
			float num = target.x - current.x;
			float num2 = target.y - current.y;
			float num3 = num * num + num2 * num2;
			bool flag = num3 == 0f || (maxDistanceDelta >= 0f && num3 <= maxDistanceDelta * maxDistanceDelta);
			Vector2 vector;
			if (flag)
			{
				vector = target;
			}
			else
			{
				float num4 = (float)Math.Sqrt((double)num3);
				vector = new Vector2(current.x + num / num4 * maxDistanceDelta, current.y + num2 / num4 * maxDistanceDelta);
			}
			return vector;
		}

		// Token: 0x06001530 RID: 5424 RVA: 0x000085F7 File Offset: 0x000067F7
		public void Scale(Vector2 scale)
		{
			this.x *= scale.x;
			this.y *= scale.y;
		}

		// Token: 0x06001531 RID: 5425 RVA: 0x000687B8 File Offset: 0x000669B8
		public string ToString(string format)
		{
			return this.ToString(format, null);
		}

		// Token: 0x06001532 RID: 5426 RVA: 0x000687D4 File Offset: 0x000669D4
		public static Vector2 Reflect(Vector2 inDirection, Vector2 inNormal)
		{
			float num = -2f * Vector2.Dot(inNormal, inDirection);
			return new Vector2(num * inNormal.x + inDirection.x, num * inNormal.y + inDirection.y);
		}

		// Token: 0x06001533 RID: 5427 RVA: 0x00068818 File Offset: 0x00066A18
		public static Vector2 Perpendicular(Vector2 inDirection)
		{
			return new Vector2(-inDirection.y, inDirection.x);
		}

		// Token: 0x06001534 RID: 5428 RVA: 0x0006883C File Offset: 0x00066A3C
		public static float SignedAngle(Vector2 from, Vector2 to)
		{
			float num = Vector2.Angle(from, to);
			float num2 = Mathf.Sign(from.x * to.y - from.y * to.x);
			return num * num2;
		}

		// Token: 0x06001535 RID: 5429 RVA: 0x0006887C File Offset: 0x00066A7C
		public static Vector2 ClampMagnitude(Vector2 vector, float maxLength)
		{
			float sqrMagnitude = vector.sqrMagnitude;
			bool flag = sqrMagnitude > maxLength * maxLength;
			Vector2 vector2;
			if (flag)
			{
				float num = (float)Math.Sqrt((double)sqrMagnitude);
				float num2 = vector.x / num;
				float num3 = vector.y / num;
				vector2 = new Vector2(num2 * maxLength, num3 * maxLength);
			}
			else
			{
				vector2 = vector;
			}
			return vector2;
		}

		// Token: 0x06001536 RID: 5430 RVA: 0x000688D0 File Offset: 0x00066AD0
		public static Vector2 SmoothDamp(Vector2 current, Vector2 target, ref Vector2 currentVelocity, float smoothTime, float maxSpeed)
		{
			float deltaTime = Time.deltaTime;
			return Vector2.SmoothDamp(current, target, ref currentVelocity, smoothTime, maxSpeed, deltaTime);
		}

		// Token: 0x040013BF RID: 5055
		private static readonly IntPtr NativeFieldInfoPtr_x;

		// Token: 0x040013C0 RID: 5056
		private static readonly IntPtr NativeFieldInfoPtr_y;

		// Token: 0x040013C1 RID: 5057
		private static readonly IntPtr NativeFieldInfoPtr_zeroVector;

		// Token: 0x040013C2 RID: 5058
		private static readonly IntPtr NativeFieldInfoPtr_oneVector;

		// Token: 0x040013C3 RID: 5059
		private static readonly IntPtr NativeFieldInfoPtr_upVector;

		// Token: 0x040013C4 RID: 5060
		private static readonly IntPtr NativeFieldInfoPtr_downVector;

		// Token: 0x040013C5 RID: 5061
		private static readonly IntPtr NativeFieldInfoPtr_leftVector;

		// Token: 0x040013C6 RID: 5062
		private static readonly IntPtr NativeFieldInfoPtr_rightVector;

		// Token: 0x040013C7 RID: 5063
		private static readonly IntPtr NativeFieldInfoPtr_positiveInfinityVector;

		// Token: 0x040013C8 RID: 5064
		private static readonly IntPtr NativeFieldInfoPtr_negativeInfinityVector;

		// Token: 0x040013C9 RID: 5065
		private static readonly IntPtr NativeFieldInfoPtr_kEpsilon;

		// Token: 0x040013CA RID: 5066
		private static readonly IntPtr NativeFieldInfoPtr_kEpsilonNormalSqrt;

		// Token: 0x040013CB RID: 5067
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_get_Single_Int32_0;

		// Token: 0x040013CC RID: 5068
		private static readonly IntPtr NativeMethodInfoPtr_set_Item_Public_set_Void_Int32_Single_0;

		// Token: 0x040013CD RID: 5069
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_Single_0;

		// Token: 0x040013CE RID: 5070
		private static readonly IntPtr NativeMethodInfoPtr_Set_Public_Void_Single_Single_0;

		// Token: 0x040013CF RID: 5071
		private static readonly IntPtr NativeMethodInfoPtr_Lerp_Public_Static_Vector2_Vector2_Vector2_Single_0;

		// Token: 0x040013D0 RID: 5072
		private static readonly IntPtr NativeMethodInfoPtr_LerpUnclamped_Public_Static_Vector2_Vector2_Vector2_Single_0;

		// Token: 0x040013D1 RID: 5073
		private static readonly IntPtr NativeMethodInfoPtr_Scale_Public_Static_Vector2_Vector2_Vector2_0;

		// Token: 0x040013D2 RID: 5074
		private static readonly IntPtr NativeMethodInfoPtr_Normalize_Public_Void_0;

		// Token: 0x040013D3 RID: 5075
		private static readonly IntPtr NativeMethodInfoPtr_get_normalized_Public_get_Vector2_0;

		// Token: 0x040013D4 RID: 5076
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x040013D5 RID: 5077
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0;

		// Token: 0x040013D6 RID: 5078
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x040013D7 RID: 5079
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x040013D8 RID: 5080
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Vector2_0;

		// Token: 0x040013D9 RID: 5081
		private static readonly IntPtr NativeMethodInfoPtr_Dot_Public_Static_Single_Vector2_Vector2_0;

		// Token: 0x040013DA RID: 5082
		private static readonly IntPtr NativeMethodInfoPtr_get_magnitude_Public_get_Single_0;

		// Token: 0x040013DB RID: 5083
		private static readonly IntPtr NativeMethodInfoPtr_get_sqrMagnitude_Public_get_Single_0;

		// Token: 0x040013DC RID: 5084
		private static readonly IntPtr NativeMethodInfoPtr_Angle_Public_Static_Single_Vector2_Vector2_0;

		// Token: 0x040013DD RID: 5085
		private static readonly IntPtr NativeMethodInfoPtr_Distance_Public_Static_Single_Vector2_Vector2_0;

		// Token: 0x040013DE RID: 5086
		private static readonly IntPtr NativeMethodInfoPtr_SqrMagnitude_Public_Static_Single_Vector2_0;

		// Token: 0x040013DF RID: 5087
		private static readonly IntPtr NativeMethodInfoPtr_SqrMagnitude_Public_Single_0;

		// Token: 0x040013E0 RID: 5088
		private static readonly IntPtr NativeMethodInfoPtr_Min_Public_Static_Vector2_Vector2_Vector2_0;

		// Token: 0x040013E1 RID: 5089
		private static readonly IntPtr NativeMethodInfoPtr_Max_Public_Static_Vector2_Vector2_Vector2_0;

		// Token: 0x040013E2 RID: 5090
		private static readonly IntPtr NativeMethodInfoPtr_SmoothDamp_Public_Static_Vector2_Vector2_Vector2_byref_Vector2_Single_0;

		// Token: 0x040013E3 RID: 5091
		private static readonly IntPtr NativeMethodInfoPtr_SmoothDamp_Public_Static_Vector2_Vector2_Vector2_byref_Vector2_Single_Single_Single_0;

		// Token: 0x040013E4 RID: 5092
		private static readonly IntPtr NativeMethodInfoPtr_op_Addition_Public_Static_Vector2_Vector2_Vector2_0;

		// Token: 0x040013E5 RID: 5093
		private static readonly IntPtr NativeMethodInfoPtr_op_Subtraction_Public_Static_Vector2_Vector2_Vector2_0;

		// Token: 0x040013E6 RID: 5094
		private static readonly IntPtr NativeMethodInfoPtr_op_Multiply_Public_Static_Vector2_Vector2_Vector2_0;

		// Token: 0x040013E7 RID: 5095
		private static readonly IntPtr NativeMethodInfoPtr_op_Division_Public_Static_Vector2_Vector2_Vector2_0;

		// Token: 0x040013E8 RID: 5096
		private static readonly IntPtr NativeMethodInfoPtr_op_UnaryNegation_Public_Static_Vector2_Vector2_0;

		// Token: 0x040013E9 RID: 5097
		private static readonly IntPtr NativeMethodInfoPtr_op_Multiply_Public_Static_Vector2_Vector2_Single_0;

		// Token: 0x040013EA RID: 5098
		private static readonly IntPtr NativeMethodInfoPtr_op_Multiply_Public_Static_Vector2_Single_Vector2_0;

		// Token: 0x040013EB RID: 5099
		private static readonly IntPtr NativeMethodInfoPtr_op_Division_Public_Static_Vector2_Vector2_Single_0;

		// Token: 0x040013EC RID: 5100
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Vector2_Vector2_0;

		// Token: 0x040013ED RID: 5101
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_Vector2_Vector2_0;

		// Token: 0x040013EE RID: 5102
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_Vector2_Vector3_0;

		// Token: 0x040013EF RID: 5103
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_Vector3_Vector2_0;

		// Token: 0x040013F0 RID: 5104
		private static readonly IntPtr NativeMethodInfoPtr_get_zero_Public_Static_get_Vector2_0;

		// Token: 0x040013F1 RID: 5105
		private static readonly IntPtr NativeMethodInfoPtr_get_one_Public_Static_get_Vector2_0;

		// Token: 0x040013F2 RID: 5106
		private static readonly IntPtr NativeMethodInfoPtr_get_up_Public_Static_get_Vector2_0;

		// Token: 0x040013F3 RID: 5107
		private static readonly IntPtr NativeMethodInfoPtr_get_down_Public_Static_get_Vector2_0;

		// Token: 0x040013F4 RID: 5108
		private static readonly IntPtr NativeMethodInfoPtr_get_left_Public_Static_get_Vector2_0;

		// Token: 0x040013F5 RID: 5109
		private static readonly IntPtr NativeMethodInfoPtr_get_right_Public_Static_get_Vector2_0;

		// Token: 0x040013F6 RID: 5110
		private static readonly IntPtr NativeMethodInfoPtr_get_positiveInfinity_Public_Static_get_Vector2_0;

		// Token: 0x040013F7 RID: 5111
		private static readonly IntPtr NativeMethodInfoPtr_get_negativeInfinity_Public_Static_get_Vector2_0;

		// Token: 0x040013F8 RID: 5112
		[FieldOffset(0)]
		public float x;

		// Token: 0x040013F9 RID: 5113
		[FieldOffset(4)]
		public float y;
	}
}
