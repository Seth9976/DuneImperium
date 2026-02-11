using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Concurrent;
using Il2CppSystem.Text;
using UnityEngine;

namespace Logging
{
	// Token: 0x02000081 RID: 129
	public class DeviceOutputLogProvider : MonoBehaviour
	{
		// Token: 0x0600099A RID: 2458 RVA: 0x00038548 File Offset: 0x00036748
		// Note: this type is marked as 'beforefieldinit'.
		static DeviceOutputLogProvider()
		{
			Il2CppClassPointerStore<DeviceOutputLogProvider>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "Logging", "DeviceOutputLogProvider");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DeviceOutputLogProvider>.NativeClassPtr);
			DeviceOutputLogProvider.NativeFieldInfoPtr_freshenLogsSizeMb = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeviceOutputLogProvider>.NativeClassPtr, "freshenLogsSizeMb");
			DeviceOutputLogProvider.NativeFieldInfoPtr_outputLogFrequencySec = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeviceOutputLogProvider>.NativeClassPtr, "outputLogFrequencySec");
			DeviceOutputLogProvider.NativeFieldInfoPtr_freshLogFileName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeviceOutputLogProvider>.NativeClassPtr, "freshLogFileName");
			DeviceOutputLogProvider.NativeFieldInfoPtr_staleLogFileName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeviceOutputLogProvider>.NativeClassPtr, "staleLogFileName");
			DeviceOutputLogProvider.NativeFieldInfoPtr_logsQueue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeviceOutputLogProvider>.NativeClassPtr, "logsQueue");
			DeviceOutputLogProvider.NativeFieldInfoPtr_logBuilder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeviceOutputLogProvider>.NativeClassPtr, "logBuilder");
			DeviceOutputLogProvider.NativeFieldInfoPtr_maxLogBytes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeviceOutputLogProvider>.NativeClassPtr, "maxLogBytes");
			DeviceOutputLogProvider.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeviceOutputLogProvider>.NativeClassPtr, 100664630);
			DeviceOutputLogProvider.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeviceOutputLogProvider>.NativeClassPtr, 100664631);
			DeviceOutputLogProvider.NativeMethodInfoPtr_enqueueLog_Private_Void_String_String_LogType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeviceOutputLogProvider>.NativeClassPtr, 100664632);
			DeviceOutputLogProvider.NativeMethodInfoPtr_saveOnDelay_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeviceOutputLogProvider>.NativeClassPtr, 100664633);
			DeviceOutputLogProvider.NativeMethodInfoPtr_OutputLog_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeviceOutputLogProvider>.NativeClassPtr, 100664634);
			DeviceOutputLogProvider.NativeMethodInfoPtr_FreshenLogs_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeviceOutputLogProvider>.NativeClassPtr, 100664635);
			DeviceOutputLogProvider.NativeMethodInfoPtr_ClearLogs_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeviceOutputLogProvider>.NativeClassPtr, 100664636);
			DeviceOutputLogProvider.NativeMethodInfoPtr_TryRetrieveLogs_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeviceOutputLogProvider>.NativeClassPtr, 100664637);
			DeviceOutputLogProvider.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeviceOutputLogProvider>.NativeClassPtr, 100664638);
		}

		// Token: 0x0600099B RID: 2459 RVA: 0x000386B8 File Offset: 0x000368B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 861879, XrefRangeEnd = 861907, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeviceOutputLogProvider.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600099C RID: 2460 RVA: 0x000386EC File Offset: 0x000368EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 861907, XrefRangeEnd = 861919, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeviceOutputLogProvider.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600099D RID: 2461 RVA: 0x00038720 File Offset: 0x00036920
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 861919, XrefRangeEnd = 861937, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void enqueueLog(string logMessage, string stackTrace, LogType logType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(logMessage);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(stackTrace);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref logType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeviceOutputLogProvider.NativeMethodInfoPtr_enqueueLog_Private_Void_String_String_LogType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600099E RID: 2462 RVA: 0x00038784 File Offset: 0x00036984
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 861937, XrefRangeEnd = 861942, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator saveOnDelay()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeviceOutputLogProvider.NativeMethodInfoPtr_saveOnDelay_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600099F RID: 2463 RVA: 0x000387C4 File Offset: 0x000369C4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 861949, RefRangeEnd = 861951, XrefRangeStart = 861942, XrefRangeEnd = 861949, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OutputLog()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeviceOutputLogProvider.NativeMethodInfoPtr_OutputLog_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009A0 RID: 2464 RVA: 0x000387F8 File Offset: 0x000369F8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 861958, RefRangeEnd = 861961, XrefRangeStart = 861951, XrefRangeEnd = 861958, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FreshenLogs()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeviceOutputLogProvider.NativeMethodInfoPtr_FreshenLogs_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009A1 RID: 2465 RVA: 0x0003882C File Offset: 0x00036A2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 861961, XrefRangeEnd = 861967, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearLogs()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeviceOutputLogProvider.NativeMethodInfoPtr_ClearLogs_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009A2 RID: 2466 RVA: 0x00038860 File Offset: 0x00036A60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 861967, XrefRangeEnd = 861981, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string TryRetrieveLogs()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeviceOutputLogProvider.NativeMethodInfoPtr_TryRetrieveLogs_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060009A3 RID: 2467 RVA: 0x00038898 File Offset: 0x00036A98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 861981, XrefRangeEnd = 862002, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DeviceOutputLogProvider()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DeviceOutputLogProvider>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeviceOutputLogProvider.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009A4 RID: 2468 RVA: 0x000055A1 File Offset: 0x000037A1
		public DeviceOutputLogProvider(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002B4 RID: 692
		// (get) Token: 0x060009A5 RID: 2469 RVA: 0x000388D4 File Offset: 0x00036AD4
		// (set) Token: 0x060009A6 RID: 2470 RVA: 0x000055AA File Offset: 0x000037AA
		public unsafe float freshenLogsSizeMb
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeviceOutputLogProvider.NativeFieldInfoPtr_freshenLogsSizeMb);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeviceOutputLogProvider.NativeFieldInfoPtr_freshenLogsSizeMb)) = value;
			}
		}

		// Token: 0x170002B5 RID: 693
		// (get) Token: 0x060009A7 RID: 2471 RVA: 0x000388FC File Offset: 0x00036AFC
		// (set) Token: 0x060009A8 RID: 2472 RVA: 0x000055C5 File Offset: 0x000037C5
		public unsafe float outputLogFrequencySec
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeviceOutputLogProvider.NativeFieldInfoPtr_outputLogFrequencySec);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeviceOutputLogProvider.NativeFieldInfoPtr_outputLogFrequencySec)) = value;
			}
		}

		// Token: 0x170002B6 RID: 694
		// (get) Token: 0x060009A9 RID: 2473 RVA: 0x00038924 File Offset: 0x00036B24
		// (set) Token: 0x060009AA RID: 2474 RVA: 0x000055E0 File Offset: 0x000037E0
		public unsafe string freshLogFileName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeviceOutputLogProvider.NativeFieldInfoPtr_freshLogFileName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeviceOutputLogProvider.NativeFieldInfoPtr_freshLogFileName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170002B7 RID: 695
		// (get) Token: 0x060009AB RID: 2475 RVA: 0x0003894C File Offset: 0x00036B4C
		// (set) Token: 0x060009AC RID: 2476 RVA: 0x000055FF File Offset: 0x000037FF
		public unsafe string staleLogFileName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeviceOutputLogProvider.NativeFieldInfoPtr_staleLogFileName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeviceOutputLogProvider.NativeFieldInfoPtr_staleLogFileName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170002B8 RID: 696
		// (get) Token: 0x060009AD RID: 2477 RVA: 0x00038974 File Offset: 0x00036B74
		// (set) Token: 0x060009AE RID: 2478 RVA: 0x0000561E File Offset: 0x0000381E
		public unsafe ConcurrentQueue<string> logsQueue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeviceOutputLogProvider.NativeFieldInfoPtr_logsQueue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConcurrentQueue<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeviceOutputLogProvider.NativeFieldInfoPtr_logsQueue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002B9 RID: 697
		// (get) Token: 0x060009AF RID: 2479 RVA: 0x000389A4 File Offset: 0x00036BA4
		// (set) Token: 0x060009B0 RID: 2480 RVA: 0x0000563D File Offset: 0x0000383D
		public unsafe StringBuilder logBuilder
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeviceOutputLogProvider.NativeFieldInfoPtr_logBuilder);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StringBuilder>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeviceOutputLogProvider.NativeFieldInfoPtr_logBuilder), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002BA RID: 698
		// (get) Token: 0x060009B1 RID: 2481 RVA: 0x000389D4 File Offset: 0x00036BD4
		// (set) Token: 0x060009B2 RID: 2482 RVA: 0x0000565C File Offset: 0x0000385C
		public unsafe int maxLogBytes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeviceOutputLogProvider.NativeFieldInfoPtr_maxLogBytes);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeviceOutputLogProvider.NativeFieldInfoPtr_maxLogBytes)) = value;
			}
		}

		// Token: 0x04000718 RID: 1816
		private static readonly IntPtr NativeFieldInfoPtr_freshenLogsSizeMb;

		// Token: 0x04000719 RID: 1817
		private static readonly IntPtr NativeFieldInfoPtr_outputLogFrequencySec;

		// Token: 0x0400071A RID: 1818
		private static readonly IntPtr NativeFieldInfoPtr_freshLogFileName;

		// Token: 0x0400071B RID: 1819
		private static readonly IntPtr NativeFieldInfoPtr_staleLogFileName;

		// Token: 0x0400071C RID: 1820
		private static readonly IntPtr NativeFieldInfoPtr_logsQueue;

		// Token: 0x0400071D RID: 1821
		private static readonly IntPtr NativeFieldInfoPtr_logBuilder;

		// Token: 0x0400071E RID: 1822
		private static readonly IntPtr NativeFieldInfoPtr_maxLogBytes;

		// Token: 0x0400071F RID: 1823
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04000720 RID: 1824
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04000721 RID: 1825
		private static readonly IntPtr NativeMethodInfoPtr_enqueueLog_Private_Void_String_String_LogType_0;

		// Token: 0x04000722 RID: 1826
		private static readonly IntPtr NativeMethodInfoPtr_saveOnDelay_Private_IEnumerator_0;

		// Token: 0x04000723 RID: 1827
		private static readonly IntPtr NativeMethodInfoPtr_OutputLog_Public_Void_0;

		// Token: 0x04000724 RID: 1828
		private static readonly IntPtr NativeMethodInfoPtr_FreshenLogs_Public_Void_0;

		// Token: 0x04000725 RID: 1829
		private static readonly IntPtr NativeMethodInfoPtr_ClearLogs_Public_Void_0;

		// Token: 0x04000726 RID: 1830
		private static readonly IntPtr NativeMethodInfoPtr_TryRetrieveLogs_Public_String_0;

		// Token: 0x04000727 RID: 1831
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000287 RID: 647
		[ObfuscatedName("Logging.DeviceOutputLogProvider+<saveOnDelay>d__10")]
		public sealed class _saveOnDelay_d__10 : global::Il2CppSystem.Object
		{
			// Token: 0x06001F24 RID: 7972 RVA: 0x0008DD70 File Offset: 0x0008BF70
			// Note: this type is marked as 'beforefieldinit'.
			static _saveOnDelay_d__10()
			{
				Il2CppClassPointerStore<DeviceOutputLogProvider._saveOnDelay_d__10>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DeviceOutputLogProvider>.NativeClassPtr, "<saveOnDelay>d__10");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DeviceOutputLogProvider._saveOnDelay_d__10>.NativeClassPtr);
				DeviceOutputLogProvider._saveOnDelay_d__10.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeviceOutputLogProvider._saveOnDelay_d__10>.NativeClassPtr, "<>1__state");
				DeviceOutputLogProvider._saveOnDelay_d__10.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeviceOutputLogProvider._saveOnDelay_d__10>.NativeClassPtr, "<>2__current");
				DeviceOutputLogProvider._saveOnDelay_d__10.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeviceOutputLogProvider._saveOnDelay_d__10>.NativeClassPtr, "<>4__this");
				DeviceOutputLogProvider._saveOnDelay_d__10.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeviceOutputLogProvider._saveOnDelay_d__10>.NativeClassPtr, 100664639);
				DeviceOutputLogProvider._saveOnDelay_d__10.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeviceOutputLogProvider._saveOnDelay_d__10>.NativeClassPtr, 100664640);
				DeviceOutputLogProvider._saveOnDelay_d__10.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeviceOutputLogProvider._saveOnDelay_d__10>.NativeClassPtr, 100664641);
				DeviceOutputLogProvider._saveOnDelay_d__10.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeviceOutputLogProvider._saveOnDelay_d__10>.NativeClassPtr, 100664642);
				DeviceOutputLogProvider._saveOnDelay_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeviceOutputLogProvider._saveOnDelay_d__10>.NativeClassPtr, 100664643);
				DeviceOutputLogProvider._saveOnDelay_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeviceOutputLogProvider._saveOnDelay_d__10>.NativeClassPtr, 100664644);
			}

			// Token: 0x06001F25 RID: 7973 RVA: 0x0008DE50 File Offset: 0x0008C050
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _saveOnDelay_d__10(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DeviceOutputLogProvider._saveOnDelay_d__10>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeviceOutputLogProvider._saveOnDelay_d__10.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001F26 RID: 7974 RVA: 0x0008DE98 File Offset: 0x0008C098
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeviceOutputLogProvider._saveOnDelay_d__10.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001F27 RID: 7975 RVA: 0x0008DECC File Offset: 0x0008C0CC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 861866, XrefRangeEnd = 861874, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeviceOutputLogProvider._saveOnDelay_d__10.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x1700088C RID: 2188
			// (get) Token: 0x06001F28 RID: 7976 RVA: 0x0008DF08 File Offset: 0x0008C108
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeviceOutputLogProvider._saveOnDelay_d__10.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06001F29 RID: 7977 RVA: 0x0008DF48 File Offset: 0x0008C148
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 861874, XrefRangeEnd = 861879, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeviceOutputLogProvider._saveOnDelay_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700088D RID: 2189
			// (get) Token: 0x06001F2A RID: 7978 RVA: 0x0008DF7C File Offset: 0x0008C17C
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeviceOutputLogProvider._saveOnDelay_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06001F2B RID: 7979 RVA: 0x0000D42B File Offset: 0x0000B62B
			public _saveOnDelay_d__10(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000889 RID: 2185
			// (get) Token: 0x06001F2C RID: 7980 RVA: 0x0008DFBC File Offset: 0x0008C1BC
			// (set) Token: 0x06001F2D RID: 7981 RVA: 0x0000D434 File Offset: 0x0000B634
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeviceOutputLogProvider._saveOnDelay_d__10.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeviceOutputLogProvider._saveOnDelay_d__10.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700088A RID: 2186
			// (get) Token: 0x06001F2E RID: 7982 RVA: 0x0008DFE4 File Offset: 0x0008C1E4
			// (set) Token: 0x06001F2F RID: 7983 RVA: 0x0000D44F File Offset: 0x0000B64F
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeviceOutputLogProvider._saveOnDelay_d__10.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeviceOutputLogProvider._saveOnDelay_d__10.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700088B RID: 2187
			// (get) Token: 0x06001F30 RID: 7984 RVA: 0x0008E014 File Offset: 0x0008C214
			// (set) Token: 0x06001F31 RID: 7985 RVA: 0x0000D46E File Offset: 0x0000B66E
			public unsafe DeviceOutputLogProvider __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeviceOutputLogProvider._saveOnDelay_d__10.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DeviceOutputLogProvider>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeviceOutputLogProvider._saveOnDelay_d__10.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040015E1 RID: 5601
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040015E2 RID: 5602
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040015E3 RID: 5603
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040015E4 RID: 5604
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040015E5 RID: 5605
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040015E6 RID: 5606
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040015E7 RID: 5607
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040015E8 RID: 5608
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040015E9 RID: 5609
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
