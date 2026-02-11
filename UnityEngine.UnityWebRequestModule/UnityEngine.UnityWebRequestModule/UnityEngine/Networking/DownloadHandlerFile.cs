using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using Il2CppSystem.IO;
using Unity.Collections;

namespace UnityEngine.Networking
{
	// Token: 0x0200000D RID: 13
	public sealed class DownloadHandlerFile : DownloadHandler
	{
		// Token: 0x06000158 RID: 344 RVA: 0x00002642 File Offset: 0x00000842
		public static IntPtr Create(DownloadHandlerFile obj, string path, bool append)
		{
			return DownloadHandlerFile.CreateDelegateField(IL2CPP.Il2CppObjectBaseToPtr(obj), IL2CPP.ManagedStringToIl2Cpp(path), append);
		}

		// Token: 0x06000159 RID: 345 RVA: 0x000075C4 File Offset: 0x000057C4
		public void InternalCreateVFS(string path, bool append)
		{
			string directoryName = Path.GetDirectoryName(path);
			bool flag = !Directory.Exists(directoryName);
			if (flag)
			{
				Directory.CreateDirectory(directoryName);
			}
			base.m_Ptr = DownloadHandlerFile.Create(this, path, append);
		}

		// Token: 0x0600015A RID: 346 RVA: 0x0000265B File Offset: 0x0000085B
		public override NativeArray<byte> GetNativeData()
		{
			throw new NotSupportedException("Raw data access is not supported");
		}

		// Token: 0x0600015B RID: 347 RVA: 0x00002668 File Offset: 0x00000868
		public override Il2CppStructArray<byte> GetData()
		{
			throw new NotSupportedException("Raw data access is not supported");
		}

		// Token: 0x0600015C RID: 348 RVA: 0x00002675 File Offset: 0x00000875
		public override string GetText()
		{
			throw new NotSupportedException("String access is not supported");
		}

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x0600015D RID: 349 RVA: 0x00002682 File Offset: 0x00000882
		// (set) Token: 0x0600015E RID: 350 RVA: 0x00002694 File Offset: 0x00000894
		public bool removeFileOnAbort
		{
			get
			{
				return DownloadHandlerFile.get_removeFileOnAbortDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				DownloadHandlerFile.set_removeFileOnAbortDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x040000D3 RID: 211
		private static readonly DownloadHandlerFile.CreateDelegate CreateDelegateField = IL2CPP.ResolveICall<DownloadHandlerFile.CreateDelegate>("UnityEngine.Networking.DownloadHandlerFile::Create");

		// Token: 0x040000D4 RID: 212
		private static readonly DownloadHandlerFile.get_removeFileOnAbortDelegate get_removeFileOnAbortDelegateField = IL2CPP.ResolveICall<DownloadHandlerFile.get_removeFileOnAbortDelegate>("UnityEngine.Networking.DownloadHandlerFile::get_removeFileOnAbort");

		// Token: 0x040000D5 RID: 213
		private static readonly DownloadHandlerFile.set_removeFileOnAbortDelegate set_removeFileOnAbortDelegateField = IL2CPP.ResolveICall<DownloadHandlerFile.set_removeFileOnAbortDelegate>("UnityEngine.Networking.DownloadHandlerFile::set_removeFileOnAbort");

		// Token: 0x02000024 RID: 36
		// (Invoke) Token: 0x06000188 RID: 392
		private delegate IntPtr CreateDelegate(IntPtr obj, IntPtr path, bool append);

		// Token: 0x02000025 RID: 37
		// (Invoke) Token: 0x0600018A RID: 394
		private delegate bool get_removeFileOnAbortDelegate(IntPtr @this);

		// Token: 0x02000026 RID: 38
		// (Invoke) Token: 0x0600018C RID: 396
		private delegate void set_removeFileOnAbortDelegate(IntPtr @this, bool value);
	}
}
