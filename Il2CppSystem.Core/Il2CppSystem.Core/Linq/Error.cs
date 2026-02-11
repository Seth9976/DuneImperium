using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Linq
{
	// Token: 0x02000017 RID: 23
	public static class Error : Object
	{
		// Token: 0x0600009B RID: 155 RVA: 0x00011F8C File Offset: 0x0001018C
		// Note: this type is marked as 'beforefieldinit'.
		static Error()
		{
			Il2CppClassPointerStore<Error>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Core.dll", "System.Linq", "Error");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Error>.NativeClassPtr);
			Error.NativeMethodInfoPtr_ArgumentNull_Internal_Static_Exception_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Error>.NativeClassPtr, 100663379);
			Error.NativeMethodInfoPtr_ArgumentOutOfRange_Internal_Static_Exception_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Error>.NativeClassPtr, 100663380);
			Error.NativeMethodInfoPtr_MoreThanOneElement_Internal_Static_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Error>.NativeClassPtr, 100663381);
			Error.NativeMethodInfoPtr_MoreThanOneMatch_Internal_Static_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Error>.NativeClassPtr, 100663382);
			Error.NativeMethodInfoPtr_NoElements_Internal_Static_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Error>.NativeClassPtr, 100663383);
			Error.NativeMethodInfoPtr_NoMatch_Internal_Static_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Error>.NativeClassPtr, 100663384);
			Error.NativeMethodInfoPtr_NotSupported_Internal_Static_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Error>.NativeClassPtr, 100663385);
		}

		// Token: 0x0600009C RID: 156 RVA: 0x00012048 File Offset: 0x00010248
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1002491, RefRangeEnd = 1002494, XrefRangeStart = 1002487, XrefRangeEnd = 1002491, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception ArgumentNull(string s)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Error.NativeMethodInfoPtr_ArgumentNull_Internal_Static_Exception_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
			}
		}

		// Token: 0x0600009D RID: 157 RVA: 0x0001208C File Offset: 0x0001028C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1002494, XrefRangeEnd = 1002498, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception ArgumentOutOfRange(string s)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Error.NativeMethodInfoPtr_ArgumentOutOfRange_Internal_Static_Exception_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
			}
		}

		// Token: 0x0600009E RID: 158 RVA: 0x000120D0 File Offset: 0x000102D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1002498, XrefRangeEnd = 1002504, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception MoreThanOneElement()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Error.NativeMethodInfoPtr_MoreThanOneElement_Internal_Static_Exception_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x0600009F RID: 159 RVA: 0x00012104 File Offset: 0x00010304
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1002504, XrefRangeEnd = 1002510, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception MoreThanOneMatch()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Error.NativeMethodInfoPtr_MoreThanOneMatch_Internal_Static_Exception_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x060000A0 RID: 160 RVA: 0x00012138 File Offset: 0x00010338
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1002510, XrefRangeEnd = 1002516, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception NoElements()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Error.NativeMethodInfoPtr_NoElements_Internal_Static_Exception_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x060000A1 RID: 161 RVA: 0x0001216C File Offset: 0x0001036C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1002516, XrefRangeEnd = 1002522, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception NoMatch()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Error.NativeMethodInfoPtr_NoMatch_Internal_Static_Exception_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x060000A2 RID: 162 RVA: 0x000121A0 File Offset: 0x000103A0
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1002526, RefRangeEnd = 1002532, XrefRangeStart = 1002522, XrefRangeEnd = 1002526, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception NotSupported()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Error.NativeMethodInfoPtr_NotSupported_Internal_Static_Exception_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x060000A3 RID: 163 RVA: 0x0000228E File Offset: 0x0000048E
		public Error(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000061 RID: 97
		private static readonly IntPtr NativeMethodInfoPtr_ArgumentNull_Internal_Static_Exception_String_0;

		// Token: 0x04000062 RID: 98
		private static readonly IntPtr NativeMethodInfoPtr_ArgumentOutOfRange_Internal_Static_Exception_String_0;

		// Token: 0x04000063 RID: 99
		private static readonly IntPtr NativeMethodInfoPtr_MoreThanOneElement_Internal_Static_Exception_0;

		// Token: 0x04000064 RID: 100
		private static readonly IntPtr NativeMethodInfoPtr_MoreThanOneMatch_Internal_Static_Exception_0;

		// Token: 0x04000065 RID: 101
		private static readonly IntPtr NativeMethodInfoPtr_NoElements_Internal_Static_Exception_0;

		// Token: 0x04000066 RID: 102
		private static readonly IntPtr NativeMethodInfoPtr_NoMatch_Internal_Static_Exception_0;

		// Token: 0x04000067 RID: 103
		private static readonly IntPtr NativeMethodInfoPtr_NotSupported_Internal_Static_Exception_0;
	}
}
