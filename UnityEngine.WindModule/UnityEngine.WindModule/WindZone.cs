using System;
using Il2CppInterop.Runtime;

namespace UnityEngine
{
	// Token: 0x02000003 RID: 3
	public class WindZone : Component
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000002 RID: 2 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06000003 RID: 3 RVA: 0x00002062 File Offset: 0x00000262
		public WindZoneMode mode
		{
			get
			{
				return WindZone.get_modeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				WindZone.set_modeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000004 RID: 4 RVA: 0x00002075 File Offset: 0x00000275
		// (set) Token: 0x06000005 RID: 5 RVA: 0x00002087 File Offset: 0x00000287
		public float radius
		{
			get
			{
				return WindZone.get_radiusDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				WindZone.set_radiusDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000006 RID: 6 RVA: 0x0000209A File Offset: 0x0000029A
		// (set) Token: 0x06000007 RID: 7 RVA: 0x000020AC File Offset: 0x000002AC
		public float windMain
		{
			get
			{
				return WindZone.get_windMainDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				WindZone.set_windMainDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000008 RID: 8 RVA: 0x000020BF File Offset: 0x000002BF
		// (set) Token: 0x06000009 RID: 9 RVA: 0x000020D1 File Offset: 0x000002D1
		public float windTurbulence
		{
			get
			{
				return WindZone.get_windTurbulenceDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				WindZone.set_windTurbulenceDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x0600000A RID: 10 RVA: 0x000020E4 File Offset: 0x000002E4
		// (set) Token: 0x0600000B RID: 11 RVA: 0x000020F6 File Offset: 0x000002F6
		public float windPulseMagnitude
		{
			get
			{
				return WindZone.get_windPulseMagnitudeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				WindZone.set_windPulseMagnitudeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x0600000C RID: 12 RVA: 0x00002109 File Offset: 0x00000309
		// (set) Token: 0x0600000D RID: 13 RVA: 0x0000211B File Offset: 0x0000031B
		public float windPulseFrequency
		{
			get
			{
				return WindZone.get_windPulseFrequencyDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				WindZone.set_windPulseFrequencyDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x04000004 RID: 4
		private static readonly WindZone.get_modeDelegate get_modeDelegateField = IL2CPP.ResolveICall<WindZone.get_modeDelegate>("UnityEngine.WindZone::get_mode");

		// Token: 0x04000005 RID: 5
		private static readonly WindZone.set_modeDelegate set_modeDelegateField = IL2CPP.ResolveICall<WindZone.set_modeDelegate>("UnityEngine.WindZone::set_mode");

		// Token: 0x04000006 RID: 6
		private static readonly WindZone.get_radiusDelegate get_radiusDelegateField = IL2CPP.ResolveICall<WindZone.get_radiusDelegate>("UnityEngine.WindZone::get_radius");

		// Token: 0x04000007 RID: 7
		private static readonly WindZone.set_radiusDelegate set_radiusDelegateField = IL2CPP.ResolveICall<WindZone.set_radiusDelegate>("UnityEngine.WindZone::set_radius");

		// Token: 0x04000008 RID: 8
		private static readonly WindZone.get_windMainDelegate get_windMainDelegateField = IL2CPP.ResolveICall<WindZone.get_windMainDelegate>("UnityEngine.WindZone::get_windMain");

		// Token: 0x04000009 RID: 9
		private static readonly WindZone.set_windMainDelegate set_windMainDelegateField = IL2CPP.ResolveICall<WindZone.set_windMainDelegate>("UnityEngine.WindZone::set_windMain");

		// Token: 0x0400000A RID: 10
		private static readonly WindZone.get_windTurbulenceDelegate get_windTurbulenceDelegateField = IL2CPP.ResolveICall<WindZone.get_windTurbulenceDelegate>("UnityEngine.WindZone::get_windTurbulence");

		// Token: 0x0400000B RID: 11
		private static readonly WindZone.set_windTurbulenceDelegate set_windTurbulenceDelegateField = IL2CPP.ResolveICall<WindZone.set_windTurbulenceDelegate>("UnityEngine.WindZone::set_windTurbulence");

		// Token: 0x0400000C RID: 12
		private static readonly WindZone.get_windPulseMagnitudeDelegate get_windPulseMagnitudeDelegateField = IL2CPP.ResolveICall<WindZone.get_windPulseMagnitudeDelegate>("UnityEngine.WindZone::get_windPulseMagnitude");

		// Token: 0x0400000D RID: 13
		private static readonly WindZone.set_windPulseMagnitudeDelegate set_windPulseMagnitudeDelegateField = IL2CPP.ResolveICall<WindZone.set_windPulseMagnitudeDelegate>("UnityEngine.WindZone::set_windPulseMagnitude");

		// Token: 0x0400000E RID: 14
		private static readonly WindZone.get_windPulseFrequencyDelegate get_windPulseFrequencyDelegateField = IL2CPP.ResolveICall<WindZone.get_windPulseFrequencyDelegate>("UnityEngine.WindZone::get_windPulseFrequency");

		// Token: 0x0400000F RID: 15
		private static readonly WindZone.set_windPulseFrequencyDelegate set_windPulseFrequencyDelegateField = IL2CPP.ResolveICall<WindZone.set_windPulseFrequencyDelegate>("UnityEngine.WindZone::set_windPulseFrequency");

		// Token: 0x02000004 RID: 4
		// (Invoke) Token: 0x0600000F RID: 15
		private delegate WindZoneMode get_modeDelegate(IntPtr @this);

		// Token: 0x02000005 RID: 5
		// (Invoke) Token: 0x06000011 RID: 17
		private delegate void set_modeDelegate(IntPtr @this, WindZoneMode value);

		// Token: 0x02000006 RID: 6
		// (Invoke) Token: 0x06000013 RID: 19
		private delegate float get_radiusDelegate(IntPtr @this);

		// Token: 0x02000007 RID: 7
		// (Invoke) Token: 0x06000015 RID: 21
		private delegate void set_radiusDelegate(IntPtr @this, float value);

		// Token: 0x02000008 RID: 8
		// (Invoke) Token: 0x06000017 RID: 23
		private delegate float get_windMainDelegate(IntPtr @this);

		// Token: 0x02000009 RID: 9
		// (Invoke) Token: 0x06000019 RID: 25
		private delegate void set_windMainDelegate(IntPtr @this, float value);

		// Token: 0x0200000A RID: 10
		// (Invoke) Token: 0x0600001B RID: 27
		private delegate float get_windTurbulenceDelegate(IntPtr @this);

		// Token: 0x0200000B RID: 11
		// (Invoke) Token: 0x0600001D RID: 29
		private delegate void set_windTurbulenceDelegate(IntPtr @this, float value);

		// Token: 0x0200000C RID: 12
		// (Invoke) Token: 0x0600001F RID: 31
		private delegate float get_windPulseMagnitudeDelegate(IntPtr @this);

		// Token: 0x0200000D RID: 13
		// (Invoke) Token: 0x06000021 RID: 33
		private delegate void set_windPulseMagnitudeDelegate(IntPtr @this, float value);

		// Token: 0x0200000E RID: 14
		// (Invoke) Token: 0x06000023 RID: 35
		private delegate float get_windPulseFrequencyDelegate(IntPtr @this);

		// Token: 0x0200000F RID: 15
		// (Invoke) Token: 0x06000025 RID: 37
		private delegate void set_windPulseFrequencyDelegate(IntPtr @this, float value);
	}
}
