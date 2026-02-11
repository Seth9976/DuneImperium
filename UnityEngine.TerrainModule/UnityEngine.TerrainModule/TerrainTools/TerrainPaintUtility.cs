using System;
using System.Runtime.InteropServices;
using Il2CppSystem;
using UnityEngine.Rendering;

namespace UnityEngine.TerrainTools
{
	// Token: 0x02000019 RID: 25
	public static class TerrainPaintUtility
	{
		// Token: 0x060001D7 RID: 471 RVA: 0x00003511 File Offset: 0x00001711
		public static Material GetBuiltinPaintMaterial()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060001D8 RID: 472 RVA: 0x000065A4 File Offset: 0x000047A4
		public static void GetBrushWorldSizeLimits(out float minBrushWorldSize, out float maxBrushWorldSize, float terrainTileWorldSize, int terrainTileTextureResolutionPixels, [Optional] int minBrushResolutionPixels, [Optional] int maxBrushResolutionPixels)
		{
			bool flag = terrainTileTextureResolutionPixels <= 0;
			if (flag)
			{
				minBrushWorldSize = terrainTileWorldSize;
				maxBrushWorldSize = terrainTileWorldSize;
			}
			else
			{
				float num = terrainTileWorldSize / (float)terrainTileTextureResolutionPixels;
				minBrushWorldSize = (float)minBrushResolutionPixels * num;
				float num2 = (float)Mathf.Min(maxBrushResolutionPixels, SystemInfo.maxTextureSize);
				maxBrushWorldSize = num2 * num;
			}
		}

		// Token: 0x060001D9 RID: 473 RVA: 0x000065E8 File Offset: 0x000047E8
		public static BrushTransform CalculateBrushTransform(Terrain terrain, Vector2 brushCenterTerrainUV, float brushSize, float brushRotationDegrees)
		{
			float num = brushRotationDegrees * 0.017453292f;
			float num2 = Mathf.Cos(num);
			float num3 = Mathf.Sin(num);
			Vector2 vector = new Vector2(num2, -num3) * brushSize;
			Vector2 vector2 = new Vector2(num3, num2) * brushSize;
			Vector3 size = terrain.terrainData.size;
			Vector2 vector3 = brushCenterTerrainUV * new Vector2(size.x, size.z);
			Vector2 vector4 = vector3 - 0.5f * vector - 0.5f * vector2;
			BrushTransform brushTransform = new BrushTransform(vector4, vector, vector2);
			return brushTransform;
		}

		// Token: 0x060001DA RID: 474 RVA: 0x0000668C File Offset: 0x0000488C
		public static void BuildTransformPaintContextUVToPaintContextUV(PaintContext src, PaintContext dst, out Vector4 scaleOffset)
		{
			float num = ((float)src.pixelRect.xMin - 0.5f) * src.pixelSize.x;
			float num2 = ((float)src.pixelRect.yMin - 0.5f) * src.pixelSize.y;
			float num3 = (float)src.pixelRect.width * src.pixelSize.x;
			float num4 = (float)src.pixelRect.height * src.pixelSize.y;
			float num5 = ((float)dst.pixelRect.xMin - 0.5f) * dst.pixelSize.x;
			float num6 = ((float)dst.pixelRect.yMin - 0.5f) * dst.pixelSize.y;
			float num7 = (float)dst.pixelRect.width * dst.pixelSize.x;
			float num8 = (float)dst.pixelRect.height * dst.pixelSize.y;
			scaleOffset = new Vector4(num3 / num7, num4 / num8, (num - num5) / num7, (num2 - num6) / num8);
		}

		// Token: 0x060001DB RID: 475 RVA: 0x000067C0 File Offset: 0x000049C0
		public static void SetupTerrainToolMaterialProperties(PaintContext paintContext, [In] ref BrushTransform brushXform, Material material)
		{
			float num = ((float)paintContext.pixelRect.xMin - 0.5f) * paintContext.pixelSize.x;
			float num2 = ((float)paintContext.pixelRect.yMin - 0.5f) * paintContext.pixelSize.y;
			float num3 = (float)paintContext.pixelRect.width * paintContext.pixelSize.x;
			float num4 = (float)paintContext.pixelRect.height * paintContext.pixelSize.y;
			Vector2 vector = num3 * brushXform.targetX;
			Vector2 vector2 = num4 * brushXform.targetY;
			Vector2 vector3 = brushXform.targetOrigin + num * brushXform.targetX + num2 * brushXform.targetY;
			material.SetVector("_PCUVToBrushUVScales", new Vector4(vector.x, vector.y, vector2.x, vector2.y));
			material.SetVector("_PCUVToBrushUVOffset", new Vector4(vector3.x, vector3.y, 0f, 0f));
		}

