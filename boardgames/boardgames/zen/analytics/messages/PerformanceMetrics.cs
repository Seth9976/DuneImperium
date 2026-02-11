using System;
using dwd.core.session;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace zen.analytics.messages
{
	// Token: 0x0200009B RID: 155
	public class PerformanceMetrics : MonoBehaviour
	{
		// Token: 0x06000773 RID: 1907 RVA: 0x00028840 File Offset: 0x00026A40
		// Note: this type is marked as 'beforefieldinit'.
		static PerformanceMetrics()
		{
			Il2CppClassPointerStore<PerformanceMetrics>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "zen.analytics.messages", "PerformanceMetrics");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PerformanceMetrics>.NativeClassPtr);
			PerformanceMetrics.NativeFieldInfoPtr_sendOnSeconds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PerformanceMetrics>.NativeClassPtr, "sendOnSeconds");
			PerformanceMetrics.NativeFieldInfoPtr_lastSent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PerformanceMetrics>.NativeClassPtr, "lastSent");
			PerformanceMetrics.NativeFieldInfoPtr_periodicFrameRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PerformanceMetrics>.NativeClassPtr, "periodicFrameRate");
			PerformanceMetrics.NativeFieldInfoPtr_periodicLowMemory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PerformanceMetrics>.NativeClassPtr, "periodicLowMemory");
			PerformanceMetrics.NativeFieldInfoPtr_periodicHighMemory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PerformanceMetrics>.NativeClassPtr, "periodicHighMemory");
			PerformanceMetrics.NativeFieldInfoPtr_sceneFrameRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PerformanceMetrics>.NativeClassPtr, "sceneFrameRate");
			PerformanceMetrics.NativeFieldInfoPtr_sceneNextPreLoadMemory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PerformanceMetrics>.NativeClassPtr, "sceneNextPreLoadMemory");
			PerformanceMetrics.NativeFieldInfoPtr_scenePreLoadMemory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PerformanceMetrics>.NativeClassPtr, "scenePreLoadMemory");
			PerformanceMetrics.NativeFieldInfoPtr_scenePreUnloadMemory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PerformanceMetrics>.NativeClassPtr, "scenePreUnloadMemory");
			PerformanceMetrics.NativeFieldInfoPtr_scenePostUnloadMemory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PerformanceMetrics>.NativeClassPtr, "scenePostUnloadMemory");
			PerformanceMetrics.NativeFieldInfoPtr_scenePostLoadMemory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PerformanceMetrics>.NativeClassPtr, "scenePostLoadMemory");
			PerformanceMetrics.NativeFieldInfoPtr_session = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PerformanceMetrics>.NativeClassPtr, "session");
			PerformanceMetrics.NativeFieldInfoPtr_analyticsManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PerformanceMetrics>.NativeClassPtr, "analyticsManager");
			PerformanceMetrics.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PerformanceMetrics>.NativeClassPtr, 100664494);
			PerformanceMetrics.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PerformanceMetrics>.NativeClassPtr, 100664495);
			PerformanceMetrics.NativeMethodInfoPtr_RefreshAnalyticsManager_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PerformanceMetrics>.NativeClassPtr, 100664496);
			PerformanceMetrics.NativeMethodInfoPtr_SendPeriodicAnalytics_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PerformanceMetrics>.NativeClassPtr, 100664497);
			PerformanceMetrics.NativeMethodInfoPtr_SendSceneChangeAnalytics_Public_Void_String_String_AnalyticsSceneChangeStart_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PerformanceMetrics>.NativeClassPtr, 100664498);
			PerformanceMetrics.NativeMethodInfoPtr_UpdateScenePreUnloadMemory_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PerformanceMetrics>.NativeClassPtr, 100664499);
			PerformanceMetrics.NativeMethodInfoPtr_UpdateScenePostUnloadMemory_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PerformanceMetrics>.NativeClassPtr, 100664500);
			PerformanceMetrics.NativeMethodInfoPtr_UpdateNextScenePreLoadMemory_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PerformanceMetrics>.NativeClassPtr, 100664501);
			PerformanceMetrics.NativeMethodInfoPtr_UpdateScenePostLoadMemory_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PerformanceMetrics>.NativeClassPtr, 100664502);
			PerformanceMetrics.NativeMethodInfoPtr_MemoryInMegabytes_Private_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PerformanceMetrics>.NativeClassPtr, 100664503);
			PerformanceMetrics.NativeMethodInfoPtr_ResetPeriodicMetrics_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PerformanceMetrics>.NativeClassPtr, 100664504);
			PerformanceMetrics.NativeMethodInfoPtr_ResetSceneMetrics_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PerformanceMetrics>.NativeClassPtr, 100664505);
			PerformanceMetrics.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PerformanceMetrics>.NativeClassPtr, 100664506);
		}

		// Token: 0x06000774 RID: 1908 RVA: 0x00028A78 File Offset: 0x00026C78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 990843, XrefRangeEnd = 990851, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PerformanceMetrics.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000775 RID: 1909 RVA: 0x00028AAC File Offset: 0x00026CAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 990851, XrefRangeEnd = 990852, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PerformanceMetrics.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000776 RID: 1910 RVA: 0x00028AE0 File Offset: 0x00026CE0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 990860, RefRangeEnd = 990862, XrefRangeStart = 990852, XrefRangeEnd = 990860, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RefreshAnalyticsManager()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PerformanceMetrics.NativeMethodInfoPtr_RefreshAnalyticsManager_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000777 RID: 1911 RVA: 0x00028B14 File Offset: 0x00026D14
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 990868, RefRangeEnd = 990870, XrefRangeStart = 990862, XrefRangeEnd = 990868, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendPeriodicAnalytics(bool forceSend)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref forceSend;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PerformanceMetrics.NativeMethodInfoPtr_SendPeriodicAnalytics_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000778 RID: 1912 RVA: 0x00028B54 File Offset: 0x00026D54
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 990877, RefRangeEnd = 990878, XrefRangeStart = 990870, XrefRangeEnd = 990877, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendSceneChangeAnalytics(string leavingScene, string enteringScene, AnalyticsSceneChangeStart sceneChangeStart)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(leavingScene);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(enteringScene);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(sceneChangeStart);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PerformanceMetrics.NativeMethodInfoPtr_SendSceneChangeAnalytics_Public_Void_String_String_AnalyticsSceneChangeStart_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000779 RID: 1913 RVA: 0x00028BBC File Offset: 0x00026DBC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 990881, RefRangeEnd = 990882, XrefRangeStart = 990878, XrefRangeEnd = 990881, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateScenePreUnloadMemory()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PerformanceMetrics.NativeMethodInfoPtr_UpdateScenePreUnloadMemory_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600077A RID: 1914 RVA: 0x00028BF0 File Offset: 0x00026DF0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 990884, RefRangeEnd = 990885, XrefRangeStart = 990882, XrefRangeEnd = 990884, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateScenePostUnloadMemory()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PerformanceMetrics.NativeMethodInfoPtr_UpdateScenePostUnloadMemory_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600077B RID: 1915 RVA: 0x00028C24 File Offset: 0x00026E24
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 990887, RefRangeEnd = 990888, XrefRangeStart = 990885, XrefRangeEnd = 990887, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateNextScenePreLoadMemory()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PerformanceMetrics.NativeMethodInfoPtr_UpdateNextScenePreLoadMemory_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600077C RID: 1916 RVA: 0x00028C58 File Offset: 0x00026E58
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 990890, RefRangeEnd = 990891, XrefRangeStart = 990888, XrefRangeEnd = 990890, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateScenePostLoadMemory()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PerformanceMetrics.NativeMethodInfoPtr_UpdateScenePostLoadMemory_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600077D RID: 1917 RVA: 0x00028C8C File Offset: 0x00026E8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 990891, XrefRangeEnd = 990893, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float MemoryInMegabytes()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PerformanceMetrics.NativeMethodInfoPtr_MemoryInMegabytes_Private_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600077E RID: 1918 RVA: 0x00028CC8 File Offset: 0x00026EC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 990893, XrefRangeEnd = 990894, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResetPeriodicMetrics()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PerformanceMetrics.NativeMethodInfoPtr_ResetPeriodicMetrics_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600077F RID: 1919 RVA: 0x00028CFC File Offset: 0x00026EFC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 990895, RefRangeEnd = 990897, XrefRangeStart = 990894, XrefRangeEnd = 990895, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResetSceneMetrics()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PerformanceMetrics.NativeMethodInfoPtr_ResetSceneMetrics_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000780 RID: 1920 RVA: 0x00028D30 File Offset: 0x00026F30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 990897, XrefRangeEnd = 990907, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PerformanceMetrics()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PerformanceMetrics>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PerformanceMetrics.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000781 RID: 1921 RVA: 0x0000556F File Offset: 0x0000376F
		public PerformanceMetrics(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000200 RID: 512
		// (get) Token: 0x06000782 RID: 1922 RVA: 0x00028D6C File Offset: 0x00026F6C
		// (set) Token: 0x06000783 RID: 1923 RVA: 0x00005578 File Offset: 0x00003778
		public unsafe int sendOnSeconds
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PerformanceMetrics.NativeFieldInfoPtr_sendOnSeconds);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PerformanceMetrics.NativeFieldInfoPtr_sendOnSeconds)) = value;
			}
		}

		// Token: 0x17000201 RID: 513
		// (get) Token: 0x06000784 RID: 1924 RVA: 0x00028D94 File Offset: 0x00026F94
		// (set) Token: 0x06000785 RID: 1925 RVA: 0x00005593 File Offset: 0x00003793
		public unsafe float lastSent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PerformanceMetrics.NativeFieldInfoPtr_lastSent);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PerformanceMetrics.NativeFieldInfoPtr_lastSent)) = value;
			}
		}

		// Token: 0x17000202 RID: 514
		// (get) Token: 0x06000786 RID: 1926 RVA: 0x00028DBC File Offset: 0x00026FBC
		// (set) Token: 0x06000787 RID: 1927 RVA: 0x000055AE File Offset: 0x000037AE
		public unsafe AveragedPerformanceMetric periodicFrameRate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PerformanceMetrics.NativeFieldInfoPtr_periodicFrameRate);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AveragedPerformanceMetric>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PerformanceMetrics.NativeFieldInfoPtr_periodicFrameRate), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000203 RID: 515
		// (get) Token: 0x06000788 RID: 1928 RVA: 0x00028DEC File Offset: 0x00026FEC
		// (set) Token: 0x06000789 RID: 1929 RVA: 0x000055CD File Offset: 0x000037CD
		public unsafe float periodicLowMemory
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PerformanceMetrics.NativeFieldInfoPtr_periodicLowMemory);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PerformanceMetrics.NativeFieldInfoPtr_periodicLowMemory)) = value;
			}
		}

		// Token: 0x17000204 RID: 516
		// (get) Token: 0x0600078A RID: 1930 RVA: 0x00028E14 File Offset: 0x00027014
		// (set) Token: 0x0600078B RID: 1931 RVA: 0x000055E8 File Offset: 0x000037E8
		public unsafe float periodicHighMemory
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PerformanceMetrics.NativeFieldInfoPtr_periodicHighMemory);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PerformanceMetrics.NativeFieldInfoPtr_periodicHighMemory)) = value;
			}
		}

		// Token: 0x17000205 RID: 517
		// (get) Token: 0x0600078C RID: 1932 RVA: 0x00028E3C File Offset: 0x0002703C
		// (set) Token: 0x0600078D RID: 1933 RVA: 0x00005603 File Offset: 0x00003803
		public unsafe AveragedPerformanceMetric sceneFrameRate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PerformanceMetrics.NativeFieldInfoPtr_sceneFrameRate);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AveragedPerformanceMetric>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PerformanceMetrics.NativeFieldInfoPtr_sceneFrameRate), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000206 RID: 518
		// (get) Token: 0x0600078E RID: 1934 RVA: 0x00028E6C File Offset: 0x0002706C
		// (set) Token: 0x0600078F RID: 1935 RVA: 0x00005622 File Offset: 0x00003822
		public unsafe float sceneNextPreLoadMemory
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PerformanceMetrics.NativeFieldInfoPtr_sceneNextPreLoadMemory);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PerformanceMetrics.NativeFieldInfoPtr_sceneNextPreLoadMemory)) = value;
			}
		}

		// Token: 0x17000207 RID: 519
		// (get) Token: 0x06000790 RID: 1936 RVA: 0x00028E94 File Offset: 0x00027094
		// (set) Token: 0x06000791 RID: 1937 RVA: 0x0000563D File Offset: 0x0000383D
		public unsafe float scenePreLoadMemory
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PerformanceMetrics.NativeFieldInfoPtr_scenePreLoadMemory);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PerformanceMetrics.NativeFieldInfoPtr_scenePreLoadMemory)) = value;
			}
		}

		// Token: 0x17000208 RID: 520
		// (get) Token: 0x06000792 RID: 1938 RVA: 0x00028EBC File Offset: 0x000270BC
		// (set) Token: 0x06000793 RID: 1939 RVA: 0x00005658 File Offset: 0x00003858
		public unsafe float scenePreUnloadMemory
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PerformanceMetrics.NativeFieldInfoPtr_scenePreUnloadMemory);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PerformanceMetrics.NativeFieldInfoPtr_scenePreUnloadMemory)) = value;
			}
		}

		// Token: 0x17000209 RID: 521
		// (get) Token: 0x06000794 RID: 1940 RVA: 0x00028EE4 File Offset: 0x000270E4
		// (set) Token: 0x06000795 RID: 1941 RVA: 0x00005673 File Offset: 0x00003873
		public unsafe float scenePostUnloadMemory
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PerformanceMetrics.NativeFieldInfoPtr_scenePostUnloadMemory);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PerformanceMetrics.NativeFieldInfoPtr_scenePostUnloadMemory)) = value;
			}
		}

		// Token: 0x1700020A RID: 522
		// (get) Token: 0x06000796 RID: 1942 RVA: 0x00028F0C File Offset: 0x0002710C
		// (set) Token: 0x06000797 RID: 1943 RVA: 0x0000568E File Offset: 0x0000388E
		public unsafe float scenePostLoadMemory
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PerformanceMetrics.NativeFieldInfoPtr_scenePostLoadMemory);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PerformanceMetrics.NativeFieldInfoPtr_scenePostLoadMemory)) = value;
			}
		}

		// Token: 0x1700020B RID: 523
		// (get) Token: 0x06000798 RID: 1944 RVA: 0x00028F34 File Offset: 0x00027134
		// (set) Token: 0x06000799 RID: 1945 RVA: 0x000056A9 File Offset: 0x000038A9
		public unsafe SessionProvider session
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PerformanceMetrics.NativeFieldInfoPtr_session);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SessionProvider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PerformanceMetrics.NativeFieldInfoPtr_session), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700020C RID: 524
		// (get) Token: 0x0600079A RID: 1946 RVA: 0x00028F64 File Offset: 0x00027164
		// (set) Token: 0x0600079B RID: 1947 RVA: 0x000056C8 File Offset: 0x000038C8
		public unsafe AnalyticsManager analyticsManager
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PerformanceMetrics.NativeFieldInfoPtr_analyticsManager);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnalyticsManager>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PerformanceMetrics.NativeFieldInfoPtr_analyticsManager), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400048C RID: 1164
		private static readonly IntPtr NativeFieldInfoPtr_sendOnSeconds;

		// Token: 0x0400048D RID: 1165
		private static readonly IntPtr NativeFieldInfoPtr_lastSent;

		// Token: 0x0400048E RID: 1166
		private static readonly IntPtr NativeFieldInfoPtr_periodicFrameRate;

		// Token: 0x0400048F RID: 1167
		private static readonly IntPtr NativeFieldInfoPtr_periodicLowMemory;

		// Token: 0x04000490 RID: 1168
		private static readonly IntPtr NativeFieldInfoPtr_periodicHighMemory;

		// Token: 0x04000491 RID: 1169
		private static readonly IntPtr NativeFieldInfoPtr_sceneFrameRate;

		// Token: 0x04000492 RID: 1170
		private static readonly IntPtr NativeFieldInfoPtr_sceneNextPreLoadMemory;

		// Token: 0x04000493 RID: 1171
		private static readonly IntPtr NativeFieldInfoPtr_scenePreLoadMemory;

		// Token: 0x04000494 RID: 1172
		private static readonly IntPtr NativeFieldInfoPtr_scenePreUnloadMemory;

		// Token: 0x04000495 RID: 1173
		private static readonly IntPtr NativeFieldInfoPtr_scenePostUnloadMemory;

		// Token: 0x04000496 RID: 1174
		private static readonly IntPtr NativeFieldInfoPtr_scenePostLoadMemory;

		// Token: 0x04000497 RID: 1175
		private static readonly IntPtr NativeFieldInfoPtr_session;

		// Token: 0x04000498 RID: 1176
		private static readonly IntPtr NativeFieldInfoPtr_analyticsManager;

		// Token: 0x04000499 RID: 1177
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x0400049A RID: 1178
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x0400049B RID: 1179
		private static readonly IntPtr NativeMethodInfoPtr_RefreshAnalyticsManager_Private_Void_0;

		// Token: 0x0400049C RID: 1180
		private static readonly IntPtr NativeMethodInfoPtr_SendPeriodicAnalytics_Private_Void_Boolean_0;

		// Token: 0x0400049D RID: 1181
		private static readonly IntPtr NativeMethodInfoPtr_SendSceneChangeAnalytics_Public_Void_String_String_AnalyticsSceneChangeStart_0;

		// Token: 0x0400049E RID: 1182
		private static readonly IntPtr NativeMethodInfoPtr_UpdateScenePreUnloadMemory_Public_Void_0;

		// Token: 0x0400049F RID: 1183
		private static readonly IntPtr NativeMethodInfoPtr_UpdateScenePostUnloadMemory_Public_Void_0;

		// Token: 0x040004A0 RID: 1184
		private static readonly IntPtr NativeMethodInfoPtr_UpdateNextScenePreLoadMemory_Public_Void_0;

		// Token: 0x040004A1 RID: 1185
		private static readonly IntPtr NativeMethodInfoPtr_UpdateScenePostLoadMemory_Public_Void_0;

		// Token: 0x040004A2 RID: 1186
		private static readonly IntPtr NativeMethodInfoPtr_MemoryInMegabytes_Private_Single_0;

		// Token: 0x040004A3 RID: 1187
		private static readonly IntPtr NativeMethodInfoPtr_ResetPeriodicMetrics_Private_Void_0;

		// Token: 0x040004A4 RID: 1188
		private static readonly IntPtr NativeMethodInfoPtr_ResetSceneMetrics_Private_Void_0;

		// Token: 0x040004A5 RID: 1189
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
