using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppMono.Math.Prime
{
	// Token: 0x02000041 RID: 65
	public sealed class PrimalityTests : Object
	{
		// Token: 0x060003DF RID: 991 RVA: 0x00012C80 File Offset: 0x00010E80
		// Note: this type is marked as 'beforefieldinit'.
		static PrimalityTests()
		{
			Il2CppClassPointerStore<PrimalityTests>.NativeClassPtr = IL2CPP.GetIl2CppClass("Mono.Security.dll", "Mono.Math.Prime", "PrimalityTests");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PrimalityTests>.NativeClassPtr);
			PrimalityTests.NativeMethodInfoPtr_GetSPPRounds_Private_Static_Int32_BigInteger_ConfidenceFactor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrimalityTests>.NativeClassPtr, 100663880);
			PrimalityTests.NativeMethodInfoPtr_RabinMillerTest_Public_Static_Boolean_BigInteger_ConfidenceFactor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrimalityTests>.NativeClassPtr, 100663881);
		}

		// Token: 0x060003E0 RID: 992 RVA: 0x00012CD8 File Offset: 0x00010ED8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1151999, XrefRangeEnd = 1152010, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x060003E1 RID: 993 RVA: 0x00012D28 File Offset: 0x00010F28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1152010, XrefRangeEnd = 1152084, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x060003E2 RID: 994 RVA: 0x00003A4E File Offset: 0x00001C4E
		public PrimalityTests(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040003F4 RID: 1012
		private static readonly IntPtr NativeMethodInfoPtr_GetSPPRounds_Private_Static_Int32_BigInteger_ConfidenceFactor_0;

		// Token: 0x040003F5 RID: 1013
		private static readonly IntPtr NativeMethodInfoPtr_RabinMillerTest_Public_Static_Boolean_BigInteger_ConfidenceFactor_0;
	}
}
