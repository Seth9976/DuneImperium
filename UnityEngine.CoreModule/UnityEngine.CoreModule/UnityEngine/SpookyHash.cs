using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x020000ED RID: 237
	public static class SpookyHash : Object
	{
		// Token: 0x060012F7 RID: 4855 RVA: 0x0005F148 File Offset: 0x0005D348
		// Note: this type is marked as 'beforefieldinit'.
		static SpookyHash()
		{
			Il2CppClassPointerStore<SpookyHash>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "SpookyHash");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpookyHash>.NativeClassPtr);
			SpookyHash.NativeMethodInfoPtr_Hash_Public_Static_Void_ptr_Void_UInt64_ptr_UInt64_ptr_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpookyHash>.NativeClassPtr, 100665964);
			SpookyHash.NativeMethodInfoPtr_End_Private_Static_Void_ptr_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpookyHash>.NativeClassPtr, 100665965);
			SpookyHash.NativeMethodInfoPtr_EndPartial_Private_Static_Void_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpookyHash>.NativeClassPtr, 100665966);
			SpookyHash.NativeMethodInfoPtr_Rot64_Private_Static_Void_byref_UInt64_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpookyHash>.NativeClassPtr, 100665967);
			SpookyHash.NativeMethodInfoPtr_Short_Private_Static_Void_ptr_Void_UInt64_ptr_UInt64_ptr_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpookyHash>.NativeClassPtr, 100665968);
			SpookyHash.NativeMethodInfoPtr_ShortMix_Private_Static_Void_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpookyHash>.NativeClassPtr, 100665969);
			SpookyHash.NativeMethodInfoPtr_ShortEnd_Private_Static_Void_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpookyHash>.NativeClassPtr, 100665970);
			SpookyHash.NativeMethodInfoPtr_Mix_Private_Static_Void_ptr_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpookyHash>.NativeClassPtr, 100665971);
		}

		// Token: 0x060012F8 RID: 4856 RVA: 0x0005F218 File Offset: 0x0005D418
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 657888, RefRangeEnd = 657891, XrefRangeStart = 657879, XrefRangeEnd = 657888, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Hash(void* message, ulong length, ulong* hash1, ulong* hash2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = message;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = hash1;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = hash2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpookyHash.NativeMethodInfoPtr_Hash_Public_Static_Void_ptr_Void_UInt64_ptr_UInt64_ptr_UInt64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012F9 RID: 4857 RVA: 0x0005F274 File Offset: 0x0005D474
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 657891, XrefRangeEnd = 657894, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void End(ulong* data, ref ulong h0, ref ulong h1, ref ulong h2, ref ulong h3, ref ulong h4, ref ulong h5, ref ulong h6, ref ulong h7, ref ulong h8, ref ulong h9, ref ulong h10, ref ulong h11)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)13) * (UIntPtr)sizeof(IntPtr)];
				*ptr = data;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &h0;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &h1;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &h2;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &h3;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &h4;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &h5;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &h6;
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &h7;
			ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &h8;
			ptr[checked(unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &h9;
			ptr[checked(unchecked((UIntPtr)11) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &h10;
			ptr[checked(unchecked((UIntPtr)12) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &h11;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpookyHash.NativeMethodInfoPtr_End_Private_Static_Void_ptr_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012FA RID: 4858 RVA: 0x0005F35C File Offset: 0x0005D55C
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 657894, RefRangeEnd = 657900, XrefRangeStart = 657894, XrefRangeEnd = 657894, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void EndPartial(ref ulong h0, ref ulong h1, ref ulong h2, ref ulong h3, ref ulong h4, ref ulong h5, ref ulong h6, ref ulong h7, ref ulong h8, ref ulong h9, ref ulong h10, ref ulong h11)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)12) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &h0;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &h1;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &h2;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &h3;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &h4;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &h5;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &h6;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &h7;
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &h8;
			ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &h9;
			ptr[checked(unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &h10;
			ptr[checked(unchecked((UIntPtr)11) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &h11;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpookyHash.NativeMethodInfoPtr_EndPartial_Private_Static_Void_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012FB RID: 4859 RVA: 0x0005F434 File Offset: 0x0005D634
		[CallerCount(0)]
		public unsafe static void Rot64(ref ulong x, int k)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref k;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpookyHash.NativeMethodInfoPtr_Rot64_Private_Static_Void_byref_UInt64_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012FC RID: 4860 RVA: 0x0005F474 File Offset: 0x0005D674
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 657906, RefRangeEnd = 657907, XrefRangeStart = 657900, XrefRangeEnd = 657906, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Short(void* message, ulong length, ulong* hash1, ulong* hash2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = message;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = hash1;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = hash2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpookyHash.NativeMethodInfoPtr_Short_Private_Static_Void_ptr_Void_UInt64_ptr_UInt64_ptr_UInt64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012FD RID: 4861 RVA: 0x0005F4D0 File Offset: 0x0005D6D0
		[CallerCount(0)]
		public unsafe static void ShortMix(ref ulong h0, ref ulong h1, ref ulong h2, ref ulong h3)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &h0;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &h1;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &h2;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &h3;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpookyHash.NativeMethodInfoPtr_ShortMix_Private_Static_Void_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012FE RID: 4862 RVA: 0x0005F52C File Offset: 0x0005D72C
		[CallerCount(0)]
		public unsafe static void ShortEnd(ref ulong h0, ref ulong h1, ref ulong h2, ref ulong h3)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &h0;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &h1;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &h2;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &h3;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpookyHash.NativeMethodInfoPtr_ShortEnd_Private_Static_Void_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012FF RID: 4863 RVA: 0x0005F588 File Offset: 0x0005D788
		[CallerCount(0)]
		public unsafe static void Mix(ulong* data, ref ulong s0, ref ulong s1, ref ulong s2, ref ulong s3, ref ulong s4, ref ulong s5, ref ulong s6, ref ulong s7, ref ulong s8, ref ulong s9, ref ulong s10, ref ulong s11)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)13) * (UIntPtr)sizeof(IntPtr)];
				*ptr = data;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &s0;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &s1;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &s2;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &s3;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &s4;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &s5;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &s6;
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &s7;
			ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &s8;
			ptr[checked(unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &s9;
			ptr[checked(unchecked((UIntPtr)11) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &s10;
			ptr[checked(unchecked((UIntPtr)12) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &s11;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpookyHash.NativeMethodInfoPtr_Mix_Private_Static_Void_ptr_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001300 RID: 4864 RVA: 0x00007EBF File Offset: 0x000060BF
		public SpookyHash(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040010BE RID: 4286
		private static readonly IntPtr NativeMethodInfoPtr_Hash_Public_Static_Void_ptr_Void_UInt64_ptr_UInt64_ptr_UInt64_0;

		// Token: 0x040010BF RID: 4287
		private static readonly IntPtr NativeMethodInfoPtr_End_Private_Static_Void_ptr_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_0;

		// Token: 0x040010C0 RID: 4288
		private static readonly IntPtr NativeMethodInfoPtr_EndPartial_Private_Static_Void_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_0;

		// Token: 0x040010C1 RID: 4289
		private static readonly IntPtr NativeMethodInfoPtr_Rot64_Private_Static_Void_byref_UInt64_Int32_0;

		// Token: 0x040010C2 RID: 4290
		private static readonly IntPtr NativeMethodInfoPtr_Short_Private_Static_Void_ptr_Void_UInt64_ptr_UInt64_ptr_UInt64_0;

		// Token: 0x040010C3 RID: 4291
		private static readonly IntPtr NativeMethodInfoPtr_ShortMix_Private_Static_Void_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_0;

		// Token: 0x040010C4 RID: 4292
		private static readonly IntPtr NativeMethodInfoPtr_ShortEnd_Private_Static_Void_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_0;

		// Token: 0x040010C5 RID: 4293
		private static readonly IntPtr NativeMethodInfoPtr_Mix_Private_Static_Void_ptr_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_0;

		// Token: 0x040010C6 RID: 4294
		public const int k_NumVars = 12;

		// Token: 0x040010C7 RID: 4295
		public const int k_BlockSize = 96;

		// Token: 0x040010C8 RID: 4296
		public const int k_BufferSize = 192;

		// Token: 0x040010C9 RID: 4297
		public const ulong k_DeadBeefConst = 16045690984833335023UL;

		// Token: 0x020006DC RID: 1756
		[StructLayout(2)]
		public struct U
		{
			// Token: 0x06003695 RID: 13973 RVA: 0x000BA540 File Offset: 0x000B8740
			// Note: this type is marked as 'beforefieldinit'.
			static U()
			{
				Il2CppClassPointerStore<SpookyHash.U>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SpookyHash>.NativeClassPtr, "U");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpookyHash.U>.NativeClassPtr);
				SpookyHash.U.NativeFieldInfoPtr_p8 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpookyHash.U>.NativeClassPtr, "p8");
				SpookyHash.U.NativeFieldInfoPtr_p32 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpookyHash.U>.NativeClassPtr, "p32");
				SpookyHash.U.NativeFieldInfoPtr_p64 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpookyHash.U>.NativeClassPtr, "p64");
				SpookyHash.U.NativeFieldInfoPtr_i = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpookyHash.U>.NativeClassPtr, "i");
				SpookyHash.U.NativeMethodInfoPtr__ctor_Public_Void_ptr_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpookyHash.U>.NativeClassPtr, 100665972);
			}

			// Token: 0x06003696 RID: 13974 RVA: 0x000BA5D0 File Offset: 0x000B87D0
			[CallerCount(44)]
			[CachedScanResults(RefRangeStart = 315640, RefRangeEnd = 315684, XrefRangeStart = 315640, XrefRangeEnd = 315684, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe U(ushort* p8)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = p8;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpookyHash.U.NativeMethodInfoPtr__ctor_Public_Void_ptr_UInt16_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06003697 RID: 13975 RVA: 0x00013DD5 File Offset: 0x00011FD5
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SpookyHash.U>.NativeClassPtr, ref this));
			}

			// Token: 0x04002C08 RID: 11272
			private static readonly IntPtr NativeFieldInfoPtr_p8;

			// Token: 0x04002C09 RID: 11273
			private static readonly IntPtr NativeFieldInfoPtr_p32;

			// Token: 0x04002C0A RID: 11274
			private static readonly IntPtr NativeFieldInfoPtr_p64;

			// Token: 0x04002C0B RID: 11275
			private static readonly IntPtr NativeFieldInfoPtr_i;

			// Token: 0x04002C0C RID: 11276
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ptr_UInt16_0;

			// Token: 0x04002C0D RID: 11277
			[FieldOffset(0)]
			public IntPtr p8;

			// Token: 0x04002C0E RID: 11278
			[FieldOffset(0)]
			public IntPtr p32;

			// Token: 0x04002C0F RID: 11279
			[FieldOffset(0)]
			public IntPtr p64;

			// Token: 0x04002C10 RID: 11280
			[FieldOffset(0)]
			public ulong i;
		}
	}
}
