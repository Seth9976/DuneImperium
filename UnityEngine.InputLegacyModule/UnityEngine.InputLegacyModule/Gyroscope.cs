using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;

namespace UnityEngine
{
	// Token: 0x0200000E RID: 14
	public class Gyroscope
	{
		// Token: 0x0600009F RID: 159 RVA: 0x00004644 File Offset: 0x00002844
		public static Vector3 rotationRate_Internal(int idx)
		{
			Vector3 vector;
			Gyroscope.rotationRate_Internal_Injected(idx, out vector);
			return vector;
		}

		// Token: 0x060000A0 RID: 160 RVA: 0x0000465C File Offset: 0x0000285C
		public static Vector3 rotationRateUnbiased_Internal(int idx)
		{
			Vector3 vector;
			Gyroscope.rotationRateUnbiased_Internal_Injected(idx, out vector);
			return vector;
		}

		// Token: 0x060000A1 RID: 161 RVA: 0x00004674 File Offset: 0x00002874
		public static Vector3 gravity_Internal(int idx)
		{
			Vector3 vector;
			Gyroscope.gravity_Internal_Injected(idx, out vector);
			return vector;
		}

		// Token: 0x060000A2 RID: 162 RVA: 0x0000468C File Offset: 0x0000288C
		public static Vector3 userAcceleration_Internal(int idx)
		{
			Vector3 vector;
			Gyroscope.userAcceleration_Internal_Injected(idx, out vector);
			return vector;
		}

		// Token: 0x060000A3 RID: 163 RVA: 0x000046A4 File Offset: 0x000028A4
		public static Quaternion attitude_Internal(int idx)
		{
			Quaternion quaternion;
			Gyroscope.attitude_Internal_Injected(idx, out quaternion);
			return quaternion;
		}

		// Token: 0x060000A4 RID: 164 RVA: 0x00002306 File Offset: 0x00000506
		public static bool getEnabled_Internal(int idx)
		{
			return Gyroscope.getEnabled_InternalDelegateField(idx);
		}

		// Token: 0x060000A5 RID: 165 RVA: 0x00002313 File Offset: 0x00000513
		public static void setEnabled_Internal(int idx, bool enabled)
		{
			Gyroscope.setEnabled_InternalDelegateField(idx, enabled);
		}

		// Token: 0x060000A6 RID: 166 RVA: 0x00002321 File Offset: 0x00000521
		public static float getUpdateInterval_Internal(int idx)
		{
			return Gyroscope.getUpdateInterval_InternalDelegateField(idx);
		}

