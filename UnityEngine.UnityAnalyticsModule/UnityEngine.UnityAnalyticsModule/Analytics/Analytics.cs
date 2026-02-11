using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;

namespace UnityEngine.Analytics
{
	// Token: 0x02000009 RID: 9
	public static class Analytics
	{
		// Token: 0x17000014 RID: 20
		// (get) Token: 0x060000A4 RID: 164 RVA: 0x000042DC File Offset: 0x000024DC
		// (set) Token: 0x060000A5 RID: 165 RVA: 0x00004304 File Offset: 0x00002504
		public static bool initializeOnStartup
		{
			get
			{
				bool flag = !Analytics.IsInitialized();
				return !flag && Analytics.initializeOnStartupInternal;
			}
			set
			{
				bool flag = Analytics.IsInitialized();
				if (flag)
				{
					Analytics.initializeOnStartupInternal = value;
				}
			}
		}

		// Token: 0x060000A6 RID: 166 RVA: 0x00004324 File Offset: 0x00002524
		public static AnalyticsResult ResumeInitialization()
		{
			bool flag = !Analytics.IsInitialized();
			AnalyticsResult analyticsResult;
			if (flag)
			{
				analyticsResult = AnalyticsResult.NotInitialized;
			}
			else
			{
				analyticsResult = Analytics.ResumeInitializationInternal();
			}
			return analyticsResult;
		}

