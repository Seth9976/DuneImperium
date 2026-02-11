using System;
using Il2CppInterop.Runtime;

namespace UnityEngine
{
	// Token: 0x0200002D RID: 45
	public class AreaEffector2D : Effector2D
	{
		// Token: 0x170000DE RID: 222
		// (get) Token: 0x06000432 RID: 1074 RVA: 0x00004642 File Offset: 0x00002842
		// (set) Token: 0x06000433 RID: 1075 RVA: 0x00004654 File Offset: 0x00002854
		public float forceAngle
		{
			get
			{
				return AreaEffector2D.get_forceAngleDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				AreaEffector2D.set_forceAngleDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000DF RID: 223
		// (get) Token: 0x06000434 RID: 1076 RVA: 0x00004667 File Offset: 0x00002867
		// (set) Token: 0x06000435 RID: 1077 RVA: 0x00004679 File Offset: 0x00002879
		public bool useGlobalAngle
		{
			get
			{
				return AreaEffector2D.get_useGlobalAngleDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				AreaEffector2D.set_useGlobalAngleDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000E0 RID: 224
		// (get) Token: 0x06000436 RID: 1078 RVA: 0x0000468C File Offset: 0x0000288C
		// (set) Token: 0x06000437 RID: 1079 RVA: 0x0000469E File Offset: 0x0000289E
		public float forceMagnitude
		{
			get
			{
				return AreaEffector2D.get_forceMagnitudeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				AreaEffector2D.set_forceMagnitudeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000E1 RID: 225
		// (get) Token: 0x06000438 RID: 1080 RVA: 0x000046B1 File Offset: 0x000028B1
		// (set) Token: 0x06000439 RID: 1081 RVA: 0x000046C3 File Offset: 0x000028C3
		public float forceVariation
		{
			get
			{
				return AreaEffector2D.get_forceVariationDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				AreaEffector2D.set_forceVariationDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000E2 RID: 226
		// (get) Token: 0x0600043A RID: 1082 RVA: 0x000046D6 File Offset: 0x000028D6
		// (set) Token: 0x0600043B RID: 1083 RVA: 0x000046E8 File Offset: 0x000028E8
		public float drag
		{
			get
			{
				return AreaEffector2D.get_dragDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				AreaEffector2D.set_dragDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000E3 RID: 227
		// (get) Token: 0x0600043C RID: 1084 RVA: 0x000046FB File Offset: 0x000028FB
		// (set) Token: 0x0600043D RID: 1085 RVA: 0x0000470D File Offset: 0x0000290D
		public float angularDrag
		{
			get
			{
				return AreaEffector2D.get_angularDragDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				AreaEffector2D.set_angularDragDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000E4 RID: 228
		// (get) Token: 0x0600043E RID: 1086 RVA: 0x00004720 File Offset: 0x00002920
		// (set) Token: 0x0600043F RID: 1087 RVA: 0x00004732 File Offset: 0x00002932
		public EffectorSelection2D forceTarget
		{
			get
			{
				return AreaEffector2D.get_forceTargetDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				AreaEffector2D.set_forceTargetDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000E5 RID: 229
		// (get) Token: 0x06000440 RID: 1088 RVA: 0x0000C704 File Offset: 0x0000A904
		// (set) Token: 0x06000441 RID: 1089 RVA: 0x00004745 File Offset: 0x00002945
		public float forceDirection
		{
			get
			{
				return this.forceAngle;
			}
			set
			{
				this.forceAngle = value;
			}
		}

		// Token: 0x0400024B RID: 587
		private static readonly AreaEffector2D.get_forceAngleDelegate get_forceAngleDelegateField = IL2CPP.ResolveICall<AreaEffector2D.get_forceAngleDelegate>("UnityEngine.AreaEffector2D::get_forceAngle");

		// Token: 0x0400024C RID: 588
		private static readonly AreaEffector2D.set_forceAngleDelegate set_forceAngleDelegateField = IL2CPP.ResolveICall<AreaEffector2D.set_forceAngleDelegate>("UnityEngine.AreaEffector2D::set_forceAngle");

		// Token: 0x0400024D RID: 589
		private static readonly AreaEffector2D.get_useGlobalAngleDelegate get_useGlobalAngleDelegateField = IL2CPP.ResolveICall<AreaEffector2D.get_useGlobalAngleDelegate>("UnityEngine.AreaEffector2D::get_useGlobalAngle");

		// Token: 0x0400024E RID: 590
		private static readonly AreaEffector2D.set_useGlobalAngleDelegate set_useGlobalAngleDelegateField = IL2CPP.ResolveICall<AreaEffector2D.set_useGlobalAngleDelegate>("UnityEngine.AreaEffector2D::set_useGlobalAngle");

		// Token: 0x0400024F RID: 591
		private static readonly AreaEffector2D.get_forceMagnitudeDelegate get_forceMagnitudeDelegateField = IL2CPP.ResolveICall<AreaEffector2D.get_forceMagnitudeDelegate>("UnityEngine.AreaEffector2D::get_forceMagnitude");

		// Token: 0x04000250 RID: 592
		private static readonly AreaEffector2D.set_forceMagnitudeDelegate set_forceMagnitudeDelegateField = IL2CPP.ResolveICall<AreaEffector2D.set_forceMagnitudeDelegate>("UnityEngine.AreaEffector2D::set_forceMagnitude");

		// Token: 0x04000251 RID: 593
		private static readonly AreaEffector2D.get_forceVariationDelegate get_forceVariationDelegateField = IL2CPP.ResolveICall<AreaEffector2D.get_forceVariationDelegate>("UnityEngine.AreaEffector2D::get_forceVariation");

		// Token: 0x04000252 RID: 594
		private static readonly AreaEffector2D.set_forceVariationDelegate set_forceVariationDelegateField = IL2CPP.ResolveICall<AreaEffector2D.set_forceVariationDelegate>("UnityEngine.AreaEffector2D::set_forceVariation");

		// Token: 0x04000253 RID: 595
		private static readonly AreaEffector2D.get_dragDelegate get_dragDelegateField = IL2CPP.ResolveICall<AreaEffector2D.get_dragDelegate>("UnityEngine.AreaEffector2D::get_drag");

		// Token: 0x04000254 RID: 596
		private static readonly AreaEffector2D.set_dragDelegate set_dragDelegateField = IL2CPP.ResolveICall<AreaEffector2D.set_dragDelegate>("UnityEngine.AreaEffector2D::set_drag");

		// Token: 0x04000255 RID: 597
		private static readonly AreaEffector2D.get_angularDragDelegate get_angularDragDelegateField = IL2CPP.ResolveICall<AreaEffector2D.get_angularDragDelegate>("UnityEngine.AreaEffector2D::get_angularDrag");

		// Token: 0x04000256 RID: 598
		private static readonly AreaEffector2D.set_angularDragDelegate set_angularDragDelegateField = IL2CPP.ResolveICall<AreaEffector2D.set_angularDragDelegate>("UnityEngine.AreaEffector2D::set_angularDrag");

		// Token: 0x04000257 RID: 599
		private static readonly AreaEffector2D.get_forceTargetDelegate get_forceTargetDelegateField = IL2CPP.ResolveICall<AreaEffector2D.get_forceTargetDelegate>("UnityEngine.AreaEffector2D::get_forceTarget");

		// Token: 0x04000258 RID: 600
		private static readonly AreaEffector2D.set_forceTargetDelegate set_forceTargetDelegateField = IL2CPP.ResolveICall<AreaEffector2D.set_forceTargetDelegate>("UnityEngine.AreaEffector2D::set_forceTarget");

		// Token: 0x020001CF RID: 463
		// (Invoke) Token: 0x060007C6 RID: 1990
		private delegate float get_forceAngleDelegate(IntPtr @this);

		// Token: 0x020001D0 RID: 464
		// (Invoke) Token: 0x060007C8 RID: 1992
		private delegate void set_forceAngleDelegate(IntPtr @this, float value);

		// Token: 0x020001D1 RID: 465
		// (Invoke) Token: 0x060007CA RID: 1994
		private delegate bool get_useGlobalAngleDelegate(IntPtr @this);

		// Token: 0x020001D2 RID: 466
		// (Invoke) Token: 0x060007CC RID: 1996
		private delegate void set_useGlobalAngleDelegate(IntPtr @this, bool value);

		// Token: 0x020001D3 RID: 467
		// (Invoke) Token: 0x060007CE RID: 1998
		private delegate float get_forceMagnitudeDelegate(IntPtr @this);

		// Token: 0x020001D4 RID: 468
		// (Invoke) Token: 0x060007D0 RID: 2000
		private delegate void set_forceMagnitudeDelegate(IntPtr @this, float value);

		// Token: 0x020001D5 RID: 469
		// (Invoke) Token: 0x060007D2 RID: 2002
		private delegate float get_forceVariationDelegate(IntPtr @this);

		// Token: 0x020001D6 RID: 470
		// (Invoke) Token: 0x060007D4 RID: 2004
		private delegate void set_forceVariationDelegate(IntPtr @this, float value);

		// Token: 0x020001D7 RID: 471
		// (Invoke) Token: 0x060007D6 RID: 2006
		private delegate float get_dragDelegate(IntPtr @this);

		// Token: 0x020001D8 RID: 472
		// (Invoke) Token: 0x060007D8 RID: 2008
		private delegate void set_dragDelegate(IntPtr @this, float value);

		// Token: 0x020001D9 RID: 473
		// (Invoke) Token: 0x060007DA RID: 2010
		private delegate float get_angularDragDelegate(IntPtr @this);

		// Token: 0x020001DA RID: 474
		// (Invoke) Token: 0x060007DC RID: 2012
		private delegate void set_angularDragDelegate(IntPtr @this, float value);

		// Token: 0x020001DB RID: 475
		// (Invoke) Token: 0x060007DE RID: 2014
		private delegate EffectorSelection2D get_forceTargetDelegate(IntPtr @this);

		// Token: 0x020001DC RID: 476
		// (Invoke) Token: 0x060007E0 RID: 2016
		private delegate void set_forceTargetDelegate(IntPtr @this, EffectorSelection2D value);
	}
}
