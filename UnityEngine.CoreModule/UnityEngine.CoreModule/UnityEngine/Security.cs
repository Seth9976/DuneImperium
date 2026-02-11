using System;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Reflection;

namespace UnityEngine
{
	// Token: 0x02000304 RID: 772
	public sealed class Security
	{
		// Token: 0x06002DA2 RID: 11682 RVA: 0x000B3BBC File Offset: 0x000B1DBC
		public static Assembly LoadAndVerifyAssembly(Il2CppStructArray<byte> assemblyData, string authorizationKey)
		{
			return null;
		}

		// Token: 0x06002DA3 RID: 11683 RVA: 0x000B3BD0 File Offset: 0x000B1DD0
		public static Assembly LoadAndVerifyAssembly(Il2CppStructArray<byte> assemblyData)
		{
			return null;
		}

		// Token: 0x06002DA4 RID: 11684 RVA: 0x000B3BE4 File Offset: 0x000B1DE4
		public static bool PrefetchSocketPolicy(string ip, int atPort)
		{
			int num = 3000;
			return Security.PrefetchSocketPolicy(ip, atPort, num);
		}

		// Token: 0x06002DA5 RID: 11685 RVA: 0x000B3C04 File Offset: 0x000B1E04
		public static bool PrefetchSocketPolicy(string ip, int atPort, int timeout)
		{
			return false;
		}
	}
}
