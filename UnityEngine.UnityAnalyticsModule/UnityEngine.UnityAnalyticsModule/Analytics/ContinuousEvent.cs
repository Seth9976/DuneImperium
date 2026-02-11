using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

namespace UnityEngine.Analytics
{
	// Token: 0x02000005 RID: 5
	public class ContinuousEvent : Object
	{
		// Token: 0x0600006C RID: 108 RVA: 0x000037E0 File Offset: 0x000019E0
		// Note: this type is marked as 'beforefieldinit'.
		static ContinuousEvent()
		{
			Il2CppClassPointerStore<ContinuousEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UnityAnalyticsModule.dll", "UnityEngine.Analytics", "ContinuousEvent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ContinuousEvent>.NativeClassPtr);
			ContinuousEvent.InternalRegisterCollectorDelegateField = IL2CPP.ResolveICall<ContinuousEvent.InternalRegisterCollectorDelegate>("UnityEngine.Analytics.ContinuousEvent::InternalRegisterCollector");
			ContinuousEvent.InternalSetEventHistogramThresholdsDelegateField = IL2CPP.ResolveICall<ContinuousEvent.InternalSetEventHistogramThresholdsDelegate>("UnityEngine.Analytics.ContinuousEvent::InternalSetEventHistogramThresholds");
			ContinuousEvent.InternalSetCustomEventHistogramThresholdsDelegateField = IL2CPP.ResolveICall<ContinuousEvent.InternalSetCustomEventHistogramThresholdsDelegate>("UnityEngine.Analytics.ContinuousEvent::InternalSetCustomEventHistogramThresholds");
			ContinuousEvent.InternalConfigureCustomEventDelegateField = IL2CPP.ResolveICall<ContinuousEvent.InternalConfigureCustomEventDelegate>("UnityEngine.Analytics.ContinuousEvent::InternalConfigureCustomEvent");
			ContinuousEvent.InternalConfigureEventDelegateField = IL2CPP.ResolveICall<ContinuousEvent.InternalConfigureEventDelegate>("UnityEngine.Analytics.ContinuousEvent::InternalConfigureEvent");
		}

		// Token: 0x0600006D RID: 109 RVA: 0x0000242E File Offset: 0x0000062E
		public ContinuousEvent(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0600006E RID: 110 RVA: 0x0000385C File Offset: 0x00001A5C
		public static AnalyticsResult RegisterCollector<T>(string metricName, Func<T> del) where T : struct, IComparable<T>, IEquatable<T>
		{
			bool flag = String.IsNullOrEmpty(metricName);
			if (flag)
			{
				throw new ArgumentException("Cannot set metric name to an empty or null string");
			}
			bool flag2 = !ContinuousEvent.IsInitialized();
			AnalyticsResult analyticsResult;
			if (flag2)
			{
				analyticsResult = AnalyticsResult.NotInitialized;
			}
			else
			{
				analyticsResult = ContinuousEvent.InternalRegisterCollector(Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<T>()).ToString(), metricName, del);
			}
			return analyticsResult;
		}

