using System;
using Il2CppInterop.Runtime;

namespace UnityEngine
{
	// Token: 0x0200002E RID: 46
	public class BuoyancyEffector2D : Effector2D
	{
		// Token: 0x170000E6 RID: 230
		// (get) Token: 0x06000443 RID: 1091 RVA: 0x00004750 File Offset: 0x00002950
		// (set) Token: 0x06000444 RID: 1092 RVA: 0x00004762 File Offset: 0x00002962
		public float surfaceLevel
		{
			get
			{
				return BuoyancyEffector2D.get_surfaceLevelDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				BuoyancyEffector2D.set_surfaceLevelDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000E7 RID: 231
		// (get) Token: 0x06000445 RID: 1093 RVA: 0x00004775 File Offset: 0x00002975
		// (set) Token: 0x06000446 RID: 1094 RVA: 0x00004787 File Offset: 0x00002987
		public float density
		{
			get
			{
				return BuoyancyEffector2D.get_densityDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				BuoyancyEffector2D.set_densityDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000E8 RID: 232
		// (get) Token: 0x06000447 RID: 1095 RVA: 0x0000479A File Offset: 0x0000299A
		// (set) Token: 0x06000448 RID: 1096 RVA: 0x000047AC File Offset: 0x000029AC
		public float linearDrag
		{
			get
			{
				return BuoyancyEffector2D.get_linearDragDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				BuoyancyEffector2D.set_linearDragDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000E9 RID: 233
		// (get) Token: 0x06000449 RID: 1097 RVA: 0x000047BF File Offset: 0x000029BF
		// (set) Token: 0x0600044A RID: 1098 RVA: 0x000047D1 File Offset: 0x000029D1
		public float angularDrag
		{
			get
			{
				return BuoyancyEffector2D.get_angularDragDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				BuoyancyEffector2D.set_angularDragDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000EA RID: 234
		// (get) Token: 0x0600044B RID: 1099 RVA: 0x000047E4 File Offset: 0x000029E4
		// (set) Token: 0x0600044C RID: 1100 RVA: 0x000047F6 File Offset: 0x000029F6
		public float flowAngle
		{
			get
			{
				return BuoyancyEffector2D.get_flowAngleDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				BuoyancyEffector2D.set_flowAngleDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000EB RID: 235
		// (get) Token: 0x0600044D RID: 1101 RVA: 0x00004809 File Offset: 0x00002A09
		// (set) Token: 0x0600044E RID: 1102 RVA: 0x0000481B File Offset: 0x00002A1B
		public float flowMagnitude
		{
			get
			{
				return BuoyancyEffector2D.get_flowMagnitudeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				BuoyancyEffector2D.set_flowMagnitudeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000EC RID: 236
		// (get) Token: 0x0600044F RID: 1103 RVA: 0x0000482E File Offset: 0x00002A2E
		// (set) Token: 0x06000450 RID: 1104 RVA: 0x00004840 File Offset: 0x00002A40
		public float flowVariation
		{
			get
			{
				return BuoyancyEffector2D.get_flowVariationDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				BuoyancyEffector2D.set_flowVariationDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x04000259 RID: 601
		private static readonly BuoyancyEffector2D.get_surfaceLevelDelegate get_surfaceLevelDelegateField = IL2CPP.ResolveICall<BuoyancyEffector2D.get_surfaceLevelDelegate>("UnityEngine.BuoyancyEffector2D::get_surfaceLevel");

		// Token: 0x0400025A RID: 602
		private static readonly BuoyancyEffector2D.set_surfaceLevelDelegate set_surfaceLevelDelegateField = IL2CPP.ResolveICall<BuoyancyEffector2D.set_surfaceLevelDelegate>("UnityEngine.BuoyancyEffector2D::set_surfaceLevel");

		// Token: 0x0400025B RID: 603
		private static readonly BuoyancyEffector2D.get_densityDelegate get_densityDelegateField = IL2CPP.ResolveICall<BuoyancyEffector2D.get_densityDelegate>("UnityEngine.BuoyancyEffector2D::get_density");

		// Token: 0x0400025C RID: 604
		private static readonly BuoyancyEffector2D.set_densityDelegate set_densityDelegateField = IL2CPP.ResolveICall<BuoyancyEffector2D.set_densityDelegate>("UnityEngine.BuoyancyEffector2D::set_density");

		// Token: 0x0400025D RID: 605
		private static readonly BuoyancyEffector2D.get_linearDragDelegate get_linearDragDelegateField = IL2CPP.ResolveICall<BuoyancyEffector2D.get_linearDragDelegate>("UnityEngine.BuoyancyEffector2D::get_linearDrag");

		// Token: 0x0400025E RID: 606
		private static readonly BuoyancyEffector2D.set_linearDragDelegate set_linearDragDelegateField = IL2CPP.ResolveICall<BuoyancyEffector2D.set_linearDragDelegate>("UnityEngine.BuoyancyEffector2D::set_linearDrag");

		// Token: 0x0400025F RID: 607
		private static readonly BuoyancyEffector2D.get_angularDragDelegate get_angularDragDelegateField = IL2CPP.ResolveICall<BuoyancyEffector2D.get_angularDragDelegate>("UnityEngine.BuoyancyEffector2D::get_angularDrag");

		// Token: 0x04000260 RID: 608
		private static readonly BuoyancyEffector2D.set_angularDragDelegate set_angularDragDelegateField = IL2CPP.ResolveICall<BuoyancyEffector2D.set_angularDragDelegate>("UnityEngine.BuoyancyEffector2D::set_angularDrag");

		// Token: 0x04000261 RID: 609
		private static readonly BuoyancyEffector2D.get_flowAngleDelegate get_flowAngleDelegateField = IL2CPP.ResolveICall<BuoyancyEffector2D.get_flowAngleDelegate>("UnityEngine.BuoyancyEffector2D::get_flowAngle");

		// Token: 0x04000262 RID: 610
		private static readonly BuoyancyEffector2D.set_flowAngleDelegate set_flowAngleDelegateField = IL2CPP.ResolveICall<BuoyancyEffector2D.set_flowAngleDelegate>("UnityEngine.BuoyancyEffector2D::set_flowAngle");

		// Token: 0x04000263 RID: 611
		private static readonly BuoyancyEffector2D.get_flowMagnitudeDelegate get_flowMagnitudeDelegateField = IL2CPP.ResolveICall<BuoyancyEffector2D.get_flowMagnitudeDelegate>("UnityEngine.BuoyancyEffector2D::get_flowMagnitude");

		// Token: 0x04000264 RID: 612
		private static readonly BuoyancyEffector2D.set_flowMagnitudeDelegate set_flowMagnitudeDelegateField = IL2CPP.ResolveICall<BuoyancyEffector2D.set_flowMagnitudeDelegate>("UnityEngine.BuoyancyEffector2D::set_flowMagnitude");

		// Token: 0x04000265 RID: 613
		private static readonly BuoyancyEffector2D.get_flowVariationDelegate get_flowVariationDelegateField = IL2CPP.ResolveICall<BuoyancyEffector2D.get_flowVariationDelegate>("UnityEngine.BuoyancyEffector2D::get_flowVariation");

		// Token: 0x04000266 RID: 614
		private static readonly BuoyancyEffector2D.set_flowVariationDelegate set_flowVariationDelegateField = IL2CPP.ResolveICall<BuoyancyEffector2D.set_flowVariationDelegate>("UnityEngine.BuoyancyEffector2D::set_flowVariation");

		// Token: 0x020001DD RID: 477
		// (Invoke) Token: 0x060007E2 RID: 2018
		private delegate float get_surfaceLevelDelegate(IntPtr @this);

		// Token: 0x020001DE RID: 478
		// (Invoke) Token: 0x060007E4 RID: 2020
		private delegate void set_surfaceLevelDelegate(IntPtr @this, float value);

		// Token: 0x020001DF RID: 479
		// (Invoke) Token: 0x060007E6 RID: 2022
		private delegate float get_densityDelegate(IntPtr @this);

		// Token: 0x020001E0 RID: 480
		// (Invoke) Token: 0x060007E8 RID: 2024
		private delegate void set_densityDelegate(IntPtr @this, float value);

		// Token: 0x020001E1 RID: 481
		// (Invoke) Token: 0x060007EA RID: 2026
		private delegate float get_linearDragDelegate(IntPtr @this);

		// Token: 0x020001E2 RID: 482
		// (Invoke) Token: 0x060007EC RID: 2028
		private delegate void set_linearDragDelegate(IntPtr @this, float value);

		// Token: 0x020001E3 RID: 483
		// (Invoke) Token: 0x060007EE RID: 2030
		private delegate float get_angularDragDelegate(IntPtr @this);

		// Token: 0x020001E4 RID: 484
		// (Invoke) Token: 0x060007F0 RID: 2032
		private delegate void set_angularDragDelegate(IntPtr @this, float value);

		// Token: 0x020001E5 RID: 485
		// (Invoke) Token: 0x060007F2 RID: 2034
		private delegate float get_flowAngleDelegate(IntPtr @this);

		// Token: 0x020001E6 RID: 486
		// (Invoke) Token: 0x060007F4 RID: 2036
		private delegate void set_flowAngleDelegate(IntPtr @this, float value);

		// Token: 0x020001E7 RID: 487
		// (Invoke) Token: 0x060007F6 RID: 2038
		private delegate float get_flowMagnitudeDelegate(IntPtr @this);

		// Token: 0x020001E8 RID: 488
		// (Invoke) Token: 0x060007F8 RID: 2040
		private delegate void set_flowMagnitudeDelegate(IntPtr @this, float value);

		// Token: 0x020001E9 RID: 489
		// (Invoke) Token: 0x060007FA RID: 2042
		private delegate float get_flowVariationDelegate(IntPtr @this);

		// Token: 0x020001EA RID: 490
		// (Invoke) Token: 0x060007FC RID: 2044
		private delegate void set_flowVariationDelegate(IntPtr @this, float value);
	}
}
