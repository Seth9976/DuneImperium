using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

namespace boardgames.data
{
	// Token: 0x02000140 RID: 320
	public class IDeleteDataCommand : Il2CppObjectBase
	{
		// Token: 0x0600108D RID: 4237 RVA: 0x00009A92 File Offset: 0x00007C92
		// Note: this type is marked as 'beforefieldinit'.
		static IDeleteDataCommand()
		{
			Il2CppClassPointerStore<IDeleteDataCommand>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "boardgames.data", "IDeleteDataCommand");
			IDeleteDataCommand.NativeMethodInfoPtr_Create_Public_Static_IDeleteDataCommand_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDeleteDataCommand>.NativeClassPtr, 100665721);
		}

		// Token: 0x0600108E RID: 4238 RVA: 0x00043F64 File Offset: 0x00042164
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 999359, RefRangeEnd = 999361, XrefRangeStart = 999344, XrefRangeEnd = 999359, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IDeleteDataCommand Create(string path)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IDeleteDataCommand.NativeMethodInfoPtr_Create_Public_Static_IDeleteDataCommand_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IDeleteDataCommand>(intPtr3) : null;
			}
		}

		// Token: 0x0600108F RID: 4239 RVA: 0x00009AC1 File Offset: 0x00007CC1
		public IDeleteDataCommand(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000A1A RID: 2586
		private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Static_IDeleteDataCommand_String_0;
	}
}
