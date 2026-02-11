using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;

namespace Unity.Baselib.LowLevel
{
	// Token: 0x02000296 RID: 662
	public static class Binding
	{
		// Token: 0x06002C74 RID: 11380 RVA: 0x00011453 File Offset: 0x0000F653
		public static IntPtr Baselib_Memory_Allocate(UIntPtr size)
		{
			return Binding.Baselib_Memory_AllocateDelegateField(size);
		}

		// Token: 0x06002C75 RID: 11381 RVA: 0x00011460 File Offset: 0x0000F660
		public static IntPtr Baselib_Memory_Reallocate(IntPtr ptr, UIntPtr newSize)
		{
			return Binding.Baselib_Memory_ReallocateDelegateField(ptr, newSize);
		}

		// Token: 0x06002C76 RID: 11382 RVA: 0x0001146E File Offset: 0x0000F66E
		public static void Baselib_Memory_Free(IntPtr ptr)
		{
			Binding.Baselib_Memory_FreeDelegateField(ptr);
		}

		// Token: 0x06002C77 RID: 11383 RVA: 0x0001147B File Offset: 0x0000F67B
		public static IntPtr Baselib_Memory_AlignedAllocate(UIntPtr size, UIntPtr alignment)
		{
			return Binding.Baselib_Memory_AlignedAllocateDelegateField(size, alignment);
		}

		// Token: 0x06002C78 RID: 11384 RVA: 0x00011489 File Offset: 0x0000F689
		public static IntPtr Baselib_Memory_AlignedReallocate(IntPtr ptr, UIntPtr newSize, UIntPtr alignment)
		{
			return Binding.Baselib_Memory_AlignedReallocateDelegateField(ptr, newSize, alignment);
		}

		// Token: 0x06002C79 RID: 11385 RVA: 0x00011498 File Offset: 0x0000F698
		public static void Baselib_Memory_AlignedFree(IntPtr ptr)
		{
			Binding.Baselib_Memory_AlignedFreeDelegateField(ptr);
		}

		// Token: 0x06002C7A RID: 11386 RVA: 0x000B2760 File Offset: 0x000B0960
		public static Binding.Baselib_RegisteredNetwork_Endpoint Baselib_RegisteredNetwork_Endpoint_Empty()
		{
			Binding.Baselib_RegisteredNetwork_Endpoint baselib_RegisteredNetwork_Endpoint;
			Binding.Baselib_RegisteredNetwork_Endpoint_Empty_Injected(out baselib_RegisteredNetwork_Endpoint);
			return baselib_RegisteredNetwork_Endpoint;
		}

		// Token: 0x06002C7B RID: 11387 RVA: 0x000114A5 File Offset: 0x0000F6A5
		public static void Baselib_Thread_YieldExecution()
		{
			Binding.Baselib_Thread_YieldExecutionDelegateField();
		}

		// Token: 0x06002C7C RID: 11388 RVA: 0x000114B1 File Offset: 0x0000F6B1
		public static IntPtr Baselib_Thread_GetCurrentThreadId()
		{
			return Binding.Baselib_Thread_GetCurrentThreadIdDelegateField();
		}

		// Token: 0x06002C7D RID: 11389 RVA: 0x000114BD File Offset: 0x0000F6BD
		public static UIntPtr Baselib_TLS_Alloc()
		{
			return Binding.Baselib_TLS_AllocDelegateField();
		}

		// Token: 0x06002C7E RID: 11390 RVA: 0x000114C9 File Offset: 0x0000F6C9
		public static void Baselib_TLS_Free(UIntPtr handle)
		{
			Binding.Baselib_TLS_FreeDelegateField(handle);
		}

		// Token: 0x06002C7F RID: 11391 RVA: 0x000114D6 File Offset: 0x0000F6D6
		public static void Baselib_TLS_Set(UIntPtr handle, UIntPtr value)
		{
			Binding.Baselib_TLS_SetDelegateField(handle, value);
		}

