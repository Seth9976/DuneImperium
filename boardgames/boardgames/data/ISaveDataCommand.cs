using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace boardgames.data
{
	// Token: 0x02000142 RID: 322
	public class ISaveDataCommand : Il2CppObjectBase
	{
		// Token: 0x06001094 RID: 4244 RVA: 0x00009AD3 File Offset: 0x00007CD3
		// Note: this type is marked as 'beforefieldinit'.
		static ISaveDataCommand()
		{
			Il2CppClassPointerStore<ISaveDataCommand>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "boardgames.data", "ISaveDataCommand");
			ISaveDataCommand.NativeMethodInfoPtr_Create_Public_Static_ISaveDataCommand_Object_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISaveDataCommand>.NativeClassPtr, 100665724);
		}

		// Token: 0x06001095 RID: 4245 RVA: 0x00044094 File Offset: 0x00042294
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 999401, RefRangeEnd = 999403, XrefRangeStart = 999383, XrefRangeEnd = 999401, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ISaveDataCommand Create(Object data, string path, bool threaded = false)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(path);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref threaded;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISaveDataCommand.NativeMethodInfoPtr_Create_Public_Static_ISaveDataCommand_Object_String_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ISaveDataCommand>(intPtr3) : null;
		}

		// Token: 0x06001096 RID: 4246 RVA: 0x00009B02 File Offset: 0x00007D02
		public ISaveDataCommand(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000A1D RID: 2589
		private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Static_ISaveDataCommand_Object_String_Boolean_0;
	}
}
