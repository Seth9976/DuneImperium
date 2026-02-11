using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.IO;
using Il2CppSystem.Text;

namespace Il2CppSystem.Runtime.Serialization.Formatters.Binary
{
	// Token: 0x0200036D RID: 877
	public sealed class __BinaryParser : Object
	{
		// Token: 0x06003617 RID: 13847 RVA: 0x0010B720 File Offset: 0x00109920
		// Note: this type is marked as 'beforefieldinit'.
		static __BinaryParser()
		{
			Il2CppClassPointerStore<__BinaryParser>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Serialization.Formatters.Binary", "__BinaryParser");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__BinaryParser>.NativeClassPtr);
			__BinaryParser.NativeFieldInfoPtr_objectReader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__BinaryParser>.NativeClassPtr, "objectReader");
			__BinaryParser.NativeFieldInfoPtr_input = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__BinaryParser>.NativeClassPtr, "input");
			__BinaryParser.NativeFieldInfoPtr_topId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__BinaryParser>.NativeClassPtr, "topId");
			__BinaryParser.NativeFieldInfoPtr_headerId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__BinaryParser>.NativeClassPtr, "headerId");
			__BinaryParser.NativeFieldInfoPtr_objectMapIdTable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__BinaryParser>.NativeClassPtr, "objectMapIdTable");
			__BinaryParser.NativeFieldInfoPtr_assemIdToAssemblyTable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__BinaryParser>.NativeClassPtr, "assemIdToAssemblyTable");
			__BinaryParser.NativeFieldInfoPtr_stack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__BinaryParser>.NativeClassPtr, "stack");
			__BinaryParser.NativeFieldInfoPtr_expectedType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__BinaryParser>.NativeClassPtr, "expectedType");
			__BinaryParser.NativeFieldInfoPtr_expectedTypeInformation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__BinaryParser>.NativeClassPtr, "expectedTypeInformation");
			__BinaryParser.NativeFieldInfoPtr_PRS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__BinaryParser>.NativeClassPtr, "PRS");
			__BinaryParser.NativeFieldInfoPtr_systemAssemblyInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__BinaryParser>.NativeClassPtr, "systemAssemblyInfo");
			__BinaryParser.NativeFieldInfoPtr_dataReader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__BinaryParser>.NativeClassPtr, "dataReader");
			__BinaryParser.NativeFieldInfoPtr_encoding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__BinaryParser>.NativeClassPtr, "encoding");
			__BinaryParser.NativeFieldInfoPtr_opPool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__BinaryParser>.NativeClassPtr, "opPool");
			__BinaryParser.NativeFieldInfoPtr_binaryObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__BinaryParser>.NativeClassPtr, "binaryObject");
			__BinaryParser.NativeFieldInfoPtr_bowm = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__BinaryParser>.NativeClassPtr, "bowm");
			__BinaryParser.NativeFieldInfoPtr_bowmt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__BinaryParser>.NativeClassPtr, "bowmt");
			__BinaryParser.NativeFieldInfoPtr_objectString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__BinaryParser>.NativeClassPtr, "objectString");
			__BinaryParser.NativeFieldInfoPtr_crossAppDomainString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__BinaryParser>.NativeClassPtr, "crossAppDomainString");
			__BinaryParser.NativeFieldInfoPtr_memberPrimitiveTyped = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__BinaryParser>.NativeClassPtr, "memberPrimitiveTyped");
			__BinaryParser.NativeFieldInfoPtr_byteBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__BinaryParser>.NativeClassPtr, "byteBuffer");
			__BinaryParser.NativeFieldInfoPtr_memberPrimitiveUnTyped = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__BinaryParser>.NativeClassPtr, "memberPrimitiveUnTyped");
			__BinaryParser.NativeFieldInfoPtr_memberReference = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__BinaryParser>.NativeClassPtr, "memberReference");
			__BinaryParser.NativeFieldInfoPtr_objectNull = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__BinaryParser>.NativeClassPtr, "objectNull");
			__BinaryParser.NativeFieldInfoPtr_messageEnd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__BinaryParser>.NativeClassPtr, "messageEnd");
			__BinaryParser.NativeMethodInfoPtr__ctor_Internal_Void_Stream_ObjectReader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__BinaryParser>.NativeClassPtr, 100671509);
			__BinaryParser.NativeMethodInfoPtr_get_SystemAssemblyInfo_Internal_get_BinaryAssemblyInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__BinaryParser>.NativeClassPtr, 100671510);
			__BinaryParser.NativeMethodInfoPtr_get_ObjectMapIdTable_Internal_get_SizedArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__BinaryParser>.NativeClassPtr, 100671511);
			__BinaryParser.NativeMethodInfoPtr_get_AssemIdToAssemblyTable_Internal_get_SizedArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__BinaryParser>.NativeClassPtr, 100671512);
			__BinaryParser.NativeMethodInfoPtr_get_prs_Internal_get_ParseRecord_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__BinaryParser>.NativeClassPtr, 100671513);
			__BinaryParser.NativeMethodInfoPtr_Run_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__BinaryParser>.NativeClassPtr, 100671514);
			__BinaryParser.NativeMethodInfoPtr_ReadBegin_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__BinaryParser>.NativeClassPtr, 100671515);
			__BinaryParser.NativeMethodInfoPtr_ReadEnd_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__BinaryParser>.NativeClassPtr, 100671516);
			__BinaryParser.NativeMethodInfoPtr_ReadBoolean_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__BinaryParser>.NativeClassPtr, 100671517);
			__BinaryParser.NativeMethodInfoPtr_ReadByte_Internal_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__BinaryParser>.NativeClassPtr, 100671518);
			__BinaryParser.NativeMethodInfoPtr_ReadBytes_Internal_Il2CppStructArray_1_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__BinaryParser>.NativeClassPtr, 100671519);
			__BinaryParser.NativeMethodInfoPtr_ReadBytes_Internal_Void_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__BinaryParser>.NativeClassPtr, 100671520);
			__BinaryParser.NativeMethodInfoPtr_ReadChar_Internal_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__BinaryParser>.NativeClassPtr, 100671521);
			__BinaryParser.NativeMethodInfoPtr_ReadChars_Internal_Il2CppStructArray_1_Char_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__BinaryParser>.NativeClassPtr, 100671522);
			__BinaryParser.NativeMethodInfoPtr_ReadDecimal_Internal_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__BinaryParser>.NativeClassPtr, 100671523);
			__BinaryParser.NativeMethodInfoPtr_ReadSingle_Internal_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__BinaryParser>.NativeClassPtr, 100671524);
			__BinaryParser.NativeMethodInfoPtr_ReadDouble_Internal_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__BinaryParser>.NativeClassPtr, 100671525);
			__BinaryParser.NativeMethodInfoPtr_ReadInt16_Internal_Int16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__BinaryParser>.NativeClassPtr, 100671526);
			__BinaryParser.NativeMethodInfoPtr_ReadInt32_Internal_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__BinaryParser>.NativeClassPtr, 100671527);
			__BinaryParser.NativeMethodInfoPtr_ReadInt64_Internal_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__BinaryParser>.NativeClassPtr, 100671528);
			__BinaryParser.NativeMethodInfoPtr_ReadSByte_Internal_SByte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__BinaryParser>.NativeClassPtr, 100671529);
			__BinaryParser.NativeMethodInfoPtr_ReadString_Internal_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__BinaryParser>.NativeClassPtr, 100671530);
			__BinaryParser.NativeMethodInfoPtr_ReadTimeSpan_Internal_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__BinaryParser>.NativeClassPtr, 100671531);
			__BinaryParser.NativeMethodInfoPtr_ReadDateTime_Internal_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__BinaryParser>.NativeClassPtr, 100671532);
			__BinaryParser.NativeMethodInfoPtr_ReadUInt16_Internal_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__BinaryParser>.NativeClassPtr, 100671533);
			__BinaryParser.NativeMethodInfoPtr_ReadUInt32_Internal_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__BinaryParser>.NativeClassPtr, 100671534);
			__BinaryParser.NativeMethodInfoPtr_ReadUInt64_Internal_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__BinaryParser>.NativeClassPtr, 100671535);
			__BinaryParser.NativeMethodInfoPtr_ReadSerializationHeaderRecord_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__BinaryParser>.NativeClassPtr, 100671536);
			__BinaryParser.NativeMethodInfoPtr_ReadAssembly_Internal_Void_BinaryHeaderEnum_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__BinaryParser>.NativeClassPtr, 100671537);
			__BinaryParser.NativeMethodInfoPtr_ReadObject_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__BinaryParser>.NativeClassPtr, 100671538);
			__BinaryParser.NativeMethodInfoPtr_ReadCrossAppDomainMap_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__BinaryParser>.NativeClassPtr, 100671539);
			__BinaryParser.NativeMethodInfoPtr_ReadObjectWithMap_Internal_Void_BinaryHeaderEnum_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__BinaryParser>.NativeClassPtr, 100671540);
			__BinaryParser.NativeMethodInfoPtr_ReadObjectWithMap_Private_Void_BinaryObjectWithMap_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__BinaryParser>.NativeClassPtr, 100671541);
			__BinaryParser.NativeMethodInfoPtr_ReadObjectWithMapTyped_Internal_Void_BinaryHeaderEnum_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__BinaryParser>.NativeClassPtr, 100671542);
			__BinaryParser.NativeMethodInfoPtr_ReadObjectWithMapTyped_Private_Void_BinaryObjectWithMapTyped_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__BinaryParser>.NativeClassPtr, 100671543);
			__BinaryParser.NativeMethodInfoPtr_ReadObjectString_Private_Void_BinaryHeaderEnum_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__BinaryParser>.NativeClassPtr, 100671544);
			__BinaryParser.NativeMethodInfoPtr_ReadMemberPrimitiveTyped_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__BinaryParser>.NativeClassPtr, 100671545);
			__BinaryParser.NativeMethodInfoPtr_ReadArray_Private_Void_BinaryHeaderEnum_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__BinaryParser>.NativeClassPtr, 100671546);
			__BinaryParser.NativeMethodInfoPtr_ReadArrayAsBytes_Private_Void_ParseRecord_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__BinaryParser>.NativeClassPtr, 100671547);
			__BinaryParser.NativeMethodInfoPtr_ReadMemberPrimitiveUnTyped_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__BinaryParser>.NativeClassPtr, 100671548);
			__BinaryParser.NativeMethodInfoPtr_ReadMemberReference_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__BinaryParser>.NativeClassPtr, 100671549);
			__BinaryParser.NativeMethodInfoPtr_ReadObjectNull_Private_Void_BinaryHeaderEnum_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__BinaryParser>.NativeClassPtr, 100671550);
			__BinaryParser.NativeMethodInfoPtr_ReadMessageEnd_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__BinaryParser>.NativeClassPtr, 100671551);
			__BinaryParser.NativeMethodInfoPtr_ReadValue_Internal_Object_InternalPrimitiveTypeE_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__BinaryParser>.NativeClassPtr, 100671552);
			__BinaryParser.NativeMethodInfoPtr_GetOp_Private_ObjectProgress_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__BinaryParser>.NativeClassPtr, 100671553);
			__BinaryParser.NativeMethodInfoPtr_PutOp_Private_Void_ObjectProgress_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__BinaryParser>.NativeClassPtr, 100671554);
		}

		// Token: 0x06003618 RID: 13848 RVA: 0x0010BCDC File Offset: 0x00109EDC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1389783, RefRangeEnd = 1389784, XrefRangeStart = 1389764, XrefRangeEnd = 1389783, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __BinaryParser(Stream stream, ObjectReader objectReader)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__BinaryParser>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stream);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(objectReader);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__BinaryParser.NativeMethodInfoPtr__ctor_Internal_Void_Stream_ObjectReader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000CAB RID: 3243
		// (get) Token: 0x06003619 RID: 13849 RVA: 0x0010BD3C File Offset: 0x00109F3C
		public unsafe BinaryAssemblyInfo SystemAssemblyInfo
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 1389793, RefRangeEnd = 1389796, XrefRangeStart = 1389784, XrefRangeEnd = 1389793, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__BinaryParser.NativeMethodInfoPtr_get_SystemAssemblyInfo_Internal_get_BinaryAssemblyInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<BinaryAssemblyInfo>(intPtr3) : null;
			}
		}

		// Token: 0x17000CAC RID: 3244
		// (get) Token: 0x0600361A RID: 13850 RVA: 0x0010BD7C File Offset: 0x00109F7C
		public unsafe SizedArray ObjectMapIdTable
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 1389808, RefRangeEnd = 1389811, XrefRangeStart = 1389796, XrefRangeEnd = 1389808, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__BinaryParser.NativeMethodInfoPtr_get_ObjectMapIdTable_Internal_get_SizedArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SizedArray>(intPtr3) : null;
			}
		}

		// Token: 0x17000CAD RID: 3245
		// (get) Token: 0x0600361B RID: 13851 RVA: 0x0010BDBC File Offset: 0x00109FBC
		public unsafe SizedArray AssemIdToAssemblyTable
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 1389823, RefRangeEnd = 1389828, XrefRangeStart = 1389811, XrefRangeEnd = 1389823, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__BinaryParser.NativeMethodInfoPtr_get_AssemIdToAssemblyTable_Internal_get_SizedArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SizedArray>(intPtr3) : null;
			}
		}

		// Token: 0x17000CAE RID: 3246
		// (get) Token: 0x0600361C RID: 13852 RVA: 0x0010BDFC File Offset: 0x00109FFC
		public unsafe ParseRecord prs
		{
			[CallerCount(34)]
			[CachedScanResults(RefRangeStart = 1389833, RefRangeEnd = 1389867, XrefRangeStart = 1389828, XrefRangeEnd = 1389833, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__BinaryParser.NativeMethodInfoPtr_get_prs_Internal_get_ParseRecord_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ParseRecord>(intPtr3) : null;
			}
		}

		// Token: 0x0600361D RID: 13853 RVA: 0x0010BE3C File Offset: 0x0010A03C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1389923, RefRangeEnd = 1389924, XrefRangeStart = 1389867, XrefRangeEnd = 1389923, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Run()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__BinaryParser.NativeMethodInfoPtr_Run_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600361E RID: 13854 RVA: 0x0010BE70 File Offset: 0x0010A070
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReadBegin()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__BinaryParser.NativeMethodInfoPtr_ReadBegin_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600361F RID: 13855 RVA: 0x0010BEA4 File Offset: 0x0010A0A4
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReadEnd()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__BinaryParser.NativeMethodInfoPtr_ReadEnd_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003620 RID: 13856 RVA: 0x0010BED8 File Offset: 0x0010A0D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1389924, XrefRangeEnd = 1389925, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ReadBoolean()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__BinaryParser.NativeMethodInfoPtr_ReadBoolean_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003621 RID: 13857 RVA: 0x0010BF14 File Offset: 0x0010A114
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1389926, RefRangeEnd = 1389931, XrefRangeStart = 1389925, XrefRangeEnd = 1389926, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe byte ReadByte()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__BinaryParser.NativeMethodInfoPtr_ReadByte_Internal_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003622 RID: 13858 RVA: 0x0010BF50 File Offset: 0x0010A150
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1389932, RefRangeEnd = 1389933, XrefRangeStart = 1389931, XrefRangeEnd = 1389932, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStructArray<byte> ReadBytes(int length)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref length;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__BinaryParser.NativeMethodInfoPtr_ReadBytes_Internal_Il2CppStructArray_1_Byte_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
			}
		}

		// Token: 0x06003623 RID: 13859 RVA: 0x0010BF9C File Offset: 0x0010A19C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1389933, XrefRangeEnd = 1389934, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReadBytes(Il2CppStructArray<byte> byteA, int offset, int size)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(byteA);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__BinaryParser.NativeMethodInfoPtr_ReadBytes_Internal_Void_Il2CppStructArray_1_Byte_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003624 RID: 13860 RVA: 0x0010BFFC File Offset: 0x0010A1FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1389934, XrefRangeEnd = 1389935, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe char ReadChar()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__BinaryParser.NativeMethodInfoPtr_ReadChar_Internal_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003625 RID: 13861 RVA: 0x0010C038 File Offset: 0x0010A238
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1389935, XrefRangeEnd = 1389936, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStructArray<char> ReadChars(int length)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref length;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__BinaryParser.NativeMethodInfoPtr_ReadChars_Internal_Il2CppStructArray_1_Char_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr3) : null;
			}
		}

		// Token: 0x06003626 RID: 13862 RVA: 0x0010C084 File Offset: 0x0010A284
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1389936, XrefRangeEnd = 1389944, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Decimal ReadDecimal()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__BinaryParser.NativeMethodInfoPtr_ReadDecimal_Internal_Decimal_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003627 RID: 13863 RVA: 0x0010C0C0 File Offset: 0x0010A2C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1389944, XrefRangeEnd = 1389945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float ReadSingle()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__BinaryParser.NativeMethodInfoPtr_ReadSingle_Internal_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003628 RID: 13864 RVA: 0x0010C0FC File Offset: 0x0010A2FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1389945, XrefRangeEnd = 1389946, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe double ReadDouble()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__BinaryParser.NativeMethodInfoPtr_ReadDouble_Internal_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003629 RID: 13865 RVA: 0x0010C138 File Offset: 0x0010A338
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1389946, XrefRangeEnd = 1389947, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe short ReadInt16()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__BinaryParser.NativeMethodInfoPtr_ReadInt16_Internal_Int16_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600362A RID: 13866 RVA: 0x0010C174 File Offset: 0x0010A374
		[CallerCount(26)]
		[CachedScanResults(RefRangeStart = 1389948, RefRangeEnd = 1389974, XrefRangeStart = 1389947, XrefRangeEnd = 1389948, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int ReadInt32()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__BinaryParser.NativeMethodInfoPtr_ReadInt32_Internal_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600362B RID: 13867 RVA: 0x0010C1B0 File Offset: 0x0010A3B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1389974, XrefRangeEnd = 1389975, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe long ReadInt64()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__BinaryParser.NativeMethodInfoPtr_ReadInt64_Internal_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600362C RID: 13868 RVA: 0x0010C1EC File Offset: 0x0010A3EC
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1389926, RefRangeEnd = 1389931, XrefRangeStart = 1389926, XrefRangeEnd = 1389931, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe sbyte ReadSByte()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__BinaryParser.NativeMethodInfoPtr_ReadSByte_Internal_SByte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600362D RID: 13869 RVA: 0x0010C228 File Offset: 0x0010A428
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 1389976, RefRangeEnd = 1389985, XrefRangeStart = 1389975, XrefRangeEnd = 1389976, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string ReadString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__BinaryParser.NativeMethodInfoPtr_ReadString_Internal_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600362E RID: 13870 RVA: 0x0010C260 File Offset: 0x0010A460
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TimeSpan ReadTimeSpan()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__BinaryParser.NativeMethodInfoPtr_ReadTimeSpan_Internal_TimeSpan_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600362F RID: 13871 RVA: 0x0010C29C File Offset: 0x0010A49C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1389985, XrefRangeEnd = 1389990, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DateTime ReadDateTime()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__BinaryParser.NativeMethodInfoPtr_ReadDateTime_Internal_DateTime_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003630 RID: 13872 RVA: 0x0010C2D8 File Offset: 0x0010A4D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1389990, XrefRangeEnd = 1389991, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ushort ReadUInt16()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__BinaryParser.NativeMethodInfoPtr_ReadUInt16_Internal_UInt16_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003631 RID: 13873 RVA: 0x0010C314 File Offset: 0x0010A514
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1389991, XrefRangeEnd = 1389992, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe uint ReadUInt32()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__BinaryParser.NativeMethodInfoPtr_ReadUInt32_Internal_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003632 RID: 13874 RVA: 0x0010C350 File Offset: 0x0010A550
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1389992, XrefRangeEnd = 1389993, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ulong ReadUInt64()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__BinaryParser.NativeMethodInfoPtr_ReadUInt64_Internal_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003633 RID: 13875 RVA: 0x0010C38C File Offset: 0x0010A58C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1389993, XrefRangeEnd = 1390001, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReadSerializationHeaderRecord()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__BinaryParser.NativeMethodInfoPtr_ReadSerializationHeaderRecord_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003634 RID: 13876 RVA: 0x0010C3C0 File Offset: 0x0010A5C0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1390047, RefRangeEnd = 1390048, XrefRangeStart = 1390001, XrefRangeEnd = 1390047, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReadAssembly(BinaryHeaderEnum binaryHeaderEnum)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref binaryHeaderEnum;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__BinaryParser.NativeMethodInfoPtr_ReadAssembly_Internal_Void_BinaryHeaderEnum_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003635 RID: 13877 RVA: 0x0010C400 File Offset: 0x0010A600
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1390112, RefRangeEnd = 1390113, XrefRangeStart = 1390048, XrefRangeEnd = 1390112, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReadObject()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__BinaryParser.NativeMethodInfoPtr_ReadObject_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003636 RID: 13878 RVA: 0x0010C434 File Offset: 0x0010A634
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1390145, RefRangeEnd = 1390146, XrefRangeStart = 1390113, XrefRangeEnd = 1390145, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReadCrossAppDomainMap()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__BinaryParser.NativeMethodInfoPtr_ReadCrossAppDomainMap_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003637 RID: 13879 RVA: 0x0010C468 File Offset: 0x0010A668
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1390156, RefRangeEnd = 1390157, XrefRangeStart = 1390146, XrefRangeEnd = 1390156, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReadObjectWithMap(BinaryHeaderEnum binaryHeaderEnum)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref binaryHeaderEnum;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__BinaryParser.NativeMethodInfoPtr_ReadObjectWithMap_Internal_Void_BinaryHeaderEnum_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003638 RID: 13880 RVA: 0x0010C4A8 File Offset: 0x0010A6A8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1390235, RefRangeEnd = 1390237, XrefRangeStart = 1390157, XrefRangeEnd = 1390235, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReadObjectWithMap(BinaryObjectWithMap record)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(record);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__BinaryParser.NativeMethodInfoPtr_ReadObjectWithMap_Private_Void_BinaryObjectWithMap_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003639 RID: 13881 RVA: 0x0010C4EC File Offset: 0x0010A6EC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1390246, RefRangeEnd = 1390247, XrefRangeStart = 1390237, XrefRangeEnd = 1390246, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReadObjectWithMapTyped(BinaryHeaderEnum binaryHeaderEnum)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref binaryHeaderEnum;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__BinaryParser.NativeMethodInfoPtr_ReadObjectWithMapTyped_Internal_Void_BinaryHeaderEnum_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600363A RID: 13882 RVA: 0x0010C52C File Offset: 0x0010A72C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1390325, RefRangeEnd = 1390327, XrefRangeStart = 1390247, XrefRangeEnd = 1390325, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReadObjectWithMapTyped(BinaryObjectWithMapTyped record)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(record);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__BinaryParser.NativeMethodInfoPtr_ReadObjectWithMapTyped_Private_Void_BinaryObjectWithMapTyped_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600363B RID: 13883 RVA: 0x0010C570 File Offset: 0x0010A770
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1390472, RefRangeEnd = 1390473, XrefRangeStart = 1390327, XrefRangeEnd = 1390472, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReadObjectString(BinaryHeaderEnum binaryHeaderEnum)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref binaryHeaderEnum;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__BinaryParser.NativeMethodInfoPtr_ReadObjectString_Private_Void_BinaryHeaderEnum_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600363C RID: 13884 RVA: 0x0010C5B0 File Offset: 0x0010A7B0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1390560, RefRangeEnd = 1390561, XrefRangeStart = 1390473, XrefRangeEnd = 1390560, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReadMemberPrimitiveTyped()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__BinaryParser.NativeMethodInfoPtr_ReadMemberPrimitiveTyped_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600363D RID: 13885 RVA: 0x0010C5E4 File Offset: 0x0010A7E4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1390603, RefRangeEnd = 1390604, XrefRangeStart = 1390561, XrefRangeEnd = 1390603, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReadArray(BinaryHeaderEnum binaryHeaderEnum)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref binaryHeaderEnum;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__BinaryParser.NativeMethodInfoPtr_ReadArray_Private_Void_BinaryHeaderEnum_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600363E RID: 13886 RVA: 0x0010C624 File Offset: 0x0010A824
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1390627, RefRangeEnd = 1390628, XrefRangeStart = 1390604, XrefRangeEnd = 1390627, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReadArrayAsBytes(ParseRecord pr)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pr);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__BinaryParser.NativeMethodInfoPtr_ReadArrayAsBytes_Private_Void_ParseRecord_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600363F RID: 13887 RVA: 0x0010C668 File Offset: 0x0010A868
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1390701, RefRangeEnd = 1390702, XrefRangeStart = 1390628, XrefRangeEnd = 1390701, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReadMemberPrimitiveUnTyped()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__BinaryParser.NativeMethodInfoPtr_ReadMemberPrimitiveUnTyped_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003640 RID: 13888 RVA: 0x0010C69C File Offset: 0x0010A89C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1390750, RefRangeEnd = 1390751, XrefRangeStart = 1390702, XrefRangeEnd = 1390750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReadMemberReference()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__BinaryParser.NativeMethodInfoPtr_ReadMemberReference_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003641 RID: 13889 RVA: 0x0010C6D0 File Offset: 0x0010A8D0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1390795, RefRangeEnd = 1390796, XrefRangeStart = 1390751, XrefRangeEnd = 1390795, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReadObjectNull(BinaryHeaderEnum binaryHeaderEnum)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref binaryHeaderEnum;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__BinaryParser.NativeMethodInfoPtr_ReadObjectNull_Private_Void_BinaryHeaderEnum_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003642 RID: 13890 RVA: 0x0010C710 File Offset: 0x0010A910
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1390819, RefRangeEnd = 1390820, XrefRangeStart = 1390796, XrefRangeEnd = 1390819, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReadMessageEnd()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__BinaryParser.NativeMethodInfoPtr_ReadMessageEnd_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003643 RID: 13891 RVA: 0x0010C744 File Offset: 0x0010A944
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1390877, RefRangeEnd = 1390879, XrefRangeStart = 1390820, XrefRangeEnd = 1390877, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object ReadValue(InternalPrimitiveTypeE code)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref code;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__BinaryParser.NativeMethodInfoPtr_ReadValue_Internal_Object_InternalPrimitiveTypeE_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06003644 RID: 13892 RVA: 0x0010C790 File Offset: 0x0010A990
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1390883, RefRangeEnd = 1390887, XrefRangeStart = 1390879, XrefRangeEnd = 1390883, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ObjectProgress GetOp()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__BinaryParser.NativeMethodInfoPtr_GetOp_Private_ObjectProgress_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ObjectProgress>(intPtr3) : null;
		}

		// Token: 0x06003645 RID: 13893 RVA: 0x0010C7D0 File Offset: 0x0010A9D0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1390896, RefRangeEnd = 1390898, XrefRangeStart = 1390887, XrefRangeEnd = 1390896, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PutOp(ObjectProgress op)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(op);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__BinaryParser.NativeMethodInfoPtr_PutOp_Private_Void_ObjectProgress_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003646 RID: 13894 RVA: 0x000136FB File Offset: 0x000118FB
		public __BinaryParser(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000C92 RID: 3218
		// (get) Token: 0x06003647 RID: 13895 RVA: 0x0010C814 File Offset: 0x0010AA14
		// (set) Token: 0x06003648 RID: 13896 RVA: 0x00013704 File Offset: 0x00011904
		public unsafe ObjectReader objectReader
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(__BinaryParser.NativeFieldInfoPtr_objectReader);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectReader>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(__BinaryParser.NativeFieldInfoPtr_objectReader), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C93 RID: 3219
		// (get) Token: 0x06003649 RID: 13897 RVA: 0x0010C844 File Offset: 0x0010AA44
		// (set) Token: 0x0600364A RID: 13898 RVA: 0x00013723 File Offset: 0x00011923
		public unsafe Stream input
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(__BinaryParser.NativeFieldInfoPtr_input);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Stream>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(__BinaryParser.NativeFieldInfoPtr_input), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C94 RID: 3220
		// (get) Token: 0x0600364B RID: 13899 RVA: 0x0010C874 File Offset: 0x0010AA74
		// (set) Token: 0x0600364C RID: 13900 RVA: 0x00013742 File Offset: 0x00011942
		public unsafe long topId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(__BinaryParser.NativeFieldInfoPtr_topId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(__BinaryParser.NativeFieldInfoPtr_topId)) = value;
			}
		}

		// Token: 0x17000C95 RID: 3221
		// (get) Token: 0x0600364D RID: 13901 RVA: 0x0010C89C File Offset: 0x0010AA9C
		// (set) Token: 0x0600364E RID: 13902 RVA: 0x0001375D File Offset: 0x0001195D
		public unsafe long headerId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(__BinaryParser.NativeFieldInfoPtr_headerId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(__BinaryParser.NativeFieldInfoPtr_headerId)) = value;
			}
		}

		// Token: 0x17000C96 RID: 3222
		// (get) Token: 0x0600364F RID: 13903 RVA: 0x0010C8C4 File Offset: 0x0010AAC4
		// (set) Token: 0x06003650 RID: 13904 RVA: 0x00013778 File Offset: 0x00011978
		public unsafe SizedArray objectMapIdTable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(__BinaryParser.NativeFieldInfoPtr_objectMapIdTable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SizedArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(__BinaryParser.NativeFieldInfoPtr_objectMapIdTable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C97 RID: 3223
		// (get) Token: 0x06003651 RID: 13905 RVA: 0x0010C8F4 File Offset: 0x0010AAF4
		// (set) Token: 0x06003652 RID: 13906 RVA: 0x00013797 File Offset: 0x00011997
		public unsafe SizedArray assemIdToAssemblyTable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(__BinaryParser.NativeFieldInfoPtr_assemIdToAssemblyTable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SizedArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(__BinaryParser.NativeFieldInfoPtr_assemIdToAssemblyTable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C98 RID: 3224
		// (get) Token: 0x06003653 RID: 13907 RVA: 0x0010C924 File Offset: 0x0010AB24
		// (set) Token: 0x06003654 RID: 13908 RVA: 0x000137B6 File Offset: 0x000119B6
		public unsafe SerStack stack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(__BinaryParser.NativeFieldInfoPtr_stack);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SerStack>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(__BinaryParser.NativeFieldInfoPtr_stack), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C99 RID: 3225
		// (get) Token: 0x06003655 RID: 13909 RVA: 0x0010C954 File Offset: 0x0010AB54
		// (set) Token: 0x06003656 RID: 13910 RVA: 0x000137D5 File Offset: 0x000119D5
		public unsafe BinaryTypeEnum expectedType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(__BinaryParser.NativeFieldInfoPtr_expectedType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(__BinaryParser.NativeFieldInfoPtr_expectedType)) = value;
			}
		}

		// Token: 0x17000C9A RID: 3226
		// (get) Token: 0x06003657 RID: 13911 RVA: 0x0010C97C File Offset: 0x0010AB7C
		// (set) Token: 0x06003658 RID: 13912 RVA: 0x000137F0 File Offset: 0x000119F0
		public unsafe Object expectedTypeInformation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(__BinaryParser.NativeFieldInfoPtr_expectedTypeInformation);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(__BinaryParser.NativeFieldInfoPtr_expectedTypeInformation), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C9B RID: 3227
		// (get) Token: 0x06003659 RID: 13913 RVA: 0x0010C9AC File Offset: 0x0010ABAC
		// (set) Token: 0x0600365A RID: 13914 RVA: 0x0001380F File Offset: 0x00011A0F
		public unsafe ParseRecord PRS
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(__BinaryParser.NativeFieldInfoPtr_PRS);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ParseRecord>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(__BinaryParser.NativeFieldInfoPtr_PRS), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C9C RID: 3228
		// (get) Token: 0x0600365B RID: 13915 RVA: 0x0010C9DC File Offset: 0x0010ABDC
		// (set) Token: 0x0600365C RID: 13916 RVA: 0x0001382E File Offset: 0x00011A2E
		public unsafe BinaryAssemblyInfo systemAssemblyInfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(__BinaryParser.NativeFieldInfoPtr_systemAssemblyInfo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BinaryAssemblyInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(__BinaryParser.NativeFieldInfoPtr_systemAssemblyInfo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C9D RID: 3229
		// (get) Token: 0x0600365D RID: 13917 RVA: 0x0010CA0C File Offset: 0x0010AC0C
		// (set) Token: 0x0600365E RID: 13918 RVA: 0x0001384D File Offset: 0x00011A4D
		public unsafe BinaryReader dataReader
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(__BinaryParser.NativeFieldInfoPtr_dataReader);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BinaryReader>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(__BinaryParser.NativeFieldInfoPtr_dataReader), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C9E RID: 3230
		// (get) Token: 0x0600365F RID: 13919 RVA: 0x0010CA3C File Offset: 0x0010AC3C
		// (set) Token: 0x06003660 RID: 13920 RVA: 0x0001386C File Offset: 0x00011A6C
		public unsafe static Encoding encoding
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(__BinaryParser.NativeFieldInfoPtr_encoding, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Encoding>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(__BinaryParser.NativeFieldInfoPtr_encoding, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C9F RID: 3231
		// (get) Token: 0x06003661 RID: 13921 RVA: 0x0010CA64 File Offset: 0x0010AC64
		// (set) Token: 0x06003662 RID: 13922 RVA: 0x0001387E File Offset: 0x00011A7E
		public unsafe SerStack opPool
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(__BinaryParser.NativeFieldInfoPtr_opPool);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SerStack>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(__BinaryParser.NativeFieldInfoPtr_opPool), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CA0 RID: 3232
		// (get) Token: 0x06003663 RID: 13923 RVA: 0x0010CA94 File Offset: 0x0010AC94
		// (set) Token: 0x06003664 RID: 13924 RVA: 0x0001389D File Offset: 0x00011A9D
		public unsafe BinaryObject binaryObject
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(__BinaryParser.NativeFieldInfoPtr_binaryObject);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BinaryObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(__BinaryParser.NativeFieldInfoPtr_binaryObject), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CA1 RID: 3233
		// (get) Token: 0x06003665 RID: 13925 RVA: 0x0010CAC4 File Offset: 0x0010ACC4
		// (set) Token: 0x06003666 RID: 13926 RVA: 0x000138BC File Offset: 0x00011ABC
		public unsafe BinaryObjectWithMap bowm
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(__BinaryParser.NativeFieldInfoPtr_bowm);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BinaryObjectWithMap>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(__BinaryParser.NativeFieldInfoPtr_bowm), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CA2 RID: 3234
		// (get) Token: 0x06003667 RID: 13927 RVA: 0x0010CAF4 File Offset: 0x0010ACF4
		// (set) Token: 0x06003668 RID: 13928 RVA: 0x000138DB File Offset: 0x00011ADB
		public unsafe BinaryObjectWithMapTyped bowmt
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(__BinaryParser.NativeFieldInfoPtr_bowmt);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BinaryObjectWithMapTyped>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(__BinaryParser.NativeFieldInfoPtr_bowmt), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CA3 RID: 3235
		// (get) Token: 0x06003669 RID: 13929 RVA: 0x0010CB24 File Offset: 0x0010AD24
		// (set) Token: 0x0600366A RID: 13930 RVA: 0x000138FA File Offset: 0x00011AFA
		public unsafe BinaryObjectString objectString
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(__BinaryParser.NativeFieldInfoPtr_objectString);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BinaryObjectString>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(__BinaryParser.NativeFieldInfoPtr_objectString), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CA4 RID: 3236
		// (get) Token: 0x0600366B RID: 13931 RVA: 0x0010CB54 File Offset: 0x0010AD54
		// (set) Token: 0x0600366C RID: 13932 RVA: 0x00013919 File Offset: 0x00011B19
		public unsafe BinaryCrossAppDomainString crossAppDomainString
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(__BinaryParser.NativeFieldInfoPtr_crossAppDomainString);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BinaryCrossAppDomainString>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(__BinaryParser.NativeFieldInfoPtr_crossAppDomainString), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CA5 RID: 3237
		// (get) Token: 0x0600366D RID: 13933 RVA: 0x0010CB84 File Offset: 0x0010AD84
		// (set) Token: 0x0600366E RID: 13934 RVA: 0x00013938 File Offset: 0x00011B38
		public unsafe MemberPrimitiveTyped memberPrimitiveTyped
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(__BinaryParser.NativeFieldInfoPtr_memberPrimitiveTyped);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MemberPrimitiveTyped>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(__BinaryParser.NativeFieldInfoPtr_memberPrimitiveTyped), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CA6 RID: 3238
		// (get) Token: 0x0600366F RID: 13935 RVA: 0x0010CBB4 File Offset: 0x0010ADB4
		// (set) Token: 0x06003670 RID: 13936 RVA: 0x00013957 File Offset: 0x00011B57
		public unsafe Il2CppStructArray<byte> byteBuffer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(__BinaryParser.NativeFieldInfoPtr_byteBuffer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(__BinaryParser.NativeFieldInfoPtr_byteBuffer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CA7 RID: 3239
		// (get) Token: 0x06003671 RID: 13937 RVA: 0x0010CBE4 File Offset: 0x0010ADE4
		// (set) Token: 0x06003672 RID: 13938 RVA: 0x00013976 File Offset: 0x00011B76
		public unsafe MemberPrimitiveUnTyped memberPrimitiveUnTyped
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(__BinaryParser.NativeFieldInfoPtr_memberPrimitiveUnTyped);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MemberPrimitiveUnTyped>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(__BinaryParser.NativeFieldInfoPtr_memberPrimitiveUnTyped), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CA8 RID: 3240
		// (get) Token: 0x06003673 RID: 13939 RVA: 0x0010CC14 File Offset: 0x0010AE14
		// (set) Token: 0x06003674 RID: 13940 RVA: 0x00013995 File Offset: 0x00011B95
		public unsafe MemberReference memberReference
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(__BinaryParser.NativeFieldInfoPtr_memberReference);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MemberReference>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(__BinaryParser.NativeFieldInfoPtr_memberReference), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CA9 RID: 3241
		// (get) Token: 0x06003675 RID: 13941 RVA: 0x0010CC44 File Offset: 0x0010AE44
		// (set) Token: 0x06003676 RID: 13942 RVA: 0x000139B4 File Offset: 0x00011BB4
		public unsafe ObjectNull objectNull
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(__BinaryParser.NativeFieldInfoPtr_objectNull);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectNull>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(__BinaryParser.NativeFieldInfoPtr_objectNull), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CAA RID: 3242
		// (get) Token: 0x06003677 RID: 13943 RVA: 0x0010CC74 File Offset: 0x0010AE74
		// (set) Token: 0x06003678 RID: 13944 RVA: 0x000139D3 File Offset: 0x00011BD3
		public unsafe static MessageEnd messageEnd
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(__BinaryParser.NativeFieldInfoPtr_messageEnd, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MessageEnd>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(__BinaryParser.NativeFieldInfoPtr_messageEnd, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002C24 RID: 11300
		private static readonly IntPtr NativeFieldInfoPtr_objectReader;

		// Token: 0x04002C25 RID: 11301
		private static readonly IntPtr NativeFieldInfoPtr_input;

		// Token: 0x04002C26 RID: 11302
		private static readonly IntPtr NativeFieldInfoPtr_topId;

		// Token: 0x04002C27 RID: 11303
		private static readonly IntPtr NativeFieldInfoPtr_headerId;

		// Token: 0x04002C28 RID: 11304
		private static readonly IntPtr NativeFieldInfoPtr_objectMapIdTable;

		// Token: 0x04002C29 RID: 11305
		private static readonly IntPtr NativeFieldInfoPtr_assemIdToAssemblyTable;

		// Token: 0x04002C2A RID: 11306
		private static readonly IntPtr NativeFieldInfoPtr_stack;

		// Token: 0x04002C2B RID: 11307
		private static readonly IntPtr NativeFieldInfoPtr_expectedType;

		// Token: 0x04002C2C RID: 11308
		private static readonly IntPtr NativeFieldInfoPtr_expectedTypeInformation;

		// Token: 0x04002C2D RID: 11309
		private static readonly IntPtr NativeFieldInfoPtr_PRS;

		// Token: 0x04002C2E RID: 11310
		private static readonly IntPtr NativeFieldInfoPtr_systemAssemblyInfo;

		// Token: 0x04002C2F RID: 11311
		private static readonly IntPtr NativeFieldInfoPtr_dataReader;

		// Token: 0x04002C30 RID: 11312
		private static readonly IntPtr NativeFieldInfoPtr_encoding;

		// Token: 0x04002C31 RID: 11313
		private static readonly IntPtr NativeFieldInfoPtr_opPool;

		// Token: 0x04002C32 RID: 11314
		private static readonly IntPtr NativeFieldInfoPtr_binaryObject;

		// Token: 0x04002C33 RID: 11315
		private static readonly IntPtr NativeFieldInfoPtr_bowm;

		// Token: 0x04002C34 RID: 11316
		private static readonly IntPtr NativeFieldInfoPtr_bowmt;

		// Token: 0x04002C35 RID: 11317
		private static readonly IntPtr NativeFieldInfoPtr_objectString;

		// Token: 0x04002C36 RID: 11318
		private static readonly IntPtr NativeFieldInfoPtr_crossAppDomainString;

		// Token: 0x04002C37 RID: 11319
		private static readonly IntPtr NativeFieldInfoPtr_memberPrimitiveTyped;

		// Token: 0x04002C38 RID: 11320
		private static readonly IntPtr NativeFieldInfoPtr_byteBuffer;

		// Token: 0x04002C39 RID: 11321
		private static readonly IntPtr NativeFieldInfoPtr_memberPrimitiveUnTyped;

		// Token: 0x04002C3A RID: 11322
		private static readonly IntPtr NativeFieldInfoPtr_memberReference;

		// Token: 0x04002C3B RID: 11323
		private static readonly IntPtr NativeFieldInfoPtr_objectNull;

		// Token: 0x04002C3C RID: 11324
		private static readonly IntPtr NativeFieldInfoPtr_messageEnd;

		// Token: 0x04002C3D RID: 11325
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Stream_ObjectReader_0;

		// Token: 0x04002C3E RID: 11326
		private static readonly IntPtr NativeMethodInfoPtr_get_SystemAssemblyInfo_Internal_get_BinaryAssemblyInfo_0;

		// Token: 0x04002C3F RID: 11327
		private static readonly IntPtr NativeMethodInfoPtr_get_ObjectMapIdTable_Internal_get_SizedArray_0;

		// Token: 0x04002C40 RID: 11328
		private static readonly IntPtr NativeMethodInfoPtr_get_AssemIdToAssemblyTable_Internal_get_SizedArray_0;

		// Token: 0x04002C41 RID: 11329
		private static readonly IntPtr NativeMethodInfoPtr_get_prs_Internal_get_ParseRecord_0;

		// Token: 0x04002C42 RID: 11330
		private static readonly IntPtr NativeMethodInfoPtr_Run_Internal_Void_0;

		// Token: 0x04002C43 RID: 11331
		private static readonly IntPtr NativeMethodInfoPtr_ReadBegin_Internal_Void_0;

		// Token: 0x04002C44 RID: 11332
		private static readonly IntPtr NativeMethodInfoPtr_ReadEnd_Internal_Void_0;

		// Token: 0x04002C45 RID: 11333
		private static readonly IntPtr NativeMethodInfoPtr_ReadBoolean_Internal_Boolean_0;

		// Token: 0x04002C46 RID: 11334
		private static readonly IntPtr NativeMethodInfoPtr_ReadByte_Internal_Byte_0;

		// Token: 0x04002C47 RID: 11335
		private static readonly IntPtr NativeMethodInfoPtr_ReadBytes_Internal_Il2CppStructArray_1_Byte_Int32_0;

		// Token: 0x04002C48 RID: 11336
		private static readonly IntPtr NativeMethodInfoPtr_ReadBytes_Internal_Void_Il2CppStructArray_1_Byte_Int32_Int32_0;

		// Token: 0x04002C49 RID: 11337
		private static readonly IntPtr NativeMethodInfoPtr_ReadChar_Internal_Char_0;

		// Token: 0x04002C4A RID: 11338
		private static readonly IntPtr NativeMethodInfoPtr_ReadChars_Internal_Il2CppStructArray_1_Char_Int32_0;

		// Token: 0x04002C4B RID: 11339
		private static readonly IntPtr NativeMethodInfoPtr_ReadDecimal_Internal_Decimal_0;

		// Token: 0x04002C4C RID: 11340
		private static readonly IntPtr NativeMethodInfoPtr_ReadSingle_Internal_Single_0;

		// Token: 0x04002C4D RID: 11341
		private static readonly IntPtr NativeMethodInfoPtr_ReadDouble_Internal_Double_0;

		// Token: 0x04002C4E RID: 11342
		private static readonly IntPtr NativeMethodInfoPtr_ReadInt16_Internal_Int16_0;

		// Token: 0x04002C4F RID: 11343
		private static readonly IntPtr NativeMethodInfoPtr_ReadInt32_Internal_Int32_0;

		// Token: 0x04002C50 RID: 11344
		private static readonly IntPtr NativeMethodInfoPtr_ReadInt64_Internal_Int64_0;

		// Token: 0x04002C51 RID: 11345
		private static readonly IntPtr NativeMethodInfoPtr_ReadSByte_Internal_SByte_0;

		// Token: 0x04002C52 RID: 11346
		private static readonly IntPtr NativeMethodInfoPtr_ReadString_Internal_String_0;

		// Token: 0x04002C53 RID: 11347
		private static readonly IntPtr NativeMethodInfoPtr_ReadTimeSpan_Internal_TimeSpan_0;

		// Token: 0x04002C54 RID: 11348
		private static readonly IntPtr NativeMethodInfoPtr_ReadDateTime_Internal_DateTime_0;

		// Token: 0x04002C55 RID: 11349
		private static readonly IntPtr NativeMethodInfoPtr_ReadUInt16_Internal_UInt16_0;

		// Token: 0x04002C56 RID: 11350
		private static readonly IntPtr NativeMethodInfoPtr_ReadUInt32_Internal_UInt32_0;

		// Token: 0x04002C57 RID: 11351
		private static readonly IntPtr NativeMethodInfoPtr_ReadUInt64_Internal_UInt64_0;

		// Token: 0x04002C58 RID: 11352
		private static readonly IntPtr NativeMethodInfoPtr_ReadSerializationHeaderRecord_Internal_Void_0;

		// Token: 0x04002C59 RID: 11353
		private static readonly IntPtr NativeMethodInfoPtr_ReadAssembly_Internal_Void_BinaryHeaderEnum_0;

		// Token: 0x04002C5A RID: 11354
		private static readonly IntPtr NativeMethodInfoPtr_ReadObject_Private_Void_0;

		// Token: 0x04002C5B RID: 11355
		private static readonly IntPtr NativeMethodInfoPtr_ReadCrossAppDomainMap_Internal_Void_0;

		// Token: 0x04002C5C RID: 11356
		private static readonly IntPtr NativeMethodInfoPtr_ReadObjectWithMap_Internal_Void_BinaryHeaderEnum_0;

		// Token: 0x04002C5D RID: 11357
		private static readonly IntPtr NativeMethodInfoPtr_ReadObjectWithMap_Private_Void_BinaryObjectWithMap_0;

		// Token: 0x04002C5E RID: 11358
		private static readonly IntPtr NativeMethodInfoPtr_ReadObjectWithMapTyped_Internal_Void_BinaryHeaderEnum_0;

		// Token: 0x04002C5F RID: 11359
		private static readonly IntPtr NativeMethodInfoPtr_ReadObjectWithMapTyped_Private_Void_BinaryObjectWithMapTyped_0;

		// Token: 0x04002C60 RID: 11360
		private static readonly IntPtr NativeMethodInfoPtr_ReadObjectString_Private_Void_BinaryHeaderEnum_0;

		// Token: 0x04002C61 RID: 11361
		private static readonly IntPtr NativeMethodInfoPtr_ReadMemberPrimitiveTyped_Private_Void_0;

		// Token: 0x04002C62 RID: 11362
		private static readonly IntPtr NativeMethodInfoPtr_ReadArray_Private_Void_BinaryHeaderEnum_0;

		// Token: 0x04002C63 RID: 11363
		private static readonly IntPtr NativeMethodInfoPtr_ReadArrayAsBytes_Private_Void_ParseRecord_0;

		// Token: 0x04002C64 RID: 11364
		private static readonly IntPtr NativeMethodInfoPtr_ReadMemberPrimitiveUnTyped_Private_Void_0;

		// Token: 0x04002C65 RID: 11365
		private static readonly IntPtr NativeMethodInfoPtr_ReadMemberReference_Private_Void_0;

		// Token: 0x04002C66 RID: 11366
		private static readonly IntPtr NativeMethodInfoPtr_ReadObjectNull_Private_Void_BinaryHeaderEnum_0;

		// Token: 0x04002C67 RID: 11367
		private static readonly IntPtr NativeMethodInfoPtr_ReadMessageEnd_Private_Void_0;

		// Token: 0x04002C68 RID: 11368
		private static readonly IntPtr NativeMethodInfoPtr_ReadValue_Internal_Object_InternalPrimitiveTypeE_0;

		// Token: 0x04002C69 RID: 11369
		private static readonly IntPtr NativeMethodInfoPtr_GetOp_Private_ObjectProgress_0;

		// Token: 0x04002C6A RID: 11370
		private static readonly IntPtr NativeMethodInfoPtr_PutOp_Private_Void_ObjectProgress_0;
	}
}
