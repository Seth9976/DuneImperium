using System;
using Il2CppSystem;

namespace UnityEngine.Windows
{
	// Token: 0x02000316 RID: 790
	public static class Input
	{
		// Token: 0x06002DF4 RID: 11764 RVA: 0x00012539 File Offset: 0x00010739
		public unsafe static void ForwardRawInput(IntPtr rawInputHeaderIndices, IntPtr rawInputDataIndices, uint indicesCount, IntPtr rawInputData, uint rawInputDataSize)
		{
			Input.ForwardRawInput((uint*)(void*)rawInputHeaderIndices, (uint*)(void*)rawInputDataIndices, indicesCount, (byte*)(void*)rawInputData, rawInputDataSize);
		}

		// Token: 0x06002DF5 RID: 11765 RVA: 0x00012559 File Offset: 0x00010759
		public unsafe static void ForwardRawInput(uint* rawInputHeaderIndices, uint* rawInputDataIndices, uint indicesCount, byte* rawInputData, uint rawInputDataSize)
		{
			throw new NotSupportedException();
		}
	}
}
