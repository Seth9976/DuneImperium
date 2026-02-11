using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;

namespace Il2CppSystem.Numerics
{
	// Token: 0x02000007 RID: 7
	public static class NumericsHelpers : Object
	{
		// Token: 0x0600008B RID: 139 RVA: 0x000052F8 File Offset: 0x000034F8
		// Note: this type is marked as 'beforefieldinit'.
		static NumericsHelpers()
		{
			Il2CppClassPointerStore<NumericsHelpers>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Numerics.dll", "System.Numerics", "NumericsHelpers");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NumericsHelpers>.NativeClassPtr);
			NumericsHelpers.NativeMethodInfoPtr_GetDoubleParts_Public_Static_Void_Double_byref_Int32_byref_Int32_byref_UInt64_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumericsHelpers>.NativeClassPtr, 100663405);
			NumericsHelpers.NativeMethodInfoPtr_GetDoubleFromParts_Public_Static_Double_Int32_Int32_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumericsHelpers>.NativeClassPtr, 100663406);
			NumericsHelpers.NativeMethodInfoPtr_DangerousMakeTwosComplement_Public_Static_Void_Il2CppStructArray_1_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumericsHelpers>.NativeClassPtr, 100663407);
			NumericsHelpers.NativeMethodInfoPtr_MakeUlong_Public_Static_UInt64_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumericsHelpers>.NativeClassPtr, 100663408);
			NumericsHelpers.NativeMethodInfoPtr_Abs_Public_Static_UInt32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumericsHelpers>.NativeClassPtr, 100663409);
			NumericsHelpers.NativeMethodInfoPtr_CombineHash_Public_Static_UInt32_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumericsHelpers>.NativeClassPtr, 100663410);
			NumericsHelpers.NativeMethodInfoPtr_CombineHash_Public_Static_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumericsHelpers>.NativeClassPtr, 100663411);
			NumericsHelpers.NativeMethodInfoPtr_CbitHighZero_Public_Static_Int32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumericsHelpers>.NativeClassPtr, 100663412);
			NumericsHelpers.NativeMethodInfoPtr_CbitHighZero_Public_Static_Int32_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumericsHelpers>.NativeClassPtr, 100663413);
		}

		// Token: 0x0600008C RID: 140 RVA: 0x000053DC File Offset: 0x000035DC
		[CallerCount(0)]
		public unsafe static void GetDoubleParts(double dbl, out int sign, out int exp, out ulong man, out bool fFinite)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref dbl;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &sign;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &exp;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &man;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &fFinite;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumericsHelpers.NativeMethodInfoPtr_GetDoubleParts_Public_Static_Void_Double_byref_Int32_byref_Int32_byref_UInt64_byref_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600008D RID: 141 RVA: 0x00005448 File Offset: 0x00003648
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1236284, RefRangeEnd = 1236286, XrefRangeStart = 1236278, XrefRangeEnd = 1236284, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static double GetDoubleFromParts(int sign, int exp, ulong man)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref sign;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref exp;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref man;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumericsHelpers.NativeMethodInfoPtr_GetDoubleFromParts_Public_Static_Double_Int32_Int32_UInt64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600008E RID: 142 RVA: 0x000054A4 File Offset: 0x000036A4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1236288, RefRangeEnd = 1236289, XrefRangeStart = 1236286, XrefRangeEnd = 1236288, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DangerousMakeTwosComplement(Il2CppStructArray<uint> d)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(d);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumericsHelpers.NativeMethodInfoPtr_DangerousMakeTwosComplement_Public_Static_Void_Il2CppStructArray_1_UInt32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600008F RID: 143 RVA: 0x000054DC File Offset: 0x000036DC
		[CallerCount(0)]
		public unsafe static ulong MakeUlong(uint uHi, uint uLo)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref uHi;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref uLo;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumericsHelpers.NativeMethodInfoPtr_MakeUlong_Public_Static_UInt64_UInt32_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000090 RID: 144 RVA: 0x00005528 File Offset: 0x00003728
		[CallerCount(0)]
		public unsafe static uint Abs(int a)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumericsHelpers.NativeMethodInfoPtr_Abs_Public_Static_UInt32_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000091 RID: 145 RVA: 0x00005568 File Offset: 0x00003768
		[CallerCount(0)]
		public unsafe static uint CombineHash(uint u1, uint u2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref u1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref u2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumericsHelpers.NativeMethodInfoPtr_CombineHash_Public_Static_UInt32_UInt32_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000092 RID: 146 RVA: 0x000055B4 File Offset: 0x000037B4
		[CallerCount(0)]
		public unsafe static int CombineHash(int n1, int n2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref n1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref n2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumericsHelpers.NativeMethodInfoPtr_CombineHash_Public_Static_Int32_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000093 RID: 147 RVA: 0x00005600 File Offset: 0x00003800
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1235908, RefRangeEnd = 1235911, XrefRangeStart = 1235908, XrefRangeEnd = 1235911, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int CbitHighZero(uint u)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref u;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumericsHelpers.NativeMethodInfoPtr_CbitHighZero_Public_Static_Int32_UInt32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000094 RID: 148 RVA: 0x00005640 File Offset: 0x00003840
		[CallerCount(0)]
		public unsafe static int CbitHighZero(ulong uu)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref uu;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumericsHelpers.NativeMethodInfoPtr_CbitHighZero_Public_Static_Int32_UInt64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000095 RID: 149 RVA: 0x000021B1 File Offset: 0x000003B1
		public NumericsHelpers(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000079 RID: 121
		private static readonly IntPtr NativeMethodInfoPtr_GetDoubleParts_Public_Static_Void_Double_byref_Int32_byref_Int32_byref_UInt64_byref_Boolean_0;

		// Token: 0x0400007A RID: 122
		private static readonly IntPtr NativeMethodInfoPtr_GetDoubleFromParts_Public_Static_Double_Int32_Int32_UInt64_0;

		// Token: 0x0400007B RID: 123
		private static readonly IntPtr NativeMethodInfoPtr_DangerousMakeTwosComplement_Public_Static_Void_Il2CppStructArray_1_UInt32_0;

		// Token: 0x0400007C RID: 124
		private static readonly IntPtr NativeMethodInfoPtr_MakeUlong_Public_Static_UInt64_UInt32_UInt32_0;

		// Token: 0x0400007D RID: 125
		private static readonly IntPtr NativeMethodInfoPtr_Abs_Public_Static_UInt32_Int32_0;

		// Token: 0x0400007E RID: 126
		private static readonly IntPtr NativeMethodInfoPtr_CombineHash_Public_Static_UInt32_UInt32_UInt32_0;

		// Token: 0x0400007F RID: 127
		private static readonly IntPtr NativeMethodInfoPtr_CombineHash_Public_Static_Int32_Int32_Int32_0;

		// Token: 0x04000080 RID: 128
		private static readonly IntPtr NativeMethodInfoPtr_CbitHighZero_Public_Static_Int32_UInt32_0;

		// Token: 0x04000081 RID: 129
		private static readonly IntPtr NativeMethodInfoPtr_CbitHighZero_Public_Static_Int32_UInt64_0;
	}
}
