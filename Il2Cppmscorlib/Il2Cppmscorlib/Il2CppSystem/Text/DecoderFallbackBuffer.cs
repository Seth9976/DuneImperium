using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;

namespace Il2CppSystem.Text
{
	// Token: 0x020001FB RID: 507
	public class DecoderFallbackBuffer : Object
	{
		// Token: 0x06002097 RID: 8343 RVA: 0x000BA4D0 File Offset: 0x000B86D0
		// Note: this type is marked as 'beforefieldinit'.
		static DecoderFallbackBuffer()
		{
			Il2CppClassPointerStore<DecoderFallbackBuffer>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Text", "DecoderFallbackBuffer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DecoderFallbackBuffer>.NativeClassPtr);
			DecoderFallbackBuffer.NativeFieldInfoPtr_byteStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecoderFallbackBuffer>.NativeClassPtr, "byteStart");
			DecoderFallbackBuffer.NativeFieldInfoPtr_charEnd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecoderFallbackBuffer>.NativeClassPtr, "charEnd");
			DecoderFallbackBuffer.NativeMethodInfoPtr_Fallback_Public_Abstract_Virtual_New_Boolean_Il2CppStructArray_1_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecoderFallbackBuffer>.NativeClassPtr, 100668823);
			DecoderFallbackBuffer.NativeMethodInfoPtr_GetNextChar_Public_Abstract_Virtual_New_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecoderFallbackBuffer>.NativeClassPtr, 100668824);
			DecoderFallbackBuffer.NativeMethodInfoPtr_get_Remaining_Public_Abstract_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecoderFallbackBuffer>.NativeClassPtr, 100668825);
			DecoderFallbackBuffer.NativeMethodInfoPtr_Reset_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecoderFallbackBuffer>.NativeClassPtr, 100668826);
			DecoderFallbackBuffer.NativeMethodInfoPtr_InternalReset_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecoderFallbackBuffer>.NativeClassPtr, 100668827);
			DecoderFallbackBuffer.NativeMethodInfoPtr_InternalInitialize_Internal_Void_ptr_Byte_ptr_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecoderFallbackBuffer>.NativeClassPtr, 100668828);
			DecoderFallbackBuffer.NativeMethodInfoPtr_InternalFallback_Internal_Virtual_New_Boolean_Il2CppStructArray_1_Byte_ptr_Byte_byref_ptr_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecoderFallbackBuffer>.NativeClassPtr, 100668829);
			DecoderFallbackBuffer.NativeMethodInfoPtr_InternalFallback_Internal_Virtual_New_Int32_Il2CppStructArray_1_Byte_ptr_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecoderFallbackBuffer>.NativeClassPtr, 100668830);
			DecoderFallbackBuffer.NativeMethodInfoPtr_ThrowLastBytesRecursive_Internal_Void_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecoderFallbackBuffer>.NativeClassPtr, 100668831);
			DecoderFallbackBuffer.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecoderFallbackBuffer>.NativeClassPtr, 100668832);
		}

		// Token: 0x06002098 RID: 8344 RVA: 0x000BA5F0 File Offset: 0x000B87F0
		[CallerCount(0)]
		public unsafe virtual bool Fallback(Il2CppStructArray<byte> bytesUnknown, int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(bytesUnknown);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DecoderFallbackBuffer.NativeMethodInfoPtr_Fallback_Public_Abstract_Virtual_New_Boolean_Il2CppStructArray_1_Byte_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002099 RID: 8345 RVA: 0x000BA658 File Offset: 0x000B8858
		[CallerCount(0)]
		public unsafe virtual char GetNextChar()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DecoderFallbackBuffer.NativeMethodInfoPtr_GetNextChar_Public_Abstract_Virtual_New_Char_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000643 RID: 1603
		// (get) Token: 0x0600209A RID: 8346 RVA: 0x000BA6A0 File Offset: 0x000B88A0
		public unsafe virtual int Remaining
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DecoderFallbackBuffer.NativeMethodInfoPtr_get_Remaining_Public_Abstract_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600209B RID: 8347 RVA: 0x000BA6E8 File Offset: 0x000B88E8
		[CallerCount(0)]
		public unsafe virtual void Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DecoderFallbackBuffer.NativeMethodInfoPtr_Reset_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600209C RID: 8348 RVA: 0x000BA724 File Offset: 0x000B8924
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1362345, RefRangeEnd = 1362349, XrefRangeStart = 1362345, XrefRangeEnd = 1362345, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InternalReset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecoderFallbackBuffer.NativeMethodInfoPtr_InternalReset_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600209D RID: 8349 RVA: 0x000BA758 File Offset: 0x000B8958
		[CallerCount(16)]
		[CachedScanResults(RefRangeStart = 1362349, RefRangeEnd = 1362365, XrefRangeStart = 1362349, XrefRangeEnd = 1362349, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InternalInitialize(byte* byteStart, char* charEnd)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = byteStart;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = charEnd;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecoderFallbackBuffer.NativeMethodInfoPtr_InternalInitialize_Internal_Void_ptr_Byte_ptr_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600209E RID: 8350 RVA: 0x000BA7A4 File Offset: 0x000B89A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1362365, XrefRangeEnd = 1362374, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool InternalFallback(Il2CppStructArray<byte> bytes, byte* pBytes, ref char* chars)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(bytes);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = pBytes;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(chars);
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DecoderFallbackBuffer.NativeMethodInfoPtr_InternalFallback_Internal_Virtual_New_Boolean_Il2CppStructArray_1_Byte_ptr_Byte_byref_ptr_Char_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			chars = ((intPtr4 == 0) ? null : new char*(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x0600209F RID: 8351 RVA: 0x000BA834 File Offset: 0x000B8A34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1362374, XrefRangeEnd = 1362375, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual int InternalFallback(Il2CppStructArray<byte> bytes, byte* pBytes)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(bytes);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = pBytes;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DecoderFallbackBuffer.NativeMethodInfoPtr_InternalFallback_Internal_Virtual_New_Int32_Il2CppStructArray_1_Byte_ptr_Byte_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060020A0 RID: 8352 RVA: 0x000BA89C File Offset: 0x000B8A9C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1362414, RefRangeEnd = 1362415, XrefRangeStart = 1362375, XrefRangeEnd = 1362414, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ThrowLastBytesRecursive(Il2CppStructArray<byte> bytesUnknown)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(bytesUnknown);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecoderFallbackBuffer.NativeMethodInfoPtr_ThrowLastBytesRecursive_Internal_Void_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060020A1 RID: 8353 RVA: 0x000BA8E0 File Offset: 0x000B8AE0
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DecoderFallbackBuffer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DecoderFallbackBuffer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecoderFallbackBuffer.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060020A2 RID: 8354 RVA: 0x0000A8C7 File Offset: 0x00008AC7
		public DecoderFallbackBuffer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000641 RID: 1601
		// (get) Token: 0x060020A3 RID: 8355 RVA: 0x000BA91C File Offset: 0x000B8B1C
		// (set) Token: 0x060020A4 RID: 8356 RVA: 0x0000A8D0 File Offset: 0x00008AD0
		public unsafe byte* byteStart
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecoderFallbackBuffer.NativeFieldInfoPtr_byteStart);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecoderFallbackBuffer.NativeFieldInfoPtr_byteStart)) = value;
			}
		}

		// Token: 0x17000642 RID: 1602
		// (get) Token: 0x060020A5 RID: 8357 RVA: 0x000BA940 File Offset: 0x000B8B40
		// (set) Token: 0x060020A6 RID: 8358 RVA: 0x0000A8EB File Offset: 0x00008AEB
		public unsafe char* charEnd
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecoderFallbackBuffer.NativeFieldInfoPtr_charEnd);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecoderFallbackBuffer.NativeFieldInfoPtr_charEnd)) = value;
			}
		}

		// Token: 0x04001CF7 RID: 7415
		private static readonly IntPtr NativeFieldInfoPtr_byteStart;

		// Token: 0x04001CF8 RID: 7416
		private static readonly IntPtr NativeFieldInfoPtr_charEnd;

		// Token: 0x04001CF9 RID: 7417
		private static readonly IntPtr NativeMethodInfoPtr_Fallback_Public_Abstract_Virtual_New_Boolean_Il2CppStructArray_1_Byte_Int32_0;

		// Token: 0x04001CFA RID: 7418
		private static readonly IntPtr NativeMethodInfoPtr_GetNextChar_Public_Abstract_Virtual_New_Char_0;

		// Token: 0x04001CFB RID: 7419
		private static readonly IntPtr NativeMethodInfoPtr_get_Remaining_Public_Abstract_Virtual_New_get_Int32_0;

		// Token: 0x04001CFC RID: 7420
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Virtual_New_Void_0;

		// Token: 0x04001CFD RID: 7421
		private static readonly IntPtr NativeMethodInfoPtr_InternalReset_Internal_Void_0;

		// Token: 0x04001CFE RID: 7422
		private static readonly IntPtr NativeMethodInfoPtr_InternalInitialize_Internal_Void_ptr_Byte_ptr_Char_0;

		// Token: 0x04001CFF RID: 7423
		private static readonly IntPtr NativeMethodInfoPtr_InternalFallback_Internal_Virtual_New_Boolean_Il2CppStructArray_1_Byte_ptr_Byte_byref_ptr_Char_0;

		// Token: 0x04001D00 RID: 7424
		private static readonly IntPtr NativeMethodInfoPtr_InternalFallback_Internal_Virtual_New_Int32_Il2CppStructArray_1_Byte_ptr_Byte_0;

		// Token: 0x04001D01 RID: 7425
		private static readonly IntPtr NativeMethodInfoPtr_ThrowLastBytesRecursive_Internal_Void_Il2CppStructArray_1_Byte_0;

		// Token: 0x04001D02 RID: 7426
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
