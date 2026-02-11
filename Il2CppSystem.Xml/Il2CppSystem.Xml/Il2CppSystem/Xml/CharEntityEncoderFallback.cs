using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Text;

namespace Il2CppSystem.Xml
{
	// Token: 0x02000015 RID: 21
	public class CharEntityEncoderFallback : EncoderFallback
	{
		// Token: 0x060001B8 RID: 440 RVA: 0x0001C3D8 File Offset: 0x0001A5D8
		// Note: this type is marked as 'beforefieldinit'.
		static CharEntityEncoderFallback()
		{
			Il2CppClassPointerStore<CharEntityEncoderFallback>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml", "CharEntityEncoderFallback");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharEntityEncoderFallback>.NativeClassPtr);
			CharEntityEncoderFallback.NativeFieldInfoPtr_fallbackBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharEntityEncoderFallback>.NativeClassPtr, "fallbackBuffer");
			CharEntityEncoderFallback.NativeFieldInfoPtr_textContentMarks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharEntityEncoderFallback>.NativeClassPtr, "textContentMarks");
			CharEntityEncoderFallback.NativeFieldInfoPtr_endMarkPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharEntityEncoderFallback>.NativeClassPtr, "endMarkPos");
			CharEntityEncoderFallback.NativeFieldInfoPtr_curMarkPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharEntityEncoderFallback>.NativeClassPtr, "curMarkPos");
			CharEntityEncoderFallback.NativeFieldInfoPtr_startOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharEntityEncoderFallback>.NativeClassPtr, "startOffset");
			CharEntityEncoderFallback.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharEntityEncoderFallback>.NativeClassPtr, 100663524);
			CharEntityEncoderFallback.NativeMethodInfoPtr_CreateFallbackBuffer_Public_Virtual_EncoderFallbackBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharEntityEncoderFallback>.NativeClassPtr, 100663525);
			CharEntityEncoderFallback.NativeMethodInfoPtr_get_MaxCharCount_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharEntityEncoderFallback>.NativeClassPtr, 100663526);
			CharEntityEncoderFallback.NativeMethodInfoPtr_set_StartOffset_Internal_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharEntityEncoderFallback>.NativeClassPtr, 100663527);
			CharEntityEncoderFallback.NativeMethodInfoPtr_Reset_Internal_Void_Il2CppStructArray_1_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharEntityEncoderFallback>.NativeClassPtr, 100663528);
			CharEntityEncoderFallback.NativeMethodInfoPtr_CanReplaceAt_Internal_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharEntityEncoderFallback>.NativeClassPtr, 100663529);
		}

		// Token: 0x060001B9 RID: 441 RVA: 0x0001C4E4 File Offset: 0x0001A6E4
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CharEntityEncoderFallback()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharEntityEncoderFallback>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharEntityEncoderFallback.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001BA RID: 442 RVA: 0x0001C520 File Offset: 0x0001A720
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 364161, XrefRangeEnd = 364170, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override EncoderFallbackBuffer CreateFallbackBuffer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CharEntityEncoderFallback.NativeMethodInfoPtr_CreateFallbackBuffer_Public_Virtual_EncoderFallbackBuffer_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<EncoderFallbackBuffer>(intPtr3) : null;
		}

		// Token: 0x1700007D RID: 125
		// (get) Token: 0x060001BB RID: 443 RVA: 0x0001C56C File Offset: 0x0001A76C
		public unsafe override int MaxCharCount
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CharEntityEncoderFallback.NativeMethodInfoPtr_get_MaxCharCount_Public_Virtual_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700007E RID: 126
		// (set) Token: 0x060001BC RID: 444 RVA: 0x0001C5B4 File Offset: 0x0001A7B4
		public unsafe int StartOffset
		{
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharEntityEncoderFallback.NativeMethodInfoPtr_set_StartOffset_Internal_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060001BD RID: 445 RVA: 0x0001C5F4 File Offset: 0x0001A7F4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 364171, RefRangeEnd = 364172, XrefRangeStart = 364170, XrefRangeEnd = 364171, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Reset(Il2CppStructArray<int> textContentMarks, int endMarkPos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(textContentMarks);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref endMarkPos;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharEntityEncoderFallback.NativeMethodInfoPtr_Reset_Internal_Void_Il2CppStructArray_1_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001BE RID: 446 RVA: 0x0001C644 File Offset: 0x0001A844
		[CallerCount(0)]
		public unsafe bool CanReplaceAt(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharEntityEncoderFallback.NativeMethodInfoPtr_CanReplaceAt_Internal_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060001BF RID: 447 RVA: 0x00002B88 File Offset: 0x00000D88
		public CharEntityEncoderFallback(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000078 RID: 120
		// (get) Token: 0x060001C0 RID: 448 RVA: 0x0001C690 File Offset: 0x0001A890
		// (set) Token: 0x060001C1 RID: 449 RVA: 0x00002B91 File Offset: 0x00000D91
		public unsafe CharEntityEncoderFallbackBuffer fallbackBuffer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharEntityEncoderFallback.NativeFieldInfoPtr_fallbackBuffer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CharEntityEncoderFallbackBuffer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharEntityEncoderFallback.NativeFieldInfoPtr_fallbackBuffer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000079 RID: 121
		// (get) Token: 0x060001C2 RID: 450 RVA: 0x0001C6C0 File Offset: 0x0001A8C0
		// (set) Token: 0x060001C3 RID: 451 RVA: 0x00002BB0 File Offset: 0x00000DB0
		public unsafe Il2CppStructArray<int> textContentMarks
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharEntityEncoderFallback.NativeFieldInfoPtr_textContentMarks);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharEntityEncoderFallback.NativeFieldInfoPtr_textContentMarks), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700007A RID: 122
		// (get) Token: 0x060001C4 RID: 452 RVA: 0x0001C6F0 File Offset: 0x0001A8F0
		// (set) Token: 0x060001C5 RID: 453 RVA: 0x00002BCF File Offset: 0x00000DCF
		public unsafe int endMarkPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharEntityEncoderFallback.NativeFieldInfoPtr_endMarkPos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharEntityEncoderFallback.NativeFieldInfoPtr_endMarkPos)) = value;
			}
		}

		// Token: 0x1700007B RID: 123
		// (get) Token: 0x060001C6 RID: 454 RVA: 0x0001C718 File Offset: 0x0001A918
		// (set) Token: 0x060001C7 RID: 455 RVA: 0x00002BEA File Offset: 0x00000DEA
		public unsafe int curMarkPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharEntityEncoderFallback.NativeFieldInfoPtr_curMarkPos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharEntityEncoderFallback.NativeFieldInfoPtr_curMarkPos)) = value;
			}
		}

		// Token: 0x1700007C RID: 124
		// (get) Token: 0x060001C8 RID: 456 RVA: 0x0001C740 File Offset: 0x0001A940
		// (set) Token: 0x060001C9 RID: 457 RVA: 0x00002C05 File Offset: 0x00000E05
		public unsafe int startOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharEntityEncoderFallback.NativeFieldInfoPtr_startOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharEntityEncoderFallback.NativeFieldInfoPtr_startOffset)) = value;
			}
		}

		// Token: 0x04000182 RID: 386
		private static readonly IntPtr NativeFieldInfoPtr_fallbackBuffer;

		// Token: 0x04000183 RID: 387
		private static readonly IntPtr NativeFieldInfoPtr_textContentMarks;

		// Token: 0x04000184 RID: 388
		private static readonly IntPtr NativeFieldInfoPtr_endMarkPos;

		// Token: 0x04000185 RID: 389
		private static readonly IntPtr NativeFieldInfoPtr_curMarkPos;

		// Token: 0x04000186 RID: 390
		private static readonly IntPtr NativeFieldInfoPtr_startOffset;

		// Token: 0x04000187 RID: 391
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

		// Token: 0x04000188 RID: 392
		private static readonly IntPtr NativeMethodInfoPtr_CreateFallbackBuffer_Public_Virtual_EncoderFallbackBuffer_0;

		// Token: 0x04000189 RID: 393
		private static readonly IntPtr NativeMethodInfoPtr_get_MaxCharCount_Public_Virtual_get_Int32_0;

		// Token: 0x0400018A RID: 394
		private static readonly IntPtr NativeMethodInfoPtr_set_StartOffset_Internal_set_Void_Int32_0;

		// Token: 0x0400018B RID: 395
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Internal_Void_Il2CppStructArray_1_Int32_Int32_0;

		// Token: 0x0400018C RID: 396
		private static readonly IntPtr NativeMethodInfoPtr_CanReplaceAt_Internal_Boolean_Int32_0;
	}
}
