using System;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine
{
	// Token: 0x020002F3 RID: 755
	public sealed class LineUtility
	{
		// Token: 0x06002D77 RID: 11639 RVA: 0x000B3864 File Offset: 0x000B1A64
		public static void Simplify(List<Vector3> points, float tolerance, List<int> pointsToKeep)
		{
			bool flag = points == null;
			if (flag)
			{
				throw new ArgumentNullException("points");
			}
			bool flag2 = pointsToKeep == null;
			if (flag2)
			{
				throw new ArgumentNullException("pointsToKeep");
			}
			LineUtility.GeneratePointsToKeep3D(points, tolerance, pointsToKeep);
		}

		// Token: 0x06002D78 RID: 11640 RVA: 0x000B38A4 File Offset: 0x000B1AA4
		public static void Simplify(List<Vector3> points, float tolerance, List<Vector3> simplifiedPoints)
		{
			bool flag = points == null;
			if (flag)
			{
				throw new ArgumentNullException("points");
			}
			bool flag2 = simplifiedPoints == null;
			if (flag2)
			{
				throw new ArgumentNullException("simplifiedPoints");
			}
			LineUtility.GenerateSimplifiedPoints3D(points, tolerance, simplifiedPoints);
		}

		// Token: 0x06002D79 RID: 11641 RVA: 0x000B38E4 File Offset: 0x000B1AE4
		public static void Simplify(List<Vector2> points, float tolerance, List<int> pointsToKeep)
		{
			bool flag = points == null;
			if (flag)
			{
				throw new ArgumentNullException("points");
			}
			bool flag2 = pointsToKeep == null;
			if (flag2)
			{
				throw new ArgumentNullException("pointsToKeep");
			}
			LineUtility.GeneratePointsToKeep2D(points, tolerance, pointsToKeep);
		}

		// Token: 0x06002D7A RID: 11642 RVA: 0x000B3924 File Offset: 0x000B1B24
		public static void Simplify(List<Vector2> points, float tolerance, List<Vector2> simplifiedPoints)
		{
			bool flag = points == null;
			if (flag)
			{
				throw new ArgumentNullException("points");
			}
			bool flag2 = simplifiedPoints == null;
			if (flag2)
			{
				throw new ArgumentNullException("simplifiedPoints");
			}
			LineUtility.GenerateSimplifiedPoints2D(points, tolerance, simplifiedPoints);
		}

		// Token: 0x06002D7B RID: 11643 RVA: 0x00012071 File Offset: 0x00010271
		public static void GeneratePointsToKeep3D(Object pointsList, float tolerance, Object pointsToKeepList)
		{
			LineUtility.GeneratePointsToKeep3DDelegateField(IL2CPP.Il2CppObjectBaseToPtr(pointsList), tolerance, IL2CPP.Il2CppObjectBaseToPtr(pointsToKeepList));
		}

		// Token: 0x06002D7C RID: 11644 RVA: 0x0001208A File Offset: 0x0001028A
		public static void GeneratePointsToKeep2D(Object pointsList, float tolerance, Object pointsToKeepList)
		{
			LineUtility.GeneratePointsToKeep2DDelegateField(IL2CPP.Il2CppObjectBaseToPtr(pointsList), tolerance, IL2CPP.Il2CppObjectBaseToPtr(pointsToKeepList));
		}

		// Token: 0x06002D7D RID: 11645 RVA: 0x000120A3 File Offset: 0x000102A3
		public static void GenerateSimplifiedPoints3D(Object pointsList, float tolerance, Object simplifiedPoints)
		{
			LineUtility.GenerateSimplifiedPoints3DDelegateField(IL2CPP.Il2CppObjectBaseToPtr(pointsList), tolerance, IL2CPP.Il2CppObjectBaseToPtr(simplifiedPoints));
		}

		// Token: 0x06002D7E RID: 11646 RVA: 0x000120BC File Offset: 0x000102BC
		public static void GenerateSimplifiedPoints2D(Object pointsList, float tolerance, Object simplifiedPoints)
		{
			LineUtility.GenerateSimplifiedPoints2DDelegateField(IL2CPP.Il2CppObjectBaseToPtr(pointsList), tolerance, IL2CPP.Il2CppObjectBaseToPtr(simplifiedPoints));
		}

		// Token: 0x04002916 RID: 10518
		private static readonly LineUtility.GeneratePointsToKeep3DDelegate GeneratePointsToKeep3DDelegateField = IL2CPP.ResolveICall<LineUtility.GeneratePointsToKeep3DDelegate>("UnityEngine.LineUtility::GeneratePointsToKeep3D");

		// Token: 0x04002917 RID: 10519
		private static readonly LineUtility.GeneratePointsToKeep2DDelegate GeneratePointsToKeep2DDelegateField = IL2CPP.ResolveICall<LineUtility.GeneratePointsToKeep2DDelegate>("UnityEngine.LineUtility::GeneratePointsToKeep2D");

		// Token: 0x04002918 RID: 10520
		private static readonly LineUtility.GenerateSimplifiedPoints3DDelegate GenerateSimplifiedPoints3DDelegateField = IL2CPP.ResolveICall<LineUtility.GenerateSimplifiedPoints3DDelegate>("UnityEngine.LineUtility::GenerateSimplifiedPoints3D");

		// Token: 0x04002919 RID: 10521
		private static readonly LineUtility.GenerateSimplifiedPoints2DDelegate GenerateSimplifiedPoints2DDelegateField = IL2CPP.ResolveICall<LineUtility.GenerateSimplifiedPoints2DDelegate>("UnityEngine.LineUtility::GenerateSimplifiedPoints2D");

		// Token: 0x02000B4E RID: 2894
		// (Invoke) Token: 0x06003F91 RID: 16273
		private delegate void GeneratePointsToKeep3DDelegate(IntPtr pointsList, float tolerance, IntPtr pointsToKeepList);

		// Token: 0x02000B4F RID: 2895
		// (Invoke) Token: 0x06003F93 RID: 16275
		private delegate void GeneratePointsToKeep2DDelegate(IntPtr pointsList, float tolerance, IntPtr pointsToKeepList);

		// Token: 0x02000B50 RID: 2896
		// (Invoke) Token: 0x06003F95 RID: 16277
		private delegate void GenerateSimplifiedPoints3DDelegate(IntPtr pointsList, float tolerance, IntPtr simplifiedPoints);

		// Token: 0x02000B51 RID: 2897
		// (Invoke) Token: 0x06003F97 RID: 16279
		private delegate void GenerateSimplifiedPoints2DDelegate(IntPtr pointsList, float tolerance, IntPtr simplifiedPoints);
	}
}
