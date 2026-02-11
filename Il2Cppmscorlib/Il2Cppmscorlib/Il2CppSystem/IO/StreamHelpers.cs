using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.IO
{
	// Token: 0x0200052B RID: 1323
	public static class StreamHelpers : Object
	{
		// Token: 0x06005086 RID: 20614 RVA: 0x0001CC2E File Offset: 0x0001AE2E
		// Note: this type is marked as 'beforefieldinit'.
		static StreamHelpers()
		{
			Il2CppClassPointerStore<StreamHelpers>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.IO", "StreamHelpers");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StreamHelpers>.NativeClassPtr);
			StreamHelpers.NativeMethodInfoPtr_ValidateCopyToArgs_Public_Static_Void_Stream_Stream_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StreamHelpers>.NativeClassPtr, 100675472);
		}

		// Token: 0x06005087 RID: 20615 RVA: 0x00176C28 File Offset: 0x00174E28
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1428002, RefRangeEnd = 1428008, XrefRangeStart = 1428002, XrefRangeEnd = 1428002, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ValidateCopyToArgs(Stream source, Stream destination, int bufferSize)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(destination);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bufferSize;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StreamHelpers.NativeMethodInfoPtr_ValidateCopyToArgs_Public_Static_Void_Stream_Stream_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005088 RID: 20616 RVA: 0x0001CC67 File Offset: 0x0001AE67
		public StreamHelpers(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040041B7 RID: 16823
		private static readonly IntPtr NativeMethodInfoPtr_ValidateCopyToArgs_Public_Static_Void_Stream_Stream_Int32_0;
	}
}
