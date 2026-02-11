using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Unity.Burst.CompilerServices
{
	// Token: 0x02000026 RID: 38
	public static class Hint : Object
	{
		// Token: 0x06000295 RID: 661 RVA: 0x0000E024 File Offset: 0x0000C224
		// Note: this type is marked as 'beforefieldinit'.
		static Hint()
		{
			Il2CppClassPointerStore<Hint>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Burst.dll", "Unity.Burst.CompilerServices", "Hint");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Hint>.NativeClassPtr);
			Hint.NativeMethodInfoPtr_Likely_Public_Static_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hint>.NativeClassPtr, 100666934);
			Hint.NativeMethodInfoPtr_Unlikely_Public_Static_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hint>.NativeClassPtr, 100666935);
			Hint.NativeMethodInfoPtr_Assume_Public_Static_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hint>.NativeClassPtr, 100666936);
		}

		// Token: 0x06000296 RID: 662 RVA: 0x0000E090 File Offset: 0x0000C290
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1064852, RefRangeEnd = 1064854, XrefRangeStart = 1064852, XrefRangeEnd = 1064852, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Likely(bool condition)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref condition;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Hint.NativeMethodInfoPtr_Likely_Public_Static_Boolean_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000297 RID: 663 RVA: 0x0000E0D0 File Offset: 0x0000C2D0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1064852, RefRangeEnd = 1064854, XrefRangeStart = 1064852, XrefRangeEnd = 1064854, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Unlikely(bool condition)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref condition;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Hint.NativeMethodInfoPtr_Unlikely_Public_Static_Boolean_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000298 RID: 664 RVA: 0x0000E110 File Offset: 0x0000C310
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Assume(bool condition)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref condition;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Hint.NativeMethodInfoPtr_Assume_Public_Static_Void_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000299 RID: 665 RVA: 0x00002DD7 File Offset: 0x00000FD7
		public Hint(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000456 RID: 1110
		private static readonly IntPtr NativeMethodInfoPtr_Likely_Public_Static_Boolean_Boolean_0;

		// Token: 0x04000457 RID: 1111
		private static readonly IntPtr NativeMethodInfoPtr_Unlikely_Public_Static_Boolean_Boolean_0;

		// Token: 0x04000458 RID: 1112
		private static readonly IntPtr NativeMethodInfoPtr_Assume_Public_Static_Void_Boolean_0;
	}
}
