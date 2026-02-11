using System;
using Il2CppInterop.Runtime;

namespace UnityEngine
{
	// Token: 0x02000010 RID: 16
	public class LocationService
	{
		// Token: 0x060000B7 RID: 183 RVA: 0x000023F7 File Offset: 0x000005F7
		public static bool IsServiceEnabledByUser()
		{
			return LocationService.IsServiceEnabledByUserDelegateField();
		}

		// Token: 0x060000B8 RID: 184 RVA: 0x00002403 File Offset: 0x00000603
		public static LocationServiceStatus GetLocationStatus()
		{
			return LocationService.GetLocationStatusDelegateField();
		}

		// Token: 0x060000B9 RID: 185 RVA: 0x0000240F File Offset: 0x0000060F
		public static void SetDesiredAccuracy(float value)
		{
			LocationService.SetDesiredAccuracyDelegateField(value);
		}

		// Token: 0x060000BA RID: 186 RVA: 0x0000241C File Offset: 0x0000061C
		public static void SetDistanceFilter(float value)
		{
			LocationService.SetDistanceFilterDelegateField(value);
		}

		// Token: 0x060000BB RID: 187 RVA: 0x00002429 File Offset: 0x00000629
		public static void StartUpdatingLocation()
		{
			LocationService.StartUpdatingLocationDelegateField();
		}

		// Token: 0x060000BC RID: 188 RVA: 0x00002435 File Offset: 0x00000635
		public static void StopUpdatingLocation()
		{
			LocationService.StopUpdatingLocationDelegateField();
		}

		// Token: 0x060000BD RID: 189 RVA: 0x00002441 File Offset: 0x00000641
		public static bool IsHeadingUpdatesEnabled()
		{
			return LocationService.IsHeadingUpdatesEnabledDelegateField();
		}

		// Token: 0x060000BE RID: 190 RVA: 0x0000244D File Offset: 0x0000064D
		public static void SetHeadingUpdatesEnabled(bool value)
		{
			LocationService.SetHeadingUpdatesEnabledDelegateField(value);
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x060000BF RID: 191 RVA: 0x00004744 File Offset: 0x00002944
		public bool isEnabledByUser
		{
			get
			{
				return LocationService.IsServiceEnabledByUser();
			}
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x060000C0 RID: 192 RVA: 0x0000475C File Offset: 0x0000295C
		public LocationServiceStatus status
		{
			get
			{
				return LocationService.GetLocationStatus();
			}
		}

		// Token: 0x060000C1 RID: 193 RVA: 0x0000245A File Offset: 0x0000065A
		public void Start(float desiredAccuracyInMeters, float updateDistanceInMeters)
		{
			LocationService.SetDesiredAccuracy(desiredAccuracyInMeters);
			LocationService.SetDistanceFilter(updateDistanceInMeters);
			LocationService.StartUpdatingLocation();
		}

		// Token: 0x060000C2 RID: 194 RVA: 0x00002471 File Offset: 0x00000671
		public void Start(float desiredAccuracyInMeters)
		{
			this.Start(desiredAccuracyInMeters, 10f);
		}

		// Token: 0x060000C3 RID: 195 RVA: 0x00002481 File Offset: 0x00000681
		public void Start()
		{
			this.Start(10f, 10f);
		}

		// Token: 0x060000C4 RID: 196 RVA: 0x00002495 File Offset: 0x00000695
		public void Stop()
		{
			LocationService.StopUpdatingLocation();
		}

		// Token: 0x040000D0 RID: 208
		private static readonly LocationService.IsServiceEnabledByUserDelegate IsServiceEnabledByUserDelegateField = IL2CPP.ResolveICall<LocationService.IsServiceEnabledByUserDelegate>("UnityEngine.LocationService::IsServiceEnabledByUser");

		// Token: 0x040000D1 RID: 209
		private static readonly LocationService.GetLocationStatusDelegate GetLocationStatusDelegateField = IL2CPP.ResolveICall<LocationService.GetLocationStatusDelegate>("UnityEngine.LocationService::GetLocationStatus");

		// Token: 0x040000D2 RID: 210
		private static readonly LocationService.SetDesiredAccuracyDelegate SetDesiredAccuracyDelegateField = IL2CPP.ResolveICall<LocationService.SetDesiredAccuracyDelegate>("UnityEngine.LocationService::SetDesiredAccuracy");

		// Token: 0x040000D3 RID: 211
		private static readonly LocationService.SetDistanceFilterDelegate SetDistanceFilterDelegateField = IL2CPP.ResolveICall<LocationService.SetDistanceFilterDelegate>("UnityEngine.LocationService::SetDistanceFilter");

		// Token: 0x040000D4 RID: 212
		private static readonly LocationService.StartUpdatingLocationDelegate StartUpdatingLocationDelegateField = IL2CPP.ResolveICall<LocationService.StartUpdatingLocationDelegate>("UnityEngine.LocationService::StartUpdatingLocation");

		// Token: 0x040000D5 RID: 213
		private static readonly LocationService.StopUpdatingLocationDelegate StopUpdatingLocationDelegateField = IL2CPP.ResolveICall<LocationService.StopUpdatingLocationDelegate>("UnityEngine.LocationService::StopUpdatingLocation");

		// Token: 0x040000D6 RID: 214
		private static readonly LocationService.IsHeadingUpdatesEnabledDelegate IsHeadingUpdatesEnabledDelegateField = IL2CPP.ResolveICall<LocationService.IsHeadingUpdatesEnabledDelegate>("UnityEngine.LocationService::IsHeadingUpdatesEnabled");

		// Token: 0x040000D7 RID: 215
		private static readonly LocationService.SetHeadingUpdatesEnabledDelegate SetHeadingUpdatesEnabledDelegateField = IL2CPP.ResolveICall<LocationService.SetHeadingUpdatesEnabledDelegate>("UnityEngine.LocationService::SetHeadingUpdatesEnabled");

		// Token: 0x02000034 RID: 52
		// (Invoke) Token: 0x06000117 RID: 279
		private delegate bool IsServiceEnabledByUserDelegate();

		// Token: 0x02000035 RID: 53
		// (Invoke) Token: 0x06000119 RID: 281
		private delegate LocationServiceStatus GetLocationStatusDelegate();

		// Token: 0x02000036 RID: 54
		// (Invoke) Token: 0x0600011B RID: 283
		private delegate void SetDesiredAccuracyDelegate(float value);

		// Token: 0x02000037 RID: 55
		// (Invoke) Token: 0x0600011D RID: 285
		private delegate void SetDistanceFilterDelegate(float value);

		// Token: 0x02000038 RID: 56
		// (Invoke) Token: 0x0600011F RID: 287
		private delegate void StartUpdatingLocationDelegate();

		// Token: 0x02000039 RID: 57
		// (Invoke) Token: 0x06000121 RID: 289
		private delegate void StopUpdatingLocationDelegate();

		// Token: 0x0200003A RID: 58
		// (Invoke) Token: 0x06000123 RID: 291
		private delegate bool IsHeadingUpdatesEnabledDelegate();

		// Token: 0x0200003B RID: 59
		// (Invoke) Token: 0x06000125 RID: 293
		private delegate void SetHeadingUpdatesEnabledDelegate(bool value);
	}
}
