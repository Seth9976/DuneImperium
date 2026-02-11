using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem.Data
{
	// Token: 0x02000015 RID: 21
	[Serializable]
	public class VersionNotFoundException : DataException
	{
		// Token: 0x06000141 RID: 321 RVA: 0x0000D304 File Offset: 0x0000B504
		// Note: this type is marked as 'beforefieldinit'.
		static VersionNotFoundException()
		{
			Il2CppClassPointerStore<VersionNotFoundException>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Data.dll", "System.Data", "VersionNotFoundException");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VersionNotFoundException>.NativeClassPtr);
			VersionNotFoundException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VersionNotFoundException>.NativeClassPtr, 100663486);
			VersionNotFoundException.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VersionNotFoundException>.NativeClassPtr, 100663487);
			VersionNotFoundException.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VersionNotFoundException>.NativeClassPtr, 100663488);
		}

		// Token: 0x06000142 RID: 322 RVA: 0x0000D370 File Offset: 0x0000B570
		[CallerCount(21)]
		[CachedScanResults(RefRangeStart = 452004, RefRangeEnd = 452025, XrefRangeStart = 452004, XrefRangeEnd = 452025, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VersionNotFoundException(SerializationInfo info, StreamingContext context)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VersionNotFoundException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VersionNotFoundException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000143 RID: 323 RVA: 0x0000D3D4 File Offset: 0x0000B5D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 888633, XrefRangeEnd = 888636, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VersionNotFoundException()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VersionNotFoundException>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VersionNotFoundException.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000144 RID: 324 RVA: 0x0000D410 File Offset: 0x0000B610
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 888636, XrefRangeEnd = 888637, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VersionNotFoundException(string s)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VersionNotFoundException>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VersionNotFoundException.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000145 RID: 325 RVA: 0x00002675 File Offset: 0x00000875
		public VersionNotFoundException(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040000EB RID: 235
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x040000EC RID: 236
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040000ED RID: 237
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;
	}
}
