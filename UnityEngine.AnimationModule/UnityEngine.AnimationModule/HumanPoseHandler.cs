using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Unity.Collections;

namespace UnityEngine
{
	// Token: 0x02000044 RID: 68
	public class HumanPoseHandler
	{
		// Token: 0x0600049B RID: 1179 RVA: 0x00003AA8 File Offset: 0x00001CA8
		public static IntPtr Internal_CreateFromRoot(Avatar avatar, Transform root)
		{
			return HumanPoseHandler.Internal_CreateFromRootDelegateField(IL2CPP.Il2CppObjectBaseToPtr(avatar), IL2CPP.Il2CppObjectBaseToPtr(root));
		}

		// Token: 0x0600049C RID: 1180 RVA: 0x00003AC0 File Offset: 0x00001CC0
		public static IntPtr Internal_CreateFromJointPaths(Avatar avatar, Il2CppStringArray jointPaths)
		{
			return HumanPoseHandler.Internal_CreateFromJointPathsDelegateField(IL2CPP.Il2CppObjectBaseToPtr(avatar), IL2CPP.Il2CppObjectBaseToPtr(jointPaths));
		}

		// Token: 0x0600049D RID: 1181 RVA: 0x00003AD8 File Offset: 0x00001CD8
		public static void Internal_Destroy(IntPtr ptr)
		{
			HumanPoseHandler.Internal_DestroyDelegateField(ptr);
		}

		// Token: 0x0600049E RID: 1182 RVA: 0x00003AE5 File Offset: 0x00001CE5
		public void GetHumanPose(out Vector3 bodyPosition, out Quaternion bodyRotation, [Out] Il2CppStructArray<float> muscles)
		{
			HumanPoseHandler.GetHumanPoseDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out bodyPosition, out bodyRotation, IL2CPP.Il2CppObjectBaseToPtr(muscles));
		}