		// Token: 0x170000B1 RID: 177
		// (get) Token: 0x060001DC RID: 476 RVA: 0x000068EC File Offset: 0x00004AEC
		public static bool paintTextureUsesCopyTexture
		{
			get
			{
				return (SystemInfo.copyTextureSupport & (CopyTextureSupport.TextureToRT | CopyTextureSupport.RTToTexture)) == (CopyTextureSupport.TextureToRT | CopyTextureSupport.RTToTexture);
			}
		}

		// Token: 0x060001DD RID: 477 RVA: 0x0000690C File Offset: 0x00004B0C
		public static PaintContext InitializePaintContext(Terrain terrain, int targetWidth, int targetHeight, RenderTextureFormat pcFormat, Rect boundsInTerrainSpace, [Optional] int extraBorderPixels, [Optional] bool sharedBoundaryTexel, [Optional] bool fillOutsideTerrain)
		{
			PaintContext paintContext = PaintContext.CreateFromBounds(terrain, boundsInTerrainSpace, targetWidth, targetHeight, extraBorderPixels, sharedBoundaryTexel, fillOutsideTerrain);
			paintContext.CreateRenderTargets(pcFormat);
			return paintContext;
		}

		// Token: 0x060001DE RID: 478 RVA: 0x0000351E File Offset: 0x0000171E
		public static void ReleaseContextResources(PaintContext ctx)
		{
			ctx.Cleanup(true);
		}

		// Token: 0x060001DF RID: 479 RVA: 0x00006938 File Offset: 0x00004B38
		public static PaintContext BeginPaintHeightmap(Terrain terrain, Rect boundsInTerrainSpace, [Optional] int extraBorderPixels, [Optional] bool fillOutsideTerrain)
		{
			int heightmapResolution = terrain.terrainData.heightmapResolution;
			PaintContext paintContext = TerrainPaintUtility.InitializePaintContext(terrain, heightmapResolution, heightmapResolution, Terrain.heightmapRenderTextureFormat, boundsInTerrainSpace, extraBorderPixels, true, fillOutsideTerrain);
			paintContext.GatherHeightmap();
			return paintContext;
		}

		// Token: 0x060001E0 RID: 480 RVA: 0x00003529 File Offset: 0x00001729
		public static void EndPaintHeightmap(PaintContext ctx, string editorUndoName)
		{
			ctx.ScatterHeightmap(editorUndoName);
			ctx.Cleanup(true);
		}

		// Token: 0x060001E1 RID: 481 RVA: 0x00006970 File Offset: 0x00004B70
		public static PaintContext BeginPaintHoles(Terrain terrain, Rect boundsInTerrainSpace, [Optional] int extraBorderPixels, [Optional] bool fillOutsideTerrain)
		{
			int holesResolution = terrain.terrainData.holesResolution;
			PaintContext paintContext = TerrainPaintUtility.InitializePaintContext(terrain, holesResolution, holesResolution, Terrain.holesRenderTextureFormat, boundsInTerrainSpace, extraBorderPixels, false, fillOutsideTerrain);
			paintContext.GatherHoles();
			return paintContext;
		}

		// Token: 0x060001E2 RID: 482 RVA: 0x0000353C File Offset: 0x0000173C
		public static void EndPaintHoles(PaintContext ctx, string editorUndoName)
		{
			ctx.ScatterHoles(editorUndoName);
			ctx.Cleanup(true);
		}

		// Token: 0x060001E3 RID: 483 RVA: 0x000069A8 File Offset: 0x00004BA8
		public static PaintContext CollectNormals(Terrain terrain, Rect boundsInTerrainSpace, [Optional] int extraBorderPixels, [Optional] bool fillOutsideTerrain)
		{
			int heightmapResolution = terrain.terrainData.heightmapResolution;
			PaintContext paintContext = TerrainPaintUtility.InitializePaintContext(terrain, heightmapResolution, heightmapResolution, Terrain.normalmapRenderTextureFormat, boundsInTerrainSpace, extraBorderPixels, true, fillOutsideTerrain);
			paintContext.GatherNormals();
			return paintContext;
		}

		// Token: 0x060001E4 RID: 484 RVA: 0x000069E0 File Offset: 0x00004BE0
		public static PaintContext BeginPaintTexture(Terrain terrain, Rect boundsInTerrainSpace, TerrainLayer inputLayer, [Optional] int extraBorderPixels, [Optional] bool fillOutsideTerrain)
		{
			bool flag = inputLayer == null;
			PaintContext paintContext;
			if (flag)
			{
				paintContext = null;
			}
			else
			{
				int alphamapResolution = terrain.terrainData.alphamapResolution;
				PaintContext paintContext2 = TerrainPaintUtility.InitializePaintContext(terrain, alphamapResolution, alphamapResolution, RenderTextureFormat.R8, boundsInTerrainSpace, extraBorderPixels, true, fillOutsideTerrain);
				paintContext2.GatherAlphamap(inputLayer, true);
				paintContext = paintContext2;
			}
			return paintContext;
		}

