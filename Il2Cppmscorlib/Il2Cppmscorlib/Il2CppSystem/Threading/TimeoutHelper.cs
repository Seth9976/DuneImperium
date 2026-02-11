using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Threading
{
	// Token: 0x02000199 RID: 409
	public static class TimeoutHelper : Object
	{
		// Token: 0x06001A91 RID: 6801 RVA: 0x000A22FC File Offset: 0x000A04FC
		// Note: this type is marked as 'beforefieldinit'.
		static TimeoutHelper()
		{
			Il2CppClassPointerStore<TimeoutHelper>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Threading", "TimeoutHelper");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TimeoutHelper>.NativeClassPtr);
			TimeoutHelper.NativeMethodInfoPtr_GetTime_Public_Static_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeoutHelper>.NativeClassPtr, 100667913);
			TimeoutHelper.NativeMethodInfoPtr_UpdateTimeOut_Public_Static_Int32_UInt32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeoutHelper>.NativeClassPtr, 100667914);
		}

		// Token: 0x06001A92 RID: 6802 RVA: 0x000A2354 File Offset: 0x000A0554
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1352281, XrefRangeEnd = 1352282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static uint GetTime()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeoutHelper.NativeMethodInfoPtr_GetTime_Public_Static_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A93 RID: 6803 RVA: 0x000A2384 File Offset: 0x000A0584
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1352283, RefRangeEnd = 1352287, XrefRangeStart = 1352282, XrefRangeEnd = 1352283, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int UpdateTimeOut(uint startTime, int originalWaitMillisecondsTimeout)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref startTime;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref originalWaitMillisecondsTimeout;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeoutHelper.NativeMethodInfoPtr_UpdateTimeOut_Public_Static_Int32_UInt32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A94 RID: 6804 RVA: 0x00008765 File Offset: 0x00006965
		public TimeoutHelper(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001886 RID: 6278
		private static readonly IntPtr NativeMethodInfoPtr_GetTime_Public_Static_UInt32_0;

		// Token: 0x04001887 RID: 6279
		private static readonly IntPtr NativeMethodInfoPtr_UpdateTimeOut_Public_Static_Int32_UInt32_Int32_0;
	}
}
