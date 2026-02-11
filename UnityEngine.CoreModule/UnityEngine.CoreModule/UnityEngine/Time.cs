using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x0200016E RID: 366
	public class Time : Object
	{
		// Token: 0x06001B68 RID: 7016 RVA: 0x0007DAD0 File Offset: 0x0007BCD0
		// Note: this type is marked as 'beforefieldinit'.
		static Time()
		{
			Il2CppClassPointerStore<Time>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "Time");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Time>.NativeClassPtr);
			Time.NativeMethodInfoPtr_get_time_Public_Static_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Time>.NativeClassPtr, 100667039);
			Time.NativeMethodInfoPtr_get_deltaTime_Public_Static_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Time>.NativeClassPtr, 100667040);
			Time.NativeMethodInfoPtr_get_unscaledTime_Public_Static_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Time>.NativeClassPtr, 100667041);
			Time.NativeMethodInfoPtr_get_unscaledDeltaTime_Public_Static_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Time>.NativeClassPtr, 100667042);
			Time.NativeMethodInfoPtr_get_fixedDeltaTime_Public_Static_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Time>.NativeClassPtr, 100667043);
			Time.NativeMethodInfoPtr_set_fixedDeltaTime_Public_Static_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Time>.NativeClassPtr, 100667044);
			Time.NativeMethodInfoPtr_get_smoothDeltaTime_Public_Static_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Time>.NativeClassPtr, 100667045);
			Time.NativeMethodInfoPtr_get_timeScale_Public_Static_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Time>.NativeClassPtr, 100667046);
			Time.NativeMethodInfoPtr_set_timeScale_Public_Static_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Time>.NativeClassPtr, 100667047);
			Time.NativeMethodInfoPtr_get_frameCount_Public_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Time>.NativeClassPtr, 100667048);
			Time.NativeMethodInfoPtr_get_renderedFrameCount_Public_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Time>.NativeClassPtr, 100667049);
			Time.NativeMethodInfoPtr_get_realtimeSinceStartup_Public_Static_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Time>.NativeClassPtr, 100667050);
			Time.get_timeAsDoubleDelegateField = IL2CPP.ResolveICall<Time.get_timeAsDoubleDelegate>("UnityEngine.Time::get_timeAsDouble");
			Time.get_timeSinceLevelLoadDelegateField = IL2CPP.ResolveICall<Time.get_timeSinceLevelLoadDelegate>("UnityEngine.Time::get_timeSinceLevelLoad");
			Time.get_timeSinceLevelLoadAsDoubleDelegateField = IL2CPP.ResolveICall<Time.get_timeSinceLevelLoadAsDoubleDelegate>("UnityEngine.Time::get_timeSinceLevelLoadAsDouble");
			Time.get_fixedTimeDelegateField = IL2CPP.ResolveICall<Time.get_fixedTimeDelegate>("UnityEngine.Time::get_fixedTime");
			Time.get_fixedTimeAsDoubleDelegateField = IL2CPP.ResolveICall<Time.get_fixedTimeAsDoubleDelegate>("UnityEngine.Time::get_fixedTimeAsDouble");
			Time.get_unscaledTimeAsDoubleDelegateField = IL2CPP.ResolveICall<Time.get_unscaledTimeAsDoubleDelegate>("UnityEngine.Time::get_unscaledTimeAsDouble");
			Time.get_fixedUnscaledTimeDelegateField = IL2CPP.ResolveICall<Time.get_fixedUnscaledTimeDelegate>("UnityEngine.Time::get_fixedUnscaledTime");
			Time.get_fixedUnscaledTimeAsDoubleDelegateField = IL2CPP.ResolveICall<Time.get_fixedUnscaledTimeAsDoubleDelegate>("UnityEngine.Time::get_fixedUnscaledTimeAsDouble");
			Time.get_fixedUnscaledDeltaTimeDelegateField = IL2CPP.ResolveICall<Time.get_fixedUnscaledDeltaTimeDelegate>("UnityEngine.Time::get_fixedUnscaledDeltaTime");
			Time.get_maximumDeltaTimeDelegateField = IL2CPP.ResolveICall<Time.get_maximumDeltaTimeDelegate>("UnityEngine.Time::get_maximumDeltaTime");
			Time.set_maximumDeltaTimeDelegateField = IL2CPP.ResolveICall<Time.set_maximumDeltaTimeDelegate>("UnityEngine.Time::set_maximumDeltaTime");
			Time.get_maximumParticleDeltaTimeDelegateField = IL2CPP.ResolveICall<Time.get_maximumParticleDeltaTimeDelegate>("UnityEngine.Time::get_maximumParticleDeltaTime");
			Time.set_maximumParticleDeltaTimeDelegateField = IL2CPP.ResolveICall<Time.set_maximumParticleDeltaTimeDelegate>("UnityEngine.Time::set_maximumParticleDeltaTime");
			Time.get_realtimeSinceStartupAsDoubleDelegateField = IL2CPP.ResolveICall<Time.get_realtimeSinceStartupAsDoubleDelegate>("UnityEngine.Time::get_realtimeSinceStartupAsDouble");
			Time.get_captureDeltaTimeDelegateField = IL2CPP.ResolveICall<Time.get_captureDeltaTimeDelegate>("UnityEngine.Time::get_captureDeltaTime");
			Time.set_captureDeltaTimeDelegateField = IL2CPP.ResolveICall<Time.set_captureDeltaTimeDelegate>("UnityEngine.Time::set_captureDeltaTime");
			Time.get_inFixedTimeStepDelegateField = IL2CPP.ResolveICall<Time.get_inFixedTimeStepDelegate>("UnityEngine.Time::get_inFixedTimeStep");
		}

		// Token: 0x170005A3 RID: 1443
		// (get) Token: 0x06001B69 RID: 7017 RVA: 0x0007DCF0 File Offset: 0x0007BEF0
		public unsafe static float time
		{
			[CallerCount(43)]
			[CachedScanResults(RefRangeStart = 673625, RefRangeEnd = 673668, XrefRangeStart = 673623, XrefRangeEnd = 673625, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Time.NativeMethodInfoPtr_get_time_Public_Static_get_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170005A4 RID: 1444
		// (get) Token: 0x06001B6A RID: 7018 RVA: 0x0007DD20 File Offset: 0x0007BF20
		public unsafe static float deltaTime
		{
			[CallerCount(59)]
			[CachedScanResults(RefRangeStart = 673670, RefRangeEnd = 673729, XrefRangeStart = 673668, XrefRangeEnd = 673670, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Time.NativeMethodInfoPtr_get_deltaTime_Public_Static_get_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170005A5 RID: 1445
		// (get) Token: 0x06001B6B RID: 7019 RVA: 0x0007DD50 File Offset: 0x0007BF50
		public unsafe static float unscaledTime
		{
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 673731, RefRangeEnd = 673804, XrefRangeStart = 673729, XrefRangeEnd = 673731, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Time.NativeMethodInfoPtr_get_unscaledTime_Public_Static_get_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170005A6 RID: 1446
		// (get) Token: 0x06001B6C RID: 7020 RVA: 0x0007DD80 File Offset: 0x0007BF80
		public unsafe static float unscaledDeltaTime
		{
			[CallerCount(40)]
			[CachedScanResults(RefRangeStart = 673806, RefRangeEnd = 673846, XrefRangeStart = 673804, XrefRangeEnd = 673806, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Time.NativeMethodInfoPtr_get_unscaledDeltaTime_Public_Static_get_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170005A7 RID: 1447
		// (get) Token: 0x06001B6D RID: 7021 RVA: 0x0007DDB0 File Offset: 0x0007BFB0
		// (set) Token: 0x06001B6E RID: 7022 RVA: 0x0007DDE0 File Offset: 0x0007BFE0
		public unsafe static float fixedDeltaTime
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 673848, RefRangeEnd = 673851, XrefRangeStart = 673846, XrefRangeEnd = 673848, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Time.NativeMethodInfoPtr_get_fixedDeltaTime_Public_Static_get_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 673853, RefRangeEnd = 673854, XrefRangeStart = 673851, XrefRangeEnd = 673853, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Time.NativeMethodInfoPtr_set_fixedDeltaTime_Public_Static_set_Void_Single_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170005A8 RID: 1448
		// (get) Token: 0x06001B6F RID: 7023 RVA: 0x0007DE14 File Offset: 0x0007C014
		public unsafe static float smoothDeltaTime
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 673856, RefRangeEnd = 673863, XrefRangeStart = 673854, XrefRangeEnd = 673856, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Time.NativeMethodInfoPtr_get_smoothDeltaTime_Public_Static_get_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170005A9 RID: 1449
		// (get) Token: 0x06001B70 RID: 7024 RVA: 0x0007DE44 File Offset: 0x0007C044
		// (set) Token: 0x06001B71 RID: 7025 RVA: 0x0007DE74 File Offset: 0x0007C074
		public unsafe static float timeScale
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 673865, RefRangeEnd = 673872, XrefRangeStart = 673863, XrefRangeEnd = 673865, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Time.NativeMethodInfoPtr_get_timeScale_Public_Static_get_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 673874, RefRangeEnd = 673880, XrefRangeStart = 673872, XrefRangeEnd = 673874, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Time.NativeMethodInfoPtr_set_timeScale_Public_Static_set_Void_Single_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170005AA RID: 1450
		// (get) Token: 0x06001B72 RID: 7026 RVA: 0x0007DEA8 File Offset: 0x0007C0A8
		public unsafe static int frameCount
		{
			[CallerCount(54)]
			[CachedScanResults(RefRangeStart = 673882, RefRangeEnd = 673936, XrefRangeStart = 673880, XrefRangeEnd = 673882, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Time.NativeMethodInfoPtr_get_frameCount_Public_Static_get_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170005AB RID: 1451
		// (get) Token: 0x06001B73 RID: 7027 RVA: 0x0007DED8 File Offset: 0x0007C0D8
		public unsafe static int renderedFrameCount
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 673938, RefRangeEnd = 673939, XrefRangeStart = 673936, XrefRangeEnd = 673938, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Time.NativeMethodInfoPtr_get_renderedFrameCount_Public_Static_get_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170005AC RID: 1452
		// (get) Token: 0x06001B74 RID: 7028 RVA: 0x0007DF08 File Offset: 0x0007C108
		public unsafe static float realtimeSinceStartup
		{
			[CallerCount(29)]
			[CachedScanResults(RefRangeStart = 673941, RefRangeEnd = 673970, XrefRangeStart = 673939, XrefRangeEnd = 673941, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Time.NativeMethodInfoPtr_get_realtimeSinceStartup_Public_Static_get_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001B75 RID: 7029 RVA: 0x0000AA37 File Offset: 0x00008C37
		public Time(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170005AD RID: 1453
		// (get) Token: 0x06001B76 RID: 7030 RVA: 0x0000AA40 File Offset: 0x00008C40
		public static double timeAsDouble
		{
			get
			{
				return Time.get_timeAsDoubleDelegateField();
			}
		}

		// Token: 0x170005AE RID: 1454
		// (get) Token: 0x06001B77 RID: 7031 RVA: 0x0000AA4C File Offset: 0x00008C4C
		public static float timeSinceLevelLoad
		{
			get
			{
				return Time.get_timeSinceLevelLoadDelegateField();
			}
		}

		// Token: 0x170005AF RID: 1455
		// (get) Token: 0x06001B78 RID: 7032 RVA: 0x0000AA58 File Offset: 0x00008C58
		public static double timeSinceLevelLoadAsDouble
		{
			get
			{
				return Time.get_timeSinceLevelLoadAsDoubleDelegateField();
			}
		}

		// Token: 0x170005B0 RID: 1456
		// (get) Token: 0x06001B79 RID: 7033 RVA: 0x0000AA64 File Offset: 0x00008C64
		public static float fixedTime
		{
			get
			{
				return Time.get_fixedTimeDelegateField();
			}
		}

		// Token: 0x170005B1 RID: 1457
		// (get) Token: 0x06001B7A RID: 7034 RVA: 0x0000AA70 File Offset: 0x00008C70
		public static double fixedTimeAsDouble
		{
			get
			{
				return Time.get_fixedTimeAsDoubleDelegateField();
			}
		}

		// Token: 0x170005B2 RID: 1458
		// (get) Token: 0x06001B7B RID: 7035 RVA: 0x0000AA7C File Offset: 0x00008C7C
		public static double unscaledTimeAsDouble
		{
			get
			{
				return Time.get_unscaledTimeAsDoubleDelegateField();
			}
		}

		// Token: 0x170005B3 RID: 1459
		// (get) Token: 0x06001B7C RID: 7036 RVA: 0x0000AA88 File Offset: 0x00008C88
		public static float fixedUnscaledTime
		{
			get
			{
				return Time.get_fixedUnscaledTimeDelegateField();
			}
		}

		// Token: 0x170005B4 RID: 1460
		// (get) Token: 0x06001B7D RID: 7037 RVA: 0x0000AA94 File Offset: 0x00008C94
		public static double fixedUnscaledTimeAsDouble
		{
			get
			{
				return Time.get_fixedUnscaledTimeAsDoubleDelegateField();
			}
		}

		// Token: 0x170005B5 RID: 1461
		// (get) Token: 0x06001B7E RID: 7038 RVA: 0x0000AAA0 File Offset: 0x00008CA0
		public static float fixedUnscaledDeltaTime
		{
			get
			{
				return Time.get_fixedUnscaledDeltaTimeDelegateField();
			}
		}

		// Token: 0x170005B6 RID: 1462
		// (get) Token: 0x06001B7F RID: 7039 RVA: 0x0000AAAC File Offset: 0x00008CAC
		// (set) Token: 0x06001B80 RID: 7040 RVA: 0x0000AAB8 File Offset: 0x00008CB8
		public static float maximumDeltaTime
		{
			get
			{
				return Time.get_maximumDeltaTimeDelegateField();
			}
			set
			{
				Time.set_maximumDeltaTimeDelegateField(value);
			}
		}

		// Token: 0x170005B7 RID: 1463
		// (get) Token: 0x06001B81 RID: 7041 RVA: 0x0000AAC5 File Offset: 0x00008CC5
		// (set) Token: 0x06001B82 RID: 7042 RVA: 0x0000AAD1 File Offset: 0x00008CD1
		public static float maximumParticleDeltaTime
		{
			get
			{
				return Time.get_maximumParticleDeltaTimeDelegateField();
			}
			set
			{
				Time.set_maximumParticleDeltaTimeDelegateField(value);
			}
		}

		// Token: 0x170005B8 RID: 1464
		// (get) Token: 0x06001B83 RID: 7043 RVA: 0x0000AADE File Offset: 0x00008CDE
		public static double realtimeSinceStartupAsDouble
		{
			get
			{
				return Time.get_realtimeSinceStartupAsDoubleDelegateField();
			}
		}

		// Token: 0x170005B9 RID: 1465
		// (get) Token: 0x06001B84 RID: 7044 RVA: 0x0000AAEA File Offset: 0x00008CEA
		// (set) Token: 0x06001B85 RID: 7045 RVA: 0x0000AAF6 File Offset: 0x00008CF6
		public static float captureDeltaTime
		{
			get
			{
				return Time.get_captureDeltaTimeDelegateField();
			}
			set
			{
				Time.set_captureDeltaTimeDelegateField(value);
			}
		}

		// Token: 0x170005BA RID: 1466
		// (get) Token: 0x06001B86 RID: 7046 RVA: 0x0007DF38 File Offset: 0x0007C138
		// (set) Token: 0x06001B87 RID: 7047 RVA: 0x0000AB03 File Offset: 0x00008D03
		public static int captureFramerate
		{
			get
			{
				return (Time.captureDeltaTime == 0f) ? 0 : ((int)Mathf.Round(1f / Time.captureDeltaTime));
			}
			set
			{
				Time.captureDeltaTime = ((value == 0) ? 0f : (1f / (float)value));
			}
		}

		// Token: 0x170005BB RID: 1467
		// (get) Token: 0x06001B88 RID: 7048 RVA: 0x0000AB1E File Offset: 0x00008D1E
		public static bool inFixedTimeStep
		{
			get
			{
				return Time.get_inFixedTimeStepDelegateField();
			}
		}

		// Token: 0x04001814 RID: 6164
		private static readonly IntPtr NativeMethodInfoPtr_get_time_Public_Static_get_Single_0;

		// Token: 0x04001815 RID: 6165
		private static readonly IntPtr NativeMethodInfoPtr_get_deltaTime_Public_Static_get_Single_0;

		// Token: 0x04001816 RID: 6166
		private static readonly IntPtr NativeMethodInfoPtr_get_unscaledTime_Public_Static_get_Single_0;

		// Token: 0x04001817 RID: 6167
		private static readonly IntPtr NativeMethodInfoPtr_get_unscaledDeltaTime_Public_Static_get_Single_0;

		// Token: 0x04001818 RID: 6168
		private static readonly IntPtr NativeMethodInfoPtr_get_fixedDeltaTime_Public_Static_get_Single_0;

		// Token: 0x04001819 RID: 6169
		private static readonly IntPtr NativeMethodInfoPtr_set_fixedDeltaTime_Public_Static_set_Void_Single_0;

		// Token: 0x0400181A RID: 6170
		private static readonly IntPtr NativeMethodInfoPtr_get_smoothDeltaTime_Public_Static_get_Single_0;

		// Token: 0x0400181B RID: 6171
		private static readonly IntPtr NativeMethodInfoPtr_get_timeScale_Public_Static_get_Single_0;

		// Token: 0x0400181C RID: 6172
		private static readonly IntPtr NativeMethodInfoPtr_set_timeScale_Public_Static_set_Void_Single_0;

		// Token: 0x0400181D RID: 6173
		private static readonly IntPtr NativeMethodInfoPtr_get_frameCount_Public_Static_get_Int32_0;

		// Token: 0x0400181E RID: 6174
		private static readonly IntPtr NativeMethodInfoPtr_get_renderedFrameCount_Public_Static_get_Int32_0;

		// Token: 0x0400181F RID: 6175
		private static readonly IntPtr NativeMethodInfoPtr_get_realtimeSinceStartup_Public_Static_get_Single_0;

		// Token: 0x04001820 RID: 6176
		private static readonly Time.get_timeAsDoubleDelegate get_timeAsDoubleDelegateField;

		// Token: 0x04001821 RID: 6177
		private static readonly Time.get_timeSinceLevelLoadDelegate get_timeSinceLevelLoadDelegateField;

		// Token: 0x04001822 RID: 6178
		private static readonly Time.get_timeSinceLevelLoadAsDoubleDelegate get_timeSinceLevelLoadAsDoubleDelegateField;

		// Token: 0x04001823 RID: 6179
		private static readonly Time.get_fixedTimeDelegate get_fixedTimeDelegateField;

		// Token: 0x04001824 RID: 6180
		private static readonly Time.get_fixedTimeAsDoubleDelegate get_fixedTimeAsDoubleDelegateField;

		// Token: 0x04001825 RID: 6181
		private static readonly Time.get_unscaledTimeAsDoubleDelegate get_unscaledTimeAsDoubleDelegateField;

		// Token: 0x04001826 RID: 6182
		private static readonly Time.get_fixedUnscaledTimeDelegate get_fixedUnscaledTimeDelegateField;

		// Token: 0x04001827 RID: 6183
		private static readonly Time.get_fixedUnscaledTimeAsDoubleDelegate get_fixedUnscaledTimeAsDoubleDelegateField;

		// Token: 0x04001828 RID: 6184
		private static readonly Time.get_fixedUnscaledDeltaTimeDelegate get_fixedUnscaledDeltaTimeDelegateField;

		// Token: 0x04001829 RID: 6185
		private static readonly Time.get_maximumDeltaTimeDelegate get_maximumDeltaTimeDelegateField;

		// Token: 0x0400182A RID: 6186
		private static readonly Time.set_maximumDeltaTimeDelegate set_maximumDeltaTimeDelegateField;

		// Token: 0x0400182B RID: 6187
		private static readonly Time.get_maximumParticleDeltaTimeDelegate get_maximumParticleDeltaTimeDelegateField;

		// Token: 0x0400182C RID: 6188
		private static readonly Time.set_maximumParticleDeltaTimeDelegate set_maximumParticleDeltaTimeDelegateField;

		// Token: 0x0400182D RID: 6189
		private static readonly Time.get_realtimeSinceStartupAsDoubleDelegate get_realtimeSinceStartupAsDoubleDelegateField;

		// Token: 0x0400182E RID: 6190
		private static readonly Time.get_captureDeltaTimeDelegate get_captureDeltaTimeDelegateField;

		// Token: 0x0400182F RID: 6191
		private static readonly Time.set_captureDeltaTimeDelegate set_captureDeltaTimeDelegateField;

		// Token: 0x04001830 RID: 6192
		private static readonly Time.get_inFixedTimeStepDelegate get_inFixedTimeStepDelegateField;

		// Token: 0x020007E2 RID: 2018
		// (Invoke) Token: 0x06003871 RID: 14449
		private delegate double get_timeAsDoubleDelegate();

		// Token: 0x020007E3 RID: 2019
		// (Invoke) Token: 0x06003873 RID: 14451
		private delegate float get_timeSinceLevelLoadDelegate();

		// Token: 0x020007E4 RID: 2020
		// (Invoke) Token: 0x06003875 RID: 14453
		private delegate double get_timeSinceLevelLoadAsDoubleDelegate();

		// Token: 0x020007E5 RID: 2021
		// (Invoke) Token: 0x06003877 RID: 14455
		private delegate float get_fixedTimeDelegate();

		// Token: 0x020007E6 RID: 2022
		// (Invoke) Token: 0x06003879 RID: 14457
		private delegate double get_fixedTimeAsDoubleDelegate();

		// Token: 0x020007E7 RID: 2023
		// (Invoke) Token: 0x0600387B RID: 14459
		private delegate double get_unscaledTimeAsDoubleDelegate();

		// Token: 0x020007E8 RID: 2024
		// (Invoke) Token: 0x0600387D RID: 14461
		private delegate float get_fixedUnscaledTimeDelegate();

		// Token: 0x020007E9 RID: 2025
		// (Invoke) Token: 0x0600387F RID: 14463
		private delegate double get_fixedUnscaledTimeAsDoubleDelegate();

		// Token: 0x020007EA RID: 2026
		// (Invoke) Token: 0x06003881 RID: 14465
		private delegate float get_fixedUnscaledDeltaTimeDelegate();

		// Token: 0x020007EB RID: 2027
		// (Invoke) Token: 0x06003883 RID: 14467
		private delegate float get_maximumDeltaTimeDelegate();

		// Token: 0x020007EC RID: 2028
		// (Invoke) Token: 0x06003885 RID: 14469
		private delegate void set_maximumDeltaTimeDelegate(float value);

		// Token: 0x020007ED RID: 2029
		// (Invoke) Token: 0x06003887 RID: 14471
		private delegate float get_maximumParticleDeltaTimeDelegate();

		// Token: 0x020007EE RID: 2030
		// (Invoke) Token: 0x06003889 RID: 14473
		private delegate void set_maximumParticleDeltaTimeDelegate(float value);

		// Token: 0x020007EF RID: 2031
		// (Invoke) Token: 0x0600388B RID: 14475
		private delegate double get_realtimeSinceStartupAsDoubleDelegate();

		// Token: 0x020007F0 RID: 2032
		// (Invoke) Token: 0x0600388D RID: 14477
		private delegate float get_captureDeltaTimeDelegate();

		// Token: 0x020007F1 RID: 2033
		// (Invoke) Token: 0x0600388F RID: 14479
		private delegate void set_captureDeltaTimeDelegate(float value);

		// Token: 0x020007F2 RID: 2034
		// (Invoke) Token: 0x06003891 RID: 14481
		private delegate bool get_inFixedTimeStepDelegate();
	}
}
