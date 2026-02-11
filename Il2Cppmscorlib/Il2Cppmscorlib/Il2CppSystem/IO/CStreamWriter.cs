using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Text;

namespace Il2CppSystem.IO
{
	// Token: 0x0200054E RID: 1358
	public class CStreamWriter : StreamWriter
	{
		// Token: 0x060053CD RID: 21453 RVA: 0x001863E0 File Offset: 0x001845E0
		// Note: this type is marked as 'beforefieldinit'.
		static CStreamWriter()
		{
			Il2CppClassPointerStore<CStreamWriter>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.IO", "CStreamWriter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CStreamWriter>.NativeClassPtr);
			CStreamWriter.NativeFieldInfoPtr_driver = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CStreamWriter>.NativeClassPtr, "driver");
			CStreamWriter.NativeMethodInfoPtr__ctor_Public_Void_Stream_Encoding_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CStreamWriter>.NativeClassPtr, 100676161);
			CStreamWriter.NativeMethodInfoPtr_Write_Public_Virtual_Void_Il2CppStructArray_1_Char_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CStreamWriter>.NativeClassPtr, 100676162);
			CStreamWriter.NativeMethodInfoPtr_Write_Public_Virtual_Void_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CStreamWriter>.NativeClassPtr, 100676163);
			CStreamWriter.NativeMethodInfoPtr_InternalWriteString_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CStreamWriter>.NativeClassPtr, 100676164);
			CStreamWriter.NativeMethodInfoPtr_InternalWriteChar_Public_Void_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CStreamWriter>.NativeClassPtr, 100676165);
			CStreamWriter.NativeMethodInfoPtr_InternalWriteChars_Public_Void_Il2CppStructArray_1_Char_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CStreamWriter>.NativeClassPtr, 100676166);
			CStreamWriter.NativeMethodInfoPtr_Write_Public_Virtual_Void_Il2CppStructArray_1_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CStreamWriter>.NativeClassPtr, 100676167);
			CStreamWriter.NativeMethodInfoPtr_Write_Public_Virtual_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CStreamWriter>.NativeClassPtr, 100676168);
			CStreamWriter.NativeMethodInfoPtr_WriteLine_Public_Virtual_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CStreamWriter>.NativeClassPtr, 100676169);
		}

		// Token: 0x060053CE RID: 21454 RVA: 0x001864D8 File Offset: 0x001846D8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1434553, RefRangeEnd = 1434555, XrefRangeStart = 1434538, XrefRangeEnd = 1434553, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CStreamWriter(Stream stream, Encoding encoding, bool leaveOpen)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CStreamWriter>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stream);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(encoding);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref leaveOpen;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CStreamWriter.NativeMethodInfoPtr__ctor_Public_Void_Stream_Encoding_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060053CF RID: 21455 RVA: 0x00186544 File Offset: 0x00184744
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1434555, XrefRangeEnd = 1434572, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Write(Il2CppStructArray<char> buffer, int index, int count)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CStreamWriter.NativeMethodInfoPtr_Write_Public_Virtual_Void_Il2CppStructArray_1_Char_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060053D0 RID: 21456 RVA: 0x001865B0 File Offset: 0x001847B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1434572, XrefRangeEnd = 1434582, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Write(char val)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CStreamWriter.NativeMethodInfoPtr_Write_Public_Virtual_Void_Char_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060053D1 RID: 21457 RVA: 0x001865FC File Offset: 0x001847FC
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 1434584, RefRangeEnd = 1434592, XrefRangeStart = 1434582, XrefRangeEnd = 1434584, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InternalWriteString(string val)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(val);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CStreamWriter.NativeMethodInfoPtr_InternalWriteString_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060053D2 RID: 21458 RVA: 0x00186640 File Offset: 0x00184840
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1434594, RefRangeEnd = 1434595, XrefRangeStart = 1434592, XrefRangeEnd = 1434594, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InternalWriteChar(char val)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CStreamWriter.NativeMethodInfoPtr_InternalWriteChar_Public_Void_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060053D3 RID: 21459 RVA: 0x00186680 File Offset: 0x00184880
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1434597, RefRangeEnd = 1434603, XrefRangeStart = 1434595, XrefRangeEnd = 1434597, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InternalWriteChars(Il2CppStructArray<char> buffer, int n)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref n;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CStreamWriter.NativeMethodInfoPtr_InternalWriteChars_Public_Void_Il2CppStructArray_1_Char_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060053D4 RID: 21460 RVA: 0x001866D0 File Offset: 0x001848D0
		[CallerCount(0)]
		public unsafe override void Write(Il2CppStructArray<char> val)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(val);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CStreamWriter.NativeMethodInfoPtr_Write_Public_Virtual_Void_Il2CppStructArray_1_Char_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060053D5 RID: 21461 RVA: 0x00186720 File Offset: 0x00184920
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1434603, XrefRangeEnd = 1434605, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Write(string val)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(val);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CStreamWriter.NativeMethodInfoPtr_Write_Public_Virtual_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060053D6 RID: 21462 RVA: 0x00186770 File Offset: 0x00184970
		[CallerCount(0)]
		public unsafe override void WriteLine(string val)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(val);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CStreamWriter.NativeMethodInfoPtr_WriteLine_Public_Virtual_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060053D7 RID: 21463 RVA: 0x0001DA5C File Offset: 0x0001BC5C
		public CStreamWriter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17001545 RID: 5445
		// (get) Token: 0x060053D8 RID: 21464 RVA: 0x001867C0 File Offset: 0x001849C0
		// (set) Token: 0x060053D9 RID: 21465 RVA: 0x0001DA65 File Offset: 0x0001BC65
		public unsafe TermInfoDriver driver
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CStreamWriter.NativeFieldInfoPtr_driver);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TermInfoDriver>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CStreamWriter.NativeFieldInfoPtr_driver), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004492 RID: 17554
		private static readonly IntPtr NativeFieldInfoPtr_driver;

		// Token: 0x04004493 RID: 17555
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Stream_Encoding_Boolean_0;

		// Token: 0x04004494 RID: 17556
		private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Virtual_Void_Il2CppStructArray_1_Char_Int32_Int32_0;

		// Token: 0x04004495 RID: 17557
		private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Virtual_Void_Char_0;

		// Token: 0x04004496 RID: 17558
		private static readonly IntPtr NativeMethodInfoPtr_InternalWriteString_Public_Void_String_0;

		// Token: 0x04004497 RID: 17559
		private static readonly IntPtr NativeMethodInfoPtr_InternalWriteChar_Public_Void_Char_0;

		// Token: 0x04004498 RID: 17560
		private static readonly IntPtr NativeMethodInfoPtr_InternalWriteChars_Public_Void_Il2CppStructArray_1_Char_Int32_0;

		// Token: 0x04004499 RID: 17561
		private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Virtual_Void_Il2CppStructArray_1_Char_0;

		// Token: 0x0400449A RID: 17562
		private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Virtual_Void_String_0;

		// Token: 0x0400449B RID: 17563
		private static readonly IntPtr NativeMethodInfoPtr_WriteLine_Public_Virtual_Void_String_0;
	}
}