		// Token: 0x060001E5 RID: 485 RVA: 0x0000354F File Offset: 0x0000174F
		public static void EndPaintTexture(PaintContext ctx, string editorUndoName)
		{
			ctx.ScatterAlphamap(editorUndoName);
			ctx.Cleanup(true);
		}

		// Token: 0x060001E6 RID: 486 RVA: 0x00003562 File Offset: 0x00001762
		public static Material GetBlitMaterial()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060001E7 RID: 487 RVA: 0x0000356F File Offset: 0x0000176F
		public static Material GetHeightBlitMaterial()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060001E8 RID: 488 RVA: 0x0000357C File Offset: 0x0000177C
		public static Material GetCopyTerrainLayerMaterial()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060001E9 RID: 489 RVA: 0x00003589 File Offset: 0x00001789
		public static void DrawQuad(RectInt destinationPixels, RectInt sourcePixels, Texture sourceTexture)
		{
			TerrainPaintUtility.DrawQuad2(destinationPixels, sourcePixels, sourceTexture, sourcePixels, sourceTexture);
		}

		// Token: 0x060001EA RID: 490 RVA: 0x00006A28 File Offset: 0x00004C28
		public static void DrawQuad2(RectInt destinationPixels, RectInt sourcePixels, Texture sourceTexture, RectInt sourcePixels2, Texture sourceTexture2)
		{
			bool flag = destinationPixels.width > 0 && destinationPixels.height > 0;
			if (flag)
			{
				Rect rect = new Rect((float)sourcePixels.x / (float)sourceTexture.width, (float)sourcePixels.y / (float)sourceTexture.height, (float)sourcePixels.width / (float)sourceTexture.width, (float)sourcePixels.height / (float)sourceTexture.height);
				Rect rect2 = new Rect((float)sourcePixels2.x / (float)sourceTexture2.width, (float)sourcePixels2.y / (float)sourceTexture2.height, (float)sourcePixels2.width / (float)sourceTexture2.width, (float)sourcePixels2.height / (float)sourceTexture2.height);
				GL.Begin(7);
				GL.Color(new Color(1f, 1f, 1f, 1f));
				GL.MultiTexCoord2(0, rect.x, rect.y);
				GL.MultiTexCoord2(1, rect2.x, rect2.y);
				GL.Vertex3((float)destinationPixels.x, (float)destinationPixels.y, 0f);
				GL.MultiTexCoord2(0, rect.x, rect.yMax);
				GL.MultiTexCoord2(1, rect2.x, rect2.yMax);
				GL.Vertex3((float)destinationPixels.x, (float)destinationPixels.yMax, 0f);
				GL.MultiTexCoord2(0, rect.xMax, rect.yMax);
				GL.MultiTexCoord2(1, rect2.xMax, rect2.yMax);
				GL.Vertex3((float)destinationPixels.xMax, (float)destinationPixels.yMax, 0f);
				GL.MultiTexCoord2(0, rect.xMax, rect.y);
				GL.MultiTexCoord2(1, rect2.xMax, rect2.y);
				GL.Vertex3((float)destinationPixels.xMax, (float)destinationPixels.y, 0f);
				GL.End();
			}
		}

