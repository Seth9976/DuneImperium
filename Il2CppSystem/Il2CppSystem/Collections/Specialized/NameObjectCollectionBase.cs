using System;
using System.Reflection;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem.Collections.Specialized
{
	// Token: 0x02000164 RID: 356
	[Serializable]
	public class NameObjectCollectionBase : Object
	{
		// Token: 0x0600156E RID: 5486 RVA: 0x0006F904 File Offset: 0x0006DB04
		// Note: this type is marked as 'beforefieldinit'.
		static NameObjectCollectionBase()
		{
			Il2CppClassPointerStore<NameObjectCollectionBase>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Collections.Specialized", "NameObjectCollectionBase");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NameObjectCollectionBase>.NativeClassPtr);
			NameObjectCollectionBase.NativeFieldInfoPtr_ReadOnlyName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NameObjectCollectionBase>.NativeClassPtr, "ReadOnlyName");
			NameObjectCollectionBase.NativeFieldInfoPtr_CountName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NameObjectCollectionBase>.NativeClassPtr, "CountName");
			NameObjectCollectionBase.NativeFieldInfoPtr_ComparerName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NameObjectCollectionBase>.NativeClassPtr, "ComparerName");
			NameObjectCollectionBase.NativeFieldInfoPtr_HashCodeProviderName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NameObjectCollectionBase>.NativeClassPtr, "HashCodeProviderName");
			NameObjectCollectionBase.NativeFieldInfoPtr_KeysName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NameObjectCollectionBase>.NativeClassPtr, "KeysName");
			NameObjectCollectionBase.NativeFieldInfoPtr_ValuesName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NameObjectCollectionBase>.NativeClassPtr, "ValuesName");
			NameObjectCollectionBase.NativeFieldInfoPtr_KeyComparerName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NameObjectCollectionBase>.NativeClassPtr, "KeyComparerName");
			NameObjectCollectionBase.NativeFieldInfoPtr_VersionName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NameObjectCollectionBase>.NativeClassPtr, "VersionName");
			NameObjectCollectionBase.NativeFieldInfoPtr__readOnly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NameObjectCollectionBase>.NativeClassPtr, "_readOnly");
			NameObjectCollectionBase.NativeFieldInfoPtr__entriesArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NameObjectCollectionBase>.NativeClassPtr, "_entriesArray");
			NameObjectCollectionBase.NativeFieldInfoPtr__keyComparer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NameObjectCollectionBase>.NativeClassPtr, "_keyComparer");
			NameObjectCollectionBase.NativeFieldInfoPtr__entriesTable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NameObjectCollectionBase>.NativeClassPtr, "_entriesTable");
			NameObjectCollectionBase.NativeFieldInfoPtr__nullKeyEntry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NameObjectCollectionBase>.NativeClassPtr, "_nullKeyEntry");
			NameObjectCollectionBase.NativeFieldInfoPtr__keys = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NameObjectCollectionBase>.NativeClassPtr, "_keys");
			NameObjectCollectionBase.NativeFieldInfoPtr__serializationInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NameObjectCollectionBase>.NativeClassPtr, "_serializationInfo");
			NameObjectCollectionBase.NativeFieldInfoPtr__version = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NameObjectCollectionBase>.NativeClassPtr, "_version");
			NameObjectCollectionBase.NativeFieldInfoPtr__syncRoot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NameObjectCollectionBase>.NativeClassPtr, "_syncRoot");
			NameObjectCollectionBase.NativeFieldInfoPtr_defaultComparer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NameObjectCollectionBase>.NativeClassPtr, "defaultComparer");
			NameObjectCollectionBase.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NameObjectCollectionBase>.NativeClassPtr, 100666560);
			NameObjectCollectionBase.NativeMethodInfoPtr__ctor_Protected_Void_IEqualityComparer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NameObjectCollectionBase>.NativeClassPtr, 100666561);
			NameObjectCollectionBase.NativeMethodInfoPtr__ctor_Protected_Void_Int32_IEqualityComparer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NameObjectCollectionBase>.NativeClassPtr, 100666562);
			NameObjectCollectionBase.NativeMethodInfoPtr__ctor_Protected_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NameObjectCollectionBase>.NativeClassPtr, 100666563);
			NameObjectCollectionBase.NativeMethodInfoPtr__ctor_Internal_Void_DBNull_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NameObjectCollectionBase>.NativeClassPtr, 100666564);
			NameObjectCollectionBase.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NameObjectCollectionBase>.NativeClassPtr, 100666565);
			NameObjectCollectionBase.NativeMethodInfoPtr_GetObjectData_Public_Virtual_New_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NameObjectCollectionBase>.NativeClassPtr, 100666566);
			NameObjectCollectionBase.NativeMethodInfoPtr_OnDeserialization_Public_Virtual_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NameObjectCollectionBase>.NativeClassPtr, 100666567);
			NameObjectCollectionBase.NativeMethodInfoPtr_Reset_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NameObjectCollectionBase>.NativeClassPtr, 100666568);
			NameObjectCollectionBase.NativeMethodInfoPtr_Reset_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NameObjectCollectionBase>.NativeClassPtr, 100666569);
			NameObjectCollectionBase.NativeMethodInfoPtr_FindEntry_Private_NameObjectEntry_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NameObjectCollectionBase>.NativeClassPtr, 100666570);
			NameObjectCollectionBase.NativeMethodInfoPtr_get_IsReadOnly_Protected_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NameObjectCollectionBase>.NativeClassPtr, 100666571);
			NameObjectCollectionBase.NativeMethodInfoPtr_BaseAdd_Protected_Void_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NameObjectCollectionBase>.NativeClassPtr, 100666572);
			NameObjectCollectionBase.NativeMethodInfoPtr_BaseRemove_Protected_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NameObjectCollectionBase>.NativeClassPtr, 100666573);
			NameObjectCollectionBase.NativeMethodInfoPtr_BaseGet_Protected_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NameObjectCollectionBase>.NativeClassPtr, 100666574);
			NameObjectCollectionBase.NativeMethodInfoPtr_BaseSet_Protected_Void_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NameObjectCollectionBase>.NativeClassPtr, 100666575);
			NameObjectCollectionBase.NativeMethodInfoPtr_BaseGet_Protected_Object_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NameObjectCollectionBase>.NativeClassPtr, 100666576);
			NameObjectCollectionBase.NativeMethodInfoPtr_BaseGetKey_Protected_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NameObjectCollectionBase>.NativeClassPtr, 100666577);
			NameObjectCollectionBase.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NameObjectCollectionBase>.NativeClassPtr, 100666578);
			NameObjectCollectionBase.NativeMethodInfoPtr_get_Count_Public_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NameObjectCollectionBase>.NativeClassPtr, 100666579);
			NameObjectCollectionBase.NativeMethodInfoPtr_System_Collections_ICollection_CopyTo_Private_Virtual_Final_New_Void_Array_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NameObjectCollectionBase>.NativeClassPtr, 100666580);
			NameObjectCollectionBase.NativeMethodInfoPtr_System_Collections_ICollection_get_SyncRoot_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NameObjectCollectionBase>.NativeClassPtr, 100666581);
			NameObjectCollectionBase.NativeMethodInfoPtr_System_Collections_ICollection_get_IsSynchronized_Private_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NameObjectCollectionBase>.NativeClassPtr, 100666582);
			NameObjectCollectionBase.NativeMethodInfoPtr_BaseGetAllKeys_Protected_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NameObjectCollectionBase>.NativeClassPtr, 100666583);
		}

		// Token: 0x0600156F RID: 5487 RVA: 0x0006FC7C File Offset: 0x0006DE7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 467120, XrefRangeEnd = 467125, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NameObjectCollectionBase()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NameObjectCollectionBase>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NameObjectCollectionBase.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001570 RID: 5488 RVA: 0x0006FCB8 File Offset: 0x0006DEB8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 467144, RefRangeEnd = 467148, XrefRangeStart = 467125, XrefRangeEnd = 467144, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NameObjectCollectionBase(IEqualityComparer equalityComparer)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NameObjectCollectionBase>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(equalityComparer);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NameObjectCollectionBase.NativeMethodInfoPtr__ctor_Protected_Void_IEqualityComparer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001571 RID: 5489 RVA: 0x0006FD04 File Offset: 0x0006DF04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 467148, XrefRangeEnd = 467150, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NameObjectCollectionBase(int capacity, IEqualityComparer equalityComparer)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NameObjectCollectionBase>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref capacity;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(equalityComparer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NameObjectCollectionBase.NativeMethodInfoPtr__ctor_Protected_Void_Int32_IEqualityComparer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001572 RID: 5490 RVA: 0x0006FD60 File Offset: 0x0006DF60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 467150, XrefRangeEnd = 467160, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NameObjectCollectionBase(int capacity)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NameObjectCollectionBase>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref capacity;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NameObjectCollectionBase.NativeMethodInfoPtr__ctor_Protected_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001573 RID: 5491 RVA: 0x0006FDA8 File Offset: 0x0006DFA8
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NameObjectCollectionBase(DBNull dummy)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NameObjectCollectionBase>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(dummy);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NameObjectCollectionBase.NativeMethodInfoPtr__ctor_Internal_Void_DBNull_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001574 RID: 5492 RVA: 0x0006FDF4 File Offset: 0x0006DFF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NameObjectCollectionBase(SerializationInfo info, StreamingContext context)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NameObjectCollectionBase>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NameObjectCollectionBase.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001575 RID: 5493 RVA: 0x0006FE58 File Offset: 0x0006E058
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 467160, XrefRangeEnd = 467285, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NameObjectCollectionBase.NativeMethodInfoPtr_GetObjectData_Public_Virtual_New_Void_SerializationInfo_StreamingContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001576 RID: 5494 RVA: 0x0006FEBC File Offset: 0x0006E0BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 467285, XrefRangeEnd = 467396, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnDeserialization(Object sender)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sender);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NameObjectCollectionBase.NativeMethodInfoPtr_OnDeserialization_Public_Virtual_New_Void_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001577 RID: 5495 RVA: 0x0006FF0C File Offset: 0x0006E10C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 467396, XrefRangeEnd = 467409, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NameObjectCollectionBase.NativeMethodInfoPtr_Reset_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001578 RID: 5496 RVA: 0x0006FF40 File Offset: 0x0006E140
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 467422, RefRangeEnd = 467427, XrefRangeStart = 467409, XrefRangeEnd = 467422, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Reset(int capacity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref capacity;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NameObjectCollectionBase.NativeMethodInfoPtr_Reset_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001579 RID: 5497 RVA: 0x0006FF80 File Offset: 0x0006E180
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 467429, RefRangeEnd = 467435, XrefRangeStart = 467427, XrefRangeEnd = 467429, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NameObjectCollectionBase.NameObjectEntry FindEntry(string key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NameObjectCollectionBase.NativeMethodInfoPtr_FindEntry_Private_NameObjectEntry_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<NameObjectCollectionBase.NameObjectEntry>(intPtr3) : null;
			}
		}

		// Token: 0x17000654 RID: 1620
		// (get) Token: 0x0600157A RID: 5498 RVA: 0x0006FFD0 File Offset: 0x0006E1D0
		public unsafe bool IsReadOnly
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NameObjectCollectionBase.NativeMethodInfoPtr_get_IsReadOnly_Protected_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600157B RID: 5499 RVA: 0x0007000C File Offset: 0x0006E20C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 467447, RefRangeEnd = 467450, XrefRangeStart = 467435, XrefRangeEnd = 467447, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BaseAdd(string name, Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NameObjectCollectionBase.NativeMethodInfoPtr_BaseAdd_Protected_Void_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600157C RID: 5500 RVA: 0x00070060 File Offset: 0x0006E260
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 467459, RefRangeEnd = 467460, XrefRangeStart = 467450, XrefRangeEnd = 467459, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BaseRemove(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NameObjectCollectionBase.NativeMethodInfoPtr_BaseRemove_Protected_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600157D RID: 5501 RVA: 0x000700A4 File Offset: 0x0006E2A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 467460, XrefRangeEnd = 467461, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object BaseGet(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NameObjectCollectionBase.NativeMethodInfoPtr_BaseGet_Protected_Object_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x0600157E RID: 5502 RVA: 0x000700F4 File Offset: 0x0006E2F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 467461, XrefRangeEnd = 467464, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BaseSet(string name, Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NameObjectCollectionBase.NativeMethodInfoPtr_BaseSet_Protected_Void_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600157F RID: 5503 RVA: 0x00070148 File Offset: 0x0006E348
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 467466, RefRangeEnd = 467468, XrefRangeStart = 467464, XrefRangeEnd = 467466, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object BaseGet(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NameObjectCollectionBase.NativeMethodInfoPtr_BaseGet_Protected_Object_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06001580 RID: 5504 RVA: 0x00070194 File Offset: 0x0006E394
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 467470, RefRangeEnd = 467474, XrefRangeStart = 467468, XrefRangeEnd = 467470, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string BaseGetKey(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NameObjectCollectionBase.NativeMethodInfoPtr_BaseGetKey_Protected_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06001581 RID: 5505 RVA: 0x000701D8 File Offset: 0x0006E3D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 467474, XrefRangeEnd = 467479, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerator GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NameObjectCollectionBase.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_New_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x17000655 RID: 1621
		// (get) Token: 0x06001582 RID: 5506 RVA: 0x00070224 File Offset: 0x0006E424
		public unsafe virtual int Count
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 467480, RefRangeEnd = 467481, XrefRangeStart = 467479, XrefRangeEnd = 467480, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NameObjectCollectionBase.NativeMethodInfoPtr_get_Count_Public_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001583 RID: 5507 RVA: 0x0007026C File Offset: 0x0006E46C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 467481, XrefRangeEnd = 467491, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void System_Collections_ICollection_CopyTo(Array array, int index)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NameObjectCollectionBase.NativeMethodInfoPtr_System_Collections_ICollection_CopyTo_Private_Virtual_Final_New_Void_Array_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000656 RID: 1622
		// (get) Token: 0x06001584 RID: 5508 RVA: 0x000702BC File Offset: 0x0006E4BC
		public unsafe virtual Object System.Collections.ICollection.SyncRoot
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 467491, XrefRangeEnd = 467496, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NameObjectCollectionBase.NativeMethodInfoPtr_System_Collections_ICollection_get_SyncRoot_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x17000657 RID: 1623
		// (get) Token: 0x06001585 RID: 5509 RVA: 0x000702FC File Offset: 0x0006E4FC
		public unsafe virtual bool System.Collections.ICollection.IsSynchronized
		{
			[CallerCount(184)]
			[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NameObjectCollectionBase.NativeMethodInfoPtr_System_Collections_ICollection_get_IsSynchronized_Private_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001586 RID: 5510 RVA: 0x00070338 File Offset: 0x0006E538
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 467496, XrefRangeEnd = 467502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStringArray BaseGetAllKeys()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NameObjectCollectionBase.NativeMethodInfoPtr_BaseGetAllKeys_Protected_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
		}

		// Token: 0x06001587 RID: 5511 RVA: 0x00009683 File Offset: 0x00007883
		public NameObjectCollectionBase(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000642 RID: 1602
		// (get) Token: 0x06001588 RID: 5512 RVA: 0x00070378 File Offset: 0x0006E578
		// (set) Token: 0x06001589 RID: 5513 RVA: 0x0000968C File Offset: 0x0000788C
		public unsafe static string ReadOnlyName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(NameObjectCollectionBase.NativeFieldInfoPtr_ReadOnlyName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NameObjectCollectionBase.NativeFieldInfoPtr_ReadOnlyName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000643 RID: 1603
		// (get) Token: 0x0600158A RID: 5514 RVA: 0x00070398 File Offset: 0x0006E598
		// (set) Token: 0x0600158B RID: 5515 RVA: 0x0000969E File Offset: 0x0000789E
		public unsafe static string CountName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(NameObjectCollectionBase.NativeFieldInfoPtr_CountName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NameObjectCollectionBase.NativeFieldInfoPtr_CountName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000644 RID: 1604
		// (get) Token: 0x0600158C RID: 5516 RVA: 0x000703B8 File Offset: 0x0006E5B8
		// (set) Token: 0x0600158D RID: 5517 RVA: 0x000096B0 File Offset: 0x000078B0
		public unsafe static string ComparerName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(NameObjectCollectionBase.NativeFieldInfoPtr_ComparerName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NameObjectCollectionBase.NativeFieldInfoPtr_ComparerName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000645 RID: 1605
		// (get) Token: 0x0600158E RID: 5518 RVA: 0x000703D8 File Offset: 0x0006E5D8
		// (set) Token: 0x0600158F RID: 5519 RVA: 0x000096C2 File Offset: 0x000078C2
		public unsafe static string HashCodeProviderName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(NameObjectCollectionBase.NativeFieldInfoPtr_HashCodeProviderName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NameObjectCollectionBase.NativeFieldInfoPtr_HashCodeProviderName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000646 RID: 1606
		// (get) Token: 0x06001590 RID: 5520 RVA: 0x000703F8 File Offset: 0x0006E5F8
		// (set) Token: 0x06001591 RID: 5521 RVA: 0x000096D4 File Offset: 0x000078D4
		public unsafe static string KeysName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(NameObjectCollectionBase.NativeFieldInfoPtr_KeysName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NameObjectCollectionBase.NativeFieldInfoPtr_KeysName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000647 RID: 1607
		// (get) Token: 0x06001592 RID: 5522 RVA: 0x00070418 File Offset: 0x0006E618
		// (set) Token: 0x06001593 RID: 5523 RVA: 0x000096E6 File Offset: 0x000078E6
		public unsafe static string ValuesName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(NameObjectCollectionBase.NativeFieldInfoPtr_ValuesName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NameObjectCollectionBase.NativeFieldInfoPtr_ValuesName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000648 RID: 1608
		// (get) Token: 0x06001594 RID: 5524 RVA: 0x00070438 File Offset: 0x0006E638
		// (set) Token: 0x06001595 RID: 5525 RVA: 0x000096F8 File Offset: 0x000078F8
		public unsafe static string KeyComparerName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(NameObjectCollectionBase.NativeFieldInfoPtr_KeyComparerName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NameObjectCollectionBase.NativeFieldInfoPtr_KeyComparerName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000649 RID: 1609
		// (get) Token: 0x06001596 RID: 5526 RVA: 0x00070458 File Offset: 0x0006E658
		// (set) Token: 0x06001597 RID: 5527 RVA: 0x0000970A File Offset: 0x0000790A
		public unsafe static string VersionName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(NameObjectCollectionBase.NativeFieldInfoPtr_VersionName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NameObjectCollectionBase.NativeFieldInfoPtr_VersionName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700064A RID: 1610
		// (get) Token: 0x06001598 RID: 5528 RVA: 0x00070478 File Offset: 0x0006E678
		// (set) Token: 0x06001599 RID: 5529 RVA: 0x0000971C File Offset: 0x0000791C
		public unsafe bool _readOnly
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NameObjectCollectionBase.NativeFieldInfoPtr__readOnly);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NameObjectCollectionBase.NativeFieldInfoPtr__readOnly)) = value;
			}
		}

		// Token: 0x1700064B RID: 1611
		// (get) Token: 0x0600159A RID: 5530 RVA: 0x000704A0 File Offset: 0x0006E6A0
		// (set) Token: 0x0600159B RID: 5531 RVA: 0x00009737 File Offset: 0x00007937
		public unsafe ArrayList _entriesArray
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NameObjectCollectionBase.NativeFieldInfoPtr__entriesArray);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArrayList>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NameObjectCollectionBase.NativeFieldInfoPtr__entriesArray), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700064C RID: 1612
		// (get) Token: 0x0600159C RID: 5532 RVA: 0x000704D0 File Offset: 0x0006E6D0
		// (set) Token: 0x0600159D RID: 5533 RVA: 0x00009756 File Offset: 0x00007956
		public unsafe IEqualityComparer _keyComparer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NameObjectCollectionBase.NativeFieldInfoPtr__keyComparer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEqualityComparer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NameObjectCollectionBase.NativeFieldInfoPtr__keyComparer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700064D RID: 1613
		// (get) Token: 0x0600159E RID: 5534 RVA: 0x00070500 File Offset: 0x0006E700
		// (set) Token: 0x0600159F RID: 5535 RVA: 0x00009775 File Offset: 0x00007975
		public unsafe Hashtable _entriesTable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NameObjectCollectionBase.NativeFieldInfoPtr__entriesTable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NameObjectCollectionBase.NativeFieldInfoPtr__entriesTable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700064E RID: 1614
		// (get) Token: 0x060015A0 RID: 5536 RVA: 0x00070530 File Offset: 0x0006E730
		// (set) Token: 0x060015A1 RID: 5537 RVA: 0x00009794 File Offset: 0x00007994
		public unsafe NameObjectCollectionBase.NameObjectEntry _nullKeyEntry
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NameObjectCollectionBase.NativeFieldInfoPtr__nullKeyEntry);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NameObjectCollectionBase.NameObjectEntry>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NameObjectCollectionBase.NativeFieldInfoPtr__nullKeyEntry), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700064F RID: 1615
		// (get) Token: 0x060015A2 RID: 5538 RVA: 0x00070560 File Offset: 0x0006E760
		// (set) Token: 0x060015A3 RID: 5539 RVA: 0x000097B3 File Offset: 0x000079B3
		public unsafe NameObjectCollectionBase.KeysCollection _keys
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NameObjectCollectionBase.NativeFieldInfoPtr__keys);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NameObjectCollectionBase.KeysCollection>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NameObjectCollectionBase.NativeFieldInfoPtr__keys), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000650 RID: 1616
		// (get) Token: 0x060015A4 RID: 5540 RVA: 0x00070590 File Offset: 0x0006E790
		// (set) Token: 0x060015A5 RID: 5541 RVA: 0x000097D2 File Offset: 0x000079D2
		public unsafe SerializationInfo _serializationInfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NameObjectCollectionBase.NativeFieldInfoPtr__serializationInfo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SerializationInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NameObjectCollectionBase.NativeFieldInfoPtr__serializationInfo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000651 RID: 1617
		// (get) Token: 0x060015A6 RID: 5542 RVA: 0x000705C0 File Offset: 0x0006E7C0
		// (set) Token: 0x060015A7 RID: 5543 RVA: 0x000097F1 File Offset: 0x000079F1
		public unsafe int _version
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NameObjectCollectionBase.NativeFieldInfoPtr__version);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NameObjectCollectionBase.NativeFieldInfoPtr__version)) = value;
			}
		}

		// Token: 0x17000652 RID: 1618
		// (get) Token: 0x060015A8 RID: 5544 RVA: 0x000705E8 File Offset: 0x0006E7E8
		// (set) Token: 0x060015A9 RID: 5545 RVA: 0x0000980C File Offset: 0x00007A0C
		public unsafe Object _syncRoot
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NameObjectCollectionBase.NativeFieldInfoPtr__syncRoot);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NameObjectCollectionBase.NativeFieldInfoPtr__syncRoot), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000653 RID: 1619
		// (get) Token: 0x060015AA RID: 5546 RVA: 0x00070618 File Offset: 0x0006E818
		// (set) Token: 0x060015AB RID: 5547 RVA: 0x0000982B File Offset: 0x00007A2B
		public unsafe static StringComparer defaultComparer
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(NameObjectCollectionBase.NativeFieldInfoPtr_defaultComparer, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StringComparer>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NameObjectCollectionBase.NativeFieldInfoPtr_defaultComparer, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040010CF RID: 4303
		private static readonly IntPtr NativeFieldInfoPtr_ReadOnlyName;

		// Token: 0x040010D0 RID: 4304
		private static readonly IntPtr NativeFieldInfoPtr_CountName;

		// Token: 0x040010D1 RID: 4305
		private static readonly IntPtr NativeFieldInfoPtr_ComparerName;

		// Token: 0x040010D2 RID: 4306
		private static readonly IntPtr NativeFieldInfoPtr_HashCodeProviderName;

		// Token: 0x040010D3 RID: 4307
		private static readonly IntPtr NativeFieldInfoPtr_KeysName;

		// Token: 0x040010D4 RID: 4308
		private static readonly IntPtr NativeFieldInfoPtr_ValuesName;

		// Token: 0x040010D5 RID: 4309
		private static readonly IntPtr NativeFieldInfoPtr_KeyComparerName;

		// Token: 0x040010D6 RID: 4310
		private static readonly IntPtr NativeFieldInfoPtr_VersionName;

		// Token: 0x040010D7 RID: 4311
		private static readonly IntPtr NativeFieldInfoPtr__readOnly;

		// Token: 0x040010D8 RID: 4312
		private static readonly IntPtr NativeFieldInfoPtr__entriesArray;

		// Token: 0x040010D9 RID: 4313
		private static readonly IntPtr NativeFieldInfoPtr__keyComparer;

		// Token: 0x040010DA RID: 4314
		private static readonly IntPtr NativeFieldInfoPtr__entriesTable;

		// Token: 0x040010DB RID: 4315
		private static readonly IntPtr NativeFieldInfoPtr__nullKeyEntry;

		// Token: 0x040010DC RID: 4316
		private static readonly IntPtr NativeFieldInfoPtr__keys;

		// Token: 0x040010DD RID: 4317
		private static readonly IntPtr NativeFieldInfoPtr__serializationInfo;

		// Token: 0x040010DE RID: 4318
		private static readonly IntPtr NativeFieldInfoPtr__version;

		// Token: 0x040010DF RID: 4319
		private static readonly IntPtr NativeFieldInfoPtr__syncRoot;

		// Token: 0x040010E0 RID: 4320
		private static readonly IntPtr NativeFieldInfoPtr_defaultComparer;

		// Token: 0x040010E1 RID: 4321
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x040010E2 RID: 4322
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_IEqualityComparer_0;

		// Token: 0x040010E3 RID: 4323
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_Int32_IEqualityComparer_0;

		// Token: 0x040010E4 RID: 4324
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_Int32_0;

		// Token: 0x040010E5 RID: 4325
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_DBNull_0;

		// Token: 0x040010E6 RID: 4326
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x040010E7 RID: 4327
		private static readonly IntPtr NativeMethodInfoPtr_GetObjectData_Public_Virtual_New_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x040010E8 RID: 4328
		private static readonly IntPtr NativeMethodInfoPtr_OnDeserialization_Public_Virtual_New_Void_Object_0;

		// Token: 0x040010E9 RID: 4329
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Private_Void_0;

		// Token: 0x040010EA RID: 4330
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Private_Void_Int32_0;

		// Token: 0x040010EB RID: 4331
		private static readonly IntPtr NativeMethodInfoPtr_FindEntry_Private_NameObjectEntry_String_0;

		// Token: 0x040010EC RID: 4332
		private static readonly IntPtr NativeMethodInfoPtr_get_IsReadOnly_Protected_get_Boolean_0;

		// Token: 0x040010ED RID: 4333
		private static readonly IntPtr NativeMethodInfoPtr_BaseAdd_Protected_Void_String_Object_0;

		// Token: 0x040010EE RID: 4334
		private static readonly IntPtr NativeMethodInfoPtr_BaseRemove_Protected_Void_String_0;

		// Token: 0x040010EF RID: 4335
		private static readonly IntPtr NativeMethodInfoPtr_BaseGet_Protected_Object_String_0;

		// Token: 0x040010F0 RID: 4336
		private static readonly IntPtr NativeMethodInfoPtr_BaseSet_Protected_Void_String_Object_0;

		// Token: 0x040010F1 RID: 4337
		private static readonly IntPtr NativeMethodInfoPtr_BaseGet_Protected_Object_Int32_0;

		// Token: 0x040010F2 RID: 4338
		private static readonly IntPtr NativeMethodInfoPtr_BaseGetKey_Protected_String_Int32_0;

		// Token: 0x040010F3 RID: 4339
		private static readonly IntPtr NativeMethodInfoPtr_GetEnumerator_Public_Virtual_New_IEnumerator_0;

		// Token: 0x040010F4 RID: 4340
		private static readonly IntPtr NativeMethodInfoPtr_get_Count_Public_Virtual_New_get_Int32_0;

		// Token: 0x040010F5 RID: 4341
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_ICollection_CopyTo_Private_Virtual_Final_New_Void_Array_Int32_0;

		// Token: 0x040010F6 RID: 4342
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_ICollection_get_SyncRoot_Private_Virtual_Final_New_get_Object_0;

		// Token: 0x040010F7 RID: 4343
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_ICollection_get_IsSynchronized_Private_Virtual_Final_New_get_Boolean_0;

		// Token: 0x040010F8 RID: 4344
		private static readonly IntPtr NativeMethodInfoPtr_BaseGetAllKeys_Protected_Il2CppStringArray_0;

		// Token: 0x020002F3 RID: 755
		public class NameObjectEntry : Object
		{
			// Token: 0x06002D14 RID: 11540 RVA: 0x000C5FD0 File Offset: 0x000C41D0
			// Note: this type is marked as 'beforefieldinit'.
			static NameObjectEntry()
			{
				Il2CppClassPointerStore<NameObjectCollectionBase.NameObjectEntry>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NameObjectCollectionBase>.NativeClassPtr, "NameObjectEntry");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NameObjectCollectionBase.NameObjectEntry>.NativeClassPtr);
				NameObjectCollectionBase.NameObjectEntry.NativeFieldInfoPtr_Key = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NameObjectCollectionBase.NameObjectEntry>.NativeClassPtr, "Key");
				NameObjectCollectionBase.NameObjectEntry.NativeFieldInfoPtr_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NameObjectCollectionBase.NameObjectEntry>.NativeClassPtr, "Value");
				NameObjectCollectionBase.NameObjectEntry.NativeMethodInfoPtr__ctor_Internal_Void_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NameObjectCollectionBase.NameObjectEntry>.NativeClassPtr, 100666585);
			}

			// Token: 0x06002D15 RID: 11541 RVA: 0x000C6038 File Offset: 0x000C4238
			[CallerCount(54)]
			[CachedScanResults(RefRangeStart = 296744, RefRangeEnd = 296798, XrefRangeStart = 296744, XrefRangeEnd = 296798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe NameObjectEntry(string name, Object value)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NameObjectCollectionBase.NameObjectEntry>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NameObjectCollectionBase.NameObjectEntry.NativeMethodInfoPtr__ctor_Internal_Void_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002D16 RID: 11542 RVA: 0x0001448C File Offset: 0x0001268C
			public NameObjectEntry(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000E24 RID: 3620
			// (get) Token: 0x06002D17 RID: 11543 RVA: 0x000C6098 File Offset: 0x000C4298
			// (set) Token: 0x06002D18 RID: 11544 RVA: 0x00014495 File Offset: 0x00012695
			public unsafe string Key
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NameObjectCollectionBase.NameObjectEntry.NativeFieldInfoPtr_Key);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NameObjectCollectionBase.NameObjectEntry.NativeFieldInfoPtr_Key), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000E25 RID: 3621
			// (get) Token: 0x06002D19 RID: 11545 RVA: 0x000C60C0 File Offset: 0x000C42C0
			// (set) Token: 0x06002D1A RID: 11546 RVA: 0x000144B4 File Offset: 0x000126B4
			public unsafe Object Value
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NameObjectCollectionBase.NameObjectEntry.NativeFieldInfoPtr_Value);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NameObjectCollectionBase.NameObjectEntry.NativeFieldInfoPtr_Value), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400237B RID: 9083
			private static readonly IntPtr NativeFieldInfoPtr_Key;

			// Token: 0x0400237C RID: 9084
			private static readonly IntPtr NativeFieldInfoPtr_Value;

			// Token: 0x0400237D RID: 9085
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_String_Object_0;
		}

		// Token: 0x020002F4 RID: 756
		[Serializable]
		public class NameObjectKeysEnumerator : Object
		{
			// Token: 0x06002D1B RID: 11547 RVA: 0x000C60F0 File Offset: 0x000C42F0
			// Note: this type is marked as 'beforefieldinit'.
			static NameObjectKeysEnumerator()
			{
				Il2CppClassPointerStore<NameObjectCollectionBase.NameObjectKeysEnumerator>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NameObjectCollectionBase>.NativeClassPtr, "NameObjectKeysEnumerator");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NameObjectCollectionBase.NameObjectKeysEnumerator>.NativeClassPtr);
				NameObjectCollectionBase.NameObjectKeysEnumerator.NativeFieldInfoPtr__pos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NameObjectCollectionBase.NameObjectKeysEnumerator>.NativeClassPtr, "_pos");
				NameObjectCollectionBase.NameObjectKeysEnumerator.NativeFieldInfoPtr__coll = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NameObjectCollectionBase.NameObjectKeysEnumerator>.NativeClassPtr, "_coll");
				NameObjectCollectionBase.NameObjectKeysEnumerator.NativeFieldInfoPtr__version = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NameObjectCollectionBase.NameObjectKeysEnumerator>.NativeClassPtr, "_version");
				NameObjectCollectionBase.NameObjectKeysEnumerator.NativeMethodInfoPtr__ctor_Internal_Void_NameObjectCollectionBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NameObjectCollectionBase.NameObjectKeysEnumerator>.NativeClassPtr, 100666586);
				NameObjectCollectionBase.NameObjectKeysEnumerator.NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NameObjectCollectionBase.NameObjectKeysEnumerator>.NativeClassPtr, 100666587);
				NameObjectCollectionBase.NameObjectKeysEnumerator.NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NameObjectCollectionBase.NameObjectKeysEnumerator>.NativeClassPtr, 100666588);
				NameObjectCollectionBase.NameObjectKeysEnumerator.NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NameObjectCollectionBase.NameObjectKeysEnumerator>.NativeClassPtr, 100666589);
			}

			// Token: 0x06002D1C RID: 11548 RVA: 0x000C61A8 File Offset: 0x000C43A8
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 467083, RefRangeEnd = 467084, XrefRangeStart = 467081, XrefRangeEnd = 467083, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe NameObjectKeysEnumerator(NameObjectCollectionBase coll)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NameObjectCollectionBase.NameObjectKeysEnumerator>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(coll);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NameObjectCollectionBase.NameObjectKeysEnumerator.NativeMethodInfoPtr__ctor_Internal_Void_NameObjectCollectionBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002D1D RID: 11549 RVA: 0x000C61F4 File Offset: 0x000C43F4
			[CallerCount(0)]
			public unsafe virtual bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NameObjectCollectionBase.NameObjectKeysEnumerator.NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06002D1E RID: 11550 RVA: 0x000C6230 File Offset: 0x000C4430
			[CallerCount(0)]
			public unsafe virtual void Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NameObjectCollectionBase.NameObjectKeysEnumerator.NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000E29 RID: 3625
			// (get) Token: 0x06002D1F RID: 11551 RVA: 0x000C6264 File Offset: 0x000C4464
			public unsafe virtual Object Current
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 467084, XrefRangeEnd = 467093, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NameObjectCollectionBase.NameObjectKeysEnumerator.NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002D20 RID: 11552 RVA: 0x000144D3 File Offset: 0x000126D3
			public NameObjectKeysEnumerator(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000E26 RID: 3622
			// (get) Token: 0x06002D21 RID: 11553 RVA: 0x000C62A4 File Offset: 0x000C44A4
			// (set) Token: 0x06002D22 RID: 11554 RVA: 0x000144DC File Offset: 0x000126DC
			public unsafe int _pos
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NameObjectCollectionBase.NameObjectKeysEnumerator.NativeFieldInfoPtr__pos);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NameObjectCollectionBase.NameObjectKeysEnumerator.NativeFieldInfoPtr__pos)) = value;
				}
			}

			// Token: 0x17000E27 RID: 3623
			// (get) Token: 0x06002D23 RID: 11555 RVA: 0x000C62CC File Offset: 0x000C44CC
			// (set) Token: 0x06002D24 RID: 11556 RVA: 0x000144F7 File Offset: 0x000126F7
			public unsafe NameObjectCollectionBase _coll
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NameObjectCollectionBase.NameObjectKeysEnumerator.NativeFieldInfoPtr__coll);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NameObjectCollectionBase>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NameObjectCollectionBase.NameObjectKeysEnumerator.NativeFieldInfoPtr__coll), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000E28 RID: 3624
			// (get) Token: 0x06002D25 RID: 11557 RVA: 0x000C62FC File Offset: 0x000C44FC
			// (set) Token: 0x06002D26 RID: 11558 RVA: 0x00014516 File Offset: 0x00012716
			public unsafe int _version
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NameObjectCollectionBase.NameObjectKeysEnumerator.NativeFieldInfoPtr__version);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NameObjectCollectionBase.NameObjectKeysEnumerator.NativeFieldInfoPtr__version)) = value;
				}
			}

			// Token: 0x0400237E RID: 9086
			private static readonly IntPtr NativeFieldInfoPtr__pos;

			// Token: 0x0400237F RID: 9087
			private static readonly IntPtr NativeFieldInfoPtr__coll;

			// Token: 0x04002380 RID: 9088
			private static readonly IntPtr NativeFieldInfoPtr__version;

			// Token: 0x04002381 RID: 9089
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_NameObjectCollectionBase_0;

			// Token: 0x04002382 RID: 9090
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0;

			// Token: 0x04002383 RID: 9091
			private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0;

			// Token: 0x04002384 RID: 9092
			private static readonly IntPtr NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x020002F5 RID: 757
		[DefaultMember("Item")]
		[Serializable]
		public class KeysCollection : Object
		{
			// Token: 0x06002D27 RID: 11559 RVA: 0x000C6324 File Offset: 0x000C4524
			// Note: this type is marked as 'beforefieldinit'.
			static KeysCollection()
			{
				Il2CppClassPointerStore<NameObjectCollectionBase.KeysCollection>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NameObjectCollectionBase>.NativeClassPtr, "KeysCollection");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NameObjectCollectionBase.KeysCollection>.NativeClassPtr);
				NameObjectCollectionBase.KeysCollection.NativeFieldInfoPtr__coll = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NameObjectCollectionBase.KeysCollection>.NativeClassPtr, "_coll");
				NameObjectCollectionBase.KeysCollection.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NameObjectCollectionBase.KeysCollection>.NativeClassPtr, 100666590);
				NameObjectCollectionBase.KeysCollection.NativeMethodInfoPtr_get_Count_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NameObjectCollectionBase.KeysCollection>.NativeClassPtr, 100666591);
				NameObjectCollectionBase.KeysCollection.NativeMethodInfoPtr_System_Collections_ICollection_CopyTo_Private_Virtual_Final_New_Void_Array_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NameObjectCollectionBase.KeysCollection>.NativeClassPtr, 100666592);
				NameObjectCollectionBase.KeysCollection.NativeMethodInfoPtr_System_Collections_ICollection_get_SyncRoot_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NameObjectCollectionBase.KeysCollection>.NativeClassPtr, 100666593);
				NameObjectCollectionBase.KeysCollection.NativeMethodInfoPtr_System_Collections_ICollection_get_IsSynchronized_Private_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NameObjectCollectionBase.KeysCollection>.NativeClassPtr, 100666594);
				NameObjectCollectionBase.KeysCollection.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NameObjectCollectionBase.KeysCollection>.NativeClassPtr, 100666595);
			}

			// Token: 0x06002D28 RID: 11560 RVA: 0x000C63DC File Offset: 0x000C45DC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 467093, XrefRangeEnd = 467098, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual IEnumerator GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NameObjectCollectionBase.KeysCollection.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x17000E2B RID: 3627
			// (get) Token: 0x06002D29 RID: 11561 RVA: 0x000C641C File Offset: 0x000C461C
			public unsafe virtual int Count
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NameObjectCollectionBase.KeysCollection.NativeMethodInfoPtr_get_Count_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06002D2A RID: 11562 RVA: 0x000C6458 File Offset: 0x000C4658
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 467098, XrefRangeEnd = 467113, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual void System_Collections_ICollection_CopyTo(Array array, int index)
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NameObjectCollectionBase.KeysCollection.NativeMethodInfoPtr_System_Collections_ICollection_CopyTo_Private_Virtual_Final_New_Void_Array_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000E2C RID: 3628
			// (get) Token: 0x06002D2B RID: 11563 RVA: 0x000C64A8 File Offset: 0x000C46A8
			public unsafe virtual Object System.Collections.ICollection.SyncRoot
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 467113, XrefRangeEnd = 467117, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NameObjectCollectionBase.KeysCollection.NativeMethodInfoPtr_System_Collections_ICollection_get_SyncRoot_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x17000E2D RID: 3629
			// (get) Token: 0x06002D2C RID: 11564 RVA: 0x000C64E8 File Offset: 0x000C46E8
			public unsafe virtual bool System.Collections.ICollection.IsSynchronized
			{
				[CallerCount(184)]
				[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NameObjectCollectionBase.KeysCollection.NativeMethodInfoPtr_System_Collections_ICollection_get_IsSynchronized_Private_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06002D2D RID: 11565 RVA: 0x000C6524 File Offset: 0x000C4724
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 467117, XrefRangeEnd = 467120, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe KeysCollection()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NameObjectCollectionBase.KeysCollection>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NameObjectCollectionBase.KeysCollection.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002D2E RID: 11566 RVA: 0x00014531 File Offset: 0x00012731
			public KeysCollection(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000E2A RID: 3626
			// (get) Token: 0x06002D2F RID: 11567 RVA: 0x000C6560 File Offset: 0x000C4760
			// (set) Token: 0x06002D30 RID: 11568 RVA: 0x0001453A File Offset: 0x0001273A
			public unsafe NameObjectCollectionBase _coll
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NameObjectCollectionBase.KeysCollection.NativeFieldInfoPtr__coll);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NameObjectCollectionBase>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NameObjectCollectionBase.KeysCollection.NativeFieldInfoPtr__coll), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002385 RID: 9093
			private static readonly IntPtr NativeFieldInfoPtr__coll;

			// Token: 0x04002386 RID: 9094
			private static readonly IntPtr NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_0;

			// Token: 0x04002387 RID: 9095
			private static readonly IntPtr NativeMethodInfoPtr_get_Count_Public_Virtual_Final_New_get_Int32_0;

			// Token: 0x04002388 RID: 9096
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_ICollection_CopyTo_Private_Virtual_Final_New_Void_Array_Int32_0;

			// Token: 0x04002389 RID: 9097
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_ICollection_get_SyncRoot_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400238A RID: 9098
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_ICollection_get_IsSynchronized_Private_Virtual_Final_New_get_Boolean_0;

			// Token: 0x0400238B RID: 9099
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;
		}
	}
}
