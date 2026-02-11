using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Xml
{
	// Token: 0x02000008 RID: 8
	public class Base64Encoder : Object
	{
		// Token: 0x06000020 RID: 32 RVA: 0x000166A0 File Offset: 0x000148A0
		// Note: this type is marked as 'beforefieldinit'.
		static Base64Encoder()
		{
			Il2CppClassPointerStore<Base64Encoder>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml", "Base64Encoder");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Base64Encoder>.NativeClassPtr);
			Base64Encoder.NativeFieldInfoPtr_leftOverBytes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Base64Encoder>.NativeClassPtr, "leftOverBytes");
			Base64Encoder.NativeFieldInfoPtr_leftOverBytesCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Base64Encoder>.NativeClassPtr, "leftOverBytesCount");
			Base64Encoder.NativeFieldInfoPtr_charsLine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Base64Encoder>.NativeClassPtr, "charsLine");
			Base64Encoder.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Base64Encoder>.NativeClassPtr, 100663303);
			Base64Encoder.NativeMethodInfoPtr_WriteChars_Internal_Abstract_Virtual_New_Void_Il2CppStructArray_1_Char_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Base64Encoder>.NativeClassPtr, 100663304);
			Base64Encoder.NativeMethodInfoPtr_Encode_Internal_Void_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Base64Encoder>.NativeClassPtr, 100663305);
			Base64Encoder.NativeMethodInfoPtr_Flush_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Base64Encoder>.NativeClassPtr, 100663306);
		}

		// Token: 0x06000021 RID: 33 RVA: 0x0001675C File Offset: 0x0001495C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 362173, XrefRangeEnd = 362178, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Base64Encoder()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Base64Encoder>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Base64Encoder.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000022 RID: 34 RVA: 0x00016798 File Offset: 0x00014998
		[CallerCount(0)]
		public unsafe virtual void WriteChars(Il2CppStructArray<char> chars, int index, int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(chars);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Base64Encoder.NativeMethodInfoPtr_WriteChars_Internal_Abstract_Virtual_New_Void_Il2CppStructArray_1_Char_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000023 RID: 35 RVA: 0x00016804 File Offset: 0x00014A04
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 362180, RefRangeEnd = 362183, XrefRangeStart = 362178, XrefRangeEnd = 362180, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Encode(Il2CppStructArray<byte> buffer, int index, int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Base64Encoder.NativeMethodInfoPtr_Encode_Internal_Void_Il2CppStructArray_1_Byte_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000024 RID: 36 RVA: 0x00016864 File Offset: 0x00014A64
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 362187, RefRangeEnd = 362196, XrefRangeStart = 362183, XrefRangeEnd = 362187, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Flush()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Base64Encoder.NativeMethodInfoPtr_Flush_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000025 RID: 37 RVA: 0x000021B2 File Offset: 0x000003B2
		public Base64Encoder(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000026 RID: 38 RVA: 0x00016898 File Offset: 0x00014A98
		// (set) Token: 0x06000027 RID: 39 RVA: 0x000021BB File Offset: 0x000003BB
		public unsafe Il2CppStructArray<byte> leftOverBytes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Base64Encoder.NativeFieldInfoPtr_leftOverBytes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Base64Encoder.NativeFieldInfoPtr_leftOverBytes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000028 RID: 40 RVA: 0x000168C8 File Offset: 0x00014AC8
		// (set) Token: 0x06000029 RID: 41 RVA: 0x000021DA File Offset: 0x000003DA
		public unsafe int leftOverBytesCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Base64Encoder.NativeFieldInfoPtr_leftOverBytesCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Base64Encoder.NativeFieldInfoPtr_leftOverBytesCount)) = value;
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x0600002A RID: 42 RVA: 0x000168F0 File Offset: 0x00014AF0
		// (set) Token: 0x0600002B RID: 43 RVA: 0x000021F5 File Offset: 0x000003F5
		public unsafe Il2CppStructArray<char> charsLine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Base64Encoder.NativeFieldInfoPtr_charsLine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Base64Encoder.NativeFieldInfoPtr_charsLine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400000C RID: 12
		private static readonly IntPtr NativeFieldInfoPtr_leftOverBytes;

		// Token: 0x0400000D RID: 13
		private static readonly IntPtr NativeFieldInfoPtr_leftOverBytesCount;

		// Token: 0x0400000E RID: 14
		private static readonly IntPtr NativeFieldInfoPtr_charsLine;

		// Token: 0x0400000F RID: 15
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

		// Token: 0x04000010 RID: 16
		private static readonly IntPtr NativeMethodInfoPtr_WriteChars_Internal_Abstract_Virtual_New_Void_Il2CppStructArray_1_Char_Int32_Int32_0;

		// Token: 0x04000011 RID: 17
		private static readonly IntPtr NativeMethodInfoPtr_Encode_Internal_Void_Il2CppStructArray_1_Byte_Int32_Int32_0;

		// Token: 0x04000012 RID: 18
		private static readonly IntPtr NativeMethodInfoPtr_Flush_Internal_Void_0;
	}
}
