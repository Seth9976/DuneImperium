using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem.Runtime
{
	// Token: 0x0200028C RID: 652
	[Serializable]
	public sealed class AmbiguousImplementationException : Exception
	{
		// Token: 0x06002A06 RID: 10758 RVA: 0x000E0058 File Offset: 0x000DE258
		// Note: this type is marked as 'beforefieldinit'.
		static AmbiguousImplementationException()
		{
			Il2CppClassPointerStore<AmbiguousImplementationException>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime", "AmbiguousImplementationException");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AmbiguousImplementationException>.NativeClassPtr);
			AmbiguousImplementationException.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AmbiguousImplementationException>.NativeClassPtr, 100670152);
			AmbiguousImplementationException.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AmbiguousImplementationException>.NativeClassPtr, 100670153);
			AmbiguousImplementationException.NativeMethodInfoPtr__ctor_Private_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AmbiguousImplementationException>.NativeClassPtr, 100670154);
		}

		// Token: 0x06002A07 RID: 10759 RVA: 0x000E00C4 File Offset: 0x000DE2C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1376753, XrefRangeEnd = 1376759, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AmbiguousImplementationException()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AmbiguousImplementationException>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AmbiguousImplementationException.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002A08 RID: 10760 RVA: 0x000E0100 File Offset: 0x000DE300
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1376759, XrefRangeEnd = 1376763, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AmbiguousImplementationException(string message)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AmbiguousImplementationException>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AmbiguousImplementationException.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002A09 RID: 10761 RVA: 0x000E014C File Offset: 0x000DE34C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1376763, XrefRangeEnd = 1376767, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AmbiguousImplementationException(SerializationInfo info, StreamingContext context)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AmbiguousImplementationException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AmbiguousImplementationException.NativeMethodInfoPtr__ctor_Private_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002A0A RID: 10762 RVA: 0x0000DF3D File Offset: 0x0000C13D
		public AmbiguousImplementationException(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040023D0 RID: 9168
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040023D1 RID: 9169
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x040023D2 RID: 9170
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_SerializationInfo_StreamingContext_0;
	}
}
