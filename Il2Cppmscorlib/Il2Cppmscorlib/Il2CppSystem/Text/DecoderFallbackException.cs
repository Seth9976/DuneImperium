using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem.Text
{
	// Token: 0x020001F9 RID: 505
	[Serializable]
	public sealed class DecoderFallbackException : ArgumentException
	{
		// Token: 0x06002083 RID: 8323 RVA: 0x000BA094 File Offset: 0x000B8294
		// Note: this type is marked as 'beforefieldinit'.
		static DecoderFallbackException()
		{
			Il2CppClassPointerStore<DecoderFallbackException>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Text", "DecoderFallbackException");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DecoderFallbackException>.NativeClassPtr);
			DecoderFallbackException.NativeFieldInfoPtr__bytesUnknown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecoderFallbackException>.NativeClassPtr, "_bytesUnknown");
			DecoderFallbackException.NativeFieldInfoPtr__index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecoderFallbackException>.NativeClassPtr, "_index");
			DecoderFallbackException.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecoderFallbackException>.NativeClassPtr, 100668815);
			DecoderFallbackException.NativeMethodInfoPtr__ctor_Public_Void_String_Il2CppStructArray_1_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecoderFallbackException>.NativeClassPtr, 100668816);
			DecoderFallbackException.NativeMethodInfoPtr__ctor_Private_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecoderFallbackException>.NativeClassPtr, 100668817);
		}

		// Token: 0x06002084 RID: 8324 RVA: 0x000BA128 File Offset: 0x000B8328
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1362316, XrefRangeEnd = 1362319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DecoderFallbackException()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DecoderFallbackException>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecoderFallbackException.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002085 RID: 8325 RVA: 0x000BA164 File Offset: 0x000B8364
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1362321, RefRangeEnd = 1362322, XrefRangeStart = 1362319, XrefRangeEnd = 1362321, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DecoderFallbackException(string message, Il2CppStructArray<byte> bytesUnknown, int index)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DecoderFallbackException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(bytesUnknown);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecoderFallbackException.NativeMethodInfoPtr__ctor_Public_Void_String_Il2CppStructArray_1_Byte_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002086 RID: 8326 RVA: 0x000BA1D0 File Offset: 0x000B83D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DecoderFallbackException(SerializationInfo serializationInfo, StreamingContext streamingContext)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DecoderFallbackException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(serializationInfo);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(streamingContext));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecoderFallbackException.NativeMethodInfoPtr__ctor_Private_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002087 RID: 8327 RVA: 0x0000A857 File Offset: 0x00008A57
		public DecoderFallbackException(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700063A RID: 1594
		// (get) Token: 0x06002088 RID: 8328 RVA: 0x000BA234 File Offset: 0x000B8434
		// (set) Token: 0x06002089 RID: 8329 RVA: 0x0000A860 File Offset: 0x00008A60
		public unsafe Il2CppStructArray<byte> _bytesUnknown
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecoderFallbackException.NativeFieldInfoPtr__bytesUnknown);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecoderFallbackException.NativeFieldInfoPtr__bytesUnknown), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700063B RID: 1595
		// (get) Token: 0x0600208A RID: 8330 RVA: 0x000BA264 File Offset: 0x000B8464
		// (set) Token: 0x0600208B RID: 8331 RVA: 0x0000A87F File Offset: 0x00008A7F
		public unsafe int _index
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecoderFallbackException.NativeFieldInfoPtr__index);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecoderFallbackException.NativeFieldInfoPtr__index)) = value;
			}
		}

		// Token: 0x04001CEB RID: 7403
		private static readonly IntPtr NativeFieldInfoPtr__bytesUnknown;

		// Token: 0x04001CEC RID: 7404
		private static readonly IntPtr NativeFieldInfoPtr__index;

		// Token: 0x04001CED RID: 7405
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001CEE RID: 7406
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Il2CppStructArray_1_Byte_Int32_0;

		// Token: 0x04001CEF RID: 7407
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_SerializationInfo_StreamingContext_0;
	}
}
