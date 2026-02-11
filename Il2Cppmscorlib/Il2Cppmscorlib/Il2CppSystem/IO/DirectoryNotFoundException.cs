using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem.IO
{
	// Token: 0x0200051C RID: 1308
	[Serializable]
	public class DirectoryNotFoundException : IOException
	{
		// Token: 0x06004FE8 RID: 20456 RVA: 0x00173E88 File Offset: 0x00172088
		// Note: this type is marked as 'beforefieldinit'.
		static DirectoryNotFoundException()
		{
			Il2CppClassPointerStore<DirectoryNotFoundException>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.IO", "DirectoryNotFoundException");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DirectoryNotFoundException>.NativeClassPtr);
			DirectoryNotFoundException.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DirectoryNotFoundException>.NativeClassPtr, 100675367);
			DirectoryNotFoundException.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DirectoryNotFoundException>.NativeClassPtr, 100675368);
			DirectoryNotFoundException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DirectoryNotFoundException>.NativeClassPtr, 100675369);
		}

		// Token: 0x06004FE9 RID: 20457 RVA: 0x00173EF4 File Offset: 0x001720F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1427194, XrefRangeEnd = 1427197, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DirectoryNotFoundException()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DirectoryNotFoundException>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DirectoryNotFoundException.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004FEA RID: 20458 RVA: 0x00173F30 File Offset: 0x00172130
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1427198, RefRangeEnd = 1427201, XrefRangeStart = 1427197, XrefRangeEnd = 1427198, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DirectoryNotFoundException(string message)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DirectoryNotFoundException>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DirectoryNotFoundException.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004FEB RID: 20459 RVA: 0x00173F7C File Offset: 0x0017217C
		[CallerCount(21)]
		[CachedScanResults(RefRangeStart = 452004, RefRangeEnd = 452025, XrefRangeStart = 452004, XrefRangeEnd = 452025, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DirectoryNotFoundException(SerializationInfo info, StreamingContext context)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DirectoryNotFoundException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DirectoryNotFoundException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004FEC RID: 20460 RVA: 0x0001C9FA File Offset: 0x0001ABFA
		public DirectoryNotFoundException(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04004120 RID: 16672
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04004121 RID: 16673
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x04004122 RID: 16674
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0;
	}
}
