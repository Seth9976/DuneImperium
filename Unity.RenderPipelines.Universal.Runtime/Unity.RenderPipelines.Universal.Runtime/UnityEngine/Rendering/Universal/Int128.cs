using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering.Universal
{
	// Token: 0x0200000E RID: 14
	[StructLayout(2)]
	public struct Int128
	{
		// Token: 0x060000BE RID: 190 RVA: 0x00017CD8 File Offset: 0x00015ED8
		// Note: this type is marked as 'beforefieldinit'.
		static Int128()
		{
			Il2CppClassPointerStore<Int128>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal", "Int128");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Int128>.NativeClassPtr);
			Int128.NativeFieldInfoPtr_hi = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Int128>.NativeClassPtr, "hi");
			Int128.NativeFieldInfoPtr_lo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Int128>.NativeClassPtr, "lo");
			Int128.NativeMethodInfoPtr__ctor_Public_Void_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Int128>.NativeClassPtr, 100663403);
			Int128.NativeMethodInfoPtr__ctor_Public_Void_Int64_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Int128>.NativeClassPtr, 100663404);
			Int128.NativeMethodInfoPtr__ctor_Public_Void_Int128_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Int128>.NativeClassPtr, 100663405);
			Int128.NativeMethodInfoPtr_IsNegative_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Int128>.NativeClassPtr, 100663406);
			Int128.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Int128_Int128_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Int128>.NativeClassPtr, 100663407);
			Int128.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_Int128_Int128_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Int128>.NativeClassPtr, 100663408);
			Int128.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Int128>.NativeClassPtr, 100663409);
			Int128.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Int128>.NativeClassPtr, 100663410);
			Int128.NativeMethodInfoPtr_op_GreaterThan_Public_Static_Boolean_Int128_Int128_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Int128>.NativeClassPtr, 100663411);
			Int128.NativeMethodInfoPtr_op_LessThan_Public_Static_Boolean_Int128_Int128_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Int128>.NativeClassPtr, 100663412);
			Int128.NativeMethodInfoPtr_op_Addition_Public_Static_Int128_Int128_Int128_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Int128>.NativeClassPtr, 100663413);
			Int128.NativeMethodInfoPtr_op_Subtraction_Public_Static_Int128_Int128_Int128_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Int128>.NativeClassPtr, 100663414);
			Int128.NativeMethodInfoPtr_op_UnaryNegation_Public_Static_Int128_Int128_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Int128>.NativeClassPtr, 100663415);
			Int128.NativeMethodInfoPtr_op_Explicit_Public_Static_Double_Int128_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Int128>.NativeClassPtr, 100663416);
			Int128.NativeMethodInfoPtr_Int128Mul_Public_Static_Int128_Int64_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Int128>.NativeClassPtr, 100663417);
		}

		// Token: 0x060000BF RID: 191 RVA: 0x00017E5C File Offset: 0x0001605C
		[CallerCount(0)]
		public unsafe Int128(long _lo)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref _lo;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Int128.NativeMethodInfoPtr__ctor_Public_Void_Int64_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000C0 RID: 192 RVA: 0x00017E90 File Offset: 0x00016090
		[CallerCount(0)]
		public unsafe Int128(long _hi, ulong _lo)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref _hi;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _lo;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Int128.NativeMethodInfoPtr__ctor_Public_Void_Int64_UInt64_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000C1 RID: 193 RVA: 0x00017ED0 File Offset: 0x000160D0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 596910, RefRangeEnd = 596911, XrefRangeStart = 596910, XrefRangeEnd = 596911, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Int128(Int128 val)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Int128.NativeMethodInfoPtr__ctor_Public_Void_Int128_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000C2 RID: 194 RVA: 0x00017F04 File Offset: 0x00016104
		[CallerCount(0)]
		public unsafe bool IsNegative()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Int128.NativeMethodInfoPtr_IsNegative_Public_Boolean_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000C3 RID: 195 RVA: 0x00017F34 File Offset: 0x00016134
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 596993, XrefRangeEnd = 596998, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator ==(Int128 val1, Int128 val2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref val2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Int128.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Int128_Int128_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000C4 RID: 196 RVA: 0x00017F80 File Offset: 0x00016180
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 596998, XrefRangeEnd = 597003, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator !=(Int128 val1, Int128 val2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref val2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Int128.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_Int128_Int128_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000C5 RID: 197 RVA: 0x00017FCC File Offset: 0x000161CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 597003, XrefRangeEnd = 597006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Int128.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000C6 RID: 198 RVA: 0x00018010 File Offset: 0x00016210
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 597006, XrefRangeEnd = 597008, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Int128.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000C7 RID: 199 RVA: 0x00018040 File Offset: 0x00016240
		[CallerCount(0)]
		public unsafe static bool operator >(Int128 val1, Int128 val2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref val2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Int128.NativeMethodInfoPtr_op_GreaterThan_Public_Static_Boolean_Int128_Int128_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000C8 RID: 200 RVA: 0x0001808C File Offset: 0x0001628C
		[CallerCount(0)]
		public unsafe static bool operator <(Int128 val1, Int128 val2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref val2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Int128.NativeMethodInfoPtr_op_LessThan_Public_Static_Boolean_Int128_Int128_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000C9 RID: 201 RVA: 0x000180D8 File Offset: 0x000162D8
		[CallerCount(0)]
		public unsafe static Int128 operator +(Int128 lhs, Int128 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Int128.NativeMethodInfoPtr_op_Addition_Public_Static_Int128_Int128_Int128_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000CA RID: 202 RVA: 0x00018124 File Offset: 0x00016324
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 597008, XrefRangeEnd = 597009, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Int128 operator -(Int128 lhs, Int128 rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Int128.NativeMethodInfoPtr_op_Subtraction_Public_Static_Int128_Int128_Int128_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000CB RID: 203 RVA: 0x00018170 File Offset: 0x00016370
		[CallerCount(0)]
		public unsafe static Int128 operator -(Int128 val)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Int128.NativeMethodInfoPtr_op_UnaryNegation_Public_Static_Int128_Int128_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000CC RID: 204 RVA: 0x000181B0 File Offset: 0x000163B0
		[CallerCount(0)]
		public unsafe static explicit operator double(Int128 val)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Int128.NativeMethodInfoPtr_op_Explicit_Public_Static_Double_Int128_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000CD RID: 205 RVA: 0x000181F0 File Offset: 0x000163F0
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 597010, RefRangeEnd = 597018, XrefRangeStart = 597009, XrefRangeEnd = 597010, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Int128 Int128Mul(long lhs, long rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Int128.NativeMethodInfoPtr_Int128Mul_Public_Static_Int128_Int64_Int64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000CE RID: 206 RVA: 0x0000258B File Offset: 0x0000078B
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Int128>.NativeClassPtr, ref this));
		}

		// Token: 0x04000088 RID: 136
		private static readonly IntPtr NativeFieldInfoPtr_hi;

		// Token: 0x04000089 RID: 137
		private static readonly IntPtr NativeFieldInfoPtr_lo;

		// Token: 0x0400008A RID: 138
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int64_0;

		// Token: 0x0400008B RID: 139
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int64_UInt64_0;

		// Token: 0x0400008C RID: 140
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int128_0;

		// Token: 0x0400008D RID: 141
		private static readonly IntPtr NativeMethodInfoPtr_IsNegative_Public_Boolean_0;

		// Token: 0x0400008E RID: 142
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Int128_Int128_0;

		// Token: 0x0400008F RID: 143
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_Int128_Int128_0;

		// Token: 0x04000090 RID: 144
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04000091 RID: 145
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04000092 RID: 146
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThan_Public_Static_Boolean_Int128_Int128_0;

		// Token: 0x04000093 RID: 147
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThan_Public_Static_Boolean_Int128_Int128_0;

		// Token: 0x04000094 RID: 148
		private static readonly IntPtr NativeMethodInfoPtr_op_Addition_Public_Static_Int128_Int128_Int128_0;

		// Token: 0x04000095 RID: 149
		private static readonly IntPtr NativeMethodInfoPtr_op_Subtraction_Public_Static_Int128_Int128_Int128_0;

		// Token: 0x04000096 RID: 150
		private static readonly IntPtr NativeMethodInfoPtr_op_UnaryNegation_Public_Static_Int128_Int128_0;

		// Token: 0x04000097 RID: 151
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_Double_Int128_0;

		// Token: 0x04000098 RID: 152
		private static readonly IntPtr NativeMethodInfoPtr_Int128Mul_Public_Static_Int128_Int64_Int64_0;

		// Token: 0x04000099 RID: 153
		[FieldOffset(0)]
		public long hi;

		// Token: 0x0400009A RID: 154
		[FieldOffset(8)]
		public ulong lo;
	}
}
