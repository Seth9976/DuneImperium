using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x0200001A RID: 26
	public sealed class CustomCollider2D : Collider2D
	{
		// Token: 0x17000083 RID: 131
		// (get) Token: 0x06000347 RID: 839 RVA: 0x0000385A File Offset: 0x00001A5A
		public int customShapeCount
		{
			get
			{
				return CustomCollider2D.get_customShapeCountDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x17000084 RID: 132
		// (get) Token: 0x06000348 RID: 840 RVA: 0x0000386C File Offset: 0x00001A6C
		public int customVertexCount
		{
			get
			{
				return CustomCollider2D.get_customVertexCountDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x06000349 RID: 841 RVA: 0x0000387E File Offset: 0x00001A7E
		public int GetCustomShapes(PhysicsShapeGroup2D physicsShapeGroup)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600034A RID: 842 RVA: 0x0000388B File Offset: 0x00001A8B
		public int GetCustomShapes(PhysicsShapeGroup2D physicsShapeGroup, int shapeIndex, [Optional] int shapeCount)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600034B RID: 843 RVA: 0x00003898 File Offset: 0x00001A98
		public int GetCustomShapesNative_Internal(IntPtr shapesPtr, int shapeCount, IntPtr verticesPtr, int vertexCount)
		{
			return CustomCollider2D.GetCustomShapesNative_InternalDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), shapesPtr, shapeCount, verticesPtr, vertexCount);
		}

		// Token: 0x0600034C RID: 844 RVA: 0x000038AF File Offset: 0x00001AAF
		public void SetCustomShapes(PhysicsShapeGroup2D physicsShapeGroup)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600034D RID: 845 RVA: 0x000038BC File Offset: 0x00001ABC
		public void SetCustomShapesNative_Internal(IntPtr shapesPtr, int shapeCount, IntPtr verticesPtr, int vertexCount)
		{
			CustomCollider2D.SetCustomShapesNative_InternalDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), shapesPtr, shapeCount, verticesPtr, vertexCount);
		}

		// Token: 0x0600034E RID: 846 RVA: 0x000038D3 File Offset: 0x00001AD3
		public void SetCustomShape(PhysicsShapeGroup2D physicsShapeGroup, int srcShapeIndex, int dstShapeIndex)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600034F RID: 847 RVA: 0x000038E0 File Offset: 0x00001AE0
		public void SetCustomShapeNative_Internal(IntPtr shapesPtr, int shapeCount, IntPtr verticesPtr, int vertexCount, int srcShapeIndex, int dstShapeIndex)
		{
			CustomCollider2D.SetCustomShapeNative_InternalDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), shapesPtr, shapeCount, verticesPtr, vertexCount, srcShapeIndex, dstShapeIndex);
		}

		// Token: 0x06000350 RID: 848 RVA: 0x0000B68C File Offset: 0x0000988C
		public void ClearCustomShapes(int shapeIndex, int shapeCount)
		{
			int customShapeCount = this.customShapeCount;
			bool flag = shapeIndex < 0 || shapeIndex >= customShapeCount;
			if (flag)
			{
				throw new ArgumentOutOfRangeException(String.Format("Cannot clear custom shape(s) at index {0} as the CustomCollider2D only has {1} shape(s).", shapeIndex, customShapeCount));
			}
			bool flag2 = shapeIndex + shapeCount < 0 || shapeIndex + shapeCount > this.customShapeCount;
			if (flag2)
			{
				throw new ArgumentOutOfRangeException(String.Format("Cannot clear custom shape(s) in the range (index {0}, count {1}) as this range is outside range of the existing {2} shape(s).", shapeIndex, shapeCount, this.customShapeCount));
			}
			this.ClearCustomShapes_Internal(shapeIndex, shapeCount);
		}

		// Token: 0x06000351 RID: 849 RVA: 0x000038FB File Offset: 0x00001AFB
		public void ClearCustomShapes_Internal(int shapeIndex, int shapeCount)
		{
			CustomCollider2D.ClearCustomShapes_InternalDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), shapeIndex, shapeCount);
		}

		// Token: 0x06000352 RID: 850 RVA: 0x0000390F File Offset: 0x00001B0F
		public void ClearCustomShapes()
		{
			CustomCollider2D.ClearCustomShapesDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x0400019E RID: 414
		private static readonly CustomCollider2D.get_customShapeCountDelegate get_customShapeCountDelegateField = IL2CPP.ResolveICall<CustomCollider2D.get_customShapeCountDelegate>("UnityEngine.CustomCollider2D::get_customShapeCount");

		// Token: 0x0400019F RID: 415
		private static readonly CustomCollider2D.get_customVertexCountDelegate get_customVertexCountDelegateField = IL2CPP.ResolveICall<CustomCollider2D.get_customVertexCountDelegate>("UnityEngine.CustomCollider2D::get_customVertexCount");

		// Token: 0x040001A0 RID: 416
		private static readonly CustomCollider2D.GetCustomShapesNative_InternalDelegate GetCustomShapesNative_InternalDelegateField = IL2CPP.ResolveICall<CustomCollider2D.GetCustomShapesNative_InternalDelegate>("UnityEngine.CustomCollider2D::GetCustomShapesNative_Internal");

		// Token: 0x040001A1 RID: 417
		private static readonly CustomCollider2D.SetCustomShapesNative_InternalDelegate SetCustomShapesNative_InternalDelegateField = IL2CPP.ResolveICall<CustomCollider2D.SetCustomShapesNative_InternalDelegate>("UnityEngine.CustomCollider2D::SetCustomShapesNative_Internal");

		// Token: 0x040001A2 RID: 418
		private static readonly CustomCollider2D.SetCustomShapeNative_InternalDelegate SetCustomShapeNative_InternalDelegateField = IL2CPP.ResolveICall<CustomCollider2D.SetCustomShapeNative_InternalDelegate>("UnityEngine.CustomCollider2D::SetCustomShapeNative_Internal");

		// Token: 0x040001A3 RID: 419
		private static readonly CustomCollider2D.ClearCustomShapes_InternalDelegate ClearCustomShapes_InternalDelegateField = IL2CPP.ResolveICall<CustomCollider2D.ClearCustomShapes_InternalDelegate>("UnityEngine.CustomCollider2D::ClearCustomShapes_Internal");

		// Token: 0x040001A4 RID: 420
		private static readonly CustomCollider2D.ClearCustomShapesDelegate ClearCustomShapesDelegateField = IL2CPP.ResolveICall<CustomCollider2D.ClearCustomShapesDelegate>("UnityEngine.CustomCollider2D::ClearCustomShapes");

		// Token: 0x02000120 RID: 288
		// (Invoke) Token: 0x0600066C RID: 1644
		private delegate int get_customShapeCountDelegate(IntPtr @this);

		// Token: 0x02000121 RID: 289
		// (Invoke) Token: 0x0600066E RID: 1646
		private delegate int get_customVertexCountDelegate(IntPtr @this);

		// Token: 0x02000122 RID: 290
		// (Invoke) Token: 0x06000670 RID: 1648
		private delegate int GetCustomShapesNative_InternalDelegate(IntPtr @this, IntPtr shapesPtr, int shapeCount, IntPtr verticesPtr, int vertexCount);

		// Token: 0x02000123 RID: 291
		// (Invoke) Token: 0x06000672 RID: 1650
		private delegate void SetCustomShapesNative_InternalDelegate(IntPtr @this, IntPtr shapesPtr, int shapeCount, IntPtr verticesPtr, int vertexCount);

		// Token: 0x02000124 RID: 292
		// (Invoke) Token: 0x06000674 RID: 1652
		private delegate void SetCustomShapeNative_InternalDelegate(IntPtr @this, IntPtr shapesPtr, int shapeCount, IntPtr verticesPtr, int vertexCount, int srcShapeIndex, int dstShapeIndex);

		// Token: 0x02000125 RID: 293
		// (Invoke) Token: 0x06000676 RID: 1654
		private delegate void ClearCustomShapes_InternalDelegate(IntPtr @this, int shapeIndex, int shapeCount);

		// Token: 0x02000126 RID: 294
		// (Invoke) Token: 0x06000678 RID: 1656
		private delegate void ClearCustomShapesDelegate(IntPtr @this);
	}
}
