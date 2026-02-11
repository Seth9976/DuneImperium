using System;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Unity.Jobs
{
	// Token: 0x02000297 RID: 663
	public static class JobValidationInternal
	{
		// Token: 0x06002C85 RID: 11397 RVA: 0x00011523 File Offset: 0x0000F723
		public static void CheckReflectionDataCorrect<T>(IntPtr reflectionData)
		{
		}

		// Token: 0x06002C86 RID: 11398 RVA: 0x000B2778 File Offset: 0x000B0978
		public static void CheckReflectionDataCorrectInternal<T>(IntPtr reflectionData, ref bool burstCompiled)
		{
			bool flag = reflectionData == IntPtr.Zero;
			if (flag)
			{
				throw new InvalidOperationException(String.Format("Reflection data was not set up by an Initialize() call. Support for burst compiled calls to Schedule depends on the Collections package.\n\nFor generic job types, please include [assembly: RegisterGenericJobType(typeof({0}))] in your source file.", Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<T>())));
			}
			burstCompiled = false;
		}
	}
}
