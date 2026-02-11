using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Reflection;

namespace Il2CppSystem.Runtime.Serialization
{
	// Token: 0x02000329 RID: 809
	public class ObjectManager : Object
	{
		// Token: 0x06003149 RID: 12617 RVA: 0x000FA664 File Offset: 0x000F8864
		// Note: this type is marked as 'beforefieldinit'.
		static ObjectManager()
		{
			Il2CppClassPointerStore<ObjectManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Serialization", "ObjectManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ObjectManager>.NativeClassPtr);
			ObjectManager.NativeFieldInfoPtr_m_onDeserializationHandler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectManager>.NativeClassPtr, "m_onDeserializationHandler");
			ObjectManager.NativeFieldInfoPtr_m_onDeserializedHandler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectManager>.NativeClassPtr, "m_onDeserializedHandler");
			ObjectManager.NativeFieldInfoPtr_m_objects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectManager>.NativeClassPtr, "m_objects");
			ObjectManager.NativeFieldInfoPtr_m_topObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectManager>.NativeClassPtr, "m_topObject");
			ObjectManager.NativeFieldInfoPtr_m_specialFixupObjects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectManager>.NativeClassPtr, "m_specialFixupObjects");
			ObjectManager.NativeFieldInfoPtr_m_fixupCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectManager>.NativeClassPtr, "m_fixupCount");
			ObjectManager.NativeFieldInfoPtr_m_selector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectManager>.NativeClassPtr, "m_selector");
			ObjectManager.NativeFieldInfoPtr_m_context = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectManager>.NativeClassPtr, "m_context");
			ObjectManager.NativeMethodInfoPtr__ctor_Internal_Void_ISurrogateSelector_StreamingContext_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectManager>.NativeClassPtr, 100671045);
			ObjectManager.NativeMethodInfoPtr_CanCallGetType_Private_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectManager>.NativeClassPtr, 100671046);
			ObjectManager.NativeMethodInfoPtr_set_TopObject_Internal_set_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectManager>.NativeClassPtr, 100671047);
			ObjectManager.NativeMethodInfoPtr_get_TopObject_Internal_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectManager>.NativeClassPtr, 100671048);
			ObjectManager.NativeMethodInfoPtr_get_SpecialFixupObjects_Internal_get_ObjectHolderList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectManager>.NativeClassPtr, 100671049);
			ObjectManager.NativeMethodInfoPtr_FindObjectHolder_Internal_ObjectHolder_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectManager>.NativeClassPtr, 100671050);
			ObjectManager.NativeMethodInfoPtr_FindOrCreateObjectHolder_Internal_ObjectHolder_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectManager>.NativeClassPtr, 100671051);
			ObjectManager.NativeMethodInfoPtr_AddObjectHolder_Private_Void_ObjectHolder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectManager>.NativeClassPtr, 100671052);
			ObjectManager.NativeMethodInfoPtr_GetCompletionInfo_Private_Boolean_FixupHolder_byref_ObjectHolder_byref_Object_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectManager>.NativeClassPtr, 100671053);
			ObjectManager.NativeMethodInfoPtr_FixupSpecialObject_Private_Void_ObjectHolder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectManager>.NativeClassPtr, 100671054);
			ObjectManager.NativeMethodInfoPtr_ResolveObjectReference_Private_Boolean_ObjectHolder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectManager>.NativeClassPtr, 100671055);
			ObjectManager.NativeMethodInfoPtr_DoValueTypeFixup_Private_Boolean_FieldInfo_ObjectHolder_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectManager>.NativeClassPtr, 100671056);
			ObjectManager.NativeMethodInfoPtr_CompleteObject_Internal_Void_ObjectHolder_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectManager>.NativeClassPtr, 100671057);
			ObjectManager.NativeMethodInfoPtr_DoNewlyRegisteredObjectFixups_Private_Void_ObjectHolder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectManager>.NativeClassPtr, 100671058);
			ObjectManager.NativeMethodInfoPtr_GetObject_Public_Virtual_New_Object_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectManager>.NativeClassPtr, 100671059);
			ObjectManager.NativeMethodInfoPtr_RegisterString_Internal_Void_String_Int64_SerializationInfo_Int64_MemberInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectManager>.NativeClassPtr, 100671060);
			ObjectManager.NativeMethodInfoPtr_RegisterObject_Public_Void_Object_Int64_SerializationInfo_Int64_MemberInfo_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectManager>.NativeClassPtr, 100671061);
			ObjectManager.NativeMethodInfoPtr_CompleteISerializableObject_Internal_Void_Object_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectManager>.NativeClassPtr, 100671062);
			ObjectManager.NativeMethodInfoPtr_GetConstructor_Internal_Static_RuntimeConstructorInfo_RuntimeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectManager>.NativeClassPtr, 100671063);
			ObjectManager.NativeMethodInfoPtr_DoFixups_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectManager>.NativeClassPtr, 100671064);
			ObjectManager.NativeMethodInfoPtr_RegisterFixup_Private_Void_FixupHolder_Int64_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectManager>.NativeClassPtr, 100671065);
			ObjectManager.NativeMethodInfoPtr_RecordFixup_Public_Virtual_New_Void_Int64_MemberInfo_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectManager>.NativeClassPtr, 100671066);
			ObjectManager.NativeMethodInfoPtr_RecordDelayedFixup_Public_Virtual_New_Void_Int64_String_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectManager>.NativeClassPtr, 100671067);
			ObjectManager.NativeMethodInfoPtr_RecordArrayElementFixup_Public_Virtual_New_Void_Int64_Il2CppStructArray_1_Int32_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectManager>.NativeClassPtr, 100671068);
			ObjectManager.NativeMethodInfoPtr_RaiseDeserializationEvent_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectManager>.NativeClassPtr, 100671069);
			ObjectManager.NativeMethodInfoPtr_AddOnDeserialization_Internal_Virtual_New_Void_DeserializationEventHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectManager>.NativeClassPtr, 100671070);
			ObjectManager.NativeMethodInfoPtr_AddOnDeserialized_Internal_Virtual_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectManager>.NativeClassPtr, 100671071);
			ObjectManager.NativeMethodInfoPtr_RaiseOnDeserializedEvent_Internal_Virtual_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectManager>.NativeClassPtr, 100671072);
			ObjectManager.NativeMethodInfoPtr_RaiseOnDeserializingEvent_Public_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectManager>.NativeClassPtr, 100671073);
		}

		// Token: 0x0600314A RID: 12618 RVA: 0x000FA978 File Offset: 0x000F8B78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1385276, XrefRangeEnd = 1385283, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ObjectManager(ISurrogateSelector selector, StreamingContext context, bool checkSecurity, bool isCrossAppDomain)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ObjectManager>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(selector);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref checkSecurity;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isCrossAppDomain;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectManager.NativeMethodInfoPtr__ctor_Internal_Void_ISurrogateSelector_StreamingContext_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600314B RID: 12619 RVA: 0x000FA9F8 File Offset: 0x000F8BF8
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 25017, RefRangeEnd = 25031, XrefRangeStart = 25017, XrefRangeEnd = 25031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CanCallGetType(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectManager.NativeMethodInfoPtr_CanCallGetType_Private_Boolean_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000B13 RID: 2835
		// (get) Token: 0x0600314D RID: 12621 RVA: 0x000FAA8C File Offset: 0x000F8C8C
		// (set) Token: 0x0600314C RID: 12620 RVA: 0x000FAA48 File Offset: 0x000F8C48
		public unsafe Object TopObject
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectManager.NativeMethodInfoPtr_get_TopObject_Internal_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectManager.NativeMethodInfoPtr_set_TopObject_Internal_set_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000B14 RID: 2836
		// (get) Token: 0x0600314E RID: 12622 RVA: 0x000FAACC File Offset: 0x000F8CCC
		public unsafe ObjectHolderList SpecialFixupObjects
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 1385292, RefRangeEnd = 1385297, XrefRangeStart = 1385283, XrefRangeEnd = 1385292, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectManager.NativeMethodInfoPtr_get_SpecialFixupObjects_Internal_get_ObjectHolderList_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ObjectHolderList>(intPtr3) : null;
			}
		}

		// Token: 0x0600314F RID: 12623 RVA: 0x000FAB0C File Offset: 0x000F8D0C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1385297, RefRangeEnd = 1385301, XrefRangeStart = 1385297, XrefRangeEnd = 1385297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ObjectHolder FindObjectHolder(long objectID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref objectID;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectManager.NativeMethodInfoPtr_FindObjectHolder_Internal_ObjectHolder_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ObjectHolder>(intPtr3) : null;
			}
		}

		// Token: 0x06003150 RID: 12624 RVA: 0x000FAB58 File Offset: 0x000F8D58
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 1385312, RefRangeEnd = 1385322, XrefRangeStart = 1385301, XrefRangeEnd = 1385312, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ObjectHolder FindOrCreateObjectHolder(long objectID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref objectID;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectManager.NativeMethodInfoPtr_FindOrCreateObjectHolder_Internal_ObjectHolder_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ObjectHolder>(intPtr3) : null;
			}
		}

		// Token: 0x06003151 RID: 12625 RVA: 0x000FABA4 File Offset: 0x000F8DA4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1385332, RefRangeEnd = 1385334, XrefRangeStart = 1385322, XrefRangeEnd = 1385332, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddObjectHolder(ObjectHolder holder)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(holder);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectManager.NativeMethodInfoPtr_AddObjectHolder_Private_Void_ObjectHolder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003152 RID: 12626 RVA: 0x000FABE8 File Offset: 0x000F8DE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1385334, XrefRangeEnd = 1385340, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool GetCompletionInfo(FixupHolder fixup, out ObjectHolder holder, out Object member, bool bThrowIfMissing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(fixup);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = 0;
			ptr3 = &intPtr2;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bThrowIfMissing;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(ObjectManager.NativeMethodInfoPtr_GetCompletionInfo_Private_Boolean_FixupHolder_byref_ObjectHolder_byref_Object_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			IntPtr intPtr5 = intPtr;
			holder = ((intPtr5 == 0) ? null : new ObjectHolder(intPtr5));
			IntPtr intPtr6 = intPtr2;
			member = ((intPtr6 == 0) ? null : new Object(intPtr6));
			return *IL2CPP.il2cpp_object_unbox(intPtr3);
		}

		// Token: 0x06003153 RID: 12627 RVA: 0x000FAC8C File Offset: 0x000F8E8C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1385383, RefRangeEnd = 1385384, XrefRangeStart = 1385340, XrefRangeEnd = 1385383, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FixupSpecialObject(ObjectHolder holder)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(holder);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectManager.NativeMethodInfoPtr_FixupSpecialObject_Private_Void_ObjectHolder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003154 RID: 12628 RVA: 0x000FACD0 File Offset: 0x000F8ED0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1385395, RefRangeEnd = 1385396, XrefRangeStart = 1385384, XrefRangeEnd = 1385395, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ResolveObjectReference(ObjectHolder holder)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(holder);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectManager.NativeMethodInfoPtr_ResolveObjectReference_Private_Boolean_ObjectHolder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003155 RID: 12629 RVA: 0x000FAD20 File Offset: 0x000F8F20
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1385442, RefRangeEnd = 1385444, XrefRangeStart = 1385396, XrefRangeEnd = 1385442, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool DoValueTypeFixup(FieldInfo memberToFix, ObjectHolder holder, Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(memberToFix);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(holder);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectManager.NativeMethodInfoPtr_DoValueTypeFixup_Private_Boolean_FieldInfo_ObjectHolder_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003156 RID: 12630 RVA: 0x000FAD94 File Offset: 0x000F8F94
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1385503, RefRangeEnd = 1385508, XrefRangeStart = 1385444, XrefRangeEnd = 1385503, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CompleteObject(ObjectHolder holder, bool bObjectFullyComplete)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(holder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bObjectFullyComplete;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectManager.NativeMethodInfoPtr_CompleteObject_Internal_Void_ObjectHolder_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003157 RID: 12631 RVA: 0x000FADE4 File Offset: 0x000F8FE4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1385515, RefRangeEnd = 1385518, XrefRangeStart = 1385508, XrefRangeEnd = 1385515, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DoNewlyRegisteredObjectFixups(ObjectHolder holder)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(holder);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectManager.NativeMethodInfoPtr_DoNewlyRegisteredObjectFixups_Private_Void_ObjectHolder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003158 RID: 12632 RVA: 0x000FAE28 File Offset: 0x000F9028
		[CallerCount(0)]
		public unsafe virtual Object GetObject(long objectID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref objectID;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ObjectManager.NativeMethodInfoPtr_GetObject_Public_Virtual_New_Object_Int64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06003159 RID: 12633 RVA: 0x000FAE80 File Offset: 0x000F9080
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1385518, XrefRangeEnd = 1385527, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RegisterString(string obj, long objectID, SerializationInfo info, long idOfContainingObj, MemberInfo member)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(obj);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref objectID;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(info);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref idOfContainingObj;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(member);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectManager.NativeMethodInfoPtr_RegisterString_Internal_Void_String_Int64_SerializationInfo_Int64_MemberInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600315A RID: 12634 RVA: 0x000FAF04 File Offset: 0x000F9104
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1385568, RefRangeEnd = 1385570, XrefRangeStart = 1385527, XrefRangeEnd = 1385568, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RegisterObject(Object obj, long objectID, SerializationInfo info, long idOfContainingObj, MemberInfo member, Il2CppStructArray<int> arrayIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref objectID;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(info);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref idOfContainingObj;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(member);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(arrayIndex);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectManager.NativeMethodInfoPtr_RegisterObject_Public_Void_Object_Int64_SerializationInfo_Int64_MemberInfo_Il2CppStructArray_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600315B RID: 12635 RVA: 0x000FAF9C File Offset: 0x000F919C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1385578, RefRangeEnd = 1385579, XrefRangeStart = 1385570, XrefRangeEnd = 1385578, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CompleteISerializableObject(Object obj, SerializationInfo info, StreamingContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(info);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectManager.NativeMethodInfoPtr_CompleteISerializableObject_Internal_Void_Object_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600315C RID: 12636 RVA: 0x000FB008 File Offset: 0x000F9208
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1385584, RefRangeEnd = 1385586, XrefRangeStart = 1385579, XrefRangeEnd = 1385584, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static RuntimeConstructorInfo GetConstructor(RuntimeType t)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectManager.NativeMethodInfoPtr_GetConstructor_Internal_Static_RuntimeConstructorInfo_RuntimeType_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RuntimeConstructorInfo>(intPtr3) : null;
			}
		}

		// Token: 0x0600315D RID: 12637 RVA: 0x000FB04C File Offset: 0x000F924C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1385586, XrefRangeEnd = 1385602, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void DoFixups()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ObjectManager.NativeMethodInfoPtr_DoFixups_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600315E RID: 12638 RVA: 0x000FB088 File Offset: 0x000F9288
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1385629, RefRangeEnd = 1385632, XrefRangeStart = 1385602, XrefRangeEnd = 1385629, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RegisterFixup(FixupHolder fixup, long objectToBeFixed, long objectRequired)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(fixup);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref objectToBeFixed;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref objectRequired;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectManager.NativeMethodInfoPtr_RegisterFixup_Private_Void_FixupHolder_Int64_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600315F RID: 12639 RVA: 0x000FB0E8 File Offset: 0x000F92E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1385632, XrefRangeEnd = 1385671, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RecordFixup(long objectToBeFixed, MemberInfo member, long objectRequired)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref objectToBeFixed;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(member);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref objectRequired;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ObjectManager.NativeMethodInfoPtr_RecordFixup_Public_Virtual_New_Void_Int64_MemberInfo_Int64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003160 RID: 12640 RVA: 0x000FB154 File Offset: 0x000F9354
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1385671, XrefRangeEnd = 1385691, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RecordDelayedFixup(long objectToBeFixed, string memberName, long objectRequired)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref objectToBeFixed;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(memberName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref objectRequired;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ObjectManager.NativeMethodInfoPtr_RecordDelayedFixup_Public_Virtual_New_Void_Int64_String_Int64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003161 RID: 12641 RVA: 0x000FB1C0 File Offset: 0x000F93C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1385691, XrefRangeEnd = 1385711, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RecordArrayElementFixup(long arrayToBeFixed, Il2CppStructArray<int> indices, long objectRequired)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref arrayToBeFixed;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(indices);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref objectRequired;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ObjectManager.NativeMethodInfoPtr_RecordArrayElementFixup_Public_Virtual_New_Void_Int64_Il2CppStructArray_1_Int32_Int64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003162 RID: 12642 RVA: 0x000FB22C File Offset: 0x000F942C
		[CallerCount(0)]
		public unsafe virtual void RaiseDeserializationEvent()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ObjectManager.NativeMethodInfoPtr_RaiseDeserializationEvent_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003163 RID: 12643 RVA: 0x000FB268 File Offset: 0x000F9468
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1385711, XrefRangeEnd = 1385719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void AddOnDeserialization(DeserializationEventHandler handler)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(handler);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ObjectManager.NativeMethodInfoPtr_AddOnDeserialization_Internal_Virtual_New_Void_DeserializationEventHandler_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003164 RID: 12644 RVA: 0x000FB2B8 File Offset: 0x000F94B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1385719, XrefRangeEnd = 1385727, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void AddOnDeserialized(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ObjectManager.NativeMethodInfoPtr_AddOnDeserialized_Internal_Virtual_New_Void_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003165 RID: 12645 RVA: 0x000FB308 File Offset: 0x000F9508
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1385727, XrefRangeEnd = 1385733, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RaiseOnDeserializedEvent(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ObjectManager.NativeMethodInfoPtr_RaiseOnDeserializedEvent_Internal_Virtual_New_Void_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003166 RID: 12646 RVA: 0x000FB358 File Offset: 0x000F9558
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1385733, XrefRangeEnd = 1385739, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RaiseOnDeserializingEvent(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectManager.NativeMethodInfoPtr_RaiseOnDeserializingEvent_Public_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003167 RID: 12647 RVA: 0x00010FAE File Offset: 0x0000F1AE
		public ObjectManager(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000B0B RID: 2827
		// (get) Token: 0x06003168 RID: 12648 RVA: 0x000FB39C File Offset: 0x000F959C
		// (set) Token: 0x06003169 RID: 12649 RVA: 0x00010FB7 File Offset: 0x0000F1B7
		public unsafe DeserializationEventHandler m_onDeserializationHandler
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectManager.NativeFieldInfoPtr_m_onDeserializationHandler);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DeserializationEventHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectManager.NativeFieldInfoPtr_m_onDeserializationHandler), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B0C RID: 2828
		// (get) Token: 0x0600316A RID: 12650 RVA: 0x000FB3CC File Offset: 0x000F95CC
		// (set) Token: 0x0600316B RID: 12651 RVA: 0x00010FD6 File Offset: 0x0000F1D6
		public unsafe SerializationEventHandler m_onDeserializedHandler
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectManager.NativeFieldInfoPtr_m_onDeserializedHandler);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SerializationEventHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectManager.NativeFieldInfoPtr_m_onDeserializedHandler), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B0D RID: 2829
		// (get) Token: 0x0600316C RID: 12652 RVA: 0x000FB3FC File Offset: 0x000F95FC
		// (set) Token: 0x0600316D RID: 12653 RVA: 0x00010FF5 File Offset: 0x0000F1F5
		public unsafe Il2CppReferenceArray<ObjectHolder> m_objects
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectManager.NativeFieldInfoPtr_m_objects);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ObjectHolder>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectManager.NativeFieldInfoPtr_m_objects), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B0E RID: 2830
		// (get) Token: 0x0600316E RID: 12654 RVA: 0x000FB42C File Offset: 0x000F962C
		// (set) Token: 0x0600316F RID: 12655 RVA: 0x00011014 File Offset: 0x0000F214
		public unsafe Object m_topObject
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectManager.NativeFieldInfoPtr_m_topObject);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectManager.NativeFieldInfoPtr_m_topObject), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B0F RID: 2831
		// (get) Token: 0x06003170 RID: 12656 RVA: 0x000FB45C File Offset: 0x000F965C
		// (set) Token: 0x06003171 RID: 12657 RVA: 0x00011033 File Offset: 0x0000F233
		public unsafe ObjectHolderList m_specialFixupObjects
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectManager.NativeFieldInfoPtr_m_specialFixupObjects);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectHolderList>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectManager.NativeFieldInfoPtr_m_specialFixupObjects), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B10 RID: 2832
		// (get) Token: 0x06003172 RID: 12658 RVA: 0x000FB48C File Offset: 0x000F968C
		// (set) Token: 0x06003173 RID: 12659 RVA: 0x00011052 File Offset: 0x0000F252
		public unsafe long m_fixupCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectManager.NativeFieldInfoPtr_m_fixupCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectManager.NativeFieldInfoPtr_m_fixupCount)) = value;
			}
		}

		// Token: 0x17000B11 RID: 2833
		// (get) Token: 0x06003174 RID: 12660 RVA: 0x000FB4B4 File Offset: 0x000F96B4
		// (set) Token: 0x06003175 RID: 12661 RVA: 0x0001106D File Offset: 0x0000F26D
		public unsafe ISurrogateSelector m_selector
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectManager.NativeFieldInfoPtr_m_selector);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ISurrogateSelector>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectManager.NativeFieldInfoPtr_m_selector), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B12 RID: 2834
		// (get) Token: 0x06003176 RID: 12662 RVA: 0x000FB4E4 File Offset: 0x000F96E4
		// (set) Token: 0x06003177 RID: 12663 RVA: 0x0001108C File Offset: 0x0000F28C
		public StreamingContext m_context
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectManager.NativeFieldInfoPtr_m_context);
				return new StreamingContext(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<StreamingContext>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectManager.NativeFieldInfoPtr_m_context), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<StreamingContext>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x0400288D RID: 10381
		private static readonly IntPtr NativeFieldInfoPtr_m_onDeserializationHandler;

		// Token: 0x0400288E RID: 10382
		private static readonly IntPtr NativeFieldInfoPtr_m_onDeserializedHandler;

		// Token: 0x0400288F RID: 10383
		private static readonly IntPtr NativeFieldInfoPtr_m_objects;

		// Token: 0x04002890 RID: 10384
		private static readonly IntPtr NativeFieldInfoPtr_m_topObject;

		// Token: 0x04002891 RID: 10385
		private static readonly IntPtr NativeFieldInfoPtr_m_specialFixupObjects;

		// Token: 0x04002892 RID: 10386
		private static readonly IntPtr NativeFieldInfoPtr_m_fixupCount;

		// Token: 0x04002893 RID: 10387
		private static readonly IntPtr NativeFieldInfoPtr_m_selector;

		// Token: 0x04002894 RID: 10388
		private static readonly IntPtr NativeFieldInfoPtr_m_context;

		// Token: 0x04002895 RID: 10389
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_ISurrogateSelector_StreamingContext_Boolean_Boolean_0;

		// Token: 0x04002896 RID: 10390
		private static readonly IntPtr NativeMethodInfoPtr_CanCallGetType_Private_Boolean_Object_0;

		// Token: 0x04002897 RID: 10391
		private static readonly IntPtr NativeMethodInfoPtr_set_TopObject_Internal_set_Void_Object_0;

		// Token: 0x04002898 RID: 10392
		private static readonly IntPtr NativeMethodInfoPtr_get_TopObject_Internal_get_Object_0;

		// Token: 0x04002899 RID: 10393
		private static readonly IntPtr NativeMethodInfoPtr_get_SpecialFixupObjects_Internal_get_ObjectHolderList_0;

		// Token: 0x0400289A RID: 10394
		private static readonly IntPtr NativeMethodInfoPtr_FindObjectHolder_Internal_ObjectHolder_Int64_0;

		// Token: 0x0400289B RID: 10395
		private static readonly IntPtr NativeMethodInfoPtr_FindOrCreateObjectHolder_Internal_ObjectHolder_Int64_0;

		// Token: 0x0400289C RID: 10396
		private static readonly IntPtr NativeMethodInfoPtr_AddObjectHolder_Private_Void_ObjectHolder_0;

		// Token: 0x0400289D RID: 10397
		private static readonly IntPtr NativeMethodInfoPtr_GetCompletionInfo_Private_Boolean_FixupHolder_byref_ObjectHolder_byref_Object_Boolean_0;

		// Token: 0x0400289E RID: 10398
		private static readonly IntPtr NativeMethodInfoPtr_FixupSpecialObject_Private_Void_ObjectHolder_0;

		// Token: 0x0400289F RID: 10399
		private static readonly IntPtr NativeMethodInfoPtr_ResolveObjectReference_Private_Boolean_ObjectHolder_0;

		// Token: 0x040028A0 RID: 10400
		private static readonly IntPtr NativeMethodInfoPtr_DoValueTypeFixup_Private_Boolean_FieldInfo_ObjectHolder_Object_0;

		// Token: 0x040028A1 RID: 10401
		private static readonly IntPtr NativeMethodInfoPtr_CompleteObject_Internal_Void_ObjectHolder_Boolean_0;

		// Token: 0x040028A2 RID: 10402
		private static readonly IntPtr NativeMethodInfoPtr_DoNewlyRegisteredObjectFixups_Private_Void_ObjectHolder_0;

		// Token: 0x040028A3 RID: 10403
		private static readonly IntPtr NativeMethodInfoPtr_GetObject_Public_Virtual_New_Object_Int64_0;

		// Token: 0x040028A4 RID: 10404
		private static readonly IntPtr NativeMethodInfoPtr_RegisterString_Internal_Void_String_Int64_SerializationInfo_Int64_MemberInfo_0;

		// Token: 0x040028A5 RID: 10405
		private static readonly IntPtr NativeMethodInfoPtr_RegisterObject_Public_Void_Object_Int64_SerializationInfo_Int64_MemberInfo_Il2CppStructArray_1_Int32_0;

		// Token: 0x040028A6 RID: 10406
		private static readonly IntPtr NativeMethodInfoPtr_CompleteISerializableObject_Internal_Void_Object_SerializationInfo_StreamingContext_0;

		// Token: 0x040028A7 RID: 10407
		private static readonly IntPtr NativeMethodInfoPtr_GetConstructor_Internal_Static_RuntimeConstructorInfo_RuntimeType_0;

		// Token: 0x040028A8 RID: 10408
		private static readonly IntPtr NativeMethodInfoPtr_DoFixups_Public_Virtual_New_Void_0;

		// Token: 0x040028A9 RID: 10409
		private static readonly IntPtr NativeMethodInfoPtr_RegisterFixup_Private_Void_FixupHolder_Int64_Int64_0;

		// Token: 0x040028AA RID: 10410
		private static readonly IntPtr NativeMethodInfoPtr_RecordFixup_Public_Virtual_New_Void_Int64_MemberInfo_Int64_0;

		// Token: 0x040028AB RID: 10411
		private static readonly IntPtr NativeMethodInfoPtr_RecordDelayedFixup_Public_Virtual_New_Void_Int64_String_Int64_0;

		// Token: 0x040028AC RID: 10412
		private static readonly IntPtr NativeMethodInfoPtr_RecordArrayElementFixup_Public_Virtual_New_Void_Int64_Il2CppStructArray_1_Int32_Int64_0;

		// Token: 0x040028AD RID: 10413
		private static readonly IntPtr NativeMethodInfoPtr_RaiseDeserializationEvent_Public_Virtual_New_Void_0;

		// Token: 0x040028AE RID: 10414
		private static readonly IntPtr NativeMethodInfoPtr_AddOnDeserialization_Internal_Virtual_New_Void_DeserializationEventHandler_0;

		// Token: 0x040028AF RID: 10415
		private static readonly IntPtr NativeMethodInfoPtr_AddOnDeserialized_Internal_Virtual_New_Void_Object_0;

		// Token: 0x040028B0 RID: 10416
		private static readonly IntPtr NativeMethodInfoPtr_RaiseOnDeserializedEvent_Internal_Virtual_New_Void_Object_0;

		// Token: 0x040028B1 RID: 10417
		private static readonly IntPtr NativeMethodInfoPtr_RaiseOnDeserializingEvent_Public_Void_Object_0;
	}
}