		// Token: 0x0600049F RID: 1183 RVA: 0x00003AFF File Offset: 0x00001CFF
		public void SetHumanPose(ref Vector3 bodyPosition, ref Quaternion bodyRotation, Il2CppStructArray<float> muscles)
		{
			HumanPoseHandler.SetHumanPoseDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref bodyPosition, ref bodyRotation, IL2CPP.Il2CppObjectBaseToPtr(muscles));
		}

		// Token: 0x060004A0 RID: 1184 RVA: 0x00003B19 File Offset: 0x00001D19
		public void GetInternalHumanPose(out Vector3 bodyPosition, out Quaternion bodyRotation, [Out] Il2CppStructArray<float> muscles)
		{
			HumanPoseHandler.GetInternalHumanPoseDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out bodyPosition, out bodyRotation, IL2CPP.Il2CppObjectBaseToPtr(muscles));
		}

		// Token: 0x060004A1 RID: 1185 RVA: 0x00003B33 File Offset: 0x00001D33
		public void SetInternalHumanPose(ref Vector3 bodyPosition, ref Quaternion bodyRotation, Il2CppStructArray<float> muscles)
		{
			HumanPoseHandler.SetInternalHumanPoseDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref bodyPosition, ref bodyRotation, IL2CPP.Il2CppObjectBaseToPtr(muscles));
		}

		// Token: 0x060004A2 RID: 1186 RVA: 0x00003B4D File Offset: 0x00001D4D
		public unsafe void GetInternalAvatarPose(void* avatarPose, int avatarPoseLength)
		{
			HumanPoseHandler.GetInternalAvatarPoseDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), avatarPose, avatarPoseLength);
		}

		// Token: 0x060004A3 RID: 1187 RVA: 0x00003B61 File Offset: 0x00001D61
		public unsafe void SetInternalAvatarPose(void* avatarPose, int avatarPoseLength)
		{
			HumanPoseHandler.SetInternalAvatarPoseDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), avatarPose, avatarPoseLength);
		}

		// Token: 0x060004A4 RID: 1188 RVA: 0x00003B75 File Offset: 0x00001D75
		public void Dispose()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060004A5 RID: 1189 RVA: 0x00003B82 File Offset: 0x00001D82
		public void GetInternalAvatarPose(NativeArray<float> avatarPose)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060004A6 RID: 1190 RVA: 0x00003B8F File Offset: 0x00001D8F
		public void SetInternalAvatarPose(NativeArray<float> avatarPose)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x040003FC RID: 1020
		private static readonly HumanPoseHandler.Internal_CreateFromRootDelegate Internal_CreateFromRootDelegateField = IL2CPP.ResolveICall<HumanPoseHandler.Internal_CreateFromRootDelegate>("UnityEngine.HumanPoseHandler::Internal_CreateFromRoot");

		// Token: 0x040003FD RID: 1021
		private static readonly HumanPoseHandler.Internal_CreateFromJointPathsDelegate Internal_CreateFromJointPathsDelegateField = IL2CPP.ResolveICall<HumanPoseHandler.Internal_CreateFromJointPathsDelegate>("UnityEngine.HumanPoseHandler::Internal_CreateFromJointPaths");

		// Token: 0x040003FE RID: 1022
		private static readonly HumanPoseHandler.Internal_DestroyDelegate Internal_DestroyDelegateField = IL2CPP.ResolveICall<HumanPoseHandler.Internal_DestroyDelegate>("UnityEngine.HumanPoseHandler::Internal_Destroy");

		// Token: 0x040003FF RID: 1023
		private static readonly HumanPoseHandler.GetHumanPoseDelegate GetHumanPoseDelegateField = IL2CPP.ResolveICall<HumanPoseHandler.GetHumanPoseDelegate>("UnityEngine.HumanPoseHandler::GetHumanPose");

		// Token: 0x04000400 RID: 1024
		private static readonly HumanPoseHandler.SetHumanPoseDelegate SetHumanPoseDelegateField = IL2CPP.ResolveICall<HumanPoseHandler.SetHumanPoseDelegate>("UnityEngine.HumanPoseHandler::SetHumanPose");

		// Token: 0x04000401 RID: 1025
		private static readonly HumanPoseHandler.GetInternalHumanPoseDelegate GetInternalHumanPoseDelegateField = IL2CPP.ResolveICall<HumanPoseHandler.GetInternalHumanPoseDelegate>("UnityEngine.HumanPoseHandler::GetInternalHumanPose");

		// Token: 0x04000402 RID: 1026
		private static readonly HumanPoseHandler.SetInternalHumanPoseDelegate SetInternalHumanPoseDelegateField = IL2CPP.ResolveICall<HumanPoseHandler.SetInternalHumanPoseDelegate>("UnityEngine.HumanPoseHandler::SetInternalHumanPose");

		// Token: 0x04000403 RID: 1027
		private static readonly HumanPoseHandler.GetInternalAvatarPoseDelegate GetInternalAvatarPoseDelegateField = IL2CPP.ResolveICall<HumanPoseHandler.GetInternalAvatarPoseDelegate>("UnityEngine.HumanPoseHandler::GetInternalAvatarPose");

		// Token: 0x04000404 RID: 1028
		private static readonly HumanPoseHandler.SetInternalAvatarPoseDelegate SetInternalAvatarPoseDelegateField = IL2CPP.ResolveICall<HumanPoseHandler.SetInternalAvatarPoseDelegate>("UnityEngine.HumanPoseHandler::SetInternalAvatarPose");

		// Token: 0x0200012E RID: 302
		// (Invoke) Token: 0x06000739 RID: 1849
		private delegate IntPtr Internal_CreateFromRootDelegate(IntPtr avatar, IntPtr root);

		// Token: 0x0200012F RID: 303
		// (Invoke) Token: 0x0600073B RID: 1851
		private delegate IntPtr Internal_CreateFromJointPathsDelegate(IntPtr avatar, IntPtr jointPaths);

		// Token: 0x02000130 RID: 304
		// (Invoke) Token: 0x0600073D RID: 1853
		private delegate void Internal_DestroyDelegate(IntPtr ptr);

		// Token: 0x02000131 RID: 305
		// (Invoke) Token: 0x0600073F RID: 1855
		private delegate void GetHumanPoseDelegate(IntPtr @this, [Out] IntPtr bodyPosition, [Out] IntPtr bodyRotation, [Out] IntPtr muscles);

		// Token: 0x02000132 RID: 306
		// (Invoke) Token: 0x06000741 RID: 1857
		private delegate void SetHumanPoseDelegate(IntPtr @this, IntPtr bodyPosition, IntPtr bodyRotation, IntPtr muscles);

		// Token: 0x02000133 RID: 307
		// (Invoke) Token: 0x06000743 RID: 1859
		private delegate void GetInternalHumanPoseDelegate(IntPtr @this, [Out] IntPtr bodyPosition, [Out] IntPtr bodyRotation, [Out] IntPtr muscles);

		// Token: 0x02000134 RID: 308
		// (Invoke) Token: 0x06000745 RID: 1861
		private delegate void SetInternalHumanPoseDelegate(IntPtr @this, IntPtr bodyPosition, IntPtr bodyRotation, IntPtr muscles);

		// Token: 0x02000135 RID: 309
		// (Invoke) Token: 0x06000747 RID: 1863
		private delegate void GetInternalAvatarPoseDelegate(IntPtr @this, IntPtr avatarPose, int avatarPoseLength);

		// Token: 0x02000136 RID: 310
		// (Invoke) Token: 0x06000749 RID: 1865
		private delegate void SetInternalAvatarPoseDelegate(IntPtr @this, IntPtr avatarPose, int avatarPoseLength);
	}
}