		// Token: 0x06002C80 RID: 11392 RVA: 0x000114E4 File Offset: 0x0000F6E4
		public static UIntPtr Baselib_TLS_Get(UIntPtr handle)
		{
			return Binding.Baselib_TLS_GetDelegateField(handle);
		}

		// Token: 0x06002C81 RID: 11393 RVA: 0x000114F1 File Offset: 0x0000F6F1
		public static ulong Baselib_Timer_GetHighPrecisionTimerTicks()
		{
			return Binding.Baselib_Timer_GetHighPrecisionTimerTicksDelegateField();
		}

		// Token: 0x06002C82 RID: 11394 RVA: 0x000114FD File Offset: 0x0000F6FD
		public static void Baselib_Timer_WaitForAtLeast(uint timeInMilliseconds)
		{
			Binding.Baselib_Timer_WaitForAtLeastDelegateField(timeInMilliseconds);
		}

		// Token: 0x06002C83 RID: 11395 RVA: 0x0001150A File Offset: 0x0000F70A
		public static double Baselib_Timer_GetTimeSinceStartupInSeconds()
		{
			return Binding.Baselib_Timer_GetTimeSinceStartupInSecondsDelegateField();
		}

		// Token: 0x06002C84 RID: 11396 RVA: 0x00011516 File Offset: 0x0000F716
		public static void Baselib_RegisteredNetwork_Endpoint_Empty_Injected(out Binding.Baselib_RegisteredNetwork_Endpoint ret)
		{
			Binding.Baselib_RegisteredNetwork_Endpoint_Empty_InjectedDelegateField(out ret);
		}

		// Token: 0x040027C0 RID: 10176
		public const uint Baselib_NetworkAddress_IpMaxStringLength = 46U;

		// Token: 0x040027C1 RID: 10177
		public const uint Baselib_RegisteredNetwork_Endpoint_MaxSize = 28U;

		// Token: 0x040027C2 RID: 10178
		public const uint Baselib_TLS_MinimumGuaranteedSlots = 100U;

		// Token: 0x040027C3 RID: 10179
		public const ulong Baselib_SecondsPerMinute = 60UL;

		// Token: 0x040027C4 RID: 10180
		public const ulong Baselib_MillisecondsPerSecond = 1000UL;

		// Token: 0x040027C5 RID: 10181
		public const ulong Baselib_MillisecondsPerMinute = 60000UL;

		// Token: 0x040027C6 RID: 10182
		public const ulong Baselib_MicrosecondsPerMillisecond = 1000UL;

		// Token: 0x040027C7 RID: 10183
		public const ulong Baselib_MicrosecondsPerSecond = 1000000UL;

		// Token: 0x040027C8 RID: 10184
		public const ulong Baselib_MicrosecondsPerMinute = 60000000UL;

		// Token: 0x040027C9 RID: 10185
		public const ulong Baselib_NanosecondsPerMicrosecond = 1000UL;

		// Token: 0x040027CA RID: 10186
		public const ulong Baselib_NanosecondsPerMillisecond = 1000000UL;

		// Token: 0x040027CB RID: 10187
		public const ulong Baselib_NanosecondsPerSecond = 1000000000UL;

		// Token: 0x040027CC RID: 10188
		public const ulong Baselib_NanosecondsPerMinute = 60000000000UL;

		// Token: 0x040027CD RID: 10189
		public const ulong Baselib_Timer_MaxNumberOfNanosecondsPerTick = 1000UL;

		// Token: 0x040027CE RID: 10190
		public const double Baselib_Timer_MinNumberOfNanosecondsPerTick = 0.01;

		// Token: 0x040027CF RID: 10191
		public const double Baselib_Timer_HighPrecisionTimerCrossThreadMontotonyTolerance_InNanoseconds = 100.0;

		// Token: 0x040027D0 RID: 10192
		private static readonly Binding.Baselib_Memory_AllocateDelegate Baselib_Memory_AllocateDelegateField = IL2CPP.ResolveICall<Binding.Baselib_Memory_AllocateDelegate>("Unity.Baselib.LowLevel.Binding::Baselib_Memory_Allocate");

