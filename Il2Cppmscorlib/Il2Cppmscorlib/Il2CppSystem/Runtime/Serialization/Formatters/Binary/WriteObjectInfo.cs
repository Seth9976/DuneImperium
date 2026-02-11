using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Reflection;

namespace Il2CppSystem.Runtime.Serialization.Formatters.Binary
{
	// Token: 0x02000366 RID: 870
	public sealed class WriteObjectInfo : Object
	{
		// Token: 0x060034E3 RID: 13539 RVA: 0x00106D6C File Offset: 0x00104F6C
		// Note: this type is marked as 'beforefieldinit'.
		static WriteObjectInfo()
		{
			Il2CppClassPointerStore<WriteObjectInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Serialization.Formatters.Binary", "WriteObjectInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WriteObjectInfo>.NativeClassPtr);
			WriteObjectInfo.NativeFieldInfoPtr_objectInfoId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WriteObjectInfo>.NativeClassPtr, "objectInfoId");
			WriteObjectInfo.NativeFieldInfoPtr_obj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WriteObjectInfo>.NativeClassPtr, "obj");
			WriteObjectInfo.NativeFieldInfoPtr_objectType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WriteObjectInfo>.NativeClassPtr, "objectType");
			WriteObjectInfo.NativeFieldInfoPtr_isSi = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WriteObjectInfo>.NativeClassPtr, "isSi");
			WriteObjectInfo.NativeFieldInfoPtr_isNamed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WriteObjectInfo>.NativeClassPtr, "isNamed");
			WriteObjectInfo.NativeFieldInfoPtr_isTyped = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WriteObjectInfo>.NativeClassPtr, "isTyped");
			WriteObjectInfo.NativeFieldInfoPtr_isArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WriteObjectInfo>.NativeClassPtr, "isArray");
			WriteObjectInfo.NativeFieldInfoPtr_si = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WriteObjectInfo>.NativeClassPtr, "si");
			WriteObjectInfo.NativeFieldInfoPtr_cache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WriteObjectInfo>.NativeClassPtr, "cache");
			WriteObjectInfo.NativeFieldInfoPtr_memberData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WriteObjectInfo>.NativeClassPtr, "memberData");
			WriteObjectInfo.NativeFieldInfoPtr_serializationSurrogate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WriteObjectInfo>.NativeClassPtr, "serializationSurrogate");
			WriteObjectInfo.NativeFieldInfoPtr_context = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WriteObjectInfo>.NativeClassPtr, "context");
			WriteObjectInfo.NativeFieldInfoPtr_serObjectInfoInit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WriteObjectInfo>.NativeClassPtr, "serObjectInfoInit");
			WriteObjectInfo.NativeFieldInfoPtr_objectId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WriteObjectInfo>.NativeClassPtr, "objectId");
			WriteObjectInfo.NativeFieldInfoPtr_assemId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WriteObjectInfo>.NativeClassPtr, "assemId");
			WriteObjectInfo.NativeFieldInfoPtr_binderTypeName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WriteObjectInfo>.NativeClassPtr, "binderTypeName");
			WriteObjectInfo.NativeFieldInfoPtr_binderAssemblyString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WriteObjectInfo>.NativeClassPtr, "binderAssemblyString");
			WriteObjectInfo.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WriteObjectInfo>.NativeClassPtr, 100671396);
			WriteObjectInfo.NativeMethodInfoPtr_ObjectEnd_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WriteObjectInfo>.NativeClassPtr, 100671397);
			WriteObjectInfo.NativeMethodInfoPtr_InternalInit_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WriteObjectInfo>.NativeClassPtr, 100671398);
			WriteObjectInfo.NativeMethodInfoPtr_Serialize_Internal_Static_WriteObjectInfo_Object_ISurrogateSelector_StreamingContext_SerObjectInfoInit_IFormatterConverter_ObjectWriter_SerializationBinder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WriteObjectInfo>.NativeClassPtr, 100671399);
			WriteObjectInfo.NativeMethodInfoPtr_InitSerialize_Internal_Void_Object_ISurrogateSelector_StreamingContext_SerObjectInfoInit_IFormatterConverter_ObjectWriter_SerializationBinder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WriteObjectInfo>.NativeClassPtr, 100671400);
			WriteObjectInfo.NativeMethodInfoPtr_Serialize_Internal_Static_WriteObjectInfo_Type_ISurrogateSelector_StreamingContext_SerObjectInfoInit_IFormatterConverter_SerializationBinder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WriteObjectInfo>.NativeClassPtr, 100671401);
			WriteObjectInfo.NativeMethodInfoPtr_InitSerialize_Internal_Void_Type_ISurrogateSelector_StreamingContext_SerObjectInfoInit_IFormatterConverter_SerializationBinder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WriteObjectInfo>.NativeClassPtr, 100671402);
			WriteObjectInfo.NativeMethodInfoPtr_InitSiWrite_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WriteObjectInfo>.NativeClassPtr, 100671403);
			WriteObjectInfo.NativeMethodInfoPtr_CheckTypeForwardedFrom_Private_Static_Void_SerObjectInfoCache_Type_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WriteObjectInfo>.NativeClassPtr, 100671404);
			WriteObjectInfo.NativeMethodInfoPtr_InitNoMembers_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WriteObjectInfo>.NativeClassPtr, 100671405);
			WriteObjectInfo.NativeMethodInfoPtr_InitMemberInfo_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WriteObjectInfo>.NativeClassPtr, 100671406);
			WriteObjectInfo.NativeMethodInfoPtr_GetTypeFullName_Internal_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WriteObjectInfo>.NativeClassPtr, 100671407);
			WriteObjectInfo.NativeMethodInfoPtr_GetAssemblyString_Internal_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WriteObjectInfo>.NativeClassPtr, 100671408);
			WriteObjectInfo.NativeMethodInfoPtr_InvokeSerializationBinder_Private_Void_SerializationBinder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WriteObjectInfo>.NativeClassPtr, 100671409);
			WriteObjectInfo.NativeMethodInfoPtr_GetMemberType_Internal_Type_MemberInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WriteObjectInfo>.NativeClassPtr, 100671410);
			WriteObjectInfo.NativeMethodInfoPtr_GetMemberInfo_Internal_Void_byref_Il2CppStringArray_byref_Il2CppReferenceArray_1_Type_byref_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WriteObjectInfo>.NativeClassPtr, 100671411);
			WriteObjectInfo.NativeMethodInfoPtr_GetObjectInfo_Private_Static_WriteObjectInfo_SerObjectInfoInit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WriteObjectInfo>.NativeClassPtr, 100671412);
			WriteObjectInfo.NativeMethodInfoPtr_PutObjectInfo_Private_Static_Void_SerObjectInfoInit_WriteObjectInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WriteObjectInfo>.NativeClassPtr, 100671413);
		}

		// Token: 0x060034E4 RID: 13540 RVA: 0x00107058 File Offset: 0x00105258
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WriteObjectInfo()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WriteObjectInfo>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WriteObjectInfo.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060034E5 RID: 13541 RVA: 0x00107094 File Offset: 0x00105294
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1388479, RefRangeEnd = 1388481, XrefRangeStart = 1388477, XrefRangeEnd = 1388479, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ObjectEnd()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WriteObjectInfo.NativeMethodInfoPtr_ObjectEnd_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060034E6 RID: 13542 RVA: 0x001070C8 File Offset: 0x001052C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1388481, XrefRangeEnd = 1388488, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InternalInit()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WriteObjectInfo.NativeMethodInfoPtr_InternalInit_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060034E7 RID: 13543 RVA: 0x001070FC File Offset: 0x001052FC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1388490, RefRangeEnd = 1388492, XrefRangeStart = 1388488, XrefRangeEnd = 1388490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static WriteObjectInfo Serialize(Object obj, ISurrogateSelector surrogateSelector, StreamingContext context, SerObjectInfoInit serObjectInfoInit, IFormatterConverter converter, ObjectWriter objectWriter, SerializationBinder binder)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(surrogateSelector);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(serObjectInfoInit);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(converter);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(objectWriter);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(binder);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WriteObjectInfo.NativeMethodInfoPtr_Serialize_Internal_Static_WriteObjectInfo_Object_ISurrogateSelector_StreamingContext_SerObjectInfoInit_IFormatterConverter_ObjectWriter_SerializationBinder_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<WriteObjectInfo>(intPtr3) : null;
		}

		// Token: 0x060034E8 RID: 13544 RVA: 0x001071B4 File Offset: 0x001053B4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1388515, RefRangeEnd = 1388516, XrefRangeStart = 1388492, XrefRangeEnd = 1388515, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitSerialize(Object obj, ISurrogateSelector surrogateSelector, StreamingContext context, SerObjectInfoInit serObjectInfoInit, IFormatterConverter converter, ObjectWriter objectWriter, SerializationBinder binder)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(surrogateSelector);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(serObjectInfoInit);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(converter);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(objectWriter);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(binder);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WriteObjectInfo.NativeMethodInfoPtr_InitSerialize_Internal_Void_Object_ISurrogateSelector_StreamingContext_SerObjectInfoInit_IFormatterConverter_ObjectWriter_SerializationBinder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060034E9 RID: 13545 RVA: 0x0010726C File Offset: 0x0010546C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1388518, RefRangeEnd = 1388520, XrefRangeStart = 1388516, XrefRangeEnd = 1388518, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static WriteObjectInfo Serialize(Type objectType, ISurrogateSelector surrogateSelector, StreamingContext context, SerObjectInfoInit serObjectInfoInit, IFormatterConverter converter, SerializationBinder binder)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(objectType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(surrogateSelector);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(serObjectInfoInit);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(converter);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(binder);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WriteObjectInfo.NativeMethodInfoPtr_Serialize_Internal_Static_WriteObjectInfo_Type_ISurrogateSelector_StreamingContext_SerObjectInfoInit_IFormatterConverter_SerializationBinder_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<WriteObjectInfo>(intPtr3) : null;
		}

		// Token: 0x060034EA RID: 13546 RVA: 0x00107314 File Offset: 0x00105514
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1388573, RefRangeEnd = 1388574, XrefRangeStart = 1388520, XrefRangeEnd = 1388573, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitSerialize(Type objectType, ISurrogateSelector surrogateSelector, StreamingContext context, SerObjectInfoInit serObjectInfoInit, IFormatterConverter converter, SerializationBinder binder)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(objectType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(surrogateSelector);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(serObjectInfoInit);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(converter);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(binder);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WriteObjectInfo.NativeMethodInfoPtr_InitSerialize_Internal_Void_Type_ISurrogateSelector_StreamingContext_SerObjectInfoInit_IFormatterConverter_SerializationBinder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060034EB RID: 13547 RVA: 0x001073B8 File Offset: 0x001055B8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1388612, RefRangeEnd = 1388613, XrefRangeStart = 1388574, XrefRangeEnd = 1388612, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitSiWrite()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WriteObjectInfo.NativeMethodInfoPtr_InitSiWrite_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060034EC RID: 13548 RVA: 0x001073EC File Offset: 0x001055EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1388613, XrefRangeEnd = 1388619, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CheckTypeForwardedFrom(SerObjectInfoCache cache, Type objectType, string binderAssemblyString)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cache);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(objectType);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(binderAssemblyString);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WriteObjectInfo.NativeMethodInfoPtr_CheckTypeForwardedFrom_Private_Static_Void_SerObjectInfoCache_Type_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060034ED RID: 13549 RVA: 0x00107448 File Offset: 0x00105648
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1388628, RefRangeEnd = 1388629, XrefRangeStart = 1388619, XrefRangeEnd = 1388628, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitNoMembers()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WriteObjectInfo.NativeMethodInfoPtr_InitNoMembers_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060034EE RID: 13550 RVA: 0x0010747C File Offset: 0x0010567C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1388659, RefRangeEnd = 1388660, XrefRangeStart = 1388629, XrefRangeEnd = 1388659, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitMemberInfo()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WriteObjectInfo.NativeMethodInfoPtr_InitMemberInfo_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060034EF RID: 13551 RVA: 0x001074B0 File Offset: 0x001056B0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1388660, RefRangeEnd = 1388664, XrefRangeStart = 1388660, XrefRangeEnd = 1388660, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetTypeFullName()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WriteObjectInfo.NativeMethodInfoPtr_GetTypeFullName_Internal_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060034F0 RID: 13552 RVA: 0x001074E8 File Offset: 0x001056E8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1388664, RefRangeEnd = 1388665, XrefRangeStart = 1388664, XrefRangeEnd = 1388664, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetAssemblyString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WriteObjectInfo.NativeMethodInfoPtr_GetAssemblyString_Internal_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060034F1 RID: 13553 RVA: 0x00107520 File Offset: 0x00105720
		[CallerCount(0)]
		public unsafe void InvokeSerializationBinder(SerializationBinder binder)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(binder);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WriteObjectInfo.NativeMethodInfoPtr_InvokeSerializationBinder_Private_Void_SerializationBinder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060034F2 RID: 13554 RVA: 0x00107564 File Offset: 0x00105764
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1388668, RefRangeEnd = 1388669, XrefRangeStart = 1388665, XrefRangeEnd = 1388668, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Type GetMemberType(MemberInfo objMember)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(objMember);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WriteObjectInfo.NativeMethodInfoPtr_GetMemberType_Internal_Type_MemberInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x060034F3 RID: 13555 RVA: 0x001075B4 File Offset: 0x001057B4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1388672, RefRangeEnd = 1388673, XrefRangeStart = 1388669, XrefRangeEnd = 1388672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetMemberInfo(out Il2CppStringArray outMemberNames, out Il2CppReferenceArray<Type> outMemberTypes, out Il2CppReferenceArray<Object> outMemberData)
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
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = 0;
			ptr3 = &intPtr2;
			ref IntPtr ptr4 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr3 = 0;
			ptr4 = &intPtr3;
			IntPtr intPtr5;
			IntPtr intPtr4 = IL2CPP.il2cpp_runtime_invoke(WriteObjectInfo.NativeMethodInfoPtr_GetMemberInfo_Internal_Void_byref_Il2CppStringArray_byref_Il2CppReferenceArray_1_Type_byref_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr5);
			Il2CppException.RaiseExceptionIfNecessary(intPtr5);
			IntPtr intPtr6 = intPtr;
			outMemberNames = ((intPtr6 == 0) ? null : new Il2CppStringArray(intPtr6));
			IntPtr intPtr7 = intPtr2;
			outMemberTypes = ((intPtr7 == 0) ? null : new Il2CppReferenceArray<Type>(intPtr7));
			IntPtr intPtr8 = intPtr3;
			outMemberData = ((intPtr8 == 0) ? null : new Il2CppReferenceArray<Object>(intPtr8));
		}

		// Token: 0x060034F4 RID: 13556 RVA: 0x0010764C File Offset: 0x0010584C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1388678, RefRangeEnd = 1388680, XrefRangeStart = 1388673, XrefRangeEnd = 1388678, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static WriteObjectInfo GetObjectInfo(SerObjectInfoInit serObjectInfoInit)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(serObjectInfoInit);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WriteObjectInfo.NativeMethodInfoPtr_GetObjectInfo_Private_Static_WriteObjectInfo_SerObjectInfoInit_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<WriteObjectInfo>(intPtr3) : null;
			}
		}

		// Token: 0x060034F5 RID: 13557 RVA: 0x00107690 File Offset: 0x00105890
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1388680, XrefRangeEnd = 1388682, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void PutObjectInfo(SerObjectInfoInit serObjectInfoInit, WriteObjectInfo objectInfo)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(serObjectInfoInit);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(objectInfo);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WriteObjectInfo.NativeMethodInfoPtr_PutObjectInfo_Private_Static_Void_SerObjectInfoInit_WriteObjectInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060034F6 RID: 13558 RVA: 0x00012BD1 File Offset: 0x00010DD1
		public WriteObjectInfo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000C30 RID: 3120
		// (get) Token: 0x060034F7 RID: 13559 RVA: 0x001076D8 File Offset: 0x001058D8
		// (set) Token: 0x060034F8 RID: 13560 RVA: 0x00012BDA File Offset: 0x00010DDA
		public unsafe int objectInfoId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WriteObjectInfo.NativeFieldInfoPtr_objectInfoId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WriteObjectInfo.NativeFieldInfoPtr_objectInfoId)) = value;
			}
		}

		// Token: 0x17000C31 RID: 3121
		// (get) Token: 0x060034F9 RID: 13561 RVA: 0x00107700 File Offset: 0x00105900
		// (set) Token: 0x060034FA RID: 13562 RVA: 0x00012BF5 File Offset: 0x00010DF5
		public unsafe Object obj
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WriteObjectInfo.NativeFieldInfoPtr_obj);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WriteObjectInfo.NativeFieldInfoPtr_obj), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C32 RID: 3122
		// (get) Token: 0x060034FB RID: 13563 RVA: 0x00107730 File Offset: 0x00105930
		// (set) Token: 0x060034FC RID: 13564 RVA: 0x00012C14 File Offset: 0x00010E14
		public unsafe Type objectType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WriteObjectInfo.NativeFieldInfoPtr_objectType);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WriteObjectInfo.NativeFieldInfoPtr_objectType), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C33 RID: 3123
		// (get) Token: 0x060034FD RID: 13565 RVA: 0x00107760 File Offset: 0x00105960
		// (set) Token: 0x060034FE RID: 13566 RVA: 0x00012C33 File Offset: 0x00010E33
		public unsafe bool isSi
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WriteObjectInfo.NativeFieldInfoPtr_isSi);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WriteObjectInfo.NativeFieldInfoPtr_isSi)) = value;
			}
		}

		// Token: 0x17000C34 RID: 3124
		// (get) Token: 0x060034FF RID: 13567 RVA: 0x00107788 File Offset: 0x00105988
		// (set) Token: 0x06003500 RID: 13568 RVA: 0x00012C4E File Offset: 0x00010E4E
		public unsafe bool isNamed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WriteObjectInfo.NativeFieldInfoPtr_isNamed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WriteObjectInfo.NativeFieldInfoPtr_isNamed)) = value;
			}
		}

		// Token: 0x17000C35 RID: 3125
		// (get) Token: 0x06003501 RID: 13569 RVA: 0x001077B0 File Offset: 0x001059B0
		// (set) Token: 0x06003502 RID: 13570 RVA: 0x00012C69 File Offset: 0x00010E69
		public unsafe bool isTyped
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WriteObjectInfo.NativeFieldInfoPtr_isTyped);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WriteObjectInfo.NativeFieldInfoPtr_isTyped)) = value;
			}
		}

		// Token: 0x17000C36 RID: 3126
		// (get) Token: 0x06003503 RID: 13571 RVA: 0x001077D8 File Offset: 0x001059D8
		// (set) Token: 0x06003504 RID: 13572 RVA: 0x00012C84 File Offset: 0x00010E84
		public unsafe bool isArray
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WriteObjectInfo.NativeFieldInfoPtr_isArray);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WriteObjectInfo.NativeFieldInfoPtr_isArray)) = value;
			}
		}

		// Token: 0x17000C37 RID: 3127
		// (get) Token: 0x06003505 RID: 13573 RVA: 0x00107800 File Offset: 0x00105A00
		// (set) Token: 0x06003506 RID: 13574 RVA: 0x00012C9F File Offset: 0x00010E9F
		public unsafe SerializationInfo si
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WriteObjectInfo.NativeFieldInfoPtr_si);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SerializationInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WriteObjectInfo.NativeFieldInfoPtr_si), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C38 RID: 3128
		// (get) Token: 0x06003507 RID: 13575 RVA: 0x00107830 File Offset: 0x00105A30
		// (set) Token: 0x06003508 RID: 13576 RVA: 0x00012CBE File Offset: 0x00010EBE
		public unsafe SerObjectInfoCache cache
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WriteObjectInfo.NativeFieldInfoPtr_cache);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SerObjectInfoCache>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WriteObjectInfo.NativeFieldInfoPtr_cache), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C39 RID: 3129
		// (get) Token: 0x06003509 RID: 13577 RVA: 0x00107860 File Offset: 0x00105A60
		// (set) Token: 0x0600350A RID: 13578 RVA: 0x00012CDD File Offset: 0x00010EDD
		public unsafe Il2CppReferenceArray<Object> memberData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WriteObjectInfo.NativeFieldInfoPtr_memberData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WriteObjectInfo.NativeFieldInfoPtr_memberData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C3A RID: 3130
		// (get) Token: 0x0600350B RID: 13579 RVA: 0x00107890 File Offset: 0x00105A90
		// (set) Token: 0x0600350C RID: 13580 RVA: 0x00012CFC File Offset: 0x00010EFC
		public unsafe ISerializationSurrogate serializationSurrogate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WriteObjectInfo.NativeFieldInfoPtr_serializationSurrogate);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ISerializationSurrogate>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WriteObjectInfo.NativeFieldInfoPtr_serializationSurrogate), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C3B RID: 3131
		// (get) Token: 0x0600350D RID: 13581 RVA: 0x001078C0 File Offset: 0x00105AC0
		// (set) Token: 0x0600350E RID: 13582 RVA: 0x00012D1B File Offset: 0x00010F1B
		public StreamingContext context
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WriteObjectInfo.NativeFieldInfoPtr_context);
				return new StreamingContext(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<StreamingContext>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WriteObjectInfo.NativeFieldInfoPtr_context), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<StreamingContext>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000C3C RID: 3132
		// (get) Token: 0x0600350F RID: 13583 RVA: 0x001078F0 File Offset: 0x00105AF0
		// (set) Token: 0x06003510 RID: 13584 RVA: 0x00012D49 File Offset: 0x00010F49
		public unsafe SerObjectInfoInit serObjectInfoInit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WriteObjectInfo.NativeFieldInfoPtr_serObjectInfoInit);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SerObjectInfoInit>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WriteObjectInfo.NativeFieldInfoPtr_serObjectInfoInit), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C3D RID: 3133
		// (get) Token: 0x06003511 RID: 13585 RVA: 0x00107920 File Offset: 0x00105B20
		// (set) Token: 0x06003512 RID: 13586 RVA: 0x00012D68 File Offset: 0x00010F68
		public unsafe long objectId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WriteObjectInfo.NativeFieldInfoPtr_objectId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WriteObjectInfo.NativeFieldInfoPtr_objectId)) = value;
			}
		}

		// Token: 0x17000C3E RID: 3134
		// (get) Token: 0x06003513 RID: 13587 RVA: 0x00107948 File Offset: 0x00105B48
		// (set) Token: 0x06003514 RID: 13588 RVA: 0x00012D83 File Offset: 0x00010F83
		public unsafe long assemId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WriteObjectInfo.NativeFieldInfoPtr_assemId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WriteObjectInfo.NativeFieldInfoPtr_assemId)) = value;
			}
		}

		// Token: 0x17000C3F RID: 3135
		// (get) Token: 0x06003515 RID: 13589 RVA: 0x00107970 File Offset: 0x00105B70
		// (set) Token: 0x06003516 RID: 13590 RVA: 0x00012D9E File Offset: 0x00010F9E
		public unsafe string binderTypeName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WriteObjectInfo.NativeFieldInfoPtr_binderTypeName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WriteObjectInfo.NativeFieldInfoPtr_binderTypeName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000C40 RID: 3136
		// (get) Token: 0x06003517 RID: 13591 RVA: 0x00107998 File Offset: 0x00105B98
		// (set) Token: 0x06003518 RID: 13592 RVA: 0x00012DBD File Offset: 0x00010FBD
		public unsafe string binderAssemblyString
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WriteObjectInfo.NativeFieldInfoPtr_binderAssemblyString);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WriteObjectInfo.NativeFieldInfoPtr_binderAssemblyString), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04002B5A RID: 11098
		private static readonly IntPtr NativeFieldInfoPtr_objectInfoId;

		// Token: 0x04002B5B RID: 11099
		private static readonly IntPtr NativeFieldInfoPtr_obj;

		// Token: 0x04002B5C RID: 11100
		private static readonly IntPtr NativeFieldInfoPtr_objectType;

		// Token: 0x04002B5D RID: 11101
		private static readonly IntPtr NativeFieldInfoPtr_isSi;

		// Token: 0x04002B5E RID: 11102
		private static readonly IntPtr NativeFieldInfoPtr_isNamed;

		// Token: 0x04002B5F RID: 11103
		private static readonly IntPtr NativeFieldInfoPtr_isTyped;

		// Token: 0x04002B60 RID: 11104
		private static readonly IntPtr NativeFieldInfoPtr_isArray;

		// Token: 0x04002B61 RID: 11105
		private static readonly IntPtr NativeFieldInfoPtr_si;

		// Token: 0x04002B62 RID: 11106
		private static readonly IntPtr NativeFieldInfoPtr_cache;

		// Token: 0x04002B63 RID: 11107
		private static readonly IntPtr NativeFieldInfoPtr_memberData;

		// Token: 0x04002B64 RID: 11108
		private static readonly IntPtr NativeFieldInfoPtr_serializationSurrogate;

		// Token: 0x04002B65 RID: 11109
		private static readonly IntPtr NativeFieldInfoPtr_context;

		// Token: 0x04002B66 RID: 11110
		private static readonly IntPtr NativeFieldInfoPtr_serObjectInfoInit;

		// Token: 0x04002B67 RID: 11111
		private static readonly IntPtr NativeFieldInfoPtr_objectId;

		// Token: 0x04002B68 RID: 11112
		private static readonly IntPtr NativeFieldInfoPtr_assemId;

		// Token: 0x04002B69 RID: 11113
		private static readonly IntPtr NativeFieldInfoPtr_binderTypeName;

		// Token: 0x04002B6A RID: 11114
		private static readonly IntPtr NativeFieldInfoPtr_binderAssemblyString;

		// Token: 0x04002B6B RID: 11115
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

		// Token: 0x04002B6C RID: 11116
		private static readonly IntPtr NativeMethodInfoPtr_ObjectEnd_Internal_Void_0;

		// Token: 0x04002B6D RID: 11117
		private static readonly IntPtr NativeMethodInfoPtr_InternalInit_Private_Void_0;

		// Token: 0x04002B6E RID: 11118
		private static readonly IntPtr NativeMethodInfoPtr_Serialize_Internal_Static_WriteObjectInfo_Object_ISurrogateSelector_StreamingContext_SerObjectInfoInit_IFormatterConverter_ObjectWriter_SerializationBinder_0;

		// Token: 0x04002B6F RID: 11119
		private static readonly IntPtr NativeMethodInfoPtr_InitSerialize_Internal_Void_Object_ISurrogateSelector_StreamingContext_SerObjectInfoInit_IFormatterConverter_ObjectWriter_SerializationBinder_0;

		// Token: 0x04002B70 RID: 11120
		private static readonly IntPtr NativeMethodInfoPtr_Serialize_Internal_Static_WriteObjectInfo_Type_ISurrogateSelector_StreamingContext_SerObjectInfoInit_IFormatterConverter_SerializationBinder_0;

		// Token: 0x04002B71 RID: 11121
		private static readonly IntPtr NativeMethodInfoPtr_InitSerialize_Internal_Void_Type_ISurrogateSelector_StreamingContext_SerObjectInfoInit_IFormatterConverter_SerializationBinder_0;

		// Token: 0x04002B72 RID: 11122
		private static readonly IntPtr NativeMethodInfoPtr_InitSiWrite_Private_Void_0;

		// Token: 0x04002B73 RID: 11123
		private static readonly IntPtr NativeMethodInfoPtr_CheckTypeForwardedFrom_Private_Static_Void_SerObjectInfoCache_Type_String_0;

		// Token: 0x04002B74 RID: 11124
		private static readonly IntPtr NativeMethodInfoPtr_InitNoMembers_Private_Void_0;

		// Token: 0x04002B75 RID: 11125
		private static readonly IntPtr NativeMethodInfoPtr_InitMemberInfo_Private_Void_0;

		// Token: 0x04002B76 RID: 11126
		private static readonly IntPtr NativeMethodInfoPtr_GetTypeFullName_Internal_String_0;

		// Token: 0x04002B77 RID: 11127
		private static readonly IntPtr NativeMethodInfoPtr_GetAssemblyString_Internal_String_0;

		// Token: 0x04002B78 RID: 11128
		private static readonly IntPtr NativeMethodInfoPtr_InvokeSerializationBinder_Private_Void_SerializationBinder_0;

		// Token: 0x04002B79 RID: 11129
		private static readonly IntPtr NativeMethodInfoPtr_GetMemberType_Internal_Type_MemberInfo_0;

		// Token: 0x04002B7A RID: 11130
		private static readonly IntPtr NativeMethodInfoPtr_GetMemberInfo_Internal_Void_byref_Il2CppStringArray_byref_Il2CppReferenceArray_1_Type_byref_Il2CppReferenceArray_1_Object_0;

		// Token: 0x04002B7B RID: 11131
		private static readonly IntPtr NativeMethodInfoPtr_GetObjectInfo_Private_Static_WriteObjectInfo_SerObjectInfoInit_0;

		// Token: 0x04002B7C RID: 11132
		private static readonly IntPtr NativeMethodInfoPtr_PutObjectInfo_Private_Static_Void_SerObjectInfoInit_WriteObjectInfo_0;
	}
}
