using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem.Data
{
	// Token: 0x0200000F RID: 15
	[Serializable]
	public class DuplicateNameException : DataException
	{
		// Token: 0x06000123 RID: 291 RVA: 0x0000CAF4 File Offset: 0x0000ACF4
		// Note: this type is marked as 'beforefieldinit'.
		static DuplicateNameException()
		{
			Il2CppClassPointerStore<DuplicateNameException>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Data.dll", "System.Data", "DuplicateNameException");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DuplicateNameException>.NativeClassPtr);
			DuplicateNameException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DuplicateNameException>.NativeClassPtr, 100663468);
			DuplicateNameException.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DuplicateNameException>.NativeClassPtr, 100663469);
			DuplicateNameException.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DuplicateNameException>.NativeClassPtr, 100663470);
		}

		// Token: 0x06000124 RID: 292 RVA: 0x0000CB60 File Offset: 0x0000AD60
		[CallerCount(21)]
		[CachedScanResults(RefRangeStart = 452004, RefRangeEnd = 452025, XrefRangeStart = 452004, XrefRangeEnd = 452025, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DuplicateNameException(SerializationInfo info, StreamingContext context)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DuplicateNameException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DuplicateNameException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000125 RID: 293 RVA: 0x0000CBC4 File Offset: 0x0000ADC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 888609, XrefRangeEnd = 888612, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DuplicateNameException()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DuplicateNameException>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DuplicateNameException.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000126 RID: 294 RVA: 0x0000CC00 File Offset: 0x0000AE00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 888612, XrefRangeEnd = 888613, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DuplicateNameException(string s)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DuplicateNameException>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DuplicateNameException.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000127 RID: 295 RVA: 0x0000263F File Offset: 0x0000083F
		public DuplicateNameException(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040000D9 RID: 217
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x040000DA RID: 218
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040000DB RID: 219
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;
	}
}
