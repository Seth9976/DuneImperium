using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;

namespace Il2CppSystem.Runtime.Serialization.Formatters.Binary
{
	// Token: 0x02000367 RID: 871
	public sealed class ReadObjectInfo : Object
	{
		// Token: 0x06003519 RID: 13593 RVA: 0x001079C0 File Offset: 0x00105BC0
		// Note: this type is marked as 'beforefieldinit'.
		static ReadObjectInfo()
		{
			Il2CppClassPointerStore<ReadObjectInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Serialization.Formatters.Binary", "ReadObjectInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReadObjectInfo>.NativeClassPtr);
			ReadObjectInfo.NativeFieldInfoPtr_objectInfoId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReadObjectInfo>.NativeClassPtr, "objectInfoId");
			ReadObjectInfo.NativeFieldInfoPtr_readObjectInfoCounter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReadObjectInfo>.NativeClassPtr, "readObjectInfoCounter");
			ReadObjectInfo.NativeFieldInfoPtr_objectType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReadObjectInfo>.NativeClassPtr, "objectType");
			ReadObjectInfo.NativeFieldInfoPtr_objectManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReadObjectInfo>.NativeClassPtr, "objectManager");
			ReadObjectInfo.NativeFieldInfoPtr_count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReadObjectInfo>.NativeClassPtr, "count");
			ReadObjectInfo.NativeFieldInfoPtr_isSi = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReadObjectInfo>.NativeClassPtr, "isSi");
			ReadObjectInfo.NativeFieldInfoPtr_isNamed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReadObjectInfo>.NativeClassPtr, "isNamed");
			ReadObjectInfo.NativeFieldInfoPtr_isTyped = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReadObjectInfo>.NativeClassPtr, "isTyped");
			ReadObjectInfo.NativeFieldInfoPtr_bSimpleAssembly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReadObjectInfo>.NativeClassPtr, "bSimpleAssembly");
			ReadObjectInfo.NativeFieldInfoPtr_cache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReadObjectInfo>.NativeClassPtr, "cache");
			ReadObjectInfo.NativeFieldInfoPtr_wireMemberNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReadObjectInfo>.NativeClassPtr, "wireMemberNames");
			ReadObjectInfo.NativeFieldInfoPtr_wireMemberTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReadObjectInfo>.NativeClassPtr, "wireMemberTypes");
			ReadObjectInfo.NativeFieldInfoPtr_lastPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReadObjectInfo>.NativeClassPtr, "lastPosition");
			ReadObjectInfo.NativeFieldInfoPtr_serializationSurrogate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReadObjectInfo>.NativeClassPtr, "serializationSurrogate");
			ReadObjectInfo.NativeFieldInfoPtr_context = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReadObjectInfo>.NativeClassPtr, "context");
			ReadObjectInfo.NativeFieldInfoPtr_memberTypesList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReadObjectInfo>.NativeClassPtr, "memberTypesList");
			ReadObjectInfo.NativeFieldInfoPtr_serObjectInfoInit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReadObjectInfo>.NativeClassPtr, "serObjectInfoInit");
			ReadObjectInfo.NativeFieldInfoPtr_formatterConverter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReadObjectInfo>.NativeClassPtr, "formatterConverter");
			ReadObjectInfo.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadObjectInfo>.NativeClassPtr, 100671414);
			ReadObjectInfo.NativeMethodInfoPtr_ObjectEnd_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadObjectInfo>.NativeClassPtr, 100671415);
			ReadObjectInfo.NativeMethodInfoPtr_PrepareForReuse_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadObjectInfo>.NativeClassPtr, 100671416);
			ReadObjectInfo.NativeMethodInfoPtr_Create_Internal_Static_ReadObjectInfo_Type_ISurrogateSelector_StreamingContext_ObjectManager_SerObjectInfoInit_IFormatterConverter_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadObjectInfo>.NativeClassPtr, 100671417);
			ReadObjectInfo.NativeMethodInfoPtr_Init_Internal_Void_Type_ISurrogateSelector_StreamingContext_ObjectManager_SerObjectInfoInit_IFormatterConverter_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadObjectInfo>.NativeClassPtr, 100671418);
			ReadObjectInfo.NativeMethodInfoPtr_Create_Internal_Static_ReadObjectInfo_Type_Il2CppStringArray_Il2CppReferenceArray_1_Type_ISurrogateSelector_StreamingContext_ObjectManager_SerObjectInfoInit_IFormatterConverter_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadObjectInfo>.NativeClassPtr, 100671419);
			ReadObjectInfo.NativeMethodInfoPtr_Init_Internal_Void_Type_Il2CppStringArray_Il2CppReferenceArray_1_Type_ISurrogateSelector_StreamingContext_ObjectManager_SerObjectInfoInit_IFormatterConverter_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadObjectInfo>.NativeClassPtr, 100671420);
			ReadObjectInfo.NativeMethodInfoPtr_InitReadConstructor_Private_Void_Type_ISurrogateSelector_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadObjectInfo>.NativeClassPtr, 100671421);
			ReadObjectInfo.NativeMethodInfoPtr_InitSiRead_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadObjectInfo>.NativeClassPtr, 100671422);
			ReadObjectInfo.NativeMethodInfoPtr_InitNoMembers_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadObjectInfo>.NativeClassPtr, 100671423);
			ReadObjectInfo.NativeMethodInfoPtr_InitMemberInfo_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadObjectInfo>.NativeClassPtr, 100671424);
			ReadObjectInfo.NativeMethodInfoPtr_GetMemberInfo_Internal_MemberInfo_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadObjectInfo>.NativeClassPtr, 100671425);
			ReadObjectInfo.NativeMethodInfoPtr_GetType_Internal_Type_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadObjectInfo>.NativeClassPtr, 100671426);
			ReadObjectInfo.NativeMethodInfoPtr_AddValue_Internal_Void_String_Object_byref_SerializationInfo_byref_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadObjectInfo>.NativeClassPtr, 100671427);
			ReadObjectInfo.NativeMethodInfoPtr_InitDataStore_Internal_Void_byref_SerializationInfo_byref_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadObjectInfo>.NativeClassPtr, 100671428);
			ReadObjectInfo.NativeMethodInfoPtr_RecordFixup_Internal_Void_Int64_String_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadObjectInfo>.NativeClassPtr, 100671429);
			ReadObjectInfo.NativeMethodInfoPtr_PopulateObjectMembers_Internal_Void_Object_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadObjectInfo>.NativeClassPtr, 100671430);
			ReadObjectInfo.NativeMethodInfoPtr_Position_Private_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadObjectInfo>.NativeClassPtr, 100671431);
			ReadObjectInfo.NativeMethodInfoPtr_GetMemberTypes_Internal_Il2CppReferenceArray_1_Type_Il2CppStringArray_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadObjectInfo>.NativeClassPtr, 100671432);
			ReadObjectInfo.NativeMethodInfoPtr_GetMemberType_Internal_Type_MemberInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadObjectInfo>.NativeClassPtr, 100671433);
			ReadObjectInfo.NativeMethodInfoPtr_GetObjectInfo_Private_Static_ReadObjectInfo_SerObjectInfoInit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadObjectInfo>.NativeClassPtr, 100671434);
		}

		// Token: 0x0600351A RID: 13594 RVA: 0x00107CFC File Offset: 0x00105EFC
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ReadObjectInfo()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReadObjectInfo>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadObjectInfo.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600351B RID: 13595 RVA: 0x00107D38 File Offset: 0x00105F38
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ObjectEnd()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadObjectInfo.NativeMethodInfoPtr_ObjectEnd_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600351C RID: 13596 RVA: 0x00107D6C File Offset: 0x00105F6C
		[CallerCount(0)]
		public unsafe void PrepareForReuse()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadObjectInfo.NativeMethodInfoPtr_PrepareForReuse_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600351D RID: 13597 RVA: 0x00107DA0 File Offset: 0x00105FA0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1388694, RefRangeEnd = 1388697, XrefRangeStart = 1388682, XrefRangeEnd = 1388694, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ReadObjectInfo Create(Type objectType, ISurrogateSelector surrogateSelector, StreamingContext context, ObjectManager objectManager, SerObjectInfoInit serObjectInfoInit, IFormatterConverter converter, bool bSimpleAssembly)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(objectType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(surrogateSelector);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(objectManager);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(serObjectInfoInit);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(converter);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bSimpleAssembly;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadObjectInfo.NativeMethodInfoPtr_Create_Internal_Static_ReadObjectInfo_Type_ISurrogateSelector_StreamingContext_ObjectManager_SerObjectInfoInit_IFormatterConverter_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ReadObjectInfo>(intPtr3) : null;
		}

		// Token: 0x0600351E RID: 13598 RVA: 0x00107E54 File Offset: 0x00106054
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1388697, XrefRangeEnd = 1388703, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Init(Type objectType, ISurrogateSelector surrogateSelector, StreamingContext context, ObjectManager objectManager, SerObjectInfoInit serObjectInfoInit, IFormatterConverter converter, bool bSimpleAssembly)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(objectType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(surrogateSelector);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(objectManager);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(serObjectInfoInit);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(converter);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bSimpleAssembly;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadObjectInfo.NativeMethodInfoPtr_Init_Internal_Void_Type_ISurrogateSelector_StreamingContext_ObjectManager_SerObjectInfoInit_IFormatterConverter_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600351F RID: 13599 RVA: 0x00107F08 File Offset: 0x00106108
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1388703, XrefRangeEnd = 1388717, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ReadObjectInfo Create(Type objectType, Il2CppStringArray memberNames, Il2CppReferenceArray<Type> memberTypes, ISurrogateSelector surrogateSelector, StreamingContext context, ObjectManager objectManager, SerObjectInfoInit serObjectInfoInit, IFormatterConverter converter, bool bSimpleAssembly)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(objectType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(memberNames);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(memberTypes);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(surrogateSelector);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(objectManager);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(serObjectInfoInit);
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(converter);
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bSimpleAssembly;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadObjectInfo.NativeMethodInfoPtr_Create_Internal_Static_ReadObjectInfo_Type_Il2CppStringArray_Il2CppReferenceArray_1_Type_ISurrogateSelector_StreamingContext_ObjectManager_SerObjectInfoInit_IFormatterConverter_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ReadObjectInfo>(intPtr3) : null;
		}

		// Token: 0x06003520 RID: 13600 RVA: 0x00107FE4 File Offset: 0x001061E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1388717, XrefRangeEnd = 1388725, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Init(Type objectType, Il2CppStringArray memberNames, Il2CppReferenceArray<Type> memberTypes, ISurrogateSelector surrogateSelector, StreamingContext context, ObjectManager objectManager, SerObjectInfoInit serObjectInfoInit, IFormatterConverter converter, bool bSimpleAssembly)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(objectType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(memberNames);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(memberTypes);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(surrogateSelector);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(objectManager);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(serObjectInfoInit);
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(converter);
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bSimpleAssembly;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadObjectInfo.NativeMethodInfoPtr_Init_Internal_Void_Type_Il2CppStringArray_Il2CppReferenceArray_1_Type_ISurrogateSelector_StreamingContext_ObjectManager_SerObjectInfoInit_IFormatterConverter_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003521 RID: 13601 RVA: 0x001080C0 File Offset: 0x001062C0
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1388746, RefRangeEnd = 1388752, XrefRangeStart = 1388725, XrefRangeEnd = 1388746, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitReadConstructor(Type objectType, ISurrogateSelector surrogateSelector, StreamingContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(objectType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(surrogateSelector);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadObjectInfo.NativeMethodInfoPtr_InitReadConstructor_Private_Void_Type_ISurrogateSelector_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003522 RID: 13602 RVA: 0x0010812C File Offset: 0x0010632C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1388752, XrefRangeEnd = 1388759, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitSiRead()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadObjectInfo.NativeMethodInfoPtr_InitSiRead_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003523 RID: 13603 RVA: 0x00108160 File Offset: 0x00106360
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1388759, XrefRangeEnd = 1388764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitNoMembers()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadObjectInfo.NativeMethodInfoPtr_InitNoMembers_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003524 RID: 13604 RVA: 0x00108194 File Offset: 0x00106394
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1388786, RefRangeEnd = 1388787, XrefRangeStart = 1388764, XrefRangeEnd = 1388786, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitMemberInfo()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadObjectInfo.NativeMethodInfoPtr_InitMemberInfo_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003525 RID: 13605 RVA: 0x001081C8 File Offset: 0x001063C8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1388788, RefRangeEnd = 1388791, XrefRangeStart = 1388787, XrefRangeEnd = 1388788, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MemberInfo GetMemberInfo(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadObjectInfo.NativeMethodInfoPtr_GetMemberInfo_Internal_MemberInfo_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MemberInfo>(intPtr3) : null;
			}
		}

		// Token: 0x06003526 RID: 13606 RVA: 0x00108218 File Offset: 0x00106418
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1388797, RefRangeEnd = 1388798, XrefRangeStart = 1388791, XrefRangeEnd = 1388797, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Type GetType(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadObjectInfo.NativeMethodInfoPtr_GetType_Internal_Type_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x06003527 RID: 13607 RVA: 0x00108268 File Offset: 0x00106468
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1388801, RefRangeEnd = 1388802, XrefRangeStart = 1388798, XrefRangeEnd = 1388801, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddValue(string name, Object value, ref SerializationInfo si, ref Il2CppReferenceArray<Object> memberData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(si);
			ptr2 = &intPtr;
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = IL2CPP.Il2CppObjectBaseToPtr(memberData);
			ptr3 = &intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(ReadObjectInfo.NativeMethodInfoPtr_AddValue_Internal_Void_String_Object_byref_SerializationInfo_byref_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			IntPtr intPtr5 = intPtr;
			si = ((intPtr5 == 0) ? null : new SerializationInfo(intPtr5));
			IntPtr intPtr6 = intPtr2;
			memberData = ((intPtr6 == 0) ? null : new Il2CppReferenceArray<Object>(intPtr6));
		}

		// Token: 0x06003528 RID: 13608 RVA: 0x00108310 File Offset: 0x00106510
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1388811, RefRangeEnd = 1388812, XrefRangeStart = 1388802, XrefRangeEnd = 1388811, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitDataStore(ref SerializationInfo si, ref Il2CppReferenceArray<Object> memberData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = IL2CPP.Il2CppObjectBaseToPtr(si);
				ptr2 = &intPtr;
			}
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = IL2CPP.Il2CppObjectBaseToPtr(memberData);
			ptr3 = &intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(ReadObjectInfo.NativeMethodInfoPtr_InitDataStore_Internal_Void_byref_SerializationInfo_byref_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			IntPtr intPtr5 = intPtr;
			si = ((intPtr5 == 0) ? null : new SerializationInfo(intPtr5));
			IntPtr intPtr6 = intPtr2;
			memberData = ((intPtr6 == 0) ? null : new Il2CppReferenceArray<Object>(intPtr6));
		}

		// Token: 0x06003529 RID: 13609 RVA: 0x00108390 File Offset: 0x00106590
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1388812, XrefRangeEnd = 1388813, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RecordFixup(long objectId, string name, long idRef)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref objectId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref idRef;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadObjectInfo.NativeMethodInfoPtr_RecordFixup_Internal_Void_Int64_String_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600352A RID: 13610 RVA: 0x001083F0 File Offset: 0x001065F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1388813, XrefRangeEnd = 1388817, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PopulateObjectMembers(Object obj, Il2CppReferenceArray<Object> memberData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(memberData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadObjectInfo.NativeMethodInfoPtr_PopulateObjectMembers_Internal_Void_Object_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600352B RID: 13611 RVA: 0x00108444 File Offset: 0x00106644
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1388819, RefRangeEnd = 1388823, XrefRangeStart = 1388817, XrefRangeEnd = 1388819, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int Position(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadObjectInfo.NativeMethodInfoPtr_Position_Private_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600352C RID: 13612 RVA: 0x00108494 File Offset: 0x00106694
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1388847, RefRangeEnd = 1388849, XrefRangeStart = 1388823, XrefRangeEnd = 1388847, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppReferenceArray<Type> GetMemberTypes(Il2CppStringArray inMemberNames, Type objectType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(inMemberNames);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(objectType);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadObjectInfo.NativeMethodInfoPtr_GetMemberTypes_Internal_Il2CppReferenceArray_1_Type_Il2CppStringArray_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Type>>(intPtr3) : null;
		}

		// Token: 0x0600352D RID: 13613 RVA: 0x001084F8 File Offset: 0x001066F8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1388852, RefRangeEnd = 1388854, XrefRangeStart = 1388849, XrefRangeEnd = 1388852, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Type GetMemberType(MemberInfo objMember)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(objMember);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadObjectInfo.NativeMethodInfoPtr_GetMemberType_Internal_Type_MemberInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x0600352E RID: 13614 RVA: 0x00108548 File Offset: 0x00106748
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1388854, XrefRangeEnd = 1388860, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ReadObjectInfo GetObjectInfo(SerObjectInfoInit serObjectInfoInit)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(serObjectInfoInit);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadObjectInfo.NativeMethodInfoPtr_GetObjectInfo_Private_Static_ReadObjectInfo_SerObjectInfoInit_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ReadObjectInfo>(intPtr3) : null;
			}
		}

		// Token: 0x0600352F RID: 13615 RVA: 0x00012DDC File Offset: 0x00010FDC
		public ReadObjectInfo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000C41 RID: 3137
		// (get) Token: 0x06003530 RID: 13616 RVA: 0x0010858C File Offset: 0x0010678C
		// (set) Token: 0x06003531 RID: 13617 RVA: 0x00012DE5 File Offset: 0x00010FE5
		public unsafe int objectInfoId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReadObjectInfo.NativeFieldInfoPtr_objectInfoId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReadObjectInfo.NativeFieldInfoPtr_objectInfoId)) = value;
			}
		}

		// Token: 0x17000C42 RID: 3138
		// (get) Token: 0x06003532 RID: 13618 RVA: 0x001085B4 File Offset: 0x001067B4
		// (set) Token: 0x06003533 RID: 13619 RVA: 0x00012E00 File Offset: 0x00011000
		public unsafe static int readObjectInfoCounter
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ReadObjectInfo.NativeFieldInfoPtr_readObjectInfoCounter, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ReadObjectInfo.NativeFieldInfoPtr_readObjectInfoCounter, (void*)(&value));
			}
		}

		// Token: 0x17000C43 RID: 3139
		// (get) Token: 0x06003534 RID: 13620 RVA: 0x001085D0 File Offset: 0x001067D0
		// (set) Token: 0x06003535 RID: 13621 RVA: 0x00012E0E File Offset: 0x0001100E
		public unsafe Type objectType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReadObjectInfo.NativeFieldInfoPtr_objectType);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReadObjectInfo.NativeFieldInfoPtr_objectType), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C44 RID: 3140
		// (get) Token: 0x06003536 RID: 13622 RVA: 0x00108600 File Offset: 0x00106800
		// (set) Token: 0x06003537 RID: 13623 RVA: 0x00012E2D File Offset: 0x0001102D
		public unsafe ObjectManager objectManager
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReadObjectInfo.NativeFieldInfoPtr_objectManager);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectManager>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReadObjectInfo.NativeFieldInfoPtr_objectManager), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C45 RID: 3141
		// (get) Token: 0x06003538 RID: 13624 RVA: 0x00108630 File Offset: 0x00106830
		// (set) Token: 0x06003539 RID: 13625 RVA: 0x00012E4C File Offset: 0x0001104C
		public unsafe int count
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReadObjectInfo.NativeFieldInfoPtr_count);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReadObjectInfo.NativeFieldInfoPtr_count)) = value;
			}
		}

		// Token: 0x17000C46 RID: 3142
		// (get) Token: 0x0600353A RID: 13626 RVA: 0x00108658 File Offset: 0x00106858
		// (set) Token: 0x0600353B RID: 13627 RVA: 0x00012E67 File Offset: 0x00011067
		public unsafe bool isSi
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReadObjectInfo.NativeFieldInfoPtr_isSi);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReadObjectInfo.NativeFieldInfoPtr_isSi)) = value;
			}
		}

		// Token: 0x17000C47 RID: 3143
		// (get) Token: 0x0600353C RID: 13628 RVA: 0x00108680 File Offset: 0x00106880
		// (set) Token: 0x0600353D RID: 13629 RVA: 0x00012E82 File Offset: 0x00011082
		public unsafe bool isNamed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReadObjectInfo.NativeFieldInfoPtr_isNamed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReadObjectInfo.NativeFieldInfoPtr_isNamed)) = value;
			}
		}

		// Token: 0x17000C48 RID: 3144
		// (get) Token: 0x0600353E RID: 13630 RVA: 0x001086A8 File Offset: 0x001068A8
		// (set) Token: 0x0600353F RID: 13631 RVA: 0x00012E9D File Offset: 0x0001109D
		public unsafe bool isTyped
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReadObjectInfo.NativeFieldInfoPtr_isTyped);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReadObjectInfo.NativeFieldInfoPtr_isTyped)) = value;
			}
		}

		// Token: 0x17000C49 RID: 3145
		// (get) Token: 0x06003540 RID: 13632 RVA: 0x001086D0 File Offset: 0x001068D0
		// (set) Token: 0x06003541 RID: 13633 RVA: 0x00012EB8 File Offset: 0x000110B8
		public unsafe bool bSimpleAssembly
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReadObjectInfo.NativeFieldInfoPtr_bSimpleAssembly);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReadObjectInfo.NativeFieldInfoPtr_bSimpleAssembly)) = value;
			}
		}

		// Token: 0x17000C4A RID: 3146
		// (get) Token: 0x06003542 RID: 13634 RVA: 0x001086F8 File Offset: 0x001068F8
		// (set) Token: 0x06003543 RID: 13635 RVA: 0x00012ED3 File Offset: 0x000110D3
		public unsafe SerObjectInfoCache cache
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReadObjectInfo.NativeFieldInfoPtr_cache);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SerObjectInfoCache>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReadObjectInfo.NativeFieldInfoPtr_cache), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C4B RID: 3147
		// (get) Token: 0x06003544 RID: 13636 RVA: 0x00108728 File Offset: 0x00106928
		// (set) Token: 0x06003545 RID: 13637 RVA: 0x00012EF2 File Offset: 0x000110F2
		public unsafe Il2CppStringArray wireMemberNames
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReadObjectInfo.NativeFieldInfoPtr_wireMemberNames);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReadObjectInfo.NativeFieldInfoPtr_wireMemberNames), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C4C RID: 3148
		// (get) Token: 0x06003546 RID: 13638 RVA: 0x00108758 File Offset: 0x00106958
		// (set) Token: 0x06003547 RID: 13639 RVA: 0x00012F11 File Offset: 0x00011111
		public unsafe Il2CppReferenceArray<Type> wireMemberTypes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReadObjectInfo.NativeFieldInfoPtr_wireMemberTypes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Type>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReadObjectInfo.NativeFieldInfoPtr_wireMemberTypes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C4D RID: 3149
		// (get) Token: 0x06003548 RID: 13640 RVA: 0x00108788 File Offset: 0x00106988
		// (set) Token: 0x06003549 RID: 13641 RVA: 0x00012F30 File Offset: 0x00011130
		public unsafe int lastPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReadObjectInfo.NativeFieldInfoPtr_lastPosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReadObjectInfo.NativeFieldInfoPtr_lastPosition)) = value;
			}
		}

		// Token: 0x17000C4E RID: 3150
		// (get) Token: 0x0600354A RID: 13642 RVA: 0x001087B0 File Offset: 0x001069B0
		// (set) Token: 0x0600354B RID: 13643 RVA: 0x00012F4B File Offset: 0x0001114B
		public unsafe ISerializationSurrogate serializationSurrogate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReadObjectInfo.NativeFieldInfoPtr_serializationSurrogate);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ISerializationSurrogate>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReadObjectInfo.NativeFieldInfoPtr_serializationSurrogate), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C4F RID: 3151
		// (get) Token: 0x0600354C RID: 13644 RVA: 0x001087E0 File Offset: 0x001069E0
		// (set) Token: 0x0600354D RID: 13645 RVA: 0x00012F6A File Offset: 0x0001116A
		public StreamingContext context
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReadObjectInfo.NativeFieldInfoPtr_context);
				return new StreamingContext(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<StreamingContext>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReadObjectInfo.NativeFieldInfoPtr_context), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<StreamingContext>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000C50 RID: 3152
		// (get) Token: 0x0600354E RID: 13646 RVA: 0x00108810 File Offset: 0x00106A10
		// (set) Token: 0x0600354F RID: 13647 RVA: 0x00012F98 File Offset: 0x00011198
		public unsafe List<Type> memberTypesList
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReadObjectInfo.NativeFieldInfoPtr_memberTypesList);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Type>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReadObjectInfo.NativeFieldInfoPtr_memberTypesList), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C51 RID: 3153
		// (get) Token: 0x06003550 RID: 13648 RVA: 0x00108840 File Offset: 0x00106A40
		// (set) Token: 0x06003551 RID: 13649 RVA: 0x00012FB7 File Offset: 0x000111B7
		public unsafe SerObjectInfoInit serObjectInfoInit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReadObjectInfo.NativeFieldInfoPtr_serObjectInfoInit);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SerObjectInfoInit>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReadObjectInfo.NativeFieldInfoPtr_serObjectInfoInit), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C52 RID: 3154
		// (get) Token: 0x06003552 RID: 13650 RVA: 0x00108870 File Offset: 0x00106A70
		// (set) Token: 0x06003553 RID: 13651 RVA: 0x00012FD6 File Offset: 0x000111D6
		public unsafe IFormatterConverter formatterConverter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReadObjectInfo.NativeFieldInfoPtr_formatterConverter);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IFormatterConverter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReadObjectInfo.NativeFieldInfoPtr_formatterConverter), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002B7D RID: 11133
		private static readonly IntPtr NativeFieldInfoPtr_objectInfoId;

		// Token: 0x04002B7E RID: 11134
		private static readonly IntPtr NativeFieldInfoPtr_readObjectInfoCounter;

		// Token: 0x04002B7F RID: 11135
		private static readonly IntPtr NativeFieldInfoPtr_objectType;

		// Token: 0x04002B80 RID: 11136
		private static readonly IntPtr NativeFieldInfoPtr_objectManager;

		// Token: 0x04002B81 RID: 11137
		private static readonly IntPtr NativeFieldInfoPtr_count;

		// Token: 0x04002B82 RID: 11138
		private static readonly IntPtr NativeFieldInfoPtr_isSi;

		// Token: 0x04002B83 RID: 11139
		private static readonly IntPtr NativeFieldInfoPtr_isNamed;

		// Token: 0x04002B84 RID: 11140
		private static readonly IntPtr NativeFieldInfoPtr_isTyped;

		// Token: 0x04002B85 RID: 11141
		private static readonly IntPtr NativeFieldInfoPtr_bSimpleAssembly;

		// Token: 0x04002B86 RID: 11142
		private static readonly IntPtr NativeFieldInfoPtr_cache;

		// Token: 0x04002B87 RID: 11143
		private static readonly IntPtr NativeFieldInfoPtr_wireMemberNames;

		// Token: 0x04002B88 RID: 11144
		private static readonly IntPtr NativeFieldInfoPtr_wireMemberTypes;

		// Token: 0x04002B89 RID: 11145
		private static readonly IntPtr NativeFieldInfoPtr_lastPosition;

		// Token: 0x04002B8A RID: 11146
		private static readonly IntPtr NativeFieldInfoPtr_serializationSurrogate;

		// Token: 0x04002B8B RID: 11147
		private static readonly IntPtr NativeFieldInfoPtr_context;

		// Token: 0x04002B8C RID: 11148
		private static readonly IntPtr NativeFieldInfoPtr_memberTypesList;

		// Token: 0x04002B8D RID: 11149
		private static readonly IntPtr NativeFieldInfoPtr_serObjectInfoInit;

		// Token: 0x04002B8E RID: 11150
		private static readonly IntPtr NativeFieldInfoPtr_formatterConverter;

		// Token: 0x04002B8F RID: 11151
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

		// Token: 0x04002B90 RID: 11152
		private static readonly IntPtr NativeMethodInfoPtr_ObjectEnd_Internal_Void_0;

		// Token: 0x04002B91 RID: 11153
		private static readonly IntPtr NativeMethodInfoPtr_PrepareForReuse_Internal_Void_0;

		// Token: 0x04002B92 RID: 11154
		private static readonly IntPtr NativeMethodInfoPtr_Create_Internal_Static_ReadObjectInfo_Type_ISurrogateSelector_StreamingContext_ObjectManager_SerObjectInfoInit_IFormatterConverter_Boolean_0;

		// Token: 0x04002B93 RID: 11155
		private static readonly IntPtr NativeMethodInfoPtr_Init_Internal_Void_Type_ISurrogateSelector_StreamingContext_ObjectManager_SerObjectInfoInit_IFormatterConverter_Boolean_0;

		// Token: 0x04002B94 RID: 11156
		private static readonly IntPtr NativeMethodInfoPtr_Create_Internal_Static_ReadObjectInfo_Type_Il2CppStringArray_Il2CppReferenceArray_1_Type_ISurrogateSelector_StreamingContext_ObjectManager_SerObjectInfoInit_IFormatterConverter_Boolean_0;

		// Token: 0x04002B95 RID: 11157
		private static readonly IntPtr NativeMethodInfoPtr_Init_Internal_Void_Type_Il2CppStringArray_Il2CppReferenceArray_1_Type_ISurrogateSelector_StreamingContext_ObjectManager_SerObjectInfoInit_IFormatterConverter_Boolean_0;

		// Token: 0x04002B96 RID: 11158
		private static readonly IntPtr NativeMethodInfoPtr_InitReadConstructor_Private_Void_Type_ISurrogateSelector_StreamingContext_0;

		// Token: 0x04002B97 RID: 11159
		private static readonly IntPtr NativeMethodInfoPtr_InitSiRead_Private_Void_0;

		// Token: 0x04002B98 RID: 11160
		private static readonly IntPtr NativeMethodInfoPtr_InitNoMembers_Private_Void_0;

		// Token: 0x04002B99 RID: 11161
		private static readonly IntPtr NativeMethodInfoPtr_InitMemberInfo_Private_Void_0;

		// Token: 0x04002B9A RID: 11162
		private static readonly IntPtr NativeMethodInfoPtr_GetMemberInfo_Internal_MemberInfo_String_0;

		// Token: 0x04002B9B RID: 11163
		private static readonly IntPtr NativeMethodInfoPtr_GetType_Internal_Type_String_0;

		// Token: 0x04002B9C RID: 11164
		private static readonly IntPtr NativeMethodInfoPtr_AddValue_Internal_Void_String_Object_byref_SerializationInfo_byref_Il2CppReferenceArray_1_Object_0;

		// Token: 0x04002B9D RID: 11165
		private static readonly IntPtr NativeMethodInfoPtr_InitDataStore_Internal_Void_byref_SerializationInfo_byref_Il2CppReferenceArray_1_Object_0;

		// Token: 0x04002B9E RID: 11166
		private static readonly IntPtr NativeMethodInfoPtr_RecordFixup_Internal_Void_Int64_String_Int64_0;

		// Token: 0x04002B9F RID: 11167
		private static readonly IntPtr NativeMethodInfoPtr_PopulateObjectMembers_Internal_Void_Object_Il2CppReferenceArray_1_Object_0;

		// Token: 0x04002BA0 RID: 11168
		private static readonly IntPtr NativeMethodInfoPtr_Position_Private_Int32_String_0;

		// Token: 0x04002BA1 RID: 11169
		private static readonly IntPtr NativeMethodInfoPtr_GetMemberTypes_Internal_Il2CppReferenceArray_1_Type_Il2CppStringArray_Type_0;

		// Token: 0x04002BA2 RID: 11170
		private static readonly IntPtr NativeMethodInfoPtr_GetMemberType_Internal_Type_MemberInfo_0;

		// Token: 0x04002BA3 RID: 11171
		private static readonly IntPtr NativeMethodInfoPtr_GetObjectInfo_Private_Static_ReadObjectInfo_SerObjectInfoInit_0;
	}
}
