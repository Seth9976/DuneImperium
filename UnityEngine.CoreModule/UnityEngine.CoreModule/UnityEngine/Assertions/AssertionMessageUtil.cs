using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Assertions
{
	// Token: 0x02000289 RID: 649
	public class AssertionMessageUtil : Object
	{
		// Token: 0x06002C4D RID: 11341 RVA: 0x000B22BC File Offset: 0x000B04BC
		// Note: this type is marked as 'beforefieldinit'.
		static AssertionMessageUtil()
		{
			Il2CppClassPointerStore<AssertionMessageUtil>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Assertions", "AssertionMessageUtil");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AssertionMessageUtil>.NativeClassPtr);
			AssertionMessageUtil.NativeMethodInfoPtr_GetMessage_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssertionMessageUtil>.NativeClassPtr, 100668691);
			AssertionMessageUtil.NativeMethodInfoPtr_GetMessage_Public_Static_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssertionMessageUtil>.NativeClassPtr, 100668692);
			AssertionMessageUtil.NativeMethodInfoPtr_GetEqualityMessage_Public_Static_String_Object_Object_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssertionMessageUtil>.NativeClassPtr, 100668693);
			AssertionMessageUtil.NativeMethodInfoPtr_NullFailureMessage_Public_Static_String_Object_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssertionMessageUtil>.NativeClassPtr, 100668694);
			AssertionMessageUtil.NativeMethodInfoPtr_BooleanFailureMessage_Public_Static_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssertionMessageUtil>.NativeClassPtr, 100668695);
		}

		// Token: 0x06002C4E RID: 11342 RVA: 0x000B2350 File Offset: 0x000B0550
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 686650, XrefRangeEnd = 686669, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetMessage(string failureMessage)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(failureMessage);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssertionMessageUtil.NativeMethodInfoPtr_GetMessage_Public_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06002C4F RID: 11343 RVA: 0x000B238C File Offset: 0x000B058C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 686714, RefRangeEnd = 686719, XrefRangeStart = 686669, XrefRangeEnd = 686714, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetMessage(string failureMessage, string expected)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(failureMessage);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(expected);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssertionMessageUtil.NativeMethodInfoPtr_GetMessage_Public_Static_String_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06002C50 RID: 11344 RVA: 0x000B23DC File Offset: 0x000B05DC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 686757, RefRangeEnd = 686759, XrefRangeStart = 686719, XrefRangeEnd = 686757, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetEqualityMessage(Object actual, Object expected, bool expectEqual)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(actual);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(expected);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref expectEqual;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssertionMessageUtil.NativeMethodInfoPtr_GetEqualityMessage_Public_Static_String_Object_Object_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06002C51 RID: 11345 RVA: 0x000B2438 File Offset: 0x000B0638
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 686786, RefRangeEnd = 686792, XrefRangeStart = 686759, XrefRangeEnd = 686786, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string NullFailureMessage(Object value, bool expectNull)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref expectNull;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssertionMessageUtil.NativeMethodInfoPtr_NullFailureMessage_Public_Static_String_Object_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06002C52 RID: 11346 RVA: 0x000B2484 File Offset: 0x000B0684
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 686792, XrefRangeEnd = 686801, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string BooleanFailureMessage(bool expected)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref expected;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssertionMessageUtil.NativeMethodInfoPtr_BooleanFailureMessage_Public_Static_String_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06002C53 RID: 11347 RVA: 0x00011310 File Offset: 0x0000F510
		public AssertionMessageUtil(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04002792 RID: 10130
		private static readonly IntPtr NativeMethodInfoPtr_GetMessage_Public_Static_String_String_0;

		// Token: 0x04002793 RID: 10131
		private static readonly IntPtr NativeMethodInfoPtr_GetMessage_Public_Static_String_String_String_0;

		// Token: 0x04002794 RID: 10132
		private static readonly IntPtr NativeMethodInfoPtr_GetEqualityMessage_Public_Static_String_Object_Object_Boolean_0;

		// Token: 0x04002795 RID: 10133
		private static readonly IntPtr NativeMethodInfoPtr_NullFailureMessage_Public_Static_String_Object_Boolean_0;

		// Token: 0x04002796 RID: 10134
		private static readonly IntPtr NativeMethodInfoPtr_BooleanFailureMessage_Public_Static_String_Boolean_0;

		// Token: 0x04002797 RID: 10135
		public const string k_Expected = "Expected:";

		// Token: 0x04002798 RID: 10136
		public const string k_AssertionFailed = "Assertion failure.";
	}
}
