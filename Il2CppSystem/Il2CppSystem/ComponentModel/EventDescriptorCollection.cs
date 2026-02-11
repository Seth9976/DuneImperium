using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;

namespace Il2CppSystem.ComponentModel
{
	// Token: 0x0200010B RID: 267
	public class EventDescriptorCollection : Object
	{
		// Token: 0x0600109B RID: 4251 RVA: 0x0005AF78 File Offset: 0x00059178
		// Note: this type is marked as 'beforefieldinit'.
		static EventDescriptorCollection()
		{
			Il2CppClassPointerStore<EventDescriptorCollection>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.ComponentModel", "EventDescriptorCollection");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EventDescriptorCollection>.NativeClassPtr);
			EventDescriptorCollection.NativeFieldInfoPtr__events = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventDescriptorCollection>.NativeClassPtr, "_events");
			EventDescriptorCollection.NativeFieldInfoPtr__namedSort = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventDescriptorCollection>.NativeClassPtr, "_namedSort");
			EventDescriptorCollection.NativeFieldInfoPtr__comparer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventDescriptorCollection>.NativeClassPtr, "_comparer");
			EventDescriptorCollection.NativeFieldInfoPtr__eventsOwned = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventDescriptorCollection>.NativeClassPtr, "_eventsOwned");
			EventDescriptorCollection.NativeFieldInfoPtr__needSort = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventDescriptorCollection>.NativeClassPtr, "_needSort");
			EventDescriptorCollection.NativeFieldInfoPtr__readOnly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventDescriptorCollection>.NativeClassPtr, "_readOnly");
			EventDescriptorCollection.NativeFieldInfoPtr_Empty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventDescriptorCollection>.NativeClassPtr, "Empty");
			EventDescriptorCollection.NativeFieldInfoPtr__Count_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventDescriptorCollection>.NativeClassPtr, "<Count>k__BackingField");
			EventDescriptorCollection.NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_EventDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventDescriptorCollection>.NativeClassPtr, 100665693);
			EventDescriptorCollection.NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_EventDescriptor_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventDescriptorCollection>.NativeClassPtr, 100665694);
			EventDescriptorCollection.NativeMethodInfoPtr_get_Count_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventDescriptorCollection>.NativeClassPtr, 100665695);
			EventDescriptorCollection.NativeMethodInfoPtr_set_Count_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventDescriptorCollection>.NativeClassPtr, 100665696);
			EventDescriptorCollection.NativeMethodInfoPtr_get_Item_Public_Virtual_New_get_EventDescriptor_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventDescriptorCollection>.NativeClassPtr, 100665697);
			EventDescriptorCollection.NativeMethodInfoPtr_get_Item_Public_Virtual_New_get_EventDescriptor_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventDescriptorCollection>.NativeClassPtr, 100665698);
			EventDescriptorCollection.NativeMethodInfoPtr_Add_Public_Int32_EventDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventDescriptorCollection>.NativeClassPtr, 100665699);
			EventDescriptorCollection.NativeMethodInfoPtr_Clear_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventDescriptorCollection>.NativeClassPtr, 100665700);
			EventDescriptorCollection.NativeMethodInfoPtr_Contains_Public_Boolean_EventDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventDescriptorCollection>.NativeClassPtr, 100665701);
			EventDescriptorCollection.NativeMethodInfoPtr_System_Collections_ICollection_CopyTo_Private_Virtual_Final_New_Void_Array_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventDescriptorCollection>.NativeClassPtr, 100665702);
			EventDescriptorCollection.NativeMethodInfoPtr_EnsureEventsOwned_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventDescriptorCollection>.NativeClassPtr, 100665703);
			EventDescriptorCollection.NativeMethodInfoPtr_EnsureSize_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventDescriptorCollection>.NativeClassPtr, 100665704);
			EventDescriptorCollection.NativeMethodInfoPtr_Find_Public_Virtual_New_EventDescriptor_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventDescriptorCollection>.NativeClassPtr, 100665705);
			EventDescriptorCollection.NativeMethodInfoPtr_IndexOf_Public_Int32_EventDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventDescriptorCollection>.NativeClassPtr, 100665706);
			EventDescriptorCollection.NativeMethodInfoPtr_Insert_Public_Void_Int32_EventDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventDescriptorCollection>.NativeClassPtr, 100665707);
			EventDescriptorCollection.NativeMethodInfoPtr_Remove_Public_Void_EventDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventDescriptorCollection>.NativeClassPtr, 100665708);
			EventDescriptorCollection.NativeMethodInfoPtr_RemoveAt_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventDescriptorCollection>.NativeClassPtr, 100665709);
			EventDescriptorCollection.NativeMethodInfoPtr_GetEnumerator_Public_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventDescriptorCollection>.NativeClassPtr, 100665710);
			EventDescriptorCollection.NativeMethodInfoPtr_InternalSort_Protected_Void_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventDescriptorCollection>.NativeClassPtr, 100665711);
			EventDescriptorCollection.NativeMethodInfoPtr_InternalSort_Protected_Void_IComparer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventDescriptorCollection>.NativeClassPtr, 100665712);
			EventDescriptorCollection.NativeMethodInfoPtr_System_Collections_ICollection_get_IsSynchronized_Private_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventDescriptorCollection>.NativeClassPtr, 100665713);
			EventDescriptorCollection.NativeMethodInfoPtr_System_Collections_ICollection_get_SyncRoot_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventDescriptorCollection>.NativeClassPtr, 100665714);
			EventDescriptorCollection.NativeMethodInfoPtr_System_Collections_ICollection_get_Count_Private_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventDescriptorCollection>.NativeClassPtr, 100665715);
			EventDescriptorCollection.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventDescriptorCollection>.NativeClassPtr, 100665716);
			EventDescriptorCollection.NativeMethodInfoPtr_System_Collections_IList_get_Item_Private_Virtual_Final_New_get_Object_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventDescriptorCollection>.NativeClassPtr, 100665717);
			EventDescriptorCollection.NativeMethodInfoPtr_System_Collections_IList_set_Item_Private_Virtual_Final_New_set_Void_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventDescriptorCollection>.NativeClassPtr, 100665718);
			EventDescriptorCollection.NativeMethodInfoPtr_System_Collections_IList_Add_Private_Virtual_Final_New_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventDescriptorCollection>.NativeClassPtr, 100665719);
			EventDescriptorCollection.NativeMethodInfoPtr_System_Collections_IList_Contains_Private_Virtual_Final_New_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventDescriptorCollection>.NativeClassPtr, 100665720);
			EventDescriptorCollection.NativeMethodInfoPtr_System_Collections_IList_Clear_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventDescriptorCollection>.NativeClassPtr, 100665721);
			EventDescriptorCollection.NativeMethodInfoPtr_System_Collections_IList_IndexOf_Private_Virtual_Final_New_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventDescriptorCollection>.NativeClassPtr, 100665722);
			EventDescriptorCollection.NativeMethodInfoPtr_System_Collections_IList_Insert_Private_Virtual_Final_New_Void_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventDescriptorCollection>.NativeClassPtr, 100665723);
			EventDescriptorCollection.NativeMethodInfoPtr_System_Collections_IList_Remove_Private_Virtual_Final_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventDescriptorCollection>.NativeClassPtr, 100665724);
			EventDescriptorCollection.NativeMethodInfoPtr_System_Collections_IList_RemoveAt_Private_Virtual_Final_New_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventDescriptorCollection>.NativeClassPtr, 100665725);
			EventDescriptorCollection.NativeMethodInfoPtr_System_Collections_IList_get_IsReadOnly_Private_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventDescriptorCollection>.NativeClassPtr, 100665726);
			EventDescriptorCollection.NativeMethodInfoPtr_System_Collections_IList_get_IsFixedSize_Private_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventDescriptorCollection>.NativeClassPtr, 100665727);
		}

		// Token: 0x0600109C RID: 4252 RVA: 0x0005B304 File Offset: 0x00059504
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 459011, RefRangeEnd = 459013, XrefRangeStart = 459004, XrefRangeEnd = 459011, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EventDescriptorCollection(Il2CppReferenceArray<EventDescriptor> events)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EventDescriptorCollection>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(events);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventDescriptorCollection.NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_EventDescriptor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600109D RID: 4253 RVA: 0x0005B350 File Offset: 0x00059550
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 459020, RefRangeEnd = 459024, XrefRangeStart = 459013, XrefRangeEnd = 459020, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EventDescriptorCollection(Il2CppReferenceArray<EventDescriptor> events, bool readOnly)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EventDescriptorCollection>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(events);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref readOnly;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventDescriptorCollection.NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_EventDescriptor_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700050B RID: 1291
		// (get) Token: 0x0600109E RID: 4254 RVA: 0x0005B3AC File Offset: 0x000595AC
		// (set) Token: 0x0600109F RID: 4255 RVA: 0x0005B3E8 File Offset: 0x000595E8
		public unsafe int Count
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventDescriptorCollection.NativeMethodInfoPtr_get_Count_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventDescriptorCollection.NativeMethodInfoPtr_set_Count_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700050C RID: 1292
		public unsafe virtual EventDescriptor this[int index]
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 459024, XrefRangeEnd = 459025, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref index;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EventDescriptorCollection.NativeMethodInfoPtr_get_Item_Public_Virtual_New_get_EventDescriptor_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<EventDescriptor>(intPtr3) : null;
				}
			}
		}

		// Token: 0x1700050D RID: 1293
		public unsafe virtual EventDescriptor this[string name]
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EventDescriptorCollection.NativeMethodInfoPtr_get_Item_Public_Virtual_New_get_EventDescriptor_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<EventDescriptor>(intPtr3) : null;
				}
			}
		}

		// Token: 0x060010A2 RID: 4258 RVA: 0x0005B4DC File Offset: 0x000596DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 459025, XrefRangeEnd = 459028, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int Add(EventDescriptor value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventDescriptorCollection.NativeMethodInfoPtr_Add_Public_Int32_EventDescriptor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060010A3 RID: 4259 RVA: 0x0005B52C File Offset: 0x0005972C
		[CallerCount(0)]
		public unsafe void Clear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventDescriptorCollection.NativeMethodInfoPtr_Clear_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010A4 RID: 4260 RVA: 0x0005B560 File Offset: 0x00059760
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 459028, XrefRangeEnd = 459031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Contains(EventDescriptor value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventDescriptorCollection.NativeMethodInfoPtr_Contains_Public_Boolean_EventDescriptor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060010A5 RID: 4261 RVA: 0x0005B5B0 File Offset: 0x000597B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 459031, XrefRangeEnd = 459033, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventDescriptorCollection.NativeMethodInfoPtr_System_Collections_ICollection_CopyTo_Private_Virtual_Final_New_Void_Array_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010A6 RID: 4262 RVA: 0x0005B600 File Offset: 0x00059800
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 459039, RefRangeEnd = 459043, XrefRangeStart = 459033, XrefRangeEnd = 459039, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EnsureEventsOwned()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventDescriptorCollection.NativeMethodInfoPtr_EnsureEventsOwned_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010A7 RID: 4263 RVA: 0x0005B634 File Offset: 0x00059834
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 459053, RefRangeEnd = 459057, XrefRangeStart = 459043, XrefRangeEnd = 459053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EnsureSize(int sizeNeeded)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref sizeNeeded;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventDescriptorCollection.NativeMethodInfoPtr_EnsureSize_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060010A8 RID: 4264 RVA: 0x0005B674 File Offset: 0x00059874
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 459057, XrefRangeEnd = 459058, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual EventDescriptor Find(string name, bool ignoreCase)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ignoreCase;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EventDescriptorCollection.NativeMethodInfoPtr_Find_Public_Virtual_New_EventDescriptor_String_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<EventDescriptor>(intPtr3) : null;
		}

		// Token: 0x060010A9 RID: 4265 RVA: 0x0005B6E0 File Offset: 0x000598E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 459058, XrefRangeEnd = 459061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int IndexOf(EventDescriptor value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventDescriptorCollection.NativeMethodInfoPtr_IndexOf_Public_Int32_EventDescriptor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060010AA RID: 4266 RVA: 0x0005B730 File Offset: 0x00059930
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 459061, XrefRangeEnd = 459065, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Insert(int index, EventDescriptor value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventDescriptorCollection.NativeMethodInfoPtr_Insert_Public_Void_Int32_EventDescriptor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010AB RID: 4267 RVA: 0x0005B780 File Offset: 0x00059980
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 459065, XrefRangeEnd = 459069, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Remove(EventDescriptor value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventDescriptorCollection.NativeMethodInfoPtr_Remove_Public_Void_EventDescriptor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060010AC RID: 4268 RVA: 0x0005B7C4 File Offset: 0x000599C4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 459071, RefRangeEnd = 459074, XrefRangeStart = 459069, XrefRangeEnd = 459071, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveAt(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventDescriptorCollection.NativeMethodInfoPtr_RemoveAt_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060010AD RID: 4269 RVA: 0x0005B804 File Offset: 0x00059A04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 459074, XrefRangeEnd = 459079, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventDescriptorCollection.NativeMethodInfoPtr_GetEnumerator_Public_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060010AE RID: 4270 RVA: 0x0005B844 File Offset: 0x00059A44
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 459109, RefRangeEnd = 459110, XrefRangeStart = 459079, XrefRangeEnd = 459109, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InternalSort(Il2CppStringArray names)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(names);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventDescriptorCollection.NativeMethodInfoPtr_InternalSort_Protected_Void_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060010AF RID: 4271 RVA: 0x0005B888 File Offset: 0x00059A88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 459110, XrefRangeEnd = 459115, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InternalSort(IComparer sorter)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sorter);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventDescriptorCollection.NativeMethodInfoPtr_InternalSort_Protected_Void_IComparer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700050E RID: 1294
		// (get) Token: 0x060010B0 RID: 4272 RVA: 0x0005B8CC File Offset: 0x00059ACC
		public unsafe virtual bool System.Collections.ICollection.IsSynchronized
		{
			[CallerCount(184)]
			[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventDescriptorCollection.NativeMethodInfoPtr_System_Collections_ICollection_get_IsSynchronized_Private_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700050F RID: 1295
		// (get) Token: 0x060010B1 RID: 4273 RVA: 0x0005B908 File Offset: 0x00059B08
		public unsafe virtual Object System.Collections.ICollection.SyncRoot
		{
			[CallerCount(74)]
			[CachedScanResults(RefRangeStart = 27932, RefRangeEnd = 28006, XrefRangeStart = 27932, XrefRangeEnd = 28006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventDescriptorCollection.NativeMethodInfoPtr_System_Collections_ICollection_get_SyncRoot_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x17000510 RID: 1296
		// (get) Token: 0x060010B2 RID: 4274 RVA: 0x0005B948 File Offset: 0x00059B48
		public unsafe virtual int System.Collections.ICollection.Count
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventDescriptorCollection.NativeMethodInfoPtr_System_Collections_ICollection_get_Count_Private_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060010B3 RID: 4275 RVA: 0x0005B984 File Offset: 0x00059B84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 459115, XrefRangeEnd = 459120, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerator System_Collections_IEnumerable_GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventDescriptorCollection.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x17000511 RID: 1297
		// (get) Token: 0x060010B4 RID: 4276 RVA: 0x0005B9C4 File Offset: 0x00059BC4
		// (set) Token: 0x060010B5 RID: 4277 RVA: 0x0005BA10 File Offset: 0x00059C10
		public unsafe virtual Object System.Collections.IList.Item
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref index;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventDescriptorCollection.NativeMethodInfoPtr_System_Collections_IList_get_Item_Private_Virtual_Final_New_get_Object_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 459120, XrefRangeEnd = 459153, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref index;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventDescriptorCollection.NativeMethodInfoPtr_System_Collections_IList_set_Item_Private_Virtual_Final_New_set_Void_Int32_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060010B6 RID: 4278 RVA: 0x0005BA60 File Offset: 0x00059C60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 459153, XrefRangeEnd = 459158, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual int System_Collections_IList_Add(Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventDescriptorCollection.NativeMethodInfoPtr_System_Collections_IList_Add_Private_Virtual_Final_New_Int32_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060010B7 RID: 4279 RVA: 0x0005BAB0 File Offset: 0x00059CB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 459158, XrefRangeEnd = 459163, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool System_Collections_IList_Contains(Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventDescriptorCollection.NativeMethodInfoPtr_System_Collections_IList_Contains_Private_Virtual_Final_New_Boolean_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060010B8 RID: 4280 RVA: 0x0005BB00 File Offset: 0x00059D00
		[CallerCount(0)]
		public unsafe virtual void System_Collections_IList_Clear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventDescriptorCollection.NativeMethodInfoPtr_System_Collections_IList_Clear_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010B9 RID: 4281 RVA: 0x0005BB34 File Offset: 0x00059D34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 459163, XrefRangeEnd = 459168, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual int System_Collections_IList_IndexOf(Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventDescriptorCollection.NativeMethodInfoPtr_System_Collections_IList_IndexOf_Private_Virtual_Final_New_Int32_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060010BA RID: 4282 RVA: 0x0005BB84 File Offset: 0x00059D84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 459168, XrefRangeEnd = 459174, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void System_Collections_IList_Insert(int index, Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventDescriptorCollection.NativeMethodInfoPtr_System_Collections_IList_Insert_Private_Virtual_Final_New_Void_Int32_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010BB RID: 4283 RVA: 0x0005BBD4 File Offset: 0x00059DD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 459174, XrefRangeEnd = 459180, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void System_Collections_IList_Remove(Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventDescriptorCollection.NativeMethodInfoPtr_System_Collections_IList_Remove_Private_Virtual_Final_New_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060010BC RID: 4284 RVA: 0x0005BC18 File Offset: 0x00059E18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 459180, XrefRangeEnd = 459181, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void System_Collections_IList_RemoveAt(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventDescriptorCollection.NativeMethodInfoPtr_System_Collections_IList_RemoveAt_Private_Virtual_Final_New_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000512 RID: 1298
		// (get) Token: 0x060010BD RID: 4285 RVA: 0x0005BC58 File Offset: 0x00059E58
		public unsafe virtual bool System.Collections.IList.IsReadOnly
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventDescriptorCollection.NativeMethodInfoPtr_System_Collections_IList_get_IsReadOnly_Private_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000513 RID: 1299
		// (get) Token: 0x060010BE RID: 4286 RVA: 0x0005BC94 File Offset: 0x00059E94
		public unsafe virtual bool System.Collections.IList.IsFixedSize
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventDescriptorCollection.NativeMethodInfoPtr_System_Collections_IList_get_IsFixedSize_Private_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060010BF RID: 4287 RVA: 0x00007ED2 File Offset: 0x000060D2
		public EventDescriptorCollection(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000503 RID: 1283
		// (get) Token: 0x060010C0 RID: 4288 RVA: 0x0005BCD0 File Offset: 0x00059ED0
		// (set) Token: 0x060010C1 RID: 4289 RVA: 0x00007EDB File Offset: 0x000060DB
		public unsafe Il2CppReferenceArray<EventDescriptor> _events
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventDescriptorCollection.NativeFieldInfoPtr__events);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<EventDescriptor>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventDescriptorCollection.NativeFieldInfoPtr__events), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000504 RID: 1284
		// (get) Token: 0x060010C2 RID: 4290 RVA: 0x0005BD00 File Offset: 0x00059F00
		// (set) Token: 0x060010C3 RID: 4291 RVA: 0x00007EFA File Offset: 0x000060FA
		public unsafe Il2CppStringArray _namedSort
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventDescriptorCollection.NativeFieldInfoPtr__namedSort);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventDescriptorCollection.NativeFieldInfoPtr__namedSort), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000505 RID: 1285
		// (get) Token: 0x060010C4 RID: 4292 RVA: 0x0005BD30 File Offset: 0x00059F30
		// (set) Token: 0x060010C5 RID: 4293 RVA: 0x00007F19 File Offset: 0x00006119
		public unsafe IComparer _comparer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventDescriptorCollection.NativeFieldInfoPtr__comparer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IComparer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventDescriptorCollection.NativeFieldInfoPtr__comparer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000506 RID: 1286
		// (get) Token: 0x060010C6 RID: 4294 RVA: 0x0005BD60 File Offset: 0x00059F60
		// (set) Token: 0x060010C7 RID: 4295 RVA: 0x00007F38 File Offset: 0x00006138
		public unsafe bool _eventsOwned
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventDescriptorCollection.NativeFieldInfoPtr__eventsOwned);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventDescriptorCollection.NativeFieldInfoPtr__eventsOwned)) = value;
			}
		}

		// Token: 0x17000507 RID: 1287
		// (get) Token: 0x060010C8 RID: 4296 RVA: 0x0005BD88 File Offset: 0x00059F88
		// (set) Token: 0x060010C9 RID: 4297 RVA: 0x00007F53 File Offset: 0x00006153
		public unsafe bool _needSort
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventDescriptorCollection.NativeFieldInfoPtr__needSort);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventDescriptorCollection.NativeFieldInfoPtr__needSort)) = value;
			}
		}

		// Token: 0x17000508 RID: 1288
		// (get) Token: 0x060010CA RID: 4298 RVA: 0x0005BDB0 File Offset: 0x00059FB0
		// (set) Token: 0x060010CB RID: 4299 RVA: 0x00007F6E File Offset: 0x0000616E
		public unsafe bool _readOnly
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventDescriptorCollection.NativeFieldInfoPtr__readOnly);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventDescriptorCollection.NativeFieldInfoPtr__readOnly)) = value;
			}
		}

		// Token: 0x17000509 RID: 1289
		// (get) Token: 0x060010CC RID: 4300 RVA: 0x0005BDD8 File Offset: 0x00059FD8
		// (set) Token: 0x060010CD RID: 4301 RVA: 0x00007F89 File Offset: 0x00006189
		public unsafe static EventDescriptorCollection Empty
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(EventDescriptorCollection.NativeFieldInfoPtr_Empty, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EventDescriptorCollection>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EventDescriptorCollection.NativeFieldInfoPtr_Empty, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700050A RID: 1290
		// (get) Token: 0x060010CE RID: 4302 RVA: 0x0005BE00 File Offset: 0x0005A000
		// (set) Token: 0x060010CF RID: 4303 RVA: 0x00007F9B File Offset: 0x0000619B
		public unsafe int _Count_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventDescriptorCollection.NativeFieldInfoPtr__Count_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventDescriptorCollection.NativeFieldInfoPtr__Count_k__BackingField)) = value;
			}
		}

		// Token: 0x04000D52 RID: 3410
		private static readonly IntPtr NativeFieldInfoPtr__events;

		// Token: 0x04000D53 RID: 3411
		private static readonly IntPtr NativeFieldInfoPtr__namedSort;

		// Token: 0x04000D54 RID: 3412
		private static readonly IntPtr NativeFieldInfoPtr__comparer;

		// Token: 0x04000D55 RID: 3413
		private static readonly IntPtr NativeFieldInfoPtr__eventsOwned;

		// Token: 0x04000D56 RID: 3414
		private static readonly IntPtr NativeFieldInfoPtr__needSort;

		// Token: 0x04000D57 RID: 3415
		private static readonly IntPtr NativeFieldInfoPtr__readOnly;

		// Token: 0x04000D58 RID: 3416
		private static readonly IntPtr NativeFieldInfoPtr_Empty;

		// Token: 0x04000D59 RID: 3417
		private static readonly IntPtr NativeFieldInfoPtr__Count_k__BackingField;

		// Token: 0x04000D5A RID: 3418
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_EventDescriptor_0;

		// Token: 0x04000D5B RID: 3419
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_EventDescriptor_Boolean_0;

		// Token: 0x04000D5C RID: 3420
		private static readonly IntPtr NativeMethodInfoPtr_get_Count_Public_get_Int32_0;

		// Token: 0x04000D5D RID: 3421
		private static readonly IntPtr NativeMethodInfoPtr_set_Count_Private_set_Void_Int32_0;

		// Token: 0x04000D5E RID: 3422
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_Virtual_New_get_EventDescriptor_Int32_0;

		// Token: 0x04000D5F RID: 3423
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_Virtual_New_get_EventDescriptor_String_0;

		// Token: 0x04000D60 RID: 3424
		private static readonly IntPtr NativeMethodInfoPtr_Add_Public_Int32_EventDescriptor_0;

		// Token: 0x04000D61 RID: 3425
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Void_0;

		// Token: 0x04000D62 RID: 3426
		private static readonly IntPtr NativeMethodInfoPtr_Contains_Public_Boolean_EventDescriptor_0;

		// Token: 0x04000D63 RID: 3427
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_ICollection_CopyTo_Private_Virtual_Final_New_Void_Array_Int32_0;

		// Token: 0x04000D64 RID: 3428
		private static readonly IntPtr NativeMethodInfoPtr_EnsureEventsOwned_Private_Void_0;

		// Token: 0x04000D65 RID: 3429
		private static readonly IntPtr NativeMethodInfoPtr_EnsureSize_Private_Void_Int32_0;

		// Token: 0x04000D66 RID: 3430
		private static readonly IntPtr NativeMethodInfoPtr_Find_Public_Virtual_New_EventDescriptor_String_Boolean_0;

		// Token: 0x04000D67 RID: 3431
		private static readonly IntPtr NativeMethodInfoPtr_IndexOf_Public_Int32_EventDescriptor_0;

		// Token: 0x04000D68 RID: 3432
		private static readonly IntPtr NativeMethodInfoPtr_Insert_Public_Void_Int32_EventDescriptor_0;

		// Token: 0x04000D69 RID: 3433
		private static readonly IntPtr NativeMethodInfoPtr_Remove_Public_Void_EventDescriptor_0;

		// Token: 0x04000D6A RID: 3434
		private static readonly IntPtr NativeMethodInfoPtr_RemoveAt_Public_Void_Int32_0;

		// Token: 0x04000D6B RID: 3435
		private static readonly IntPtr NativeMethodInfoPtr_GetEnumerator_Public_IEnumerator_0;

		// Token: 0x04000D6C RID: 3436
		private static readonly IntPtr NativeMethodInfoPtr_InternalSort_Protected_Void_Il2CppStringArray_0;

		// Token: 0x04000D6D RID: 3437
		private static readonly IntPtr NativeMethodInfoPtr_InternalSort_Protected_Void_IComparer_0;

		// Token: 0x04000D6E RID: 3438
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_ICollection_get_IsSynchronized_Private_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04000D6F RID: 3439
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_ICollection_get_SyncRoot_Private_Virtual_Final_New_get_Object_0;

		// Token: 0x04000D70 RID: 3440
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_ICollection_get_Count_Private_Virtual_Final_New_get_Int32_0;

		// Token: 0x04000D71 RID: 3441
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;

		// Token: 0x04000D72 RID: 3442
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IList_get_Item_Private_Virtual_Final_New_get_Object_Int32_0;

		// Token: 0x04000D73 RID: 3443
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IList_set_Item_Private_Virtual_Final_New_set_Void_Int32_Object_0;

		// Token: 0x04000D74 RID: 3444
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IList_Add_Private_Virtual_Final_New_Int32_Object_0;

		// Token: 0x04000D75 RID: 3445
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IList_Contains_Private_Virtual_Final_New_Boolean_Object_0;

		// Token: 0x04000D76 RID: 3446
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IList_Clear_Private_Virtual_Final_New_Void_0;

		// Token: 0x04000D77 RID: 3447
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IList_IndexOf_Private_Virtual_Final_New_Int32_Object_0;

		// Token: 0x04000D78 RID: 3448
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IList_Insert_Private_Virtual_Final_New_Void_Int32_Object_0;

		// Token: 0x04000D79 RID: 3449
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IList_Remove_Private_Virtual_Final_New_Void_Object_0;

		// Token: 0x04000D7A RID: 3450
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IList_RemoveAt_Private_Virtual_Final_New_Void_Int32_0;

		// Token: 0x04000D7B RID: 3451
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IList_get_IsReadOnly_Private_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04000D7C RID: 3452
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IList_get_IsFixedSize_Private_Virtual_Final_New_get_Boolean_0;

		// Token: 0x020002DB RID: 731
		public class ArraySubsetEnumerator : Object
		{
			// Token: 0x06002C19 RID: 11289 RVA: 0x000C271C File Offset: 0x000C091C
			// Note: this type is marked as 'beforefieldinit'.
			static ArraySubsetEnumerator()
			{
				Il2CppClassPointerStore<EventDescriptorCollection.ArraySubsetEnumerator>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EventDescriptorCollection>.NativeClassPtr, "ArraySubsetEnumerator");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EventDescriptorCollection.ArraySubsetEnumerator>.NativeClassPtr);
				EventDescriptorCollection.ArraySubsetEnumerator.NativeFieldInfoPtr__array = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventDescriptorCollection.ArraySubsetEnumerator>.NativeClassPtr, "_array");
				EventDescriptorCollection.ArraySubsetEnumerator.NativeFieldInfoPtr__total = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventDescriptorCollection.ArraySubsetEnumerator>.NativeClassPtr, "_total");
				EventDescriptorCollection.ArraySubsetEnumerator.NativeFieldInfoPtr__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventDescriptorCollection.ArraySubsetEnumerator>.NativeClassPtr, "_current");
				EventDescriptorCollection.ArraySubsetEnumerator.NativeMethodInfoPtr__ctor_Public_Void_Array_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventDescriptorCollection.ArraySubsetEnumerator>.NativeClassPtr, 100665729);
				EventDescriptorCollection.ArraySubsetEnumerator.NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventDescriptorCollection.ArraySubsetEnumerator>.NativeClassPtr, 100665730);
				EventDescriptorCollection.ArraySubsetEnumerator.NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventDescriptorCollection.ArraySubsetEnumerator>.NativeClassPtr, 100665731);
				EventDescriptorCollection.ArraySubsetEnumerator.NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventDescriptorCollection.ArraySubsetEnumerator>.NativeClassPtr, 100665732);
			}

			// Token: 0x06002C1A RID: 11290 RVA: 0x000C27D4 File Offset: 0x000C09D4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 458995, XrefRangeEnd = 458997, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ArraySubsetEnumerator(Array array, int count)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EventDescriptorCollection.ArraySubsetEnumerator>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventDescriptorCollection.ArraySubsetEnumerator.NativeMethodInfoPtr__ctor_Public_Void_Array_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002C1B RID: 11291 RVA: 0x000C2830 File Offset: 0x000C0A30
			[CallerCount(0)]
			public unsafe virtual bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventDescriptorCollection.ArraySubsetEnumerator.NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06002C1C RID: 11292 RVA: 0x000C286C File Offset: 0x000C0A6C
			[CallerCount(0)]
			public unsafe virtual void Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventDescriptorCollection.ArraySubsetEnumerator.NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000DD9 RID: 3545
			// (get) Token: 0x06002C1D RID: 11293 RVA: 0x000C28A0 File Offset: 0x000C0AA0
			public unsafe virtual Object Current
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 458997, XrefRangeEnd = 459004, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventDescriptorCollection.ArraySubsetEnumerator.NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002C1E RID: 11294 RVA: 0x00013DF1 File Offset: 0x00011FF1
			public ArraySubsetEnumerator(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000DD6 RID: 3542
			// (get) Token: 0x06002C1F RID: 11295 RVA: 0x000C28E0 File Offset: 0x000C0AE0
			// (set) Token: 0x06002C20 RID: 11296 RVA: 0x00013DFA File Offset: 0x00011FFA
			public unsafe Array _array
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventDescriptorCollection.ArraySubsetEnumerator.NativeFieldInfoPtr__array);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Array>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventDescriptorCollection.ArraySubsetEnumerator.NativeFieldInfoPtr__array), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000DD7 RID: 3543
			// (get) Token: 0x06002C21 RID: 11297 RVA: 0x000C2910 File Offset: 0x000C0B10
			// (set) Token: 0x06002C22 RID: 11298 RVA: 0x00013E19 File Offset: 0x00012019
			public unsafe int _total
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventDescriptorCollection.ArraySubsetEnumerator.NativeFieldInfoPtr__total);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventDescriptorCollection.ArraySubsetEnumerator.NativeFieldInfoPtr__total)) = value;
				}
			}

			// Token: 0x17000DD8 RID: 3544
			// (get) Token: 0x06002C23 RID: 11299 RVA: 0x000C2938 File Offset: 0x000C0B38
			// (set) Token: 0x06002C24 RID: 11300 RVA: 0x00013E34 File Offset: 0x00012034
			public unsafe int _current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventDescriptorCollection.ArraySubsetEnumerator.NativeFieldInfoPtr__current);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventDescriptorCollection.ArraySubsetEnumerator.NativeFieldInfoPtr__current)) = value;
				}
			}

			// Token: 0x040022DB RID: 8923
			private static readonly IntPtr NativeFieldInfoPtr__array;

			// Token: 0x040022DC RID: 8924
			private static readonly IntPtr NativeFieldInfoPtr__total;

			// Token: 0x040022DD RID: 8925
			private static readonly IntPtr NativeFieldInfoPtr__current;

			// Token: 0x040022DE RID: 8926
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Array_Int32_0;

			// Token: 0x040022DF RID: 8927
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0;

			// Token: 0x040022E0 RID: 8928
			private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0;

			// Token: 0x040022E1 RID: 8929
			private static readonly IntPtr NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_Object_0;
		}
	}
}
