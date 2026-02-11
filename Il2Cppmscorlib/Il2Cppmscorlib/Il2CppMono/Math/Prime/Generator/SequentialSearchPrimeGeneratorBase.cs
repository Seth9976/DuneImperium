using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppMono.Math.Prime.Generator
{
	// Token: 0x0200003B RID: 59
	public class SequentialSearchPrimeGeneratorBase : PrimeGeneratorBase
	{
		// Token: 0x06000374 RID: 884 RVA: 0x00033428 File Offset: 0x00031628
		// Note: this type is marked as 'beforefieldinit'.
		static SequentialSearchPrimeGeneratorBase()
		{
			Il2CppClassPointerStore<SequentialSearchPrimeGeneratorBase>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "Mono.Math.Prime.Generator", "SequentialSearchPrimeGeneratorBase");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SequentialSearchPrimeGeneratorBase>.NativeClassPtr);
			SequentialSearchPrimeGeneratorBase.NativeMethodInfoPtr_GenerateSearchBase_Protected_Virtual_New_BigInteger_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequentialSearchPrimeGeneratorBase>.NativeClassPtr, 100663822);
			SequentialSearchPrimeGeneratorBase.NativeMethodInfoPtr_GenerateNewPrime_Public_Virtual_BigInteger_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequentialSearchPrimeGeneratorBase>.NativeClassPtr, 100663823);
			SequentialSearchPrimeGeneratorBase.NativeMethodInfoPtr_GenerateNewPrime_Public_Virtual_New_BigInteger_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequentialSearchPrimeGeneratorBase>.NativeClassPtr, 100663824);
			SequentialSearchPrimeGeneratorBase.NativeMethodInfoPtr_IsPrimeAcceptable_Protected_Virtual_New_Boolean_BigInteger_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequentialSearchPrimeGeneratorBase>.NativeClassPtr, 100663825);
			SequentialSearchPrimeGeneratorBase.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequentialSearchPrimeGeneratorBase>.NativeClassPtr, 100663826);
		}

		// Token: 0x06000375 RID: 885 RVA: 0x000334BC File Offset: 0x000316BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1280254, XrefRangeEnd = 1280262, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual BigInteger GenerateSearchBase(int bits, Object context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref bits;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(context);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SequentialSearchPrimeGeneratorBase.NativeMethodInfoPtr_GenerateSearchBase_Protected_Virtual_New_BigInteger_Int32_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<BigInteger>(intPtr3) : null;
		}

		// Token: 0x06000376 RID: 886 RVA: 0x00033528 File Offset: 0x00031728
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 460546, RefRangeEnd = 460550, XrefRangeStart = 460546, XrefRangeEnd = 460550, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override BigInteger GenerateNewPrime(int bits)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref bits;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SequentialSearchPrimeGeneratorBase.NativeMethodInfoPtr_GenerateNewPrime_Public_Virtual_BigInteger_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<BigInteger>(intPtr3) : null;
			}
		}

		// Token: 0x06000377 RID: 887 RVA: 0x00033580 File Offset: 0x00031780
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1280262, XrefRangeEnd = 1280271, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual BigInteger GenerateNewPrime(int bits, Object context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref bits;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(context);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SequentialSearchPrimeGeneratorBase.NativeMethodInfoPtr_GenerateNewPrime_Public_Virtual_New_BigInteger_Int32_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<BigInteger>(intPtr3) : null;
		}

		// Token: 0x06000378 RID: 888 RVA: 0x000335EC File Offset: 0x000317EC
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 25017, RefRangeEnd = 25031, XrefRangeStart = 25017, XrefRangeEnd = 25031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool IsPrimeAcceptable(BigInteger bi, Object context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(bi);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(context);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SequentialSearchPrimeGeneratorBase.NativeMethodInfoPtr_IsPrimeAcceptable_Protected_Virtual_New_Boolean_BigInteger_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000379 RID: 889 RVA: 0x00033658 File Offset: 0x00031858
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SequentialSearchPrimeGeneratorBase()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SequentialSearchPrimeGeneratorBase>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SequentialSearchPrimeGeneratorBase.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600037A RID: 890 RVA: 0x000035B1 File Offset: 0x000017B1
		public SequentialSearchPrimeGeneratorBase(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000271 RID: 625
		private static readonly IntPtr NativeMethodInfoPtr_GenerateSearchBase_Protected_Virtual_New_BigInteger_Int32_Object_0;

		// Token: 0x04000272 RID: 626
		private static readonly IntPtr NativeMethodInfoPtr_GenerateNewPrime_Public_Virtual_BigInteger_Int32_0;

		// Token: 0x04000273 RID: 627
		private static readonly IntPtr NativeMethodInfoPtr_GenerateNewPrime_Public_Virtual_New_BigInteger_Int32_Object_0;

		// Token: 0x04000274 RID: 628
		private static readonly IntPtr NativeMethodInfoPtr_IsPrimeAcceptable_Protected_Virtual_New_Boolean_BigInteger_Object_0;

		// Token: 0x04000275 RID: 629
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
