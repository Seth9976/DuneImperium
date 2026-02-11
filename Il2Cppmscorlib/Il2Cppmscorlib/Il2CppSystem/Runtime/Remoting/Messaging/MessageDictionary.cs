using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;

namespace Il2CppSystem.Runtime.Remoting.Messaging
{
	// Token: 0x02000303 RID: 771
	[Serializable]
	public class MessageDictionary : Object
	{
		// Token: 0x06002F67 RID: 12135 RVA: 0x000F37A8 File Offset: 0x000F19A8
		// Note: this type is marked as 'beforefieldinit'.
		static MessageDictionary()
		{
			Il2CppClassPointerStore<MessageDictionary>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting.Messaging", "MessageDictionary");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MessageDictionary>.NativeClassPtr);
			MessageDictionary.NativeFieldInfoPtr__internalProperties = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessageDictionary>.NativeClassPtr, "_internalProperties");
			MessageDictionary.NativeFieldInfoPtr__message = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessageDictionary>.NativeClassPtr, "_message");
			MessageDictionary.NativeFieldInfoPtr__methodKeys = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessageDictionary>.NativeClassPtr, "_methodKeys");
			MessageDictionary.NativeFieldInfoPtr__ownProperties = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessageDictionary>.NativeClassPtr, "_ownProperties");
			MessageDictionary.NativeMethodInfoPtr__ctor_Public_Void_IMethodMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessageDictionary>.NativeClassPtr, 100670813);
			MessageDictionary.NativeMethodInfoPtr_HasUserData_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessageDictionary>.NativeClassPtr, 100670814);
			MessageDictionary.NativeMethodInfoPtr_get_InternalDictionary_Internal_get_IDictionary_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessageDictionary>.NativeClassPtr, 100670815);
			MessageDictionary.NativeMethodInfoPtr_set_MethodKeys_Public_set_Void_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessageDictionary>.NativeClassPtr, 100670816);
			MessageDictionary.NativeMethodInfoPtr_AllocInternalProperties_Protected_Virtual_New_IDictionary_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessageDictionary>.NativeClassPtr, 100670817);
			MessageDictionary.NativeMethodInfoPtr_GetInternalProperties_Public_IDictionary_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessageDictionary>.NativeClassPtr, 100670818);
			MessageDictionary.NativeMethodInfoPtr_IsOverridenKey_Private_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessageDictionary>.NativeClassPtr, 100670819);
			MessageDictionary.NativeMethodInfoPtr_get_IsFixedSize_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessageDictionary>.NativeClassPtr, 100670820);
			MessageDictionary.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessageDictionary>.NativeClassPtr, 100670821);
			MessageDictionary.NativeMethodInfoPtr_get_Item_Public_Virtual_Final_New_get_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessageDictionary>.NativeClassPtr, 100670822);
			MessageDictionary.NativeMethodInfoPtr_set_Item_Public_Virtual_Final_New_set_Void_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessageDictionary>.NativeClassPtr, 100670823);
			MessageDictionary.NativeMethodInfoPtr_GetMethodProperty_Protected_Virtual_New_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessageDictionary>.NativeClassPtr, 100670824);
			MessageDictionary.NativeMethodInfoPtr_SetMethodProperty_Protected_Virtual_New_Void_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessageDictionary>.NativeClassPtr, 100670825);
			MessageDictionary.NativeMethodInfoPtr_get_Keys_Public_Virtual_Final_New_get_ICollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessageDictionary>.NativeClassPtr, 100670826);
			MessageDictionary.NativeMethodInfoPtr_get_Values_Public_Virtual_Final_New_get_ICollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessageDictionary>.NativeClassPtr, 100670827);
			MessageDictionary.NativeMethodInfoPtr_Add_Public_Virtual_Final_New_Void_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessageDictionary>.NativeClassPtr, 100670828);
			MessageDictionary.NativeMethodInfoPtr_Clear_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessageDictionary>.NativeClassPtr, 100670829);
			MessageDictionary.NativeMethodInfoPtr_Contains_Public_Virtual_Final_New_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessageDictionary>.NativeClassPtr, 100670830);
			MessageDictionary.NativeMethodInfoPtr_Remove_Public_Virtual_Final_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessageDictionary>.NativeClassPtr, 100670831);
			MessageDictionary.NativeMethodInfoPtr_get_Count_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessageDictionary>.NativeClassPtr, 100670832);
			MessageDictionary.NativeMethodInfoPtr_get_IsSynchronized_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessageDictionary>.NativeClassPtr, 100670833);
			MessageDictionary.NativeMethodInfoPtr_get_SyncRoot_Public_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessageDictionary>.NativeClassPtr, 100670834);
			MessageDictionary.NativeMethodInfoPtr_CopyTo_Public_Virtual_Final_New_Void_Array_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessageDictionary>.NativeClassPtr, 100670835);
			MessageDictionary.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessageDictionary>.NativeClassPtr, 100670836);
			MessageDictionary.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IDictionaryEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessageDictionary>.NativeClassPtr, 100670837);
		}

		// Token: 0x06002F68 RID: 12136 RVA: 0x000F3A1C File Offset: 0x000F1C1C
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 320067, RefRangeEnd = 320078, XrefRangeStart = 320067, XrefRangeEnd = 320078, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MessageDictionary(IMethodMessage message)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MessageDictionary>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessageDictionary.NativeMethodInfoPtr__ctor_Public_Void_IMethodMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002F69 RID: 12137 RVA: 0x000F3A68 File Offset: 0x000F1C68
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1383629, RefRangeEnd = 1383630, XrefRangeStart = 1383627, XrefRangeEnd = 1383629, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool HasUserData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessageDictionary.NativeMethodInfoPtr_HasUserData_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000A6E RID: 2670
		// (get) Token: 0x06002F6A RID: 12138 RVA: 0x000F3AA4 File Offset: 0x000F1CA4
		public unsafe IDictionary InternalDictionary
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1383633, RefRangeEnd = 1383635, XrefRangeStart = 1383630, XrefRangeEnd = 1383633, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessageDictionary.NativeMethodInfoPtr_get_InternalDictionary_Internal_get_IDictionary_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IDictionary>(intPtr3) : null;
			}
		}

		// Token: 0x17000A6F RID: 2671
		// (set) Token: 0x06002F6B RID: 12139 RVA: 0x000F3AE4 File Offset: 0x000F1CE4
		public unsafe Il2CppStringArray MethodKeys
		{
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessageDictionary.NativeMethodInfoPtr_set_MethodKeys_Public_set_Void_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06002F6C RID: 12140 RVA: 0x000F3B28 File Offset: 0x000F1D28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1383635, XrefRangeEnd = 1383639, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IDictionary AllocInternalProperties()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MessageDictionary.NativeMethodInfoPtr_AllocInternalProperties_Protected_Virtual_New_IDictionary_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IDictionary>(intPtr3) : null;
		}

		// Token: 0x06002F6D RID: 12141 RVA: 0x000F3B74 File Offset: 0x000F1D74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1383639, XrefRangeEnd = 1383640, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IDictionary GetInternalProperties()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessageDictionary.NativeMethodInfoPtr_GetInternalProperties_Public_IDictionary_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IDictionary>(intPtr3) : null;
		}

		// Token: 0x06002F6E RID: 12142 RVA: 0x000F3BB4 File Offset: 0x000F1DB4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1383642, RefRangeEnd = 1383643, XrefRangeStart = 1383640, XrefRangeEnd = 1383642, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsOverridenKey(string key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessageDictionary.NativeMethodInfoPtr_IsOverridenKey_Private_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000A70 RID: 2672
		// (get) Token: 0x06002F6F RID: 12143 RVA: 0x000F3C04 File Offset: 0x000F1E04
		public unsafe virtual bool IsFixedSize
		{
			[CallerCount(184)]
			[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessageDictionary.NativeMethodInfoPtr_get_IsFixedSize_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000A71 RID: 2673
		// (get) Token: 0x06002F70 RID: 12144 RVA: 0x000F3C40 File Offset: 0x000F1E40
		public unsafe virtual bool IsReadOnly
		{
			[CallerCount(184)]
			[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessageDictionary.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000A72 RID: 2674
		public unsafe virtual Object this[Object key]
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1383643, XrefRangeEnd = 1383648, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessageDictionary.NativeMethodInfoPtr_get_Item_Public_Virtual_Final_New_get_Object_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1383648, XrefRangeEnd = 1383653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessageDictionary.NativeMethodInfoPtr_set_Item_Public_Virtual_Final_New_set_Void_Object_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002F73 RID: 12147 RVA: 0x000F3D20 File Offset: 0x000F1F20
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1383704, RefRangeEnd = 1383705, XrefRangeStart = 1383653, XrefRangeEnd = 1383704, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Object GetMethodProperty(string key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MessageDictionary.NativeMethodInfoPtr_GetMethodProperty_Protected_Virtual_New_Object_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06002F74 RID: 12148 RVA: 0x000F3D7C File Offset: 0x000F1F7C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1383739, RefRangeEnd = 1383740, XrefRangeStart = 1383705, XrefRangeEnd = 1383739, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetMethodProperty(string key, Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MessageDictionary.NativeMethodInfoPtr_SetMethodProperty_Protected_Virtual_New_Void_String_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000A73 RID: 2675
		// (get) Token: 0x06002F75 RID: 12149 RVA: 0x000F3DDC File Offset: 0x000F1FDC
		public unsafe virtual ICollection Keys
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1383740, XrefRangeEnd = 1383771, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessageDictionary.NativeMethodInfoPtr_get_Keys_Public_Virtual_Final_New_get_ICollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ICollection>(intPtr3) : null;
			}
		}

		// Token: 0x17000A74 RID: 2676
		// (get) Token: 0x06002F76 RID: 12150 RVA: 0x000F3E1C File Offset: 0x000F201C
		public unsafe virtual ICollection Values
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1383802, RefRangeEnd = 1383803, XrefRangeStart = 1383771, XrefRangeEnd = 1383802, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessageDictionary.NativeMethodInfoPtr_get_Values_Public_Virtual_Final_New_get_ICollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ICollection>(intPtr3) : null;
			}
		}

		// Token: 0x06002F77 RID: 12151 RVA: 0x000F3E5C File Offset: 0x000F205C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Add(Object key, Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessageDictionary.NativeMethodInfoPtr_Add_Public_Virtual_Final_New_Void_Object_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002F78 RID: 12152 RVA: 0x000F3EB0 File Offset: 0x000F20B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1383803, XrefRangeEnd = 1383806, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Clear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessageDictionary.NativeMethodInfoPtr_Clear_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002F79 RID: 12153 RVA: 0x000F3EE4 File Offset: 0x000F20E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1383806, XrefRangeEnd = 1383811, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool Contains(Object key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessageDictionary.NativeMethodInfoPtr_Contains_Public_Virtual_Final_New_Boolean_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002F7A RID: 12154 RVA: 0x000F3F34 File Offset: 0x000F2134
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1383811, XrefRangeEnd = 1383818, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Remove(Object key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessageDictionary.NativeMethodInfoPtr_Remove_Public_Virtual_Final_New_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000A75 RID: 2677
		// (get) Token: 0x06002F7B RID: 12155 RVA: 0x000F3F78 File Offset: 0x000F2178
		public unsafe virtual int Count
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1383818, XrefRangeEnd = 1383819, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessageDictionary.NativeMethodInfoPtr_get_Count_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000A76 RID: 2678
		// (get) Token: 0x06002F7C RID: 12156 RVA: 0x000F3FB4 File Offset: 0x000F21B4
		public unsafe virtual bool IsSynchronized
		{
			[CallerCount(184)]
			[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessageDictionary.NativeMethodInfoPtr_get_IsSynchronized_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000A77 RID: 2679
		// (get) Token: 0x06002F7D RID: 12157 RVA: 0x000F3FF0 File Offset: 0x000F21F0
		public unsafe virtual Object SyncRoot
		{
			[CallerCount(1295)]
			[CachedScanResults(RefRangeStart = 308780, RefRangeEnd = 310075, XrefRangeStart = 308780, XrefRangeEnd = 310075, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessageDictionary.NativeMethodInfoPtr_get_SyncRoot_Public_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06002F7E RID: 12158 RVA: 0x000F4030 File Offset: 0x000F2230
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1383819, XrefRangeEnd = 1383823, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void CopyTo(Array array, int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessageDictionary.NativeMethodInfoPtr_CopyTo_Public_Virtual_Final_New_Void_Array_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002F7F RID: 12159 RVA: 0x000F4080 File Offset: 0x000F2280
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1383823, XrefRangeEnd = 1383827, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerator System_Collections_IEnumerable_GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessageDictionary.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06002F80 RID: 12160 RVA: 0x000F40C0 File Offset: 0x000F22C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1383827, XrefRangeEnd = 1383831, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IDictionaryEnumerator GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessageDictionary.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IDictionaryEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IDictionaryEnumerator>(intPtr3) : null;
		}

		// Token: 0x06002F81 RID: 12161 RVA: 0x0001025A File Offset: 0x0000E45A
		public MessageDictionary(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000A6A RID: 2666
		// (get) Token: 0x06002F82 RID: 12162 RVA: 0x000F4100 File Offset: 0x000F2300
		// (set) Token: 0x06002F83 RID: 12163 RVA: 0x00010263 File Offset: 0x0000E463
		public unsafe IDictionary _internalProperties
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageDictionary.NativeFieldInfoPtr__internalProperties);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IDictionary>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageDictionary.NativeFieldInfoPtr__internalProperties), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A6B RID: 2667
		// (get) Token: 0x06002F84 RID: 12164 RVA: 0x000F4130 File Offset: 0x000F2330
		// (set) Token: 0x06002F85 RID: 12165 RVA: 0x00010282 File Offset: 0x0000E482
		public unsafe IMethodMessage _message
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageDictionary.NativeFieldInfoPtr__message);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IMethodMessage>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageDictionary.NativeFieldInfoPtr__message), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A6C RID: 2668
		// (get) Token: 0x06002F86 RID: 12166 RVA: 0x000F4160 File Offset: 0x000F2360
		// (set) Token: 0x06002F87 RID: 12167 RVA: 0x000102A1 File Offset: 0x0000E4A1
		public unsafe Il2CppStringArray _methodKeys
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageDictionary.NativeFieldInfoPtr__methodKeys);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageDictionary.NativeFieldInfoPtr__methodKeys), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A6D RID: 2669
		// (get) Token: 0x06002F88 RID: 12168 RVA: 0x000F4190 File Offset: 0x000F2390
		// (set) Token: 0x06002F89 RID: 12169 RVA: 0x000102C0 File Offset: 0x0000E4C0
		public unsafe bool _ownProperties
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageDictionary.NativeFieldInfoPtr__ownProperties);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageDictionary.NativeFieldInfoPtr__ownProperties)) = value;
			}
		}

		// Token: 0x04002755 RID: 10069
		private static readonly IntPtr NativeFieldInfoPtr__internalProperties;

		// Token: 0x04002756 RID: 10070
		private static readonly IntPtr NativeFieldInfoPtr__message;

		// Token: 0x04002757 RID: 10071
		private static readonly IntPtr NativeFieldInfoPtr__methodKeys;

		// Token: 0x04002758 RID: 10072
		private static readonly IntPtr NativeFieldInfoPtr__ownProperties;

		// Token: 0x04002759 RID: 10073
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IMethodMessage_0;

		// Token: 0x0400275A RID: 10074
		private static readonly IntPtr NativeMethodInfoPtr_HasUserData_Internal_Boolean_0;

		// Token: 0x0400275B RID: 10075
		private static readonly IntPtr NativeMethodInfoPtr_get_InternalDictionary_Internal_get_IDictionary_0;

		// Token: 0x0400275C RID: 10076
		private static readonly IntPtr NativeMethodInfoPtr_set_MethodKeys_Public_set_Void_Il2CppStringArray_0;

		// Token: 0x0400275D RID: 10077
		private static readonly IntPtr NativeMethodInfoPtr_AllocInternalProperties_Protected_Virtual_New_IDictionary_0;

		// Token: 0x0400275E RID: 10078
		private static readonly IntPtr NativeMethodInfoPtr_GetInternalProperties_Public_IDictionary_0;

		// Token: 0x0400275F RID: 10079
		private static readonly IntPtr NativeMethodInfoPtr_IsOverridenKey_Private_Boolean_String_0;

		// Token: 0x04002760 RID: 10080
		private static readonly IntPtr NativeMethodInfoPtr_get_IsFixedSize_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04002761 RID: 10081
		private static readonly IntPtr NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04002762 RID: 10082
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_Virtual_Final_New_get_Object_Object_0;

		// Token: 0x04002763 RID: 10083
		private static readonly IntPtr NativeMethodInfoPtr_set_Item_Public_Virtual_Final_New_set_Void_Object_Object_0;

		// Token: 0x04002764 RID: 10084
		private static readonly IntPtr NativeMethodInfoPtr_GetMethodProperty_Protected_Virtual_New_Object_String_0;

		// Token: 0x04002765 RID: 10085
		private static readonly IntPtr NativeMethodInfoPtr_SetMethodProperty_Protected_Virtual_New_Void_String_Object_0;

		// Token: 0x04002766 RID: 10086
		private static readonly IntPtr NativeMethodInfoPtr_get_Keys_Public_Virtual_Final_New_get_ICollection_0;

		// Token: 0x04002767 RID: 10087
		private static readonly IntPtr NativeMethodInfoPtr_get_Values_Public_Virtual_Final_New_get_ICollection_0;

		// Token: 0x04002768 RID: 10088
		private static readonly IntPtr NativeMethodInfoPtr_Add_Public_Virtual_Final_New_Void_Object_Object_0;

		// Token: 0x04002769 RID: 10089
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Virtual_Final_New_Void_0;

		// Token: 0x0400276A RID: 10090
		private static readonly IntPtr NativeMethodInfoPtr_Contains_Public_Virtual_Final_New_Boolean_Object_0;

		// Token: 0x0400276B RID: 10091
		private static readonly IntPtr NativeMethodInfoPtr_Remove_Public_Virtual_Final_New_Void_Object_0;

		// Token: 0x0400276C RID: 10092
		private static readonly IntPtr NativeMethodInfoPtr_get_Count_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x0400276D RID: 10093
		private static readonly IntPtr NativeMethodInfoPtr_get_IsSynchronized_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x0400276E RID: 10094
		private static readonly IntPtr NativeMethodInfoPtr_get_SyncRoot_Public_Virtual_Final_New_get_Object_0;

		// Token: 0x0400276F RID: 10095
		private static readonly IntPtr NativeMethodInfoPtr_CopyTo_Public_Virtual_Final_New_Void_Array_Int32_0;

		// Token: 0x04002770 RID: 10096
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;

		// Token: 0x04002771 RID: 10097
		private static readonly IntPtr NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IDictionaryEnumerator_0;

		// Token: 0x0200066D RID: 1645
		public class DictionaryEnumerator : Object
		{
			// Token: 0x06005B51 RID: 23377 RVA: 0x0019F908 File Offset: 0x0019DB08
			// Note: this type is marked as 'beforefieldinit'.
			static DictionaryEnumerator()
			{
				Il2CppClassPointerStore<MessageDictionary.DictionaryEnumerator>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MessageDictionary>.NativeClassPtr, "DictionaryEnumerator");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MessageDictionary.DictionaryEnumerator>.NativeClassPtr);
				MessageDictionary.DictionaryEnumerator.NativeFieldInfoPtr__methodDictionary = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessageDictionary.DictionaryEnumerator>.NativeClassPtr, "_methodDictionary");
				MessageDictionary.DictionaryEnumerator.NativeFieldInfoPtr__hashtableEnum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessageDictionary.DictionaryEnumerator>.NativeClassPtr, "_hashtableEnum");
				MessageDictionary.DictionaryEnumerator.NativeFieldInfoPtr__posMethod = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessageDictionary.DictionaryEnumerator>.NativeClassPtr, "_posMethod");
				MessageDictionary.DictionaryEnumerator.NativeMethodInfoPtr__ctor_Public_Void_MessageDictionary_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessageDictionary.DictionaryEnumerator>.NativeClassPtr, 100670838);
				MessageDictionary.DictionaryEnumerator.NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessageDictionary.DictionaryEnumerator>.NativeClassPtr, 100670839);
				MessageDictionary.DictionaryEnumerator.NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessageDictionary.DictionaryEnumerator>.NativeClassPtr, 100670840);
				MessageDictionary.DictionaryEnumerator.NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessageDictionary.DictionaryEnumerator>.NativeClassPtr, 100670841);
				MessageDictionary.DictionaryEnumerator.NativeMethodInfoPtr_get_Entry_Public_Virtual_Final_New_get_DictionaryEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessageDictionary.DictionaryEnumerator>.NativeClassPtr, 100670842);
				MessageDictionary.DictionaryEnumerator.NativeMethodInfoPtr_get_Key_Public_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessageDictionary.DictionaryEnumerator>.NativeClassPtr, 100670843);
				MessageDictionary.DictionaryEnumerator.NativeMethodInfoPtr_get_Value_Public_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessageDictionary.DictionaryEnumerator>.NativeClassPtr, 100670844);
			}

			// Token: 0x06005B52 RID: 23378 RVA: 0x0019F9FC File Offset: 0x0019DBFC
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1383600, RefRangeEnd = 1383602, XrefRangeStart = 1383593, XrefRangeEnd = 1383600, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe DictionaryEnumerator(MessageDictionary methodDictionary)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MessageDictionary.DictionaryEnumerator>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(methodDictionary);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessageDictionary.DictionaryEnumerator.NativeMethodInfoPtr__ctor_Public_Void_MessageDictionary_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x17001768 RID: 5992
			// (get) Token: 0x06005B53 RID: 23379 RVA: 0x0019FA48 File Offset: 0x0019DC48
			public unsafe virtual Object Current
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1383602, XrefRangeEnd = 1383606, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessageDictionary.DictionaryEnumerator.NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06005B54 RID: 23380 RVA: 0x0019FA88 File Offset: 0x0019DC88
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1383606, XrefRangeEnd = 1383615, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessageDictionary.DictionaryEnumerator.NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06005B55 RID: 23381 RVA: 0x0019FAC4 File Offset: 0x0019DCC4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1383615, XrefRangeEnd = 1383619, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual void Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessageDictionary.DictionaryEnumerator.NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001769 RID: 5993
			// (get) Token: 0x06005B56 RID: 23382 RVA: 0x0019FAF8 File Offset: 0x0019DCF8
			public unsafe virtual DictionaryEntry Entry
			{
				[CallerCount(3)]
				[CachedScanResults(RefRangeStart = 1383622, RefRangeEnd = 1383625, XrefRangeStart = 1383619, XrefRangeEnd = 1383622, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessageDictionary.DictionaryEnumerator.NativeMethodInfoPtr_get_Entry_Public_Virtual_Final_New_get_DictionaryEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return new DictionaryEntry(intPtr);
				}
			}

			// Token: 0x1700176A RID: 5994
			// (get) Token: 0x06005B57 RID: 23383 RVA: 0x0019FB30 File Offset: 0x0019DD30
			public unsafe virtual Object Key
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1383625, XrefRangeEnd = 1383626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessageDictionary.DictionaryEnumerator.NativeMethodInfoPtr_get_Key_Public_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x1700176B RID: 5995
			// (get) Token: 0x06005B58 RID: 23384 RVA: 0x0019FB70 File Offset: 0x0019DD70
			public unsafe virtual Object Value
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1383626, XrefRangeEnd = 1383627, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessageDictionary.DictionaryEnumerator.NativeMethodInfoPtr_get_Value_Public_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06005B59 RID: 23385 RVA: 0x00021196 File Offset: 0x0001F396
			public DictionaryEnumerator(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001765 RID: 5989
			// (get) Token: 0x06005B5A RID: 23386 RVA: 0x0019FBB0 File Offset: 0x0019DDB0
			// (set) Token: 0x06005B5B RID: 23387 RVA: 0x0002119F File Offset: 0x0001F39F
			public unsafe MessageDictionary _methodDictionary
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageDictionary.DictionaryEnumerator.NativeFieldInfoPtr__methodDictionary);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MessageDictionary>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageDictionary.DictionaryEnumerator.NativeFieldInfoPtr__methodDictionary), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001766 RID: 5990
			// (get) Token: 0x06005B5C RID: 23388 RVA: 0x0019FBE0 File Offset: 0x0019DDE0
			// (set) Token: 0x06005B5D RID: 23389 RVA: 0x000211BE File Offset: 0x0001F3BE
			public unsafe IDictionaryEnumerator _hashtableEnum
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageDictionary.DictionaryEnumerator.NativeFieldInfoPtr__hashtableEnum);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IDictionaryEnumerator>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageDictionary.DictionaryEnumerator.NativeFieldInfoPtr__hashtableEnum), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001767 RID: 5991
			// (get) Token: 0x06005B5E RID: 23390 RVA: 0x0019FC10 File Offset: 0x0019DE10
			// (set) Token: 0x06005B5F RID: 23391 RVA: 0x000211DD File Offset: 0x0001F3DD
			public unsafe int _posMethod
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageDictionary.DictionaryEnumerator.NativeFieldInfoPtr__posMethod);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageDictionary.DictionaryEnumerator.NativeFieldInfoPtr__posMethod)) = value;
				}
			}

			// Token: 0x04004A6A RID: 19050
			private static readonly IntPtr NativeFieldInfoPtr__methodDictionary;

			// Token: 0x04004A6B RID: 19051
			private static readonly IntPtr NativeFieldInfoPtr__hashtableEnum;

			// Token: 0x04004A6C RID: 19052
			private static readonly IntPtr NativeFieldInfoPtr__posMethod;

			// Token: 0x04004A6D RID: 19053
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_MessageDictionary_0;

			// Token: 0x04004A6E RID: 19054
			private static readonly IntPtr NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_Object_0;

			// Token: 0x04004A6F RID: 19055
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0;

			// Token: 0x04004A70 RID: 19056
			private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0;

			// Token: 0x04004A71 RID: 19057
			private static readonly IntPtr NativeMethodInfoPtr_get_Entry_Public_Virtual_Final_New_get_DictionaryEntry_0;

			// Token: 0x04004A72 RID: 19058
			private static readonly IntPtr NativeMethodInfoPtr_get_Key_Public_Virtual_Final_New_get_Object_0;

			// Token: 0x04004A73 RID: 19059
			private static readonly IntPtr NativeMethodInfoPtr_get_Value_Public_Virtual_Final_New_get_Object_0;
		}
	}
}