		// Token: 0x060000A7 RID: 167 RVA: 0x00002695 File Offset: 0x00000895
		public static AnalyticsResult ResumeInitializationInternal()
		{
			return Analytics.ResumeInitializationInternalDelegateField();
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x060000A8 RID: 168 RVA: 0x000026A1 File Offset: 0x000008A1
		// (set) Token: 0x060000A9 RID: 169 RVA: 0x000026AD File Offset: 0x000008AD
		public static bool initializeOnStartupInternal
		{
			get
			{
				return Analytics.get_initializeOnStartupInternalDelegateField();
			}
			set
			{
				Analytics.set_initializeOnStartupInternalDelegateField(value);
			}
		}

		// Token: 0x060000AA RID: 170 RVA: 0x000026BA File Offset: 0x000008BA
		public static bool IsInitialized()
		{
			return Analytics.IsInitializedDelegateField();
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x060000AB RID: 171 RVA: 0x000026C6 File Offset: 0x000008C6
		// (set) Token: 0x060000AC RID: 172 RVA: 0x000026D2 File Offset: 0x000008D2
		public static bool enabledInternal
		{
			get
			{
				return Analytics.get_enabledInternalDelegateField();
			}
			set
			{
				Analytics.set_enabledInternalDelegateField(value);
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x060000AD RID: 173 RVA: 0x000026DF File Offset: 0x000008DF
		public static bool playerOptedOutInternal
		{
			get
			{
				return Analytics.get_playerOptedOutInternalDelegateField();
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x060000AE RID: 174 RVA: 0x0000434C File Offset: 0x0000254C
		public static string eventUrlInternal
		{
			get
			{
				IntPtr intPtr = Analytics.get_eventUrlInternalDelegateField();
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x060000AF RID: 175 RVA: 0x0000436C File Offset: 0x0000256C
		public static string configUrlInternal
		{
			get
			{
				IntPtr intPtr = Analytics.get_configUrlInternalDelegateField();
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x060000B0 RID: 176 RVA: 0x0000438C File Offset: 0x0000258C
		public static string dashboardUrlInternal
		{
			get
			{
				IntPtr intPtr = Analytics.get_dashboardUrlInternalDelegateField();
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x060000B1 RID: 177 RVA: 0x000026EB File Offset: 0x000008EB
		// (set) Token: 0x060000B2 RID: 178 RVA: 0x000026F7 File Offset: 0x000008F7
		public static bool limitUserTrackingInternal
		{
			get
			{
				return Analytics.get_limitUserTrackingInternalDelegateField();
			}
			set
			{
				Analytics.set_limitUserTrackingInternalDelegateField(value);
			}
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x060000B3 RID: 179 RVA: 0x00002704 File Offset: 0x00000904
		// (set) Token: 0x060000B4 RID: 180 RVA: 0x00002710 File Offset: 0x00000910
		public static bool deviceStatsEnabledInternal
		{
			get
			{
				return Analytics.get_deviceStatsEnabledInternalDelegateField();
			}
			set
			{
				Analytics.set_deviceStatsEnabledInternalDelegateField(value);
			}
		}

		// Token: 0x060000B5 RID: 181 RVA: 0x0000271D File Offset: 0x0000091D
		public static bool FlushArchivedEvents()
		{
			return Analytics.FlushArchivedEventsDelegateField();
		}

		// Token: 0x060000B6 RID: 182 RVA: 0x00002729 File Offset: 0x00000929
		public static AnalyticsResult Transaction(string productId, double amount, string currency, string receiptPurchaseData, string signature, bool usingIAPService)
		{
			return Analytics.TransactionDelegateField(IL2CPP.ManagedStringToIl2Cpp(productId), amount, IL2CPP.ManagedStringToIl2Cpp(currency), IL2CPP.ManagedStringToIl2Cpp(receiptPurchaseData), IL2CPP.ManagedStringToIl2Cpp(signature), usingIAPService);
		}

		// Token: 0x060000B7 RID: 183 RVA: 0x00002751 File Offset: 0x00000951
		public static AnalyticsResult SendCustomEventName(string customEventName)
		{
			return Analytics.SendCustomEventNameDelegateField(IL2CPP.ManagedStringToIl2Cpp(customEventName));
		}

		// Token: 0x060000B8 RID: 184 RVA: 0x00002763 File Offset: 0x00000963
		public static AnalyticsResult SendCustomEvent(CustomEventData eventData)
		{
			return Analytics.SendCustomEventDelegateField(IL2CPP.Il2CppObjectBaseToPtr(eventData));
		}

		// Token: 0x060000B9 RID: 185 RVA: 0x00002775 File Offset: 0x00000975
		public static AnalyticsResult IsCustomEventWithLimitEnabled(string customEventName)
		{
			return Analytics.IsCustomEventWithLimitEnabledDelegateField(IL2CPP.ManagedStringToIl2Cpp(customEventName));
		}

		// Token: 0x060000BA RID: 186 RVA: 0x00002787 File Offset: 0x00000987
		public static AnalyticsResult EnableCustomEventWithLimit(string customEventName, bool enable)
		{
			return Analytics.EnableCustomEventWithLimitDelegateField(IL2CPP.ManagedStringToIl2Cpp(customEventName), enable);
		}

		// Token: 0x060000BB RID: 187 RVA: 0x0000279A File Offset: 0x0000099A
		public static AnalyticsResult IsEventWithLimitEnabled(string eventName, int ver, string prefix)
		{
			return Analytics.IsEventWithLimitEnabledDelegateField(IL2CPP.ManagedStringToIl2Cpp(eventName), ver, IL2CPP.ManagedStringToIl2Cpp(prefix));
		}

		// Token: 0x060000BC RID: 188 RVA: 0x000027B3 File Offset: 0x000009B3
		public static AnalyticsResult EnableEventWithLimit(string eventName, bool enable, int ver, string prefix)
		{
			return Analytics.EnableEventWithLimitDelegateField(IL2CPP.ManagedStringToIl2Cpp(eventName), enable, ver, IL2CPP.ManagedStringToIl2Cpp(prefix));
		}

		// Token: 0x060000BD RID: 189 RVA: 0x000043AC File Offset: 0x000025AC
		public static AnalyticsResult RegisterEventWithLimit(string eventName, int maxEventPerHour, int maxItems, string vendorKey, int ver, string prefix, string assemblyInfo, bool notifyServer)
		{
			return Analytics.RegisterEventWithLimitDelegateField(IL2CPP.ManagedStringToIl2Cpp(eventName), maxEventPerHour, maxItems, IL2CPP.ManagedStringToIl2Cpp(vendorKey), ver, IL2CPP.ManagedStringToIl2Cpp(prefix), IL2CPP.ManagedStringToIl2Cpp(assemblyInfo), notifyServer);
		}

		// Token: 0x060000BE RID: 190 RVA: 0x000043E4 File Offset: 0x000025E4
		public static AnalyticsResult RegisterEventsWithLimit(Il2CppStringArray eventName, int maxEventPerHour, int maxItems, string vendorKey, int ver, string prefix, string assemblyInfo, bool notifyServer)
		{
			return Analytics.RegisterEventsWithLimitDelegateField(IL2CPP.Il2CppObjectBaseToPtr(eventName), maxEventPerHour, maxItems, IL2CPP.ManagedStringToIl2Cpp(vendorKey), ver, IL2CPP.ManagedStringToIl2Cpp(prefix), IL2CPP.ManagedStringToIl2Cpp(assemblyInfo), notifyServer);
		}

		// Token: 0x060000BF RID: 191 RVA: 0x000027CD File Offset: 0x000009CD
		public static AnalyticsResult SendEventWithLimit(string eventName, Object parameters, int ver, string prefix)
		{
			return Analytics.SendEventWithLimitDelegateField(IL2CPP.ManagedStringToIl2Cpp(eventName), IL2CPP.Il2CppObjectBaseToPtr(parameters), ver, IL2CPP.ManagedStringToIl2Cpp(prefix));
		}

		// Token: 0x060000C0 RID: 192 RVA: 0x000027EC File Offset: 0x000009EC
		public static AnalyticsResult SetEventWithLimitEndPoint(string eventName, string endPoint, int ver, string prefix)
		{
			return Analytics.SetEventWithLimitEndPointDelegateField(IL2CPP.ManagedStringToIl2Cpp(eventName), IL2CPP.ManagedStringToIl2Cpp(endPoint), ver, IL2CPP.ManagedStringToIl2Cpp(prefix));
		}

		// Token: 0x060000C1 RID: 193 RVA: 0x0000280B File Offset: 0x00000A0B
		public static AnalyticsResult SetEventWithLimitPriority(string eventName, AnalyticsEventPriority eventPriority, int ver, string prefix)
		{
			return Analytics.SetEventWithLimitPriorityDelegateField(IL2CPP.ManagedStringToIl2Cpp(eventName), eventPriority, ver, IL2CPP.ManagedStringToIl2Cpp(prefix));
		}

		// Token: 0x060000C2 RID: 194 RVA: 0x00002825 File Offset: 0x00000A25
		public static bool QueueEvent(string eventName, Object parameters, int ver, string prefix)
		{
			return Analytics.QueueEventDelegateField(IL2CPP.ManagedStringToIl2Cpp(eventName), IL2CPP.Il2CppObjectBaseToPtr(parameters), ver, IL2CPP.ManagedStringToIl2Cpp(prefix));
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x060000C3 RID: 195 RVA: 0x0000441C File Offset: 0x0000261C
		public static bool playerOptedOut
		{
			get
			{
				bool flag = !Analytics.IsInitialized();
				return !flag && Analytics.playerOptedOutInternal;
			}
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x060000C4 RID: 196 RVA: 0x00004444 File Offset: 0x00002644
		public static string eventUrl
		{
			get
			{
				bool flag = !Analytics.IsInitialized();
				string text;
				if (flag)
				{
					text = String.Empty;
				}
				else
				{
					text = Analytics.eventUrlInternal;
				}
				return text;
			}
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x060000C5 RID: 197 RVA: 0x00004470 File Offset: 0x00002670
		public static string dashboardUrl
		{
			get
			{
				bool flag = !Analytics.IsInitialized();
				string text;
				if (flag)
				{
					text = String.Empty;
				}
				else
				{
					text = Analytics.dashboardUrlInternal;
				}
				return text;
			}
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x060000C6 RID: 198 RVA: 0x0000449C File Offset: 0x0000269C
		public static string configUrl
		{
			get
			{
				bool flag = !Analytics.IsInitialized();
				string text;
				if (flag)
				{
					text = String.Empty;
				}
				else
				{
					text = Analytics.configUrlInternal;
				}
				return text;
			}
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x060000C7 RID: 199 RVA: 0x000044C8 File Offset: 0x000026C8
		// (set) Token: 0x060000C8 RID: 200 RVA: 0x000044F0 File Offset: 0x000026F0
		public static bool limitUserTracking
		{
			get
			{
				bool flag = !Analytics.IsInitialized();
				return !flag && Analytics.limitUserTrackingInternal;
			}
			set
			{
				bool flag = Analytics.IsInitialized();
				if (flag)
				{
					Analytics.limitUserTrackingInternal = value;
				}
			}
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x060000C9 RID: 201 RVA: 0x00004510 File Offset: 0x00002710
		// (set) Token: 0x060000CA RID: 202 RVA: 0x00004538 File Offset: 0x00002738
		public static bool deviceStatsEnabled
		{
			get
			{
				bool flag = !Analytics.IsInitialized();
				return !flag && Analytics.deviceStatsEnabledInternal;
			}
			set
			{
				bool flag = Analytics.IsInitialized();
				if (flag)
				{
					Analytics.deviceStatsEnabledInternal = value;
				}
			}
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x060000CB RID: 203 RVA: 0x00004558 File Offset: 0x00002758
		// (set) Token: 0x060000CC RID: 204 RVA: 0x00004580 File Offset: 0x00002780
		public static bool enabled
		{
			get
			{
				bool flag = !Analytics.IsInitialized();
				return !flag && Analytics.enabledInternal;
			}
			set
			{
				bool flag = Analytics.IsInitialized();
				if (flag)
				{
					Analytics.enabledInternal = value;
				}
			}
		}

		// Token: 0x060000CD RID: 205 RVA: 0x000045A0 File Offset: 0x000027A0
		public static AnalyticsResult FlushEvents()
		{
			bool flag = !Analytics.IsInitialized();
			AnalyticsResult analyticsResult;
			if (flag)
			{
				analyticsResult = AnalyticsResult.NotInitialized;
			}
			else
			{
				analyticsResult = (Analytics.FlushArchivedEvents() ? AnalyticsResult.Ok : AnalyticsResult.NotInitialized);
			}
			return analyticsResult;
		}

		// Token: 0x060000CE RID: 206 RVA: 0x000045D0 File Offset: 0x000027D0
		public static AnalyticsResult SetUserId(string userId)
		{
			bool flag = String.IsNullOrEmpty(userId);
			if (flag)
			{
				throw new ArgumentException("Cannot set userId to an empty or null string");
			}
			return AnalyticsResult.InvalidData;
		}

		// Token: 0x060000CF RID: 207 RVA: 0x000045F8 File Offset: 0x000027F8
		public static AnalyticsResult SetUserGender(Gender gender)
		{
			return AnalyticsResult.InvalidData;
		}

		// Token: 0x060000D0 RID: 208 RVA: 0x0000460C File Offset: 0x0000280C
		public static AnalyticsResult SetUserBirthYear(int birthYear)
		{
			return AnalyticsResult.InvalidData;
		}

		// Token: 0x060000D1 RID: 209 RVA: 0x00004620 File Offset: 0x00002820
		public static AnalyticsResult SendUserInfoEvent(Object param)
		{
			return AnalyticsResult.InvalidData;
		}

		// Token: 0x060000D2 RID: 210 RVA: 0x00004634 File Offset: 0x00002834
		public static AnalyticsResult Transaction(string productId, Decimal amount, string currency)
		{
			return Analytics.Transaction(productId, amount, currency, null, null, false);
		}

		// Token: 0x060000D3 RID: 211 RVA: 0x00004654 File Offset: 0x00002854
		public static AnalyticsResult Transaction(string productId, Decimal amount, string currency, string receiptPurchaseData, string signature)
		{
			return Analytics.Transaction(productId, amount, currency, receiptPurchaseData, signature, false);
		}

		// Token: 0x060000D4 RID: 212 RVA: 0x00004674 File Offset: 0x00002874
		public static AnalyticsResult Transaction(string productId, Decimal amount, string currency, string receiptPurchaseData, string signature, bool usingIAPService)
		{
			bool flag = String.IsNullOrEmpty(productId);
			if (flag)
			{
				throw new ArgumentException("Cannot set productId to an empty or null string");
			}
			bool flag2 = String.IsNullOrEmpty(currency);
			if (flag2)
			{
				throw new ArgumentException("Cannot set currency to an empty or null string");
			}
			bool flag3 = !Analytics.IsInitialized();
			AnalyticsResult analyticsResult;
			if (flag3)
			{
				analyticsResult = AnalyticsResult.NotInitialized;
			}
			else
			{
				bool flag4 = receiptPurchaseData == null;
				if (flag4)
				{
					receiptPurchaseData = String.Empty;
				}
				bool flag5 = signature == null;
				if (flag5)
				{
					signature = String.Empty;
				}
				analyticsResult = Analytics.Transaction(productId, Convert.ToDouble(amount), currency, receiptPurchaseData, signature, usingIAPService);
			}
			return analyticsResult;
		}

		// Token: 0x060000D5 RID: 213 RVA: 0x000046F8 File Offset: 0x000028F8
		public static AnalyticsResult CustomEvent(string customEventName)
		{
			bool flag = String.IsNullOrEmpty(customEventName);
			if (flag)
			{
				throw new ArgumentException("Cannot set custom event name to an empty or null string");
			}
			bool flag2 = !Analytics.IsInitialized();
			AnalyticsResult analyticsResult;
			if (flag2)
			{
				analyticsResult = AnalyticsResult.NotInitialized;
			}
			else
			{
				analyticsResult = Analytics.SendCustomEventName(customEventName);
			}
			return analyticsResult;
		}

		// Token: 0x060000D6 RID: 214 RVA: 0x00004738 File Offset: 0x00002938
		public static AnalyticsResult CustomEvent(string customEventName, Vector3 position)
		{
			bool flag = String.IsNullOrEmpty(customEventName);
			if (flag)
			{
				throw new ArgumentException("Cannot set custom event name to an empty or null string");
			}
			bool flag2 = !Analytics.IsInitialized();
			AnalyticsResult analyticsResult;
			if (flag2)
			{
				analyticsResult = AnalyticsResult.NotInitialized;
			}
			else
			{
				CustomEventData customEventData = new CustomEventData(customEventName);
				customEventData.AddDouble("x", (double)Convert.ToDecimal(position.x));
				customEventData.AddDouble("y", (double)Convert.ToDecimal(position.y));
				customEventData.AddDouble("z", (double)Convert.ToDecimal(position.z));
				AnalyticsResult analyticsResult2 = Analytics.SendCustomEvent(customEventData);
				customEventData.Dispose();
				analyticsResult = analyticsResult2;
			}
			return analyticsResult;
		}

		// Token: 0x060000D7 RID: 215 RVA: 0x000047E0 File Offset: 0x000029E0
		public static AnalyticsResult CustomEvent(string customEventName, IDictionary<string, Object> eventData)
		{
			bool flag = String.IsNullOrEmpty(customEventName);
			if (flag)
			{
				throw new ArgumentException("Cannot set custom event name to an empty or null string");
			}
			bool flag2 = !Analytics.IsInitialized();
			AnalyticsResult analyticsResult;
			if (flag2)
			{
				analyticsResult = AnalyticsResult.NotInitialized;
			}
			else
			{
				bool flag3 = eventData == null;
				if (flag3)
				{
					analyticsResult = Analytics.SendCustomEventName(customEventName);
				}
				else
				{
					CustomEventData customEventData = new CustomEventData(customEventName);
					AnalyticsResult analyticsResult2 = AnalyticsResult.InvalidData;
					try
					{
						customEventData.AddDictionary(eventData);
						analyticsResult2 = Analytics.SendCustomEvent(customEventData);
					}
					finally
					{
						customEventData.Dispose();
					}
					analyticsResult = analyticsResult2;
				}
			}
			return analyticsResult;
		}

		// Token: 0x060000D8 RID: 216 RVA: 0x00004868 File Offset: 0x00002A68
		public static AnalyticsResult EnableCustomEvent(string customEventName, bool enabled)
		{
			bool flag = String.IsNullOrEmpty(customEventName);
			if (flag)
			{
				throw new ArgumentException("Cannot set event name to an empty or null string");
			}
			bool flag2 = !Analytics.IsInitialized();
			AnalyticsResult analyticsResult;
			if (flag2)
			{
				analyticsResult = AnalyticsResult.NotInitialized;
			}
			else
			{
				analyticsResult = Analytics.EnableCustomEventWithLimit(customEventName, enabled);
			}
			return analyticsResult;
		}

		// Token: 0x060000D9 RID: 217 RVA: 0x000048A8 File Offset: 0x00002AA8
		public static AnalyticsResult IsCustomEventEnabled(string customEventName)
		{
			bool flag = String.IsNullOrEmpty(customEventName);
			if (flag)
			{
				throw new ArgumentException("Cannot set event name to an empty or null string");
			}
			bool flag2 = !Analytics.IsInitialized();
			AnalyticsResult analyticsResult;
			if (flag2)
			{
				analyticsResult = AnalyticsResult.NotInitialized;
			}
			else
			{
				analyticsResult = Analytics.IsCustomEventWithLimitEnabled(customEventName);
			}
			return analyticsResult;
		}

		// Token: 0x060000DA RID: 218 RVA: 0x000048E8 File Offset: 0x00002AE8
		public static AnalyticsResult RegisterEvent(string eventName, int maxEventPerHour, int maxItems, [Optional] string vendorKey, [Optional] string prefix)
		{
			string text = String.Empty;
			text = Assembly.GetCallingAssembly().FullName;
			return Analytics.RegisterEvent(eventName, maxEventPerHour, maxItems, vendorKey, 1, prefix, text);
		}

		// Token: 0x060000DB RID: 219 RVA: 0x00004918 File Offset: 0x00002B18
		public static AnalyticsResult RegisterEvent(string eventName, int maxEventPerHour, int maxItems, string vendorKey, int ver, [Optional] string prefix)
		{
			string text = String.Empty;
			text = Assembly.GetCallingAssembly().FullName;
			return Analytics.RegisterEvent(eventName, maxEventPerHour, maxItems, vendorKey, ver, prefix, text);
		}

		// Token: 0x060000DC RID: 220 RVA: 0x0000494C File Offset: 0x00002B4C
		public static AnalyticsResult RegisterEvent(string eventName, int maxEventPerHour, int maxItems, string vendorKey, int ver, string prefix, string assemblyInfo)
		{
			bool flag = String.IsNullOrEmpty(eventName);
			if (flag)
			{
				throw new ArgumentException("Cannot set event name to an empty or null string");
			}
			bool flag2 = !Analytics.IsInitialized();
			AnalyticsResult analyticsResult;
			if (flag2)
			{
				analyticsResult = AnalyticsResult.NotInitialized;
			}
			else
			{
				analyticsResult = Analytics.RegisterEventWithLimit(eventName, maxEventPerHour, maxItems, vendorKey, ver, prefix, assemblyInfo, true);
			}
			return analyticsResult;
		}

		// Token: 0x060000DD RID: 221 RVA: 0x00004994 File Offset: 0x00002B94
		public static AnalyticsResult SendEvent(string eventName, Object parameters, [Optional] int ver, [Optional] string prefix)
		{
			bool flag = String.IsNullOrEmpty(eventName);
			if (flag)
			{
				throw new ArgumentException("Cannot set event name to an empty or null string");
			}
			bool flag2 = parameters == null;
			if (flag2)
			{
				throw new ArgumentException("Cannot set parameters to null");
			}
			bool flag3 = !Analytics.IsInitialized();
			AnalyticsResult analyticsResult;
			if (flag3)
			{
				analyticsResult = AnalyticsResult.NotInitialized;
			}
			else
			{
				analyticsResult = Analytics.SendEventWithLimit(eventName, parameters, ver, prefix);
			}
			return analyticsResult;
		}

		// Token: 0x060000DE RID: 222 RVA: 0x000049E8 File Offset: 0x00002BE8
		public static AnalyticsResult SetEventEndPoint(string eventName, string endPoint, [Optional] int ver, [Optional] string prefix)
		{
			bool flag = String.IsNullOrEmpty(eventName);
			if (flag)
			{
				throw new ArgumentException("Cannot set event name to an empty or null string");
			}
			bool flag2 = endPoint == null;
			if (flag2)
			{
				throw new ArgumentException("Cannot set parameters to null");
			}
			bool flag3 = !Analytics.IsInitialized();
			AnalyticsResult analyticsResult;
			if (flag3)
			{
				analyticsResult = AnalyticsResult.NotInitialized;
			}
			else
			{
				analyticsResult = Analytics.SetEventWithLimitEndPoint(eventName, endPoint, ver, prefix);
			}
			return analyticsResult;
		}

		// Token: 0x060000DF RID: 223 RVA: 0x00004A3C File Offset: 0x00002C3C
		public static AnalyticsResult SetEventPriority(string eventName, AnalyticsEventPriority eventPriority, [Optional] int ver, [Optional] string prefix)
		{
			bool flag = String.IsNullOrEmpty(eventName);
			if (flag)
			{
				throw new ArgumentException("Cannot set event name to an empty or null string");
			}
			bool flag2 = !Analytics.IsInitialized();
			AnalyticsResult analyticsResult;
			if (flag2)
			{
				analyticsResult = AnalyticsResult.NotInitialized;
			}
			else
			{
				analyticsResult = Analytics.SetEventWithLimitPriority(eventName, eventPriority, ver, prefix);
			}
			return analyticsResult;
		}

		// Token: 0x060000E0 RID: 224 RVA: 0x00004A7C File Offset: 0x00002C7C
		public static AnalyticsResult EnableEvent(string eventName, bool enabled, [Optional] int ver, [Optional] string prefix)
		{
			bool flag = String.IsNullOrEmpty(eventName);
			if (flag)
			{
				throw new ArgumentException("Cannot set event name to an empty or null string");
			}
			bool flag2 = !Analytics.IsInitialized();
			AnalyticsResult analyticsResult;
			if (flag2)
			{
				analyticsResult = AnalyticsResult.NotInitialized;
			}
			else
			{
				analyticsResult = Analytics.EnableEventWithLimit(eventName, enabled, ver, prefix);
			}
			return analyticsResult;
		}

		// Token: 0x060000E1 RID: 225 RVA: 0x00004ABC File Offset: 0x00002CBC
		public static AnalyticsResult IsEventEnabled(string eventName, [Optional] int ver, [Optional] string prefix)
		{
			bool flag = String.IsNullOrEmpty(eventName);
			if (flag)
			{
				throw new ArgumentException("Cannot set event name to an empty or null string");
			}
			bool flag2 = !Analytics.IsInitialized();
			AnalyticsResult analyticsResult;
			if (flag2)
			{
				analyticsResult = AnalyticsResult.NotInitialized;
			}
			else
			{
				analyticsResult = Analytics.IsEventWithLimitEnabled(eventName, ver, prefix);
			}
			return analyticsResult;
		}

		// Token: 0x0400005D RID: 93
		private static readonly Analytics.ResumeInitializationInternalDelegate ResumeInitializationInternalDelegateField = IL2CPP.ResolveICall<Analytics.ResumeInitializationInternalDelegate>("UnityEngine.Analytics.Analytics::ResumeInitializationInternal");

		// Token: 0x0400005E RID: 94
		private static readonly Analytics.get_initializeOnStartupInternalDelegate get_initializeOnStartupInternalDelegateField = IL2CPP.ResolveICall<Analytics.get_initializeOnStartupInternalDelegate>("UnityEngine.Analytics.Analytics::get_initializeOnStartupInternal");

		// Token: 0x0400005F RID: 95
		private static readonly Analytics.set_initializeOnStartupInternalDelegate set_initializeOnStartupInternalDelegateField = IL2CPP.ResolveICall<Analytics.set_initializeOnStartupInternalDelegate>("UnityEngine.Analytics.Analytics::set_initializeOnStartupInternal");

		// Token: 0x04000060 RID: 96
		private static readonly Analytics.IsInitializedDelegate IsInitializedDelegateField = IL2CPP.ResolveICall<Analytics.IsInitializedDelegate>("UnityEngine.Analytics.Analytics::IsInitialized");

		// Token: 0x04000061 RID: 97
		private static readonly Analytics.get_enabledInternalDelegate get_enabledInternalDelegateField = IL2CPP.ResolveICall<Analytics.get_enabledInternalDelegate>("UnityEngine.Analytics.Analytics::get_enabledInternal");

		// Token: 0x04000062 RID: 98
		private static readonly Analytics.set_enabledInternalDelegate set_enabledInternalDelegateField = IL2CPP.ResolveICall<Analytics.set_enabledInternalDelegate>("UnityEngine.Analytics.Analytics::set_enabledInternal");

		// Token: 0x04000063 RID: 99
		private static readonly Analytics.get_playerOptedOutInternalDelegate get_playerOptedOutInternalDelegateField = IL2CPP.ResolveICall<Analytics.get_playerOptedOutInternalDelegate>("UnityEngine.Analytics.Analytics::get_playerOptedOutInternal");

		// Token: 0x04000064 RID: 100
		private static readonly Analytics.get_eventUrlInternalDelegate get_eventUrlInternalDelegateField = IL2CPP.ResolveICall<Analytics.get_eventUrlInternalDelegate>("UnityEngine.Analytics.Analytics::get_eventUrlInternal");

		// Token: 0x04000065 RID: 101
		private static readonly Analytics.get_configUrlInternalDelegate get_configUrlInternalDelegateField = IL2CPP.ResolveICall<Analytics.get_configUrlInternalDelegate>("UnityEngine.Analytics.Analytics::get_configUrlInternal");

		// Token: 0x04000066 RID: 102
		private static readonly Analytics.get_dashboardUrlInternalDelegate get_dashboardUrlInternalDelegateField = IL2CPP.ResolveICall<Analytics.get_dashboardUrlInternalDelegate>("UnityEngine.Analytics.Analytics::get_dashboardUrlInternal");

		// Token: 0x04000067 RID: 103
		private static readonly Analytics.get_limitUserTrackingInternalDelegate get_limitUserTrackingInternalDelegateField = IL2CPP.ResolveICall<Analytics.get_limitUserTrackingInternalDelegate>("UnityEngine.Analytics.Analytics::get_limitUserTrackingInternal");

		// Token: 0x04000068 RID: 104
		private static readonly Analytics.set_limitUserTrackingInternalDelegate set_limitUserTrackingInternalDelegateField = IL2CPP.ResolveICall<Analytics.set_limitUserTrackingInternalDelegate>("UnityEngine.Analytics.Analytics::set_limitUserTrackingInternal");

		// Token: 0x04000069 RID: 105
		private static readonly Analytics.get_deviceStatsEnabledInternalDelegate get_deviceStatsEnabledInternalDelegateField = IL2CPP.ResolveICall<Analytics.get_deviceStatsEnabledInternalDelegate>("UnityEngine.Analytics.Analytics::get_deviceStatsEnabledInternal");

		// Token: 0x0400006A RID: 106
		private static readonly Analytics.set_deviceStatsEnabledInternalDelegate set_deviceStatsEnabledInternalDelegateField = IL2CPP.ResolveICall<Analytics.set_deviceStatsEnabledInternalDelegate>("UnityEngine.Analytics.Analytics::set_deviceStatsEnabledInternal");

		// Token: 0x0400006B RID: 107
		private static readonly Analytics.FlushArchivedEventsDelegate FlushArchivedEventsDelegateField = IL2CPP.ResolveICall<Analytics.FlushArchivedEventsDelegate>("UnityEngine.Analytics.Analytics::FlushArchivedEvents");

		// Token: 0x0400006C RID: 108
		private static readonly Analytics.TransactionDelegate TransactionDelegateField = IL2CPP.ResolveICall<Analytics.TransactionDelegate>("UnityEngine.Analytics.Analytics::Transaction");

		// Token: 0x0400006D RID: 109
		private static readonly Analytics.SendCustomEventNameDelegate SendCustomEventNameDelegateField = IL2CPP.ResolveICall<Analytics.SendCustomEventNameDelegate>("UnityEngine.Analytics.Analytics::SendCustomEventName");

		// Token: 0x0400006E RID: 110
		private static readonly Analytics.SendCustomEventDelegate SendCustomEventDelegateField = IL2CPP.ResolveICall<Analytics.SendCustomEventDelegate>("UnityEngine.Analytics.Analytics::SendCustomEvent");

		// Token: 0x0400006F RID: 111
		private static readonly Analytics.IsCustomEventWithLimitEnabledDelegate IsCustomEventWithLimitEnabledDelegateField = IL2CPP.ResolveICall<Analytics.IsCustomEventWithLimitEnabledDelegate>("UnityEngine.Analytics.Analytics::IsCustomEventWithLimitEnabled");

		// Token: 0x04000070 RID: 112
		private static readonly Analytics.EnableCustomEventWithLimitDelegate EnableCustomEventWithLimitDelegateField = IL2CPP.ResolveICall<Analytics.EnableCustomEventWithLimitDelegate>("UnityEngine.Analytics.Analytics::EnableCustomEventWithLimit");

		// Token: 0x04000071 RID: 113
		private static readonly Analytics.IsEventWithLimitEnabledDelegate IsEventWithLimitEnabledDelegateField = IL2CPP.ResolveICall<Analytics.IsEventWithLimitEnabledDelegate>("UnityEngine.Analytics.Analytics::IsEventWithLimitEnabled");

		// Token: 0x04000072 RID: 114
		private static readonly Analytics.EnableEventWithLimitDelegate EnableEventWithLimitDelegateField = IL2CPP.ResolveICall<Analytics.EnableEventWithLimitDelegate>("UnityEngine.Analytics.Analytics::EnableEventWithLimit");

		// Token: 0x04000073 RID: 115
		private static readonly Analytics.RegisterEventWithLimitDelegate RegisterEventWithLimitDelegateField = IL2CPP.ResolveICall<Analytics.RegisterEventWithLimitDelegate>("UnityEngine.Analytics.Analytics::RegisterEventWithLimit");

		// Token: 0x04000074 RID: 116
		private static readonly Analytics.RegisterEventsWithLimitDelegate RegisterEventsWithLimitDelegateField = IL2CPP.ResolveICall<Analytics.RegisterEventsWithLimitDelegate>("UnityEngine.Analytics.Analytics::RegisterEventsWithLimit");

		// Token: 0x04000075 RID: 117
		private static readonly Analytics.SendEventWithLimitDelegate SendEventWithLimitDelegateField = IL2CPP.ResolveICall<Analytics.SendEventWithLimitDelegate>("UnityEngine.Analytics.Analytics::SendEventWithLimit");

		// Token: 0x04000076 RID: 118
		private static readonly Analytics.SetEventWithLimitEndPointDelegate SetEventWithLimitEndPointDelegateField = IL2CPP.ResolveICall<Analytics.SetEventWithLimitEndPointDelegate>("UnityEngine.Analytics.Analytics::SetEventWithLimitEndPoint");

		// Token: 0x04000077 RID: 119
		private static readonly Analytics.SetEventWithLimitPriorityDelegate SetEventWithLimitPriorityDelegateField = IL2CPP.ResolveICall<Analytics.SetEventWithLimitPriorityDelegate>("UnityEngine.Analytics.Analytics::SetEventWithLimitPriority");

		// Token: 0x04000078 RID: 120
		private static readonly Analytics.QueueEventDelegate QueueEventDelegateField = IL2CPP.ResolveICall<Analytics.QueueEventDelegate>("UnityEngine.Analytics.Analytics::QueueEvent");

		// Token: 0x0200005B RID: 91
		// (Invoke) Token: 0x0600018C RID: 396
		private delegate AnalyticsResult ResumeInitializationInternalDelegate();

		// Token: 0x0200005C RID: 92
		// (Invoke) Token: 0x0600018E RID: 398
		private delegate bool get_initializeOnStartupInternalDelegate();

		// Token: 0x0200005D RID: 93
		// (Invoke) Token: 0x06000190 RID: 400
		private delegate void set_initializeOnStartupInternalDelegate(bool value);

		// Token: 0x0200005E RID: 94
		// (Invoke) Token: 0x06000192 RID: 402
		private delegate bool IsInitializedDelegate();

		// Token: 0x0200005F RID: 95
		// (Invoke) Token: 0x06000194 RID: 404
		private delegate bool get_enabledInternalDelegate();

		// Token: 0x02000060 RID: 96
		// (Invoke) Token: 0x06000196 RID: 406
		private delegate void set_enabledInternalDelegate(bool value);

		// Token: 0x02000061 RID: 97
		// (Invoke) Token: 0x06000198 RID: 408
		private delegate bool get_playerOptedOutInternalDelegate();

		// Token: 0x02000062 RID: 98
		// (Invoke) Token: 0x0600019A RID: 410
		private delegate IntPtr get_eventUrlInternalDelegate();

		// Token: 0x02000063 RID: 99
		// (Invoke) Token: 0x0600019C RID: 412
		private delegate IntPtr get_configUrlInternalDelegate();

		// Token: 0x02000064 RID: 100
		// (Invoke) Token: 0x0600019E RID: 414
		private delegate IntPtr get_dashboardUrlInternalDelegate();

		// Token: 0x02000065 RID: 101
		// (Invoke) Token: 0x060001A0 RID: 416
		private delegate bool get_limitUserTrackingInternalDelegate();

		// Token: 0x02000066 RID: 102
		// (Invoke) Token: 0x060001A2 RID: 418
		private delegate void set_limitUserTrackingInternalDelegate(bool value);

		// Token: 0x02000067 RID: 103
		// (Invoke) Token: 0x060001A4 RID: 420
		private delegate bool get_deviceStatsEnabledInternalDelegate();

		// Token: 0x02000068 RID: 104
		// (Invoke) Token: 0x060001A6 RID: 422
		private delegate void set_deviceStatsEnabledInternalDelegate(bool value);

		// Token: 0x02000069 RID: 105
		// (Invoke) Token: 0x060001A8 RID: 424
		private delegate bool FlushArchivedEventsDelegate();

		// Token: 0x0200006A RID: 106
		// (Invoke) Token: 0x060001AA RID: 426
		private delegate AnalyticsResult TransactionDelegate(IntPtr productId, double amount, IntPtr currency, IntPtr receiptPurchaseData, IntPtr signature, bool usingIAPService);

		// Token: 0x0200006B RID: 107
		// (Invoke) Token: 0x060001AC RID: 428
		private delegate AnalyticsResult SendCustomEventNameDelegate(IntPtr customEventName);

		// Token: 0x0200006C RID: 108
		// (Invoke) Token: 0x060001AE RID: 430
		private delegate AnalyticsResult SendCustomEventDelegate(IntPtr eventData);

		// Token: 0x0200006D RID: 109
		// (Invoke) Token: 0x060001B0 RID: 432
		private delegate AnalyticsResult IsCustomEventWithLimitEnabledDelegate(IntPtr customEventName);

		// Token: 0x0200006E RID: 110
		// (Invoke) Token: 0x060001B2 RID: 434
		private delegate AnalyticsResult EnableCustomEventWithLimitDelegate(IntPtr customEventName, bool enable);

		// Token: 0x0200006F RID: 111
		// (Invoke) Token: 0x060001B4 RID: 436
		private delegate AnalyticsResult IsEventWithLimitEnabledDelegate(IntPtr eventName, int ver, IntPtr prefix);

		// Token: 0x02000070 RID: 112
		// (Invoke) Token: 0x060001B6 RID: 438
		private delegate AnalyticsResult EnableEventWithLimitDelegate(IntPtr eventName, bool enable, int ver, IntPtr prefix);

		// Token: 0x02000071 RID: 113
		// (Invoke) Token: 0x060001B8 RID: 440
		private delegate AnalyticsResult RegisterEventWithLimitDelegate(IntPtr eventName, int maxEventPerHour, int maxItems, IntPtr vendorKey, int ver, IntPtr prefix, IntPtr assemblyInfo, bool notifyServer);

		// Token: 0x02000072 RID: 114
		// (Invoke) Token: 0x060001BA RID: 442
		private delegate AnalyticsResult RegisterEventsWithLimitDelegate(IntPtr eventName, int maxEventPerHour, int maxItems, IntPtr vendorKey, int ver, IntPtr prefix, IntPtr assemblyInfo, bool notifyServer);

		// Token: 0x02000073 RID: 115
		// (Invoke) Token: 0x060001BC RID: 444
		private delegate AnalyticsResult SendEventWithLimitDelegate(IntPtr eventName, IntPtr parameters, int ver, IntPtr prefix);

		// Token: 0x02000074 RID: 116
		// (Invoke) Token: 0x060001BE RID: 446
		private delegate AnalyticsResult SetEventWithLimitEndPointDelegate(IntPtr eventName, IntPtr endPoint, int ver, IntPtr prefix);

		// Token: 0x02000075 RID: 117
		// (Invoke) Token: 0x060001C0 RID: 448
		private delegate AnalyticsResult SetEventWithLimitPriorityDelegate(IntPtr eventName, AnalyticsEventPriority eventPriority, int ver, IntPtr prefix);

		// Token: 0x02000076 RID: 118
		// (Invoke) Token: 0x060001C2 RID: 450
		private delegate bool QueueEventDelegate(IntPtr eventName, IntPtr parameters, int ver, IntPtr prefix);
	}
}