		// Token: 0x040027D1 RID: 10193
		private static readonly Binding.Baselib_Memory_ReallocateDelegate Baselib_Memory_ReallocateDelegateField = IL2CPP.ResolveICall<Binding.Baselib_Memory_ReallocateDelegate>("Unity.Baselib.LowLevel.Binding::Baselib_Memory_Reallocate");

		// Token: 0x040027D2 RID: 10194
		private static readonly Binding.Baselib_Memory_FreeDelegate Baselib_Memory_FreeDelegateField = IL2CPP.ResolveICall<Binding.Baselib_Memory_FreeDelegate>("Unity.Baselib.LowLevel.Binding::Baselib_Memory_Free");

		// Token: 0x040027D3 RID: 10195
		private static readonly Binding.Baselib_Memory_AlignedAllocateDelegate Baselib_Memory_AlignedAllocateDelegateField = IL2CPP.ResolveICall<Binding.Baselib_Memory_AlignedAllocateDelegate>("Unity.Baselib.LowLevel.Binding::Baselib_Memory_AlignedAllocate");

		// Token: 0x040027D4 RID: 10196
		private static readonly Binding.Baselib_Memory_AlignedReallocateDelegate Baselib_Memory_AlignedReallocateDelegateField = IL2CPP.ResolveICall<Binding.Baselib_Memory_AlignedReallocateDelegate>("Unity.Baselib.LowLevel.Binding::Baselib_Memory_AlignedReallocate");

		// Token: 0x040027D5 RID: 10197
		private static readonly Binding.Baselib_Memory_AlignedFreeDelegate Baselib_Memory_AlignedFreeDelegateField = IL2CPP.ResolveICall<Binding.Baselib_Memory_AlignedFreeDelegate>("Unity.Baselib.LowLevel.Binding::Baselib_Memory_AlignedFree");

		// Token: 0x040027D6 RID: 10198
		private static readonly Binding.Baselib_Thread_YieldExecutionDelegate Baselib_Thread_YieldExecutionDelegateField = IL2CPP.ResolveICall<Binding.Baselib_Thread_YieldExecutionDelegate>("Unity.Baselib.LowLevel.Binding::Baselib_Thread_YieldExecution");

		// Token: 0x040027D7 RID: 10199
		private static readonly Binding.Baselib_Thread_GetCurrentThreadIdDelegate Baselib_Thread_GetCurrentThreadIdDelegateField = IL2CPP.ResolveICall<Binding.Baselib_Thread_GetCurrentThreadIdDelegate>("Unity.Baselib.LowLevel.Binding::Baselib_Thread_GetCurrentThreadId");

		// Token: 0x040027D8 RID: 10200
		private static readonly Binding.Baselib_TLS_AllocDelegate Baselib_TLS_AllocDelegateField = IL2CPP.ResolveICall<Binding.Baselib_TLS_AllocDelegate>("Unity.Baselib.LowLevel.Binding::Baselib_TLS_Alloc");

		// Token: 0x040027D9 RID: 10201
		private static readonly Binding.Baselib_TLS_FreeDelegate Baselib_TLS_FreeDelegateField = IL2CPP.ResolveICall<Binding.Baselib_TLS_FreeDelegate>("Unity.Baselib.LowLevel.Binding::Baselib_TLS_Free");

		// Token: 0x040027DA RID: 10202
		private static readonly Binding.Baselib_TLS_SetDelegate Baselib_TLS_SetDelegateField = IL2CPP.ResolveICall<Binding.Baselib_TLS_SetDelegate>("Unity.Baselib.LowLevel.Binding::Baselib_TLS_Set");

		// Token: 0x040027DB RID: 10203
		private static readonly Binding.Baselib_TLS_GetDelegate Baselib_TLS_GetDelegateField = IL2CPP.ResolveICall<Binding.Baselib_TLS_GetDelegate>("Unity.Baselib.LowLevel.Binding::Baselib_TLS_Get");

