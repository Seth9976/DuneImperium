using System;
using Il2CppInterop.Runtime;

namespace UnityEngine
{
	// Token: 0x0200002A RID: 42
	public sealed class FixedJoint2D : AnchoredJoint2D
	{
		// Token: 0x170000D1 RID: 209
		// (get) Token: 0x0600041C RID: 1052 RVA: 0x000044E6 File Offset: 0x000026E6
		// (set) Token: 0x0600041D RID: 1053 RVA: 0x000044F8 File Offset: 0x000026F8
		public float dampingRatio
		{
			get
			{
				return FixedJoint2D.get_dampingRatioDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				FixedJoint2D.set_dampingRatioDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000D2 RID: 210
		// (get) Token: 0x0600041E RID: 1054 RVA: 0x0000450B File Offset: 0x0000270B
		// (set) Token: 0x0600041F RID: 1055 RVA: 0x0000451D File Offset: 0x0000271D
		public float frequency
		{
			get
			{
				return FixedJoint2D.get_frequencyDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				FixedJoint2D.set_frequencyDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x170000D3 RID: 211
		// (get) Token: 0x06000420 RID: 1056 RVA: 0x00004530 File Offset: 0x00002730
		public float referenceAngle
		{
			get
			{
				return FixedJoint2D.get_referenceAngleDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x04000238 RID: 568
		private static readonly FixedJoint2D.get_dampingRatioDelegate get_dampingRatioDelegateField = IL2CPP.ResolveICall<FixedJoint2D.get_dampingRatioDelegate>("UnityEngine.FixedJoint2D::get_dampingRatio");

		// Token: 0x04000239 RID: 569
		private static readonly FixedJoint2D.set_dampingRatioDelegate set_dampingRatioDelegateField = IL2CPP.ResolveICall<FixedJoint2D.set_dampingRatioDelegate>("UnityEngine.FixedJoint2D::set_dampingRatio");

		// Token: 0x0400023A RID: 570
		private static readonly FixedJoint2D.get_frequencyDelegate get_frequencyDelegateField = IL2CPP.ResolveICall<FixedJoint2D.get_frequencyDelegate>("UnityEngine.FixedJoint2D::get_frequency");

		// Token: 0x0400023B RID: 571
		private static readonly FixedJoint2D.set_frequencyDelegate set_frequencyDelegateField = IL2CPP.ResolveICall<FixedJoint2D.set_frequencyDelegate>("UnityEngine.FixedJoint2D::set_frequency");

		// Token: 0x0400023C RID: 572
		private static readonly FixedJoint2D.get_referenceAngleDelegate get_referenceAngleDelegateField = IL2CPP.ResolveICall<FixedJoint2D.get_referenceAngleDelegate>("UnityEngine.FixedJoint2D::get_referenceAngle");

		// Token: 0x020001BC RID: 444
		// (Invoke) Token: 0x060007A0 RID: 1952
		private delegate float get_dampingRatioDelegate(IntPtr @this);

		// Token: 0x020001BD RID: 445
		// (Invoke) Token: 0x060007A2 RID: 1954
		private delegate void set_dampingRatioDelegate(IntPtr @this, float value);

		// Token: 0x020001BE RID: 446
		// (Invoke) Token: 0x060007A4 RID: 1956
		private delegate float get_frequencyDelegate(IntPtr @this);

		// Token: 0x020001BF RID: 447
		// (Invoke) Token: 0x060007A6 RID: 1958
		private delegate void set_frequencyDelegate(IntPtr @this, float value);

		// Token: 0x020001C0 RID: 448
		// (Invoke) Token: 0x060007A8 RID: 1960
		private delegate float get_referenceAngleDelegate(IntPtr @this);
	}
}
