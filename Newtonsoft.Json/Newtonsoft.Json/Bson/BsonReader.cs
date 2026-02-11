using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.IO;

namespace Newtonsoft.Json.Bson
{
	// Token: 0x02000104 RID: 260
	public class BsonReader : JsonReader
	{
		// Token: 0x06001571 RID: 5489 RVA: 0x00074B04 File Offset: 0x00072D04
		// Note: this type is marked as 'beforefieldinit'.
		static BsonReader()
		{
			Il2CppClassPointerStore<BsonReader>.NativeClassPtr = IL2CPP.GetIl2CppClass("Newtonsoft.Json.dll", "Newtonsoft.Json.Bson", "BsonReader");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BsonReader>.NativeClassPtr);
			BsonReader.NativeFieldInfoPtr_MaxCharBytesSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BsonReader>.NativeClassPtr, "MaxCharBytesSize");
			BsonReader.NativeFieldInfoPtr_SeqRange1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BsonReader>.NativeClassPtr, "SeqRange1");
			BsonReader.NativeFieldInfoPtr_SeqRange2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BsonReader>.NativeClassPtr, "SeqRange2");
			BsonReader.NativeFieldInfoPtr_SeqRange3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BsonReader>.NativeClassPtr, "SeqRange3");
			BsonReader.NativeFieldInfoPtr_SeqRange4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BsonReader>.NativeClassPtr, "SeqRange4");
			BsonReader.NativeFieldInfoPtr__reader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BsonReader>.NativeClassPtr, "_reader");
			BsonReader.NativeFieldInfoPtr__stack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BsonReader>.NativeClassPtr, "_stack");
			BsonReader.NativeFieldInfoPtr__byteBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BsonReader>.NativeClassPtr, "_byteBuffer");
			BsonReader.NativeFieldInfoPtr__charBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BsonReader>.NativeClassPtr, "_charBuffer");
			BsonReader.NativeFieldInfoPtr__currentElementType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BsonReader>.NativeClassPtr, "_currentElementType");
			BsonReader.NativeFieldInfoPtr__bsonReaderState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BsonReader>.NativeClassPtr, "_bsonReaderState");
			BsonReader.NativeFieldInfoPtr__currentContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BsonReader>.NativeClassPtr, "_currentContext");
			BsonReader.NativeFieldInfoPtr__readRootValueAsArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BsonReader>.NativeClassPtr, "_readRootValueAsArray");
			BsonReader.NativeFieldInfoPtr__jsonNet35BinaryCompatibility = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BsonReader>.NativeClassPtr, "_jsonNet35BinaryCompatibility");
			BsonReader.NativeFieldInfoPtr__dateTimeKindHandling = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BsonReader>.NativeClassPtr, "_dateTimeKindHandling");
			BsonReader.NativeMethodInfoPtr_get_JsonNet35BinaryCompatibility_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BsonReader>.NativeClassPtr, 100667357);
			BsonReader.NativeMethodInfoPtr_set_JsonNet35BinaryCompatibility_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BsonReader>.NativeClassPtr, 100667358);
			BsonReader.NativeMethodInfoPtr_get_ReadRootValueAsArray_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BsonReader>.NativeClassPtr, 100667359);
			BsonReader.NativeMethodInfoPtr_set_ReadRootValueAsArray_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BsonReader>.NativeClassPtr, 100667360);
			BsonReader.NativeMethodInfoPtr_get_DateTimeKindHandling_Public_get_DateTimeKind_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BsonReader>.NativeClassPtr, 100667361);
			BsonReader.NativeMethodInfoPtr_set_DateTimeKindHandling_Public_set_Void_DateTimeKind_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BsonReader>.NativeClassPtr, 100667362);
			BsonReader.NativeMethodInfoPtr__ctor_Public_Void_Stream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BsonReader>.NativeClassPtr, 100667363);
			BsonReader.NativeMethodInfoPtr__ctor_Public_Void_BinaryReader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BsonReader>.NativeClassPtr, 100667364);
			BsonReader.NativeMethodInfoPtr__ctor_Public_Void_Stream_Boolean_DateTimeKind_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BsonReader>.NativeClassPtr, 100667365);
			BsonReader.NativeMethodInfoPtr__ctor_Public_Void_BinaryReader_Boolean_DateTimeKind_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BsonReader>.NativeClassPtr, 100667366);
			BsonReader.NativeMethodInfoPtr_ReadElement_Private_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BsonReader>.NativeClassPtr, 100667367);
			BsonReader.NativeMethodInfoPtr_Read_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BsonReader>.NativeClassPtr, 100667368);
			BsonReader.NativeMethodInfoPtr_Close_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BsonReader>.NativeClassPtr, 100667369);
			BsonReader.NativeMethodInfoPtr_ReadCodeWScope_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BsonReader>.NativeClassPtr, 100667370);
			BsonReader.NativeMethodInfoPtr_ReadReference_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BsonReader>.NativeClassPtr, 100667371);
			BsonReader.NativeMethodInfoPtr_ReadNormal_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BsonReader>.NativeClassPtr, 100667372);
			BsonReader.NativeMethodInfoPtr_PopContext_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BsonReader>.NativeClassPtr, 100667373);
			BsonReader.NativeMethodInfoPtr_PushContext_Private_Void_ContainerContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BsonReader>.NativeClassPtr, 100667374);
			BsonReader.NativeMethodInfoPtr_ReadByte_Private_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BsonReader>.NativeClassPtr, 100667375);
			BsonReader.NativeMethodInfoPtr_ReadType_Private_Void_BsonType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BsonReader>.NativeClassPtr, 100667376);
			BsonReader.NativeMethodInfoPtr_ReadBinary_Private_Il2CppStructArray_1_Byte_byref_BsonBinaryType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BsonReader>.NativeClassPtr, 100667377);
			BsonReader.NativeMethodInfoPtr_ReadString_Private_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BsonReader>.NativeClassPtr, 100667378);
			BsonReader.NativeMethodInfoPtr_ReadLengthString_Private_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BsonReader>.NativeClassPtr, 100667379);
			BsonReader.NativeMethodInfoPtr_GetString_Private_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BsonReader>.NativeClassPtr, 100667380);
			BsonReader.NativeMethodInfoPtr_GetLastFullCharStop_Private_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BsonReader>.NativeClassPtr, 100667381);
			BsonReader.NativeMethodInfoPtr_BytesInSequence_Private_Int32_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BsonReader>.NativeClassPtr, 100667382);
			BsonReader.NativeMethodInfoPtr_EnsureBuffers_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BsonReader>.NativeClassPtr, 100667383);
			BsonReader.NativeMethodInfoPtr_ReadDouble_Private_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BsonReader>.NativeClassPtr, 100667384);
			BsonReader.NativeMethodInfoPtr_ReadInt32_Private_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BsonReader>.NativeClassPtr, 100667385);
			BsonReader.NativeMethodInfoPtr_ReadInt64_Private_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BsonReader>.NativeClassPtr, 100667386);
			BsonReader.NativeMethodInfoPtr_ReadType_Private_BsonType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BsonReader>.NativeClassPtr, 100667387);
			BsonReader.NativeMethodInfoPtr_MovePosition_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BsonReader>.NativeClassPtr, 100667388);
			BsonReader.NativeMethodInfoPtr_ReadBytes_Private_Il2CppStructArray_1_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BsonReader>.NativeClassPtr, 100667389);
		}

		// Token: 0x170005A6 RID: 1446
		// (get) Token: 0x06001572 RID: 5490 RVA: 0x00074EF4 File Offset: 0x000730F4
		// (set) Token: 0x06001573 RID: 5491 RVA: 0x00074F30 File Offset: 0x00073130
		public unsafe bool JsonNet35BinaryCompatibility
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BsonReader.NativeMethodInfoPtr_get_JsonNet35BinaryCompatibility_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BsonReader.NativeMethodInfoPtr_set_JsonNet35BinaryCompatibility_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170005A7 RID: 1447
		// (get) Token: 0x06001574 RID: 5492 RVA: 0x00074F70 File Offset: 0x00073170
		// (set) Token: 0x06001575 RID: 5493 RVA: 0x00074FAC File Offset: 0x000731AC
		public unsafe bool ReadRootValueAsArray
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BsonReader.NativeMethodInfoPtr_get_ReadRootValueAsArray_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BsonReader.NativeMethodInfoPtr_set_ReadRootValueAsArray_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170005A8 RID: 1448
		// (get) Token: 0x06001576 RID: 5494 RVA: 0x00074FEC File Offset: 0x000731EC
		// (set) Token: 0x06001577 RID: 5495 RVA: 0x00075028 File Offset: 0x00073228
		public unsafe DateTimeKind DateTimeKindHandling
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BsonReader.NativeMethodInfoPtr_get_DateTimeKindHandling_Public_get_DateTimeKind_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 314559, RefRangeEnd = 314560, XrefRangeStart = 314559, XrefRangeEnd = 314560, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BsonReader.NativeMethodInfoPtr_set_DateTimeKindHandling_Public_set_Void_DateTimeKind_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06001578 RID: 5496 RVA: 0x00075068 File Offset: 0x00073268
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 766884, XrefRangeEnd = 766900, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BsonReader(Stream stream)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BsonReader>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stream);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BsonReader.NativeMethodInfoPtr__ctor_Public_Void_Stream_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001579 RID: 5497 RVA: 0x000750B4 File Offset: 0x000732B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 766900, XrefRangeEnd = 766912, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BsonReader(BinaryReader reader)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BsonReader>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BsonReader.NativeMethodInfoPtr__ctor_Public_Void_BinaryReader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600157A RID: 5498 RVA: 0x00075100 File Offset: 0x00073300
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 766912, XrefRangeEnd = 766928, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BsonReader(Stream stream, bool readRootValueAsArray, DateTimeKind dateTimeKindHandling)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BsonReader>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stream);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref readRootValueAsArray;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dateTimeKindHandling;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BsonReader.NativeMethodInfoPtr__ctor_Public_Void_Stream_Boolean_DateTimeKind_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600157B RID: 5499 RVA: 0x00075168 File Offset: 0x00073368
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 766928, XrefRangeEnd = 766940, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BsonReader(BinaryReader reader, bool readRootValueAsArray, DateTimeKind dateTimeKindHandling)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BsonReader>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref readRootValueAsArray;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dateTimeKindHandling;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BsonReader.NativeMethodInfoPtr__ctor_Public_Void_BinaryReader_Boolean_DateTimeKind_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600157C RID: 5500 RVA: 0x000751D0 File Offset: 0x000733D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 766940, XrefRangeEnd = 766942, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string ReadElement()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BsonReader.NativeMethodInfoPtr_ReadElement_Private_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600157D RID: 5501 RVA: 0x00075208 File Offset: 0x00073408
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 766942, XrefRangeEnd = 766951, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Read()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BsonReader.NativeMethodInfoPtr_Read_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600157E RID: 5502 RVA: 0x00075250 File Offset: 0x00073450
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 766951, XrefRangeEnd = 766952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BsonReader.NativeMethodInfoPtr_Close_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600157F RID: 5503 RVA: 0x0007528C File Offset: 0x0007348C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 766956, RefRangeEnd = 766957, XrefRangeStart = 766952, XrefRangeEnd = 766956, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ReadCodeWScope()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BsonReader.NativeMethodInfoPtr_ReadCodeWScope_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001580 RID: 5504 RVA: 0x000752C8 File Offset: 0x000734C8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 766960, RefRangeEnd = 766961, XrefRangeStart = 766957, XrefRangeEnd = 766960, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ReadReference()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BsonReader.NativeMethodInfoPtr_ReadReference_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001581 RID: 5505 RVA: 0x00075304 File Offset: 0x00073504
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 766963, RefRangeEnd = 766964, XrefRangeStart = 766961, XrefRangeEnd = 766963, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ReadNormal()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BsonReader.NativeMethodInfoPtr_ReadNormal_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001582 RID: 5506 RVA: 0x00075340 File Offset: 0x00073540
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 766964, XrefRangeEnd = 766974, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PopContext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BsonReader.NativeMethodInfoPtr_PopContext_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001583 RID: 5507 RVA: 0x00075374 File Offset: 0x00073574
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 766974, XrefRangeEnd = 766982, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PushContext(BsonReader.ContainerContext newContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(newContext);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BsonReader.NativeMethodInfoPtr_PushContext_Private_Void_ContainerContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001584 RID: 5508 RVA: 0x000753B8 File Offset: 0x000735B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 766982, XrefRangeEnd = 766983, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe byte ReadByte()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BsonReader.NativeMethodInfoPtr_ReadByte_Private_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001585 RID: 5509 RVA: 0x000753F4 File Offset: 0x000735F4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 767005, RefRangeEnd = 767006, XrefRangeStart = 766983, XrefRangeEnd = 767005, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReadType(BsonType type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref type;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BsonReader.NativeMethodInfoPtr_ReadType_Private_Void_BsonType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001586 RID: 5510 RVA: 0x00075434 File Offset: 0x00073634
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 767006, XrefRangeEnd = 767007, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStructArray<byte> ReadBinary(out BsonBinaryType binaryType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &binaryType;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BsonReader.NativeMethodInfoPtr_ReadBinary_Private_Il2CppStructArray_1_Byte_byref_BsonBinaryType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
			}
		}

		// Token: 0x06001587 RID: 5511 RVA: 0x00075480 File Offset: 0x00073680
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 767021, RefRangeEnd = 767022, XrefRangeStart = 767007, XrefRangeEnd = 767021, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string ReadString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BsonReader.NativeMethodInfoPtr_ReadString_Private_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001588 RID: 5512 RVA: 0x000754B8 File Offset: 0x000736B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 767022, XrefRangeEnd = 767023, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string ReadLengthString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BsonReader.NativeMethodInfoPtr_ReadLengthString_Private_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001589 RID: 5513 RVA: 0x000754F0 File Offset: 0x000736F0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 767035, RefRangeEnd = 767036, XrefRangeStart = 767023, XrefRangeEnd = 767035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetString(int length)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref length;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BsonReader.NativeMethodInfoPtr_GetString_Private_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600158A RID: 5514 RVA: 0x00075534 File Offset: 0x00073734
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 767036, XrefRangeEnd = 767037, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetLastFullCharStop(int start)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref start;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BsonReader.NativeMethodInfoPtr_GetLastFullCharStop_Private_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600158B RID: 5515 RVA: 0x00075580 File Offset: 0x00073780
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 767045, RefRangeEnd = 767048, XrefRangeStart = 767037, XrefRangeEnd = 767045, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int BytesInSequence(byte b)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref b;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BsonReader.NativeMethodInfoPtr_BytesInSequence_Private_Int32_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600158C RID: 5516 RVA: 0x000755CC File Offset: 0x000737CC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 767057, RefRangeEnd = 767059, XrefRangeStart = 767048, XrefRangeEnd = 767057, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EnsureBuffers()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BsonReader.NativeMethodInfoPtr_EnsureBuffers_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600158D RID: 5517 RVA: 0x00075600 File Offset: 0x00073800
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 767059, XrefRangeEnd = 767060, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe double ReadDouble()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BsonReader.NativeMethodInfoPtr_ReadDouble_Private_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600158E RID: 5518 RVA: 0x0007563C File Offset: 0x0007383C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 767060, XrefRangeEnd = 767061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int ReadInt32()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BsonReader.NativeMethodInfoPtr_ReadInt32_Private_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600158F RID: 5519 RVA: 0x00075678 File Offset: 0x00073878
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 767061, XrefRangeEnd = 767062, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe long ReadInt64()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BsonReader.NativeMethodInfoPtr_ReadInt64_Private_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001590 RID: 5520 RVA: 0x000756B4 File Offset: 0x000738B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 767062, XrefRangeEnd = 767063, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BsonType ReadType()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BsonReader.NativeMethodInfoPtr_ReadType_Private_BsonType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001591 RID: 5521 RVA: 0x000756F0 File Offset: 0x000738F0
		[CallerCount(0)]
		public unsafe void MovePosition(int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref count;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BsonReader.NativeMethodInfoPtr_MovePosition_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001592 RID: 5522 RVA: 0x00075730 File Offset: 0x00073930
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 767063, XrefRangeEnd = 767064, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStructArray<byte> ReadBytes(int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref count;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BsonReader.NativeMethodInfoPtr_ReadBytes_Private_Il2CppStructArray_1_Byte_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
			}
		}

		// Token: 0x06001593 RID: 5523 RVA: 0x0000869D File Offset: 0x0000689D
		public BsonReader(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000597 RID: 1431
		// (get) Token: 0x06001594 RID: 5524 RVA: 0x0007577C File Offset: 0x0007397C
		// (set) Token: 0x06001595 RID: 5525 RVA: 0x000086A6 File Offset: 0x000068A6
		public unsafe static int MaxCharBytesSize
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(BsonReader.NativeFieldInfoPtr_MaxCharBytesSize, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BsonReader.NativeFieldInfoPtr_MaxCharBytesSize, (void*)(&value));
			}
		}

		// Token: 0x17000598 RID: 1432
		// (get) Token: 0x06001596 RID: 5526 RVA: 0x00075798 File Offset: 0x00073998
		// (set) Token: 0x06001597 RID: 5527 RVA: 0x000086B4 File Offset: 0x000068B4
		public unsafe static Il2CppStructArray<byte> SeqRange1
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BsonReader.NativeFieldInfoPtr_SeqRange1, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BsonReader.NativeFieldInfoPtr_SeqRange1, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000599 RID: 1433
		// (get) Token: 0x06001598 RID: 5528 RVA: 0x000757C0 File Offset: 0x000739C0
		// (set) Token: 0x06001599 RID: 5529 RVA: 0x000086C6 File Offset: 0x000068C6
		public unsafe static Il2CppStructArray<byte> SeqRange2
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BsonReader.NativeFieldInfoPtr_SeqRange2, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BsonReader.NativeFieldInfoPtr_SeqRange2, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700059A RID: 1434
		// (get) Token: 0x0600159A RID: 5530 RVA: 0x000757E8 File Offset: 0x000739E8
		// (set) Token: 0x0600159B RID: 5531 RVA: 0x000086D8 File Offset: 0x000068D8
		public unsafe static Il2CppStructArray<byte> SeqRange3
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BsonReader.NativeFieldInfoPtr_SeqRange3, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BsonReader.NativeFieldInfoPtr_SeqRange3, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700059B RID: 1435
		// (get) Token: 0x0600159C RID: 5532 RVA: 0x00075810 File Offset: 0x00073A10
		// (set) Token: 0x0600159D RID: 5533 RVA: 0x000086EA File Offset: 0x000068EA
		public unsafe static Il2CppStructArray<byte> SeqRange4
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BsonReader.NativeFieldInfoPtr_SeqRange4, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BsonReader.NativeFieldInfoPtr_SeqRange4, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700059C RID: 1436
		// (get) Token: 0x0600159E RID: 5534 RVA: 0x00075838 File Offset: 0x00073A38
		// (set) Token: 0x0600159F RID: 5535 RVA: 0x000086FC File Offset: 0x000068FC
		public unsafe BinaryReader _reader
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BsonReader.NativeFieldInfoPtr__reader);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BinaryReader>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BsonReader.NativeFieldInfoPtr__reader), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700059D RID: 1437
		// (get) Token: 0x060015A0 RID: 5536 RVA: 0x00075868 File Offset: 0x00073A68
		// (set) Token: 0x060015A1 RID: 5537 RVA: 0x0000871B File Offset: 0x0000691B
		public new unsafe List<BsonReader.ContainerContext> _stack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BsonReader.NativeFieldInfoPtr__stack);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<BsonReader.ContainerContext>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BsonReader.NativeFieldInfoPtr__stack), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700059E RID: 1438
		// (get) Token: 0x060015A2 RID: 5538 RVA: 0x00075898 File Offset: 0x00073A98
		// (set) Token: 0x060015A3 RID: 5539 RVA: 0x0000873A File Offset: 0x0000693A
		public unsafe Il2CppStructArray<byte> _byteBuffer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BsonReader.NativeFieldInfoPtr__byteBuffer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BsonReader.NativeFieldInfoPtr__byteBuffer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700059F RID: 1439
		// (get) Token: 0x060015A4 RID: 5540 RVA: 0x000758C8 File Offset: 0x00073AC8
		// (set) Token: 0x060015A5 RID: 5541 RVA: 0x00008759 File Offset: 0x00006959
		public unsafe Il2CppStructArray<char> _charBuffer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BsonReader.NativeFieldInfoPtr__charBuffer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BsonReader.NativeFieldInfoPtr__charBuffer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005A0 RID: 1440
		// (get) Token: 0x060015A6 RID: 5542 RVA: 0x000758F8 File Offset: 0x00073AF8
		// (set) Token: 0x060015A7 RID: 5543 RVA: 0x00008778 File Offset: 0x00006978
		public unsafe BsonType _currentElementType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BsonReader.NativeFieldInfoPtr__currentElementType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BsonReader.NativeFieldInfoPtr__currentElementType)) = value;
			}
		}

		// Token: 0x170005A1 RID: 1441
		// (get) Token: 0x060015A8 RID: 5544 RVA: 0x00075920 File Offset: 0x00073B20
		// (set) Token: 0x060015A9 RID: 5545 RVA: 0x00008793 File Offset: 0x00006993
		public unsafe BsonReader.BsonReaderState _bsonReaderState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BsonReader.NativeFieldInfoPtr__bsonReaderState);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BsonReader.NativeFieldInfoPtr__bsonReaderState)) = value;
			}
		}

		// Token: 0x170005A2 RID: 1442
		// (get) Token: 0x060015AA RID: 5546 RVA: 0x00075948 File Offset: 0x00073B48
		// (set) Token: 0x060015AB RID: 5547 RVA: 0x000087AE File Offset: 0x000069AE
		public unsafe BsonReader.ContainerContext _currentContext
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BsonReader.NativeFieldInfoPtr__currentContext);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BsonReader.ContainerContext>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BsonReader.NativeFieldInfoPtr__currentContext), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005A3 RID: 1443
		// (get) Token: 0x060015AC RID: 5548 RVA: 0x00075978 File Offset: 0x00073B78
		// (set) Token: 0x060015AD RID: 5549 RVA: 0x000087CD File Offset: 0x000069CD
		public unsafe bool _readRootValueAsArray
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BsonReader.NativeFieldInfoPtr__readRootValueAsArray);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BsonReader.NativeFieldInfoPtr__readRootValueAsArray)) = value;
			}
		}

		// Token: 0x170005A4 RID: 1444
		// (get) Token: 0x060015AE RID: 5550 RVA: 0x000759A0 File Offset: 0x00073BA0
		// (set) Token: 0x060015AF RID: 5551 RVA: 0x000087E8 File Offset: 0x000069E8
		public unsafe bool _jsonNet35BinaryCompatibility
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BsonReader.NativeFieldInfoPtr__jsonNet35BinaryCompatibility);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BsonReader.NativeFieldInfoPtr__jsonNet35BinaryCompatibility)) = value;
			}
		}

		// Token: 0x170005A5 RID: 1445
		// (get) Token: 0x060015B0 RID: 5552 RVA: 0x000759C8 File Offset: 0x00073BC8
		// (set) Token: 0x060015B1 RID: 5553 RVA: 0x00008803 File Offset: 0x00006A03
		public unsafe DateTimeKind _dateTimeKindHandling
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BsonReader.NativeFieldInfoPtr__dateTimeKindHandling);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BsonReader.NativeFieldInfoPtr__dateTimeKindHandling)) = value;
			}
		}

		// Token: 0x04001156 RID: 4438
		private static readonly IntPtr NativeFieldInfoPtr_MaxCharBytesSize;

		// Token: 0x04001157 RID: 4439
		private static readonly IntPtr NativeFieldInfoPtr_SeqRange1;

		// Token: 0x04001158 RID: 4440
		private static readonly IntPtr NativeFieldInfoPtr_SeqRange2;

		// Token: 0x04001159 RID: 4441
		private static readonly IntPtr NativeFieldInfoPtr_SeqRange3;

		// Token: 0x0400115A RID: 4442
		private static readonly IntPtr NativeFieldInfoPtr_SeqRange4;

		// Token: 0x0400115B RID: 4443
		private static readonly IntPtr NativeFieldInfoPtr__reader;

		// Token: 0x0400115C RID: 4444
		private static readonly IntPtr NativeFieldInfoPtr__stack;

		// Token: 0x0400115D RID: 4445
		private static readonly IntPtr NativeFieldInfoPtr__byteBuffer;

		// Token: 0x0400115E RID: 4446
		private static readonly IntPtr NativeFieldInfoPtr__charBuffer;

		// Token: 0x0400115F RID: 4447
		private static readonly IntPtr NativeFieldInfoPtr__currentElementType;

		// Token: 0x04001160 RID: 4448
		private static readonly IntPtr NativeFieldInfoPtr__bsonReaderState;

		// Token: 0x04001161 RID: 4449
		private static readonly IntPtr NativeFieldInfoPtr__currentContext;

		// Token: 0x04001162 RID: 4450
		private static readonly IntPtr NativeFieldInfoPtr__readRootValueAsArray;

		// Token: 0x04001163 RID: 4451
		private static readonly IntPtr NativeFieldInfoPtr__jsonNet35BinaryCompatibility;

		// Token: 0x04001164 RID: 4452
		private static readonly IntPtr NativeFieldInfoPtr__dateTimeKindHandling;

		// Token: 0x04001165 RID: 4453
		private static readonly IntPtr NativeMethodInfoPtr_get_JsonNet35BinaryCompatibility_Public_get_Boolean_0;

		// Token: 0x04001166 RID: 4454
		private static readonly IntPtr NativeMethodInfoPtr_set_JsonNet35BinaryCompatibility_Public_set_Void_Boolean_0;

		// Token: 0x04001167 RID: 4455
		private static readonly IntPtr NativeMethodInfoPtr_get_ReadRootValueAsArray_Public_get_Boolean_0;

		// Token: 0x04001168 RID: 4456
		private static readonly IntPtr NativeMethodInfoPtr_set_ReadRootValueAsArray_Public_set_Void_Boolean_0;

		// Token: 0x04001169 RID: 4457
		private static readonly IntPtr NativeMethodInfoPtr_get_DateTimeKindHandling_Public_get_DateTimeKind_0;

		// Token: 0x0400116A RID: 4458
		private static readonly IntPtr NativeMethodInfoPtr_set_DateTimeKindHandling_Public_set_Void_DateTimeKind_0;

		// Token: 0x0400116B RID: 4459
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Stream_0;

		// Token: 0x0400116C RID: 4460
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_BinaryReader_0;

		// Token: 0x0400116D RID: 4461
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Stream_Boolean_DateTimeKind_0;

		// Token: 0x0400116E RID: 4462
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_BinaryReader_Boolean_DateTimeKind_0;

		// Token: 0x0400116F RID: 4463
		private static readonly IntPtr NativeMethodInfoPtr_ReadElement_Private_String_0;

		// Token: 0x04001170 RID: 4464
		private static readonly IntPtr NativeMethodInfoPtr_Read_Public_Virtual_Boolean_0;

		// Token: 0x04001171 RID: 4465
		private static readonly IntPtr NativeMethodInfoPtr_Close_Public_Virtual_Void_0;

		// Token: 0x04001172 RID: 4466
		private static readonly IntPtr NativeMethodInfoPtr_ReadCodeWScope_Private_Boolean_0;

		// Token: 0x04001173 RID: 4467
		private static readonly IntPtr NativeMethodInfoPtr_ReadReference_Private_Boolean_0;

		// Token: 0x04001174 RID: 4468
		private static readonly IntPtr NativeMethodInfoPtr_ReadNormal_Private_Boolean_0;

		// Token: 0x04001175 RID: 4469
		private static readonly IntPtr NativeMethodInfoPtr_PopContext_Private_Void_0;

		// Token: 0x04001176 RID: 4470
		private static readonly IntPtr NativeMethodInfoPtr_PushContext_Private_Void_ContainerContext_0;

		// Token: 0x04001177 RID: 4471
		private static readonly IntPtr NativeMethodInfoPtr_ReadByte_Private_Byte_0;

		// Token: 0x04001178 RID: 4472
		private static readonly IntPtr NativeMethodInfoPtr_ReadType_Private_Void_BsonType_0;

		// Token: 0x04001179 RID: 4473
		private static readonly IntPtr NativeMethodInfoPtr_ReadBinary_Private_Il2CppStructArray_1_Byte_byref_BsonBinaryType_0;

		// Token: 0x0400117A RID: 4474
		private static readonly IntPtr NativeMethodInfoPtr_ReadString_Private_String_0;

		// Token: 0x0400117B RID: 4475
		private static readonly IntPtr NativeMethodInfoPtr_ReadLengthString_Private_String_0;

		// Token: 0x0400117C RID: 4476
		private static readonly IntPtr NativeMethodInfoPtr_GetString_Private_String_Int32_0;

		// Token: 0x0400117D RID: 4477
		private static readonly IntPtr NativeMethodInfoPtr_GetLastFullCharStop_Private_Int32_Int32_0;

		// Token: 0x0400117E RID: 4478
		private static readonly IntPtr NativeMethodInfoPtr_BytesInSequence_Private_Int32_Byte_0;

		// Token: 0x0400117F RID: 4479
		private static readonly IntPtr NativeMethodInfoPtr_EnsureBuffers_Private_Void_0;

		// Token: 0x04001180 RID: 4480
		private static readonly IntPtr NativeMethodInfoPtr_ReadDouble_Private_Double_0;

		// Token: 0x04001181 RID: 4481
		private static readonly IntPtr NativeMethodInfoPtr_ReadInt32_Private_Int32_0;

		// Token: 0x04001182 RID: 4482
		private static readonly IntPtr NativeMethodInfoPtr_ReadInt64_Private_Int64_0;

		// Token: 0x04001183 RID: 4483
		private static readonly IntPtr NativeMethodInfoPtr_ReadType_Private_BsonType_0;

		// Token: 0x04001184 RID: 4484
		private static readonly IntPtr NativeMethodInfoPtr_MovePosition_Private_Void_Int32_0;

		// Token: 0x04001185 RID: 4485
		private static readonly IntPtr NativeMethodInfoPtr_ReadBytes_Private_Il2CppStructArray_1_Byte_Int32_0;

		// Token: 0x02000227 RID: 551
		public enum BsonReaderState
		{
			// Token: 0x040018B9 RID: 6329
			Normal,
			// Token: 0x040018BA RID: 6330
			ReferenceStart,
			// Token: 0x040018BB RID: 6331
			ReferenceRef,
			// Token: 0x040018BC RID: 6332
			ReferenceId,
			// Token: 0x040018BD RID: 6333
			CodeWScopeStart,
			// Token: 0x040018BE RID: 6334
			CodeWScopeCode,
			// Token: 0x040018BF RID: 6335
			CodeWScopeScope,
			// Token: 0x040018C0 RID: 6336
			CodeWScopeScopeObject,
			// Token: 0x040018C1 RID: 6337
			CodeWScopeScopeEnd
		}

		// Token: 0x02000228 RID: 552
		public class ContainerContext : Object
		{
			// Token: 0x060022BA RID: 8890 RVA: 0x000991EC File Offset: 0x000973EC
			// Note: this type is marked as 'beforefieldinit'.
			static ContainerContext()
			{
				Il2CppClassPointerStore<BsonReader.ContainerContext>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BsonReader>.NativeClassPtr, "ContainerContext");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BsonReader.ContainerContext>.NativeClassPtr);
				BsonReader.ContainerContext.NativeFieldInfoPtr_Type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BsonReader.ContainerContext>.NativeClassPtr, "Type");
				BsonReader.ContainerContext.NativeFieldInfoPtr_Length = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BsonReader.ContainerContext>.NativeClassPtr, "Length");
				BsonReader.ContainerContext.NativeFieldInfoPtr_Position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BsonReader.ContainerContext>.NativeClassPtr, "Position");
				BsonReader.ContainerContext.NativeMethodInfoPtr__ctor_Public_Void_BsonType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BsonReader.ContainerContext>.NativeClassPtr, 100667391);
			}

			// Token: 0x060022BB RID: 8891 RVA: 0x00099268 File Offset: 0x00097468
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ContainerContext(BsonType type)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BsonReader.ContainerContext>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref type;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BsonReader.ContainerContext.NativeMethodInfoPtr__ctor_Public_Void_BsonType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060022BC RID: 8892 RVA: 0x00011B49 File Offset: 0x0000FD49
			public ContainerContext(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170009FB RID: 2555
			// (get) Token: 0x060022BD RID: 8893 RVA: 0x000992B0 File Offset: 0x000974B0
			// (set) Token: 0x060022BE RID: 8894 RVA: 0x00011B52 File Offset: 0x0000FD52
			public unsafe BsonType Type
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BsonReader.ContainerContext.NativeFieldInfoPtr_Type);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BsonReader.ContainerContext.NativeFieldInfoPtr_Type)) = value;
				}
			}

			// Token: 0x170009FC RID: 2556
			// (get) Token: 0x060022BF RID: 8895 RVA: 0x000992D8 File Offset: 0x000974D8
			// (set) Token: 0x060022C0 RID: 8896 RVA: 0x00011B6D File Offset: 0x0000FD6D
			public unsafe int Length
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BsonReader.ContainerContext.NativeFieldInfoPtr_Length);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BsonReader.ContainerContext.NativeFieldInfoPtr_Length)) = value;
				}
			}

			// Token: 0x170009FD RID: 2557
			// (get) Token: 0x060022C1 RID: 8897 RVA: 0x00099300 File Offset: 0x00097500
			// (set) Token: 0x060022C2 RID: 8898 RVA: 0x00011B88 File Offset: 0x0000FD88
			public unsafe int Position
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BsonReader.ContainerContext.NativeFieldInfoPtr_Position);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BsonReader.ContainerContext.NativeFieldInfoPtr_Position)) = value;
				}
			}

			// Token: 0x040018C2 RID: 6338
			private static readonly IntPtr NativeFieldInfoPtr_Type;

			// Token: 0x040018C3 RID: 6339
			private static readonly IntPtr NativeFieldInfoPtr_Length;

			// Token: 0x040018C4 RID: 6340
			private static readonly IntPtr NativeFieldInfoPtr_Position;

			// Token: 0x040018C5 RID: 6341
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_BsonType_0;
		}
	}
}
