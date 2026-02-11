using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Text
{
	// Token: 0x02000209 RID: 521
	public sealed class EncoderReplacementFallbackBuffer : EncoderFallbackBuffer
	{
		// Token: 0x06002173 RID: 8563 RVA: 0x000BE0DC File Offset: 0x000BC2DC
		// Note: this type is marked as 'beforefieldinit'.
		static EncoderReplacementFallbackBuffer()
		{
			Il2CppClassPointerStore<EncoderReplacementFallbackBuffer>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Text", "EncoderReplacementFallbackBuffer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EncoderReplacementFallbackBuffer>.NativeClassPtr);
			EncoderReplacementFallbackBuffer.NativeFieldInfoPtr__strDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EncoderReplacementFallbackBuffer>.NativeClassPtr, "_strDefault");
			EncoderReplacementFallbackBuffer.NativeFieldInfoPtr__fallbackCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EncoderReplacementFallbackBuffer>.NativeClassPtr, "_fallbackCount");
			EncoderReplacementFallbackBuffer.NativeFieldInfoPtr__fallbackIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EncoderReplacementFallbackBuffer>.NativeClassPtr, "_fallbackIndex");
			EncoderReplacementFallbackBuffer.NativeMethodInfoPtr__ctor_Public_Void_EncoderReplacementFallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EncoderReplacementFallbackBuffer>.NativeClassPtr, 100668939);
			EncoderReplacementFallbackBuffer.NativeMethodInfoPtr_Fallback_Public_Virtual_Boolean_Char_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EncoderReplacementFallbackBuffer>.NativeClassPtr, 100668940);
			EncoderReplacementFallbackBuffer.NativeMethodInfoPtr_Fallback_Public_Virtual_Boolean_Char_Char_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EncoderReplacementFallbackBuffer>.NativeClassPtr, 100668941);
			EncoderReplacementFallbackBuffer.NativeMethodInfoPtr_GetNextChar_Public_Virtual_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EncoderReplacementFallbackBuffer>.NativeClassPtr, 100668942);
			EncoderReplacementFallbackBuffer.NativeMethodInfoPtr_MovePrevious_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EncoderReplacementFallbackBuffer>.NativeClassPtr, 100668943);
			EncoderReplacementFallbackBuffer.NativeMethodInfoPtr_get_Remaining_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EncoderReplacementFallbackBuffer>.NativeClassPtr, 100668944);
			EncoderReplacementFallbackBuffer.NativeMethodInfoPtr_Reset_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EncoderReplacementFallbackBuffer>.NativeClassPtr, 100668945);
		}

		// Token: 0x06002174 RID: 8564 RVA: 0x000BE1D4 File Offset: 0x000BC3D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1363013, XrefRangeEnd = 1363017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EncoderReplacementFallbackBuffer(EncoderReplacementFallback fallback)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EncoderReplacementFallbackBuffer>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(fallback);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EncoderReplacementFallbackBuffer.NativeMethodInfoPtr__ctor_Public_Void_EncoderReplacementFallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002175 RID: 8565 RVA: 0x000BE220 File Offset: 0x000BC420
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1363017, XrefRangeEnd = 1363018, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Fallback(char charUnknown, int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref charUnknown;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EncoderReplacementFallbackBuffer.NativeMethodInfoPtr_Fallback_Public_Virtual_Boolean_Char_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002176 RID: 8566 RVA: 0x000BE278 File Offset: 0x000BC478
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1363018, XrefRangeEnd = 1363025, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Fallback(char charUnknownHigh, char charUnknownLow, int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref charUnknownHigh;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref charUnknownLow;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EncoderReplacementFallbackBuffer.NativeMethodInfoPtr_Fallback_Public_Virtual_Boolean_Char_Char_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002177 RID: 8567 RVA: 0x000BE2E0 File Offset: 0x000BC4E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1363025, XrefRangeEnd = 1363026, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override char GetNextChar()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EncoderReplacementFallbackBuffer.NativeMethodInfoPtr_GetNextChar_Public_Virtual_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002178 RID: 8568 RVA: 0x000BE31C File Offset: 0x000BC51C
		[CallerCount(0)]
		public unsafe override bool MovePrevious()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EncoderReplacementFallbackBuffer.NativeMethodInfoPtr_MovePrevious_Public_Virtual_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000681 RID: 1665
		// (get) Token: 0x06002179 RID: 8569 RVA: 0x000BE358 File Offset: 0x000BC558
		public unsafe override int Remaining
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EncoderReplacementFallbackBuffer.NativeMethodInfoPtr_get_Remaining_Public_Virtual_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600217A RID: 8570 RVA: 0x000BE394 File Offset: 0x000BC594
		[CallerCount(0)]
		public unsafe override void Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EncoderReplacementFallbackBuffer.NativeMethodInfoPtr_Reset_Public_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600217B RID: 8571 RVA: 0x0000AD58 File Offset: 0x00008F58
		public EncoderReplacementFallbackBuffer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700067E RID: 1662
		// (get) Token: 0x0600217C RID: 8572 RVA: 0x000BE3C8 File Offset: 0x000BC5C8
		// (set) Token: 0x0600217D RID: 8573 RVA: 0x0000AD61 File Offset: 0x00008F61
		public unsafe string _strDefault
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EncoderReplacementFallbackBuffer.NativeFieldInfoPtr__strDefault);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EncoderReplacementFallbackBuffer.NativeFieldInfoPtr__strDefault), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700067F RID: 1663
		// (get) Token: 0x0600217E RID: 8574 RVA: 0x000BE3F0 File Offset: 0x000BC5F0
		// (set) Token: 0x0600217F RID: 8575 RVA: 0x0000AD80 File Offset: 0x00008F80
		public unsafe int _fallbackCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EncoderReplacementFallbackBuffer.NativeFieldInfoPtr__fallbackCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EncoderReplacementFallbackBuffer.NativeFieldInfoPtr__fallbackCount)) = value;
			}
		}

		// Token: 0x17000680 RID: 1664
		// (get) Token: 0x06002180 RID: 8576 RVA: 0x000BE418 File Offset: 0x000BC618
		// (set) Token: 0x06002181 RID: 8577 RVA: 0x0000AD9B File Offset: 0x00008F9B
		public unsafe int _fallbackIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EncoderReplacementFallbackBuffer.NativeFieldInfoPtr__fallbackIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EncoderReplacementFallbackBuffer.NativeFieldInfoPtr__fallbackIndex)) = value;
			}
		}

		// Token: 0x04001D91 RID: 7569
		private static readonly IntPtr NativeFieldInfoPtr__strDefault;

		// Token: 0x04001D92 RID: 7570
		private static readonly IntPtr NativeFieldInfoPtr__fallbackCount;

		// Token: 0x04001D93 RID: 7571
		private static readonly IntPtr NativeFieldInfoPtr__fallbackIndex;

		// Token: 0x04001D94 RID: 7572
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_EncoderReplacementFallback_0;

		// Token: 0x04001D95 RID: 7573
		private static readonly IntPtr NativeMethodInfoPtr_Fallback_Public_Virtual_Boolean_Char_Int32_0;

		// Token: 0x04001D96 RID: 7574
		private static readonly IntPtr NativeMethodInfoPtr_Fallback_Public_Virtual_Boolean_Char_Char_Int32_0;

		// Token: 0x04001D97 RID: 7575
		private static readonly IntPtr NativeMethodInfoPtr_GetNextChar_Public_Virtual_Char_0;

		// Token: 0x04001D98 RID: 7576
		private static readonly IntPtr NativeMethodInfoPtr_MovePrevious_Public_Virtual_Boolean_0;

		// Token: 0x04001D99 RID: 7577
		private static readonly IntPtr NativeMethodInfoPtr_get_Remaining_Public_Virtual_get_Int32_0;

		// Token: 0x04001D9A RID: 7578
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Virtual_Void_0;
	}
}
