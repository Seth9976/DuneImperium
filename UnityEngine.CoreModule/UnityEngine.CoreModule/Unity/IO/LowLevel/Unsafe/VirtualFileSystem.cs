using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;

namespace Unity.IO.LowLevel.Unsafe
{
	// Token: 0x020002A2 RID: 674
	public static class VirtualFileSystem
	{
		// Token: 0x06002CBD RID: 11453 RVA: 0x000B2B88 File Offset: 0x000B0D88
		public unsafe static bool GetLocalFileSystemName(string vfsFileName, out string localFileName, out ulong localFileOffset, out ulong localFileSize)
		{
			VirtualFileSystem.GetLocalFileSystemNameDelegate getLocalFileSystemNameDelegateField = VirtualFileSystem.GetLocalFileSystemNameDelegateField;
			IntPtr intPtr = IL2CPP.ManagedStringToIl2Cpp(vfsFileName);
			IntPtr intPtr2 = IL2CPP.ManagedStringToIl2Cpp(localFileName);
			return getLocalFileSystemNameDelegateField(intPtr, &intPtr2, out localFileOffset, out localFileSize);
		}

		// Token: 0x06002CBE RID: 11454 RVA: 0x000B2BB4 File Offset: 0x000B0DB4
		public static string ToLogicalPath(string physicalPath)
		{
			IntPtr intPtr = VirtualFileSystem.ToLogicalPathDelegateField(IL2CPP.ManagedStringToIl2Cpp(physicalPath));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0400280C RID: 10252
		private static readonly VirtualFileSystem.GetLocalFileSystemNameDelegate GetLocalFileSystemNameDelegateField = IL2CPP.ResolveICall<VirtualFileSystem.GetLocalFileSystemNameDelegate>("Unity.IO.LowLevel.Unsafe.VirtualFileSystem::GetLocalFileSystemName");

		// Token: 0x0400280D RID: 10253
		private static readonly VirtualFileSystem.ToLogicalPathDelegate ToLogicalPathDelegateField = IL2CPP.ResolveICall<VirtualFileSystem.ToLogicalPathDelegate>("Unity.IO.LowLevel.Unsafe.VirtualFileSystem::ToLogicalPath");

		// Token: 0x02000AE0 RID: 2784
		// (Invoke) Token: 0x06003EB7 RID: 16055
		private delegate bool GetLocalFileSystemNameDelegate(IntPtr vfsFileName, [Out] IntPtr localFileName, [Out] IntPtr localFileOffset, [Out] IntPtr localFileSize);

		// Token: 0x02000AE1 RID: 2785
		// (Invoke) Token: 0x06003EB9 RID: 16057
		private delegate IntPtr ToLogicalPathDelegate(IntPtr physicalPath);
	}
}