		// Token: 0x040027DC RID: 10204
		private static readonly Binding.Baselib_Timer_GetHighPrecisionTimerTicksDelegate Baselib_Timer_GetHighPrecisionTimerTicksDelegateField = IL2CPP.ResolveICall<Binding.Baselib_Timer_GetHighPrecisionTimerTicksDelegate>("Unity.Baselib.LowLevel.Binding::Baselib_Timer_GetHighPrecisionTimerTicks");

		// Token: 0x040027DD RID: 10205
		private static readonly Binding.Baselib_Timer_WaitForAtLeastDelegate Baselib_Timer_WaitForAtLeastDelegateField = IL2CPP.ResolveICall<Binding.Baselib_Timer_WaitForAtLeastDelegate>("Unity.Baselib.LowLevel.Binding::Baselib_Timer_WaitForAtLeast");

		// Token: 0x040027DE RID: 10206
		private static readonly Binding.Baselib_Timer_GetTimeSinceStartupInSecondsDelegate Baselib_Timer_GetTimeSinceStartupInSecondsDelegateField = IL2CPP.ResolveICall<Binding.Baselib_Timer_GetTimeSinceStartupInSecondsDelegate>("Unity.Baselib.LowLevel.Binding::Baselib_Timer_GetTimeSinceStartupInSeconds");

		// Token: 0x040027DF RID: 10207
		private static readonly Binding.Baselib_RegisteredNetwork_Endpoint_Empty_InjectedDelegate Baselib_RegisteredNetwork_Endpoint_Empty_InjectedDelegateField = IL2CPP.ResolveICall<Binding.Baselib_RegisteredNetwork_Endpoint_Empty_InjectedDelegate>("Unity.Baselib.LowLevel.Binding::Baselib_RegisteredNetwork_Endpoint_Empty_Injected");

		// Token: 0x02000AAF RID: 2735
		public enum Baselib_ErrorCode
		{
			// Token: 0x04002D5E RID: 11614
			Success,
			// Token: 0x04002D5F RID: 11615
			OutOfMemory = 16777216,
			// Token: 0x04002D60 RID: 11616
			OutOfSystemResources,
			// Token: 0x04002D61 RID: 11617
			InvalidAddressRange,
			// Token: 0x04002D62 RID: 11618
			InvalidArgument,
			// Token: 0x04002D63 RID: 11619
			InvalidBufferSize,
			// Token: 0x04002D64 RID: 11620
			InvalidState,
			// Token: 0x04002D65 RID: 11621
			NotSupported,
			// Token: 0x04002D66 RID: 11622
			Timeout,
			// Token: 0x04002D67 RID: 11623
			UnsupportedAlignment = 33554432,
			// Token: 0x04002D68 RID: 11624
			InvalidPageSize,
			// Token: 0x04002D69 RID: 11625
			InvalidPageCount,
			// Token: 0x04002D6A RID: 11626
			UnsupportedPageState,
			// Token: 0x04002D6B RID: 11627
			ThreadCannotJoinSelf = 50331648,
			// Token: 0x04002D6C RID: 11628
			NetworkInitializationError = 67108864,
			// Token: 0x04002D6D RID: 11629
			AddressInUse,
			// Token: 0x04002D6E RID: 11630
			AddressUnreachable,
			// Token: 0x04002D6F RID: 11631
			AddressFamilyNotSupported,
			// Token: 0x04002D70 RID: 11632
			Disconnected,
			// Token: 0x04002D71 RID: 11633
			InvalidPathname = 83886080,
			// Token: 0x04002D72 RID: 11634
			RequestedAccessIsNotAllowed,
			// Token: 0x04002D73 RID: 11635
			IOError,
			// Token: 0x04002D74 RID: 11636
			FailedToOpenDynamicLibrary = 100663296,
			// Token: 0x04002D75 RID: 11637
			FunctionNotFound,
			// Token: 0x04002D76 RID: 11638
			UnexpectedError = -1
		}

		// Token: 0x02000AB0 RID: 2736
		public enum Baselib_ErrorState_NativeErrorCodeType : byte
		{
			// Token: 0x04002D78 RID: 11640
			None,
			// Token: 0x04002D79 RID: 11641
			PlatformDefined
		}

