using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Text;
using Il2CppSystem.Threading.Tasks;

namespace Il2CppSystem.IO
{
	// Token: 0x0200052F RID: 1327
	[Serializable]
	public class TextWriter : MarshalByRefObject
	{
		// Token: 0x06005123 RID: 20771 RVA: 0x00179A18 File Offset: 0x00177C18
		// Note: this type is marked as 'beforefieldinit'.
		static TextWriter()
		{
			Il2CppClassPointerStore<TextWriter>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.IO", "TextWriter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TextWriter>.NativeClassPtr);
			TextWriter.NativeFieldInfoPtr_Null = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextWriter>.NativeClassPtr, "Null");
			TextWriter.NativeFieldInfoPtr_s_coreNewLine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextWriter>.NativeClassPtr, "s_coreNewLine");
			TextWriter.NativeFieldInfoPtr_CoreNewLine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextWriter>.NativeClassPtr, "CoreNewLine");
			TextWriter.NativeFieldInfoPtr_CoreNewLineStr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextWriter>.NativeClassPtr, "CoreNewLineStr");
			TextWriter.NativeFieldInfoPtr__internalFormatProvider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextWriter>.NativeClassPtr, "_internalFormatProvider");
			TextWriter.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextWriter>.NativeClassPtr, 100675606);
			TextWriter.NativeMethodInfoPtr__ctor_Protected_Void_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextWriter>.NativeClassPtr, 100675607);
			TextWriter.NativeMethodInfoPtr_get_FormatProvider_Public_Virtual_New_get_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextWriter>.NativeClassPtr, 100675608);
			TextWriter.NativeMethodInfoPtr_Close_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextWriter>.NativeClassPtr, 100675609);
			TextWriter.NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextWriter>.NativeClassPtr, 100675610);
			TextWriter.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextWriter>.NativeClassPtr, 100675611);
			TextWriter.NativeMethodInfoPtr_DisposeAsync_Public_Virtual_New_ValueTask_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextWriter>.NativeClassPtr, 100675612);
			TextWriter.NativeMethodInfoPtr_Flush_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextWriter>.NativeClassPtr, 100675613);
			TextWriter.NativeMethodInfoPtr_get_Encoding_Public_Abstract_Virtual_New_get_Encoding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextWriter>.NativeClassPtr, 100675614);
			TextWriter.NativeMethodInfoPtr_get_NewLine_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextWriter>.NativeClassPtr, 100675615);
			TextWriter.NativeMethodInfoPtr_Write_Public_Virtual_New_Void_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextWriter>.NativeClassPtr, 100675616);
			TextWriter.NativeMethodInfoPtr_Write_Public_Virtual_New_Void_Il2CppStructArray_1_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextWriter>.NativeClassPtr, 100675617);
			TextWriter.NativeMethodInfoPtr_Write_Public_Virtual_New_Void_Il2CppStructArray_1_Char_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextWriter>.NativeClassPtr, 100675618);
			TextWriter.NativeMethodInfoPtr_Write_Public_Virtual_New_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextWriter>.NativeClassPtr, 100675619);
			TextWriter.NativeMethodInfoPtr_Write_Public_Virtual_New_Void_String_Object_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextWriter>.NativeClassPtr, 100675620);
			TextWriter.NativeMethodInfoPtr_WriteLine_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextWriter>.NativeClassPtr, 100675621);
			TextWriter.NativeMethodInfoPtr_WriteLine_Public_Virtual_New_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextWriter>.NativeClassPtr, 100675622);
			TextWriter.NativeMethodInfoPtr_WriteLine_Public_Virtual_New_Void_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextWriter>.NativeClassPtr, 100675623);
			TextWriter.NativeMethodInfoPtr_WriteAsync_Public_Virtual_New_Task_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextWriter>.NativeClassPtr, 100675624);
			TextWriter.NativeMethodInfoPtr_WriteAsync_Public_Virtual_New_Task_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextWriter>.NativeClassPtr, 100675625);
			TextWriter.NativeMethodInfoPtr_WriteAsync_Public_Virtual_New_Task_Il2CppStructArray_1_Char_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextWriter>.NativeClassPtr, 100675626);
			TextWriter.NativeMethodInfoPtr_FlushAsync_Public_Virtual_New_Task_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextWriter>.NativeClassPtr, 100675627);
			TextWriter.NativeMethodInfoPtr_Synchronized_Public_Static_TextWriter_TextWriter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextWriter>.NativeClassPtr, 100675628);
		}

		// Token: 0x06005124 RID: 20772 RVA: 0x00179C78 File Offset: 0x00177E78
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1429533, RefRangeEnd = 1429536, XrefRangeStart = 1429524, XrefRangeEnd = 1429533, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TextWriter()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TextWriter>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextWriter.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005125 RID: 20773 RVA: 0x00179CB4 File Offset: 0x00177EB4
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 1429545, RefRangeEnd = 1429554, XrefRangeStart = 1429536, XrefRangeEnd = 1429545, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TextWriter(IFormatProvider formatProvider)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TextWriter>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(formatProvider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextWriter.NativeMethodInfoPtr__ctor_Protected_Void_IFormatProvider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170014AD RID: 5293
		// (get) Token: 0x06005126 RID: 20774 RVA: 0x00179D00 File Offset: 0x00177F00
		public unsafe virtual IFormatProvider FormatProvider
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1429554, XrefRangeEnd = 1429555, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TextWriter.NativeMethodInfoPtr_get_FormatProvider_Public_Virtual_New_get_IFormatProvider_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IFormatProvider>(intPtr3) : null;
			}
		}

		// Token: 0x06005127 RID: 20775 RVA: 0x00179D4C File Offset: 0x00177F4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1429555, XrefRangeEnd = 1429559, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TextWriter.NativeMethodInfoPtr_Close_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005128 RID: 20776 RVA: 0x00179D88 File Offset: 0x00177F88
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dispose(bool disposing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref disposing;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TextWriter.NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06005129 RID: 20777 RVA: 0x00179DD4 File Offset: 0x00177FD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1429559, XrefRangeEnd = 1429563, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextWriter.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600512A RID: 20778 RVA: 0x00179E08 File Offset: 0x00178008
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1429573, RefRangeEnd = 1429574, XrefRangeStart = 1429563, XrefRangeEnd = 1429573, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual ValueTask DisposeAsync()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TextWriter.NativeMethodInfoPtr_DisposeAsync_Public_Virtual_New_ValueTask_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new ValueTask(intPtr);
		}

		// Token: 0x0600512B RID: 20779 RVA: 0x00179E4C File Offset: 0x0017804C
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Flush()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TextWriter.NativeMethodInfoPtr_Flush_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170014AE RID: 5294
		// (get) Token: 0x0600512C RID: 20780 RVA: 0x00179E88 File Offset: 0x00178088
		public unsafe virtual Encoding Encoding
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TextWriter.NativeMethodInfoPtr_get_Encoding_Public_Abstract_Virtual_New_get_Encoding_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Encoding>(intPtr3) : null;
			}
		}

		// Token: 0x170014AF RID: 5295
		// (get) Token: 0x0600512D RID: 20781 RVA: 0x00179ED4 File Offset: 0x001780D4
		public unsafe virtual string NewLine
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TextWriter.NativeMethodInfoPtr_get_NewLine_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600512E RID: 20782 RVA: 0x00179F18 File Offset: 0x00178118
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Write(char value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TextWriter.NativeMethodInfoPtr_Write_Public_Virtual_New_Void_Char_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600512F RID: 20783 RVA: 0x00179F64 File Offset: 0x00178164
		[CallerCount(0)]
		public unsafe virtual void Write(Il2CppStructArray<char> buffer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TextWriter.NativeMethodInfoPtr_Write_Public_Virtual_New_Void_Il2CppStructArray_1_Char_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06005130 RID: 20784 RVA: 0x00179FB4 File Offset: 0x001781B4
		[CallerCount(0)]
		public unsafe virtual void Write(Il2CppStructArray<char> buffer, int index, int count)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TextWriter.NativeMethodInfoPtr_Write_Public_Virtual_New_Void_Il2CppStructArray_1_Char_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005131 RID: 20785 RVA: 0x0017A020 File Offset: 0x00178220
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1429574, XrefRangeEnd = 1429575, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Write(string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TextWriter.NativeMethodInfoPtr_Write_Public_Virtual_New_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06005132 RID: 20786 RVA: 0x0017A070 File Offset: 0x00178270
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1429575, XrefRangeEnd = 1429597, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Write(string format, Object arg0, Object arg1, Object arg2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(format);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(arg0);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(arg1);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(arg2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TextWriter.NativeMethodInfoPtr_Write_Public_Virtual_New_Void_String_Object_Object_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005133 RID: 20787 RVA: 0x0017A0F4 File Offset: 0x001782F4
		[CallerCount(0)]
		public unsafe virtual void WriteLine()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TextWriter.NativeMethodInfoPtr_WriteLine_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005134 RID: 20788 RVA: 0x0017A130 File Offset: 0x00178330
		[CallerCount(0)]
		public unsafe virtual void WriteLine(string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TextWriter.NativeMethodInfoPtr_WriteLine_Public_Virtual_New_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06005135 RID: 20789 RVA: 0x0017A180 File Offset: 0x00178380
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1429597, XrefRangeEnd = 1429598, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void WriteLine(string format, Object arg0)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(format);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(arg0);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TextWriter.NativeMethodInfoPtr_WriteLine_Public_Virtual_New_Void_String_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005136 RID: 20790 RVA: 0x0017A1E0 File Offset: 0x001783E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1429598, XrefRangeEnd = 1429638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Task WriteAsync(char value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TextWriter.NativeMethodInfoPtr_WriteAsync_Public_Virtual_New_Task_Char_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
			}
		}

		// Token: 0x06005137 RID: 20791 RVA: 0x0017A238 File Offset: 0x00178438
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1429638, XrefRangeEnd = 1429678, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Task WriteAsync(string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TextWriter.NativeMethodInfoPtr_WriteAsync_Public_Virtual_New_Task_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
			}
		}

		// Token: 0x06005138 RID: 20792 RVA: 0x0017A294 File Offset: 0x00178494
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1429678, XrefRangeEnd = 1429718, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Task WriteAsync(Il2CppStructArray<char> buffer, int index, int count)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TextWriter.NativeMethodInfoPtr_WriteAsync_Public_Virtual_New_Task_Il2CppStructArray_1_Char_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
		}

		// Token: 0x06005139 RID: 20793 RVA: 0x0017A30C File Offset: 0x0017850C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1429718, XrefRangeEnd = 1429752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Task FlushAsync()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TextWriter.NativeMethodInfoPtr_FlushAsync_Public_Virtual_New_Task_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
		}

		// Token: 0x0600513A RID: 20794 RVA: 0x0017A358 File Offset: 0x00178558
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1429754, RefRangeEnd = 1429759, XrefRangeStart = 1429752, XrefRangeEnd = 1429754, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TextWriter Synchronized(TextWriter writer)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextWriter.NativeMethodInfoPtr_Synchronized_Public_Static_TextWriter_TextWriter_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TextWriter>(intPtr3) : null;
			}
		}

		// Token: 0x0600513B RID: 20795 RVA: 0x0001CFAF File Offset: 0x0001B1AF
		public TextWriter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170014A8 RID: 5288
		// (get) Token: 0x0600513C RID: 20796 RVA: 0x0017A39C File Offset: 0x0017859C
		// (set) Token: 0x0600513D RID: 20797 RVA: 0x0001CFB8 File Offset: 0x0001B1B8
		public unsafe static TextWriter Null
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TextWriter.NativeFieldInfoPtr_Null, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextWriter>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TextWriter.NativeFieldInfoPtr_Null, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170014A9 RID: 5289
		// (get) Token: 0x0600513E RID: 20798 RVA: 0x0017A3C4 File Offset: 0x001785C4
		// (set) Token: 0x0600513F RID: 20799 RVA: 0x0001CFCA File Offset: 0x0001B1CA
		public unsafe static Il2CppStructArray<char> s_coreNewLine
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TextWriter.NativeFieldInfoPtr_s_coreNewLine, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TextWriter.NativeFieldInfoPtr_s_coreNewLine, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170014AA RID: 5290
		// (get) Token: 0x06005140 RID: 20800 RVA: 0x0017A3EC File Offset: 0x001785EC
		// (set) Token: 0x06005141 RID: 20801 RVA: 0x0001CFDC File Offset: 0x0001B1DC
		public unsafe Il2CppStructArray<char> CoreNewLine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextWriter.NativeFieldInfoPtr_CoreNewLine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextWriter.NativeFieldInfoPtr_CoreNewLine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170014AB RID: 5291
		// (get) Token: 0x06005142 RID: 20802 RVA: 0x0017A41C File Offset: 0x0017861C
		// (set) Token: 0x06005143 RID: 20803 RVA: 0x0001CFFB File Offset: 0x0001B1FB
		public unsafe string CoreNewLineStr
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextWriter.NativeFieldInfoPtr_CoreNewLineStr);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextWriter.NativeFieldInfoPtr_CoreNewLineStr), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170014AC RID: 5292
		// (get) Token: 0x06005144 RID: 20804 RVA: 0x0017A444 File Offset: 0x00178644
		// (set) Token: 0x06005145 RID: 20805 RVA: 0x0001D01A File Offset: 0x0001B21A
		public unsafe IFormatProvider _internalFormatProvider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextWriter.NativeFieldInfoPtr__internalFormatProvider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IFormatProvider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextWriter.NativeFieldInfoPtr__internalFormatProvider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400422F RID: 16943
		private static readonly IntPtr NativeFieldInfoPtr_Null;

		// Token: 0x04004230 RID: 16944
		private static readonly IntPtr NativeFieldInfoPtr_s_coreNewLine;

		// Token: 0x04004231 RID: 16945
		private static readonly IntPtr NativeFieldInfoPtr_CoreNewLine;

		// Token: 0x04004232 RID: 16946
		private static readonly IntPtr NativeFieldInfoPtr_CoreNewLineStr;

		// Token: 0x04004233 RID: 16947
		private static readonly IntPtr NativeFieldInfoPtr__internalFormatProvider;

		// Token: 0x04004234 RID: 16948
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x04004235 RID: 16949
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_IFormatProvider_0;

		// Token: 0x04004236 RID: 16950
		private static readonly IntPtr NativeMethodInfoPtr_get_FormatProvider_Public_Virtual_New_get_IFormatProvider_0;

		// Token: 0x04004237 RID: 16951
		private static readonly IntPtr NativeMethodInfoPtr_Close_Public_Virtual_New_Void_0;

		// Token: 0x04004238 RID: 16952
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0;

		// Token: 0x04004239 RID: 16953
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

		// Token: 0x0400423A RID: 16954
		private static readonly IntPtr NativeMethodInfoPtr_DisposeAsync_Public_Virtual_New_ValueTask_0;

		// Token: 0x0400423B RID: 16955
		private static readonly IntPtr NativeMethodInfoPtr_Flush_Public_Virtual_New_Void_0;

		// Token: 0x0400423C RID: 16956
		private static readonly IntPtr NativeMethodInfoPtr_get_Encoding_Public_Abstract_Virtual_New_get_Encoding_0;

		// Token: 0x0400423D RID: 16957
		private static readonly IntPtr NativeMethodInfoPtr_get_NewLine_Public_Virtual_New_get_String_0;

		// Token: 0x0400423E RID: 16958
		private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Virtual_New_Void_Char_0;

		// Token: 0x0400423F RID: 16959
		private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Virtual_New_Void_Il2CppStructArray_1_Char_0;

		// Token: 0x04004240 RID: 16960
		private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Virtual_New_Void_Il2CppStructArray_1_Char_Int32_Int32_0;

		// Token: 0x04004241 RID: 16961
		private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Virtual_New_Void_String_0;

		// Token: 0x04004242 RID: 16962
		private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Virtual_New_Void_String_Object_Object_Object_0;

		// Token: 0x04004243 RID: 16963
		private static readonly IntPtr NativeMethodInfoPtr_WriteLine_Public_Virtual_New_Void_0;

		// Token: 0x04004244 RID: 16964
		private static readonly IntPtr NativeMethodInfoPtr_WriteLine_Public_Virtual_New_Void_String_0;

		// Token: 0x04004245 RID: 16965
		private static readonly IntPtr NativeMethodInfoPtr_WriteLine_Public_Virtual_New_Void_String_Object_0;

		// Token: 0x04004246 RID: 16966
		private static readonly IntPtr NativeMethodInfoPtr_WriteAsync_Public_Virtual_New_Task_Char_0;

		// Token: 0x04004247 RID: 16967
		private static readonly IntPtr NativeMethodInfoPtr_WriteAsync_Public_Virtual_New_Task_String_0;

		// Token: 0x04004248 RID: 16968
		private static readonly IntPtr NativeMethodInfoPtr_WriteAsync_Public_Virtual_New_Task_Il2CppStructArray_1_Char_Int32_Int32_0;

		// Token: 0x04004249 RID: 16969
		private static readonly IntPtr NativeMethodInfoPtr_FlushAsync_Public_Virtual_New_Task_0;

		// Token: 0x0400424A RID: 16970
		private static readonly IntPtr NativeMethodInfoPtr_Synchronized_Public_Static_TextWriter_TextWriter_0;

		// Token: 0x02000720 RID: 1824
		[Serializable]
		public sealed class NullTextWriter : TextWriter
		{
			// Token: 0x06006108 RID: 24840 RVA: 0x001B42B8 File Offset: 0x001B24B8
			// Note: this type is marked as 'beforefieldinit'.
			static NullTextWriter()
			{
				Il2CppClassPointerStore<TextWriter.NullTextWriter>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TextWriter>.NativeClassPtr, "NullTextWriter");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TextWriter.NullTextWriter>.NativeClassPtr);
				TextWriter.NullTextWriter.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextWriter.NullTextWriter>.NativeClassPtr, 100675630);
				TextWriter.NullTextWriter.NativeMethodInfoPtr_get_Encoding_Public_Virtual_get_Encoding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextWriter.NullTextWriter>.NativeClassPtr, 100675631);
				TextWriter.NullTextWriter.NativeMethodInfoPtr_Write_Public_Virtual_Void_Il2CppStructArray_1_Char_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextWriter.NullTextWriter>.NativeClassPtr, 100675632);
				TextWriter.NullTextWriter.NativeMethodInfoPtr_Write_Public_Virtual_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextWriter.NullTextWriter>.NativeClassPtr, 100675633);
				TextWriter.NullTextWriter.NativeMethodInfoPtr_WriteLine_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextWriter.NullTextWriter>.NativeClassPtr, 100675634);
				TextWriter.NullTextWriter.NativeMethodInfoPtr_WriteLine_Public_Virtual_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextWriter.NullTextWriter>.NativeClassPtr, 100675635);
				TextWriter.NullTextWriter.NativeMethodInfoPtr_Write_Public_Virtual_Void_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextWriter.NullTextWriter>.NativeClassPtr, 100675636);
			}

			// Token: 0x06006109 RID: 24841 RVA: 0x001B4370 File Offset: 0x001B2570
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1429446, XrefRangeEnd = 1429454, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe NullTextWriter()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TextWriter.NullTextWriter>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextWriter.NullTextWriter.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001930 RID: 6448
			// (get) Token: 0x0600610A RID: 24842 RVA: 0x001B43AC File Offset: 0x001B25AC
			public unsafe override Encoding Encoding
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextWriter.NullTextWriter.NativeMethodInfoPtr_get_Encoding_Public_Virtual_get_Encoding_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Encoding>(intPtr3) : null;
				}
			}

			// Token: 0x0600610B RID: 24843 RVA: 0x001B43EC File Offset: 0x001B25EC
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextWriter.NullTextWriter.NativeMethodInfoPtr_Write_Public_Virtual_Void_Il2CppStructArray_1_Char_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600610C RID: 24844 RVA: 0x001B444C File Offset: 0x001B264C
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Write(string value)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextWriter.NullTextWriter.NativeMethodInfoPtr_Write_Public_Virtual_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600610D RID: 24845 RVA: 0x001B4490 File Offset: 0x001B2690
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void WriteLine()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextWriter.NullTextWriter.NativeMethodInfoPtr_WriteLine_Public_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600610E RID: 24846 RVA: 0x001B44C4 File Offset: 0x001B26C4
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void WriteLine(string value)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextWriter.NullTextWriter.NativeMethodInfoPtr_WriteLine_Public_Virtual_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600610F RID: 24847 RVA: 0x001B4508 File Offset: 0x001B2708
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Write(char value)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextWriter.NullTextWriter.NativeMethodInfoPtr_Write_Public_Virtual_Void_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06006110 RID: 24848 RVA: 0x00023D68 File Offset: 0x00021F68
			public NullTextWriter(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04004E8E RID: 20110
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

			// Token: 0x04004E8F RID: 20111
			private static readonly IntPtr NativeMethodInfoPtr_get_Encoding_Public_Virtual_get_Encoding_0;

			// Token: 0x04004E90 RID: 20112
			private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Virtual_Void_Il2CppStructArray_1_Char_Int32_Int32_0;

			// Token: 0x04004E91 RID: 20113
			private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Virtual_Void_String_0;

			// Token: 0x04004E92 RID: 20114
			private static readonly IntPtr NativeMethodInfoPtr_WriteLine_Public_Virtual_Void_0;

			// Token: 0x04004E93 RID: 20115
			private static readonly IntPtr NativeMethodInfoPtr_WriteLine_Public_Virtual_Void_String_0;

			// Token: 0x04004E94 RID: 20116
			private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Virtual_Void_Char_0;
		}

		// Token: 0x02000721 RID: 1825
		[Serializable]
		public sealed class SyncTextWriter : TextWriter
		{
			// Token: 0x06006111 RID: 24849 RVA: 0x001B4548 File Offset: 0x001B2748
			// Note: this type is marked as 'beforefieldinit'.
			static SyncTextWriter()
			{
				Il2CppClassPointerStore<TextWriter.SyncTextWriter>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TextWriter>.NativeClassPtr, "SyncTextWriter");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TextWriter.SyncTextWriter>.NativeClassPtr);
				TextWriter.SyncTextWriter.NativeFieldInfoPtr__out = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextWriter.SyncTextWriter>.NativeClassPtr, "_out");
				TextWriter.SyncTextWriter.NativeMethodInfoPtr__ctor_Internal_Void_TextWriter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextWriter.SyncTextWriter>.NativeClassPtr, 100675637);
				TextWriter.SyncTextWriter.NativeMethodInfoPtr_get_Encoding_Public_Virtual_get_Encoding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextWriter.SyncTextWriter>.NativeClassPtr, 100675638);
				TextWriter.SyncTextWriter.NativeMethodInfoPtr_get_FormatProvider_Public_Virtual_get_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextWriter.SyncTextWriter>.NativeClassPtr, 100675639);
				TextWriter.SyncTextWriter.NativeMethodInfoPtr_get_NewLine_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextWriter.SyncTextWriter>.NativeClassPtr, 100675640);
				TextWriter.SyncTextWriter.NativeMethodInfoPtr_Close_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextWriter.SyncTextWriter>.NativeClassPtr, 100675641);
				TextWriter.SyncTextWriter.NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextWriter.SyncTextWriter>.NativeClassPtr, 100675642);
				TextWriter.SyncTextWriter.NativeMethodInfoPtr_Flush_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextWriter.SyncTextWriter>.NativeClassPtr, 100675643);
				TextWriter.SyncTextWriter.NativeMethodInfoPtr_Write_Public_Virtual_Void_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextWriter.SyncTextWriter>.NativeClassPtr, 100675644);
				TextWriter.SyncTextWriter.NativeMethodInfoPtr_Write_Public_Virtual_Void_Il2CppStructArray_1_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextWriter.SyncTextWriter>.NativeClassPtr, 100675645);
				TextWriter.SyncTextWriter.NativeMethodInfoPtr_Write_Public_Virtual_Void_Il2CppStructArray_1_Char_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextWriter.SyncTextWriter>.NativeClassPtr, 100675646);
				TextWriter.SyncTextWriter.NativeMethodInfoPtr_Write_Public_Virtual_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextWriter.SyncTextWriter>.NativeClassPtr, 100675647);
				TextWriter.SyncTextWriter.NativeMethodInfoPtr_Write_Public_Virtual_Void_String_Object_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextWriter.SyncTextWriter>.NativeClassPtr, 100675648);
				TextWriter.SyncTextWriter.NativeMethodInfoPtr_WriteLine_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextWriter.SyncTextWriter>.NativeClassPtr, 100675649);
				TextWriter.SyncTextWriter.NativeMethodInfoPtr_WriteLine_Public_Virtual_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextWriter.SyncTextWriter>.NativeClassPtr, 100675650);
				TextWriter.SyncTextWriter.NativeMethodInfoPtr_WriteLine_Public_Virtual_Void_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextWriter.SyncTextWriter>.NativeClassPtr, 100675651);
				TextWriter.SyncTextWriter.NativeMethodInfoPtr_WriteAsync_Public_Virtual_Task_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextWriter.SyncTextWriter>.NativeClassPtr, 100675652);
				TextWriter.SyncTextWriter.NativeMethodInfoPtr_WriteAsync_Public_Virtual_Task_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextWriter.SyncTextWriter>.NativeClassPtr, 100675653);
				TextWriter.SyncTextWriter.NativeMethodInfoPtr_WriteAsync_Public_Virtual_Task_Il2CppStructArray_1_Char_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextWriter.SyncTextWriter>.NativeClassPtr, 100675654);
				TextWriter.SyncTextWriter.NativeMethodInfoPtr_FlushAsync_Public_Virtual_Task_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextWriter.SyncTextWriter>.NativeClassPtr, 100675655);
			}

			// Token: 0x06006112 RID: 24850 RVA: 0x001B4704 File Offset: 0x001B2904
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1429454, XrefRangeEnd = 1429460, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SyncTextWriter(TextWriter t)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TextWriter.SyncTextWriter>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextWriter.SyncTextWriter.NativeMethodInfoPtr__ctor_Internal_Void_TextWriter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x17001932 RID: 6450
			// (get) Token: 0x06006113 RID: 24851 RVA: 0x001B4750 File Offset: 0x001B2950
			public unsafe override Encoding Encoding
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextWriter.SyncTextWriter.NativeMethodInfoPtr_get_Encoding_Public_Virtual_get_Encoding_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Encoding>(intPtr3) : null;
				}
			}

			// Token: 0x17001933 RID: 6451
			// (get) Token: 0x06006114 RID: 24852 RVA: 0x001B4790 File Offset: 0x001B2990
			public unsafe override IFormatProvider FormatProvider
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextWriter.SyncTextWriter.NativeMethodInfoPtr_get_FormatProvider_Public_Virtual_get_IFormatProvider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IFormatProvider>(intPtr3) : null;
				}
			}

			// Token: 0x17001934 RID: 6452
			// (get) Token: 0x06006115 RID: 24853 RVA: 0x001B47D0 File Offset: 0x001B29D0
			public unsafe override string NewLine
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1429460, XrefRangeEnd = 1429461, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextWriter.SyncTextWriter.NativeMethodInfoPtr_get_NewLine_Public_Virtual_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x06006116 RID: 24854 RVA: 0x001B4808 File Offset: 0x001B2A08
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1429461, XrefRangeEnd = 1429462, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Close()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextWriter.SyncTextWriter.NativeMethodInfoPtr_Close_Public_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06006117 RID: 24855 RVA: 0x001B483C File Offset: 0x001B2A3C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1429462, XrefRangeEnd = 1429465, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Dispose(bool disposing)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref disposing;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextWriter.SyncTextWriter.NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06006118 RID: 24856 RVA: 0x001B487C File Offset: 0x001B2A7C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1429465, XrefRangeEnd = 1429466, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Flush()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextWriter.SyncTextWriter.NativeMethodInfoPtr_Flush_Public_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06006119 RID: 24857 RVA: 0x001B48B0 File Offset: 0x001B2AB0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Write(char value)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextWriter.SyncTextWriter.NativeMethodInfoPtr_Write_Public_Virtual_Void_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600611A RID: 24858 RVA: 0x001B48F0 File Offset: 0x001B2AF0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Write(Il2CppStructArray<char> buffer)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextWriter.SyncTextWriter.NativeMethodInfoPtr_Write_Public_Virtual_Void_Il2CppStructArray_1_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600611B RID: 24859 RVA: 0x001B4934 File Offset: 0x001B2B34
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1429466, XrefRangeEnd = 1429467, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextWriter.SyncTextWriter.NativeMethodInfoPtr_Write_Public_Virtual_Void_Il2CppStructArray_1_Char_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600611C RID: 24860 RVA: 0x001B4994 File Offset: 0x001B2B94
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Write(string value)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextWriter.SyncTextWriter.NativeMethodInfoPtr_Write_Public_Virtual_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600611D RID: 24861 RVA: 0x001B49D8 File Offset: 0x001B2BD8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1429467, XrefRangeEnd = 1429468, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Write(string format, Object arg0, Object arg1, Object arg2)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(format);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(arg0);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(arg1);
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(arg2);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextWriter.SyncTextWriter.NativeMethodInfoPtr_Write_Public_Virtual_Void_String_Object_Object_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600611E RID: 24862 RVA: 0x001B4A54 File Offset: 0x001B2C54
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1429468, XrefRangeEnd = 1429469, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void WriteLine()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextWriter.SyncTextWriter.NativeMethodInfoPtr_WriteLine_Public_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600611F RID: 24863 RVA: 0x001B4A88 File Offset: 0x001B2C88
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void WriteLine(string value)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextWriter.SyncTextWriter.NativeMethodInfoPtr_WriteLine_Public_Virtual_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06006120 RID: 24864 RVA: 0x001B4ACC File Offset: 0x001B2CCC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1429469, XrefRangeEnd = 1429470, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void WriteLine(string format, Object arg0)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(format);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(arg0);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextWriter.SyncTextWriter.NativeMethodInfoPtr_WriteLine_Public_Virtual_Void_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06006121 RID: 24865 RVA: 0x001B4B20 File Offset: 0x001B2D20
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1429470, XrefRangeEnd = 1429478, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override Task WriteAsync(char value)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextWriter.SyncTextWriter.NativeMethodInfoPtr_WriteAsync_Public_Virtual_Task_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
				}
			}

			// Token: 0x06006122 RID: 24866 RVA: 0x001B4B6C File Offset: 0x001B2D6C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1429478, XrefRangeEnd = 1429486, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override Task WriteAsync(string value)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextWriter.SyncTextWriter.NativeMethodInfoPtr_WriteAsync_Public_Virtual_Task_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
				}
			}

			// Token: 0x06006123 RID: 24867 RVA: 0x001B4BBC File Offset: 0x001B2DBC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1429486, XrefRangeEnd = 1429494, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override Task WriteAsync(Il2CppStructArray<char> buffer, int index, int count)
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextWriter.SyncTextWriter.NativeMethodInfoPtr_WriteAsync_Public_Virtual_Task_Il2CppStructArray_1_Char_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
			}

			// Token: 0x06006124 RID: 24868 RVA: 0x001B4C28 File Offset: 0x001B2E28
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1429494, XrefRangeEnd = 1429502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override Task FlushAsync()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextWriter.SyncTextWriter.NativeMethodInfoPtr_FlushAsync_Public_Virtual_Task_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
			}

			// Token: 0x06006125 RID: 24869 RVA: 0x00023D71 File Offset: 0x00021F71
			public SyncTextWriter(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001931 RID: 6449
			// (get) Token: 0x06006126 RID: 24870 RVA: 0x001B4C68 File Offset: 0x001B2E68
			// (set) Token: 0x06006127 RID: 24871 RVA: 0x00023D7A File Offset: 0x00021F7A
			public unsafe TextWriter _out
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextWriter.SyncTextWriter.NativeFieldInfoPtr__out);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextWriter>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextWriter.SyncTextWriter.NativeFieldInfoPtr__out), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04004E95 RID: 20117
			private static readonly IntPtr NativeFieldInfoPtr__out;

			// Token: 0x04004E96 RID: 20118
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_TextWriter_0;

			// Token: 0x04004E97 RID: 20119
			private static readonly IntPtr NativeMethodInfoPtr_get_Encoding_Public_Virtual_get_Encoding_0;

			// Token: 0x04004E98 RID: 20120
			private static readonly IntPtr NativeMethodInfoPtr_get_FormatProvider_Public_Virtual_get_IFormatProvider_0;

			// Token: 0x04004E99 RID: 20121
			private static readonly IntPtr NativeMethodInfoPtr_get_NewLine_Public_Virtual_get_String_0;

			// Token: 0x04004E9A RID: 20122
			private static readonly IntPtr NativeMethodInfoPtr_Close_Public_Virtual_Void_0;

			// Token: 0x04004E9B RID: 20123
			private static readonly IntPtr NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0;

			// Token: 0x04004E9C RID: 20124
			private static readonly IntPtr NativeMethodInfoPtr_Flush_Public_Virtual_Void_0;

			// Token: 0x04004E9D RID: 20125
			private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Virtual_Void_Char_0;

			// Token: 0x04004E9E RID: 20126
			private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Virtual_Void_Il2CppStructArray_1_Char_0;

			// Token: 0x04004E9F RID: 20127
			private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Virtual_Void_Il2CppStructArray_1_Char_Int32_Int32_0;

			// Token: 0x04004EA0 RID: 20128
			private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Virtual_Void_String_0;

			// Token: 0x04004EA1 RID: 20129
			private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Virtual_Void_String_Object_Object_Object_0;

			// Token: 0x04004EA2 RID: 20130
			private static readonly IntPtr NativeMethodInfoPtr_WriteLine_Public_Virtual_Void_0;

			// Token: 0x04004EA3 RID: 20131
			private static readonly IntPtr NativeMethodInfoPtr_WriteLine_Public_Virtual_Void_String_0;

			// Token: 0x04004EA4 RID: 20132
			private static readonly IntPtr NativeMethodInfoPtr_WriteLine_Public_Virtual_Void_String_Object_0;

			// Token: 0x04004EA5 RID: 20133
			private static readonly IntPtr NativeMethodInfoPtr_WriteAsync_Public_Virtual_Task_Char_0;

			// Token: 0x04004EA6 RID: 20134
			private static readonly IntPtr NativeMethodInfoPtr_WriteAsync_Public_Virtual_Task_String_0;

			// Token: 0x04004EA7 RID: 20135
			private static readonly IntPtr NativeMethodInfoPtr_WriteAsync_Public_Virtual_Task_Il2CppStructArray_1_Char_Int32_Int32_0;

			// Token: 0x04004EA8 RID: 20136
			private static readonly IntPtr NativeMethodInfoPtr_FlushAsync_Public_Virtual_Task_0;
		}

		// Token: 0x02000722 RID: 1826
		[ObfuscatedName("System.IO.TextWriter+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06006128 RID: 24872 RVA: 0x001B4C98 File Offset: 0x001B2E98
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<TextWriter.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TextWriter>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TextWriter.__c>.NativeClassPtr);
				TextWriter.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextWriter.__c>.NativeClassPtr, "<>9");
				TextWriter.__c.NativeFieldInfoPtr___9__56_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextWriter.__c>.NativeClassPtr, "<>9__56_0");
				TextWriter.__c.NativeFieldInfoPtr___9__57_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextWriter.__c>.NativeClassPtr, "<>9__57_0");
				TextWriter.__c.NativeFieldInfoPtr___9__59_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextWriter.__c>.NativeClassPtr, "<>9__59_0");
				TextWriter.__c.NativeFieldInfoPtr___9__67_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextWriter.__c>.NativeClassPtr, "<>9__67_0");
				TextWriter.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextWriter.__c>.NativeClassPtr, 100675657);
				TextWriter.__c.NativeMethodInfoPtr__WriteAsync_b__56_0_Internal_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextWriter.__c>.NativeClassPtr, 100675658);
				TextWriter.__c.NativeMethodInfoPtr__WriteAsync_b__57_0_Internal_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextWriter.__c>.NativeClassPtr, 100675659);
				TextWriter.__c.NativeMethodInfoPtr__WriteAsync_b__59_0_Internal_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextWriter.__c>.NativeClassPtr, 100675660);
				TextWriter.__c.NativeMethodInfoPtr__FlushAsync_b__67_0_Internal_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextWriter.__c>.NativeClassPtr, 100675661);
			}

			// Token: 0x06006129 RID: 24873 RVA: 0x001B4D8C File Offset: 0x001B2F8C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TextWriter.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextWriter.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600612A RID: 24874 RVA: 0x001B4DC8 File Offset: 0x001B2FC8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1429502, XrefRangeEnd = 1429508, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _WriteAsync_b__56_0(Object state)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(state);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextWriter.__c.NativeMethodInfoPtr__WriteAsync_b__56_0_Internal_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600612B RID: 24875 RVA: 0x001B4E0C File Offset: 0x001B300C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1429508, XrefRangeEnd = 1429514, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _WriteAsync_b__57_0(Object state)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(state);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextWriter.__c.NativeMethodInfoPtr__WriteAsync_b__57_0_Internal_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600612C RID: 24876 RVA: 0x001B4E50 File Offset: 0x001B3050
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1429514, XrefRangeEnd = 1429520, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _WriteAsync_b__59_0(Object state)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(state);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextWriter.__c.NativeMethodInfoPtr__WriteAsync_b__59_0_Internal_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600612D RID: 24877 RVA: 0x001B4E94 File Offset: 0x001B3094
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1429520, XrefRangeEnd = 1429524, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _FlushAsync_b__67_0(Object state)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(state);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextWriter.__c.NativeMethodInfoPtr__FlushAsync_b__67_0_Internal_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600612E RID: 24878 RVA: 0x00023D99 File Offset: 0x00021F99
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001935 RID: 6453
			// (get) Token: 0x0600612F RID: 24879 RVA: 0x001B4ED8 File Offset: 0x001B30D8
			// (set) Token: 0x06006130 RID: 24880 RVA: 0x00023DA2 File Offset: 0x00021FA2
			public unsafe static TextWriter.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(TextWriter.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextWriter.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(TextWriter.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001936 RID: 6454
			// (get) Token: 0x06006131 RID: 24881 RVA: 0x001B4F00 File Offset: 0x001B3100
			// (set) Token: 0x06006132 RID: 24882 RVA: 0x00023DB4 File Offset: 0x00021FB4
			public unsafe static Action<Object> __9__56_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(TextWriter.__c.NativeFieldInfoPtr___9__56_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Object>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(TextWriter.__c.NativeFieldInfoPtr___9__56_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001937 RID: 6455
			// (get) Token: 0x06006133 RID: 24883 RVA: 0x001B4F28 File Offset: 0x001B3128
			// (set) Token: 0x06006134 RID: 24884 RVA: 0x00023DC6 File Offset: 0x00021FC6
			public unsafe static Action<Object> __9__57_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(TextWriter.__c.NativeFieldInfoPtr___9__57_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Object>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(TextWriter.__c.NativeFieldInfoPtr___9__57_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001938 RID: 6456
			// (get) Token: 0x06006135 RID: 24885 RVA: 0x001B4F50 File Offset: 0x001B3150
			// (set) Token: 0x06006136 RID: 24886 RVA: 0x00023DD8 File Offset: 0x00021FD8
			public unsafe static Action<Object> __9__59_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(TextWriter.__c.NativeFieldInfoPtr___9__59_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Object>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(TextWriter.__c.NativeFieldInfoPtr___9__59_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001939 RID: 6457
			// (get) Token: 0x06006137 RID: 24887 RVA: 0x001B4F78 File Offset: 0x001B3178
			// (set) Token: 0x06006138 RID: 24888 RVA: 0x00023DEA File Offset: 0x00021FEA
			public unsafe static Action<Object> __9__67_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(TextWriter.__c.NativeFieldInfoPtr___9__67_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Object>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(TextWriter.__c.NativeFieldInfoPtr___9__67_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04004EA9 RID: 20137
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04004EAA RID: 20138
			private static readonly IntPtr NativeFieldInfoPtr___9__56_0;

			// Token: 0x04004EAB RID: 20139
			private static readonly IntPtr NativeFieldInfoPtr___9__57_0;

			// Token: 0x04004EAC RID: 20140
			private static readonly IntPtr NativeFieldInfoPtr___9__59_0;

			// Token: 0x04004EAD RID: 20141
			private static readonly IntPtr NativeFieldInfoPtr___9__67_0;

			// Token: 0x04004EAE RID: 20142
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04004EAF RID: 20143
			private static readonly IntPtr NativeMethodInfoPtr__WriteAsync_b__56_0_Internal_Void_Object_0;

			// Token: 0x04004EB0 RID: 20144
			private static readonly IntPtr NativeMethodInfoPtr__WriteAsync_b__57_0_Internal_Void_Object_0;

			// Token: 0x04004EB1 RID: 20145
			private static readonly IntPtr NativeMethodInfoPtr__WriteAsync_b__59_0_Internal_Void_Object_0;

			// Token: 0x04004EB2 RID: 20146
			private static readonly IntPtr NativeMethodInfoPtr__FlushAsync_b__67_0_Internal_Void_Object_0;
		}
	}
}
