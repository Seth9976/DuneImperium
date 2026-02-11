using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem.Data
{
	// Token: 0x0200000E RID: 14
	[Serializable]
	public class DeletedRowInaccessibleException : DataException
	{
		// Token: 0x0600011E RID: 286 RVA: 0x0000C99C File Offset: 0x0000AB9C
		// Note: this type is marked as 'beforefieldinit'.
		static DeletedRowInaccessibleException()
		{
			Il2CppClassPointerStore<DeletedRowInaccessibleException>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Data.dll", "System.Data", "DeletedRowInaccessibleException");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DeletedRowInaccessibleException>.NativeClassPtr);
			DeletedRowInaccessibleException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeletedRowInaccessibleException>.NativeClassPtr, 100663465);
			DeletedRowInaccessibleException.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeletedRowInaccessibleException>.NativeClassPtr, 100663466);
			DeletedRowInaccessibleException.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeletedRowInaccessibleException>.NativeClassPtr, 100663467);
		}

		// Token: 0x0600011F RID: 287 RVA: 0x0000CA08 File Offset: 0x0000AC08
		[CallerCount(21)]
		[CachedScanResults(RefRangeStart = 452004, RefRangeEnd = 452025, XrefRangeStart = 452004, XrefRangeEnd = 452025, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DeletedRowInaccessibleException(SerializationInfo info, StreamingContext context)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DeletedRowInaccessibleException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeletedRowInaccessibleException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000120 RID: 288 RVA: 0x0000CA6C File Offset: 0x0000AC6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 888605, XrefRangeEnd = 888608, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DeletedRowInaccessibleException()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DeletedRowInaccessibleException>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeletedRowInaccessibleException.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000121 RID: 289 RVA: 0x0000CAA8 File Offset: 0x0000ACA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 888608, XrefRangeEnd = 888609, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DeletedRowInaccessibleException(string s)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DeletedRowInaccessibleException>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeletedRowInaccessibleException.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000122 RID: 290 RVA: 0x00002636 File Offset: 0x00000836
		public DeletedRowInaccessibleException(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040000D6 RID: 214
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x040000D7 RID: 215
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040000D8 RID: 216
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;
	}
}
