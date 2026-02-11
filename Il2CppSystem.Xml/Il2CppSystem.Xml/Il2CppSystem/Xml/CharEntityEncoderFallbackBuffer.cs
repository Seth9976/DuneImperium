using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Text;

namespace Il2CppSystem.Xml
{
	// Token: 0x02000016 RID: 22
	public class CharEntityEncoderFallbackBuffer : EncoderFallbackBuffer
	{
		// Token: 0x060001CA RID: 458 RVA: 0x0001C768 File Offset: 0x0001A968
		// Note: this type is marked as 'beforefieldinit'.
		static CharEntityEncoderFallbackBuffer()
		{
			Il2CppClassPointerStore<CharEntityEncoderFallbackBuffer>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml", "CharEntityEncoderFallbackBuffer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharEntityEncoderFallbackBuffer>.NativeClassPtr);
			CharEntityEncoderFallbackBuffer.NativeFieldInfoPtr_parent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharEntityEncoderFallbackBuffer>.NativeClassPtr, "parent");
			CharEntityEncoderFallbackBuffer.NativeFieldInfoPtr_charEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharEntityEncoderFallbackBuffer>.NativeClassPtr, "charEntity");
			CharEntityEncoderFallbackBuffer.NativeFieldInfoPtr_charEntityIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharEntityEncoderFallbackBuffer>.NativeClassPtr, "charEntityIndex");
			CharEntityEncoderFallbackBuffer.NativeMethodInfoPtr__ctor_Internal_Void_CharEntityEncoderFallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharEntityEncoderFallbackBuffer>.NativeClassPtr, 100663530);
			CharEntityEncoderFallbackBuffer.NativeMethodInfoPtr_Fallback_Public_Virtual_Boolean_Char_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharEntityEncoderFallbackBuffer>.NativeClassPtr, 100663531);
			CharEntityEncoderFallbackBuffer.NativeMethodInfoPtr_Fallback_Public_Virtual_Boolean_Char_Char_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharEntityEncoderFallbackBuffer>.NativeClassPtr, 100663532);
			CharEntityEncoderFallbackBuffer.NativeMethodInfoPtr_GetNextChar_Public_Virtual_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharEntityEncoderFallbackBuffer>.NativeClassPtr, 100663533);
			CharEntityEncoderFallbackBuffer.NativeMethodInfoPtr_MovePrevious_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharEntityEncoderFallbackBuffer>.NativeClassPtr, 100663534);
			CharEntityEncoderFallbackBuffer.NativeMethodInfoPtr_get_Remaining_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharEntityEncoderFallbackBuffer>.NativeClassPtr, 100663535);
			CharEntityEncoderFallbackBuffer.NativeMethodInfoPtr_Reset_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharEntityEncoderFallbackBuffer>.NativeClassPtr, 100663536);
			CharEntityEncoderFallbackBuffer.NativeMethodInfoPtr_SurrogateCharToUtf32_Private_Int32_Char_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharEntityEncoderFallbackBuffer>.NativeClassPtr, 100663537);
		}

		// Token: 0x060001CB RID: 459 RVA: 0x0001C874 File Offset: 0x0001AA74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 364172, XrefRangeEnd = 364177, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CharEntityEncoderFallbackBuffer(CharEntityEncoderFallback parent)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharEntityEncoderFallbackBuffer>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(parent);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharEntityEncoderFallbackBuffer.NativeMethodInfoPtr__ctor_Internal_Void_CharEntityEncoderFallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060001CC RID: 460 RVA: 0x0001C8C0 File Offset: 0x0001AAC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 364177, XrefRangeEnd = 364188, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CharEntityEncoderFallbackBuffer.NativeMethodInfoPtr_Fallback_Public_Virtual_Boolean_Char_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060001CD RID: 461 RVA: 0x0001C924 File Offset: 0x0001AB24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 364188, XrefRangeEnd = 364203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CharEntityEncoderFallbackBuffer.NativeMethodInfoPtr_Fallback_Public_Virtual_Boolean_Char_Char_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060001CE RID: 462 RVA: 0x0001C994 File Offset: 0x0001AB94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 364203, XrefRangeEnd = 364204, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override char GetNextChar()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CharEntityEncoderFallbackBuffer.NativeMethodInfoPtr_GetNextChar_Public_Virtual_Char_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060001CF RID: 463 RVA: 0x0001C9DC File Offset: 0x0001ABDC
		[CallerCount(0)]
		public unsafe override bool MovePrevious()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CharEntityEncoderFallbackBuffer.NativeMethodInfoPtr_MovePrevious_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000082 RID: 130
		// (get) Token: 0x060001D0 RID: 464 RVA: 0x0001CA24 File Offset: 0x0001AC24
		public unsafe override int Remaining
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CharEntityEncoderFallbackBuffer.NativeMethodInfoPtr_get_Remaining_Public_Virtual_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060001D1 RID: 465 RVA: 0x0001CA6C File Offset: 0x0001AC6C
		[CallerCount(0)]
		public unsafe override void Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CharEntityEncoderFallbackBuffer.NativeMethodInfoPtr_Reset_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001D2 RID: 466 RVA: 0x0001CAA8 File Offset: 0x0001ACA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 364204, XrefRangeEnd = 364205, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int SurrogateCharToUtf32(char highSurrogate, char lowSurrogate)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref highSurrogate;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lowSurrogate;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharEntityEncoderFallbackBuffer.NativeMethodInfoPtr_SurrogateCharToUtf32_Private_Int32_Char_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060001D3 RID: 467 RVA: 0x00002C20 File Offset: 0x00000E20
		public CharEntityEncoderFallbackBuffer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700007F RID: 127
		// (get) Token: 0x060001D4 RID: 468 RVA: 0x0001CB00 File Offset: 0x0001AD00
		// (set) Token: 0x060001D5 RID: 469 RVA: 0x00002C29 File Offset: 0x00000E29
		public unsafe CharEntityEncoderFallback parent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharEntityEncoderFallbackBuffer.NativeFieldInfoPtr_parent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CharEntityEncoderFallback>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharEntityEncoderFallbackBuffer.NativeFieldInfoPtr_parent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000080 RID: 128
		// (get) Token: 0x060001D6 RID: 470 RVA: 0x0001CB30 File Offset: 0x0001AD30
		// (set) Token: 0x060001D7 RID: 471 RVA: 0x00002C48 File Offset: 0x00000E48
		public unsafe string charEntity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharEntityEncoderFallbackBuffer.NativeFieldInfoPtr_charEntity);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharEntityEncoderFallbackBuffer.NativeFieldInfoPtr_charEntity), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000081 RID: 129
		// (get) Token: 0x060001D8 RID: 472 RVA: 0x0001CB58 File Offset: 0x0001AD58
		// (set) Token: 0x060001D9 RID: 473 RVA: 0x00002C67 File Offset: 0x00000E67
		public unsafe int charEntityIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharEntityEncoderFallbackBuffer.NativeFieldInfoPtr_charEntityIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharEntityEncoderFallbackBuffer.NativeFieldInfoPtr_charEntityIndex)) = value;
			}
		}

		// Token: 0x0400018D RID: 397
		private static readonly IntPtr NativeFieldInfoPtr_parent;

		// Token: 0x0400018E RID: 398
		private static readonly IntPtr NativeFieldInfoPtr_charEntity;

		// Token: 0x0400018F RID: 399
		private static readonly IntPtr NativeFieldInfoPtr_charEntityIndex;

		// Token: 0x04000190 RID: 400
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_CharEntityEncoderFallback_0;

		// Token: 0x04000191 RID: 401
		private static readonly IntPtr NativeMethodInfoPtr_Fallback_Public_Virtual_Boolean_Char_Int32_0;

		// Token: 0x04000192 RID: 402
		private static readonly IntPtr NativeMethodInfoPtr_Fallback_Public_Virtual_Boolean_Char_Char_Int32_0;

		// Token: 0x04000193 RID: 403
		private static readonly IntPtr NativeMethodInfoPtr_GetNextChar_Public_Virtual_Char_0;

		// Token: 0x04000194 RID: 404
		private static readonly IntPtr NativeMethodInfoPtr_MovePrevious_Public_Virtual_Boolean_0;

		// Token: 0x04000195 RID: 405
		private static readonly IntPtr NativeMethodInfoPtr_get_Remaining_Public_Virtual_get_Int32_0;

		// Token: 0x04000196 RID: 406
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Virtual_Void_0;

		// Token: 0x04000197 RID: 407
		private static readonly IntPtr NativeMethodInfoPtr_SurrogateCharToUtf32_Private_Int32_Char_Char_0;
	}
}
