using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem.Text
{
	// Token: 0x02000204 RID: 516
	[Serializable]
	public sealed class EncoderFallbackException : ArgumentException
	{
		// Token: 0x06002119 RID: 8473 RVA: 0x000BCA00 File Offset: 0x000BAC00
		// Note: this type is marked as 'beforefieldinit'.
		static EncoderFallbackException()
		{
			Il2CppClassPointerStore<EncoderFallbackException>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Text", "EncoderFallbackException");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EncoderFallbackException>.NativeClassPtr);
			EncoderFallbackException.NativeFieldInfoPtr__charUnknown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EncoderFallbackException>.NativeClassPtr, "_charUnknown");
			EncoderFallbackException.NativeFieldInfoPtr__charUnknownHigh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EncoderFallbackException>.NativeClassPtr, "_charUnknownHigh");
			EncoderFallbackException.NativeFieldInfoPtr__charUnknownLow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EncoderFallbackException>.NativeClassPtr, "_charUnknownLow");
			EncoderFallbackException.NativeFieldInfoPtr__index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EncoderFallbackException>.NativeClassPtr, "_index");
			EncoderFallbackException.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EncoderFallbackException>.NativeClassPtr, 100668897);
			EncoderFallbackException.NativeMethodInfoPtr__ctor_Internal_Void_String_Char_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EncoderFallbackException>.NativeClassPtr, 100668898);
			EncoderFallbackException.NativeMethodInfoPtr__ctor_Internal_Void_String_Char_Char_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EncoderFallbackException>.NativeClassPtr, 100668899);
			EncoderFallbackException.NativeMethodInfoPtr__ctor_Private_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EncoderFallbackException>.NativeClassPtr, 100668900);
		}

		// Token: 0x0600211A RID: 8474 RVA: 0x000BCAD0 File Offset: 0x000BACD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1362757, XrefRangeEnd = 1362760, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EncoderFallbackException()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EncoderFallbackException>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EncoderFallbackException.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600211B RID: 8475 RVA: 0x000BCB0C File Offset: 0x000BAD0C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1362761, RefRangeEnd = 1362762, XrefRangeStart = 1362760, XrefRangeEnd = 1362761, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EncoderFallbackException(string message, char charUnknown, int index)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EncoderFallbackException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref charUnknown;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EncoderFallbackException.NativeMethodInfoPtr__ctor_Internal_Void_String_Char_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600211C RID: 8476 RVA: 0x000BCB74 File Offset: 0x000BAD74
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1362770, RefRangeEnd = 1362771, XrefRangeStart = 1362762, XrefRangeEnd = 1362770, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EncoderFallbackException(string message, char charUnknownHigh, char charUnknownLow, int index)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EncoderFallbackException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref charUnknownHigh;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref charUnknownLow;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EncoderFallbackException.NativeMethodInfoPtr__ctor_Internal_Void_String_Char_Char_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600211D RID: 8477 RVA: 0x000BCBEC File Offset: 0x000BADEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EncoderFallbackException(SerializationInfo serializationInfo, StreamingContext streamingContext)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EncoderFallbackException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(serializationInfo);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(streamingContext));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EncoderFallbackException.NativeMethodInfoPtr__ctor_Private_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600211E RID: 8478 RVA: 0x0000AB30 File Offset: 0x00008D30
		public EncoderFallbackException(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000662 RID: 1634
		// (get) Token: 0x0600211F RID: 8479 RVA: 0x000BCC50 File Offset: 0x000BAE50
		// (set) Token: 0x06002120 RID: 8480 RVA: 0x0000AB39 File Offset: 0x00008D39
		public unsafe char _charUnknown
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EncoderFallbackException.NativeFieldInfoPtr__charUnknown);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EncoderFallbackException.NativeFieldInfoPtr__charUnknown)) = value;
			}
		}

		// Token: 0x17000663 RID: 1635
		// (get) Token: 0x06002121 RID: 8481 RVA: 0x000BCC78 File Offset: 0x000BAE78
		// (set) Token: 0x06002122 RID: 8482 RVA: 0x0000AB54 File Offset: 0x00008D54
		public unsafe char _charUnknownHigh
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EncoderFallbackException.NativeFieldInfoPtr__charUnknownHigh);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EncoderFallbackException.NativeFieldInfoPtr__charUnknownHigh)) = value;
			}
		}

		// Token: 0x17000664 RID: 1636
		// (get) Token: 0x06002123 RID: 8483 RVA: 0x000BCCA0 File Offset: 0x000BAEA0
		// (set) Token: 0x06002124 RID: 8484 RVA: 0x0000AB6F File Offset: 0x00008D6F
		public unsafe char _charUnknownLow
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EncoderFallbackException.NativeFieldInfoPtr__charUnknownLow);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EncoderFallbackException.NativeFieldInfoPtr__charUnknownLow)) = value;
			}
		}

		// Token: 0x17000665 RID: 1637
		// (get) Token: 0x06002125 RID: 8485 RVA: 0x000BCCC8 File Offset: 0x000BAEC8
		// (set) Token: 0x06002126 RID: 8486 RVA: 0x0000AB8A File Offset: 0x00008D8A
		public unsafe int _index
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EncoderFallbackException.NativeFieldInfoPtr__index);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EncoderFallbackException.NativeFieldInfoPtr__index)) = value;
			}
		}

		// Token: 0x04001D54 RID: 7508
		private static readonly IntPtr NativeFieldInfoPtr__charUnknown;

		// Token: 0x04001D55 RID: 7509
		private static readonly IntPtr NativeFieldInfoPtr__charUnknownHigh;

		// Token: 0x04001D56 RID: 7510
		private static readonly IntPtr NativeFieldInfoPtr__charUnknownLow;

		// Token: 0x04001D57 RID: 7511
		private static readonly IntPtr NativeFieldInfoPtr__index;

		// Token: 0x04001D58 RID: 7512
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001D59 RID: 7513
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_String_Char_Int32_0;

		// Token: 0x04001D5A RID: 7514
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_String_Char_Char_Int32_0;

		// Token: 0x04001D5B RID: 7515
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_SerializationInfo_StreamingContext_0;
	}
}
