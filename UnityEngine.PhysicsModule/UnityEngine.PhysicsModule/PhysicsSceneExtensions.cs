using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine.SceneManagement;

namespace UnityEngine
{
	// Token: 0x0200002E RID: 46
	public static class PhysicsSceneExtensions
	{
		// Token: 0x06000428 RID: 1064 RVA: 0x0000C6E4 File Offset: 0x0000A8E4
		public static PhysicsScene GetPhysicsScene(Scene scene)
		{
			bool flag = !scene.IsValid();
			if (flag)
			{
				throw new ArgumentException("Cannot get physics scene; Unity scene is invalid.", "scene");
			}
			PhysicsScene physicsScene_Internal = PhysicsSceneExtensions.GetPhysicsScene_Internal(scene);
			bool flag2 = physicsScene_Internal.IsValid();
			if (flag2)
			{
				return physicsScene_Internal;
			}
			throw new Exception("The physics scene associated with the Unity scene is invalid.");
		}

		// Token: 0x06000429 RID: 1065 RVA: 0x0000C734 File Offset: 0x0000A934
		public static PhysicsScene GetPhysicsScene_Internal(Scene scene)
		{
			PhysicsScene physicsScene;
			PhysicsSceneExtensions.GetPhysicsScene_Internal_Injected(ref scene, out physicsScene);
			return physicsScene;
		}

		// Token: 0x0600042A RID: 1066 RVA: 0x000047E2 File Offset: 0x000029E2
		public static void GetPhysicsScene_Internal_Injected(ref Scene scene, out PhysicsScene ret)
		{
			PhysicsSceneExtensions.GetPhysicsScene_Internal_InjectedDelegateField(ref scene, out ret);
		}

		// Token: 0x04000306 RID: 774
		private static readonly PhysicsSceneExtensions.GetPhysicsScene_Internal_InjectedDelegate GetPhysicsScene_Internal_InjectedDelegateField = IL2CPP.ResolveICall<PhysicsSceneExtensions.GetPhysicsScene_Internal_InjectedDelegate>("UnityEngine.PhysicsSceneExtensions::GetPhysicsScene_Internal_Injected");

		// Token: 0x020001D9 RID: 473
		// (Invoke) Token: 0x0600078A RID: 1930
		private delegate void GetPhysicsScene_Internal_InjectedDelegate(IntPtr scene, [Out] IntPtr ret);
	}
}
