using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;
using Il2CppSystem.Runtime.Remoting.Messaging;

namespace Il2CppSystem.Runtime.Serialization.Formatters.Binary
{
	// Token: 0x0200036C RID: 876
	public sealed class ObjectWriter : Object
	{
		// Token: 0x060035CC RID: 13772 RVA: 0x0010A254 File Offset: 0x00108454
		// Note: this type is marked as 'beforefieldinit'.
		static ObjectWriter()
		{
			Il2CppClassPointerStore<ObjectWriter>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Serialization.Formatters.Binary", "ObjectWriter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ObjectWriter>.NativeClassPtr);
			ObjectWriter.NativeFieldInfoPtr_m_objectQueue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectWriter>.NativeClassPtr, "m_objectQueue");
			ObjectWriter.NativeFieldInfoPtr_m_idGenerator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectWriter>.NativeClassPtr, "m_idGenerator");
			ObjectWriter.NativeFieldInfoPtr_m_currentId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectWriter>.NativeClassPtr, "m_currentId");
			ObjectWriter.NativeFieldInfoPtr_m_surrogates = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectWriter>.NativeClassPtr, "m_surrogates");
			ObjectWriter.NativeFieldInfoPtr_m_context = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectWriter>.NativeClassPtr, "m_context");
			ObjectWriter.NativeFieldInfoPtr_serWriter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectWriter>.NativeClassPtr, "serWriter");
			ObjectWriter.NativeFieldInfoPtr_m_objectManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectWriter>.NativeClassPtr, "m_objectManager");
			ObjectWriter.NativeFieldInfoPtr_topId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectWriter>.NativeClassPtr, "topId");
			ObjectWriter.NativeFieldInfoPtr_topName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectWriter>.NativeClassPtr, "topName");
			ObjectWriter.NativeFieldInfoPtr_headers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectWriter>.NativeClassPtr, "headers");
			ObjectWriter.NativeFieldInfoPtr_formatterEnums = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectWriter>.NativeClassPtr, "formatterEnums");
			ObjectWriter.NativeFieldInfoPtr_m_binder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectWriter>.NativeClassPtr, "m_binder");
			ObjectWriter.NativeFieldInfoPtr_serObjectInfoInit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectWriter>.NativeClassPtr, "serObjectInfoInit");
			ObjectWriter.NativeFieldInfoPtr_m_formatterConverter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectWriter>.NativeClassPtr, "m_formatterConverter");
			ObjectWriter.NativeFieldInfoPtr_crossAppDomainArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectWriter>.NativeClassPtr, "crossAppDomainArray");
			ObjectWriter.NativeFieldInfoPtr_previousObj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectWriter>.NativeClassPtr, "previousObj");
			ObjectWriter.NativeFieldInfoPtr_previousId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectWriter>.NativeClassPtr, "previousId");
			ObjectWriter.NativeFieldInfoPtr_previousType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectWriter>.NativeClassPtr, "previousType");
			ObjectWriter.NativeFieldInfoPtr_previousCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectWriter>.NativeClassPtr, "previousCode");
			ObjectWriter.NativeFieldInfoPtr_assemblyToIdTable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectWriter>.NativeClassPtr, "assemblyToIdTable");
			ObjectWriter.NativeFieldInfoPtr_niPool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectWriter>.NativeClassPtr, "niPool");
			ObjectWriter.NativeMethodInfoPtr__ctor_Internal_Void_ISurrogateSelector_StreamingContext_InternalFE_SerializationBinder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectWriter>.NativeClassPtr, 100671478);
			ObjectWriter.NativeMethodInfoPtr_Serialize_Internal_Void_Object_Il2CppReferenceArray_1_Header___BinaryWriter_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectWriter>.NativeClassPtr, 100671479);
			ObjectWriter.NativeMethodInfoPtr_get_ObjectManager_Internal_get_SerializationObjectManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectWriter>.NativeClassPtr, 100671480);
			ObjectWriter.NativeMethodInfoPtr_Write_Private_Void_WriteObjectInfo_NameInfo_NameInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectWriter>.NativeClassPtr, 100671481);
			ObjectWriter.NativeMethodInfoPtr_Write_Private_Void_WriteObjectInfo_NameInfo_NameInfo_Il2CppStringArray_Il2CppReferenceArray_1_Type_Il2CppReferenceArray_1_Object_Il2CppReferenceArray_1_WriteObjectInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectWriter>.NativeClassPtr, 100671482);
			ObjectWriter.NativeMethodInfoPtr_WriteMemberSetup_Private_Void_WriteObjectInfo_NameInfo_NameInfo_String_Type_Object_WriteObjectInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectWriter>.NativeClassPtr, 100671483);
			ObjectWriter.NativeMethodInfoPtr_WriteMembers_Private_Void_NameInfo_NameInfo_Object_WriteObjectInfo_NameInfo_WriteObjectInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectWriter>.NativeClassPtr, 100671484);
			ObjectWriter.NativeMethodInfoPtr_WriteArray_Private_Void_WriteObjectInfo_NameInfo_WriteObjectInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectWriter>.NativeClassPtr, 100671485);
			ObjectWriter.NativeMethodInfoPtr_WriteArrayMember_Private_Void_WriteObjectInfo_NameInfo_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectWriter>.NativeClassPtr, 100671486);
			ObjectWriter.NativeMethodInfoPtr_WriteRectangle_Private_Void_WriteObjectInfo_Int32_Il2CppStructArray_1_Int32_Array_NameInfo_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectWriter>.NativeClassPtr, 100671487);
			ObjectWriter.NativeMethodInfoPtr_GetNext_Private_Object_byref_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectWriter>.NativeClassPtr, 100671488);
			ObjectWriter.NativeMethodInfoPtr_InternalGetId_Private_Int64_Object_Boolean_Type_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectWriter>.NativeClassPtr, 100671489);
			ObjectWriter.NativeMethodInfoPtr_Schedule_Private_Int64_Object_Boolean_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectWriter>.NativeClassPtr, 100671490);
			ObjectWriter.NativeMethodInfoPtr_Schedule_Private_Int64_Object_Boolean_Type_WriteObjectInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectWriter>.NativeClassPtr, 100671491);
			ObjectWriter.NativeMethodInfoPtr_WriteKnownValueClass_Private_Boolean_NameInfo_NameInfo_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectWriter>.NativeClassPtr, 100671492);
			ObjectWriter.NativeMethodInfoPtr_WriteObjectRef_Private_Void_NameInfo_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectWriter>.NativeClassPtr, 100671493);
			ObjectWriter.NativeMethodInfoPtr_WriteString_Private_Void_NameInfo_NameInfo_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectWriter>.NativeClassPtr, 100671494);
			ObjectWriter.NativeMethodInfoPtr_CheckForNull_Private_Boolean_WriteObjectInfo_NameInfo_NameInfo_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectWriter>.NativeClassPtr, 100671495);
			ObjectWriter.NativeMethodInfoPtr_WriteSerializedStreamHeader_Private_Void_Int64_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectWriter>.NativeClassPtr, 100671496);
			ObjectWriter.NativeMethodInfoPtr_TypeToNameInfo_Private_NameInfo_Type_WriteObjectInfo_InternalPrimitiveTypeE_NameInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectWriter>.NativeClassPtr, 100671497);
			ObjectWriter.NativeMethodInfoPtr_TypeToNameInfo_Private_NameInfo_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectWriter>.NativeClassPtr, 100671498);
			ObjectWriter.NativeMethodInfoPtr_TypeToNameInfo_Private_NameInfo_WriteObjectInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectWriter>.NativeClassPtr, 100671499);
			ObjectWriter.NativeMethodInfoPtr_TypeToNameInfo_Private_NameInfo_WriteObjectInfo_NameInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectWriter>.NativeClassPtr, 100671500);
			ObjectWriter.NativeMethodInfoPtr_TypeToNameInfo_Private_Void_Type_NameInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectWriter>.NativeClassPtr, 100671501);
			ObjectWriter.NativeMethodInfoPtr_MemberToNameInfo_Private_NameInfo_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectWriter>.NativeClassPtr, 100671502);
			ObjectWriter.NativeMethodInfoPtr_ToCode_Internal_InternalPrimitiveTypeE_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectWriter>.NativeClassPtr, 100671503);
			ObjectWriter.NativeMethodInfoPtr_GetAssemblyId_Private_Int64_WriteObjectInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectWriter>.NativeClassPtr, 100671504);
			ObjectWriter.NativeMethodInfoPtr_GetType_Private_Type_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectWriter>.NativeClassPtr, 100671505);
			ObjectWriter.NativeMethodInfoPtr_GetNameInfo_Private_NameInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectWriter>.NativeClassPtr, 100671506);
			ObjectWriter.NativeMethodInfoPtr_CheckTypeFormat_Private_Boolean_FormatterTypeStyle_FormatterTypeStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectWriter>.NativeClassPtr, 100671507);
			ObjectWriter.NativeMethodInfoPtr_PutNameInfo_Private_Void_NameInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectWriter>.NativeClassPtr, 100671508);
		}

		// Token: 0x060035CD RID: 13773 RVA: 0x0010A694 File Offset: 0x00108894
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1389428, RefRangeEnd = 1389429, XrefRangeStart = 1389411, XrefRangeEnd = 1389428, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ObjectWriter(ISurrogateSelector selector, StreamingContext context, InternalFE formatterEnums, SerializationBinder binder)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ObjectWriter>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(selector);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(formatterEnums);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(binder);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectWriter.NativeMethodInfoPtr__ctor_Internal_Void_ISurrogateSelector_StreamingContext_InternalFE_SerializationBinder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060035CE RID: 13774 RVA: 0x0010A71C File Offset: 0x0010891C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1389472, RefRangeEnd = 1389473, XrefRangeStart = 1389429, XrefRangeEnd = 1389472, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Serialize(Object graph, Il2CppReferenceArray<Header> inHeaders, __BinaryWriter serWriter, bool fCheck)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(graph);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(inHeaders);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(serWriter);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fCheck;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectWriter.NativeMethodInfoPtr_Serialize_Internal_Void_Object_Il2CppReferenceArray_1_Header___BinaryWriter_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000C91 RID: 3217
		// (get) Token: 0x060035CF RID: 13775 RVA: 0x0010A790 File Offset: 0x00108990
		public unsafe SerializationObjectManager ObjectManager
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectWriter.NativeMethodInfoPtr_get_ObjectManager_Internal_get_SerializationObjectManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SerializationObjectManager>(intPtr3) : null;
			}
		}

		// Token: 0x060035D0 RID: 13776 RVA: 0x0010A7D0 File Offset: 0x001089D0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1389517, RefRangeEnd = 1389518, XrefRangeStart = 1389473, XrefRangeEnd = 1389517, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Write(WriteObjectInfo objectInfo, NameInfo memberNameInfo, NameInfo typeNameInfo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(objectInfo);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(memberNameInfo);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(typeNameInfo);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectWriter.NativeMethodInfoPtr_Write_Private_Void_WriteObjectInfo_NameInfo_NameInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060035D1 RID: 13777 RVA: 0x0010A838 File Offset: 0x00108A38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1389518, XrefRangeEnd = 1389538, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Write(WriteObjectInfo objectInfo, NameInfo memberNameInfo, NameInfo typeNameInfo, Il2CppStringArray memberNames, Il2CppReferenceArray<Type> memberTypes, Il2CppReferenceArray<Object> memberData, Il2CppReferenceArray<WriteObjectInfo> memberObjectInfos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(objectInfo);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(memberNameInfo);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(typeNameInfo);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(memberNames);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(memberTypes);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(memberData);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(memberObjectInfos);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectWriter.NativeMethodInfoPtr_Write_Private_Void_WriteObjectInfo_NameInfo_NameInfo_Il2CppStringArray_Il2CppReferenceArray_1_Type_Il2CppReferenceArray_1_Object_Il2CppReferenceArray_1_WriteObjectInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060035D2 RID: 13778 RVA: 0x0010A8EC File Offset: 0x00108AEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1389538, XrefRangeEnd = 1389551, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteMemberSetup(WriteObjectInfo objectInfo, NameInfo memberNameInfo, NameInfo typeNameInfo, string memberName, Type memberType, Object memberData, WriteObjectInfo memberObjectInfo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(objectInfo);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(memberNameInfo);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(typeNameInfo);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(memberName);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(memberType);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(memberData);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(memberObjectInfo);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectWriter.NativeMethodInfoPtr_WriteMemberSetup_Private_Void_WriteObjectInfo_NameInfo_NameInfo_String_Type_Object_WriteObjectInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060035D3 RID: 13779 RVA: 0x0010A9A0 File Offset: 0x00108BA0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1389585, RefRangeEnd = 1389588, XrefRangeStart = 1389551, XrefRangeEnd = 1389585, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteMembers(NameInfo memberNameInfo, NameInfo memberTypeNameInfo, Object memberData, WriteObjectInfo objectInfo, NameInfo typeNameInfo, WriteObjectInfo memberObjectInfo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(memberNameInfo);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(memberTypeNameInfo);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(memberData);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(objectInfo);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(typeNameInfo);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(memberObjectInfo);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectWriter.NativeMethodInfoPtr_WriteMembers_Private_Void_NameInfo_NameInfo_Object_WriteObjectInfo_NameInfo_WriteObjectInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060035D4 RID: 13780 RVA: 0x0010AA40 File Offset: 0x00108C40
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1389622, RefRangeEnd = 1389623, XrefRangeStart = 1389588, XrefRangeEnd = 1389622, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteArray(WriteObjectInfo objectInfo, NameInfo memberNameInfo, WriteObjectInfo memberObjectInfo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(objectInfo);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(memberNameInfo);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(memberObjectInfo);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectWriter.NativeMethodInfoPtr_WriteArray_Private_Void_WriteObjectInfo_NameInfo_WriteObjectInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060035D5 RID: 13781 RVA: 0x0010AAA8 File Offset: 0x00108CA8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1389625, RefRangeEnd = 1389626, XrefRangeStart = 1389623, XrefRangeEnd = 1389625, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteArrayMember(WriteObjectInfo objectInfo, NameInfo arrayElemTypeNameInfo, Object data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(objectInfo);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(arrayElemTypeNameInfo);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectWriter.NativeMethodInfoPtr_WriteArrayMember_Private_Void_WriteObjectInfo_NameInfo_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060035D6 RID: 13782 RVA: 0x0010AB10 File Offset: 0x00108D10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1389626, XrefRangeEnd = 1389634, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteRectangle(WriteObjectInfo objectInfo, int rank, Il2CppStructArray<int> maxA, Array array, NameInfo arrayElemNameTypeInfo, Il2CppStructArray<int> lowerBoundA)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(objectInfo);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rank;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(maxA);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(array);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(arrayElemNameTypeInfo);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(lowerBoundA);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectWriter.NativeMethodInfoPtr_WriteRectangle_Private_Void_WriteObjectInfo_Int32_Il2CppStructArray_1_Int32_Array_NameInfo_Il2CppStructArray_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060035D7 RID: 13783 RVA: 0x0010ABAC File Offset: 0x00108DAC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1389637, RefRangeEnd = 1389639, XrefRangeStart = 1389634, XrefRangeEnd = 1389637, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object GetNext(out long objID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &objID;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectWriter.NativeMethodInfoPtr_GetNext_Private_Object_byref_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x060035D8 RID: 13784 RVA: 0x0010ABF8 File Offset: 0x00108DF8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1389640, RefRangeEnd = 1389642, XrefRangeStart = 1389639, XrefRangeEnd = 1389640, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe long InternalGetId(Object obj, bool assignUniqueIdToValueType, Type type, out bool isNew)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref assignUniqueIdToValueType;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(type);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &isNew;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectWriter.NativeMethodInfoPtr_InternalGetId_Private_Int64_Object_Boolean_Type_byref_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060035D9 RID: 13785 RVA: 0x0010AC74 File Offset: 0x00108E74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1389642, XrefRangeEnd = 1389643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe long Schedule(Object obj, bool assignUniqueIdToValueType, Type type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref assignUniqueIdToValueType;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(type);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectWriter.NativeMethodInfoPtr_Schedule_Private_Int64_Object_Boolean_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060035DA RID: 13786 RVA: 0x0010ACE4 File Offset: 0x00108EE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1389643, XrefRangeEnd = 1389644, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe long Schedule(Object obj, bool assignUniqueIdToValueType, Type type, WriteObjectInfo objectInfo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref assignUniqueIdToValueType;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(type);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(objectInfo);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectWriter.NativeMethodInfoPtr_Schedule_Private_Int64_Object_Boolean_Type_WriteObjectInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060035DB RID: 13787 RVA: 0x0010AD64 File Offset: 0x00108F64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1389644, XrefRangeEnd = 1389652, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool WriteKnownValueClass(NameInfo memberNameInfo, NameInfo typeNameInfo, Object data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(memberNameInfo);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(typeNameInfo);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectWriter.NativeMethodInfoPtr_WriteKnownValueClass_Private_Boolean_NameInfo_NameInfo_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060035DC RID: 13788 RVA: 0x0010ADD8 File Offset: 0x00108FD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1389652, XrefRangeEnd = 1389654, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteObjectRef(NameInfo nameInfo, long objectId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(nameInfo);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref objectId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectWriter.NativeMethodInfoPtr_WriteObjectRef_Private_Void_NameInfo_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060035DD RID: 13789 RVA: 0x0010AE28 File Offset: 0x00109028
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1389654, XrefRangeEnd = 1389658, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteString(NameInfo memberNameInfo, NameInfo typeNameInfo, Object stringObject)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(memberNameInfo);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(typeNameInfo);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(stringObject);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectWriter.NativeMethodInfoPtr_WriteString_Private_Void_NameInfo_NameInfo_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060035DE RID: 13790 RVA: 0x0010AE90 File Offset: 0x00109090
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1389658, XrefRangeEnd = 1389659, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CheckForNull(WriteObjectInfo objectInfo, NameInfo memberNameInfo, NameInfo typeNameInfo, Object data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(objectInfo);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(memberNameInfo);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(typeNameInfo);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectWriter.NativeMethodInfoPtr_CheckForNull_Private_Boolean_WriteObjectInfo_NameInfo_NameInfo_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060035DF RID: 13791 RVA: 0x0010AF14 File Offset: 0x00109114
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1389659, XrefRangeEnd = 1389660, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteSerializedStreamHeader(long topId, long headerId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref topId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref headerId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectWriter.NativeMethodInfoPtr_WriteSerializedStreamHeader_Private_Void_Int64_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060035E0 RID: 13792 RVA: 0x0010AF60 File Offset: 0x00109160
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1389660, XrefRangeEnd = 1389668, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NameInfo TypeToNameInfo(Type type, WriteObjectInfo objectInfo, InternalPrimitiveTypeE code, NameInfo nameInfo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(objectInfo);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref code;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(nameInfo);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectWriter.NativeMethodInfoPtr_TypeToNameInfo_Private_NameInfo_Type_WriteObjectInfo_InternalPrimitiveTypeE_NameInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<NameInfo>(intPtr3) : null;
		}

		// Token: 0x060035E1 RID: 13793 RVA: 0x0010AFE4 File Offset: 0x001091E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1389668, XrefRangeEnd = 1389671, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NameInfo TypeToNameInfo(Type type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectWriter.NativeMethodInfoPtr_TypeToNameInfo_Private_NameInfo_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<NameInfo>(intPtr3) : null;
			}
		}

		// Token: 0x060035E2 RID: 13794 RVA: 0x0010B034 File Offset: 0x00109234
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1389677, RefRangeEnd = 1389683, XrefRangeStart = 1389671, XrefRangeEnd = 1389677, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NameInfo TypeToNameInfo(WriteObjectInfo objectInfo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(objectInfo);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectWriter.NativeMethodInfoPtr_TypeToNameInfo_Private_NameInfo_WriteObjectInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<NameInfo>(intPtr3) : null;
			}
		}

		// Token: 0x060035E3 RID: 13795 RVA: 0x0010B084 File Offset: 0x00109284
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1389683, XrefRangeEnd = 1389692, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NameInfo TypeToNameInfo(WriteObjectInfo objectInfo, NameInfo nameInfo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(objectInfo);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(nameInfo);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectWriter.NativeMethodInfoPtr_TypeToNameInfo_Private_NameInfo_WriteObjectInfo_NameInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<NameInfo>(intPtr3) : null;
		}

		// Token: 0x060035E4 RID: 13796 RVA: 0x0010B0E8 File Offset: 0x001092E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1389692, XrefRangeEnd = 1389699, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TypeToNameInfo(Type type, NameInfo nameInfo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(nameInfo);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectWriter.NativeMethodInfoPtr_TypeToNameInfo_Private_Void_Type_NameInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060035E5 RID: 13797 RVA: 0x0010B13C File Offset: 0x0010933C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1389699, XrefRangeEnd = 1389701, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NameInfo MemberToNameInfo(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectWriter.NativeMethodInfoPtr_MemberToNameInfo_Private_NameInfo_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<NameInfo>(intPtr3) : null;
			}
		}

		// Token: 0x060035E6 RID: 13798 RVA: 0x0010B18C File Offset: 0x0010938C
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 1389706, RefRangeEnd = 1389718, XrefRangeStart = 1389701, XrefRangeEnd = 1389706, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InternalPrimitiveTypeE ToCode(Type type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectWriter.NativeMethodInfoPtr_ToCode_Internal_InternalPrimitiveTypeE_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060035E7 RID: 13799 RVA: 0x0010B1DC File Offset: 0x001093DC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1389742, RefRangeEnd = 1389745, XrefRangeStart = 1389718, XrefRangeEnd = 1389742, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe long GetAssemblyId(WriteObjectInfo objectInfo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(objectInfo);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectWriter.NativeMethodInfoPtr_GetAssemblyId_Private_Int64_WriteObjectInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060035E8 RID: 13800 RVA: 0x0010B22C File Offset: 0x0010942C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Type GetType(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectWriter.NativeMethodInfoPtr_GetType_Private_Type_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x060035E9 RID: 13801 RVA: 0x0010B27C File Offset: 0x0010947C
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 1389749, RefRangeEnd = 1389762, XrefRangeStart = 1389745, XrefRangeEnd = 1389749, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NameInfo GetNameInfo()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectWriter.NativeMethodInfoPtr_GetNameInfo_Private_NameInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<NameInfo>(intPtr3) : null;
		}

		// Token: 0x060035EA RID: 13802 RVA: 0x0010B2BC File Offset: 0x001094BC
		[CallerCount(0)]
		public unsafe bool CheckTypeFormat(FormatterTypeStyle test, FormatterTypeStyle want)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref test;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref want;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectWriter.NativeMethodInfoPtr_CheckTypeFormat_Private_Boolean_FormatterTypeStyle_FormatterTypeStyle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060035EB RID: 13803 RVA: 0x0010B314 File Offset: 0x00109514
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1389762, XrefRangeEnd = 1389764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PutNameInfo(NameInfo nameInfo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(nameInfo);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectWriter.NativeMethodInfoPtr_PutNameInfo_Private_Void_NameInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060035EC RID: 13804 RVA: 0x00013468 File Offset: 0x00011668
		public ObjectWriter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000C7C RID: 3196
		// (get) Token: 0x060035ED RID: 13805 RVA: 0x0010B358 File Offset: 0x00109558
		// (set) Token: 0x060035EE RID: 13806 RVA: 0x00013471 File Offset: 0x00011671
		public unsafe Queue m_objectQueue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectWriter.NativeFieldInfoPtr_m_objectQueue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Queue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectWriter.NativeFieldInfoPtr_m_objectQueue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C7D RID: 3197
		// (get) Token: 0x060035EF RID: 13807 RVA: 0x0010B388 File Offset: 0x00109588
		// (set) Token: 0x060035F0 RID: 13808 RVA: 0x00013490 File Offset: 0x00011690
		public unsafe ObjectIDGenerator m_idGenerator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectWriter.NativeFieldInfoPtr_m_idGenerator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectIDGenerator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectWriter.NativeFieldInfoPtr_m_idGenerator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C7E RID: 3198
		// (get) Token: 0x060035F1 RID: 13809 RVA: 0x0010B3B8 File Offset: 0x001095B8
		// (set) Token: 0x060035F2 RID: 13810 RVA: 0x000134AF File Offset: 0x000116AF
		public unsafe int m_currentId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectWriter.NativeFieldInfoPtr_m_currentId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectWriter.NativeFieldInfoPtr_m_currentId)) = value;
			}
		}

		// Token: 0x17000C7F RID: 3199
		// (get) Token: 0x060035F3 RID: 13811 RVA: 0x0010B3E0 File Offset: 0x001095E0
		// (set) Token: 0x060035F4 RID: 13812 RVA: 0x000134CA File Offset: 0x000116CA
		public unsafe ISurrogateSelector m_surrogates
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectWriter.NativeFieldInfoPtr_m_surrogates);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ISurrogateSelector>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectWriter.NativeFieldInfoPtr_m_surrogates), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C80 RID: 3200
		// (get) Token: 0x060035F5 RID: 13813 RVA: 0x0010B410 File Offset: 0x00109610
		// (set) Token: 0x060035F6 RID: 13814 RVA: 0x000134E9 File Offset: 0x000116E9
		public StreamingContext m_context
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectWriter.NativeFieldInfoPtr_m_context);
				return new StreamingContext(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<StreamingContext>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectWriter.NativeFieldInfoPtr_m_context), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<StreamingContext>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000C81 RID: 3201
		// (get) Token: 0x060035F7 RID: 13815 RVA: 0x0010B440 File Offset: 0x00109640
		// (set) Token: 0x060035F8 RID: 13816 RVA: 0x00013517 File Offset: 0x00011717
		public unsafe __BinaryWriter serWriter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectWriter.NativeFieldInfoPtr_serWriter);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<__BinaryWriter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectWriter.NativeFieldInfoPtr_serWriter), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C82 RID: 3202
		// (get) Token: 0x060035F9 RID: 13817 RVA: 0x0010B470 File Offset: 0x00109670
		// (set) Token: 0x060035FA RID: 13818 RVA: 0x00013536 File Offset: 0x00011736
		public unsafe SerializationObjectManager m_objectManager
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectWriter.NativeFieldInfoPtr_m_objectManager);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SerializationObjectManager>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectWriter.NativeFieldInfoPtr_m_objectManager), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C83 RID: 3203
		// (get) Token: 0x060035FB RID: 13819 RVA: 0x0010B4A0 File Offset: 0x001096A0
		// (set) Token: 0x060035FC RID: 13820 RVA: 0x00013555 File Offset: 0x00011755
		public unsafe long topId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectWriter.NativeFieldInfoPtr_topId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectWriter.NativeFieldInfoPtr_topId)) = value;
			}
		}

		// Token: 0x17000C84 RID: 3204
		// (get) Token: 0x060035FD RID: 13821 RVA: 0x0010B4C8 File Offset: 0x001096C8
		// (set) Token: 0x060035FE RID: 13822 RVA: 0x00013570 File Offset: 0x00011770
		public unsafe string topName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectWriter.NativeFieldInfoPtr_topName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectWriter.NativeFieldInfoPtr_topName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000C85 RID: 3205
		// (get) Token: 0x060035FF RID: 13823 RVA: 0x0010B4F0 File Offset: 0x001096F0
		// (set) Token: 0x06003600 RID: 13824 RVA: 0x0001358F File Offset: 0x0001178F
		public unsafe Il2CppReferenceArray<Header> headers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectWriter.NativeFieldInfoPtr_headers);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Header>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectWriter.NativeFieldInfoPtr_headers), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C86 RID: 3206
		// (get) Token: 0x06003601 RID: 13825 RVA: 0x0010B520 File Offset: 0x00109720
		// (set) Token: 0x06003602 RID: 13826 RVA: 0x000135AE File Offset: 0x000117AE
		public unsafe InternalFE formatterEnums
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectWriter.NativeFieldInfoPtr_formatterEnums);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InternalFE>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectWriter.NativeFieldInfoPtr_formatterEnums), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C87 RID: 3207
		// (get) Token: 0x06003603 RID: 13827 RVA: 0x0010B550 File Offset: 0x00109750
		// (set) Token: 0x06003604 RID: 13828 RVA: 0x000135CD File Offset: 0x000117CD
		public unsafe SerializationBinder m_binder
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectWriter.NativeFieldInfoPtr_m_binder);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SerializationBinder>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectWriter.NativeFieldInfoPtr_m_binder), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C88 RID: 3208
		// (get) Token: 0x06003605 RID: 13829 RVA: 0x0010B580 File Offset: 0x00109780
		// (set) Token: 0x06003606 RID: 13830 RVA: 0x000135EC File Offset: 0x000117EC
		public unsafe SerObjectInfoInit serObjectInfoInit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectWriter.NativeFieldInfoPtr_serObjectInfoInit);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SerObjectInfoInit>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectWriter.NativeFieldInfoPtr_serObjectInfoInit), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C89 RID: 3209
		// (get) Token: 0x06003607 RID: 13831 RVA: 0x0010B5B0 File Offset: 0x001097B0
		// (set) Token: 0x06003608 RID: 13832 RVA: 0x0001360B File Offset: 0x0001180B
		public unsafe IFormatterConverter m_formatterConverter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectWriter.NativeFieldInfoPtr_m_formatterConverter);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IFormatterConverter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectWriter.NativeFieldInfoPtr_m_formatterConverter), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C8A RID: 3210
		// (get) Token: 0x06003609 RID: 13833 RVA: 0x0010B5E0 File Offset: 0x001097E0
		// (set) Token: 0x0600360A RID: 13834 RVA: 0x0001362A File Offset: 0x0001182A
		public unsafe Il2CppReferenceArray<Object> crossAppDomainArray
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectWriter.NativeFieldInfoPtr_crossAppDomainArray);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectWriter.NativeFieldInfoPtr_crossAppDomainArray), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C8B RID: 3211
		// (get) Token: 0x0600360B RID: 13835 RVA: 0x0010B610 File Offset: 0x00109810
		// (set) Token: 0x0600360C RID: 13836 RVA: 0x00013649 File Offset: 0x00011849
		public unsafe Object previousObj
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectWriter.NativeFieldInfoPtr_previousObj);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectWriter.NativeFieldInfoPtr_previousObj), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C8C RID: 3212
		// (get) Token: 0x0600360D RID: 13837 RVA: 0x0010B640 File Offset: 0x00109840
		// (set) Token: 0x0600360E RID: 13838 RVA: 0x00013668 File Offset: 0x00011868
		public unsafe long previousId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectWriter.NativeFieldInfoPtr_previousId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectWriter.NativeFieldInfoPtr_previousId)) = value;
			}
		}

		// Token: 0x17000C8D RID: 3213
		// (get) Token: 0x0600360F RID: 13839 RVA: 0x0010B668 File Offset: 0x00109868
		// (set) Token: 0x06003610 RID: 13840 RVA: 0x00013683 File Offset: 0x00011883
		public unsafe Type previousType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectWriter.NativeFieldInfoPtr_previousType);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectWriter.NativeFieldInfoPtr_previousType), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C8E RID: 3214
		// (get) Token: 0x06003611 RID: 13841 RVA: 0x0010B698 File Offset: 0x00109898
		// (set) Token: 0x06003612 RID: 13842 RVA: 0x000136A2 File Offset: 0x000118A2
		public unsafe InternalPrimitiveTypeE previousCode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectWriter.NativeFieldInfoPtr_previousCode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectWriter.NativeFieldInfoPtr_previousCode)) = value;
			}
		}

		// Token: 0x17000C8F RID: 3215
		// (get) Token: 0x06003613 RID: 13843 RVA: 0x0010B6C0 File Offset: 0x001098C0
		// (set) Token: 0x06003614 RID: 13844 RVA: 0x000136BD File Offset: 0x000118BD
		public unsafe Hashtable assemblyToIdTable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectWriter.NativeFieldInfoPtr_assemblyToIdTable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectWriter.NativeFieldInfoPtr_assemblyToIdTable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C90 RID: 3216
		// (get) Token: 0x06003615 RID: 13845 RVA: 0x0010B6F0 File Offset: 0x001098F0
		// (set) Token: 0x06003616 RID: 13846 RVA: 0x000136DC File Offset: 0x000118DC
		public unsafe SerStack niPool
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectWriter.NativeFieldInfoPtr_niPool);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SerStack>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectWriter.NativeFieldInfoPtr_niPool), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002BF0 RID: 11248
		private static readonly IntPtr NativeFieldInfoPtr_m_objectQueue;

		// Token: 0x04002BF1 RID: 11249
		private static readonly IntPtr NativeFieldInfoPtr_m_idGenerator;

		// Token: 0x04002BF2 RID: 11250
		private static readonly IntPtr NativeFieldInfoPtr_m_currentId;

		// Token: 0x04002BF3 RID: 11251
		private static readonly IntPtr NativeFieldInfoPtr_m_surrogates;

		// Token: 0x04002BF4 RID: 11252
		private static readonly IntPtr NativeFieldInfoPtr_m_context;

		// Token: 0x04002BF5 RID: 11253
		private static readonly IntPtr NativeFieldInfoPtr_serWriter;

		// Token: 0x04002BF6 RID: 11254
		private static readonly IntPtr NativeFieldInfoPtr_m_objectManager;

		// Token: 0x04002BF7 RID: 11255
		private static readonly IntPtr NativeFieldInfoPtr_topId;

		// Token: 0x04002BF8 RID: 11256
		private static readonly IntPtr NativeFieldInfoPtr_topName;

		// Token: 0x04002BF9 RID: 11257
		private static readonly IntPtr NativeFieldInfoPtr_headers;

		// Token: 0x04002BFA RID: 11258
		private static readonly IntPtr NativeFieldInfoPtr_formatterEnums;

		// Token: 0x04002BFB RID: 11259
		private static readonly IntPtr NativeFieldInfoPtr_m_binder;

		// Token: 0x04002BFC RID: 11260
		private static readonly IntPtr NativeFieldInfoPtr_serObjectInfoInit;

		// Token: 0x04002BFD RID: 11261
		private static readonly IntPtr NativeFieldInfoPtr_m_formatterConverter;

		// Token: 0x04002BFE RID: 11262
		private static readonly IntPtr NativeFieldInfoPtr_crossAppDomainArray;

		// Token: 0x04002BFF RID: 11263
		private static readonly IntPtr NativeFieldInfoPtr_previousObj;

		// Token: 0x04002C00 RID: 11264
		private static readonly IntPtr NativeFieldInfoPtr_previousId;

		// Token: 0x04002C01 RID: 11265
		private static readonly IntPtr NativeFieldInfoPtr_previousType;

		// Token: 0x04002C02 RID: 11266
		private static readonly IntPtr NativeFieldInfoPtr_previousCode;

		// Token: 0x04002C03 RID: 11267
		private static readonly IntPtr NativeFieldInfoPtr_assemblyToIdTable;

		// Token: 0x04002C04 RID: 11268
		private static readonly IntPtr NativeFieldInfoPtr_niPool;

		// Token: 0x04002C05 RID: 11269
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_ISurrogateSelector_StreamingContext_InternalFE_SerializationBinder_0;

		// Token: 0x04002C06 RID: 11270
		private static readonly IntPtr NativeMethodInfoPtr_Serialize_Internal_Void_Object_Il2CppReferenceArray_1_Header___BinaryWriter_Boolean_0;

		// Token: 0x04002C07 RID: 11271
		private static readonly IntPtr NativeMethodInfoPtr_get_ObjectManager_Internal_get_SerializationObjectManager_0;

		// Token: 0x04002C08 RID: 11272
		private static readonly IntPtr NativeMethodInfoPtr_Write_Private_Void_WriteObjectInfo_NameInfo_NameInfo_0;

		// Token: 0x04002C09 RID: 11273
		private static readonly IntPtr NativeMethodInfoPtr_Write_Private_Void_WriteObjectInfo_NameInfo_NameInfo_Il2CppStringArray_Il2CppReferenceArray_1_Type_Il2CppReferenceArray_1_Object_Il2CppReferenceArray_1_WriteObjectInfo_0;

		// Token: 0x04002C0A RID: 11274
		private static readonly IntPtr NativeMethodInfoPtr_WriteMemberSetup_Private_Void_WriteObjectInfo_NameInfo_NameInfo_String_Type_Object_WriteObjectInfo_0;

		// Token: 0x04002C0B RID: 11275
		private static readonly IntPtr NativeMethodInfoPtr_WriteMembers_Private_Void_NameInfo_NameInfo_Object_WriteObjectInfo_NameInfo_WriteObjectInfo_0;

		// Token: 0x04002C0C RID: 11276
		private static readonly IntPtr NativeMethodInfoPtr_WriteArray_Private_Void_WriteObjectInfo_NameInfo_WriteObjectInfo_0;

		// Token: 0x04002C0D RID: 11277
		private static readonly IntPtr NativeMethodInfoPtr_WriteArrayMember_Private_Void_WriteObjectInfo_NameInfo_Object_0;

		// Token: 0x04002C0E RID: 11278
		private static readonly IntPtr NativeMethodInfoPtr_WriteRectangle_Private_Void_WriteObjectInfo_Int32_Il2CppStructArray_1_Int32_Array_NameInfo_Il2CppStructArray_1_Int32_0;

		// Token: 0x04002C0F RID: 11279
		private static readonly IntPtr NativeMethodInfoPtr_GetNext_Private_Object_byref_Int64_0;

		// Token: 0x04002C10 RID: 11280
		private static readonly IntPtr NativeMethodInfoPtr_InternalGetId_Private_Int64_Object_Boolean_Type_byref_Boolean_0;

		// Token: 0x04002C11 RID: 11281
		private static readonly IntPtr NativeMethodInfoPtr_Schedule_Private_Int64_Object_Boolean_Type_0;

		// Token: 0x04002C12 RID: 11282
		private static readonly IntPtr NativeMethodInfoPtr_Schedule_Private_Int64_Object_Boolean_Type_WriteObjectInfo_0;

		// Token: 0x04002C13 RID: 11283
		private static readonly IntPtr NativeMethodInfoPtr_WriteKnownValueClass_Private_Boolean_NameInfo_NameInfo_Object_0;

		// Token: 0x04002C14 RID: 11284
		private static readonly IntPtr NativeMethodInfoPtr_WriteObjectRef_Private_Void_NameInfo_Int64_0;

		// Token: 0x04002C15 RID: 11285
		private static readonly IntPtr NativeMethodInfoPtr_WriteString_Private_Void_NameInfo_NameInfo_Object_0;

		// Token: 0x04002C16 RID: 11286
		private static readonly IntPtr NativeMethodInfoPtr_CheckForNull_Private_Boolean_WriteObjectInfo_NameInfo_NameInfo_Object_0;

		// Token: 0x04002C17 RID: 11287
		private static readonly IntPtr NativeMethodInfoPtr_WriteSerializedStreamHeader_Private_Void_Int64_Int64_0;

		// Token: 0x04002C18 RID: 11288
		private static readonly IntPtr NativeMethodInfoPtr_TypeToNameInfo_Private_NameInfo_Type_WriteObjectInfo_InternalPrimitiveTypeE_NameInfo_0;

		// Token: 0x04002C19 RID: 11289
		private static readonly IntPtr NativeMethodInfoPtr_TypeToNameInfo_Private_NameInfo_Type_0;

		// Token: 0x04002C1A RID: 11290
		private static readonly IntPtr NativeMethodInfoPtr_TypeToNameInfo_Private_NameInfo_WriteObjectInfo_0;

		// Token: 0x04002C1B RID: 11291
		private static readonly IntPtr NativeMethodInfoPtr_TypeToNameInfo_Private_NameInfo_WriteObjectInfo_NameInfo_0;

		// Token: 0x04002C1C RID: 11292
		private static readonly IntPtr NativeMethodInfoPtr_TypeToNameInfo_Private_Void_Type_NameInfo_0;

		// Token: 0x04002C1D RID: 11293
		private static readonly IntPtr NativeMethodInfoPtr_MemberToNameInfo_Private_NameInfo_String_0;

		// Token: 0x04002C1E RID: 11294
		private static readonly IntPtr NativeMethodInfoPtr_ToCode_Internal_InternalPrimitiveTypeE_Type_0;

		// Token: 0x04002C1F RID: 11295
		private static readonly IntPtr NativeMethodInfoPtr_GetAssemblyId_Private_Int64_WriteObjectInfo_0;

		// Token: 0x04002C20 RID: 11296
		private static readonly IntPtr NativeMethodInfoPtr_GetType_Private_Type_Object_0;

		// Token: 0x04002C21 RID: 11297
		private static readonly IntPtr NativeMethodInfoPtr_GetNameInfo_Private_NameInfo_0;

		// Token: 0x04002C22 RID: 11298
		private static readonly IntPtr NativeMethodInfoPtr_CheckTypeFormat_Private_Boolean_FormatterTypeStyle_FormatterTypeStyle_0;

		// Token: 0x04002C23 RID: 11299
		private static readonly IntPtr NativeMethodInfoPtr_PutNameInfo_Private_Void_NameInfo_0;
	}
}
