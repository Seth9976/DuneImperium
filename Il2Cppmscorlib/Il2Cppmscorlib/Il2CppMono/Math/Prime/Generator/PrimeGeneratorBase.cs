using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppMono.Math.Prime.Generator
{
	// Token: 0x0200003A RID: 58
	public class PrimeGeneratorBase : Object
	{
		// Token: 0x0600036D RID: 877 RVA: 0x00033224 File Offset: 0x00031424
		// Note: this type is marked as 'beforefieldinit'.
		static PrimeGeneratorBase()
		{
			Il2CppClassPointerStore<PrimeGeneratorBase>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "Mono.Math.Prime.Generator", "PrimeGeneratorBase");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PrimeGeneratorBase>.NativeClassPtr);
			PrimeGeneratorBase.NativeMethodInfoPtr_get_Confidence_Public_Virtual_New_get_ConfidenceFactor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrimeGeneratorBase>.NativeClassPtr, 100663817);
			PrimeGeneratorBase.NativeMethodInfoPtr_get_PrimalityTest_Public_Virtual_New_get_PrimalityTest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrimeGeneratorBase>.NativeClassPtr, 100663818);
			PrimeGeneratorBase.NativeMethodInfoPtr_get_TrialDivisionBounds_Public_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrimeGeneratorBase>.NativeClassPtr, 100663819);
			PrimeGeneratorBase.NativeMethodInfoPtr_GenerateNewPrime_Public_Abstract_Virtual_New_BigInteger_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrimeGeneratorBase>.NativeClassPtr, 100663820);
			PrimeGeneratorBase.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrimeGeneratorBase>.NativeClassPtr, 100663821);
		}

		// Token: 0x170000E1 RID: 225
		// (get) Token: 0x0600036E RID: 878 RVA: 0x000332B8 File Offset: 0x000314B8
		public unsafe virtual ConfidenceFactor Confidence
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 72978, RefRangeEnd = 72985, XrefRangeStart = 72978, XrefRangeEnd = 72985, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PrimeGeneratorBase.NativeMethodInfoPtr_get_Confidence_Public_Virtual_New_get_ConfidenceFactor_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000E2 RID: 226
		// (get) Token: 0x0600036F RID: 879 RVA: 0x00033300 File Offset: 0x00031500
		public unsafe virtual PrimalityTest PrimalityTest
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1280240, XrefRangeEnd = 1280254, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PrimeGeneratorBase.NativeMethodInfoPtr_get_PrimalityTest_Public_Virtual_New_get_PrimalityTest_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PrimalityTest>(intPtr3) : null;
			}
		}

		// Token: 0x170000E3 RID: 227
		// (get) Token: 0x06000370 RID: 880 RVA: 0x0003334C File Offset: 0x0003154C
		public unsafe virtual int TrialDivisionBounds
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PrimeGeneratorBase.NativeMethodInfoPtr_get_TrialDivisionBounds_Public_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000371 RID: 881 RVA: 0x00033394 File Offset: 0x00031594
		[CallerCount(0)]
		public unsafe virtual BigInteger GenerateNewPrime(int bits)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref bits;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PrimeGeneratorBase.NativeMethodInfoPtr_GenerateNewPrime_Public_Abstract_Virtual_New_BigInteger_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<BigInteger>(intPtr3) : null;
			}
		}

		// Token: 0x06000372 RID: 882 RVA: 0x000333EC File Offset: 0x000315EC
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PrimeGeneratorBase()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PrimeGeneratorBase>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PrimeGeneratorBase.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000373 RID: 883 RVA: 0x000035A8 File Offset: 0x000017A8
		public PrimeGeneratorBase(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400026C RID: 620
		private static readonly IntPtr NativeMethodInfoPtr_get_Confidence_Public_Virtual_New_get_ConfidenceFactor_0;

		// Token: 0x0400026D RID: 621
		private static readonly IntPtr NativeMethodInfoPtr_get_PrimalityTest_Public_Virtual_New_get_PrimalityTest_0;

		// Token: 0x0400026E RID: 622
		private static readonly IntPtr NativeMethodInfoPtr_get_TrialDivisionBounds_Public_Virtual_New_get_Int32_0;

		// Token: 0x0400026F RID: 623
		private static readonly IntPtr NativeMethodInfoPtr_GenerateNewPrime_Public_Abstract_Virtual_New_BigInteger_Int32_0;

		// Token: 0x04000270 RID: 624
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
