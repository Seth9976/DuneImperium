using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine
{
	// Token: 0x02000041 RID: 65
	public class AvatarBuilder
	{
		// Token: 0x06000486 RID: 1158 RVA: 0x00012868 File Offset: 0x00010A68
		public static Avatar BuildGenericAvatar(GameObject go, string rootMotionTransformName)
		{
			IntPtr intPtr = AvatarBuilder.BuildGenericAvatarDelegateField(IL2CPP.Il2CppObjectBaseToPtr(go), IL2CPP.ManagedStringToIl2Cpp(rootMotionTransformName));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Avatar>(intPtr2) : null;
		}

		// Token: 0x040003E0 RID: 992
		private static readonly AvatarBuilder.BuildGenericAvatarDelegate BuildGenericAvatarDelegateField = IL2CPP.ResolveICall<AvatarBuilder.BuildGenericAvatarDelegate>("UnityEngine.AvatarBuilder::BuildGenericAvatar");

		// Token: 0x02000121 RID: 289
		// (Invoke) Token: 0x0600071F RID: 1823
		private delegate IntPtr BuildGenericAvatarDelegate(IntPtr go, IntPtr rootMotionTransformName);
	}
}
