using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;

namespace Il2CppSystem.Text
{
	// Token: 0x020001FE RID: 510
	public sealed class DecoderReplacementFallbackBuffer : DecoderFallbackBuffer
	{
		// Token: 0x060020CB RID: 8395 RVA: 0x000BB52C File Offset: 0x000B972C
		// Note: this type is marked as 'beforefieldinit'.
		static DecoderReplacementFallbackBuffer()
		{
			Il2CppClassPointerStore<DecoderReplacementFallbackBuffer>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Text", "DecoderReplacementFallbackBuffer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DecoderReplacementFallbackBuffer>.NativeClassPtr);
			DecoderReplacementFallbackBuffer.NativeFieldInfoPtr__strDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecoderReplacementFallbackBuffer>.NativeClassPtr, "_strDefault");
			DecoderReplacementFallbackBuffer.NativeFieldInfoPtr__fallbackCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecoderReplacementFallbackBuffer>.NativeClassPtr, "_fallbackCount");
			DecoderReplacementFallbackBuffer.NativeFieldInfoPtr__fallbackIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecoderReplacementFallbackBuffer>.NativeClassPtr, "_fallbackIndex");
			DecoderReplacementFallbackBuffer.NativeMethodInfoPtr__ctor_Public_Void_DecoderReplacementFallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecoderReplacementFallbackBuffer>.NativeClassPtr, 100668855);
			DecoderReplacementFallbackBuffer.NativeMethodInfoPtr_Fallback_Public_Virtual_Boolean_Il2CppStructArray_1_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecoderReplacementFallbackBuffer>.NativeClassPtr, 100668856);
			DecoderReplacementFallbackBuffer.NativeMethodInfoPtr_GetNextChar_Public_Virtual_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecoderReplacementFallbackBuffer>.NativeClassPtr, 100668857);
			DecoderReplacementFallbackBuffer.NativeMethodInfoPtr_get_Remaining_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecoderReplacementFallbackBuffer>.NativeClassPtr, 100668858);
			DecoderReplacementFallbackBuffer.NativeMethodInfoPtr_Reset_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecoderReplacementFallbackBuffer>.NativeClassPtr, 100668859);
			DecoderReplacementFallbackBuffer.NativeMethodInfoPtr_InternalFallback_Internal_Virtual_Int32_Il2CppStructArray_1_Byte_ptr_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecoderReplacementFallbackBuffer>.NativeClassPtr, 100668860);
		}

		// Token: 0x060020CC RID: 8396 RVA: 0x000BB610 File Offset: 0x000B9810
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1362599, XrefRangeEnd = 1362602, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DecoderReplacementFallbackBuffer(DecoderReplacementFallback fallback)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DecoderReplacementFallbackBuffer>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(fallback);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecoderReplacementFallbackBuffer.NativeMethodInfoPtr__ctor_Public_Void_DecoderReplacementFallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060020CD RID: 8397 RVA: 0x000BB65C File Offset: 0x000B985C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1362602, XrefRangeEnd = 1362603, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Fallback(Il2CppStructArray<byte> bytesUnknown, int index)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecoderReplacementFallbackBuffer.NativeMethodInfoPtr_Fallback_Public_Virtual_Boolean_Il2CppStructArray_1_Byte_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060020CE RID: 8398 RVA: 0x000BB6B8 File Offset: 0x000B98B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1362603, XrefRangeEnd = 1362604, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override char GetNextChar()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecoderReplacementFallbackBuffer.NativeMethodInfoPtr_GetNextChar_Public_Virtual_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000650 RID: 1616
		// (get) Token: 0x060020CF RID: 8399 RVA: 0x000BB6F4 File Offset: 0x000B98F4
		public unsafe override int Remaining
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecoderReplacementFallbackBuffer.NativeMethodInfoPtr_get_Remaining_Public_Virtual_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060020D0 RID: 8400 RVA: 0x000BB730 File Offset: 0x000B9930
		[CallerCount(0)]
		public unsafe override void Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecoderReplacementFallbackBuffer.NativeMethodInfoPtr_Reset_Public_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060020D1 RID: 8401 RVA: 0x000BB764 File Offset: 0x000B9964
		[CallerCount(0)]
		public unsafe override int InternalFallback(Il2CppStructArray<byte> bytes, byte* pBytes)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecoderReplacementFallbackBuffer.NativeMethodInfoPtr_InternalFallback_Internal_Virtual_Int32_Il2CppStructArray_1_Byte_ptr_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060020D2 RID: 8402 RVA: 0x0000A9A7 File Offset: 0x00008BA7
		public DecoderReplacementFallbackBuffer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700064D RID: 1613
		// (get) Token: 0x060020D3 RID: 8403 RVA: 0x000BB7C0 File Offset: 0x000B99C0
		// (set) Token: 0x060020D4 RID: 8404 RVA: 0x0000A9B0 File Offset: 0x00008BB0
		public unsafe string _strDefault
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecoderReplacementFallbackBuffer.NativeFieldInfoPtr__strDefault);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecoderReplacementFallbackBuffer.NativeFieldInfoPtr__strDefault), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700064E RID: 1614
		// (get) Token: 0x060020D5 RID: 8405 RVA: 0x000BB7E8 File Offset: 0x000B99E8
		// (set) Token: 0x060020D6 RID: 8406 RVA: 0x0000A9CF File Offset: 0x00008BCF
		public unsafe int _fallbackCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecoderReplacementFallbackBuffer.NativeFieldInfoPtr__fallbackCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecoderReplacementFallbackBuffer.NativeFieldInfoPtr__fallbackCount)) = value;
			}
		}

		// Token: 0x1700064F RID: 1615
		// (get) Token: 0x060020D7 RID: 8407 RVA: 0x000BB810 File Offset: 0x000B9A10
		// (set) Token: 0x060020D8 RID: 8408 RVA: 0x0000A9EA File Offset: 0x00008BEA
		public unsafe int _fallbackIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecoderReplacementFallbackBuffer.NativeFieldInfoPtr__fallbackIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecoderReplacementFallbackBuffer.NativeFieldInfoPtr__fallbackIndex)) = value;
			}
		}

		// Token: 0x04001D1E RID: 7454
		private static readonly IntPtr NativeFieldInfoPtr__strDefault;

		// Token: 0x04001D1F RID: 7455
		private static readonly IntPtr NativeFieldInfoPtr__fallbackCount;

		// Token: 0x04001D20 RID: 7456
		private static readonly IntPtr NativeFieldInfoPtr__fallbackIndex;

		// Token: 0x04001D21 RID: 7457
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_DecoderReplacementFallback_0;

		// Token: 0x04001D22 RID: 7458
		private static readonly IntPtr NativeMethodInfoPtr_Fallback_Public_Virtual_Boolean_Il2CppStructArray_1_Byte_Int32_0;

		// Token: 0x04001D23 RID: 7459
		private static readonly IntPtr NativeMethodInfoPtr_GetNextChar_Public_Virtual_Char_0;

		// Token: 0x04001D24 RID: 7460
		private static readonly IntPtr NativeMethodInfoPtr_get_Remaining_Public_Virtual_get_Int32_0;

		// Token: 0x04001D25 RID: 7461
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Virtual_Void_0;

		// Token: 0x04001D26 RID: 7462
		private static readonly IntPtr NativeMethodInfoPtr_InternalFallback_Internal_Virtual_Int32_Il2CppStructArray_1_Byte_ptr_Byte_0;
	}
}