		// Token: 0x02000AB1 RID: 2737
		public enum Baselib_ErrorState_ExtraInformationType : byte
		{
			// Token: 0x04002D7B RID: 11643
			None,
			// Token: 0x04002D7C RID: 11644
			StaticString,
			// Token: 0x04002D7D RID: 11645
			GenerationCounter
		}

		// Token: 0x02000AB2 RID: 2738
		public enum Baselib_ErrorState_ExplainVerbosity
		{
			// Token: 0x04002D7F RID: 11647
			ErrorType,
			// Token: 0x04002D80 RID: 11648
			ErrorType_SourceLocation_Explanation
		}

		// Token: 0x02000AB3 RID: 2739
		public enum Baselib_FileIO_OpenFlags : uint
		{
			// Token: 0x04002D82 RID: 11650
			Read = 1U,
			// Token: 0x04002D83 RID: 11651
			Write,
			// Token: 0x04002D84 RID: 11652
			OpenAlways = 4U,
			// Token: 0x04002D85 RID: 11653
			CreateAlways = 8U
		}

		// Token: 0x02000AB4 RID: 2740
		public enum Baselib_FileIO_Priority
		{
			// Token: 0x04002D87 RID: 11655
			Normal,
			// Token: 0x04002D88 RID: 11656
			High
		}

		// Token: 0x02000AB5 RID: 2741
		public enum Baselib_FileIO_EventQueue_ResultType
		{
			// Token: 0x04002D8A RID: 11658
			Baselib_FileIO_EventQueue_Callback = 1,
			// Token: 0x04002D8B RID: 11659
			Baselib_FileIO_EventQueue_OpenFile,
			// Token: 0x04002D8C RID: 11660
			Baselib_FileIO_EventQueue_ReadFile,
			// Token: 0x04002D8D RID: 11661
			Baselib_FileIO_EventQueue_CloseFile
		}

		// Token: 0x02000AB6 RID: 2742
		public enum Baselib_Memory_PageState
		{
			// Token: 0x04002D8F RID: 11663
			Reserved,
			// Token: 0x04002D90 RID: 11664
			NoAccess,
			// Token: 0x04002D91 RID: 11665
			ReadOnly,
			// Token: 0x04002D92 RID: 11666
			ReadWrite = 4,
			// Token: 0x04002D93 RID: 11667
			ReadOnly_Executable = 18,
			// Token: 0x04002D94 RID: 11668
			ReadWrite_Executable = 20
		}

		// Token: 0x02000AB7 RID: 2743
		public enum Baselib_NetworkAddress_Family
		{
			// Token: 0x04002D96 RID: 11670
			Invalid,
			// Token: 0x04002D97 RID: 11671
			IPv4,
			// Token: 0x04002D98 RID: 11672
			IPv6
		}

		// Token: 0x02000AB8 RID: 2744
		public enum Baselib_NetworkAddress_AddressReuse
		{
			// Token: 0x04002D9A RID: 11674
			DoNotAllow,
			// Token: 0x04002D9B RID: 11675
			Allow
		}

		// Token: 0x02000AB9 RID: 2745
		public struct Baselib_RegisteredNetwork_Endpoint
		{
		}

		// Token: 0x02000ABA RID: 2746
		public enum Baselib_RegisteredNetwork_CompletionStatus
		{
			// Token: 0x04002D9D RID: 11677
			Failed,
			// Token: 0x04002D9E RID: 11678
			Success
		}

		// Token: 0x02000ABB RID: 2747
		public enum Baselib_RegisteredNetwork_ProcessStatus
		{
			// Token: 0x04002DA0 RID: 11680
			NonePendingImmediately,
			// Token: 0x04002DA1 RID: 11681
			Done = 0,
			// Token: 0x04002DA2 RID: 11682
			Pending
		}

		// Token: 0x02000ABC RID: 2748
		public enum Baselib_RegisteredNetwork_CompletionQueueStatus
		{
			// Token: 0x04002DA4 RID: 11684
			NoResultsAvailable,
			// Token: 0x04002DA5 RID: 11685
			ResultsAvailable
		}

