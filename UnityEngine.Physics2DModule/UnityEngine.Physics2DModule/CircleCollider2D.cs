using System;
using Il2CppInterop.Runtime;

namespace UnityEngine
{
	// Token: 0x0200001B RID: 27
	public sealed class CircleCollider2D : Collider2D
	{
		// Token: 0x17000085 RID: 133
		// (get) Token: 0x06000354 RID: 852 RVA: 0x00003941 File Offset: 0x00001B41
		// (set) Token: 0x06000355 RID: 853 RVA: 0x00003953 File Offset: 0x00001B53
		public float radius
		{
			get
			{
				return CircleCollider2D.get_radiusDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				CircleCollider2D.set_radiusDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000086 RID: 134
		// (get) Token: 0x06000356 RID: 854 RVA: 0x0000B718 File Offset: 0x00009918
		// (set) Token: 0x06000357 RID: 855 RVA: 0x00003966 File Offset: 0x00001B66
		public Vector2 center
		{
			get
			{
				return Vector2.zero;
			}
			set
			{
			}
		}

		// Token: 0x040001A5 RID: 421
		private static readonly CircleCollider2D.get_radiusDelegate get_radiusDelegateField = IL2CPP.ResolveICall<CircleCollider2D.get_radiusDelegate>("UnityEngine.CircleCollider2D::get_radius");

		// Token: 0x040001A6 RID: 422
		private static readonly CircleCollider2D.set_radiusDelegate set_radiusDelegateField = IL2CPP.ResolveICall<CircleCollider2D.set_radiusDelegate>("UnityEngine.CircleCollider2D::set_radius");

		// Token: 0x02000127 RID: 295
		// (Invoke) Token: 0x0600067A RID: 1658
		private delegate float get_radiusDelegate(IntPtr @this);

		// Token: 0x02000128 RID: 296
		// (Invoke) Token: 0x0600067C RID: 1660
		private delegate void set_radiusDelegate(IntPtr @this, float value);
	}
}
