using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Text;

namespace Il2CppSystem.Net.Http
{
	// Token: 0x02000016 RID: 22
	public class StringContent : ByteArrayContent
	{
		// Token: 0x0600015E RID: 350 RVA: 0x0000965C File Offset: 0x0000785C
		// Note: this type is marked as 'beforefieldinit'.
		static StringContent()
		{
			Il2CppClassPointerStore<StringContent>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Net.Http.dll", "System.Net.Http", "StringContent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StringContent>.NativeClassPtr);
			StringContent.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringContent>.NativeClassPtr, 100663492);
			StringContent.NativeMethodInfoPtr__ctor_Public_Void_String_Encoding_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringContent>.NativeClassPtr, 100663493);
			StringContent.NativeMethodInfoPtr_GetByteArray_Private_Static_Il2CppStructArray_1_Byte_String_Encoding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringContent>.NativeClassPtr, 100663494);
		}

		// Token: 0x0600015F RID: 351 RVA: 0x000096C8 File Offset: 0x000078C8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1172408, RefRangeEnd = 1172410, XrefRangeStart = 1172407, XrefRangeEnd = 1172408, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StringContent(string content)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StringContent>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(content);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringContent.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000160 RID: 352 RVA: 0x00009714 File Offset: 0x00007914
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1172435, RefRangeEnd = 1172439, XrefRangeStart = 1172410, XrefRangeEnd = 1172435, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StringContent(string content, Encoding encoding, string mediaType)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StringContent>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(content);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(encoding);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(mediaType);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringContent.NativeMethodInfoPtr__ctor_Public_Void_String_Encoding_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000161 RID: 353 RVA: 0x00009784 File Offset: 0x00007984
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1172439, XrefRangeEnd = 1172441, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<byte> GetByteArray(string content, Encoding encoding)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(content);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(encoding);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringContent.NativeMethodInfoPtr_GetByteArray_Private_Static_Il2CppStructArray_1_Byte_String_Encoding_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
		}

		// Token: 0x06000162 RID: 354 RVA: 0x00002928 File Offset: 0x00000B28
		public StringContent(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040000F5 RID: 245
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x040000F6 RID: 246
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Encoding_String_0;

		// Token: 0x040000F7 RID: 247
		private static readonly IntPtr NativeMethodInfoPtr_GetByteArray_Private_Static_Il2CppStructArray_1_Byte_String_Encoding_0;
	}
}
