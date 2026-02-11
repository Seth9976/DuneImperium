using System;
using Il2CppInterop.Runtime;

namespace UnityEngine.Networking
{
	// Token: 0x02000011 RID: 17
	public sealed class UploadHandlerFile : UploadHandler
	{
		// Token: 0x06000169 RID: 361 RVA: 0x00002720 File Offset: 0x00000920
		public static IntPtr Create(UploadHandlerFile self, string filePath)
		{
			return UploadHandlerFile.CreateDelegateField(IL2CPP.Il2CppObjectBaseToPtr(self), IL2CPP.ManagedStringToIl2Cpp(filePath));
		}

		// Token: 0x040000D6 RID: 214
		private static readonly UploadHandlerFile.CreateDelegate CreateDelegateField = IL2CPP.ResolveICall<UploadHandlerFile.CreateDelegate>("UnityEngine.Networking.UploadHandlerFile::Create");

		// Token: 0x02000027 RID: 39
		// (Invoke) Token: 0x0600018E RID: 398
		private delegate IntPtr CreateDelegate(IntPtr self, IntPtr filePath);
	}
}
