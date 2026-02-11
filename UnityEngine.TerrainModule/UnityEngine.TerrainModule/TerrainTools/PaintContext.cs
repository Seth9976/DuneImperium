using System;
using System.Runtime.InteropServices;
using Il2CppSystem;

namespace UnityEngine.TerrainTools
{
	// Token: 0x02000017 RID: 23
	public class PaintContext
	{
		// Token: 0x170000A5 RID: 165
		// (get) Token: 0x060001B0 RID: 432 RVA: 0x0000335D File Offset: 0x0000155D
		public Terrain originTerrain
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x170000A6 RID: 166
		// (get) Token: 0x060001B1 RID: 433 RVA: 0x0000336A File Offset: 0x0000156A
		public RectInt pixelRect
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x170000A7 RID: 167
		// (get) Token: 0x060001B2 RID: 434 RVA: 0x00003377 File Offset: 0x00001577
		public int targetTextureWidth
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x170000A8 RID: 168
		// (get) Token: 0x060001B3 RID: 435 RVA: 0x00003384 File Offset: 0x00001584
		public int targetTextureHeight
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x170000A9 RID: 169
		// (get) Token: 0x060001B4 RID: 436 RVA: 0x00003391 File Offset: 0x00001591
		public Vector2 pixelSize
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x170000AA RID: 170
		// (get) Token: 0x060001B5 RID: 437 RVA: 0x0000339E File Offset: 0x0000159E
		// (set) Token: 0x060001B6 RID: 438 RVA: 0x000033AB File Offset: 0x000015AB
		public RenderTexture sourceRenderTexture
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

		// Token: 0x170000AB RID: 171
		// (get) Token: 0x060001B7 RID: 439 RVA: 0x000033B8 File Offset: 0x000015B8
		// (set) Token: 0x060001B8 RID: 440 RVA: 0x000033C5 File Offset: 0x000015C5
		public RenderTexture destinationRenderTexture
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

		// Token: 0x170000AC RID: 172
		// (get) Token: 0x060001B9 RID: 441 RVA: 0x000033D2 File Offset: 0x000015D2
		// (set) Token: 0x060001BA RID: 442 RVA: 0x000033DF File Offset: 0x000015DF
		public RenderTexture oldRenderTexture
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

		// Token: 0x170000AD RID: 173
		// (get) Token: 0x060001BB RID: 443 RVA: 0x000033EC File Offset: 0x000015EC
		public int terrainCount
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x060001BC RID: 444 RVA: 0x000033F9 File Offset: 0x000015F9
		public Terrain GetTerrain(int terrainIndex)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060001BD RID: 445 RVA: 0x00003406 File Offset: 0x00001606
		public RectInt GetClippedPixelRectInTerrainPixels(int terrainIndex)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060001BE RID: 446 RVA: 0x00003413 File Offset: 0x00001613
		public RectInt GetClippedPixelRectInRenderTexturePixels(int terrainIndex)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x170000AE RID: 174
		// (get) Token: 0x060001BF RID: 447 RVA: 0x00003420 File Offset: 0x00001620
		public float heightWorldSpaceMin
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x170000AF RID: 175
		// (get) Token: 0x060001C0 RID: 448 RVA: 0x0000342D File Offset: 0x0000162D
		public float heightWorldSpaceSize
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x170000B0 RID: 176
		// (get) Token: 0x060001C1 RID: 449 RVA: 0x0000343A File Offset: 0x0000163A
		public static float kNormalizedHeightScale
		{
			get
			{
				return 0.4999771f;
			}
		}

