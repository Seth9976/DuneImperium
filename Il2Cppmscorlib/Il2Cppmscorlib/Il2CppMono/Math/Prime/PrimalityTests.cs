using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppMono.Math.Prime
{
	// Token: 0x02000039 RID: 57
	public sealed class PrimalityTests : Object
	{
		// Token: 0x06000367 RID: 871 RVA: 0x00033064 File Offset: 0x00031264
		// Note: this type is marked as 'beforefieldinit'.
		static PrimalityTests()
		{
			Il2CppClassPointerStore<PrimalityTests>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "Mono.Math.Prime", "PrimalityTests");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PrimalityTests>.NativeClassPtr);
			PrimalityTests.NativeMethodInfoPtr_GetSPPRounds_Private_Static_Int32_BigInteger_ConfidenceFactor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrimalityTests>.NativeClassPtr, 100663813);
			PrimalityTests.NativeMethodInfoPtr_Test_Public_Static_Boolean_BigInteger_ConfidenceFactor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrimalityTests>.NativeClassPtr, 100663814);
			PrimalityTests.NativeMethodInfoPtr_RabinMillerTest_Public_Static_Boolean_BigInteger_ConfidenceFactor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrimalityTests>.NativeClassPtr, 100663815);
			PrimalityTests.NativeMethodInfoPtr_SmallPrimeSppTest_Public_Static_Boolean_BigInteger_ConfidenceFactor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrimalityTests>.NativeClassPtr, 100663816);
		}

		// Token: 0x06000368 RID: 872 RVA: 0x000330E4 File Offset: 0x000312E4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1280153, RefRangeEnd = 1280155, XrefRangeStart = 1280142, XrefRangeEnd = 1280153, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetSPPRounds(BigInteger bi, ConfidenceFactor confidence)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(bi);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref confidence;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PrimalityTests.NativeMethodInfoPtr_GetSPPRounds_Private_Static_Int32_BigInteger_ConfidenceFactor_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000369 RID: 873 RVA: 0x00033134 File Offset: 0x00031334
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1280155, XrefRangeEnd = 1280159, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Test(BigInteger n, ConfidenceFactor confidence)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(n);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref confidence;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PrimalityTests.NativeMethodInfoPtr_Test_Public_Static_Boolean_BigInteger_ConfidenceFactor_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600036A RID: 874 RVA: 0x00033184 File Offset: 0x00031384
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1280210, RefRangeEnd = 1280212, XrefRangeStart = 1280159, XrefRangeEnd = 1280210, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool RabinMillerTest(BigInteger n, ConfidenceFactor confidence)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(n);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref confidence;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PrimalityTests.NativeMethodInfoPtr_RabinMillerTest_Public_Static_Boolean_BigInteger_ConfidenceFactor_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600036B RID: 875 RVA: 0x000331D4 File Offset: 0x000313D4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1280238, RefRangeEnd = 1280240, XrefRangeStart = 1280212, XrefRangeEnd = 1280238, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool SmallPrimeSppTest(BigInteger bi, ConfidenceFactor confidence)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(bi);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref confidence;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PrimalityTests.NativeMethodInfoPtr_SmallPrimeSppTest_Public_Static_Boolean_BigInteger_ConfidenceFactor_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600036C RID: 876 RVA: 0x0000359F File Offset: 0x0000179F
		public PrimalityTests(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000268 RID: 616
		private static readonly IntPtr NativeMethodInfoPtr_GetSPPRounds_Private_Static_Int32_BigInteger_ConfidenceFactor_0;

		// Token: 0x04000269 RID: 617
		private static readonly IntPtr NativeMethodInfoPtr_Test_Public_Static_Boolean_BigInteger_ConfidenceFactor_0;

		// Token: 0x0400026A RID: 618
		private static readonly IntPtr NativeMethodInfoPtr_RabinMillerTest_Public_Static_Boolean_BigInteger_ConfidenceFactor_0;

		// Token: 0x0400026B RID: 619
		private static readonly IntPtr NativeMethodInfoPtr_SmallPrimeSppTest_Public_Static_Boolean_BigInteger_ConfidenceFactor_0;
	}
}
