using System;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x0200030F RID: 783
	[Serializable]
	public struct Pose
	{
		// Token: 0x06002DD6 RID: 11734 RVA: 0x0001244B File Offset: 0x0001064B
		public override string ToString()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06002DD7 RID: 11735 RVA: 0x00012458 File Offset: 0x00010658
		public string ToString(string format)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06002DD8 RID: 11736 RVA: 0x000B43D8 File Offset: 0x000B25D8
		public Pose GetTransformedBy(Pose lhs)
		{
			return new Pose
			{
				position = lhs.position + lhs.rotation * this.position,
				rotation = lhs.rotation * this.rotation
			};
		}

		// Token: 0x06002DD9 RID: 11737 RVA: 0x000B4430 File Offset: 0x000B2630
		public Pose GetTransformedBy(Transform lhs)
		{
			return new Pose
			{
				position = lhs.TransformPoint(this.position),
				rotation = lhs.rotation * this.rotation
			};
		}

		// Token: 0x17000958 RID: 2392
		// (get) Token: 0x06002DDA RID: 11738 RVA: 0x000B4478 File Offset: 0x000B2678
		public Vector3 forward
		{
			get
			{
				return this.rotation * Vector3.forward;
			}
		}

		// Token: 0x17000959 RID: 2393
		// (get) Token: 0x06002DDB RID: 11739 RVA: 0x000B449C File Offset: 0x000B269C
		public Vector3 right
		{
			get
			{
				return this.rotation * Vector3.right;
			}
		}

		// Token: 0x1700095A RID: 2394
		// (get) Token: 0x06002DDC RID: 11740 RVA: 0x000B44C0 File Offset: 0x000B26C0
		public Vector3 up
		{
			get
			{
				return this.rotation * Vector3.up;
			}
		}

		// Token: 0x1700095B RID: 2395
		// (get) Token: 0x06002DDD RID: 11741 RVA: 0x00012465 File Offset: 0x00010665
		public static Pose identity
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x06002DDE RID: 11742 RVA: 0x000B44E4 File Offset: 0x000B26E4
		public override bool Equals(Object obj)
		{
			bool flag = !(obj is Pose);
			return !flag && this.Equals((Pose)obj);
		}

		// Token: 0x06002DDF RID: 11743 RVA: 0x000B4518 File Offset: 0x000B2718
		public bool Equals(Pose other)
		{
			return this.position.Equals(other.position) && this.rotation.Equals(other.rotation);
		}

		// Token: 0x06002DE0 RID: 11744 RVA: 0x000B4554 File Offset: 0x000B2754
		public override int GetHashCode()
		{
			return this.position.GetHashCode() ^ (this.rotation.GetHashCode() << 1);
		}

		// Token: 0x06002DE1 RID: 11745 RVA: 0x000B458C File Offset: 0x000B278C
		public static bool operator ==(Pose a, Pose b)
		{
			return a.position == b.position && a.rotation.Equals(b.rotation);
		}

		// Token: 0x06002DE2 RID: 11746 RVA: 0x000B45C8 File Offset: 0x000B27C8
		public static bool operator !=(Pose a, Pose b)
		{
			return !(a == b);
		}

		// Token: 0x0400294F RID: 10575
		public Vector3 position;

		// Token: 0x04002950 RID: 10576
		public Quaternion rotation;
	}
}
