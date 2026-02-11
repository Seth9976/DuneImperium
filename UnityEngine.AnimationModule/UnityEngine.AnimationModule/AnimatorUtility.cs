using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;

namespace UnityEngine
{
	// Token: 0x02000038 RID: 56
	public class AnimatorUtility
	{
		// Token: 0x06000483 RID: 1155 RVA: 0x00003959 File Offset: 0x00001B59
		public static void OptimizeTransformHierarchy(GameObject go, Il2CppStringArray exposedTransforms)
		{
			AnimatorUtility.OptimizeTransformHierarchyDelegateField(IL2CPP.Il2CppObjectBaseToPtr(go), IL2CPP.Il2CppObjectBaseToPtr(exposedTransforms));
		}

		// Token: 0x06000484 RID: 1156 RVA: 0x00003971 File Offset: 0x00001B71
		public static void DeoptimizeTransformHierarchy(GameObject go)
		{
			AnimatorUtility.DeoptimizeTransformHierarchyDelegateField(IL2CPP.Il2CppObjectBaseToPtr(go));
		}

		// Token: 0x0400037E RID: 894
		private static readonly AnimatorUtility.OptimizeTransformHierarchyDelegate OptimizeTransformHierarchyDelegateField = IL2CPP.ResolveICall<AnimatorUtility.OptimizeTransformHierarchyDelegate>("UnityEngine.AnimatorUtility::OptimizeTransformHierarchy");

		// Token: 0x0400037F RID: 895
		private static readonly AnimatorUtility.DeoptimizeTransformHierarchyDelegate DeoptimizeTransformHierarchyDelegateField = IL2CPP.ResolveICall<AnimatorUtility.DeoptimizeTransformHierarchyDelegate>("UnityEngine.AnimatorUtility::DeoptimizeTransformHierarchy");

		// Token: 0x0200011F RID: 287
		// (Invoke) Token: 0x0600071B RID: 1819
		private delegate void OptimizeTransformHierarchyDelegate(IntPtr go, IntPtr exposedTransforms);

		// Token: 0x02000120 RID: 288
		// (Invoke) Token: 0x0600071D RID: 1821
		private delegate void DeoptimizeTransformHierarchyDelegate(IntPtr go);
	}
}
