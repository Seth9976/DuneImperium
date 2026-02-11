using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem.Resources
{
	// Token: 0x020003E3 RID: 995
	[Serializable]
	public class MissingManifestResourceException : SystemException
	{
		// Token: 0x06003A5E RID: 14942 RVA: 0x001196CC File Offset: 0x001178CC
		// Note: this type is marked as 'beforefieldinit'.
		static MissingManifestResourceException()
		{
			Il2CppClassPointerStore<MissingManifestResourceException>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Resources", "MissingManifestResourceException");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MissingManifestResourceException>.NativeClassPtr);
			MissingManifestResourceException.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MissingManifestResourceException>.NativeClassPtr, 100672015);
			MissingManifestResourceException.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MissingManifestResourceException>.NativeClassPtr, 100672016);
			MissingManifestResourceException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MissingManifestResourceException>.NativeClassPtr, 100672017);
		}

		// Token: 0x06003A5F RID: 14943 RVA: 0x00119738 File Offset: 0x00117938
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1396460, XrefRangeEnd = 1396463, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MissingManifestResourceException()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MissingManifestResourceException>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MissingManifestResourceException.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003A60 RID: 14944 RVA: 0x00119774 File Offset: 0x00117974
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1396464, RefRangeEnd = 1396465, XrefRangeStart = 1396463, XrefRangeEnd = 1396464, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MissingManifestResourceException(string message)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MissingManifestResourceException>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MissingManifestResourceException.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003A61 RID: 14945 RVA: 0x001197C0 File Offset: 0x001179C0
		[CallerCount(21)]
		[CachedScanResults(RefRangeStart = 452004, RefRangeEnd = 452025, XrefRangeStart = 452004, XrefRangeEnd = 452025, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MissingManifestResourceException(SerializationInfo info, StreamingContext context)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MissingManifestResourceException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MissingManifestResourceException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003A62 RID: 14946 RVA: 0x00015ACC File Offset: 0x00013CCC
		public MissingManifestResourceException(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04002F41 RID: 12097
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04002F42 RID: 12098
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x04002F43 RID: 12099
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0;
	}
}
