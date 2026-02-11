using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Text;
using Il2CppSystem.Threading.Tasks;

namespace Il2CppSystem.IO
{
	// Token: 0x02000541 RID: 1345
	[Serializable]
	public class BinaryWriter : Object
	{
		// Token: 0x06005287 RID: 21127 RVA: 0x001806A8 File Offset: 0x0017E8A8
		// Note: this type is marked as 'beforefieldinit'.
		static BinaryWriter()
		{
			Il2CppClassPointerStore<BinaryWriter>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.IO", "BinaryWriter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BinaryWriter>.NativeClassPtr);
			BinaryWriter.NativeFieldInfoPtr_Null = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinaryWriter>.NativeClassPtr, "Null");
			BinaryWriter.NativeFieldInfoPtr_OutStream = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinaryWriter>.NativeClassPtr, "OutStream");
			BinaryWriter.NativeFieldInfoPtr__buffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinaryWriter>.NativeClassPtr, "_buffer");
			BinaryWriter.NativeFieldInfoPtr__encoding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinaryWriter>.NativeClassPtr, "_encoding");
			BinaryWriter.NativeFieldInfoPtr__encoder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinaryWriter>.NativeClassPtr, "_encoder");
			BinaryWriter.NativeFieldInfoPtr__leaveOpen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinaryWriter>.NativeClassPtr, "_leaveOpen");
			BinaryWriter.NativeFieldInfoPtr__largeByteBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinaryWriter>.NativeClassPtr, "_largeByteBuffer");
			BinaryWriter.NativeFieldInfoPtr__maxChars = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinaryWriter>.NativeClassPtr, "_maxChars");
			BinaryWriter.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryWriter>.NativeClassPtr, 100675951);
			BinaryWriter.NativeMethodInfoPtr__ctor_Public_Void_Stream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryWriter>.NativeClassPtr, 100675952);
			BinaryWriter.NativeMethodInfoPtr__ctor_Public_Void_Stream_Encoding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryWriter>.NativeClassPtr, 100675953);
			BinaryWriter.NativeMethodInfoPtr__ctor_Public_Void_Stream_Encoding_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryWriter>.NativeClassPtr, 100675954);
			BinaryWriter.NativeMethodInfoPtr_Close_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryWriter>.NativeClassPtr, 100675955);
			BinaryWriter.NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryWriter>.NativeClassPtr, 100675956);
			BinaryWriter.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryWriter>.NativeClassPtr, 100675957);
			BinaryWriter.NativeMethodInfoPtr_Flush_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryWriter>.NativeClassPtr, 100675958);
			BinaryWriter.NativeMethodInfoPtr_DisposeAsync_Public_Virtual_New_ValueTask_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryWriter>.NativeClassPtr, 100675959);
			BinaryWriter.NativeMethodInfoPtr_Write_Public_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryWriter>.NativeClassPtr, 100675960);
			BinaryWriter.NativeMethodInfoPtr_Write_Public_Virtual_New_Void_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryWriter>.NativeClassPtr, 100675961);
			BinaryWriter.NativeMethodInfoPtr_Write_Public_Virtual_New_Void_SByte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryWriter>.NativeClassPtr, 100675962);
			BinaryWriter.NativeMethodInfoPtr_Write_Public_Virtual_New_Void_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryWriter>.NativeClassPtr, 100675963);
			BinaryWriter.NativeMethodInfoPtr_Write_Public_Virtual_New_Void_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryWriter>.NativeClassPtr, 100675964);
			BinaryWriter.NativeMethodInfoPtr_Write_Public_Virtual_New_Void_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryWriter>.NativeClassPtr, 100675965);
			BinaryWriter.NativeMethodInfoPtr_Write_Public_Virtual_New_Void_Il2CppStructArray_1_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryWriter>.NativeClassPtr, 100675966);
			BinaryWriter.NativeMethodInfoPtr_Write_Public_Virtual_New_Void_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryWriter>.NativeClassPtr, 100675967);
			BinaryWriter.NativeMethodInfoPtr_Write_Public_Virtual_New_Void_Int16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryWriter>.NativeClassPtr, 100675968);
			BinaryWriter.NativeMethodInfoPtr_Write_Public_Virtual_New_Void_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryWriter>.NativeClassPtr, 100675969);
			BinaryWriter.NativeMethodInfoPtr_Write_Public_Virtual_New_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryWriter>.NativeClassPtr, 100675970);
			BinaryWriter.NativeMethodInfoPtr_Write_Public_Virtual_New_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryWriter>.NativeClassPtr, 100675971);
			BinaryWriter.NativeMethodInfoPtr_Write_Public_Virtual_New_Void_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryWriter>.NativeClassPtr, 100675972);
			BinaryWriter.NativeMethodInfoPtr_Write_Public_Virtual_New_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryWriter>.NativeClassPtr, 100675973);
			BinaryWriter.NativeMethodInfoPtr_Write_Public_Virtual_New_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryWriter>.NativeClassPtr, 100675974);
			BinaryWriter.NativeMethodInfoPtr_Write_Public_Virtual_New_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryWriter>.NativeClassPtr, 100675975);
			BinaryWriter.NativeMethodInfoPtr_Write7BitEncodedInt_Protected_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryWriter>.NativeClassPtr, 100675976);
		}

		// Token: 0x06005288 RID: 21128 RVA: 0x00180980 File Offset: 0x0017EB80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1432230, XrefRangeEnd = 1432247, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BinaryWriter()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BinaryWriter>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryWriter.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005289 RID: 21129 RVA: 0x001809BC File Offset: 0x0017EBBC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1432252, RefRangeEnd = 1432253, XrefRangeStart = 1432247, XrefRangeEnd = 1432252, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BinaryWriter(Stream output)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BinaryWriter>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(output);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryWriter.NativeMethodInfoPtr__ctor_Public_Void_Stream_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600528A RID: 21130 RVA: 0x00180A08 File Offset: 0x0017EC08
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1432254, RefRangeEnd = 1432257, XrefRangeStart = 1432253, XrefRangeEnd = 1432254, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BinaryWriter(Stream output, Encoding encoding)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BinaryWriter>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(output);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(encoding);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryWriter.NativeMethodInfoPtr__ctor_Public_Void_Stream_Encoding_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600528B RID: 21131 RVA: 0x00180A68 File Offset: 0x0017EC68
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1432265, RefRangeEnd = 1432267, XrefRangeStart = 1432257, XrefRangeEnd = 1432265, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BinaryWriter(Stream output, Encoding encoding, bool leaveOpen)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BinaryWriter>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(output);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(encoding);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref leaveOpen;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryWriter.NativeMethodInfoPtr__ctor_Public_Void_Stream_Encoding_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600528C RID: 21132 RVA: 0x00180AD4 File Offset: 0x0017ECD4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 875040, RefRangeEnd = 875041, XrefRangeStart = 875040, XrefRangeEnd = 875041, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BinaryWriter.NativeMethodInfoPtr_Close_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600528D RID: 21133 RVA: 0x00180B10 File Offset: 0x0017ED10
		[CallerCount(0)]
		public unsafe virtual void Dispose(bool disposing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref disposing;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BinaryWriter.NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600528E RID: 21134 RVA: 0x00180B5C File Offset: 0x0017ED5C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 875040, RefRangeEnd = 875041, XrefRangeStart = 875040, XrefRangeEnd = 875041, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryWriter.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600528F RID: 21135 RVA: 0x00180B90 File Offset: 0x0017ED90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1432267, XrefRangeEnd = 1432268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Flush()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BinaryWriter.NativeMethodInfoPtr_Flush_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005290 RID: 21136 RVA: 0x00180BCC File Offset: 0x0017EDCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1432268, XrefRangeEnd = 1432290, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual ValueTask DisposeAsync()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BinaryWriter.NativeMethodInfoPtr_DisposeAsync_Public_Virtual_New_ValueTask_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new ValueTask(intPtr);
		}

		// Token: 0x06005291 RID: 21137 RVA: 0x00180C10 File Offset: 0x0017EE10
		[CallerCount(0)]
		public unsafe virtual void Write(bool value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BinaryWriter.NativeMethodInfoPtr_Write_Public_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06005292 RID: 21138 RVA: 0x00180C5C File Offset: 0x0017EE5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1432290, XrefRangeEnd = 1432291, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Write(byte value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BinaryWriter.NativeMethodInfoPtr_Write_Public_Virtual_New_Void_Byte_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06005293 RID: 21139 RVA: 0x00180CA8 File Offset: 0x0017EEA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Write(sbyte value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BinaryWriter.NativeMethodInfoPtr_Write_Public_Virtual_New_Void_SByte_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06005294 RID: 21140 RVA: 0x00180CF4 File Offset: 0x0017EEF4
		[CallerCount(0)]
		public unsafe virtual void Write(Il2CppStructArray<byte> buffer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BinaryWriter.NativeMethodInfoPtr_Write_Public_Virtual_New_Void_Il2CppStructArray_1_Byte_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06005295 RID: 21141 RVA: 0x00180D44 File Offset: 0x0017EF44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1432291, XrefRangeEnd = 1432292, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Write(Il2CppStructArray<byte> buffer, int index, int count)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BinaryWriter.NativeMethodInfoPtr_Write_Public_Virtual_New_Void_Il2CppStructArray_1_Byte_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005296 RID: 21142 RVA: 0x00180DB0 File Offset: 0x0017EFB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1432292, XrefRangeEnd = 1432297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Write(char ch)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ch;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BinaryWriter.NativeMethodInfoPtr_Write_Public_Virtual_New_Void_Char_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06005297 RID: 21143 RVA: 0x00180DFC File Offset: 0x0017EFFC
		[CallerCount(0)]
		public unsafe virtual void Write(Il2CppStructArray<char> chars)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(chars);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BinaryWriter.NativeMethodInfoPtr_Write_Public_Virtual_New_Void_Il2CppStructArray_1_Char_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06005298 RID: 21144 RVA: 0x00180E4C File Offset: 0x0017F04C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1432297, XrefRangeEnd = 1432298, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Write(double value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BinaryWriter.NativeMethodInfoPtr_Write_Public_Virtual_New_Void_Double_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06005299 RID: 21145 RVA: 0x00180E98 File Offset: 0x0017F098
		[CallerCount(0)]
		public unsafe virtual void Write(short value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BinaryWriter.NativeMethodInfoPtr_Write_Public_Virtual_New_Void_Int16_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600529A RID: 21146 RVA: 0x00180EE4 File Offset: 0x0017F0E4
		[CallerCount(0)]
		public unsafe virtual void Write(ushort value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BinaryWriter.NativeMethodInfoPtr_Write_Public_Virtual_New_Void_UInt16_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600529B RID: 21147 RVA: 0x00180F30 File Offset: 0x0017F130
		[CallerCount(0)]
		public unsafe virtual void Write(int value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BinaryWriter.NativeMethodInfoPtr_Write_Public_Virtual_New_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600529C RID: 21148 RVA: 0x00180F7C File Offset: 0x0017F17C
		[CallerCount(0)]
		public unsafe virtual void Write(uint value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BinaryWriter.NativeMethodInfoPtr_Write_Public_Virtual_New_Void_UInt32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600529D RID: 21149 RVA: 0x00180FC8 File Offset: 0x0017F1C8
		[CallerCount(0)]
		public unsafe virtual void Write(long value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BinaryWriter.NativeMethodInfoPtr_Write_Public_Virtual_New_Void_Int64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600529E RID: 21150 RVA: 0x00181014 File Offset: 0x0017F214
		[CallerCount(0)]
		public unsafe virtual void Write(ulong value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BinaryWriter.NativeMethodInfoPtr_Write_Public_Virtual_New_Void_UInt64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600529F RID: 21151 RVA: 0x00181060 File Offset: 0x0017F260
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1432298, XrefRangeEnd = 1432299, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Write(float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BinaryWriter.NativeMethodInfoPtr_Write_Public_Virtual_New_Void_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060052A0 RID: 21152 RVA: 0x001810AC File Offset: 0x0017F2AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1432299, XrefRangeEnd = 1432309, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Write(string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BinaryWriter.NativeMethodInfoPtr_Write_Public_Virtual_New_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060052A1 RID: 21153 RVA: 0x001810FC File Offset: 0x0017F2FC
		[CallerCount(0)]
		public unsafe void Write7BitEncodedInt(int value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryWriter.NativeMethodInfoPtr_Write7BitEncodedInt_Protected_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060052A2 RID: 21154 RVA: 0x0001D49C File Offset: 0x0001B69C
		public BinaryWriter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170014F8 RID: 5368
		// (get) Token: 0x060052A3 RID: 21155 RVA: 0x0018113C File Offset: 0x0017F33C
		// (set) Token: 0x060052A4 RID: 21156 RVA: 0x0001D4A5 File Offset: 0x0001B6A5
		public unsafe static BinaryWriter Null
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BinaryWriter.NativeFieldInfoPtr_Null, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BinaryWriter>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BinaryWriter.NativeFieldInfoPtr_Null, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170014F9 RID: 5369
		// (get) Token: 0x060052A5 RID: 21157 RVA: 0x00181164 File Offset: 0x0017F364
		// (set) Token: 0x060052A6 RID: 21158 RVA: 0x0001D4B7 File Offset: 0x0001B6B7
		public unsafe Stream OutStream
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryWriter.NativeFieldInfoPtr_OutStream);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Stream>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryWriter.NativeFieldInfoPtr_OutStream), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170014FA RID: 5370
		// (get) Token: 0x060052A7 RID: 21159 RVA: 0x00181194 File Offset: 0x0017F394
		// (set) Token: 0x060052A8 RID: 21160 RVA: 0x0001D4D6 File Offset: 0x0001B6D6
		public unsafe Il2CppStructArray<byte> _buffer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryWriter.NativeFieldInfoPtr__buffer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryWriter.NativeFieldInfoPtr__buffer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170014FB RID: 5371
		// (get) Token: 0x060052A9 RID: 21161 RVA: 0x001811C4 File Offset: 0x0017F3C4
		// (set) Token: 0x060052AA RID: 21162 RVA: 0x0001D4F5 File Offset: 0x0001B6F5
		public unsafe Encoding _encoding
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryWriter.NativeFieldInfoPtr__encoding);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Encoding>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryWriter.NativeFieldInfoPtr__encoding), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170014FC RID: 5372
		// (get) Token: 0x060052AB RID: 21163 RVA: 0x001811F4 File Offset: 0x0017F3F4
		// (set) Token: 0x060052AC RID: 21164 RVA: 0x0001D514 File Offset: 0x0001B714
		public unsafe Encoder _encoder
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryWriter.NativeFieldInfoPtr__encoder);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Encoder>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryWriter.NativeFieldInfoPtr__encoder), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170014FD RID: 5373
		// (get) Token: 0x060052AD RID: 21165 RVA: 0x00181224 File Offset: 0x0017F424
		// (set) Token: 0x060052AE RID: 21166 RVA: 0x0001D533 File Offset: 0x0001B733
		public unsafe bool _leaveOpen
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryWriter.NativeFieldInfoPtr__leaveOpen);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryWriter.NativeFieldInfoPtr__leaveOpen)) = value;
			}
		}

		// Token: 0x170014FE RID: 5374
		// (get) Token: 0x060052AF RID: 21167 RVA: 0x0018124C File Offset: 0x0017F44C
		// (set) Token: 0x060052B0 RID: 21168 RVA: 0x0001D54E File Offset: 0x0001B74E
		public unsafe Il2CppStructArray<byte> _largeByteBuffer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryWriter.NativeFieldInfoPtr__largeByteBuffer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryWriter.NativeFieldInfoPtr__largeByteBuffer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170014FF RID: 5375
		// (get) Token: 0x060052B1 RID: 21169 RVA: 0x0018127C File Offset: 0x0017F47C
		// (set) Token: 0x060052B2 RID: 21170 RVA: 0x0001D56D File Offset: 0x0001B76D
		public unsafe int _maxChars
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryWriter.NativeFieldInfoPtr__maxChars);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryWriter.NativeFieldInfoPtr__maxChars)) = value;
			}
		}

		// Token: 0x0400436E RID: 17262
		private static readonly IntPtr NativeFieldInfoPtr_Null;

		// Token: 0x0400436F RID: 17263
		private static readonly IntPtr NativeFieldInfoPtr_OutStream;

		// Token: 0x04004370 RID: 17264
		private static readonly IntPtr NativeFieldInfoPtr__buffer;

		// Token: 0x04004371 RID: 17265
		private static readonly IntPtr NativeFieldInfoPtr__encoding;

		// Token: 0x04004372 RID: 17266
		private static readonly IntPtr NativeFieldInfoPtr__encoder;

		// Token: 0x04004373 RID: 17267
		private static readonly IntPtr NativeFieldInfoPtr__leaveOpen;

		// Token: 0x04004374 RID: 17268
		private static readonly IntPtr NativeFieldInfoPtr__largeByteBuffer;

		// Token: 0x04004375 RID: 17269
		private static readonly IntPtr NativeFieldInfoPtr__maxChars;

		// Token: 0x04004376 RID: 17270
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x04004377 RID: 17271
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Stream_0;

		// Token: 0x04004378 RID: 17272
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Stream_Encoding_0;

		// Token: 0x04004379 RID: 17273
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Stream_Encoding_Boolean_0;

		// Token: 0x0400437A RID: 17274
		private static readonly IntPtr NativeMethodInfoPtr_Close_Public_Virtual_New_Void_0;

		// Token: 0x0400437B RID: 17275
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0;

		// Token: 0x0400437C RID: 17276
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

		// Token: 0x0400437D RID: 17277
		private static readonly IntPtr NativeMethodInfoPtr_Flush_Public_Virtual_New_Void_0;

		// Token: 0x0400437E RID: 17278
		private static readonly IntPtr NativeMethodInfoPtr_DisposeAsync_Public_Virtual_New_ValueTask_0;

		// Token: 0x0400437F RID: 17279
		private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Virtual_New_Void_Boolean_0;

		// Token: 0x04004380 RID: 17280
		private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Virtual_New_Void_Byte_0;

		// Token: 0x04004381 RID: 17281
		private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Virtual_New_Void_SByte_0;

		// Token: 0x04004382 RID: 17282
		private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Virtual_New_Void_Il2CppStructArray_1_Byte_0;

		// Token: 0x04004383 RID: 17283
		private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Virtual_New_Void_Il2CppStructArray_1_Byte_Int32_Int32_0;

		// Token: 0x04004384 RID: 17284
		private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Virtual_New_Void_Char_0;

		// Token: 0x04004385 RID: 17285
		private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Virtual_New_Void_Il2CppStructArray_1_Char_0;

		// Token: 0x04004386 RID: 17286
		private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Virtual_New_Void_Double_0;

		// Token: 0x04004387 RID: 17287
		private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Virtual_New_Void_Int16_0;

		// Token: 0x04004388 RID: 17288
		private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Virtual_New_Void_UInt16_0;

		// Token: 0x04004389 RID: 17289
		private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Virtual_New_Void_Int32_0;

		// Token: 0x0400438A RID: 17290
		private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Virtual_New_Void_UInt32_0;

		// Token: 0x0400438B RID: 17291
		private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Virtual_New_Void_Int64_0;

		// Token: 0x0400438C RID: 17292
		private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Virtual_New_Void_UInt64_0;

		// Token: 0x0400438D RID: 17293
		private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Virtual_New_Void_Single_0;

		// Token: 0x0400438E RID: 17294
		private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Virtual_New_Void_String_0;

		// Token: 0x0400438F RID: 17295
		private static readonly IntPtr NativeMethodInfoPtr_Write7BitEncodedInt_Protected_Void_Int32_0;
	}
}
