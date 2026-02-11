using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Canis.logging
{
	// Token: 0x0200009A RID: 154
	public static class MatchLogging : Object
	{
		// Token: 0x0600079B RID: 1947 RVA: 0x00038420 File Offset: 0x00036620
		// Note: this type is marked as 'beforefieldinit'.
		static MatchLogging()
		{
			Il2CppClassPointerStore<MatchLogging>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.logging", "MatchLogging");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MatchLogging>.NativeClassPtr);
			MatchLogging.NativeMethodInfoPtr_LogException_Public_Static_Void_Match_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MatchLogging>.NativeClassPtr, 100664855);
			MatchLogging.NativeMethodInfoPtr_LogError_Public_Static_Void_Match_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MatchLogging>.NativeClassPtr, 100664856);
			MatchLogging.NativeMethodInfoPtr_LogException_Public_Static_Void_Exception_GameID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MatchLogging>.NativeClassPtr, 100664857);
			MatchLogging.NativeMethodInfoPtr_LogError_Public_Static_Void_String_GameID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MatchLogging>.NativeClassPtr, 100664858);
			MatchLogging.NativeMethodInfoPtr_LogException_Public_Static_Void_String_Exception_GameID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MatchLogging>.NativeClassPtr, 100664859);
			MatchLogging.NativeMethodInfoPtr_LogError_Public_Static_Void_String_Exception_GameID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MatchLogging>.NativeClassPtr, 100664860);
		}

		// Token: 0x0600079C RID: 1948 RVA: 0x000384C8 File Offset: 0x000366C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 557984, XrefRangeEnd = 558002, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void LogException(this Match m, Exception e)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(e);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MatchLogging.NativeMethodInfoPtr_LogException_Public_Static_Void_Match_Exception_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600079D RID: 1949 RVA: 0x00038510 File Offset: 0x00036710
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 558002, XrefRangeEnd = 558020, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void LogError(this Match m, string error)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(error);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MatchLogging.NativeMethodInfoPtr_LogError_Public_Static_Void_Match_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600079E RID: 1950 RVA: 0x00038558 File Offset: 0x00036758
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 558020, XrefRangeEnd = 558037, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void LogException(Exception e, GameID gameID)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(gameID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MatchLogging.NativeMethodInfoPtr_LogException_Public_Static_Void_Exception_GameID_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600079F RID: 1951 RVA: 0x000385A0 File Offset: 0x000367A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 558037, XrefRangeEnd = 558054, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void LogError(string error, GameID gameID)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(error);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(gameID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MatchLogging.NativeMethodInfoPtr_LogError_Public_Static_Void_String_GameID_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007A0 RID: 1952 RVA: 0x000385E8 File Offset: 0x000367E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 558054, XrefRangeEnd = 558071, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void LogException(string error, Exception e, GameID gameID)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(error);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(e);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(gameID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MatchLogging.NativeMethodInfoPtr_LogException_Public_Static_Void_String_Exception_GameID_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007A1 RID: 1953 RVA: 0x00038644 File Offset: 0x00036844
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 558071, XrefRangeEnd = 558088, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void LogError(string error, Exception e, GameID gameID)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(error);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(e);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(gameID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MatchLogging.NativeMethodInfoPtr_LogError_Public_Static_Void_String_Exception_GameID_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007A2 RID: 1954 RVA: 0x00004F3A File Offset: 0x0000313A
		public MatchLogging(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400053F RID: 1343
		private static readonly IntPtr NativeMethodInfoPtr_LogException_Public_Static_Void_Match_Exception_0;

		// Token: 0x04000540 RID: 1344
		private static readonly IntPtr NativeMethodInfoPtr_LogError_Public_Static_Void_Match_String_0;

		// Token: 0x04000541 RID: 1345
		private static readonly IntPtr NativeMethodInfoPtr_LogException_Public_Static_Void_Exception_GameID_0;

		// Token: 0x04000542 RID: 1346
		private static readonly IntPtr NativeMethodInfoPtr_LogError_Public_Static_Void_String_GameID_0;

		// Token: 0x04000543 RID: 1347
		private static readonly IntPtr NativeMethodInfoPtr_LogException_Public_Static_Void_String_Exception_GameID_0;

		// Token: 0x04000544 RID: 1348
		private static readonly IntPtr NativeMethodInfoPtr_LogError_Public_Static_Void_String_Exception_GameID_0;
	}
}
