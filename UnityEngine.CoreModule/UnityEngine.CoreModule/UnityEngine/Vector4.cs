using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x02000104 RID: 260
	[StructLayout(2)]
	public struct Vector4
	{
		// Token: 0x060015AF RID: 5551 RVA: 0x0006A1AC File Offset: 0x000683AC
		// Note: this type is marked as 'beforefieldinit'.
		static Vector4()
		{
			Il2CppClassPointerStore<Vector4>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "Vector4");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Vector4>.NativeClassPtr);
			Vector4.NativeFieldInfoPtr_kEpsilon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vector4>.NativeClassPtr, "kEpsilon");
			Vector4.NativeFieldInfoPtr_x = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vector4>.NativeClassPtr, "x");
			Vector4.NativeFieldInfoPtr_y = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vector4>.NativeClassPtr, "y");
			Vector4.NativeFieldInfoPtr_z = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vector4>.NativeClassPtr, "z");
			Vector4.NativeFieldInfoPtr_w = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vector4>.NativeClassPtr, "w");
			Vector4.NativeFieldInfoPtr_zeroVector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vector4>.NativeClassPtr, "zeroVector");
			Vector4.NativeFieldInfoPtr_oneVector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vector4>.NativeClassPtr, "oneVector");
			Vector4.NativeFieldInfoPtr_positiveInfinityVector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vector4>.NativeClassPtr, "positiveInfinityVector");
			Vector4.NativeFieldInfoPtr_negativeInfinityVector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vector4>.NativeClassPtr, "negativeInfinityVector");
			Vector4.NativeMethodInfoPtr_get_Item_Public_get_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector4>.NativeClassPtr, 100666338);
			Vector4.NativeMethodInfoPtr_set_Item_Public_set_Void_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector4>.NativeClassPtr, 100666339);
			Vector4.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector4>.NativeClassPtr, 100666340);
			Vector4.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector4>.NativeClassPtr, 100666341);
			Vector4.NativeMethodInfoPtr_Set_Public_Void_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector4>.NativeClassPtr, 100666342);
			Vector4.NativeMethodInfoPtr_Scale_Public_Void_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector4>.NativeClassPtr, 100666343);
			Vector4.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector4>.NativeClassPtr, 100666344);
			Vector4.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector4>.NativeClassPtr, 100666345);
			Vector4.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector4>.NativeClassPtr, 100666346);
			Vector4.NativeMethodInfoPtr_Normalize_Public_Static_Vector4_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector4>.NativeClassPtr, 100666347);
			Vector4.NativeMethodInfoPtr_get_normalized_Public_get_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector4>.NativeClassPtr, 100666348);
			Vector4.NativeMethodInfoPtr_Dot_Public_Static_Single_Vector4_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector4>.NativeClassPtr, 100666349);
			Vector4.NativeMethodInfoPtr_Magnitude_Public_Static_Single_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector4>.NativeClassPtr, 100666350);
			Vector4.NativeMethodInfoPtr_get_magnitude_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector4>.NativeClassPtr, 100666351);
			Vector4.NativeMethodInfoPtr_get_sqrMagnitude_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector4>.NativeClassPtr, 100666352);
			Vector4.NativeMethodInfoPtr_get_zero_Public_Static_get_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector4>.NativeClassPtr, 100666353);
			Vector4.NativeMethodInfoPtr_get_one_Public_Static_get_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector4>.NativeClassPtr, 100666354);
			Vector4.NativeMethodInfoPtr_op_Addition_Public_Static_Vector4_Vector4_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector4>.NativeClassPtr, 100666355);
			Vector4.NativeMethodInfoPtr_op_Subtraction_Public_Static_Vector4_Vector4_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector4>.NativeClassPtr, 100666356);
			Vector4.NativeMethodInfoPtr_op_UnaryNegation_Public_Static_Vector4_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector4>.NativeClassPtr, 100666357);
			Vector4.NativeMethodInfoPtr_op_Multiply_Public_Static_Vector4_Vector4_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector4>.NativeClassPtr, 100666358);
			Vector4.NativeMethodInfoPtr_op_Multiply_Public_Static_Vector4_Single_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector4>.NativeClassPtr, 100666359);
			Vector4.NativeMethodInfoPtr_op_Division_Public_Static_Vector4_Vector4_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector4>.NativeClassPtr, 100666360);
			Vector4.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Vector4_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector4>.NativeClassPtr, 100666361);
			Vector4.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_Vector4_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector4>.NativeClassPtr, 100666362);
			Vector4.NativeMethodInfoPtr_op_Implicit_Public_Static_Vector4_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector4>.NativeClassPtr, 100666363);
			Vector4.NativeMethodInfoPtr_op_Implicit_Public_Static_Vector3_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector4>.NativeClassPtr, 100666364);
			Vector4.NativeMethodInfoPtr_op_Implicit_Public_Static_Vector4_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector4>.NativeClassPtr, 100666365);
			Vector4.NativeMethodInfoPtr_op_Implicit_Public_Static_Vector2_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector4>.NativeClassPtr, 100666366);
			Vector4.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector4>.NativeClassPtr, 100666367);
			Vector4.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector4>.NativeClassPtr, 100666368);
		}

		// Token: 0x17000488 RID: 1160
		public unsafe float this[int index]
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 659828, RefRangeEnd = 659843, XrefRangeStart = 659828, XrefRangeEnd = 659828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref index;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector4.NativeMethodInfoPtr_get_Item_Public_get_Single_Int32_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 659843, RefRangeEnd = 659847, XrefRangeStart = 659843, XrefRangeEnd = 659843, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector4.NativeMethodInfoPtr_set_Item_Public_set_Void_Int32_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060015B2 RID: 5554 RVA: 0x0006A57C File Offset: 0x0006877C
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 323501, RefRangeEnd = 323508, XrefRangeStart = 323501, XrefRangeEnd = 323508, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector4(float x, float y, float z, float w)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref z;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref w;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector4.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_Single_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060015B3 RID: 5555 RVA: 0x0006A5D8 File Offset: 0x000687D8
		[CallerCount(0)]
		public unsafe Vector4(float x, float y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector4.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060015B4 RID: 5556 RVA: 0x0006A618 File Offset: 0x00068818
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 323501, RefRangeEnd = 323508, XrefRangeStart = 323501, XrefRangeEnd = 323508, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Set(float newX, float newY, float newZ, float newW)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref newX;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref newY;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref newZ;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref newW;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector4.NativeMethodInfoPtr_Set_Public_Void_Single_Single_Single_Single_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060015B5 RID: 5557 RVA: 0x0006A674 File Offset: 0x00068874
		[CallerCount(0)]
		public unsafe void Scale(Vector4 scale)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref scale;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector4.NativeMethodInfoPtr_Scale_Public_Void_Vector4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060015B6 RID: 5558 RVA: 0x0006A6A8 File Offset: 0x000688A8
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 659210, RefRangeEnd = 659218, XrefRangeStart = 659210, XrefRangeEnd = 659218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector4.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060015B7 RID: 5559 RVA: 0x0006A6D8 File Offset: 0x000688D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 659847, XrefRangeEnd = 659850, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector4.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060015B8 RID: 5560 RVA: 0x0006A71C File Offset: 0x0006891C
		[CallerCount(0)]
		public unsafe bool Equals(Vector4 other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector4.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Vector4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060015B9 RID: 5561 RVA: 0x0006A75C File Offset: 0x0006895C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 659850, XrefRangeEnd = 659853, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector4 Normalize(Vector4 a)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector4.NativeMethodInfoPtr_Normalize_Public_Static_Vector4_Vector4_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000489 RID: 1161
		// (get) Token: 0x060015BA RID: 5562 RVA: 0x0006A79C File Offset: 0x0006899C
		public unsafe Vector4 normalized
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 659853, XrefRangeEnd = 659856, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector4.NativeMethodInfoPtr_get_normalized_Public_get_Vector4_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060015BB RID: 5563 RVA: 0x0006A7CC File Offset: 0x000689CC
		[CallerCount(0)]
		public unsafe static float Dot(Vector4 a, Vector4 b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector4.NativeMethodInfoPtr_Dot_Public_Static_Single_Vector4_Vector4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060015BC RID: 5564 RVA: 0x0006A818 File Offset: 0x00068A18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 659856, XrefRangeEnd = 659859, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float Magnitude(Vector4 a)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector4.NativeMethodInfoPtr_Magnitude_Public_Static_Single_Vector4_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700048A RID: 1162
		// (get) Token: 0x060015BD RID: 5565 RVA: 0x0006A858 File Offset: 0x00068A58
		public unsafe float magnitude
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 659859, XrefRangeEnd = 659862, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector4.NativeMethodInfoPtr_get_magnitude_Public_get_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700048B RID: 1163
		// (get) Token: 0x060015BE RID: 5566 RVA: 0x0006A888 File Offset: 0x00068A88
		public unsafe float sqrMagnitude
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector4.NativeMethodInfoPtr_get_sqrMagnitude_Public_get_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700048C RID: 1164
		// (get) Token: 0x060015BF RID: 5567 RVA: 0x0006A8B8 File Offset: 0x00068AB8
		public unsafe static Vector4 zero
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 659862, XrefRangeEnd = 659864, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector4.NativeMethodInfoPtr_get_zero_Public_Static_get_Vector4_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700048D RID: 1165
		// (get) Token: 0x060015C0 RID: 5568 RVA: 0x0006A8E8 File Offset: 0x00068AE8
		public unsafe static Vector4 one
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 659864, XrefRangeEnd = 659866, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector4.NativeMethodInfoPtr_get_one_Public_Static_get_Vector4_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060015C1 RID: 5569 RVA: 0x0006A918 File Offset: 0x00068B18
		[CallerCount(0)]
		public unsafe static Vector4 operator +(Vector4 a, Vector4 b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector4.NativeMethodInfoPtr_op_Addition_Public_Static_Vector4_Vector4_Vector4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060015C2 RID: 5570 RVA: 0x0006A964 File Offset: 0x00068B64
		[CallerCount(0)]
		public unsafe static Vector4 operator -(Vector4 a, Vector4 b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector4.NativeMethodInfoPtr_op_Subtraction_Public_Static_Vector4_Vector4_Vector4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060015C3 RID: 5571 RVA: 0x0006A9B0 File Offset: 0x00068BB0
		[CallerCount(0)]
		public unsafe static Vector4 operator -(Vector4 a)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector4.NativeMethodInfoPtr_op_UnaryNegation_Public_Static_Vector4_Vector4_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060015C4 RID: 5572 RVA: 0x0006A9F0 File Offset: 0x00068BF0
		[CallerCount(0)]
		public unsafe static Vector4 operator *(Vector4 a, float d)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref d;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector4.NativeMethodInfoPtr_op_Multiply_Public_Static_Vector4_Vector4_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060015C5 RID: 5573 RVA: 0x0006AA3C File Offset: 0x00068C3C
		[CallerCount(0)]
		public unsafe static Vector4 operator *(float d, Vector4 a)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref d;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref a;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector4.NativeMethodInfoPtr_op_Multiply_Public_Static_Vector4_Single_Vector4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060015C6 RID: 5574 RVA: 0x0006AA88 File Offset: 0x00068C88
		[CallerCount(0)]
		public unsafe static Vector4 operator /(Vector4 a, float d)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref d;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector4.NativeMethodInfoPtr_op_Division_Public_Static_Vector4_Vector4_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060015C7 RID: 5575 RVA: 0x0006AAD4 File Offset: 0x00068CD4
		[CallerCount(0)]
		public unsafe static bool operator ==(Vector4 lhs, Vector4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector4.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Vector4_Vector4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060015C8 RID: 5576 RVA: 0x0006AB20 File Offset: 0x00068D20
		[CallerCount(0)]
		public unsafe static bool operator !=(Vector4 lhs, Vector4 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector4.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_Vector4_Vector4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060015C9 RID: 5577 RVA: 0x0006AB6C File Offset: 0x00068D6C
		[CallerCount(0)]
		public unsafe static implicit operator Vector4(Vector3 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector4.NativeMethodInfoPtr_op_Implicit_Public_Static_Vector4_Vector3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060015CA RID: 5578 RVA: 0x0006ABAC File Offset: 0x00068DAC
		[CallerCount(0)]
		public unsafe static implicit operator Vector3(Vector4 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector4.NativeMethodInfoPtr_op_Implicit_Public_Static_Vector3_Vector4_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060015CB RID: 5579 RVA: 0x0006ABEC File Offset: 0x00068DEC
		[CallerCount(0)]
		public unsafe static implicit operator Vector4(Vector2 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector4.NativeMethodInfoPtr_op_Implicit_Public_Static_Vector4_Vector2_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060015CC RID: 5580 RVA: 0x0006AC2C File Offset: 0x00068E2C
		[CallerCount(0)]
		public unsafe static implicit operator Vector2(Vector4 v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector4.NativeMethodInfoPtr_op_Implicit_Public_Static_Vector2_Vector4_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060015CD RID: 5581 RVA: 0x0006AC6C File Offset: 0x00068E6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 659866, XrefRangeEnd = 659872, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector4.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060015CE RID: 5582 RVA: 0x0006AC98 File Offset: 0x00068E98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 659872, XrefRangeEnd = 659907, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector4.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060015CF RID: 5583 RVA: 0x00008778 File Offset: 0x00006978
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Vector4>.NativeClassPtr, ref this));
		}

		// Token: 0x17000483 RID: 1155
		// (get) Token: 0x060015D0 RID: 5584 RVA: 0x0006ACE8 File Offset: 0x00068EE8
		// (set) Token: 0x060015D1 RID: 5585 RVA: 0x0000878A File Offset: 0x0000698A
		public unsafe static float kEpsilon
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(Vector4.NativeFieldInfoPtr_kEpsilon, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Vector4.NativeFieldInfoPtr_kEpsilon, (void*)(&value));
			}
		}

		// Token: 0x17000484 RID: 1156
		// (get) Token: 0x060015D2 RID: 5586 RVA: 0x0006AD04 File Offset: 0x00068F04
		// (set) Token: 0x060015D3 RID: 5587 RVA: 0x00008798 File Offset: 0x00006998
		public unsafe static Vector4 zeroVector
		{
			get
			{
				Vector4 vector;
				IL2CPP.il2cpp_field_static_get_value(Vector4.NativeFieldInfoPtr_zeroVector, (void*)(&vector));
				return vector;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Vector4.NativeFieldInfoPtr_zeroVector, (void*)(&value));
			}
		}

		// Token: 0x17000485 RID: 1157
		// (get) Token: 0x060015D4 RID: 5588 RVA: 0x0006AD20 File Offset: 0x00068F20
		// (set) Token: 0x060015D5 RID: 5589 RVA: 0x000087A6 File Offset: 0x000069A6
		public unsafe static Vector4 oneVector
		{
			get
			{
				Vector4 vector;
				IL2CPP.il2cpp_field_static_get_value(Vector4.NativeFieldInfoPtr_oneVector, (void*)(&vector));
				return vector;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Vector4.NativeFieldInfoPtr_oneVector, (void*)(&value));
			}
		}

		// Token: 0x17000486 RID: 1158
		// (get) Token: 0x060015D6 RID: 5590 RVA: 0x0006AD3C File Offset: 0x00068F3C
		// (set) Token: 0x060015D7 RID: 5591 RVA: 0x000087B4 File Offset: 0x000069B4
		public unsafe static Vector4 positiveInfinityVector
		{
			get
			{
				Vector4 vector;
				IL2CPP.il2cpp_field_static_get_value(Vector4.NativeFieldInfoPtr_positiveInfinityVector, (void*)(&vector));
				return vector;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Vector4.NativeFieldInfoPtr_positiveInfinityVector, (void*)(&value));
			}
		}

		// Token: 0x17000487 RID: 1159
		// (get) Token: 0x060015D8 RID: 5592 RVA: 0x0006AD58 File Offset: 0x00068F58
		// (set) Token: 0x060015D9 RID: 5593 RVA: 0x000087C2 File Offset: 0x000069C2
		public unsafe static Vector4 negativeInfinityVector
		{
			get
			{
				Vector4 vector;
				IL2CPP.il2cpp_field_static_get_value(Vector4.NativeFieldInfoPtr_negativeInfinityVector, (void*)(&vector));
				return vector;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Vector4.NativeFieldInfoPtr_negativeInfinityVector, (void*)(&value));
			}
		}

		// Token: 0x060015DA RID: 5594 RVA: 0x0006AD74 File Offset: 0x00068F74
		public static Vector4 Lerp(Vector4 a, Vector4 b, float t)
		{
			t = Mathf.Clamp01(t);
			return new Vector4(a.x + (b.x - a.x) * t, a.y + (b.y - a.y) * t, a.z + (b.z - a.z) * t, a.w + (b.w - a.w) * t);
		}

		// Token: 0x060015DB RID: 5595 RVA: 0x0006ADEC File Offset: 0x00068FEC
		public static Vector4 LerpUnclamped(Vector4 a, Vector4 b, float t)
		{
			return new Vector4(a.x + (b.x - a.x) * t, a.y + (b.y - a.y) * t, a.z + (b.z - a.z) * t, a.w + (b.w - a.w) * t);
		}

		// Token: 0x060015DC RID: 5596 RVA: 0x0006AE5C File Offset: 0x0006905C
		public static Vector4 MoveTowards(Vector4 current, Vector4 target, float maxDistanceDelta)
		{
			float num = target.x - current.x;
			float num2 = target.y - current.y;
			float num3 = target.z - current.z;
			float num4 = target.w - current.w;
			float num5 = num * num + num2 * num2 + num3 * num3 + num4 * num4;
			bool flag = num5 == 0f || (maxDistanceDelta >= 0f && num5 <= maxDistanceDelta * maxDistanceDelta);
			Vector4 vector;
			if (flag)
			{
				vector = target;
			}
			else
			{
				float num6 = (float)Math.Sqrt((double)num5);
				vector = new Vector4(current.x + num / num6 * maxDistanceDelta, current.y + num2 / num6 * maxDistanceDelta, current.z + num3 / num6 * maxDistanceDelta, current.w + num4 / num6 * maxDistanceDelta);
			}
			return vector;
		}

		// Token: 0x060015DD RID: 5597 RVA: 0x0006AF2C File Offset: 0x0006912C
		public static Vector4 Scale(Vector4 a, Vector4 b)
		{
			return new Vector4(a.x * b.x, a.y * b.y, a.z * b.z, a.w * b.w);
		}

		// Token: 0x060015DE RID: 5598 RVA: 0x0006AF78 File Offset: 0x00069178
		public void Normalize()
		{
			float num = Vector4.Magnitude(this);
			bool flag = num > 1E-05f;
			if (flag)
			{
				this /= num;
			}
			else
			{
				this = Vector4.zero;
			}
		}

		// Token: 0x060015DF RID: 5599 RVA: 0x0006AFC0 File Offset: 0x000691C0
		public static Vector4 Project(Vector4 a, Vector4 b)
		{
			return b * (Vector4.Dot(a, b) / Vector4.Dot(b, b));
		}

		// Token: 0x060015E0 RID: 5600 RVA: 0x0006AFE8 File Offset: 0x000691E8
		public static float Distance(Vector4 a, Vector4 b)
		{
			return Vector4.Magnitude(a - b);
		}

		// Token: 0x060015E1 RID: 5601 RVA: 0x0006B008 File Offset: 0x00069208
		public static Vector4 Min(Vector4 lhs, Vector4 rhs)
		{
			return new Vector4(Mathf.Min(lhs.x, rhs.x), Mathf.Min(lhs.y, rhs.y), Mathf.Min(lhs.z, rhs.z), Mathf.Min(lhs.w, rhs.w));
		}

		// Token: 0x060015E2 RID: 5602 RVA: 0x0006B064 File Offset: 0x00069264
		public static Vector4 Max(Vector4 lhs, Vector4 rhs)
		{
			return new Vector4(Mathf.Max(lhs.x, rhs.x), Mathf.Max(lhs.y, rhs.y), Mathf.Max(lhs.z, rhs.z), Mathf.Max(lhs.w, rhs.w));
		}

		// Token: 0x1700048E RID: 1166
		// (get) Token: 0x060015E3 RID: 5603 RVA: 0x0006B0C0 File Offset: 0x000692C0
		public static Vector4 positiveInfinity
		{
			get
			{
				return Vector4.positiveInfinityVector;
			}
		}

		// Token: 0x1700048F RID: 1167
		// (get) Token: 0x060015E4 RID: 5604 RVA: 0x0006B0D8 File Offset: 0x000692D8
		public static Vector4 negativeInfinity
		{
			get
			{
				return Vector4.negativeInfinityVector;
			}
		}

		// Token: 0x060015E5 RID: 5605 RVA: 0x0006B0F0 File Offset: 0x000692F0
		public string ToString(string format)
		{
			return this.ToString(format, null);
		}

		// Token: 0x060015E6 RID: 5606 RVA: 0x0006B10C File Offset: 0x0006930C
		public static float SqrMagnitude(Vector4 a)
		{
			return Vector4.Dot(a, a);
		}

		// Token: 0x060015E7 RID: 5607 RVA: 0x0006B128 File Offset: 0x00069328
		public float SqrMagnitude()
		{
			return Vector4.Dot(this, this);
		}

		// Token: 0x0400143B RID: 5179
		private static readonly IntPtr NativeFieldInfoPtr_kEpsilon;

		// Token: 0x0400143C RID: 5180
		private static readonly IntPtr NativeFieldInfoPtr_x;

		// Token: 0x0400143D RID: 5181
		private static readonly IntPtr NativeFieldInfoPtr_y;

		// Token: 0x0400143E RID: 5182
		private static readonly IntPtr NativeFieldInfoPtr_z;

		// Token: 0x0400143F RID: 5183
		private static readonly IntPtr NativeFieldInfoPtr_w;

		// Token: 0x04001440 RID: 5184
		private static readonly IntPtr NativeFieldInfoPtr_zeroVector;

		// Token: 0x04001441 RID: 5185
		private static readonly IntPtr NativeFieldInfoPtr_oneVector;

		// Token: 0x04001442 RID: 5186
		private static readonly IntPtr NativeFieldInfoPtr_positiveInfinityVector;

		// Token: 0x04001443 RID: 5187
		private static readonly IntPtr NativeFieldInfoPtr_negativeInfinityVector;

		// Token: 0x04001444 RID: 5188
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_get_Single_Int32_0;

		// Token: 0x04001445 RID: 5189
		private static readonly IntPtr NativeMethodInfoPtr_set_Item_Public_set_Void_Int32_Single_0;

		// Token: 0x04001446 RID: 5190
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_Single_0;

		// Token: 0x04001447 RID: 5191
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_Single_0;

		// Token: 0x04001448 RID: 5192
		private static readonly IntPtr NativeMethodInfoPtr_Set_Public_Void_Single_Single_Single_Single_0;

		// Token: 0x04001449 RID: 5193
		private static readonly IntPtr NativeMethodInfoPtr_Scale_Public_Void_Vector4_0;

		// Token: 0x0400144A RID: 5194
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x0400144B RID: 5195
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x0400144C RID: 5196
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Vector4_0;

		// Token: 0x0400144D RID: 5197
		private static readonly IntPtr NativeMethodInfoPtr_Normalize_Public_Static_Vector4_Vector4_0;

		// Token: 0x0400144E RID: 5198
		private static readonly IntPtr NativeMethodInfoPtr_get_normalized_Public_get_Vector4_0;

		// Token: 0x0400144F RID: 5199
		private static readonly IntPtr NativeMethodInfoPtr_Dot_Public_Static_Single_Vector4_Vector4_0;

		// Token: 0x04001450 RID: 5200
		private static readonly IntPtr NativeMethodInfoPtr_Magnitude_Public_Static_Single_Vector4_0;

		// Token: 0x04001451 RID: 5201
		private static readonly IntPtr NativeMethodInfoPtr_get_magnitude_Public_get_Single_0;

		// Token: 0x04001452 RID: 5202
		private static readonly IntPtr NativeMethodInfoPtr_get_sqrMagnitude_Public_get_Single_0;

		// Token: 0x04001453 RID: 5203
		private static readonly IntPtr NativeMethodInfoPtr_get_zero_Public_Static_get_Vector4_0;

		// Token: 0x04001454 RID: 5204
		private static readonly IntPtr NativeMethodInfoPtr_get_one_Public_Static_get_Vector4_0;

		// Token: 0x04001455 RID: 5205
		private static readonly IntPtr NativeMethodInfoPtr_op_Addition_Public_Static_Vector4_Vector4_Vector4_0;

		// Token: 0x04001456 RID: 5206
		private static readonly IntPtr NativeMethodInfoPtr_op_Subtraction_Public_Static_Vector4_Vector4_Vector4_0;

		// Token: 0x04001457 RID: 5207
		private static readonly IntPtr NativeMethodInfoPtr_op_UnaryNegation_Public_Static_Vector4_Vector4_0;

		// Token: 0x04001458 RID: 5208
		private static readonly IntPtr NativeMethodInfoPtr_op_Multiply_Public_Static_Vector4_Vector4_Single_0;

		// Token: 0x04001459 RID: 5209
		private static readonly IntPtr NativeMethodInfoPtr_op_Multiply_Public_Static_Vector4_Single_Vector4_0;

		// Token: 0x0400145A RID: 5210
		private static readonly IntPtr NativeMethodInfoPtr_op_Division_Public_Static_Vector4_Vector4_Single_0;

		// Token: 0x0400145B RID: 5211
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Vector4_Vector4_0;

		// Token: 0x0400145C RID: 5212
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_Vector4_Vector4_0;

		// Token: 0x0400145D RID: 5213
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_Vector4_Vector3_0;

		// Token: 0x0400145E RID: 5214
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_Vector3_Vector4_0;

		// Token: 0x0400145F RID: 5215
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_Vector4_Vector2_0;

		// Token: 0x04001460 RID: 5216
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_Vector2_Vector4_0;

		// Token: 0x04001461 RID: 5217
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04001462 RID: 5218
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0;

		// Token: 0x04001463 RID: 5219
		[FieldOffset(0)]
		public float x;

		// Token: 0x04001464 RID: 5220
		[FieldOffset(4)]
		public float y;

		// Token: 0x04001465 RID: 5221
		[FieldOffset(8)]
		public float z;

		// Token: 0x04001466 RID: 5222
		[FieldOffset(12)]
		public float w;
	}
}
