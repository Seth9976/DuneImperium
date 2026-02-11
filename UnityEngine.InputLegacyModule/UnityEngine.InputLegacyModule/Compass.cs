using System;

namespace UnityEngine
{
	// Token: 0x02000011 RID: 17
	public class Compass
	{
		// Token: 0x1700003D RID: 61
		// (get) Token: 0x060000C5 RID: 197 RVA: 0x0000249E File Offset: 0x0000069E
		public float magneticHeading
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x060000C6 RID: 198 RVA: 0x000024AB File Offset: 0x000006AB
		public float trueHeading
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x060000C7 RID: 199 RVA: 0x000024B8 File Offset: 0x000006B8
		public float headingAccuracy
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x060000C8 RID: 200 RVA: 0x000024C5 File Offset: 0x000006C5
		public Vector3 rawVector
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x060000C9 RID: 201 RVA: 0x000024D2 File Offset: 0x000006D2
		public double timestamp
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x060000CA RID: 202 RVA: 0x00004774 File Offset: 0x00002974
		// (set) Token: 0x060000CB RID: 203 RVA: 0x000024DF File Offset: 0x000006DF
		public bool enabled
		{
			get
			{
				return LocationService.IsHeadingUpdatesEnabled();
			}
			set
			{
				LocationService.SetHeadingUpdatesEnabled(value);
			}
		}
	}
}
