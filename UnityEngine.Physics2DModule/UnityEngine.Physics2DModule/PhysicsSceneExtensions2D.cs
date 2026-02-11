using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine.SceneManagement;

namespace UnityEngine
{
	// Token: 0x0200000A RID: 10
	public static class PhysicsSceneExtensions2D
	{
		// Token: 0x0600032F RID: 815 RVA: 0x0000B548 File Offset: 0x00009748
		public static PhysicsScene2D GetPhysicsScene2D(Scene scene)
		{
			bool flag = !scene.IsValid();
			if (flag)
			{
				throw new ArgumentException("Cannot get physics scene; Unity scene is invalid.", "scene");
			}
			PhysicsScene2D physicsScene_Internal = PhysicsSceneExtensions2D.GetPhysicsScene_Internal(scene);
			bool flag2 = physicsScene_Internal.IsValid();
			if (flag2)
			{
				return physicsScene_Internal;
			}
			throw new Exception("The physics scene associated with the Unity scene is invalid.");
		}

		// Token: 0x06000330 RID: 816 RVA: 0x0000B598 File Offset: 0x00009798
		public static PhysicsScene2D GetPhysicsScene_Internal(Scene scene)
		{
			PhysicsScene2D physicsScene2D;
			PhysicsSceneExtensions2D.GetPhysicsScene_Internal_Injected(ref scene, out physicsScene2D);
			return physicsScene2D;
		}

		// Token: 0x06000331 RID: 817 RVA: 0x00003762 File Offset: 0x00001962
		public static void GetPhysicsScene_Internal_Injected(ref Scene scene, out PhysicsScene2D ret)
		{
			PhysicsSceneExtensions2D.GetPhysicsScene_Internal_InjectedDelegateField(ref scene, out ret);
		}

		// Token: 0x04000161 RID: 353
		private static readonly PhysicsSceneExtensions2D.GetPhysicsScene_Internal_InjectedDelegate GetPhysicsScene_Internal_InjectedDelegateField = IL2CPP.ResolveICall<PhysicsSceneExtensions2D.GetPhysicsScene_Internal_InjectedDelegate>("UnityEngine.PhysicsSceneExtensions2D::GetPhysicsScene_Internal_Injected");

		// Token: 0x0200011F RID: 287
		// (Invoke) Token: 0x0600066A RID: 1642
		private delegate void GetPhysicsScene_Internal_InjectedDelegate(IntPtr scene, [Out] IntPtr ret);
	}
}
