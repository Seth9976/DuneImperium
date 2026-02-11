using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.IO;
using Il2CppSystem.Reflection;
using Il2CppSystem.Runtime.Remoting.Messaging;

namespace Il2CppSystem.Runtime.Serialization.Formatters.Binary
{
	// Token: 0x0200036B RID: 875
	public sealed class ObjectReader : Object
	{
		// Token: 0x06003579 RID: 13689 RVA: 0x00108EC0 File Offset: 0x001070C0
		// Note: this type is marked as 'beforefieldinit'.
		static ObjectReader()
		{
			Il2CppClassPointerStore<ObjectReader>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Serialization.Formatters.Binary", "ObjectReader");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ObjectReader>.NativeClassPtr);
			ObjectReader.NativeFieldInfoPtr_m_stream = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectReader>.NativeClassPtr, "m_stream");
			ObjectReader.NativeFieldInfoPtr_m_surrogates = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectReader>.NativeClassPtr, "m_surrogates");
			ObjectReader.NativeFieldInfoPtr_m_context = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectReader>.NativeClassPtr, "m_context");
			ObjectReader.NativeFieldInfoPtr_m_objectManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectReader>.NativeClassPtr, "m_objectManager");
			ObjectReader.NativeFieldInfoPtr_formatterEnums = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectReader>.NativeClassPtr, "formatterEnums");
			ObjectReader.NativeFieldInfoPtr_m_binder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectReader>.NativeClassPtr, "m_binder");
			ObjectReader.NativeFieldInfoPtr_topId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectReader>.NativeClassPtr, "topId");
			ObjectReader.NativeFieldInfoPtr_bSimpleAssembly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectReader>.NativeClassPtr, "bSimpleAssembly");
			ObjectReader.NativeFieldInfoPtr_handlerObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectReader>.NativeClassPtr, "handlerObject");
			ObjectReader.NativeFieldInfoPtr_m_topObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectReader>.NativeClassPtr, "m_topObject");
			ObjectReader.NativeFieldInfoPtr_headers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectReader>.NativeClassPtr, "headers");
			ObjectReader.NativeFieldInfoPtr_handler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectReader>.NativeClassPtr, "handler");
			ObjectReader.NativeFieldInfoPtr_serObjectInfoInit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectReader>.NativeClassPtr, "serObjectInfoInit");
			ObjectReader.NativeFieldInfoPtr_m_formatterConverter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectReader>.NativeClassPtr, "m_formatterConverter");
			ObjectReader.NativeFieldInfoPtr_stack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectReader>.NativeClassPtr, "stack");
			ObjectReader.NativeFieldInfoPtr_valueFixupStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectReader>.NativeClassPtr, "valueFixupStack");
			ObjectReader.NativeFieldInfoPtr_crossAppDomainArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectReader>.NativeClassPtr, "crossAppDomainArray");
			ObjectReader.NativeFieldInfoPtr_bFullDeserialization = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectReader>.NativeClassPtr, "bFullDeserialization");
			ObjectReader.NativeFieldInfoPtr_bOldFormatDetected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectReader>.NativeClassPtr, "bOldFormatDetected");
			ObjectReader.NativeFieldInfoPtr_valTypeObjectIdTable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectReader>.NativeClassPtr, "valTypeObjectIdTable");
			ObjectReader.NativeFieldInfoPtr_typeCache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectReader>.NativeClassPtr, "typeCache");
			ObjectReader.NativeFieldInfoPtr_previousAssemblyString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectReader>.NativeClassPtr, "previousAssemblyString");
			ObjectReader.NativeFieldInfoPtr_previousName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectReader>.NativeClassPtr, "previousName");
			ObjectReader.NativeFieldInfoPtr_previousType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectReader>.NativeClassPtr, "previousType");
			ObjectReader.NativeMethodInfoPtr_get_ValueFixupStack_Private_get_SerStack_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectReader>.NativeClassPtr, 100671442);
			ObjectReader.NativeMethodInfoPtr_get_TopObject_Internal_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectReader>.NativeClassPtr, 100671443);
			ObjectReader.NativeMethodInfoPtr_set_TopObject_Internal_set_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectReader>.NativeClassPtr, 100671444);
			ObjectReader.NativeMethodInfoPtr__ctor_Internal_Void_Stream_ISurrogateSelector_StreamingContext_InternalFE_SerializationBinder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectReader>.NativeClassPtr, 100671445);
			ObjectReader.NativeMethodInfoPtr_Deserialize_Internal_Object_HeaderHandler___BinaryParser_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectReader>.NativeClassPtr, 100671446);
			ObjectReader.NativeMethodInfoPtr_HasSurrogate_Private_Boolean_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectReader>.NativeClassPtr, 100671447);
			ObjectReader.NativeMethodInfoPtr_CheckSerializable_Private_Void_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectReader>.NativeClassPtr, 100671448);
			ObjectReader.NativeMethodInfoPtr_InitFullDeserialization_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectReader>.NativeClassPtr, 100671449);
			ObjectReader.NativeMethodInfoPtr_CrossAppDomainArray_Internal_Object_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectReader>.NativeClassPtr, 100671450);
			ObjectReader.NativeMethodInfoPtr_CreateReadObjectInfo_Internal_ReadObjectInfo_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectReader>.NativeClassPtr, 100671451);
			ObjectReader.NativeMethodInfoPtr_CreateReadObjectInfo_Internal_ReadObjectInfo_Type_Il2CppStringArray_Il2CppReferenceArray_1_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectReader>.NativeClassPtr, 100671452);
			ObjectReader.NativeMethodInfoPtr_Parse_Internal_Void_ParseRecord_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectReader>.NativeClassPtr, 100671453);
			ObjectReader.NativeMethodInfoPtr_ParseError_Private_Void_ParseRecord_ParseRecord_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectReader>.NativeClassPtr, 100671454);
			ObjectReader.NativeMethodInfoPtr_ParseSerializedStreamHeader_Private_Void_ParseRecord_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectReader>.NativeClassPtr, 100671455);
			ObjectReader.NativeMethodInfoPtr_ParseSerializedStreamHeaderEnd_Private_Void_ParseRecord_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectReader>.NativeClassPtr, 100671456);
			ObjectReader.NativeMethodInfoPtr_ParseObject_Private_Void_ParseRecord_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectReader>.NativeClassPtr, 100671457);
			ObjectReader.NativeMethodInfoPtr_ParseObjectEnd_Private_Void_ParseRecord_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectReader>.NativeClassPtr, 100671458);
			ObjectReader.NativeMethodInfoPtr_ParseArray_Private_Void_ParseRecord_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectReader>.NativeClassPtr, 100671459);
			ObjectReader.NativeMethodInfoPtr_NextRectangleMap_Private_Void_ParseRecord_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectReader>.NativeClassPtr, 100671460);
			ObjectReader.NativeMethodInfoPtr_ParseArrayMember_Private_Void_ParseRecord_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectReader>.NativeClassPtr, 100671461);
			ObjectReader.NativeMethodInfoPtr_ParseArrayMemberEnd_Private_Void_ParseRecord_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectReader>.NativeClassPtr, 100671462);
			ObjectReader.NativeMethodInfoPtr_ParseMember_Private_Void_ParseRecord_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectReader>.NativeClassPtr, 100671463);
			ObjectReader.NativeMethodInfoPtr_ParseMemberEnd_Private_Void_ParseRecord_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectReader>.NativeClassPtr, 100671464);
			ObjectReader.NativeMethodInfoPtr_ParseString_Private_Void_ParseRecord_ParseRecord_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectReader>.NativeClassPtr, 100671465);
			ObjectReader.NativeMethodInfoPtr_RegisterObject_Private_Void_Object_ParseRecord_ParseRecord_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectReader>.NativeClassPtr, 100671466);
			ObjectReader.NativeMethodInfoPtr_RegisterObject_Private_Void_Object_ParseRecord_ParseRecord_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectReader>.NativeClassPtr, 100671467);
			ObjectReader.NativeMethodInfoPtr_GetId_Internal_Int64_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectReader>.NativeClassPtr, 100671468);
			ObjectReader.NativeMethodInfoPtr_Bind_Internal_Type_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectReader>.NativeClassPtr, 100671469);
			ObjectReader.NativeMethodInfoPtr_FastBindToType_Internal_Type_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectReader>.NativeClassPtr, 100671470);
			ObjectReader.NativeMethodInfoPtr_ResolveSimpleAssemblyName_Private_Static_Assembly_AssemblyName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectReader>.NativeClassPtr, 100671471);
			ObjectReader.NativeMethodInfoPtr_GetSimplyNamedTypeFromAssembly_Private_Static_Void_Assembly_String_byref_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectReader>.NativeClassPtr, 100671472);
			ObjectReader.NativeMethodInfoPtr_GetType_Internal_Type_BinaryAssemblyInfo_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectReader>.NativeClassPtr, 100671473);
			ObjectReader.NativeMethodInfoPtr_CheckTypeForwardedTo_Private_Static_Void_Assembly_Assembly_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectReader>.NativeClassPtr, 100671474);
		}

		// Token: 0x17000C7A RID: 3194
		// (get) Token: 0x0600357A RID: 13690 RVA: 0x00109364 File Offset: 0x00107564
		public unsafe SerStack ValueFixupStack
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1388896, RefRangeEnd = 1388897, XrefRangeStart = 1388889, XrefRangeEnd = 1388896, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectReader.NativeMethodInfoPtr_get_ValueFixupStack_Private_get_SerStack_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SerStack>(intPtr3) : null;
			}
		}

		// Token: 0x17000C7B RID: 3195
		// (get) Token: 0x0600357B RID: 13691 RVA: 0x001093A4 File Offset: 0x001075A4
		// (set) Token: 0x0600357C RID: 13692 RVA: 0x001093E4 File Offset: 0x001075E4
		public unsafe Object TopObject
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectReader.NativeMethodInfoPtr_get_TopObject_Internal_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 1388899, RefRangeEnd = 1388902, XrefRangeStart = 1388897, XrefRangeEnd = 1388899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectReader.NativeMethodInfoPtr_set_TopObject_Internal_set_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600357D RID: 13693 RVA: 0x00109428 File Offset: 0x00107628
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1388902, XrefRangeEnd = 1388921, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ObjectReader(Stream stream, ISurrogateSelector selector, StreamingContext context, InternalFE formatterEnums, SerializationBinder binder)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ObjectReader>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stream);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(selector);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(formatterEnums);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(binder);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectReader.NativeMethodInfoPtr__ctor_Internal_Void_Stream_ISurrogateSelector_StreamingContext_InternalFE_SerializationBinder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600357E RID: 13694 RVA: 0x001094C4 File Offset: 0x001076C4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1388968, RefRangeEnd = 1388969, XrefRangeStart = 1388921, XrefRangeEnd = 1388968, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object Deserialize(HeaderHandler handler, __BinaryParser serParser, bool fCheck)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(handler);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(serParser);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fCheck;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectReader.NativeMethodInfoPtr_Deserialize_Internal_Object_HeaderHandler___BinaryParser_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x0600357F RID: 13695 RVA: 0x00109534 File Offset: 0x00107734
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1388972, RefRangeEnd = 1388974, XrefRangeStart = 1388969, XrefRangeEnd = 1388972, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool HasSurrogate(Type t)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectReader.NativeMethodInfoPtr_HasSurrogate_Private_Boolean_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003580 RID: 13696 RVA: 0x00109584 File Offset: 0x00107784
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1388975, RefRangeEnd = 1388977, XrefRangeStart = 1388974, XrefRangeEnd = 1388975, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckSerializable(Type t)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectReader.NativeMethodInfoPtr_CheckSerializable_Private_Void_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003581 RID: 13697 RVA: 0x001095C8 File Offset: 0x001077C8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1389000, RefRangeEnd = 1389002, XrefRangeStart = 1388977, XrefRangeEnd = 1389000, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitFullDeserialization()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectReader.NativeMethodInfoPtr_InitFullDeserialization_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003582 RID: 13698 RVA: 0x001095FC File Offset: 0x001077FC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1389002, RefRangeEnd = 1389005, XrefRangeStart = 1389002, XrefRangeEnd = 1389002, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object CrossAppDomainArray(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectReader.NativeMethodInfoPtr_CrossAppDomainArray_Internal_Object_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06003583 RID: 13699 RVA: 0x00109648 File Offset: 0x00107848
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1389005, XrefRangeEnd = 1389006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ReadObjectInfo CreateReadObjectInfo(Type objectType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(objectType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectReader.NativeMethodInfoPtr_CreateReadObjectInfo_Internal_ReadObjectInfo_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ReadObjectInfo>(intPtr3) : null;
			}
		}

		// Token: 0x06003584 RID: 13700 RVA: 0x00109698 File Offset: 0x00107898
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1389006, XrefRangeEnd = 1389020, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ReadObjectInfo CreateReadObjectInfo(Type objectType, Il2CppStringArray memberNames, Il2CppReferenceArray<Type> memberTypes)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(objectType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(memberNames);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(memberTypes);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectReader.NativeMethodInfoPtr_CreateReadObjectInfo_Internal_ReadObjectInfo_Type_Il2CppStringArray_Il2CppReferenceArray_1_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ReadObjectInfo>(intPtr3) : null;
		}

		// Token: 0x06003585 RID: 13701 RVA: 0x0010970C File Offset: 0x0010790C
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 1389024, RefRangeEnd = 1389036, XrefRangeStart = 1389020, XrefRangeEnd = 1389024, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Parse(ParseRecord pr)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pr);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectReader.NativeMethodInfoPtr_Parse_Internal_Void_ParseRecord_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003586 RID: 13702 RVA: 0x00109750 File Offset: 0x00107950
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1389036, XrefRangeEnd = 1389082, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ParseError(ParseRecord processing, ParseRecord onStack)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(processing);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(onStack);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectReader.NativeMethodInfoPtr_ParseError_Private_Void_ParseRecord_ParseRecord_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003587 RID: 13703 RVA: 0x001097A4 File Offset: 0x001079A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1389082, XrefRangeEnd = 1389084, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ParseSerializedStreamHeader(ParseRecord pr)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pr);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectReader.NativeMethodInfoPtr_ParseSerializedStreamHeader_Private_Void_ParseRecord_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003588 RID: 13704 RVA: 0x001097E8 File Offset: 0x001079E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1389084, XrefRangeEnd = 1389086, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ParseSerializedStreamHeaderEnd(ParseRecord pr)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pr);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectReader.NativeMethodInfoPtr_ParseSerializedStreamHeaderEnd_Private_Void_ParseRecord_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003589 RID: 13705 RVA: 0x0010982C File Offset: 0x00107A2C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1389109, RefRangeEnd = 1389111, XrefRangeStart = 1389086, XrefRangeEnd = 1389109, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ParseObject(ParseRecord pr)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pr);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectReader.NativeMethodInfoPtr_ParseObject_Private_Void_ParseRecord_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600358A RID: 13706 RVA: 0x00109870 File Offset: 0x00107A70
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1389123, RefRangeEnd = 1389126, XrefRangeStart = 1389111, XrefRangeEnd = 1389123, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ParseObjectEnd(ParseRecord pr)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pr);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectReader.NativeMethodInfoPtr_ParseObjectEnd_Private_Void_ParseRecord_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600358B RID: 13707 RVA: 0x001098B4 File Offset: 0x00107AB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1389126, XrefRangeEnd = 1389200, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ParseArray(ParseRecord pr)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pr);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectReader.NativeMethodInfoPtr_ParseArray_Private_Void_ParseRecord_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600358C RID: 13708 RVA: 0x001098F8 File Offset: 0x00107AF8
		[CallerCount(0)]
		public unsafe void NextRectangleMap(ParseRecord pr)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pr);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectReader.NativeMethodInfoPtr_NextRectangleMap_Private_Void_ParseRecord_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600358D RID: 13709 RVA: 0x0010993C File Offset: 0x00107B3C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1389285, RefRangeEnd = 1389286, XrefRangeStart = 1389200, XrefRangeEnd = 1389285, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ParseArrayMember(ParseRecord pr)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pr);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectReader.NativeMethodInfoPtr_ParseArrayMember_Private_Void_ParseRecord_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600358E RID: 13710 RVA: 0x00109980 File Offset: 0x00107B80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1389286, XrefRangeEnd = 1389287, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ParseArrayMemberEnd(ParseRecord pr)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pr);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectReader.NativeMethodInfoPtr_ParseArrayMemberEnd_Private_Void_ParseRecord_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600358F RID: 13711 RVA: 0x001099C4 File Offset: 0x00107BC4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1389307, RefRangeEnd = 1389308, XrefRangeStart = 1389287, XrefRangeEnd = 1389307, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ParseMember(ParseRecord pr)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pr);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectReader.NativeMethodInfoPtr_ParseMember_Private_Void_ParseRecord_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003590 RID: 13712 RVA: 0x00109A08 File Offset: 0x00107C08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1389308, XrefRangeEnd = 1389310, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ParseMemberEnd(ParseRecord pr)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pr);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectReader.NativeMethodInfoPtr_ParseMemberEnd_Private_Void_ParseRecord_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003591 RID: 13713 RVA: 0x00109A4C File Offset: 0x00107C4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1389310, XrefRangeEnd = 1389311, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ParseString(ParseRecord pr, ParseRecord parentPr)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pr);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parentPr);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectReader.NativeMethodInfoPtr_ParseString_Private_Void_ParseRecord_ParseRecord_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003592 RID: 13714 RVA: 0x00109AA0 File Offset: 0x00107CA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1389311, XrefRangeEnd = 1389314, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RegisterObject(Object obj, ParseRecord pr, ParseRecord objectPr)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(pr);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(objectPr);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectReader.NativeMethodInfoPtr_RegisterObject_Private_Void_Object_ParseRecord_ParseRecord_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003593 RID: 13715 RVA: 0x00109B08 File Offset: 0x00107D08
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1389317, RefRangeEnd = 1389320, XrefRangeStart = 1389314, XrefRangeEnd = 1389317, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RegisterObject(Object obj, ParseRecord pr, ParseRecord objectPr, bool bIsString)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(pr);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(objectPr);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bIsString;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectReader.NativeMethodInfoPtr_RegisterObject_Private_Void_Object_ParseRecord_ParseRecord_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003594 RID: 13716 RVA: 0x00109B7C File Offset: 0x00107D7C
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 1389322, RefRangeEnd = 1389332, XrefRangeStart = 1389320, XrefRangeEnd = 1389322, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe long GetId(long objectId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref objectId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectReader.NativeMethodInfoPtr_GetId_Internal_Int64_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003595 RID: 13717 RVA: 0x00109BC8 File Offset: 0x00107DC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1389332, XrefRangeEnd = 1389333, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Type Bind(string assemblyString, string typeString)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(assemblyString);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(typeString);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectReader.NativeMethodInfoPtr_Bind_Internal_Type_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
		}

		// Token: 0x06003596 RID: 13718 RVA: 0x00109C2C File Offset: 0x00107E2C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1389360, RefRangeEnd = 1389361, XrefRangeStart = 1389333, XrefRangeEnd = 1389360, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Type FastBindToType(string assemblyName, string typeName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(assemblyName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(typeName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectReader.NativeMethodInfoPtr_FastBindToType_Internal_Type_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
		}

		// Token: 0x06003597 RID: 13719 RVA: 0x00109C90 File Offset: 0x00107E90
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1389364, RefRangeEnd = 1389365, XrefRangeStart = 1389361, XrefRangeEnd = 1389364, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Assembly ResolveSimpleAssemblyName(AssemblyName assemblyName)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(assemblyName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectReader.NativeMethodInfoPtr_ResolveSimpleAssemblyName_Private_Static_Assembly_AssemblyName_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Assembly>(intPtr3) : null;
			}
		}

		// Token: 0x06003598 RID: 13720 RVA: 0x00109CD4 File Offset: 0x00107ED4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1389392, RefRangeEnd = 1389393, XrefRangeStart = 1389365, XrefRangeEnd = 1389392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void GetSimplyNamedTypeFromAssembly(Assembly assm, string typeName, ref Type type)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(assm);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(typeName);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(type);
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ObjectReader.NativeMethodInfoPtr_GetSimplyNamedTypeFromAssembly_Private_Static_Void_Assembly_String_byref_Type_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			type = ((intPtr4 == 0) ? null : new Type(intPtr4));
		}

		// Token: 0x06003599 RID: 13721 RVA: 0x00109D44 File Offset: 0x00107F44
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1389397, RefRangeEnd = 1389399, XrefRangeStart = 1389393, XrefRangeEnd = 1389397, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Type GetType(BinaryAssemblyInfo assemblyInfo, string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(assemblyInfo);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectReader.NativeMethodInfoPtr_GetType_Internal_Type_BinaryAssemblyInfo_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
		}

		// Token: 0x0600359A RID: 13722 RVA: 0x00109DA8 File Offset: 0x00107FA8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1389410, RefRangeEnd = 1389411, XrefRangeStart = 1389399, XrefRangeEnd = 1389410, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CheckTypeForwardedTo(Assembly sourceAssembly, Assembly destAssembly, Type resolvedType)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sourceAssembly);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(destAssembly);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(resolvedType);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectReader.NativeMethodInfoPtr_CheckTypeForwardedTo_Private_Static_Void_Assembly_Assembly_Type_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600359B RID: 13723 RVA: 0x00013178 File Offset: 0x00011378
		public ObjectReader(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000C62 RID: 3170
		// (get) Token: 0x0600359C RID: 13724 RVA: 0x00109E04 File Offset: 0x00108004
		// (set) Token: 0x0600359D RID: 13725 RVA: 0x00013181 File Offset: 0x00011381
		public unsafe Stream m_stream
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectReader.NativeFieldInfoPtr_m_stream);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Stream>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectReader.NativeFieldInfoPtr_m_stream), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C63 RID: 3171
		// (get) Token: 0x0600359E RID: 13726 RVA: 0x00109E34 File Offset: 0x00108034
		// (set) Token: 0x0600359F RID: 13727 RVA: 0x000131A0 File Offset: 0x000113A0
		public unsafe ISurrogateSelector m_surrogates
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectReader.NativeFieldInfoPtr_m_surrogates);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ISurrogateSelector>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectReader.NativeFieldInfoPtr_m_surrogates), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C64 RID: 3172
		// (get) Token: 0x060035A0 RID: 13728 RVA: 0x00109E64 File Offset: 0x00108064
		// (set) Token: 0x060035A1 RID: 13729 RVA: 0x000131BF File Offset: 0x000113BF
		public StreamingContext m_context
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectReader.NativeFieldInfoPtr_m_context);
				return new StreamingContext(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<StreamingContext>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectReader.NativeFieldInfoPtr_m_context), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<StreamingContext>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000C65 RID: 3173
		// (get) Token: 0x060035A2 RID: 13730 RVA: 0x00109E94 File Offset: 0x00108094
		// (set) Token: 0x060035A3 RID: 13731 RVA: 0x000131ED File Offset: 0x000113ED
		public unsafe ObjectManager m_objectManager
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectReader.NativeFieldInfoPtr_m_objectManager);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectManager>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectReader.NativeFieldInfoPtr_m_objectManager), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C66 RID: 3174
		// (get) Token: 0x060035A4 RID: 13732 RVA: 0x00109EC4 File Offset: 0x001080C4
		// (set) Token: 0x060035A5 RID: 13733 RVA: 0x0001320C File Offset: 0x0001140C
		public unsafe InternalFE formatterEnums
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectReader.NativeFieldInfoPtr_formatterEnums);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InternalFE>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectReader.NativeFieldInfoPtr_formatterEnums), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C67 RID: 3175
		// (get) Token: 0x060035A6 RID: 13734 RVA: 0x00109EF4 File Offset: 0x001080F4
		// (set) Token: 0x060035A7 RID: 13735 RVA: 0x0001322B File Offset: 0x0001142B
		public unsafe SerializationBinder m_binder
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectReader.NativeFieldInfoPtr_m_binder);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SerializationBinder>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectReader.NativeFieldInfoPtr_m_binder), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C68 RID: 3176
		// (get) Token: 0x060035A8 RID: 13736 RVA: 0x00109F24 File Offset: 0x00108124
		// (set) Token: 0x060035A9 RID: 13737 RVA: 0x0001324A File Offset: 0x0001144A
		public unsafe long topId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectReader.NativeFieldInfoPtr_topId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectReader.NativeFieldInfoPtr_topId)) = value;
			}
		}

		// Token: 0x17000C69 RID: 3177
		// (get) Token: 0x060035AA RID: 13738 RVA: 0x00109F4C File Offset: 0x0010814C
		// (set) Token: 0x060035AB RID: 13739 RVA: 0x00013265 File Offset: 0x00011465
		public unsafe bool bSimpleAssembly
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectReader.NativeFieldInfoPtr_bSimpleAssembly);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectReader.NativeFieldInfoPtr_bSimpleAssembly)) = value;
			}
		}

		// Token: 0x17000C6A RID: 3178
		// (get) Token: 0x060035AC RID: 13740 RVA: 0x00109F74 File Offset: 0x00108174
		// (set) Token: 0x060035AD RID: 13741 RVA: 0x00013280 File Offset: 0x00011480
		public unsafe Object handlerObject
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectReader.NativeFieldInfoPtr_handlerObject);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectReader.NativeFieldInfoPtr_handlerObject), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C6B RID: 3179
		// (get) Token: 0x060035AE RID: 13742 RVA: 0x00109FA4 File Offset: 0x001081A4
		// (set) Token: 0x060035AF RID: 13743 RVA: 0x0001329F File Offset: 0x0001149F
		public unsafe Object m_topObject
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectReader.NativeFieldInfoPtr_m_topObject);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectReader.NativeFieldInfoPtr_m_topObject), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C6C RID: 3180
		// (get) Token: 0x060035B0 RID: 13744 RVA: 0x00109FD4 File Offset: 0x001081D4
		// (set) Token: 0x060035B1 RID: 13745 RVA: 0x000132BE File Offset: 0x000114BE
		public unsafe Il2CppReferenceArray<Header> headers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectReader.NativeFieldInfoPtr_headers);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Header>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectReader.NativeFieldInfoPtr_headers), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C6D RID: 3181
		// (get) Token: 0x060035B2 RID: 13746 RVA: 0x0010A004 File Offset: 0x00108204
		// (set) Token: 0x060035B3 RID: 13747 RVA: 0x000132DD File Offset: 0x000114DD
		public unsafe HeaderHandler handler
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectReader.NativeFieldInfoPtr_handler);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HeaderHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectReader.NativeFieldInfoPtr_handler), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C6E RID: 3182
		// (get) Token: 0x060035B4 RID: 13748 RVA: 0x0010A034 File Offset: 0x00108234
		// (set) Token: 0x060035B5 RID: 13749 RVA: 0x000132FC File Offset: 0x000114FC
		public unsafe SerObjectInfoInit serObjectInfoInit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectReader.NativeFieldInfoPtr_serObjectInfoInit);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SerObjectInfoInit>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectReader.NativeFieldInfoPtr_serObjectInfoInit), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C6F RID: 3183
		// (get) Token: 0x060035B6 RID: 13750 RVA: 0x0010A064 File Offset: 0x00108264
		// (set) Token: 0x060035B7 RID: 13751 RVA: 0x0001331B File Offset: 0x0001151B
		public unsafe IFormatterConverter m_formatterConverter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectReader.NativeFieldInfoPtr_m_formatterConverter);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IFormatterConverter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectReader.NativeFieldInfoPtr_m_formatterConverter), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C70 RID: 3184
		// (get) Token: 0x060035B8 RID: 13752 RVA: 0x0010A094 File Offset: 0x00108294
		// (set) Token: 0x060035B9 RID: 13753 RVA: 0x0001333A File Offset: 0x0001153A
		public unsafe SerStack stack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectReader.NativeFieldInfoPtr_stack);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SerStack>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectReader.NativeFieldInfoPtr_stack), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C71 RID: 3185
		// (get) Token: 0x060035BA RID: 13754 RVA: 0x0010A0C4 File Offset: 0x001082C4
		// (set) Token: 0x060035BB RID: 13755 RVA: 0x00013359 File Offset: 0x00011559
		public unsafe SerStack valueFixupStack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectReader.NativeFieldInfoPtr_valueFixupStack);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SerStack>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectReader.NativeFieldInfoPtr_valueFixupStack), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C72 RID: 3186
		// (get) Token: 0x060035BC RID: 13756 RVA: 0x0010A0F4 File Offset: 0x001082F4
		// (set) Token: 0x060035BD RID: 13757 RVA: 0x00013378 File Offset: 0x00011578
		public unsafe Il2CppReferenceArray<Object> crossAppDomainArray
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectReader.NativeFieldInfoPtr_crossAppDomainArray);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectReader.NativeFieldInfoPtr_crossAppDomainArray), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C73 RID: 3187
		// (get) Token: 0x060035BE RID: 13758 RVA: 0x0010A124 File Offset: 0x00108324
		// (set) Token: 0x060035BF RID: 13759 RVA: 0x00013397 File Offset: 0x00011597
		public unsafe bool bFullDeserialization
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectReader.NativeFieldInfoPtr_bFullDeserialization);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectReader.NativeFieldInfoPtr_bFullDeserialization)) = value;
			}
		}

		// Token: 0x17000C74 RID: 3188
		// (get) Token: 0x060035C0 RID: 13760 RVA: 0x0010A14C File Offset: 0x0010834C
		// (set) Token: 0x060035C1 RID: 13761 RVA: 0x000133B2 File Offset: 0x000115B2
		public unsafe bool bOldFormatDetected
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectReader.NativeFieldInfoPtr_bOldFormatDetected);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectReader.NativeFieldInfoPtr_bOldFormatDetected)) = value;
			}
		}

		// Token: 0x17000C75 RID: 3189
		// (get) Token: 0x060035C2 RID: 13762 RVA: 0x0010A174 File Offset: 0x00108374
		// (set) Token: 0x060035C3 RID: 13763 RVA: 0x000133CD File Offset: 0x000115CD
		public unsafe IntSizedArray valTypeObjectIdTable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectReader.NativeFieldInfoPtr_valTypeObjectIdTable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IntSizedArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectReader.NativeFieldInfoPtr_valTypeObjectIdTable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C76 RID: 3190
		// (get) Token: 0x060035C4 RID: 13764 RVA: 0x0010A1A4 File Offset: 0x001083A4
		// (set) Token: 0x060035C5 RID: 13765 RVA: 0x000133EC File Offset: 0x000115EC
		public unsafe NameCache typeCache
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectReader.NativeFieldInfoPtr_typeCache);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NameCache>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectReader.NativeFieldInfoPtr_typeCache), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C77 RID: 3191
		// (get) Token: 0x060035C6 RID: 13766 RVA: 0x0010A1D4 File Offset: 0x001083D4
		// (set) Token: 0x060035C7 RID: 13767 RVA: 0x0001340B File Offset: 0x0001160B
		public unsafe string previousAssemblyString
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectReader.NativeFieldInfoPtr_previousAssemblyString);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectReader.NativeFieldInfoPtr_previousAssemblyString), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000C78 RID: 3192
		// (get) Token: 0x060035C8 RID: 13768 RVA: 0x0010A1FC File Offset: 0x001083FC
		// (set) Token: 0x060035C9 RID: 13769 RVA: 0x0001342A File Offset: 0x0001162A
		public unsafe string previousName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectReader.NativeFieldInfoPtr_previousName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectReader.NativeFieldInfoPtr_previousName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000C79 RID: 3193
		// (get) Token: 0x060035CA RID: 13770 RVA: 0x0010A224 File Offset: 0x00108424
		// (set) Token: 0x060035CB RID: 13771 RVA: 0x00013449 File Offset: 0x00011649
		public unsafe Type previousType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectReader.NativeFieldInfoPtr_previousType);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectReader.NativeFieldInfoPtr_previousType), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002BB7 RID: 11191
		private static readonly IntPtr NativeFieldInfoPtr_m_stream;

		// Token: 0x04002BB8 RID: 11192
		private static readonly IntPtr NativeFieldInfoPtr_m_surrogates;

		// Token: 0x04002BB9 RID: 11193
		private static readonly IntPtr NativeFieldInfoPtr_m_context;

		// Token: 0x04002BBA RID: 11194
		private static readonly IntPtr NativeFieldInfoPtr_m_objectManager;

		// Token: 0x04002BBB RID: 11195
		private static readonly IntPtr NativeFieldInfoPtr_formatterEnums;

		// Token: 0x04002BBC RID: 11196
		private static readonly IntPtr NativeFieldInfoPtr_m_binder;

		// Token: 0x04002BBD RID: 11197
		private static readonly IntPtr NativeFieldInfoPtr_topId;

		// Token: 0x04002BBE RID: 11198
		private static readonly IntPtr NativeFieldInfoPtr_bSimpleAssembly;

		// Token: 0x04002BBF RID: 11199
		private static readonly IntPtr NativeFieldInfoPtr_handlerObject;

		// Token: 0x04002BC0 RID: 11200
		private static readonly IntPtr NativeFieldInfoPtr_m_topObject;

		// Token: 0x04002BC1 RID: 11201
		private static readonly IntPtr NativeFieldInfoPtr_headers;

		// Token: 0x04002BC2 RID: 11202
		private static readonly IntPtr NativeFieldInfoPtr_handler;

		// Token: 0x04002BC3 RID: 11203
		private static readonly IntPtr NativeFieldInfoPtr_serObjectInfoInit;

		// Token: 0x04002BC4 RID: 11204
		private static readonly IntPtr NativeFieldInfoPtr_m_formatterConverter;

		// Token: 0x04002BC5 RID: 11205
		private static readonly IntPtr NativeFieldInfoPtr_stack;

		// Token: 0x04002BC6 RID: 11206
		private static readonly IntPtr NativeFieldInfoPtr_valueFixupStack;

		// Token: 0x04002BC7 RID: 11207
		private static readonly IntPtr NativeFieldInfoPtr_crossAppDomainArray;

		// Token: 0x04002BC8 RID: 11208
		private static readonly IntPtr NativeFieldInfoPtr_bFullDeserialization;

		// Token: 0x04002BC9 RID: 11209
		private static readonly IntPtr NativeFieldInfoPtr_bOldFormatDetected;

		// Token: 0x04002BCA RID: 11210
		private static readonly IntPtr NativeFieldInfoPtr_valTypeObjectIdTable;

		// Token: 0x04002BCB RID: 11211
		private static readonly IntPtr NativeFieldInfoPtr_typeCache;

		// Token: 0x04002BCC RID: 11212
		private static readonly IntPtr NativeFieldInfoPtr_previousAssemblyString;

		// Token: 0x04002BCD RID: 11213
		private static readonly IntPtr NativeFieldInfoPtr_previousName;

		// Token: 0x04002BCE RID: 11214
		private static readonly IntPtr NativeFieldInfoPtr_previousType;

		// Token: 0x04002BCF RID: 11215
		private static readonly IntPtr NativeMethodInfoPtr_get_ValueFixupStack_Private_get_SerStack_0;

		// Token: 0x04002BD0 RID: 11216
		private static readonly IntPtr NativeMethodInfoPtr_get_TopObject_Internal_get_Object_0;

		// Token: 0x04002BD1 RID: 11217
		private static readonly IntPtr NativeMethodInfoPtr_set_TopObject_Internal_set_Void_Object_0;

		// Token: 0x04002BD2 RID: 11218
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Stream_ISurrogateSelector_StreamingContext_InternalFE_SerializationBinder_0;

		// Token: 0x04002BD3 RID: 11219
		private static readonly IntPtr NativeMethodInfoPtr_Deserialize_Internal_Object_HeaderHandler___BinaryParser_Boolean_0;

		// Token: 0x04002BD4 RID: 11220
		private static readonly IntPtr NativeMethodInfoPtr_HasSurrogate_Private_Boolean_Type_0;

		// Token: 0x04002BD5 RID: 11221
		private static readonly IntPtr NativeMethodInfoPtr_CheckSerializable_Private_Void_Type_0;

		// Token: 0x04002BD6 RID: 11222
		private static readonly IntPtr NativeMethodInfoPtr_InitFullDeserialization_Private_Void_0;

		// Token: 0x04002BD7 RID: 11223
		private static readonly IntPtr NativeMethodInfoPtr_CrossAppDomainArray_Internal_Object_Int32_0;

		// Token: 0x04002BD8 RID: 11224
		private static readonly IntPtr NativeMethodInfoPtr_CreateReadObjectInfo_Internal_ReadObjectInfo_Type_0;

		// Token: 0x04002BD9 RID: 11225
		private static readonly IntPtr NativeMethodInfoPtr_CreateReadObjectInfo_Internal_ReadObjectInfo_Type_Il2CppStringArray_Il2CppReferenceArray_1_Type_0;

		// Token: 0x04002BDA RID: 11226
		private static readonly IntPtr NativeMethodInfoPtr_Parse_Internal_Void_ParseRecord_0;

		// Token: 0x04002BDB RID: 11227
		private static readonly IntPtr NativeMethodInfoPtr_ParseError_Private_Void_ParseRecord_ParseRecord_0;

		// Token: 0x04002BDC RID: 11228
		private static readonly IntPtr NativeMethodInfoPtr_ParseSerializedStreamHeader_Private_Void_ParseRecord_0;

		// Token: 0x04002BDD RID: 11229
		private static readonly IntPtr NativeMethodInfoPtr_ParseSerializedStreamHeaderEnd_Private_Void_ParseRecord_0;

		// Token: 0x04002BDE RID: 11230
		private static readonly IntPtr NativeMethodInfoPtr_ParseObject_Private_Void_ParseRecord_0;

		// Token: 0x04002BDF RID: 11231
		private static readonly IntPtr NativeMethodInfoPtr_ParseObjectEnd_Private_Void_ParseRecord_0;

		// Token: 0x04002BE0 RID: 11232
		private static readonly IntPtr NativeMethodInfoPtr_ParseArray_Private_Void_ParseRecord_0;

		// Token: 0x04002BE1 RID: 11233
		private static readonly IntPtr NativeMethodInfoPtr_NextRectangleMap_Private_Void_ParseRecord_0;

		// Token: 0x04002BE2 RID: 11234
		private static readonly IntPtr NativeMethodInfoPtr_ParseArrayMember_Private_Void_ParseRecord_0;

		// Token: 0x04002BE3 RID: 11235
		private static readonly IntPtr NativeMethodInfoPtr_ParseArrayMemberEnd_Private_Void_ParseRecord_0;

		// Token: 0x04002BE4 RID: 11236
		private static readonly IntPtr NativeMethodInfoPtr_ParseMember_Private_Void_ParseRecord_0;

		// Token: 0x04002BE5 RID: 11237
		private static readonly IntPtr NativeMethodInfoPtr_ParseMemberEnd_Private_Void_ParseRecord_0;

		// Token: 0x04002BE6 RID: 11238
		private static readonly IntPtr NativeMethodInfoPtr_ParseString_Private_Void_ParseRecord_ParseRecord_0;

		// Token: 0x04002BE7 RID: 11239
		private static readonly IntPtr NativeMethodInfoPtr_RegisterObject_Private_Void_Object_ParseRecord_ParseRecord_0;

		// Token: 0x04002BE8 RID: 11240
		private static readonly IntPtr NativeMethodInfoPtr_RegisterObject_Private_Void_Object_ParseRecord_ParseRecord_Boolean_0;

		// Token: 0x04002BE9 RID: 11241
		private static readonly IntPtr NativeMethodInfoPtr_GetId_Internal_Int64_Int64_0;

		// Token: 0x04002BEA RID: 11242
		private static readonly IntPtr NativeMethodInfoPtr_Bind_Internal_Type_String_String_0;

		// Token: 0x04002BEB RID: 11243
		private static readonly IntPtr NativeMethodInfoPtr_FastBindToType_Internal_Type_String_String_0;

		// Token: 0x04002BEC RID: 11244
		private static readonly IntPtr NativeMethodInfoPtr_ResolveSimpleAssemblyName_Private_Static_Assembly_AssemblyName_0;

		// Token: 0x04002BED RID: 11245
		private static readonly IntPtr NativeMethodInfoPtr_GetSimplyNamedTypeFromAssembly_Private_Static_Void_Assembly_String_byref_Type_0;

		// Token: 0x04002BEE RID: 11246
		private static readonly IntPtr NativeMethodInfoPtr_GetType_Internal_Type_BinaryAssemblyInfo_String_0;

		// Token: 0x04002BEF RID: 11247
		private static readonly IntPtr NativeMethodInfoPtr_CheckTypeForwardedTo_Private_Static_Void_Assembly_Assembly_Type_0;

		// Token: 0x02000670 RID: 1648
		public class TypeNAssembly : Object
		{
			// Token: 0x06005B6E RID: 23406 RVA: 0x0019FEB4 File Offset: 0x0019E0B4
			// Note: this type is marked as 'beforefieldinit'.
			static TypeNAssembly()
			{
				Il2CppClassPointerStore<ObjectReader.TypeNAssembly>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ObjectReader>.NativeClassPtr, "TypeNAssembly");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ObjectReader.TypeNAssembly>.NativeClassPtr);
				ObjectReader.TypeNAssembly.NativeFieldInfoPtr_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectReader.TypeNAssembly>.NativeClassPtr, "type");
				ObjectReader.TypeNAssembly.NativeFieldInfoPtr_assemblyName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectReader.TypeNAssembly>.NativeClassPtr, "assemblyName");
				ObjectReader.TypeNAssembly.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectReader.TypeNAssembly>.NativeClassPtr, 100671475);
			}

			// Token: 0x06005B6F RID: 23407 RVA: 0x0019FF1C File Offset: 0x0019E11C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe TypeNAssembly()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ObjectReader.TypeNAssembly>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectReader.TypeNAssembly.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005B70 RID: 23408 RVA: 0x0002124D File Offset: 0x0001F44D
			public TypeNAssembly(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700176F RID: 5999
			// (get) Token: 0x06005B71 RID: 23409 RVA: 0x0019FF58 File Offset: 0x0019E158
			// (set) Token: 0x06005B72 RID: 23410 RVA: 0x00021256 File Offset: 0x0001F456
			public unsafe Type type
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectReader.TypeNAssembly.NativeFieldInfoPtr_type);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectReader.TypeNAssembly.NativeFieldInfoPtr_type), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001770 RID: 6000
			// (get) Token: 0x06005B73 RID: 23411 RVA: 0x0019FF88 File Offset: 0x0019E188
			// (set) Token: 0x06005B74 RID: 23412 RVA: 0x00021275 File Offset: 0x0001F475
			public unsafe string assemblyName
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectReader.TypeNAssembly.NativeFieldInfoPtr_assemblyName);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectReader.TypeNAssembly.NativeFieldInfoPtr_assemblyName), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04004A7B RID: 19067
			private static readonly IntPtr NativeFieldInfoPtr_type;

			// Token: 0x04004A7C RID: 19068
			private static readonly IntPtr NativeFieldInfoPtr_assemblyName;

			// Token: 0x04004A7D RID: 19069
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000671 RID: 1649
		public sealed class TopLevelAssemblyTypeResolver : Object
		{
			// Token: 0x06005B75 RID: 23413 RVA: 0x0019FFB0 File Offset: 0x0019E1B0
			// Note: this type is marked as 'beforefieldinit'.
			static TopLevelAssemblyTypeResolver()
			{
				Il2CppClassPointerStore<ObjectReader.TopLevelAssemblyTypeResolver>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ObjectReader>.NativeClassPtr, "TopLevelAssemblyTypeResolver");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ObjectReader.TopLevelAssemblyTypeResolver>.NativeClassPtr);
				ObjectReader.TopLevelAssemblyTypeResolver.NativeFieldInfoPtr_m_topLevelAssembly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectReader.TopLevelAssemblyTypeResolver>.NativeClassPtr, "m_topLevelAssembly");
				ObjectReader.TopLevelAssemblyTypeResolver.NativeMethodInfoPtr__ctor_Public_Void_Assembly_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectReader.TopLevelAssemblyTypeResolver>.NativeClassPtr, 100671476);
				ObjectReader.TopLevelAssemblyTypeResolver.NativeMethodInfoPtr_ResolveType_Public_Type_Assembly_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectReader.TopLevelAssemblyTypeResolver>.NativeClassPtr, 100671477);
			}

			// Token: 0x06005B76 RID: 23414 RVA: 0x001A0018 File Offset: 0x0019E218
			[CallerCount(148)]
			[CachedScanResults(RefRangeStart = 286435, RefRangeEnd = 286583, XrefRangeStart = 286435, XrefRangeEnd = 286583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe TopLevelAssemblyTypeResolver(Assembly topLevelAssembly)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ObjectReader.TopLevelAssemblyTypeResolver>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(topLevelAssembly);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectReader.TopLevelAssemblyTypeResolver.NativeMethodInfoPtr__ctor_Public_Void_Assembly_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06005B77 RID: 23415 RVA: 0x001A0064 File Offset: 0x0019E264
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1388887, XrefRangeEnd = 1388889, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Type ResolveType(Assembly assembly, string simpleTypeName, bool ignoreCase)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(assembly);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(simpleTypeName);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ignoreCase;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectReader.TopLevelAssemblyTypeResolver.NativeMethodInfoPtr_ResolveType_Public_Type_Assembly_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}

			// Token: 0x06005B78 RID: 23416 RVA: 0x00021294 File Offset: 0x0001F494
			public TopLevelAssemblyTypeResolver(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001771 RID: 6001
			// (get) Token: 0x06005B79 RID: 23417 RVA: 0x001A00D4 File Offset: 0x0019E2D4
			// (set) Token: 0x06005B7A RID: 23418 RVA: 0x0002129D File Offset: 0x0001F49D
			public unsafe Assembly m_topLevelAssembly
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectReader.TopLevelAssemblyTypeResolver.NativeFieldInfoPtr_m_topLevelAssembly);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Assembly>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectReader.TopLevelAssemblyTypeResolver.NativeFieldInfoPtr_m_topLevelAssembly), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04004A7E RID: 19070
			private static readonly IntPtr NativeFieldInfoPtr_m_topLevelAssembly;

			// Token: 0x04004A7F RID: 19071
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Assembly_0;

			// Token: 0x04004A80 RID: 19072
			private static readonly IntPtr NativeMethodInfoPtr_ResolveType_Public_Type_Assembly_String_Boolean_0;
		}
	}
}
