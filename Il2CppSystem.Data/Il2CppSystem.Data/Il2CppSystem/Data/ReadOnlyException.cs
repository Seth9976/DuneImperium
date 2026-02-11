using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem.Data
{
	// Token: 0x02000013 RID: 19
	[Serializable]
	public class ReadOnlyException : DataException
	{
		// Token: 0x06000137 RID: 311 RVA: 0x0000D054 File Offset: 0x0000B254
		// Note: this type is marked as 'beforefieldinit'.
		static ReadOnlyException()
		{
			Il2CppClassPointerStore<ReadOnlyException>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Data.dll", "System.Data", "ReadOnlyException");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReadOnlyException>.NativeClassPtr);
			ReadOnlyException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadOnlyException>.NativeClassPtr, 100663480);
			ReadOnlyException.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadOnlyException>.NativeClassPtr, 100663481);
			ReadOnlyException.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadOnlyException>.NativeClassPtr, 100663482);
		}

		// Token: 0x06000138 RID: 312 RVA: 0x0000D0C0 File Offset: 0x0000B2C0
		[CallerCount(21)]
		[CachedScanResults(RefRangeStart = 452004, RefRangeEnd = 452025, XrefRangeStart = 452004, XrefRangeEnd = 452025, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ReadOnlyException(SerializationInfo info, StreamingContext context)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReadOnlyException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadOnlyException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000139 RID: 313 RVA: 0x0000D124 File Offset: 0x0000B324
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 888625, XrefRangeEnd = 888628, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ReadOnlyException()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReadOnlyException>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadOnlyException.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600013A RID: 314 RVA: 0x0000D160 File Offset: 0x0000B360
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 888628, XrefRangeEnd = 888629, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ReadOnlyException(string s)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReadOnlyException>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadOnlyException.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600013B RID: 315 RVA: 0x00002663 File Offset: 0x00000863
		public ReadOnlyException(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040000E5 RID: 229
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x040000E6 RID: 230
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040000E7 RID: 231
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;
	}
}