		// Token: 0x02000ABD RID: 2749
		public enum Baselib_Socket_Protocol
		{
			// Token: 0x04002DA7 RID: 11687
			UDP = 1,
			// Token: 0x04002DA8 RID: 11688
			TCP
		}

		// Token: 0x02000ABE RID: 2750
		public enum Baselib_Socket_PollEvents
		{
			// Token: 0x04002DAA RID: 11690
			Readable = 1,
			// Token: 0x04002DAB RID: 11691
			Writable,
			// Token: 0x04002DAC RID: 11692
			Connected = 4
		}

		// Token: 0x02000ABF RID: 2751
		// (Invoke) Token: 0x06003E77 RID: 15991
		private delegate IntPtr Baselib_Memory_AllocateDelegate(UIntPtr size);

		// Token: 0x02000AC0 RID: 2752
		// (Invoke) Token: 0x06003E79 RID: 15993
		private delegate IntPtr Baselib_Memory_ReallocateDelegate(IntPtr ptr, UIntPtr newSize);

		// Token: 0x02000AC1 RID: 2753
		// (Invoke) Token: 0x06003E7B RID: 15995
		private delegate void Baselib_Memory_FreeDelegate(IntPtr ptr);

		// Token: 0x02000AC2 RID: 2754
		// (Invoke) Token: 0x06003E7D RID: 15997
		private delegate IntPtr Baselib_Memory_AlignedAllocateDelegate(UIntPtr size, UIntPtr alignment);

		// Token: 0x02000AC3 RID: 2755
		// (Invoke) Token: 0x06003E7F RID: 15999
		private delegate IntPtr Baselib_Memory_AlignedReallocateDelegate(IntPtr ptr, UIntPtr newSize, UIntPtr alignment);

		// Token: 0x02000AC4 RID: 2756
		// (Invoke) Token: 0x06003E81 RID: 16001
		private delegate void Baselib_Memory_AlignedFreeDelegate(IntPtr ptr);

		// Token: 0x02000AC5 RID: 2757
		// (Invoke) Token: 0x06003E83 RID: 16003
		private delegate void Baselib_Thread_YieldExecutionDelegate();

		// Token: 0x02000AC6 RID: 2758
		// (Invoke) Token: 0x06003E85 RID: 16005
		private delegate IntPtr Baselib_Thread_GetCurrentThreadIdDelegate();

		// Token: 0x02000AC7 RID: 2759
		// (Invoke) Token: 0x06003E87 RID: 16007
		private delegate UIntPtr Baselib_TLS_AllocDelegate();

		// Token: 0x02000AC8 RID: 2760
		// (Invoke) Token: 0x06003E89 RID: 16009
		private delegate void Baselib_TLS_FreeDelegate(UIntPtr handle);

		// Token: 0x02000AC9 RID: 2761
		// (Invoke) Token: 0x06003E8B RID: 16011
		private delegate void Baselib_TLS_SetDelegate(UIntPtr handle, UIntPtr value);

		// Token: 0x02000ACA RID: 2762
		// (Invoke) Token: 0x06003E8D RID: 16013
		private delegate UIntPtr Baselib_TLS_GetDelegate(UIntPtr handle);

		// Token: 0x02000ACB RID: 2763
		// (Invoke) Token: 0x06003E8F RID: 16015
		private delegate ulong Baselib_Timer_GetHighPrecisionTimerTicksDelegate();

		// Token: 0x02000ACC RID: 2764
		// (Invoke) Token: 0x06003E91 RID: 16017
		private delegate void Baselib_Timer_WaitForAtLeastDelegate(uint timeInMilliseconds);

		// Token: 0x02000ACD RID: 2765
		// (Invoke) Token: 0x06003E93 RID: 16019
		private delegate double Baselib_Timer_GetTimeSinceStartupInSecondsDelegate();

		// Token: 0x02000ACE RID: 2766
		// (Invoke) Token: 0x06003E95 RID: 16021
		private delegate void Baselib_RegisteredNetwork_Endpoint_Empty_InjectedDelegate([Out] IntPtr ret);
	}
}
