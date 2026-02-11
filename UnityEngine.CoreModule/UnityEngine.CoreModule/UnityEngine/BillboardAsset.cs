using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine
{
	// Token: 0x020002CD RID: 717
	public sealed class BillboardAsset : Object
	{
		// Token: 0x06002D0F RID: 11535 RVA: 0x000119FB File Offset: 0x0000FBFB
		public static void Internal_Create(BillboardAsset obj)
		{
			BillboardAsset.Internal_CreateDelegateField(IL2CPP.Il2CppObjectBaseToPtr(obj));
		}

		// Token: 0x17000924 RID: 2340
		// (get) Token: 0x06002D10 RID: 11536 RVA: 0x00011A0D File Offset: 0x0000FC0D
		// (set) Token: 0x06002D11 RID: 11537 RVA: 0x00011A1F File Offset: 0x0000FC1F
		public float width
		{
			get
			{
				return BillboardAsset.get_widthDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				BillboardAsset.set_widthDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000925 RID: 2341
		// (get) Token: 0x06002D12 RID: 11538 RVA: 0x00011A32 File Offset: 0x0000FC32
		// (set) Token: 0x06002D13 RID: 11539 RVA: 0x00011A44 File Offset: 0x0000FC44
		public float height
		{
			get
			{
				return BillboardAsset.get_heightDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				BillboardAsset.set_heightDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000926 RID: 2342
		// (get) Token: 0x06002D14 RID: 11540 RVA: 0x00011A57 File Offset: 0x0000FC57
		// (set) Token: 0x06002D15 RID: 11541 RVA: 0x00011A69 File Offset: 0x0000FC69
		public float bottom
		{
			get
			{
				return BillboardAsset.get_bottomDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				BillboardAsset.set_bottomDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000927 RID: 2343
		// (get) Token: 0x06002D16 RID: 11542 RVA: 0x00011A7C File Offset: 0x0000FC7C
		public int imageCount
		{
			get
			{
				return BillboardAsset.get_imageCountDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x17000928 RID: 2344
		// (get) Token: 0x06002D17 RID: 11543 RVA: 0x00011A8E File Offset: 0x0000FC8E
		public int vertexCount
		{
			get
			{
				return BillboardAsset.get_vertexCountDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x17000929 RID: 2345
		// (get) Token: 0x06002D18 RID: 11544 RVA: 0x00011AA0 File Offset: 0x0000FCA0
		public int indexCount
		{
			get
			{
				return BillboardAsset.get_indexCountDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x1700092A RID: 2346
		// (get) Token: 0x06002D19 RID: 11545 RVA: 0x000B32D0 File Offset: 0x000B14D0
		// (set) Token: 0x06002D1A RID: 11546 RVA: 0x00011AB2 File Offset: 0x0000FCB2
		public Material material
		{
			get
			{
				IntPtr intPtr = BillboardAsset.get_materialDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				BillboardAsset.set_materialDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x06002D1B RID: 11547 RVA: 0x000B32FC File Offset: 0x000B14FC
		public void GetImageTexCoords(List<Vector4> imageTexCoords)
		{
			bool flag = imageTexCoords == null;
			if (flag)
			{
				throw new ArgumentNullException("imageTexCoords");
			}
			this.GetImageTexCoordsInternal(imageTexCoords);
		}

		// Token: 0x06002D1C RID: 11548 RVA: 0x000B3328 File Offset: 0x000B1528
		public Il2CppStructArray<Vector4> GetImageTexCoords()
		{
			IntPtr intPtr = BillboardAsset.GetImageTexCoordsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector4>>(intPtr2) : null;
		}

		// Token: 0x06002D1D RID: 11549 RVA: 0x00011ACA File Offset: 0x0000FCCA
		public void GetImageTexCoordsInternal(Object list)
		{
			BillboardAsset.GetImageTexCoordsInternalDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(list));
		}

		// Token: 0x06002D1E RID: 11550 RVA: 0x000B3354 File Offset: 0x000B1554
		public void SetImageTexCoords(List<Vector4> imageTexCoords)
		{
			bool flag = imageTexCoords == null;
			if (flag)
			{
				throw new ArgumentNullException("imageTexCoords");
			}
			this.SetImageTexCoordsInternalList(imageTexCoords);
		}

		// Token: 0x06002D1F RID: 11551 RVA: 0x00011AE2 File Offset: 0x0000FCE2
		public void SetImageTexCoords(Il2CppStructArray<Vector4> imageTexCoords)
		{
			BillboardAsset.SetImageTexCoordsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(imageTexCoords));
		}

		// Token: 0x06002D20 RID: 11552 RVA: 0x00011AFA File Offset: 0x0000FCFA
		public void SetImageTexCoordsInternalList(Object list)
		{
			BillboardAsset.SetImageTexCoordsInternalListDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(list));
		}

		// Token: 0x06002D21 RID: 11553 RVA: 0x000B3380 File Offset: 0x000B1580
		public void GetVertices(List<Vector2> vertices)
		{
			bool flag = vertices == null;
			if (flag)
			{
				throw new ArgumentNullException("vertices");
			}
			this.GetVerticesInternal(vertices);
		}

		// Token: 0x06002D22 RID: 11554 RVA: 0x000B33AC File Offset: 0x000B15AC
		public Il2CppStructArray<Vector2> GetVertices()
		{
			IntPtr intPtr = BillboardAsset.GetVerticesDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector2>>(intPtr2) : null;
		}

		// Token: 0x06002D23 RID: 11555 RVA: 0x00011B12 File Offset: 0x0000FD12
		public void GetVerticesInternal(Object list)
		{
			BillboardAsset.GetVerticesInternalDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(list));
		}

		// Token: 0x06002D24 RID: 11556 RVA: 0x000B33D8 File Offset: 0x000B15D8
		public void SetVertices(List<Vector2> vertices)
		{
			bool flag = vertices == null;
			if (flag)
			{
				throw new ArgumentNullException("vertices");
			}
			this.SetVerticesInternalList(vertices);
		}

		// Token: 0x06002D25 RID: 11557 RVA: 0x00011B2A File Offset: 0x0000FD2A
		public void SetVertices(Il2CppStructArray<Vector2> vertices)
		{
			BillboardAsset.SetVerticesDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(vertices));
		}

		// Token: 0x06002D26 RID: 11558 RVA: 0x00011B42 File Offset: 0x0000FD42
		public void SetVerticesInternalList(Object list)
		{
			BillboardAsset.SetVerticesInternalListDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(list));
		}

		// Token: 0x06002D27 RID: 11559 RVA: 0x000B3404 File Offset: 0x000B1604
		public void GetIndices(List<ushort> indices)
		{
			bool flag = indices == null;
			if (flag)
			{
				throw new ArgumentNullException("indices");
			}
			this.GetIndicesInternal(indices);
		}

		// Token: 0x06002D28 RID: 11560 RVA: 0x000B3430 File Offset: 0x000B1630
		public Il2CppStructArray<ushort> GetIndices()
		{
			IntPtr intPtr = BillboardAsset.GetIndicesDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<ushort>>(intPtr2) : null;
		}

		// Token: 0x06002D29 RID: 11561 RVA: 0x00011B5A File Offset: 0x0000FD5A
		public void GetIndicesInternal(Object list)
		{
			BillboardAsset.GetIndicesInternalDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(list));
		}

		// Token: 0x06002D2A RID: 11562 RVA: 0x000B345C File Offset: 0x000B165C
		public void SetIndices(List<ushort> indices)
		{
			bool flag = indices == null;
			if (flag)
			{
				throw new ArgumentNullException("indices");
			}
			this.SetIndicesInternalList(indices);
		}

		// Token: 0x06002D2B RID: 11563 RVA: 0x00011B72 File Offset: 0x0000FD72
		public void SetIndices(Il2CppStructArray<ushort> indices)
		{
			BillboardAsset.SetIndicesDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(indices));
		}

		// Token: 0x06002D2C RID: 11564 RVA: 0x00011B8A File Offset: 0x0000FD8A
		public void SetIndicesInternalList(Object list)
		{
			BillboardAsset.SetIndicesInternalListDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(list));
		}

		// Token: 0x06002D2D RID: 11565 RVA: 0x00011BA2 File Offset: 0x0000FDA2
		public void MakeMaterialProperties(MaterialPropertyBlock properties, Camera camera)
		{
			BillboardAsset.MakeMaterialPropertiesDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(properties), IL2CPP.Il2CppObjectBaseToPtr(camera));
		}

		// Token: 0x04002868 RID: 10344
		private static readonly BillboardAsset.Internal_CreateDelegate Internal_CreateDelegateField = IL2CPP.ResolveICall<BillboardAsset.Internal_CreateDelegate>("UnityEngine.BillboardAsset::Internal_Create");

		// Token: 0x04002869 RID: 10345
		private static readonly BillboardAsset.get_widthDelegate get_widthDelegateField = IL2CPP.ResolveICall<BillboardAsset.get_widthDelegate>("UnityEngine.BillboardAsset::get_width");

		// Token: 0x0400286A RID: 10346
		private static readonly BillboardAsset.set_widthDelegate set_widthDelegateField = IL2CPP.ResolveICall<BillboardAsset.set_widthDelegate>("UnityEngine.BillboardAsset::set_width");

		// Token: 0x0400286B RID: 10347
		private static readonly BillboardAsset.get_heightDelegate get_heightDelegateField = IL2CPP.ResolveICall<BillboardAsset.get_heightDelegate>("UnityEngine.BillboardAsset::get_height");

		// Token: 0x0400286C RID: 10348
		private static readonly BillboardAsset.set_heightDelegate set_heightDelegateField = IL2CPP.ResolveICall<BillboardAsset.set_heightDelegate>("UnityEngine.BillboardAsset::set_height");

		// Token: 0x0400286D RID: 10349
		private static readonly BillboardAsset.get_bottomDelegate get_bottomDelegateField = IL2CPP.ResolveICall<BillboardAsset.get_bottomDelegate>("UnityEngine.BillboardAsset::get_bottom");

		// Token: 0x0400286E RID: 10350
		private static readonly BillboardAsset.set_bottomDelegate set_bottomDelegateField = IL2CPP.ResolveICall<BillboardAsset.set_bottomDelegate>("UnityEngine.BillboardAsset::set_bottom");

		// Token: 0x0400286F RID: 10351
		private static readonly BillboardAsset.get_imageCountDelegate get_imageCountDelegateField = IL2CPP.ResolveICall<BillboardAsset.get_imageCountDelegate>("UnityEngine.BillboardAsset::get_imageCount");

		// Token: 0x04002870 RID: 10352
		private static readonly BillboardAsset.get_vertexCountDelegate get_vertexCountDelegateField = IL2CPP.ResolveICall<BillboardAsset.get_vertexCountDelegate>("UnityEngine.BillboardAsset::get_vertexCount");

		// Token: 0x04002871 RID: 10353
		private static readonly BillboardAsset.get_indexCountDelegate get_indexCountDelegateField = IL2CPP.ResolveICall<BillboardAsset.get_indexCountDelegate>("UnityEngine.BillboardAsset::get_indexCount");

		// Token: 0x04002872 RID: 10354
		private static readonly BillboardAsset.get_materialDelegate get_materialDelegateField = IL2CPP.ResolveICall<BillboardAsset.get_materialDelegate>("UnityEngine.BillboardAsset::get_material");

		// Token: 0x04002873 RID: 10355
		private static readonly BillboardAsset.set_materialDelegate set_materialDelegateField = IL2CPP.ResolveICall<BillboardAsset.set_materialDelegate>("UnityEngine.BillboardAsset::set_material");

		// Token: 0x04002874 RID: 10356
		private static readonly BillboardAsset.GetImageTexCoordsDelegate GetImageTexCoordsDelegateField = IL2CPP.ResolveICall<BillboardAsset.GetImageTexCoordsDelegate>("UnityEngine.BillboardAsset::GetImageTexCoords");

		// Token: 0x04002875 RID: 10357
		private static readonly BillboardAsset.GetImageTexCoordsInternalDelegate GetImageTexCoordsInternalDelegateField = IL2CPP.ResolveICall<BillboardAsset.GetImageTexCoordsInternalDelegate>("UnityEngine.BillboardAsset::GetImageTexCoordsInternal");

		// Token: 0x04002876 RID: 10358
		private static readonly BillboardAsset.SetImageTexCoordsDelegate SetImageTexCoordsDelegateField = IL2CPP.ResolveICall<BillboardAsset.SetImageTexCoordsDelegate>("UnityEngine.BillboardAsset::SetImageTexCoords");

		// Token: 0x04002877 RID: 10359
		private static readonly BillboardAsset.SetImageTexCoordsInternalListDelegate SetImageTexCoordsInternalListDelegateField = IL2CPP.ResolveICall<BillboardAsset.SetImageTexCoordsInternalListDelegate>("UnityEngine.BillboardAsset::SetImageTexCoordsInternalList");

		// Token: 0x04002878 RID: 10360
		private static readonly BillboardAsset.GetVerticesDelegate GetVerticesDelegateField = IL2CPP.ResolveICall<BillboardAsset.GetVerticesDelegate>("UnityEngine.BillboardAsset::GetVertices");

		// Token: 0x04002879 RID: 10361
		private static readonly BillboardAsset.GetVerticesInternalDelegate GetVerticesInternalDelegateField = IL2CPP.ResolveICall<BillboardAsset.GetVerticesInternalDelegate>("UnityEngine.BillboardAsset::GetVerticesInternal");

		// Token: 0x0400287A RID: 10362
		private static readonly BillboardAsset.SetVerticesDelegate SetVerticesDelegateField = IL2CPP.ResolveICall<BillboardAsset.SetVerticesDelegate>("UnityEngine.BillboardAsset::SetVertices");

		// Token: 0x0400287B RID: 10363
		private static readonly BillboardAsset.SetVerticesInternalListDelegate SetVerticesInternalListDelegateField = IL2CPP.ResolveICall<BillboardAsset.SetVerticesInternalListDelegate>("UnityEngine.BillboardAsset::SetVerticesInternalList");

		// Token: 0x0400287C RID: 10364
		private static readonly BillboardAsset.GetIndicesDelegate GetIndicesDelegateField = IL2CPP.ResolveICall<BillboardAsset.GetIndicesDelegate>("UnityEngine.BillboardAsset::GetIndices");

		// Token: 0x0400287D RID: 10365
		private static readonly BillboardAsset.GetIndicesInternalDelegate GetIndicesInternalDelegateField = IL2CPP.ResolveICall<BillboardAsset.GetIndicesInternalDelegate>("UnityEngine.BillboardAsset::GetIndicesInternal");

		// Token: 0x0400287E RID: 10366
		private static readonly BillboardAsset.SetIndicesDelegate SetIndicesDelegateField = IL2CPP.ResolveICall<BillboardAsset.SetIndicesDelegate>("UnityEngine.BillboardAsset::SetIndices");

		// Token: 0x0400287F RID: 10367
		private static readonly BillboardAsset.SetIndicesInternalListDelegate SetIndicesInternalListDelegateField = IL2CPP.ResolveICall<BillboardAsset.SetIndicesInternalListDelegate>("UnityEngine.BillboardAsset::SetIndicesInternalList");

		// Token: 0x04002880 RID: 10368
		private static readonly BillboardAsset.MakeMaterialPropertiesDelegate MakeMaterialPropertiesDelegateField = IL2CPP.ResolveICall<BillboardAsset.MakeMaterialPropertiesDelegate>("UnityEngine.BillboardAsset::MakeMaterialProperties");

		// Token: 0x02000B00 RID: 2816
		// (Invoke) Token: 0x06003EF5 RID: 16117
		private delegate void Internal_CreateDelegate(IntPtr obj);

		// Token: 0x02000B01 RID: 2817
		// (Invoke) Token: 0x06003EF7 RID: 16119
		private delegate float get_widthDelegate(IntPtr @this);

		// Token: 0x02000B02 RID: 2818
		// (Invoke) Token: 0x06003EF9 RID: 16121
		private delegate void set_widthDelegate(IntPtr @this, float value);

		// Token: 0x02000B03 RID: 2819
		// (Invoke) Token: 0x06003EFB RID: 16123
		private delegate float get_heightDelegate(IntPtr @this);

		// Token: 0x02000B04 RID: 2820
		// (Invoke) Token: 0x06003EFD RID: 16125
		private delegate void set_heightDelegate(IntPtr @this, float value);

		// Token: 0x02000B05 RID: 2821
		// (Invoke) Token: 0x06003EFF RID: 16127
		private delegate float get_bottomDelegate(IntPtr @this);

		// Token: 0x02000B06 RID: 2822
		// (Invoke) Token: 0x06003F01 RID: 16129
		private delegate void set_bottomDelegate(IntPtr @this, float value);

		// Token: 0x02000B07 RID: 2823
		// (Invoke) Token: 0x06003F03 RID: 16131
		private delegate int get_imageCountDelegate(IntPtr @this);

		// Token: 0x02000B08 RID: 2824
		// (Invoke) Token: 0x06003F05 RID: 16133
		private delegate int get_vertexCountDelegate(IntPtr @this);

		// Token: 0x02000B09 RID: 2825
		// (Invoke) Token: 0x06003F07 RID: 16135
		private delegate int get_indexCountDelegate(IntPtr @this);

		// Token: 0x02000B0A RID: 2826
		// (Invoke) Token: 0x06003F09 RID: 16137
		private delegate IntPtr get_materialDelegate(IntPtr @this);

		// Token: 0x02000B0B RID: 2827
		// (Invoke) Token: 0x06003F0B RID: 16139
		private delegate void set_materialDelegate(IntPtr @this, IntPtr value);

		// Token: 0x02000B0C RID: 2828
		// (Invoke) Token: 0x06003F0D RID: 16141
		private delegate IntPtr GetImageTexCoordsDelegate(IntPtr @this);

		// Token: 0x02000B0D RID: 2829
		// (Invoke) Token: 0x06003F0F RID: 16143
		private delegate void GetImageTexCoordsInternalDelegate(IntPtr @this, IntPtr list);

		// Token: 0x02000B0E RID: 2830
		// (Invoke) Token: 0x06003F11 RID: 16145
		private delegate void SetImageTexCoordsDelegate(IntPtr @this, IntPtr imageTexCoords);

		// Token: 0x02000B0F RID: 2831
		// (Invoke) Token: 0x06003F13 RID: 16147
		private delegate void SetImageTexCoordsInternalListDelegate(IntPtr @this, IntPtr list);

		// Token: 0x02000B10 RID: 2832
		// (Invoke) Token: 0x06003F15 RID: 16149
		private delegate IntPtr GetVerticesDelegate(IntPtr @this);

		// Token: 0x02000B11 RID: 2833
		// (Invoke) Token: 0x06003F17 RID: 16151
		private delegate void GetVerticesInternalDelegate(IntPtr @this, IntPtr list);

		// Token: 0x02000B12 RID: 2834
		// (Invoke) Token: 0x06003F19 RID: 16153
		private delegate void SetVerticesDelegate(IntPtr @this, IntPtr vertices);

		// Token: 0x02000B13 RID: 2835
		// (Invoke) Token: 0x06003F1B RID: 16155
		private delegate void SetVerticesInternalListDelegate(IntPtr @this, IntPtr list);

		// Token: 0x02000B14 RID: 2836
		// (Invoke) Token: 0x06003F1D RID: 16157
		private delegate IntPtr GetIndicesDelegate(IntPtr @this);

		// Token: 0x02000B15 RID: 2837
		// (Invoke) Token: 0x06003F1F RID: 16159
		private delegate void GetIndicesInternalDelegate(IntPtr @this, IntPtr list);

		// Token: 0x02000B16 RID: 2838
		// (Invoke) Token: 0x06003F21 RID: 16161
		private delegate void SetIndicesDelegate(IntPtr @this, IntPtr indices);

		// Token: 0x02000B17 RID: 2839
		// (Invoke) Token: 0x06003F23 RID: 16163
		private delegate void SetIndicesInternalListDelegate(IntPtr @this, IntPtr list);

		// Token: 0x02000B18 RID: 2840
		// (Invoke) Token: 0x06003F25 RID: 16165
		private delegate void MakeMaterialPropertiesDelegate(IntPtr @this, IntPtr properties, IntPtr camera);
	}
}
