using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem.IO
{
	// Token: 0x02000184 RID: 388
	[Serializable]
	public sealed class InvalidDataException : SystemException
	{
		// Token: 0x060017B4 RID: 6068 RVA: 0x000789A8 File Offset: 0x00076BA8
		// Note: this type is marked as 'beforefieldinit'.
		static InvalidDataException()
		{
			Il2CppClassPointerStore<InvalidDataException>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.IO", "InvalidDataException");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InvalidDataException>.NativeClassPtr);
			InvalidDataException.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InvalidDataException>.NativeClassPtr, 100667023);
			InvalidDataException.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InvalidDataException>.NativeClassPtr, 100667024);
			InvalidDataException.NativeMethodInfoPtr__ctor_Private_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InvalidDataException>.NativeClassPtr, 100667025);
		}

		// Token: 0x060017B5 RID: 6069 RVA: 0x00078A14 File Offset: 0x00076C14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 470035, XrefRangeEnd = 470039, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InvalidDataException()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InvalidDataException>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InvalidDataException.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060017B6 RID: 6070 RVA: 0x00078A50 File Offset: 0x00076C50
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 470040, RefRangeEnd = 470041, XrefRangeStart = 470039, XrefRangeEnd = 470040, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InvalidDataException(string message)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InvalidDataException>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InvalidDataException.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060017B7 RID: 6071 RVA: 0x00078A9C File Offset: 0x00076C9C
		[CallerCount(21)]
		[CachedScanResults(RefRangeStart = 452004, RefRangeEnd = 452025, XrefRangeStart = 452004, XrefRangeEnd = 452025, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InvalidDataException(SerializationInfo info, StreamingContext context)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InvalidDataException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InvalidDataException.NativeMethodInfoPtr__ctor_Private_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060017B8 RID: 6072 RVA: 0x0000A4B7 File Offset: 0x000086B7
		public InvalidDataException(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001262 RID: 4706
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001263 RID: 4707
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x04001264 RID: 4708
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_SerializationInfo_StreamingContext_0;
	}
}
