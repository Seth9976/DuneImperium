using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;

namespace Il2CppSystem.Runtime.Serialization.Formatters.Binary
{
	// Token: 0x0200034F RID: 847
	public sealed class SerializationHeaderRecord : Object
	{
		// Token: 0x060032B6 RID: 12982 RVA: 0x001000EC File Offset: 0x000FE2EC
		// Note: this type is marked as 'beforefieldinit'.
		static SerializationHeaderRecord()
		{
			Il2CppClassPointerStore<SerializationHeaderRecord>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Serialization.Formatters.Binary", "SerializationHeaderRecord");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SerializationHeaderRecord>.NativeClassPtr);
			SerializationHeaderRecord.NativeFieldInfoPtr_binaryFormatterMajorVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializationHeaderRecord>.NativeClassPtr, "binaryFormatterMajorVersion");
			SerializationHeaderRecord.NativeFieldInfoPtr_binaryFormatterMinorVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializationHeaderRecord>.NativeClassPtr, "binaryFormatterMinorVersion");
			SerializationHeaderRecord.NativeFieldInfoPtr_binaryHeaderEnum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializationHeaderRecord>.NativeClassPtr, "binaryHeaderEnum");
			SerializationHeaderRecord.NativeFieldInfoPtr_topId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializationHeaderRecord>.NativeClassPtr, "topId");
			SerializationHeaderRecord.NativeFieldInfoPtr_headerId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializationHeaderRecord>.NativeClassPtr, "headerId");
			SerializationHeaderRecord.NativeFieldInfoPtr_majorVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializationHeaderRecord>.NativeClassPtr, "majorVersion");
			SerializationHeaderRecord.NativeFieldInfoPtr_minorVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializationHeaderRecord>.NativeClassPtr, "minorVersion");
			SerializationHeaderRecord.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationHeaderRecord>.NativeClassPtr, 100671229);
			SerializationHeaderRecord.NativeMethodInfoPtr__ctor_Internal_Void_BinaryHeaderEnum_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationHeaderRecord>.NativeClassPtr, 100671230);
			SerializationHeaderRecord.NativeMethodInfoPtr_Write_Public_Virtual_Final_New_Void___BinaryWriter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationHeaderRecord>.NativeClassPtr, 100671231);
			SerializationHeaderRecord.NativeMethodInfoPtr_GetInt32_Private_Static_Int32_Il2CppStructArray_1_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationHeaderRecord>.NativeClassPtr, 100671232);
			SerializationHeaderRecord.NativeMethodInfoPtr_Read_Public_Virtual_Final_New_Void___BinaryParser_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationHeaderRecord>.NativeClassPtr, 100671233);
			SerializationHeaderRecord.NativeMethodInfoPtr_Dump_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationHeaderRecord>.NativeClassPtr, 100671234);
		}

		// Token: 0x060032B7 RID: 12983 RVA: 0x00100220 File Offset: 0x000FE420
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1387200, RefRangeEnd = 1387202, XrefRangeStart = 1387199, XrefRangeEnd = 1387200, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SerializationHeaderRecord()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SerializationHeaderRecord>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializationHeaderRecord.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060032B8 RID: 12984 RVA: 0x0010025C File Offset: 0x000FE45C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1387202, XrefRangeEnd = 1387203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SerializationHeaderRecord(BinaryHeaderEnum binaryHeaderEnum, int topId, int headerId, int majorVersion, int minorVersion)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SerializationHeaderRecord>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref binaryHeaderEnum;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref topId;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref headerId;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref majorVersion;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref minorVersion;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializationHeaderRecord.NativeMethodInfoPtr__ctor_Internal_Void_BinaryHeaderEnum_Int32_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060032B9 RID: 12985 RVA: 0x001002DC File Offset: 0x000FE4DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1387203, XrefRangeEnd = 1387204, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Write(__BinaryWriter sout)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sout);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializationHeaderRecord.NativeMethodInfoPtr_Write_Public_Virtual_Final_New_Void___BinaryWriter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060032BA RID: 12986 RVA: 0x00100320 File Offset: 0x000FE520
		[CallerCount(0)]
		public unsafe static int GetInt32(Il2CppStructArray<byte> buffer, int index)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializationHeaderRecord.NativeMethodInfoPtr_GetInt32_Private_Static_Int32_Il2CppStructArray_1_Byte_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060032BB RID: 12987 RVA: 0x00100370 File Offset: 0x000FE570
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1387206, RefRangeEnd = 1387208, XrefRangeStart = 1387204, XrefRangeEnd = 1387206, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Read(__BinaryParser input)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(input);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializationHeaderRecord.NativeMethodInfoPtr_Read_Public_Virtual_Final_New_Void___BinaryParser_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060032BC RID: 12988 RVA: 0x001003B4 File Offset: 0x000FE5B4
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Dump()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializationHeaderRecord.NativeMethodInfoPtr_Dump_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060032BD RID: 12989 RVA: 0x0001195F File Offset: 0x0000FB5F
		public SerializationHeaderRecord(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000B80 RID: 2944
		// (get) Token: 0x060032BE RID: 12990 RVA: 0x001003E8 File Offset: 0x000FE5E8
		// (set) Token: 0x060032BF RID: 12991 RVA: 0x00011968 File Offset: 0x0000FB68
		public unsafe int binaryFormatterMajorVersion
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializationHeaderRecord.NativeFieldInfoPtr_binaryFormatterMajorVersion);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializationHeaderRecord.NativeFieldInfoPtr_binaryFormatterMajorVersion)) = value;
			}
		}

		// Token: 0x17000B81 RID: 2945
		// (get) Token: 0x060032C0 RID: 12992 RVA: 0x00100410 File Offset: 0x000FE610
		// (set) Token: 0x060032C1 RID: 12993 RVA: 0x00011983 File Offset: 0x0000FB83
		public unsafe int binaryFormatterMinorVersion
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializationHeaderRecord.NativeFieldInfoPtr_binaryFormatterMinorVersion);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializationHeaderRecord.NativeFieldInfoPtr_binaryFormatterMinorVersion)) = value;
			}
		}

		// Token: 0x17000B82 RID: 2946
		// (get) Token: 0x060032C2 RID: 12994 RVA: 0x00100438 File Offset: 0x000FE638
		// (set) Token: 0x060032C3 RID: 12995 RVA: 0x0001199E File Offset: 0x0000FB9E
		public unsafe BinaryHeaderEnum binaryHeaderEnum
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializationHeaderRecord.NativeFieldInfoPtr_binaryHeaderEnum);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializationHeaderRecord.NativeFieldInfoPtr_binaryHeaderEnum)) = value;
			}
		}

		// Token: 0x17000B83 RID: 2947
		// (get) Token: 0x060032C4 RID: 12996 RVA: 0x00100460 File Offset: 0x000FE660
		// (set) Token: 0x060032C5 RID: 12997 RVA: 0x000119B9 File Offset: 0x0000FBB9
		public unsafe int topId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializationHeaderRecord.NativeFieldInfoPtr_topId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializationHeaderRecord.NativeFieldInfoPtr_topId)) = value;
			}
		}

		// Token: 0x17000B84 RID: 2948
		// (get) Token: 0x060032C6 RID: 12998 RVA: 0x00100488 File Offset: 0x000FE688
		// (set) Token: 0x060032C7 RID: 12999 RVA: 0x000119D4 File Offset: 0x0000FBD4
		public unsafe int headerId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializationHeaderRecord.NativeFieldInfoPtr_headerId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializationHeaderRecord.NativeFieldInfoPtr_headerId)) = value;
			}
		}

		// Token: 0x17000B85 RID: 2949
		// (get) Token: 0x060032C8 RID: 13000 RVA: 0x001004B0 File Offset: 0x000FE6B0
		// (set) Token: 0x060032C9 RID: 13001 RVA: 0x000119EF File Offset: 0x0000FBEF
		public unsafe int majorVersion
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializationHeaderRecord.NativeFieldInfoPtr_majorVersion);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializationHeaderRecord.NativeFieldInfoPtr_majorVersion)) = value;
			}
		}

		// Token: 0x17000B86 RID: 2950
		// (get) Token: 0x060032CA RID: 13002 RVA: 0x001004D8 File Offset: 0x000FE6D8
		// (set) Token: 0x060032CB RID: 13003 RVA: 0x00011A0A File Offset: 0x0000FC0A
		public unsafe int minorVersion
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializationHeaderRecord.NativeFieldInfoPtr_minorVersion);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializationHeaderRecord.NativeFieldInfoPtr_minorVersion)) = value;
			}
		}

		// Token: 0x04002A09 RID: 10761
		private static readonly IntPtr NativeFieldInfoPtr_binaryFormatterMajorVersion;

		// Token: 0x04002A0A RID: 10762
		private static readonly IntPtr NativeFieldInfoPtr_binaryFormatterMinorVersion;

		// Token: 0x04002A0B RID: 10763
		private static readonly IntPtr NativeFieldInfoPtr_binaryHeaderEnum;

		// Token: 0x04002A0C RID: 10764
		private static readonly IntPtr NativeFieldInfoPtr_topId;

		// Token: 0x04002A0D RID: 10765
		private static readonly IntPtr NativeFieldInfoPtr_headerId;

		// Token: 0x04002A0E RID: 10766
		private static readonly IntPtr NativeFieldInfoPtr_majorVersion;

		// Token: 0x04002A0F RID: 10767
		private static readonly IntPtr NativeFieldInfoPtr_minorVersion;

		// Token: 0x04002A10 RID: 10768
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

		// Token: 0x04002A11 RID: 10769
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_BinaryHeaderEnum_Int32_Int32_Int32_Int32_0;

		// Token: 0x04002A12 RID: 10770
		private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Virtual_Final_New_Void___BinaryWriter_0;

		// Token: 0x04002A13 RID: 10771
		private static readonly IntPtr NativeMethodInfoPtr_GetInt32_Private_Static_Int32_Il2CppStructArray_1_Byte_Int32_0;

		// Token: 0x04002A14 RID: 10772
		private static readonly IntPtr NativeMethodInfoPtr_Read_Public_Virtual_Final_New_Void___BinaryParser_0;

		// Token: 0x04002A15 RID: 10773
		private static readonly IntPtr NativeMethodInfoPtr_Dump_Public_Void_0;
	}
}