		// Token: 0x0600006F RID: 111 RVA: 0x000038AC File Offset: 0x00001AAC
		public static AnalyticsResult SetEventHistogramThresholds<T>(string eventName, int count, Il2CppArrayBase<T> data, [Optional] int ver, [Optional] string prefix) where T : struct, IComparable<T>, IEquatable<T>
		{
			bool flag = String.IsNullOrEmpty(eventName);
			if (flag)
			{
				throw new ArgumentException("Cannot set event name to an empty or null string");
			}
			bool flag2 = !ContinuousEvent.IsInitialized();
			AnalyticsResult analyticsResult;
			if (flag2)
			{
				analyticsResult = AnalyticsResult.NotInitialized;
			}
			else
			{
				analyticsResult = ContinuousEvent.InternalSetEventHistogramThresholds(Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<T>()).ToString(), eventName, count, data, ver, prefix);
			}
			return analyticsResult;
		}

		// Token: 0x06000070 RID: 112 RVA: 0x00003900 File Offset: 0x00001B00
		public static AnalyticsResult SetCustomEventHistogramThresholds<T>(string eventName, int count, Il2CppArrayBase<T> data) where T : struct, IComparable<T>, IEquatable<T>
		{
			bool flag = String.IsNullOrEmpty(eventName);
			if (flag)
			{
				throw new ArgumentException("Cannot set event name to an empty or null string");
			}
			bool flag2 = !ContinuousEvent.IsInitialized();
			AnalyticsResult analyticsResult;
			if (flag2)
			{
				analyticsResult = AnalyticsResult.NotInitialized;
			}
			else
			{
				analyticsResult = ContinuousEvent.InternalSetCustomEventHistogramThresholds(Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<T>()).ToString(), eventName, count, data);
			}
			return analyticsResult;
		}

		// Token: 0x06000071 RID: 113 RVA: 0x00003950 File Offset: 0x00001B50
		public static AnalyticsResult ConfigureCustomEvent(string customEventName, string metricName, float interval, float period, [Optional] bool enabled)
		{
			bool flag = String.IsNullOrEmpty(customEventName);
			if (flag)
			{
				throw new ArgumentException("Cannot set event name to an empty or null string");
			}
			bool flag2 = !ContinuousEvent.IsInitialized();
			AnalyticsResult analyticsResult;
			if (flag2)
			{
				analyticsResult = AnalyticsResult.NotInitialized;
			}
			else
			{
				analyticsResult = ContinuousEvent.InternalConfigureCustomEvent(customEventName, metricName, interval, period, enabled);
			}
			return analyticsResult;
		}

		// Token: 0x06000072 RID: 114 RVA: 0x00003994 File Offset: 0x00001B94
		public static AnalyticsResult ConfigureEvent(string eventName, string metricName, float interval, float period, [Optional] bool enabled, [Optional] int ver, [Optional] string prefix)
		{
			bool flag = String.IsNullOrEmpty(eventName);
			if (flag)
			{
				throw new ArgumentException("Cannot set event name to an empty or null string");
			}
			bool flag2 = !ContinuousEvent.IsInitialized();
			AnalyticsResult analyticsResult;
			if (flag2)
			{
				analyticsResult = AnalyticsResult.NotInitialized;
			}
			else
			{
				analyticsResult = ContinuousEvent.InternalConfigureEvent(eventName, metricName, interval, period, enabled, ver, prefix);
			}
			return analyticsResult;
		}

		// Token: 0x06000073 RID: 115 RVA: 0x00002437 File Offset: 0x00000637
		public static AnalyticsResult InternalRegisterCollector(string type, string metricName, Object collector)
		{
			return ContinuousEvent.InternalRegisterCollectorDelegateField(IL2CPP.ManagedStringToIl2Cpp(type), IL2CPP.ManagedStringToIl2Cpp(metricName), IL2CPP.Il2CppObjectBaseToPtr(collector));
		}

		// Token: 0x06000074 RID: 116 RVA: 0x00002455 File Offset: 0x00000655
		public static AnalyticsResult InternalSetEventHistogramThresholds(string type, string eventName, int count, Object data, int ver, string prefix)
		{
			return ContinuousEvent.InternalSetEventHistogramThresholdsDelegateField(IL2CPP.ManagedStringToIl2Cpp(type), IL2CPP.ManagedStringToIl2Cpp(eventName), count, IL2CPP.Il2CppObjectBaseToPtr(data), ver, IL2CPP.ManagedStringToIl2Cpp(prefix));
		}

		// Token: 0x06000075 RID: 117 RVA: 0x0000247D File Offset: 0x0000067D
		public static AnalyticsResult InternalSetCustomEventHistogramThresholds(string type, string eventName, int count, Object data)
		{
			return ContinuousEvent.InternalSetCustomEventHistogramThresholdsDelegateField(IL2CPP.ManagedStringToIl2Cpp(type), IL2CPP.ManagedStringToIl2Cpp(eventName), count, IL2CPP.Il2CppObjectBaseToPtr(data));
		}

		// Token: 0x06000076 RID: 118 RVA: 0x0000249C File Offset: 0x0000069C
		public static AnalyticsResult InternalConfigureCustomEvent(string customEventName, string metricName, float interval, float period, bool enabled)
		{
			return ContinuousEvent.InternalConfigureCustomEventDelegateField(IL2CPP.ManagedStringToIl2Cpp(customEventName), IL2CPP.ManagedStringToIl2Cpp(metricName), interval, period, enabled);
		}

		// Token: 0x06000077 RID: 119 RVA: 0x000024B8 File Offset: 0x000006B8
		public static AnalyticsResult InternalConfigureEvent(string eventName, string metricName, float interval, float period, bool enabled, int ver, string prefix)
		{
			return ContinuousEvent.InternalConfigureEventDelegateField(IL2CPP.ManagedStringToIl2Cpp(eventName), IL2CPP.ManagedStringToIl2Cpp(metricName), interval, period, enabled, ver, IL2CPP.ManagedStringToIl2Cpp(prefix));
		}

		// Token: 0x06000078 RID: 120 RVA: 0x000039DC File Offset: 0x00001BDC
		public static bool IsInitialized()
		{
			return Analytics.IsInitialized();
		}

		// Token: 0x0400003B RID: 59
		private static readonly ContinuousEvent.InternalRegisterCollectorDelegate InternalRegisterCollectorDelegateField;

		// Token: 0x0400003C RID: 60
		private static readonly ContinuousEvent.InternalSetEventHistogramThresholdsDelegate InternalSetEventHistogramThresholdsDelegateField;

		// Token: 0x0400003D RID: 61
		private static readonly ContinuousEvent.InternalSetCustomEventHistogramThresholdsDelegate InternalSetCustomEventHistogramThresholdsDelegateField;

		// Token: 0x0400003E RID: 62
		private static readonly ContinuousEvent.InternalConfigureCustomEventDelegate InternalConfigureCustomEventDelegateField;

		// Token: 0x0400003F RID: 63
		private static readonly ContinuousEvent.InternalConfigureEventDelegate InternalConfigureEventDelegateField;

		// Token: 0x02000040 RID: 64
		// (Invoke) Token: 0x0600014C RID: 332
		private delegate AnalyticsResult InternalRegisterCollectorDelegate(IntPtr type, IntPtr metricName, IntPtr collector);

		// Token: 0x02000041 RID: 65
		// (Invoke) Token: 0x0600014E RID: 334
		private delegate AnalyticsResult InternalSetEventHistogramThresholdsDelegate(IntPtr type, IntPtr eventName, int count, IntPtr data, int ver, IntPtr prefix);

		// Token: 0x02000042 RID: 66
		// (Invoke) Token: 0x06000150 RID: 336
		private delegate AnalyticsResult InternalSetCustomEventHistogramThresholdsDelegate(IntPtr type, IntPtr eventName, int count, IntPtr data);

		// Token: 0x02000043 RID: 67
		// (Invoke) Token: 0x06000152 RID: 338
		private delegate AnalyticsResult InternalConfigureCustomEventDelegate(IntPtr customEventName, IntPtr metricName, float interval, float period, bool enabled);

		// Token: 0x02000044 RID: 68
		// (Invoke) Token: 0x06000154 RID: 340
		private delegate AnalyticsResult InternalConfigureEventDelegate(IntPtr eventName, IntPtr metricName, float interval, float period, bool enabled, int ver, IntPtr prefix);
	}
}