		// Token: 0x060001EB RID: 491 RVA: 0x00006C28 File Offset: 0x00004E28
		public static void DrawQuadPadded(RectInt destinationPixels, RectInt destinationPixelsPadded, RectInt sourcePixels, RectInt sourcePixelsPadded, Texture sourceTexture)
		{
			GL.Begin(7);
			GL.Color(new Color(1f, 1f, 1f, 1f));
			for (int i = 0; i < 3; i++)
			{
				bool flag = i == 0;
				Vector2Int vector2Int;
				Vector2Int vector2Int2;
				Vector2 vector;
				if (flag)
				{
					vector2Int = new Vector2Int(sourcePixelsPadded.yMin, sourcePixels.yMin);
					vector2Int2 = new Vector2Int(destinationPixelsPadded.yMin, destinationPixels.yMin);
					vector = new Vector2(-1f, 0f);
				}
				else
				{
					bool flag2 = i == 1;
					if (flag2)
					{
						vector2Int = new Vector2Int(sourcePixels.yMin, sourcePixels.yMax);
						vector2Int2 = new Vector2Int(destinationPixels.yMin, destinationPixels.yMax);
						vector = new Vector2(0f, 0f);
					}
					else
					{
						vector2Int = new Vector2Int(sourcePixels.yMax, sourcePixelsPadded.yMax);
						vector2Int2 = new Vector2Int(destinationPixels.yMax, destinationPixelsPadded.yMax);
						vector = new Vector2(0f, -1f);
					}
				}
				bool flag3 = vector2Int[0] >= vector2Int[1];
				if (!flag3)
				{
					for (int j = 0; j < 3; j++)
					{
						bool flag4 = j == 0;
						Vector2Int vector2Int3;
						Vector2Int vector2Int4;
						Vector2 vector2;
						if (flag4)
						{
							vector2Int3 = new Vector2Int(sourcePixelsPadded.xMin, sourcePixels.xMin);
							vector2Int4 = new Vector2Int(destinationPixelsPadded.xMin, destinationPixels.xMin);
							vector2 = new Vector2(-1f, 0f);
						}
						else
						{
							bool flag5 = j == 1;
							if (flag5)
							{
								vector2Int3 = new Vector2Int(sourcePixels.xMin, sourcePixels.xMax);
								vector2Int4 = new Vector2Int(destinationPixels.xMin, destinationPixels.xMax);
								vector2 = new Vector2(0f, 0f);
							}
							else
							{
								vector2Int3 = new Vector2Int(sourcePixels.xMax, sourcePixelsPadded.xMax);
								vector2Int4 = new Vector2Int(destinationPixels.xMax, destinationPixelsPadded.xMax);
								vector2 = new Vector2(0f, -1f);
							}
						}
						bool flag6 = vector2Int3[0] >= vector2Int3[1];
						if (!flag6)
						{
							Rect rect = new Rect((float)vector2Int3[0] / (float)sourceTexture.width, (float)vector2Int[0] / (float)sourceTexture.height, (float)(vector2Int3[1] - vector2Int3[0]) / (float)sourceTexture.width, (float)(vector2Int[1] - vector2Int[0]) / (float)sourceTexture.height);
							GL.TexCoord2(rect.x, rect.y);
							GL.Vertex3((float)vector2Int4[0], (float)vector2Int2[0], 0.5f * (vector2[0] + vector[0]));
							GL.TexCoord2(rect.x, rect.yMax);
							GL.Vertex3((float)vector2Int4[0], (float)vector2Int2[1], 0.5f * (vector2[0] + vector[1]));
							GL.TexCoord2(rect.xMax, rect.yMax);
							GL.Vertex3((float)vector2Int4[1], (float)vector2Int2[1], 0.5f * (vector2[1] + vector[1]));
							GL.TexCoord2(rect.xMax, rect.y);
							GL.Vertex3((float)vector2Int4[1], (float)vector2Int2[0], 0.5f * (vector2[1] + vector[0]));
						}
					}
				}
			}
			GL.End();
		}

		// Token: 0x060001EC RID: 492 RVA: 0x00006FF0 File Offset: 0x000051F0
		public static RectInt CalcPixelRectFromBounds(Terrain terrain, Rect boundsInTerrainSpace, int textureWidth, int textureHeight, int extraBorderPixels, bool sharedBoundaryTexel)
		{
			float num = ((float)textureWidth - (sharedBoundaryTexel ? 1f : 0f)) / terrain.terrainData.size.x;
			float num2 = ((float)textureHeight - (sharedBoundaryTexel ? 1f : 0f)) / terrain.terrainData.size.z;
			int num3 = Mathf.FloorToInt(boundsInTerrainSpace.xMin * num) - extraBorderPixels;
			int num4 = Mathf.FloorToInt(boundsInTerrainSpace.yMin * num2) - extraBorderPixels;
			int num5 = Mathf.CeilToInt(boundsInTerrainSpace.xMax * num) + extraBorderPixels;
			int num6 = Mathf.CeilToInt(boundsInTerrainSpace.yMax * num2) + extraBorderPixels;
			int num7 = PaintContext.ClampContextResolution(num5 - num3 + 1);
			int num8 = PaintContext.ClampContextResolution(num6 - num4 + 1);
			return new RectInt(num3, num4, num7, num8);
		}

		// Token: 0x060001ED RID: 493 RVA: 0x000070C0 File Offset: 0x000052C0
		public static Texture2D GetTerrainAlphaMapChecked(Terrain terrain, int mapIndex)
		{
			bool flag = mapIndex >= terrain.terrainData.alphamapTextureCount;
			if (flag)
			{
				throw new ArgumentException("Trying to access out-of-bounds terrain alphamap information.");
			}
			return terrain.terrainData.GetAlphamapTexture(mapIndex);
		}

		// Token: 0x060001EE RID: 494 RVA: 0x00003597 File Offset: 0x00001797
		public static int FindTerrainLayerIndex(Terrain terrain, TerrainLayer inputLayer)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060001EF RID: 495 RVA: 0x000035A4 File Offset: 0x000017A4
		public static int AddTerrainLayer(Terrain terrain, TerrainLayer inputLayer)
		{
			throw new NotSupportedException("Method unstripping failed");
		}
	}
}
