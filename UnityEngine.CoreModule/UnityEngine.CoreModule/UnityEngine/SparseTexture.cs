using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using UnityEngine.Experimental.Rendering;

namespace UnityEngine
{
	// Token: 0x020002F5 RID: 757
	public sealed class SparseTexture : Texture
	{
		// Token: 0x17000945 RID: 2373
		// (get) Token: 0x06002D82 RID: 11650 RVA: 0x000120FE File Offset: 0x000102FE
		public int tileWidth
		{
			get
			{
				return SparseTexture.get_tileWidthDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x17000946 RID: 2374
		// (get) Token: 0x06002D83 RID: 11651 RVA: 0x00012110 File Offset: 0x00010310
		public int tileHeight
		{
			get
			{
				return SparseTexture.get_tileHeightDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x17000947 RID: 2375
		// (get) Token: 0x06002D84 RID: 11652 RVA: 0x00012122 File Offset: 0x00010322
		public bool isCreated
		{
			get
			{
				return SparseTexture.get_isCreatedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x06002D85 RID: 11653 RVA: 0x00012134 File Offset: 0x00010334
		public static void Internal_Create(SparseTexture mono, int width, int height, UnityEngine.Experimental.Rendering.GraphicsFormat format, TextureColorSpace colorSpace, int mipCount)
		{
			SparseTexture.Internal_CreateDelegateField(IL2CPP.Il2CppObjectBaseToPtr(mono), width, height, format, colorSpace, mipCount);
		}

		// Token: 0x06002D86 RID: 11654 RVA: 0x0001214D File Offset: 0x0001034D
		public void UpdateTile(int tileX, int tileY, int miplevel, Il2CppStructArray<Color32> data)
		{
			SparseTexture.UpdateTileDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), tileX, tileY, miplevel, IL2CPP.Il2CppObjectBaseToPtr(data));
		}

		// Token: 0x06002D87 RID: 11655 RVA: 0x00012169 File Offset: 0x00010369
		public void UpdateTileRaw(int tileX, int tileY, int miplevel, Il2CppStructArray<byte> data)
		{
			SparseTexture.UpdateTileRawDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), tileX, tileY, miplevel, IL2CPP.Il2CppObjectBaseToPtr(data));
		}

		// Token: 0x06002D88 RID: 11656 RVA: 0x00012185 File Offset: 0x00010385
		public void UnloadTile(int tileX, int tileY, int miplevel)
		{
			this.UpdateTileRaw(tileX, tileY, miplevel, null);
		}

		// Token: 0x06002D89 RID: 11657 RVA: 0x000B39CC File Offset: 0x000B1BCC
		public bool ValidateFormat(TextureFormat format, int width, int height)
		{
			bool flag = base.ValidateFormat(format);
			bool flag2 = flag;
			if (flag2)
			{
				bool flag3 = TextureFormat.PVRTC_RGB2 <= format && format <= TextureFormat.PVRTC_RGBA4;
				bool flag4 = flag3 && (width != height || !Mathf.IsPowerOfTwo(width));
				if (flag4)
				{
					throw new UnityException(String.Format("'{0}' demands texture to be square and have power-of-two dimensions", format.ToString()));
				}
			}
			return flag;
		}

		// Token: 0x06002D8A RID: 11658 RVA: 0x000B3A38 File Offset: 0x000B1C38
		public bool ValidateFormat(UnityEngine.Experimental.Rendering.GraphicsFormat format, int width, int height)
		{
			bool flag = base.ValidateFormat(format, UnityEngine.Experimental.Rendering.FormatUsage.Sparse);
			bool flag2 = flag;
			if (flag2)
			{
				bool flag3 = UnityEngine.Experimental.Rendering.GraphicsFormatUtility.IsPVRTCFormat(format);
				bool flag4 = flag3 && (width != height || !Mathf.IsPowerOfTwo(width));
				if (flag4)
				{
					throw new UnityException(String.Format("'{0}' demands texture to be square and have power-of-two dimensions", format.ToString()));
				}
			}
			return flag;
		}

		// Token: 0x06002D8B RID: 11659 RVA: 0x000B3A9C File Offset: 0x000B1C9C
		public bool ValidateSize(int width, int height, UnityEngine.Experimental.Rendering.GraphicsFormat format)
		{
			bool flag = (ulong)UnityEngine.Experimental.Rendering.GraphicsFormatUtility.GetBlockSize(format) * (ulong)((long)width / (long)((ulong)UnityEngine.Experimental.Rendering.GraphicsFormatUtility.GetBlockWidth(format))) * (ulong)((long)height / (long)((ulong)UnityEngine.Experimental.Rendering.GraphicsFormatUtility.GetBlockHeight(format))) < 65536UL;
			bool flag2;
			if (flag)
			{
				Debug.LogError("SparseTexture creation failed. The minimum size in bytes of a SparseTexture is 64KB.", this);
				flag2 = false;
			}
			else
			{
				flag2 = true;
			}
			return flag2;
		}

		// Token: 0x06002D8C RID: 11660 RVA: 0x000B3AEC File Offset: 0x000B1CEC
		public static void ValidateIsNotCrunched(TextureFormat textureFormat)
		{
			bool flag = UnityEngine.Experimental.Rendering.GraphicsFormatUtility.IsCrunchFormat(textureFormat);
			if (flag)
			{
				throw new ArgumentException("Crunched SparseTexture is not supported.");
			}
		}

		// Token: 0x0400291B RID: 10523
		private static readonly SparseTexture.get_tileWidthDelegate get_tileWidthDelegateField = IL2CPP.ResolveICall<SparseTexture.get_tileWidthDelegate>("UnityEngine.SparseTexture::get_tileWidth");

		// Token: 0x0400291C RID: 10524
		private static readonly SparseTexture.get_tileHeightDelegate get_tileHeightDelegateField = IL2CPP.ResolveICall<SparseTexture.get_tileHeightDelegate>("UnityEngine.SparseTexture::get_tileHeight");

		// Token: 0x0400291D RID: 10525
		private static readonly SparseTexture.get_isCreatedDelegate get_isCreatedDelegateField = IL2CPP.ResolveICall<SparseTexture.get_isCreatedDelegate>("UnityEngine.SparseTexture::get_isCreated");

		// Token: 0x0400291E RID: 10526
		private static readonly SparseTexture.Internal_CreateDelegate Internal_CreateDelegateField = IL2CPP.ResolveICall<SparseTexture.Internal_CreateDelegate>("UnityEngine.SparseTexture::Internal_Create");

		// Token: 0x0400291F RID: 10527
		private static readonly SparseTexture.UpdateTileDelegate UpdateTileDelegateField = IL2CPP.ResolveICall<SparseTexture.UpdateTileDelegate>("UnityEngine.SparseTexture::UpdateTile");

		// Token: 0x04002920 RID: 10528
		private static readonly SparseTexture.UpdateTileRawDelegate UpdateTileRawDelegateField = IL2CPP.ResolveICall<SparseTexture.UpdateTileRawDelegate>("UnityEngine.SparseTexture::UpdateTileRaw");

		// Token: 0x02000B53 RID: 2899
		// (Invoke) Token: 0x06003F9B RID: 16283
		private delegate int get_tileWidthDelegate(IntPtr @this);

		// Token: 0x02000B54 RID: 2900
		// (Invoke) Token: 0x06003F9D RID: 16285
		private delegate int get_tileHeightDelegate(IntPtr @this);

		// Token: 0x02000B55 RID: 2901
		// (Invoke) Token: 0x06003F9F RID: 16287
		private delegate bool get_isCreatedDelegate(IntPtr @this);

		// Token: 0x02000B56 RID: 2902
		// (Invoke) Token: 0x06003FA1 RID: 16289
		private delegate void Internal_CreateDelegate(IntPtr mono, int width, int height, UnityEngine.Experimental.Rendering.GraphicsFormat format, TextureColorSpace colorSpace, int mipCount);

		// Token: 0x02000B57 RID: 2903
		// (Invoke) Token: 0x06003FA3 RID: 16291
		private delegate void UpdateTileDelegate(IntPtr @this, int tileX, int tileY, int miplevel, IntPtr data);

		// Token: 0x02000B58 RID: 2904
		// (Invoke) Token: 0x06003FA5 RID: 16293
		private delegate void UpdateTileRawDelegate(IntPtr @this, int tileX, int tileY, int miplevel, IntPtr data);
	}
}
