using System;
using boardgames.analytics;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace zen.analytics.messages
{
	// Token: 0x0200009A RID: 154
	public class MemoryWarningAnalyticsEvent : ClientAnalyticsMessage
	{
		// Token: 0x0600076E RID: 1902 RVA: 0x000286F0 File Offset: 0x000268F0
		// Note: this type is marked as 'beforefieldinit'.
		static MemoryWarningAnalyticsEvent()
		{
			Il2CppClassPointerStore<MemoryWarningAnalyticsEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "zen.analytics.messages", "MemoryWarningAnalyticsEvent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MemoryWarningAnalyticsEvent>.NativeClassPtr);
			MemoryWarningAnalyticsEvent.NativeMethodInfoPtr__ctor_Public_Void_MemoryCleanupEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryWarningAnalyticsEvent>.NativeClassPtr, 100664491);
			MemoryWarningAnalyticsEvent.NativeMethodInfoPtr__ctor_Public_Void_MemoryCleanupEvent_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryWarningAnalyticsEvent>.NativeClassPtr, 100664492);
			MemoryWarningAnalyticsEvent.NativeMethodInfoPtr_memoryInMegabytes_Private_Static_Single_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemoryWarningAnalyticsEvent>.NativeClassPtr, 100664493);
		}

		// Token: 0x0600076F RID: 1903 RVA: 0x0002875C File Offset: 0x0002695C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 990768, XrefRangeEnd = 990774, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MemoryWarningAnalyticsEvent(MemoryWatchdog.MemoryCleanupEvent cleanupData)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MemoryWarningAnalyticsEvent>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref cleanupData;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MemoryWarningAnalyticsEvent.NativeMethodInfoPtr__ctor_Public_Void_MemoryCleanupEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000770 RID: 1904 RVA: 0x000287A4 File Offset: 0x000269A4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 990840, RefRangeEnd = 990842, XrefRangeStart = 990774, XrefRangeEnd = 990840, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MemoryWarningAnalyticsEvent(MemoryWatchdog.MemoryCleanupEvent cleanupData, string scene)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MemoryWarningAnalyticsEvent>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref cleanupData;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(scene);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MemoryWarningAnalyticsEvent.NativeMethodInfoPtr__ctor_Public_Void_MemoryCleanupEvent_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000771 RID: 1905 RVA: 0x00028800 File Offset: 0x00026A00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 990842, XrefRangeEnd = 990843, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float memoryInMegabytes(ulong bytes)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref bytes;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MemoryWarningAnalyticsEvent.NativeMethodInfoPtr_memoryInMegabytes_Private_Static_Single_UInt64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000772 RID: 1906 RVA: 0x00005566 File Offset: 0x00003766
		public MemoryWarningAnalyticsEvent(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000489 RID: 1161
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_MemoryCleanupEvent_0;

		// Token: 0x0400048A RID: 1162
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_MemoryCleanupEvent_String_0;

		// Token: 0x0400048B RID: 1163
		private static readonly IntPtr NativeMethodInfoPtr_memoryInMegabytes_Private_Static_Single_UInt64_0;
	}
}
