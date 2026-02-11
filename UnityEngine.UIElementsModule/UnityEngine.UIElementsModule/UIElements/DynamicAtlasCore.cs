using System;
using System.Runtime.InteropServices;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x020002DD RID: 733
	public class DynamicAtlasCore
	{
		// Token: 0x17001061 RID: 4193
		// (get) Token: 0x06003417 RID: 13335 RVA: 0x0001534C File Offset: 0x0001354C
		public int maxImageSize
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x17001062 RID: 4194
		// (get) Token: 0x06003418 RID: 13336 RVA: 0x00015359 File Offset: 0x00013559
		public RenderTextureFormat format
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x17001063 RID: 4195
		// (get) Token: 0x06003419 RID: 13337 RVA: 0x00015366 File Offset: 0x00013566
		// (set) Token: 0x0600341A RID: 13338 RVA: 0x00015373 File Offset: 0x00013573
		public RenderTexture atlas
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

		// Token: 0x17001064 RID: 4196
		// (get) Token: 0x0600341B RID: 13339 RVA: 0x00015380 File Offset: 0x00013580
		// (set) Token: 0x0600341C RID: 13340 RVA: 0x0001538D File Offset: 0x0001358D
		public bool disposed
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

		// Token: 0x0600341D RID: 13341 RVA: 0x0001539A File Offset: 0x0001359A
		public void Dispose()
		{
			this.Dispose(true);
			GC.SuppressFinalize(this);
		}

		// Token: 0x0600341E RID: 13342 RVA: 0x000153AC File Offset: 0x000135AC
		public virtual void Dispose(bool disposing)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600341F RID: 13343 RVA: 0x000153B9 File Offset: 0x000135B9
		public static void LogDisposeError()
		{
			Debug.LogError("An attempt to use a disposed atlas manager has been detected.");
		}

		// Token: 0x06003420 RID: 13344 RVA: 0x000DA180 File Offset: 0x000D8380
		public bool IsReleased()
		{
			return this.atlas != null && !this.atlas.IsCreated();
		}

		// Token: 0x06003421 RID: 13345 RVA: 0x000153C7 File Offset: 0x000135C7
		public bool TryGetRect(Texture2D image, out RectInt uvs, [Optional] Func<Texture2D, bool> filter)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06003422 RID: 13346 RVA: 0x000153D4 File Offset: 0x000135D4
		public void UpdateTexture(Texture2D image)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06003423 RID: 13347 RVA: 0x000153E1 File Offset: 0x000135E1
		public bool AllocateRect(int width, int height, out RectInt uvs)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06003424 RID: 13348 RVA: 0x000153EE File Offset: 0x000135EE
		public void EnqueueBlit(Texture image, RectInt srcRect, int x, int y, bool addBorder, Color tint)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06003425 RID: 13349 RVA: 0x000153FB File Offset: 0x000135FB
		public void Commit()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06003426 RID: 13350 RVA: 0x00015408 File Offset: 0x00013608
		public void UpdateAtlasTexture()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06003427 RID: 13351 RVA: 0x00015415 File Offset: 0x00013615
		public RenderTexture CreateAtlasTexture()
		{
			throw new NotSupportedException("Method unstripping failed");
		}
	}
}
