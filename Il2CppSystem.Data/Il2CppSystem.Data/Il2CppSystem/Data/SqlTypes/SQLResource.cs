using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Data.SqlTypes
{
	// Token: 0x0200008A RID: 138
	public static class SQLResource : Object
	{
		// Token: 0x06000D69 RID: 3433 RVA: 0x00043214 File Offset: 0x00041414
		// Note: this type is marked as 'beforefieldinit'.
		static SQLResource()
		{
			Il2CppClassPointerStore<SQLResource>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Data.dll", "System.Data.SqlTypes", "SQLResource");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SQLResource>.NativeClassPtr);
			SQLResource.NativeMethodInfoPtr_get_NullString_Internal_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SQLResource>.NativeClassPtr, 100665486);
			SQLResource.NativeMethodInfoPtr_get_ArithOverflowMessage_Internal_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SQLResource>.NativeClassPtr, 100665487);
			SQLResource.NativeMethodInfoPtr_get_DivideByZeroMessage_Internal_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SQLResource>.NativeClassPtr, 100665488);
			SQLResource.NativeMethodInfoPtr_get_NullValueMessage_Internal_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SQLResource>.NativeClassPtr, 100665489);
			SQLResource.NativeMethodInfoPtr_get_TruncationMessage_Internal_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SQLResource>.NativeClassPtr, 100665490);
			SQLResource.NativeMethodInfoPtr_get_DateTimeOverflowMessage_Internal_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SQLResource>.NativeClassPtr, 100665491);
			SQLResource.NativeMethodInfoPtr_get_ConcatDiffCollationMessage_Internal_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SQLResource>.NativeClassPtr, 100665492);
			SQLResource.NativeMethodInfoPtr_get_CompareDiffCollationMessage_Internal_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SQLResource>.NativeClassPtr, 100665493);
			SQLResource.NativeMethodInfoPtr_get_ConversionOverflowMessage_Internal_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SQLResource>.NativeClassPtr, 100665494);
			SQLResource.NativeMethodInfoPtr_get_TimeZoneSpecifiedMessage_Internal_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SQLResource>.NativeClassPtr, 100665495);
			SQLResource.NativeMethodInfoPtr_get_InvalidPrecScaleMessage_Internal_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SQLResource>.NativeClassPtr, 100665496);
			SQLResource.NativeMethodInfoPtr_get_FormatMessage_Internal_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SQLResource>.NativeClassPtr, 100665497);
			SQLResource.NativeMethodInfoPtr_InvalidOpStreamClosed_Internal_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SQLResource>.NativeClassPtr, 100665498);
			SQLResource.NativeMethodInfoPtr_InvalidOpStreamNonWritable_Internal_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SQLResource>.NativeClassPtr, 100665499);
			SQLResource.NativeMethodInfoPtr_InvalidOpStreamNonReadable_Internal_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SQLResource>.NativeClassPtr, 100665500);
			SQLResource.NativeMethodInfoPtr_InvalidOpStreamNonSeekable_Internal_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SQLResource>.NativeClassPtr, 100665501);
		}

		// Token: 0x17000356 RID: 854
		// (get) Token: 0x06000D6A RID: 3434 RVA: 0x00043384 File Offset: 0x00041584
		public unsafe static string NullString
		{
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 915068, RefRangeEnd = 915076, XrefRangeStart = 915066, XrefRangeEnd = 915068, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SQLResource.NativeMethodInfoPtr_get_NullString_Internal_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000357 RID: 855
		// (get) Token: 0x06000D6B RID: 3435 RVA: 0x000433B0 File Offset: 0x000415B0
		public unsafe static string ArithOverflowMessage
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 915076, XrefRangeEnd = 915078, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SQLResource.NativeMethodInfoPtr_get_ArithOverflowMessage_Internal_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000358 RID: 856
		// (get) Token: 0x06000D6C RID: 3436 RVA: 0x000433DC File Offset: 0x000415DC
		public unsafe static string DivideByZeroMessage
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 915078, XrefRangeEnd = 915080, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SQLResource.NativeMethodInfoPtr_get_DivideByZeroMessage_Internal_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000359 RID: 857
		// (get) Token: 0x06000D6D RID: 3437 RVA: 0x00043408 File Offset: 0x00041608
		public unsafe static string NullValueMessage
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 915082, RefRangeEnd = 915083, XrefRangeStart = 915080, XrefRangeEnd = 915082, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SQLResource.NativeMethodInfoPtr_get_NullValueMessage_Internal_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700035A RID: 858
		// (get) Token: 0x06000D6E RID: 3438 RVA: 0x00043434 File Offset: 0x00041634
		public unsafe static string TruncationMessage
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 915085, RefRangeEnd = 915086, XrefRangeStart = 915083, XrefRangeEnd = 915085, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SQLResource.NativeMethodInfoPtr_get_TruncationMessage_Internal_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700035B RID: 859
		// (get) Token: 0x06000D6F RID: 3439 RVA: 0x00043460 File Offset: 0x00041660
		public unsafe static string DateTimeOverflowMessage
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 915086, XrefRangeEnd = 915088, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SQLResource.NativeMethodInfoPtr_get_DateTimeOverflowMessage_Internal_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700035C RID: 860
		// (get) Token: 0x06000D70 RID: 3440 RVA: 0x0004348C File Offset: 0x0004168C
		public unsafe static string ConcatDiffCollationMessage
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 915088, XrefRangeEnd = 915090, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SQLResource.NativeMethodInfoPtr_get_ConcatDiffCollationMessage_Internal_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700035D RID: 861
		// (get) Token: 0x06000D71 RID: 3441 RVA: 0x000434B8 File Offset: 0x000416B8
		public unsafe static string CompareDiffCollationMessage
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 915090, XrefRangeEnd = 915092, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SQLResource.NativeMethodInfoPtr_get_CompareDiffCollationMessage_Internal_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700035E RID: 862
		// (get) Token: 0x06000D72 RID: 3442 RVA: 0x000434E4 File Offset: 0x000416E4
		public unsafe static string ConversionOverflowMessage
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 915092, XrefRangeEnd = 915094, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SQLResource.NativeMethodInfoPtr_get_ConversionOverflowMessage_Internal_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700035F RID: 863
		// (get) Token: 0x06000D73 RID: 3443 RVA: 0x00043510 File Offset: 0x00041710
		public unsafe static string TimeZoneSpecifiedMessage
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 915094, XrefRangeEnd = 915096, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SQLResource.NativeMethodInfoPtr_get_TimeZoneSpecifiedMessage_Internal_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000360 RID: 864
		// (get) Token: 0x06000D74 RID: 3444 RVA: 0x0004353C File Offset: 0x0004173C
		public unsafe static string InvalidPrecScaleMessage
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 915096, XrefRangeEnd = 915098, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SQLResource.NativeMethodInfoPtr_get_InvalidPrecScaleMessage_Internal_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000361 RID: 865
		// (get) Token: 0x06000D75 RID: 3445 RVA: 0x00043568 File Offset: 0x00041768
		public unsafe static string FormatMessage
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 915098, XrefRangeEnd = 915100, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SQLResource.NativeMethodInfoPtr_get_FormatMessage_Internal_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000D76 RID: 3446 RVA: 0x00043594 File Offset: 0x00041794
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 915103, RefRangeEnd = 915104, XrefRangeStart = 915100, XrefRangeEnd = 915103, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string InvalidOpStreamClosed(string method)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(method);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SQLResource.NativeMethodInfoPtr_InvalidOpStreamClosed_Internal_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000D77 RID: 3447 RVA: 0x000435D0 File Offset: 0x000417D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 915104, XrefRangeEnd = 915107, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string InvalidOpStreamNonWritable(string method)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(method);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SQLResource.NativeMethodInfoPtr_InvalidOpStreamNonWritable_Internal_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000D78 RID: 3448 RVA: 0x0004360C File Offset: 0x0004180C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 915107, XrefRangeEnd = 915110, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string InvalidOpStreamNonReadable(string method)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(method);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SQLResource.NativeMethodInfoPtr_InvalidOpStreamNonReadable_Internal_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000D79 RID: 3449 RVA: 0x00043648 File Offset: 0x00041848
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 915110, XrefRangeEnd = 915113, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string InvalidOpStreamNonSeekable(string method)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(method);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SQLResource.NativeMethodInfoPtr_InvalidOpStreamNonSeekable_Internal_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000D7A RID: 3450 RVA: 0x000063C6 File Offset: 0x000045C6
		public SQLResource(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000B1A RID: 2842
		private static readonly IntPtr NativeMethodInfoPtr_get_NullString_Internal_Static_get_String_0;

		// Token: 0x04000B1B RID: 2843
		private static readonly IntPtr NativeMethodInfoPtr_get_ArithOverflowMessage_Internal_Static_get_String_0;

		// Token: 0x04000B1C RID: 2844
		private static readonly IntPtr NativeMethodInfoPtr_get_DivideByZeroMessage_Internal_Static_get_String_0;

		// Token: 0x04000B1D RID: 2845
		private static readonly IntPtr NativeMethodInfoPtr_get_NullValueMessage_Internal_Static_get_String_0;

		// Token: 0x04000B1E RID: 2846
		private static readonly IntPtr NativeMethodInfoPtr_get_TruncationMessage_Internal_Static_get_String_0;

		// Token: 0x04000B1F RID: 2847
		private static readonly IntPtr NativeMethodInfoPtr_get_DateTimeOverflowMessage_Internal_Static_get_String_0;

		// Token: 0x04000B20 RID: 2848
		private static readonly IntPtr NativeMethodInfoPtr_get_ConcatDiffCollationMessage_Internal_Static_get_String_0;

		// Token: 0x04000B21 RID: 2849
		private static readonly IntPtr NativeMethodInfoPtr_get_CompareDiffCollationMessage_Internal_Static_get_String_0;

		// Token: 0x04000B22 RID: 2850
		private static readonly IntPtr NativeMethodInfoPtr_get_ConversionOverflowMessage_Internal_Static_get_String_0;

		// Token: 0x04000B23 RID: 2851
		private static readonly IntPtr NativeMethodInfoPtr_get_TimeZoneSpecifiedMessage_Internal_Static_get_String_0;

		// Token: 0x04000B24 RID: 2852
		private static readonly IntPtr NativeMethodInfoPtr_get_InvalidPrecScaleMessage_Internal_Static_get_String_0;

		// Token: 0x04000B25 RID: 2853
		private static readonly IntPtr NativeMethodInfoPtr_get_FormatMessage_Internal_Static_get_String_0;

		// Token: 0x04000B26 RID: 2854
		private static readonly IntPtr NativeMethodInfoPtr_InvalidOpStreamClosed_Internal_Static_String_String_0;

		// Token: 0x04000B27 RID: 2855
		private static readonly IntPtr NativeMethodInfoPtr_InvalidOpStreamNonWritable_Internal_Static_String_String_0;

		// Token: 0x04000B28 RID: 2856
		private static readonly IntPtr NativeMethodInfoPtr_InvalidOpStreamNonReadable_Internal_Static_String_String_0;

		// Token: 0x04000B29 RID: 2857
		private static readonly IntPtr NativeMethodInfoPtr_InvalidOpStreamNonSeekable_Internal_Static_String_String_0;
	}
}
