using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Unity.Jobs;

namespace Unity.IO.LowLevel.Unsafe
{
	// Token: 0x0200029F RID: 671
	public static class AsyncReadManager
	{
		// Token: 0x06002C89 RID: 11401 RVA: 0x000B27D0 File Offset: 0x000B09D0
		public static Unity.Jobs.JobHandle CloseCachedFileAsync(string fileName, [Optional] Unity.Jobs.JobHandle dependency)
		{
			Unity.Jobs.JobHandle jobHandle;
			AsyncReadManager.CloseCachedFileAsync_Injected(fileName, ref dependency, out jobHandle);
			return jobHandle;
		}

		// Token: 0x06002C8A RID: 11402 RVA: 0x00011537 File Offset: 0x0000F737
		public static void CloseCachedFileAsync_Injected(string fileName, [Optional] ref Unity.Jobs.JobHandle dependency, out Unity.Jobs.JobHandle ret)
		{
			AsyncReadManager.CloseCachedFileAsync_InjectedDelegateField(IL2CPP.ManagedStringToIl2Cpp(fileName), ref dependency, out ret);
		}

		// Token: 0x040027FC RID: 10236
		private static readonly AsyncReadManager.CloseCachedFileAsync_InjectedDelegate CloseCachedFileAsync_InjectedDelegateField = IL2CPP.ResolveICall<AsyncReadManager.CloseCachedFileAsync_InjectedDelegate>("Unity.IO.LowLevel.Unsafe.AsyncReadManager::CloseCachedFileAsync_Injected");

		// Token: 0x02000ACF RID: 2767
		// (Invoke) Token: 0x06003E97 RID: 16023
		private delegate void CloseCachedFileAsync_InjectedDelegate(IntPtr fileName, IntPtr dependency, [Out] IntPtr ret);
	}
}
