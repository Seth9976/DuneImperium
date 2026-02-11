using System;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x0200002A RID: 42
	public sealed class GUITexture
	{
		// Token: 0x0600067B RID: 1659 RVA: 0x00004D64 File Offset: 0x00002F64
		public static void FeatureRemoved()
		{
			throw new Exception("GUITexture has been removed from Unity. Use UI.Image instead.");
		}

		// Token: 0x1700016B RID: 363
		// (get) Token: 0x0600067C RID: 1660 RVA: 0x00017710 File Offset: 0x00015910
		// (set) Token: 0x0600067D RID: 1661 RVA: 0x00004D71 File Offset: 0x00002F71
		public Color color
		{
			get
			{
				GUITexture.FeatureRemoved();
				return new Color(0f, 0f, 0f);
			}
			set
			{
				GUITexture.FeatureRemoved();
			}
		}

		// Token: 0x1700016C RID: 364
		// (get) Token: 0x0600067E RID: 1662 RVA: 0x0001773C File Offset: 0x0001593C
		// (set) Token: 0x0600067F RID: 1663 RVA: 0x00004D7A File Offset: 0x00002F7A
		public Texture texture
		{
			get
			{
				GUITexture.FeatureRemoved();
				return null;
			}
			set
			{
				GUITexture.FeatureRemoved();
			}
		}

		// Token: 0x1700016D RID: 365
		// (get) Token: 0x06000680 RID: 1664 RVA: 0x00017758 File Offset: 0x00015958
		// (set) Token: 0x06000681 RID: 1665 RVA: 0x00004D83 File Offset: 0x00002F83
		public Rect pixelInset
		{
			get
			{
				GUITexture.FeatureRemoved();
				return default(Rect);
			}
			set
			{
				GUITexture.FeatureRemoved();
			}
		}

		// Token: 0x1700016E RID: 366
		// (get) Token: 0x06000682 RID: 1666 RVA: 0x0001777C File Offset: 0x0001597C
		// (set) Token: 0x06000683 RID: 1667 RVA: 0x00004D8C File Offset: 0x00002F8C
		public RectOffset border
		{
			get
			{
				GUITexture.FeatureRemoved();
				return null;
			}
			set
			{
				GUITexture.FeatureRemoved();
			}
		}
	}
}
