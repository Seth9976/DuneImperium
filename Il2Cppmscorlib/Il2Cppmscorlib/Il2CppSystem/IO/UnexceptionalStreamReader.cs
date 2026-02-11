using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Text;

namespace Il2CppSystem.IO
{
	// Token: 0x0200054B RID: 1355
	public class UnexceptionalStreamReader : StreamReader
	{
		// Token: 0x060053AE RID: 21422 RVA: 0x00185AEC File Offset: 0x00183CEC
		// Note: this type is marked as 'beforefieldinit'.
		static UnexceptionalStreamReader()
		{
			Il2CppClassPointerStore<UnexceptionalStreamReader>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.IO", "UnexceptionalStreamReader");
			UnexceptionalStreamReader.NativeFieldInfoPtr_newline = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnexceptionalStreamReader>.NativeClassPtr, "newline");
			UnexceptionalStreamReader.NativeFieldInfoPtr_newlineChar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnexceptionalStreamReader>.NativeClassPtr, "newlineChar");
			UnexceptionalStreamReader.NativeMethodInfoPtr__ctor_Public_Void_Stream_Encoding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnexceptionalStreamReader>.NativeClassPtr, 100676142);
			UnexceptionalStreamReader.NativeMethodInfoPtr_Peek_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnexceptionalStreamReader>.NativeClassPtr, 100676143);
			UnexceptionalStreamReader.NativeMethodInfoPtr_Read_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnexceptionalStreamReader>.NativeClassPtr, 100676144);
			UnexceptionalStreamReader.NativeMethodInfoPtr_Read_Public_Virtual_Int32_Il2CppStructArray_1_Char_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnexceptionalStreamReader>.NativeClassPtr, 100676145);
			UnexceptionalStreamReader.NativeMethodInfoPtr_CheckEOL_Private_Boolean_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnexceptionalStreamReader>.NativeClassPtr, 100676146);
			UnexceptionalStreamReader.NativeMethodInfoPtr_ReadLine_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnexceptionalStreamReader>.NativeClassPtr, 100676147);
			UnexceptionalStreamReader.NativeMethodInfoPtr_ReadToEnd_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnexceptionalStreamReader>.NativeClassPtr, 100676148);
		}

		// Token: 0x060053AF RID: 21423 RVA: 0x00185BC8 File Offset: 0x00183DC8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1434470, RefRangeEnd = 1434471, XrefRangeStart = 1434466, XrefRangeEnd = 1434470, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UnexceptionalStreamReader(Stream stream, Encoding encoding)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnexceptionalStreamReader>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stream);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(encoding);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnexceptionalStreamReader.NativeMethodInfoPtr__ctor_Public_Void_Stream_Encoding_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060053B0 RID: 21424 RVA: 0x00185C28 File Offset: 0x00183E28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1434471, XrefRangeEnd = 1434472, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int Peek()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UnexceptionalStreamReader.NativeMethodInfoPtr_Peek_Public_Virtual_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060053B1 RID: 21425 RVA: 0x00185C70 File Offset: 0x00183E70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1434472, XrefRangeEnd = 1434473, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int Read()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UnexceptionalStreamReader.NativeMethodInfoPtr_Read_Public_Virtual_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060053B2 RID: 21426 RVA: 0x00185CB8 File Offset: 0x00183EB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1434473, XrefRangeEnd = 1434483, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int Read([In] [Out] Il2CppStructArray<char> dest_buffer, int index, int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = 0;
				ptr2 = &intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UnexceptionalStreamReader.NativeMethodInfoPtr_Read_Public_Virtual_Int32_Il2CppStructArray_1_Char_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			*dest_buffer = ((intPtr4 == 0) ? null : new Il2CppStructArray<char>(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x060053B3 RID: 21427 RVA: 0x00185D40 File Offset: 0x00183F40
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1434496, RefRangeEnd = 1434497, XrefRangeStart = 1434483, XrefRangeEnd = 1434496, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CheckEOL(char current)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref current;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnexceptionalStreamReader.NativeMethodInfoPtr_CheckEOL_Private_Boolean_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060053B4 RID: 21428 RVA: 0x00185D8C File Offset: 0x00183F8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1434497, XrefRangeEnd = 1434498, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ReadLine()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UnexceptionalStreamReader.NativeMethodInfoPtr_ReadLine_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060053B5 RID: 21429 RVA: 0x00185DD0 File Offset: 0x00183FD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1434498, XrefRangeEnd = 1434499, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ReadToEnd()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UnexceptionalStreamReader.NativeMethodInfoPtr_ReadToEnd_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060053B6 RID: 21430 RVA: 0x0001DA02 File Offset: 0x0001BC02
		public UnexceptionalStreamReader(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17001542 RID: 5442
		// (get) Token: 0x060053B7 RID: 21431 RVA: 0x00185E14 File Offset: 0x00184014
		// (set) Token: 0x060053B8 RID: 21432 RVA: 0x0001DA0B File Offset: 0x0001BC0B
		public unsafe static Il2CppStructArray<bool> newline
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(UnexceptionalStreamReader.NativeFieldInfoPtr_newline, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<bool>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UnexceptionalStreamReader.NativeFieldInfoPtr_newline, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001543 RID: 5443
		// (get) Token: 0x060053B9 RID: 21433 RVA: 0x00185E3C File Offset: 0x0018403C
		// (set) Token: 0x060053BA RID: 21434 RVA: 0x0001DA1D File Offset: 0x0001BC1D
		public unsafe static char newlineChar
		{
			get
			{
				char c;
				IL2CPP.il2cpp_field_static_get_value(UnexceptionalStreamReader.NativeFieldInfoPtr_newlineChar, (void*)(&c));
				return c;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UnexceptionalStreamReader.NativeFieldInfoPtr_newlineChar, (void*)(&value));
			}
		}

		// Token: 0x0400447C RID: 17532
		private static readonly IntPtr NativeFieldInfoPtr_newline;

		// Token: 0x0400447D RID: 17533
		private static readonly IntPtr NativeFieldInfoPtr_newlineChar;

		// Token: 0x0400447E RID: 17534
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Stream_Encoding_0;

		// Token: 0x0400447F RID: 17535
		private static readonly IntPtr NativeMethodInfoPtr_Peek_Public_Virtual_Int32_0;

		// Token: 0x04004480 RID: 17536
		private static readonly IntPtr NativeMethodInfoPtr_Read_Public_Virtual_Int32_0;

		// Token: 0x04004481 RID: 17537
		private static readonly IntPtr NativeMethodInfoPtr_Read_Public_Virtual_Int32_Il2CppStructArray_1_Char_Int32_Int32_0;

		// Token: 0x04004482 RID: 17538
		private static readonly IntPtr NativeMethodInfoPtr_CheckEOL_Private_Boolean_Char_0;

		// Token: 0x04004483 RID: 17539
		private static readonly IntPtr NativeMethodInfoPtr_ReadLine_Public_Virtual_String_0;

		// Token: 0x04004484 RID: 17540
		private static readonly IntPtr NativeMethodInfoPtr_ReadToEnd_Public_Virtual_String_0;
	}
}
