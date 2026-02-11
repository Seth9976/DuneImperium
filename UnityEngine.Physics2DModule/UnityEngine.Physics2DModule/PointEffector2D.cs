using System;
using Il2CppInterop.Runtime;

namespace UnityEngine
{
	// Token: 0x0200002F RID: 47
	public class PointEffector2D : Effector2D
	{
		// Token: 0x170000ED RID: 237
		// (get) Token: 0x06000452 RID: 1106 RVA: 0x00004853 File Offset: 0x00002A53
		// (set) Token: 0x06000453 RID: 1107 RVA: 0x00004865 File Offset: 0x00002A65
		public float forceMagnitude
		{
			get
			{
				return PointEffector2D.get_forceMagnitudeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				PointEffector2D.set_forceMagnitudeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000EE RID: 238
		// (get) Token: 0x06000454 RID: 1108 RVA: 0x00004878 File Offset: 0x00002A78
		// (set) Token: 0x06000455 RID: 1109 RVA: 0x0000488A File Offset: 0x00002A8A
		public float forceVariation
		{
			get
			{
				return PointEffector2D.get_forceVariationDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				PointEffector2D.set_forceVariationDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000EF RID: 239
		// (get) Token: 0x06000456 RID: 1110 RVA: 0x0000489D File Offset: 0x00002A9D
		// (set) Token: 0x06000457 RID: 1111 RVA: 0x000048AF File Offset: 0x00002AAF
		public float distanceScale
		{
			get
			{
				return PointEffector2D.get_distanceScaleDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				PointEffector2D.set_distanceScaleDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000F0 RID: 240
		// (get) Token: 0x06000458 RID: 1112 RVA: 0x000048C2 File Offset: 0x00002AC2
		// (set) Token: 0x06000459 RID: 1113 RVA: 0x000048D4 File Offset: 0x00002AD4
		public float drag
		{
			get
			{
				return PointEffector2D.get_dragDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				PointEffector2D.set_dragDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000F1 RID: 241
		// (get) Token: 0x0600045A RID: 1114 RVA: 0x000048E7 File Offset: 0x00002AE7
		// (set) Token: 0x0600045B RID: 1115 RVA: 0x000048F9 File Offset: 0x00002AF9
		public float angularDrag
		{
			get
			{
				return PointEffector2D.get_angularDragDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				PointEffector2D.set_angularDragDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000F2 RID: 242
		// (get) Token: 0x0600045C RID: 1116 RVA: 0x0000490C File Offset: 0x00002B0C
		// (set) Token: 0x0600045D RID: 1117 RVA: 0x0000491E File Offset: 0x00002B1E
		public EffectorSelection2D forceSource
		{
			get
			{
				return PointEffector2D.get_forceSourceDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				PointEffector2D.set_forceSourceDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000F3 RID: 243
		// (get) Token: 0x0600045E RID: 1118 RVA: 0x00004931 File Offset: 0x00002B31
		// (set) Token: 0x0600045F RID: 1119 RVA: 0x00004943 File Offset: 0x00002B43
		public EffectorSelection2D forceTarget
		{
			get
			{
				return PointEffector2D.get_forceTargetDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				PointEffector2D.set_forceTargetDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000F4 RID: 244
		// (get) Token: 0x06000460 RID: 1120 RVA: 0x00004956 File Offset: 0x00002B56
		// (set) Token: 0x06000461 RID: 1121 RVA: 0x00004968 File Offset: 0x00002B68
		public EffectorForceMode2D forceMode
		{
			get
			{
				return PointEffector2D.get_forceModeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				PointEffector2D.set_forceModeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x04000267 RID: 615
		private static readonly PointEffector2D.get_forceMagnitudeDelegate get_forceMagnitudeDelegateField = IL2CPP.ResolveICall<PointEffector2D.get_forceMagnitudeDelegate>("UnityEngine.PointEffector2D::get_forceMagnitude");

		// Token: 0x04000268 RID: 616
		private static readonly PointEffector2D.set_forceMagnitudeDelegate set_forceMagnitudeDelegateField = IL2CPP.ResolveICall<PointEffector2D.set_forceMagnitudeDelegate>("UnityEngine.PointEffector2D::set_forceMagnitude");

		// Token: 0x04000269 RID: 617
		private static readonly PointEffector2D.get_forceVariationDelegate get_forceVariationDelegateField = IL2CPP.ResolveICall<PointEffector2D.get_forceVariationDelegate>("UnityEngine.PointEffector2D::get_forceVariation");

		// Token: 0x0400026A RID: 618
		private static readonly PointEffector2D.set_forceVariationDelegate set_forceVariationDelegateField = IL2CPP.ResolveICall<PointEffector2D.set_forceVariationDelegate>("UnityEngine.PointEffector2D::set_forceVariation");

		// Token: 0x0400026B RID: 619
		private static readonly PointEffector2D.get_distanceScaleDelegate get_distanceScaleDelegateField = IL2CPP.ResolveICall<PointEffector2D.get_distanceScaleDelegate>("UnityEngine.PointEffector2D::get_distanceScale");

		// Token: 0x0400026C RID: 620
		private static readonly PointEffector2D.set_distanceScaleDelegate set_distanceScaleDelegateField = IL2CPP.ResolveICall<PointEffector2D.set_distanceScaleDelegate>("UnityEngine.PointEffector2D::set_distanceScale");

		// Token: 0x0400026D RID: 621
		private static readonly PointEffector2D.get_dragDelegate get_dragDelegateField = IL2CPP.ResolveICall<PointEffector2D.get_dragDelegate>("UnityEngine.PointEffector2D::get_drag");

		// Token: 0x0400026E RID: 622
		private static readonly PointEffector2D.set_dragDelegate set_dragDelegateField = IL2CPP.ResolveICall<PointEffector2D.set_dragDelegate>("UnityEngine.PointEffector2D::set_drag");

		// Token: 0x0400026F RID: 623
		private static readonly PointEffector2D.get_angularDragDelegate get_angularDragDelegateField = IL2CPP.ResolveICall<PointEffector2D.get_angularDragDelegate>("UnityEngine.PointEffector2D::get_angularDrag");

		// Token: 0x04000270 RID: 624
		private static readonly PointEffector2D.set_angularDragDelegate set_angularDragDelegateField = IL2CPP.ResolveICall<PointEffector2D.set_angularDragDelegate>("UnityEngine.PointEffector2D::set_angularDrag");

		// Token: 0x04000271 RID: 625
		private static readonly PointEffector2D.get_forceSourceDelegate get_forceSourceDelegateField = IL2CPP.ResolveICall<PointEffector2D.get_forceSourceDelegate>("UnityEngine.PointEffector2D::get_forceSource");

		// Token: 0x04000272 RID: 626
		private static readonly PointEffector2D.set_forceSourceDelegate set_forceSourceDelegateField = IL2CPP.ResolveICall<PointEffector2D.set_forceSourceDelegate>("UnityEngine.PointEffector2D::set_forceSource");

		// Token: 0x04000273 RID: 627
		private static readonly PointEffector2D.get_forceTargetDelegate get_forceTargetDelegateField = IL2CPP.ResolveICall<PointEffector2D.get_forceTargetDelegate>("UnityEngine.PointEffector2D::get_forceTarget");

		// Token: 0x04000274 RID: 628
		private static readonly PointEffector2D.set_forceTargetDelegate set_forceTargetDelegateField = IL2CPP.ResolveICall<PointEffector2D.set_forceTargetDelegate>("UnityEngine.PointEffector2D::set_forceTarget");

		// Token: 0x04000275 RID: 629
		private static readonly PointEffector2D.get_forceModeDelegate get_forceModeDelegateField = IL2CPP.ResolveICall<PointEffector2D.get_forceModeDelegate>("UnityEngine.PointEffector2D::get_forceMode");

		// Token: 0x04000276 RID: 630
		private static readonly PointEffector2D.set_forceModeDelegate set_forceModeDelegateField = IL2CPP.ResolveICall<PointEffector2D.set_forceModeDelegate>("UnityEngine.PointEffector2D::set_forceMode");

		// Token: 0x020001EB RID: 491
		// (Invoke) Token: 0x060007FE RID: 2046
		private delegate float get_forceMagnitudeDelegate(IntPtr @this);

		// Token: 0x020001EC RID: 492
		// (Invoke) Token: 0x06000800 RID: 2048
		private delegate void set_forceMagnitudeDelegate(IntPtr @this, float value);

		// Token: 0x020001ED RID: 493
		// (Invoke) Token: 0x06000802 RID: 2050
		private delegate float get_forceVariationDelegate(IntPtr @this);

		// Token: 0x020001EE RID: 494
		// (Invoke) Token: 0x06000804 RID: 2052
		private delegate void set_forceVariationDelegate(IntPtr @this, float value);

		// Token: 0x020001EF RID: 495
		// (Invoke) Token: 0x06000806 RID: 2054
		private delegate float get_distanceScaleDelegate(IntPtr @this);

		// Token: 0x020001F0 RID: 496
		// (Invoke) Token: 0x06000808 RID: 2056
		private delegate void set_distanceScaleDelegate(IntPtr @this, float value);

		// Token: 0x020001F1 RID: 497
		// (Invoke) Token: 0x0600080A RID: 2058
		private delegate float get_dragDelegate(IntPtr @this);

		// Token: 0x020001F2 RID: 498
		// (Invoke) Token: 0x0600080C RID: 2060
		private delegate void set_dragDelegate(IntPtr @this, float value);

		// Token: 0x020001F3 RID: 499
		// (Invoke) Token: 0x0600080E RID: 2062
		private delegate float get_angularDragDelegate(IntPtr @this);

		// Token: 0x020001F4 RID: 500
		// (Invoke) Token: 0x06000810 RID: 2064
		private delegate void set_angularDragDelegate(IntPtr @this, float value);

		// Token: 0x020001F5 RID: 501
		// (Invoke) Token: 0x06000812 RID: 2066
		private delegate EffectorSelection2D get_forceSourceDelegate(IntPtr @this);

		// Token: 0x020001F6 RID: 502
		// (Invoke) Token: 0x06000814 RID: 2068
		private delegate void set_forceSourceDelegate(IntPtr @this, EffectorSelection2D value);

		// Token: 0x020001F7 RID: 503
		// (Invoke) Token: 0x06000816 RID: 2070
		private delegate EffectorSelection2D get_forceTargetDelegate(IntPtr @this);

		// Token: 0x020001F8 RID: 504
		// (Invoke) Token: 0x06000818 RID: 2072
		private delegate void set_forceTargetDelegate(IntPtr @this, EffectorSelection2D value);

		// Token: 0x020001F9 RID: 505
		// (Invoke) Token: 0x0600081A RID: 2074
		private delegate EffectorForceMode2D get_forceModeDelegate(IntPtr @this);

		// Token: 0x020001FA RID: 506
		// (Invoke) Token: 0x0600081C RID: 2076
		private delegate void set_forceModeDelegate(IntPtr @this, EffectorForceMode2D value);
	}
}
