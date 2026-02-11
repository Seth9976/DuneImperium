using System;
using Il2CppInterop.Runtime.InteropTypes.Arrays;

namespace UnityEngine.Android
{
	// Token: 0x0200001D RID: 29
	public struct Permission
	{
		// Token: 0x06000289 RID: 649 RVA: 0x00002CB7 File Offset: 0x00000EB7
		public static AndroidJavaObject GetUnityPermissions()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600028A RID: 650 RVA: 0x0000BD4C File Offset: 0x00009F4C
		public static bool HasUserAuthorizedPermission(string permission)
		{
			bool flag = permission == null;
			return !flag;
		}

		// Token: 0x0600028B RID: 651 RVA: 0x00002CC4 File Offset: 0x00000EC4
		public static void RequestUserPermission(string permission)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600028C RID: 652 RVA: 0x0000BD6C File Offset: 0x00009F6C
		public static void RequestUserPermissions(Il2CppStringArray permissions)
		{
			bool flag = permissions == null || permissions.Length == 0;
			if (!flag)
			{
				Permission.RequestUserPermissions(permissions, null);
			}
		}

		// Token: 0x0600028D RID: 653 RVA: 0x00002CD1 File Offset: 0x00000ED1
		public static void RequestUserPermission(string permission, PermissionCallbacks callbacks)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600028E RID: 654 RVA: 0x0000BD98 File Offset: 0x00009F98
		public static void RequestUserPermissions(Il2CppStringArray permissions, PermissionCallbacks callbacks)
		{
			bool flag = permissions == null || permissions.Length == 0;
			if (flag)
			{
			}
		}

		// Token: 0x0400018F RID: 399
		public const string Camera = "android.permission.CAMERA";

		// Token: 0x04000190 RID: 400
		public const string Microphone = "android.permission.RECORD_AUDIO";

		// Token: 0x04000191 RID: 401
		public const string FineLocation = "android.permission.ACCESS_FINE_LOCATION";

		// Token: 0x04000192 RID: 402
		public const string CoarseLocation = "android.permission.ACCESS_COARSE_LOCATION";

		// Token: 0x04000193 RID: 403
		public const string ExternalStorageRead = "android.permission.READ_EXTERNAL_STORAGE";

		// Token: 0x04000194 RID: 404
		public const string ExternalStorageWrite = "android.permission.WRITE_EXTERNAL_STORAGE";
	}
}
