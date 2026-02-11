using System;
using System.Runtime.InteropServices;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine
{
	// Token: 0x02000019 RID: 25
	public class PhysicsShapeGroup2D
	{
		// Token: 0x1700007F RID: 127
		// (get) Token: 0x06000332 RID: 818 RVA: 0x00003770 File Offset: 0x00001970
		public List<Vector2> groupVertices
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x17000080 RID: 128
		// (get) Token: 0x06000333 RID: 819 RVA: 0x0000377D File Offset: 0x0000197D
		public int shapeCount
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x17000081 RID: 129
		// (get) Token: 0x06000334 RID: 820 RVA: 0x0000378A File Offset: 0x0000198A
		public int vertexCount
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x17000082 RID: 130
		// (get) Token: 0x06000335 RID: 821 RVA: 0x00003797 File Offset: 0x00001997
		// (set) Token: 0x06000336 RID: 822 RVA: 0x000037A4 File Offset: 0x000019A4
		public Matrix4x4 localToWorldMatrix
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

		// Token: 0x06000337 RID: 823 RVA: 0x000037B1 File Offset: 0x000019B1
		public void Clear()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000338 RID: 824 RVA: 0x000037BE File Offset: 0x000019BE
		public void Add(PhysicsShapeGroup2D physicsShapeGroup)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000339 RID: 825 RVA: 0x000037CB File Offset: 0x000019CB
		public void GetShapeVertices(int shapeIndex, List<Vector2> vertices)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600033A RID: 826 RVA: 0x000037D8 File Offset: 0x000019D8
		public Vector2 GetShapeVertex(int shapeIndex, int vertexIndex)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600033B RID: 827 RVA: 0x000037E5 File Offset: 0x000019E5
		public void SetShapeVertex(int shapeIndex, int vertexIndex, Vector2 vertex)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600033C RID: 828 RVA: 0x000037F2 File Offset: 0x000019F2
		public void SetShapeRadius(int shapeIndex, float radius)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600033D RID: 829 RVA: 0x000037FF File Offset: 0x000019FF
		public void SetShapeAdjacentVertices(int shapeIndex, bool useAdjacentStart, bool useAdjacentEnd, Vector2 adjacentStart, Vector2 adjacentEnd)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600033E RID: 830 RVA: 0x0000380C File Offset: 0x00001A0C
		public void DeleteShape(int shapeIndex)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600033F RID: 831 RVA: 0x00003819 File Offset: 0x00001A19
		public int AddCircle(Vector2 center, float radius)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000340 RID: 832 RVA: 0x00003826 File Offset: 0x00001A26
		public int AddCapsule(Vector2 vertex0, Vector2 vertex1, float radius)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000341 RID: 833 RVA: 0x00003833 File Offset: 0x00001A33
		public int AddBox(Vector2 center, Vector2 size, [Optional] float angle, [Optional] float edgeRadius)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000342 RID: 834 RVA: 0x00003840 File Offset: 0x00001A40
		public int AddPolygon(List<Vector2> vertices)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000343 RID: 835 RVA: 0x0000B5B0 File Offset: 0x000097B0
		public int AddEdges(List<Vector2> vertices, [Optional] float edgeRadius)
		{
			return this.AddEdges(vertices, false, false, Vector2.zero, Vector2.zero, edgeRadius);
		}

		// Token: 0x06000344 RID: 836 RVA: 0x0000384D File Offset: 0x00001A4D
		public int AddEdges(List<Vector2> vertices, bool useAdjacentStart, bool useAdjacentEnd, Vector2 adjacentStart, Vector2 adjacentEnd, [Optional] float edgeRadius)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000345 RID: 837 RVA: 0x0000B5D8 File Offset: 0x000097D8
		public static Vector2 <AddBox>g__Rotate|28_0(float cos, float sin, Vector2 value)
		{
			return new Vector2(cos * value.x - sin * value.y, sin * value.x + cos * value.y);
		}

		// Token: 0x0400019D RID: 413
		public const float MinVertexSeparation = 0.0025f;
	}
}
