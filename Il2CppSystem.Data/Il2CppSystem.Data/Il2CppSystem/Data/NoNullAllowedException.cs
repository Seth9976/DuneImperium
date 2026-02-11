using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem.Data
{
	// Token: 0x02000012 RID: 18
	[Serializable]
	public class NoNullAllowedException : DataException
	{
		// Token: 0x06000132 RID: 306 RVA: 0x0000CEFC File Offset: 0x0000B0FC
		// Note: this type is marked as 'beforefieldinit'.
		static NoNullAllowedException()
		{
			Il2CppClassPointerStore<NoNullAllowedException>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Data.dll", "System.Data", "NoNullAllowedException");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NoNullAllowedException>.NativeClassPtr);
			NoNullAllowedException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoNullAllowedException>.NativeClassPtr, 100663477);
			NoNullAllowedException.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoNullAllowedException>.NativeClassPtr, 100663478);
			NoNullAllowedException.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoNullAllowedException>.NativeClassPtr, 100663479);
		}

		// Token: 0x06000133 RID: 307 RVA: 0x0000CF68 File Offset: 0x0000B168
		[CallerCount(21)]
		[CachedScanResults(RefRangeStart = 452004, RefRangeEnd = 452025, XrefRangeStart = 452004, XrefRangeEnd = 452025, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NoNullAllowedException(SerializationInfo info, StreamingContext context)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NoNullAllowedException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoNullAllowedException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000134 RID: 308 RVA: 0x0000CFCC File Offset: 0x0000B1CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 888621, XrefRangeEnd = 888624, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NoNullAllowedException()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NoNullAllowedException>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoNullAllowedException.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000135 RID: 309 RVA: 0x0000D008 File Offset: 0x0000B208
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 888624, XrefRangeEnd = 888625, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NoNullAllowedException(string s)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NoNullAllowedException>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoNullAllowedException.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000136 RID: 310 RVA: 0x0000265A File Offset: 0x0000085A
		public NoNullAllowedException(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040000E2 RID: 226
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x040000E3 RID: 227
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040000E4 RID: 228
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;
	}
}
