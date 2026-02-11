using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Text;

namespace Il2CppSystem.IO
{
	// Token: 0x02000540 RID: 1344
	public class BinaryReader : Object
	{
		// Token: 0x06005254 RID: 21076 RVA: 0x0017F904 File Offset: 0x0017DB04
		// Note: this type is marked as 'beforefieldinit'.
		static BinaryReader()
		{
			Il2CppClassPointerStore<BinaryReader>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.IO", "BinaryReader");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BinaryReader>.NativeClassPtr);
			BinaryReader.NativeFieldInfoPtr_m_stream = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinaryReader>.NativeClassPtr, "m_stream");
			BinaryReader.NativeFieldInfoPtr_m_buffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinaryReader>.NativeClassPtr, "m_buffer");
			BinaryReader.NativeFieldInfoPtr_m_decoder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinaryReader>.NativeClassPtr, "m_decoder");
			BinaryReader.NativeFieldInfoPtr_m_charBytes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinaryReader>.NativeClassPtr, "m_charBytes");
			BinaryReader.NativeFieldInfoPtr_m_singleChar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinaryReader>.NativeClassPtr, "m_singleChar");
			BinaryReader.NativeFieldInfoPtr_m_charBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinaryReader>.NativeClassPtr, "m_charBuffer");
			BinaryReader.NativeFieldInfoPtr_m_maxCharsSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinaryReader>.NativeClassPtr, "m_maxCharsSize");
			BinaryReader.NativeFieldInfoPtr_m_2BytesPerChar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinaryReader>.NativeClassPtr, "m_2BytesPerChar");
			BinaryReader.NativeFieldInfoPtr_m_isMemoryStream = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinaryReader>.NativeClassPtr, "m_isMemoryStream");
			BinaryReader.NativeFieldInfoPtr_m_leaveOpen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinaryReader>.NativeClassPtr, "m_leaveOpen");
			BinaryReader.NativeMethodInfoPtr__ctor_Public_Void_Stream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryReader>.NativeClassPtr, 100675922);
			BinaryReader.NativeMethodInfoPtr__ctor_Public_Void_Stream_Encoding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryReader>.NativeClassPtr, 100675923);
			BinaryReader.NativeMethodInfoPtr__ctor_Public_Void_Stream_Encoding_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryReader>.NativeClassPtr, 100675924);
			BinaryReader.NativeMethodInfoPtr_get_BaseStream_Public_Virtual_New_get_Stream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryReader>.NativeClassPtr, 100675925);
			BinaryReader.NativeMethodInfoPtr_Close_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryReader>.NativeClassPtr, 100675926);
			BinaryReader.NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryReader>.NativeClassPtr, 100675927);
			BinaryReader.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryReader>.NativeClassPtr, 100675928);
			BinaryReader.NativeMethodInfoPtr_Read_Public_Virtual_New_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryReader>.NativeClassPtr, 100675929);
			BinaryReader.NativeMethodInfoPtr_ReadBoolean_Public_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryReader>.NativeClassPtr, 100675930);
			BinaryReader.NativeMethodInfoPtr_ReadByte_Public_Virtual_New_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryReader>.NativeClassPtr, 100675931);
			BinaryReader.NativeMethodInfoPtr_ReadSByte_Public_Virtual_New_SByte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryReader>.NativeClassPtr, 100675932);
			BinaryReader.NativeMethodInfoPtr_ReadChar_Public_Virtual_New_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryReader>.NativeClassPtr, 100675933);
			BinaryReader.NativeMethodInfoPtr_ReadInt16_Public_Virtual_New_Int16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryReader>.NativeClassPtr, 100675934);
			BinaryReader.NativeMethodInfoPtr_ReadUInt16_Public_Virtual_New_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryReader>.NativeClassPtr, 100675935);
			BinaryReader.NativeMethodInfoPtr_ReadInt32_Public_Virtual_New_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryReader>.NativeClassPtr, 100675936);
			BinaryReader.NativeMethodInfoPtr_ReadUInt32_Public_Virtual_New_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryReader>.NativeClassPtr, 100675937);
			BinaryReader.NativeMethodInfoPtr_ReadInt64_Public_Virtual_New_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryReader>.NativeClassPtr, 100675938);
			BinaryReader.NativeMethodInfoPtr_ReadUInt64_Public_Virtual_New_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryReader>.NativeClassPtr, 100675939);
			BinaryReader.NativeMethodInfoPtr_ReadSingle_Public_Virtual_New_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryReader>.NativeClassPtr, 100675940);
			BinaryReader.NativeMethodInfoPtr_ReadDouble_Public_Virtual_New_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryReader>.NativeClassPtr, 100675941);
			BinaryReader.NativeMethodInfoPtr_ReadDecimal_Public_Virtual_New_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryReader>.NativeClassPtr, 100675942);
			BinaryReader.NativeMethodInfoPtr_ReadString_Public_Virtual_New_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryReader>.NativeClassPtr, 100675943);
			BinaryReader.NativeMethodInfoPtr_InternalReadChars_Private_Int32_Il2CppStructArray_1_Char_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryReader>.NativeClassPtr, 100675944);
			BinaryReader.NativeMethodInfoPtr_InternalReadOneChar_Private_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryReader>.NativeClassPtr, 100675945);
			BinaryReader.NativeMethodInfoPtr_ReadChars_Public_Virtual_New_Il2CppStructArray_1_Char_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryReader>.NativeClassPtr, 100675946);
			BinaryReader.NativeMethodInfoPtr_Read_Public_Virtual_New_Int32_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryReader>.NativeClassPtr, 100675947);
			BinaryReader.NativeMethodInfoPtr_ReadBytes_Public_Virtual_New_Il2CppStructArray_1_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryReader>.NativeClassPtr, 100675948);
			BinaryReader.NativeMethodInfoPtr_FillBuffer_Protected_Virtual_New_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryReader>.NativeClassPtr, 100675949);
			BinaryReader.NativeMethodInfoPtr_Read7BitEncodedInt_FamOrAssem_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryReader>.NativeClassPtr, 100675950);
		}

		// Token: 0x06005255 RID: 21077 RVA: 0x0017FC40 File Offset: 0x0017DE40
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1432087, RefRangeEnd = 1432093, XrefRangeStart = 1432082, XrefRangeEnd = 1432087, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BinaryReader(Stream input)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BinaryReader>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(input);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryReader.NativeMethodInfoPtr__ctor_Public_Void_Stream_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06005256 RID: 21078 RVA: 0x0017FC8C File Offset: 0x0017DE8C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1432094, RefRangeEnd = 1432096, XrefRangeStart = 1432093, XrefRangeEnd = 1432094, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BinaryReader(Stream input, Encoding encoding)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BinaryReader>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(input);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(encoding);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryReader.NativeMethodInfoPtr__ctor_Public_Void_Stream_Encoding_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005257 RID: 21079 RVA: 0x0017FCEC File Offset: 0x0017DEEC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1432114, RefRangeEnd = 1432116, XrefRangeStart = 1432096, XrefRangeEnd = 1432114, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BinaryReader(Stream input, Encoding encoding, bool leaveOpen)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BinaryReader>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(input);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(encoding);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref leaveOpen;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryReader.NativeMethodInfoPtr__ctor_Public_Void_Stream_Encoding_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170014F7 RID: 5367
		// (get) Token: 0x06005258 RID: 21080 RVA: 0x0017FD58 File Offset: 0x0017DF58
		public unsafe virtual Stream BaseStream
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BinaryReader.NativeMethodInfoPtr_get_BaseStream_Public_Virtual_New_get_Stream_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Stream>(intPtr3) : null;
			}
		}

		// Token: 0x06005259 RID: 21081 RVA: 0x0017FDA4 File Offset: 0x0017DFA4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 875040, RefRangeEnd = 875041, XrefRangeStart = 875040, XrefRangeEnd = 875041, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BinaryReader.NativeMethodInfoPtr_Close_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600525A RID: 21082 RVA: 0x0017FDE0 File Offset: 0x0017DFE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1432116, XrefRangeEnd = 1432123, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dispose(bool disposing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref disposing;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BinaryReader.NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600525B RID: 21083 RVA: 0x0017FE2C File Offset: 0x0017E02C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 875040, RefRangeEnd = 875041, XrefRangeStart = 875040, XrefRangeEnd = 875041, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryReader.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600525C RID: 21084 RVA: 0x0017FE60 File Offset: 0x0017E060
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1432123, XrefRangeEnd = 1432125, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual int Read()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BinaryReader.NativeMethodInfoPtr_Read_Public_Virtual_New_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600525D RID: 21085 RVA: 0x0017FEA8 File Offset: 0x0017E0A8
		[CallerCount(0)]
		public unsafe virtual bool ReadBoolean()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BinaryReader.NativeMethodInfoPtr_ReadBoolean_Public_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600525E RID: 21086 RVA: 0x0017FEF0 File Offset: 0x0017E0F0
		[CallerCount(0)]
		public unsafe virtual byte ReadByte()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BinaryReader.NativeMethodInfoPtr_ReadByte_Public_Virtual_New_Byte_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600525F RID: 21087 RVA: 0x0017FF38 File Offset: 0x0017E138
		[CallerCount(0)]
		public unsafe virtual sbyte ReadSByte()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BinaryReader.NativeMethodInfoPtr_ReadSByte_Public_Virtual_New_SByte_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005260 RID: 21088 RVA: 0x0017FF80 File Offset: 0x0017E180
		[CallerCount(0)]
		public unsafe virtual char ReadChar()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BinaryReader.NativeMethodInfoPtr_ReadChar_Public_Virtual_New_Char_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005261 RID: 21089 RVA: 0x0017FFC8 File Offset: 0x0017E1C8
		[CallerCount(0)]
		public unsafe virtual short ReadInt16()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BinaryReader.NativeMethodInfoPtr_ReadInt16_Public_Virtual_New_Int16_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005262 RID: 21090 RVA: 0x00180010 File Offset: 0x0017E210
		[CallerCount(0)]
		public unsafe virtual ushort ReadUInt16()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BinaryReader.NativeMethodInfoPtr_ReadUInt16_Public_Virtual_New_UInt16_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005263 RID: 21091 RVA: 0x00180058 File Offset: 0x0017E258
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1432125, XrefRangeEnd = 1432126, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual int ReadInt32()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BinaryReader.NativeMethodInfoPtr_ReadInt32_Public_Virtual_New_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005264 RID: 21092 RVA: 0x001800A0 File Offset: 0x0017E2A0
		[CallerCount(0)]
		public unsafe virtual uint ReadUInt32()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BinaryReader.NativeMethodInfoPtr_ReadUInt32_Public_Virtual_New_UInt32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005265 RID: 21093 RVA: 0x001800E8 File Offset: 0x0017E2E8
		[CallerCount(0)]
		public unsafe virtual long ReadInt64()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BinaryReader.NativeMethodInfoPtr_ReadInt64_Public_Virtual_New_Int64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005266 RID: 21094 RVA: 0x00180130 File Offset: 0x0017E330
		[CallerCount(0)]
		public unsafe virtual ulong ReadUInt64()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BinaryReader.NativeMethodInfoPtr_ReadUInt64_Public_Virtual_New_UInt64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005267 RID: 21095 RVA: 0x00180178 File Offset: 0x0017E378
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1432126, XrefRangeEnd = 1432127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual float ReadSingle()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BinaryReader.NativeMethodInfoPtr_ReadSingle_Public_Virtual_New_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005268 RID: 21096 RVA: 0x001801C0 File Offset: 0x0017E3C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1432127, XrefRangeEnd = 1432128, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual double ReadDouble()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BinaryReader.NativeMethodInfoPtr_ReadDouble_Public_Virtual_New_Double_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005269 RID: 21097 RVA: 0x00180208 File Offset: 0x0017E408
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1432128, XrefRangeEnd = 1432133, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Decimal ReadDecimal()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BinaryReader.NativeMethodInfoPtr_ReadDecimal_Public_Virtual_New_Decimal_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600526A RID: 21098 RVA: 0x00180250 File Offset: 0x0017E450
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1432133, XrefRangeEnd = 1432146, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string ReadString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BinaryReader.NativeMethodInfoPtr_ReadString_Public_Virtual_New_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600526B RID: 21099 RVA: 0x00180294 File Offset: 0x0017E494
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1432163, RefRangeEnd = 1432164, XrefRangeStart = 1432146, XrefRangeEnd = 1432163, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int InternalReadChars(Il2CppStructArray<char> buffer, int index, int count)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryReader.NativeMethodInfoPtr_InternalReadChars_Private_Int32_Il2CppStructArray_1_Char_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600526C RID: 21100 RVA: 0x00180300 File Offset: 0x0017E500
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1432175, RefRangeEnd = 1432176, XrefRangeStart = 1432164, XrefRangeEnd = 1432175, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int InternalReadOneChar()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryReader.NativeMethodInfoPtr_InternalReadOneChar_Private_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600526D RID: 21101 RVA: 0x0018033C File Offset: 0x0017E53C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1432176, XrefRangeEnd = 1432184, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Il2CppStructArray<char> ReadChars(int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref count;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BinaryReader.NativeMethodInfoPtr_ReadChars_Public_Virtual_New_Il2CppStructArray_1_Char_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr3) : null;
			}
		}

		// Token: 0x0600526E RID: 21102 RVA: 0x00180394 File Offset: 0x0017E594
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1432184, XrefRangeEnd = 1432217, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual int Read(Il2CppStructArray<byte> buffer, int index, int count)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BinaryReader.NativeMethodInfoPtr_Read_Public_Virtual_New_Int32_Il2CppStructArray_1_Byte_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600526F RID: 21103 RVA: 0x00180408 File Offset: 0x0017E608
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1432217, XrefRangeEnd = 1432224, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Il2CppStructArray<byte> ReadBytes(int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref count;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BinaryReader.NativeMethodInfoPtr_ReadBytes_Public_Virtual_New_Il2CppStructArray_1_Byte_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
			}
		}

		// Token: 0x06005270 RID: 21104 RVA: 0x00180460 File Offset: 0x0017E660
		[CallerCount(0)]
		public unsafe virtual void FillBuffer(int numBytes)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref numBytes;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BinaryReader.NativeMethodInfoPtr_FillBuffer_Protected_Virtual_New_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06005271 RID: 21105 RVA: 0x001804AC File Offset: 0x0017E6AC
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1432224, RefRangeEnd = 1432230, XrefRangeStart = 1432224, XrefRangeEnd = 1432224, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int Read7BitEncodedInt()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryReader.NativeMethodInfoPtr_Read7BitEncodedInt_FamOrAssem_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005272 RID: 21106 RVA: 0x0001D36D File Offset: 0x0001B56D
		public BinaryReader(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170014ED RID: 5357
		// (get) Token: 0x06005273 RID: 21107 RVA: 0x001804E8 File Offset: 0x0017E6E8
		// (set) Token: 0x06005274 RID: 21108 RVA: 0x0001D376 File Offset: 0x0001B576
		public unsafe Stream m_stream
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryReader.NativeFieldInfoPtr_m_stream);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Stream>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryReader.NativeFieldInfoPtr_m_stream), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170014EE RID: 5358
		// (get) Token: 0x06005275 RID: 21109 RVA: 0x00180518 File Offset: 0x0017E718
		// (set) Token: 0x06005276 RID: 21110 RVA: 0x0001D395 File Offset: 0x0001B595
		public unsafe Il2CppStructArray<byte> m_buffer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryReader.NativeFieldInfoPtr_m_buffer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryReader.NativeFieldInfoPtr_m_buffer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170014EF RID: 5359
		// (get) Token: 0x06005277 RID: 21111 RVA: 0x00180548 File Offset: 0x0017E748
		// (set) Token: 0x06005278 RID: 21112 RVA: 0x0001D3B4 File Offset: 0x0001B5B4
		public unsafe Decoder m_decoder
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryReader.NativeFieldInfoPtr_m_decoder);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Decoder>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryReader.NativeFieldInfoPtr_m_decoder), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170014F0 RID: 5360
		// (get) Token: 0x06005279 RID: 21113 RVA: 0x00180578 File Offset: 0x0017E778
		// (set) Token: 0x0600527A RID: 21114 RVA: 0x0001D3D3 File Offset: 0x0001B5D3
		public unsafe Il2CppStructArray<byte> m_charBytes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryReader.NativeFieldInfoPtr_m_charBytes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryReader.NativeFieldInfoPtr_m_charBytes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170014F1 RID: 5361
		// (get) Token: 0x0600527B RID: 21115 RVA: 0x001805A8 File Offset: 0x0017E7A8
		// (set) Token: 0x0600527C RID: 21116 RVA: 0x0001D3F2 File Offset: 0x0001B5F2
		public unsafe Il2CppStructArray<char> m_singleChar
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryReader.NativeFieldInfoPtr_m_singleChar);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryReader.NativeFieldInfoPtr_m_singleChar), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170014F2 RID: 5362
		// (get) Token: 0x0600527D RID: 21117 RVA: 0x001805D8 File Offset: 0x0017E7D8
		// (set) Token: 0x0600527E RID: 21118 RVA: 0x0001D411 File Offset: 0x0001B611
		public unsafe Il2CppStructArray<char> m_charBuffer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryReader.NativeFieldInfoPtr_m_charBuffer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryReader.NativeFieldInfoPtr_m_charBuffer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170014F3 RID: 5363
		// (get) Token: 0x0600527F RID: 21119 RVA: 0x00180608 File Offset: 0x0017E808
		// (set) Token: 0x06005280 RID: 21120 RVA: 0x0001D430 File Offset: 0x0001B630
		public unsafe int m_maxCharsSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryReader.NativeFieldInfoPtr_m_maxCharsSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryReader.NativeFieldInfoPtr_m_maxCharsSize)) = value;
			}
		}

		// Token: 0x170014F4 RID: 5364
		// (get) Token: 0x06005281 RID: 21121 RVA: 0x00180630 File Offset: 0x0017E830
		// (set) Token: 0x06005282 RID: 21122 RVA: 0x0001D44B File Offset: 0x0001B64B
		public unsafe bool m_2BytesPerChar
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryReader.NativeFieldInfoPtr_m_2BytesPerChar);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryReader.NativeFieldInfoPtr_m_2BytesPerChar)) = value;
			}
		}

		// Token: 0x170014F5 RID: 5365
		// (get) Token: 0x06005283 RID: 21123 RVA: 0x00180658 File Offset: 0x0017E858
		// (set) Token: 0x06005284 RID: 21124 RVA: 0x0001D466 File Offset: 0x0001B666
		public unsafe bool m_isMemoryStream
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryReader.NativeFieldInfoPtr_m_isMemoryStream);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryReader.NativeFieldInfoPtr_m_isMemoryStream)) = value;
			}
		}

		// Token: 0x170014F6 RID: 5366
		// (get) Token: 0x06005285 RID: 21125 RVA: 0x00180680 File Offset: 0x0017E880
		// (set) Token: 0x06005286 RID: 21126 RVA: 0x0001D481 File Offset: 0x0001B681
		public unsafe bool m_leaveOpen
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryReader.NativeFieldInfoPtr_m_leaveOpen);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryReader.NativeFieldInfoPtr_m_leaveOpen)) = value;
			}
		}

		// Token: 0x04004347 RID: 17223
		private static readonly IntPtr NativeFieldInfoPtr_m_stream;

		// Token: 0x04004348 RID: 17224
		private static readonly IntPtr NativeFieldInfoPtr_m_buffer;

		// Token: 0x04004349 RID: 17225
		private static readonly IntPtr NativeFieldInfoPtr_m_decoder;

		// Token: 0x0400434A RID: 17226
		private static readonly IntPtr NativeFieldInfoPtr_m_charBytes;

		// Token: 0x0400434B RID: 17227
		private static readonly IntPtr NativeFieldInfoPtr_m_singleChar;

		// Token: 0x0400434C RID: 17228
		private static readonly IntPtr NativeFieldInfoPtr_m_charBuffer;

		// Token: 0x0400434D RID: 17229
		private static readonly IntPtr NativeFieldInfoPtr_m_maxCharsSize;

		// Token: 0x0400434E RID: 17230
		private static readonly IntPtr NativeFieldInfoPtr_m_2BytesPerChar;

		// Token: 0x0400434F RID: 17231
		private static readonly IntPtr NativeFieldInfoPtr_m_isMemoryStream;

		// Token: 0x04004350 RID: 17232
		private static readonly IntPtr NativeFieldInfoPtr_m_leaveOpen;

		// Token: 0x04004351 RID: 17233
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Stream_0;

		// Token: 0x04004352 RID: 17234
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Stream_Encoding_0;

		// Token: 0x04004353 RID: 17235
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Stream_Encoding_Boolean_0;

		// Token: 0x04004354 RID: 17236
		private static readonly IntPtr NativeMethodInfoPtr_get_BaseStream_Public_Virtual_New_get_Stream_0;

		// Token: 0x04004355 RID: 17237
		private static readonly IntPtr NativeMethodInfoPtr_Close_Public_Virtual_New_Void_0;

		// Token: 0x04004356 RID: 17238
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0;

		// Token: 0x04004357 RID: 17239
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

		// Token: 0x04004358 RID: 17240
		private static readonly IntPtr NativeMethodInfoPtr_Read_Public_Virtual_New_Int32_0;

		// Token: 0x04004359 RID: 17241
		private static readonly IntPtr NativeMethodInfoPtr_ReadBoolean_Public_Virtual_New_Boolean_0;

		// Token: 0x0400435A RID: 17242
		private static readonly IntPtr NativeMethodInfoPtr_ReadByte_Public_Virtual_New_Byte_0;

		// Token: 0x0400435B RID: 17243
		private static readonly IntPtr NativeMethodInfoPtr_ReadSByte_Public_Virtual_New_SByte_0;

		// Token: 0x0400435C RID: 17244
		private static readonly IntPtr NativeMethodInfoPtr_ReadChar_Public_Virtual_New_Char_0;

		// Token: 0x0400435D RID: 17245
		private static readonly IntPtr NativeMethodInfoPtr_ReadInt16_Public_Virtual_New_Int16_0;

		// Token: 0x0400435E RID: 17246
		private static readonly IntPtr NativeMethodInfoPtr_ReadUInt16_Public_Virtual_New_UInt16_0;

		// Token: 0x0400435F RID: 17247
		private static readonly IntPtr NativeMethodInfoPtr_ReadInt32_Public_Virtual_New_Int32_0;

		// Token: 0x04004360 RID: 17248
		private static readonly IntPtr NativeMethodInfoPtr_ReadUInt32_Public_Virtual_New_UInt32_0;

		// Token: 0x04004361 RID: 17249
		private static readonly IntPtr NativeMethodInfoPtr_ReadInt64_Public_Virtual_New_Int64_0;

		// Token: 0x04004362 RID: 17250
		private static readonly IntPtr NativeMethodInfoPtr_ReadUInt64_Public_Virtual_New_UInt64_0;

		// Token: 0x04004363 RID: 17251
		private static readonly IntPtr NativeMethodInfoPtr_ReadSingle_Public_Virtual_New_Single_0;

		// Token: 0x04004364 RID: 17252
		private static readonly IntPtr NativeMethodInfoPtr_ReadDouble_Public_Virtual_New_Double_0;

		// Token: 0x04004365 RID: 17253
		private static readonly IntPtr NativeMethodInfoPtr_ReadDecimal_Public_Virtual_New_Decimal_0;

		// Token: 0x04004366 RID: 17254
		private static readonly IntPtr NativeMethodInfoPtr_ReadString_Public_Virtual_New_String_0;

		// Token: 0x04004367 RID: 17255
		private static readonly IntPtr NativeMethodInfoPtr_InternalReadChars_Private_Int32_Il2CppStructArray_1_Char_Int32_Int32_0;

		// Token: 0x04004368 RID: 17256
		private static readonly IntPtr NativeMethodInfoPtr_InternalReadOneChar_Private_Int32_0;

		// Token: 0x04004369 RID: 17257
		private static readonly IntPtr NativeMethodInfoPtr_ReadChars_Public_Virtual_New_Il2CppStructArray_1_Char_Int32_0;

		// Token: 0x0400436A RID: 17258
		private static readonly IntPtr NativeMethodInfoPtr_Read_Public_Virtual_New_Int32_Il2CppStructArray_1_Byte_Int32_Int32_0;

		// Token: 0x0400436B RID: 17259
		private static readonly IntPtr NativeMethodInfoPtr_ReadBytes_Public_Virtual_New_Il2CppStructArray_1_Byte_Int32_0;

		// Token: 0x0400436C RID: 17260
		private static readonly IntPtr NativeMethodInfoPtr_FillBuffer_Protected_Virtual_New_Void_Int32_0;

		// Token: 0x0400436D RID: 17261
		private static readonly IntPtr NativeMethodInfoPtr_Read7BitEncodedInt_FamOrAssem_Int32_0;
	}
}