		// Token: 0x060001C2 RID: 450 RVA: 0x00003441 File Offset: 0x00001641
		public static void add_onTerrainTileBeforePaint(Action<PaintContext.ITerrainInfo, PaintContext.ToolAction, string> value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060001C3 RID: 451 RVA: 0x0000344E File Offset: 0x0000164E
		public static void remove_onTerrainTileBeforePaint(Action<PaintContext.ITerrainInfo, PaintContext.ToolAction, string> value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060001C4 RID: 452 RVA: 0x000064B0 File Offset: 0x000046B0
		public static int ClampContextResolution(int resolution)
		{
			return Mathf.Clamp(resolution, 1, 8192);
		}

		// Token: 0x060001C5 RID: 453 RVA: 0x000064D0 File Offset: 0x000046D0
		public static PaintContext CreateFromBounds(Terrain terrain, Rect boundsInTerrainSpace, int inputTextureWidth, int inputTextureHeight, [Optional] int extraBorderPixels, [Optional] bool sharedBoundaryTexel, [Optional] bool fillOutsideTerrain)
		{
			return new PaintContext(terrain, TerrainPaintUtility.CalcPixelRectFromBounds(terrain, boundsInTerrainSpace, inputTextureWidth, inputTextureHeight, extraBorderPixels, sharedBoundaryTexel), inputTextureWidth, inputTextureHeight, sharedBoundaryTexel, fillOutsideTerrain);
		}

		// Token: 0x060001C6 RID: 454 RVA: 0x0000345B File Offset: 0x0000165B
		public void FindTerrainTilesUnlimited(bool sharedBoundaryTexel, bool fillOutsideTerrain)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060001C7 RID: 455 RVA: 0x00003468 File Offset: 0x00001668
		public void CreateRenderTargets(RenderTextureFormat colorFormat)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060001C8 RID: 456 RVA: 0x000064FC File Offset: 0x000046FC
		public void Cleanup([Optional] bool restoreRenderTexture)
		{
			if (restoreRenderTexture)
			{
				RenderTexture.active = this.oldRenderTexture;
			}
			RenderTexture.ReleaseTemporary(this.sourceRenderTexture);
			RenderTexture.ReleaseTemporary(this.destinationRenderTexture);
			this.sourceRenderTexture = null;
			this.destinationRenderTexture = null;
			this.oldRenderTexture = null;
		}

		// Token: 0x060001C9 RID: 457 RVA: 0x00003475 File Offset: 0x00001675
		public void GatherInternal(Func<PaintContext.ITerrainInfo, Texture> terrainToTexture, Color defaultColor, string operationName, [Optional] Material blitMaterial, [Optional] int blitPass, [Optional] Action<PaintContext.ITerrainInfo> beforeBlit, [Optional] Action<PaintContext.ITerrainInfo> afterBlit)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060001CA RID: 458 RVA: 0x00003482 File Offset: 0x00001682
		public void ScatterInternal(Func<PaintContext.ITerrainInfo, RenderTexture> terrainToRT, string operationName, [Optional] Material blitMaterial, [Optional] int blitPass, [Optional] Action<PaintContext.ITerrainInfo> beforeBlit, [Optional] Action<PaintContext.ITerrainInfo> afterBlit)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060001CB RID: 459 RVA: 0x0000654C File Offset: 0x0000474C
		public void Gather(Func<PaintContext.ITerrainInfo, Texture> terrainSource, Color defaultColor, [Optional] Material blitMaterial, [Optional] int blitPass, [Optional] Action<PaintContext.ITerrainInfo> beforeBlit, [Optional] Action<PaintContext.ITerrainInfo> afterBlit)
		{
			bool flag = terrainSource != null;
			if (flag)
			{
				this.GatherInternal(terrainSource, defaultColor, "PaintContext.Gather", blitMaterial, blitPass, beforeBlit, afterBlit);
			}
		}

		// Token: 0x060001CC RID: 460 RVA: 0x00006578 File Offset: 0x00004778
		public void Scatter(Func<PaintContext.ITerrainInfo, RenderTexture> terrainDest, [Optional] Material blitMaterial, [Optional] int blitPass, [Optional] Action<PaintContext.ITerrainInfo> beforeBlit, [Optional] Action<PaintContext.ITerrainInfo> afterBlit)
		{
			bool flag = terrainDest != null;
			if (flag)
			{
				this.ScatterInternal(terrainDest, "PaintContext.Scatter", blitMaterial, blitPass, beforeBlit, afterBlit);
			}
		}

		// Token: 0x060001CD RID: 461 RVA: 0x0000348F File Offset: 0x0000168F
		public void GatherHeightmap()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060001CE RID: 462 RVA: 0x0000349C File Offset: 0x0000169C
		public void ScatterHeightmap(string editorUndoName)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060001CF RID: 463 RVA: 0x000034A9 File Offset: 0x000016A9
		public void GatherHoles()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060001D0 RID: 464 RVA: 0x000034B6 File Offset: 0x000016B6
		public void ScatterHoles(string editorUndoName)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060001D1 RID: 465 RVA: 0x000034C3 File Offset: 0x000016C3
		public void GatherNormals()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060001D2 RID: 466 RVA: 0x000034D0 File Offset: 0x000016D0
		public PaintContext.SplatmapUserData GetTerrainLayerUserData(PaintContext.ITerrainInfo context, [Optional] TerrainLayer terrainLayer, [Optional] bool addLayerIfDoesntExist)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060001D3 RID: 467 RVA: 0x000034DD File Offset: 0x000016DD
		public void GatherAlphamap(TerrainLayer inputLayer, [Optional] bool addLayerIfDoesntExist)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060001D4 RID: 468 RVA: 0x000034EA File Offset: 0x000016EA
		public void ScatterAlphamap(string editorUndoName)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060001D5 RID: 469 RVA: 0x000034F7 File Offset: 0x000016F7
		public static void OnTerrainPainted(PaintContext.ITerrainInfo tile, PaintContext.ToolAction action)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060001D6 RID: 470 RVA: 0x00003504 File Offset: 0x00001704
		public static void ApplyDelayedActions()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x04000122 RID: 290
		public const int k_MinimumResolution = 1;

		// Token: 0x04000123 RID: 291
		public const int k_MaximumResolution = 8192;

		// Token: 0x020000E3 RID: 227
		public interface ITerrainInfo
		{
		}

		// Token: 0x020000E4 RID: 228
		public class TerrainTile
		{
		}

		// Token: 0x020000E5 RID: 229
		public class SplatmapUserData
		{
		}

		// Token: 0x020000E6 RID: 230
		public enum ToolAction
		{
			// Token: 0x04000148 RID: 328
			None,
			// Token: 0x04000149 RID: 329
			PaintHeightmap,
			// Token: 0x0400014A RID: 330
			PaintTexture,
			// Token: 0x0400014B RID: 331
			PaintHoles = 4,
			// Token: 0x0400014C RID: 332
			AddTerrainLayer = 8
		}

		// Token: 0x020000E7 RID: 231
		[Serializable]
		public sealed class <>c
		{
		}

		// Token: 0x020000E8 RID: 232
		public sealed class <>c__DisplayClass53_0
		{
		}

		// Token: 0x020000E9 RID: 233
		public sealed class <>c__DisplayClass60_0
		{
		}

		// Token: 0x020000EA RID: 234
		public sealed class <>c__DisplayClass61_0
		{
		}

		// Token: 0x020000EB RID: 235
		public sealed class <>c__DisplayClass63_0
		{
		}

		// Token: 0x020000EC RID: 236
		public sealed class <>c__DisplayClass66_0
		{
		}

		// Token: 0x020000ED RID: 237
		public sealed class <>c__DisplayClass67_0
		{
		}
	}
}