		// Token: 0x060000A7 RID: 167 RVA: 0x0000232E File Offset: 0x0000052E
		public static void setUpdateInterval_Internal(int idx, float interval)
		{
			Gyroscope.setUpdateInterval_InternalDelegateField(idx, interval);
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x060000A8 RID: 168 RVA: 0x0000233C File Offset: 0x0000053C
		public Vector3 rotationRate
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x060000A9 RID: 169 RVA: 0x00002349 File Offset: 0x00000549
		public Vector3 rotationRateUnbiased
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x060000AA RID: 170 RVA: 0x00002356 File Offset: 0x00000556
		public Vector3 gravity
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x060000AB RID: 171 RVA: 0x00002363 File Offset: 0x00000563
		public Vector3 userAcceleration
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x060000AC RID: 172 RVA: 0x00002370 File Offset: 0x00000570
		public Quaternion attitude
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x060000AD RID: 173 RVA: 0x0000237D File Offset: 0x0000057D
		// (set) Token: 0x060000AE RID: 174 RVA: 0x0000238A File Offset: 0x0000058A
		public bool enabled
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
			set
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x060000AF RID: 175 RVA: 0x00002397 File Offset: 0x00000597
		// (set) Token: 0x060000B0 RID: 176 RVA: 0x000023A4 File Offset: 0x000005A4
		public float updateInterval
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
			set
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x060000B1 RID: 177 RVA: 0x000023B1 File Offset: 0x000005B1
		public static void rotationRate_Internal_Injected(int idx, out Vector3 ret)
		{
			Gyroscope.rotationRate_Internal_InjectedDelegateField(idx, out ret);
		}

		// Token: 0x060000B2 RID: 178 RVA: 0x000023BF File Offset: 0x000005BF
		public static void rotationRateUnbiased_Internal_Injected(int idx, out Vector3 ret)
		{
			Gyroscope.rotationRateUnbiased_Internal_InjectedDelegateField(idx, out ret);
		}

		// Token: 0x060000B3 RID: 179 RVA: 0x000023CD File Offset: 0x000005CD
		public static void gravity_Internal_Injected(int idx, out Vector3 ret)
		{
			Gyroscope.gravity_Internal_InjectedDelegateField(idx, out ret);
		}

		// Token: 0x060000B4 RID: 180 RVA: 0x000023DB File Offset: 0x000005DB
		public static void userAcceleration_Internal_Injected(int idx, out Vector3 ret)
		{
			Gyroscope.userAcceleration_Internal_InjectedDelegateField(idx, out ret);
		}

		// Token: 0x060000B5 RID: 181 RVA: 0x000023E9 File Offset: 0x000005E9
		public static void attitude_Internal_Injected(int idx, out Quaternion ret)
		{
			Gyroscope.attitude_Internal_InjectedDelegateField(idx, out ret);
		}

		// Token: 0x040000C2 RID: 194
		private static readonly Gyroscope.getEnabled_InternalDelegate getEnabled_InternalDelegateField = IL2CPP.ResolveICall<Gyroscope.getEnabled_InternalDelegate>("UnityEngine.Gyroscope::getEnabled_Internal");

		// Token: 0x040000C3 RID: 195
		private static readonly Gyroscope.setEnabled_InternalDelegate setEnabled_InternalDelegateField = IL2CPP.ResolveICall<Gyroscope.setEnabled_InternalDelegate>("UnityEngine.Gyroscope::setEnabled_Internal");

		// Token: 0x040000C4 RID: 196
		private static readonly Gyroscope.getUpdateInterval_InternalDelegate getUpdateInterval_InternalDelegateField = IL2CPP.ResolveICall<Gyroscope.getUpdateInterval_InternalDelegate>("UnityEngine.Gyroscope::getUpdateInterval_Internal");

		// Token: 0x040000C5 RID: 197
		private static readonly Gyroscope.setUpdateInterval_InternalDelegate setUpdateInterval_InternalDelegateField = IL2CPP.ResolveICall<Gyroscope.setUpdateInterval_InternalDelegate>("UnityEngine.Gyroscope::setUpdateInterval_Internal");

		// Token: 0x040000C6 RID: 198
		private static readonly Gyroscope.rotationRate_Internal_InjectedDelegate rotationRate_Internal_InjectedDelegateField = IL2CPP.ResolveICall<Gyroscope.rotationRate_Internal_InjectedDelegate>("UnityEngine.Gyroscope::rotationRate_Internal_Injected");

		// Token: 0x040000C7 RID: 199
		private static readonly Gyroscope.rotationRateUnbiased_Internal_InjectedDelegate rotationRateUnbiased_Internal_InjectedDelegateField = IL2CPP.ResolveICall<Gyroscope.rotationRateUnbiased_Internal_InjectedDelegate>("UnityEngine.Gyroscope::rotationRateUnbiased_Internal_Injected");

		// Token: 0x040000C8 RID: 200
		private static readonly Gyroscope.gravity_Internal_InjectedDelegate gravity_Internal_InjectedDelegateField = IL2CPP.ResolveICall<Gyroscope.gravity_Internal_InjectedDelegate>("UnityEngine.Gyroscope::gravity_Internal_Injected");

		// Token: 0x040000C9 RID: 201
		private static readonly Gyroscope.userAcceleration_Internal_InjectedDelegate userAcceleration_Internal_InjectedDelegateField = IL2CPP.ResolveICall<Gyroscope.userAcceleration_Internal_InjectedDelegate>("UnityEngine.Gyroscope::userAcceleration_Internal_Injected");

		// Token: 0x040000CA RID: 202
		private static readonly Gyroscope.attitude_Internal_InjectedDelegate attitude_Internal_InjectedDelegateField = IL2CPP.ResolveICall<Gyroscope.attitude_Internal_InjectedDelegate>("UnityEngine.Gyroscope::attitude_Internal_Injected");

		// Token: 0x0200002B RID: 43
		// (Invoke) Token: 0x06000105 RID: 261
		private delegate bool getEnabled_InternalDelegate(int idx);

		// Token: 0x0200002C RID: 44
		// (Invoke) Token: 0x06000107 RID: 263
		private delegate void setEnabled_InternalDelegate(int idx, bool enabled);

		// Token: 0x0200002D RID: 45
		// (Invoke) Token: 0x06000109 RID: 265
		private delegate float getUpdateInterval_InternalDelegate(int idx);

		// Token: 0x0200002E RID: 46
		// (Invoke) Token: 0x0600010B RID: 267
		private delegate void setUpdateInterval_InternalDelegate(int idx, float interval);

		// Token: 0x0200002F RID: 47
		// (Invoke) Token: 0x0600010D RID: 269
		private delegate void rotationRate_Internal_InjectedDelegate(int idx, [Out] IntPtr ret);

		// Token: 0x02000030 RID: 48
		// (Invoke) Token: 0x0600010F RID: 271
		private delegate void rotationRateUnbiased_Internal_InjectedDelegate(int idx, [Out] IntPtr ret);

		// Token: 0x02000031 RID: 49
		// (Invoke) Token: 0x06000111 RID: 273
		private delegate void gravity_Internal_InjectedDelegate(int idx, [Out] IntPtr ret);

		// Token: 0x02000032 RID: 50
		// (Invoke) Token: 0x06000113 RID: 275
		private delegate void userAcceleration_Internal_InjectedDelegate(int idx, [Out] IntPtr ret);

		// Token: 0x02000033 RID: 51
		// (Invoke) Token: 0x06000115 RID: 277
		private delegate void attitude_Internal_InjectedDelegate(int idx, [Out] IntPtr ret);
	}
}
