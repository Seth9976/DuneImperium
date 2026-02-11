using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x020001D0 RID: 464
	public class XmlSchemaObjectCollection : CollectionBase
	{
		// Token: 0x060026F9 RID: 9977 RVA: 0x000B6254 File Offset: 0x000B4454
		// Note: this type is marked as 'beforefieldinit'.
		static XmlSchemaObjectCollection()
		{
			Il2CppClassPointerStore<XmlSchemaObjectCollection>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "XmlSchemaObjectCollection");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlSchemaObjectCollection>.NativeClassPtr);
			XmlSchemaObjectCollection.NativeFieldInfoPtr_parent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaObjectCollection>.NativeClassPtr, "parent");
			XmlSchemaObjectCollection.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaObjectCollection>.NativeClassPtr, 100668923);
			XmlSchemaObjectCollection.NativeMethodInfoPtr_get_Item_Public_Virtual_New_get_XmlSchemaObject_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaObjectCollection>.NativeClassPtr, 100668924);
			XmlSchemaObjectCollection.NativeMethodInfoPtr_set_Item_Public_Virtual_New_set_Void_Int32_XmlSchemaObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaObjectCollection>.NativeClassPtr, 100668925);
			XmlSchemaObjectCollection.NativeMethodInfoPtr_GetEnumerator_Public_XmlSchemaObjectEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaObjectCollection>.NativeClassPtr, 100668926);
			XmlSchemaObjectCollection.NativeMethodInfoPtr_Add_Public_Int32_XmlSchemaObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaObjectCollection>.NativeClassPtr, 100668927);
			XmlSchemaObjectCollection.NativeMethodInfoPtr_Insert_Public_Void_Int32_XmlSchemaObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaObjectCollection>.NativeClassPtr, 100668928);
			XmlSchemaObjectCollection.NativeMethodInfoPtr_Remove_Public_Void_XmlSchemaObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaObjectCollection>.NativeClassPtr, 100668929);
			XmlSchemaObjectCollection.NativeMethodInfoPtr_OnInsert_Protected_Virtual_Void_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaObjectCollection>.NativeClassPtr, 100668930);
			XmlSchemaObjectCollection.NativeMethodInfoPtr_OnSet_Protected_Virtual_Void_Int32_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaObjectCollection>.NativeClassPtr, 100668931);
			XmlSchemaObjectCollection.NativeMethodInfoPtr_OnClear_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaObjectCollection>.NativeClassPtr, 100668932);
			XmlSchemaObjectCollection.NativeMethodInfoPtr_OnRemove_Protected_Virtual_Void_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaObjectCollection>.NativeClassPtr, 100668933);
			XmlSchemaObjectCollection.NativeMethodInfoPtr_Clone_Internal_XmlSchemaObjectCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaObjectCollection>.NativeClassPtr, 100668934);
			XmlSchemaObjectCollection.NativeMethodInfoPtr_Add_Private_Void_XmlSchemaObjectCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaObjectCollection>.NativeClassPtr, 100668935);
		}

		// Token: 0x060026FA RID: 9978 RVA: 0x000B639C File Offset: 0x000B459C
		[CallerCount(23)]
		[CachedScanResults(RefRangeStart = 385162, RefRangeEnd = 385185, XrefRangeStart = 385162, XrefRangeEnd = 385185, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlSchemaObjectCollection()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlSchemaObjectCollection>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaObjectCollection.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000D4F RID: 3407
		public unsafe virtual XmlSchemaObject this[int index]
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 412466, XrefRangeEnd = 412472, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref index;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlSchemaObjectCollection.NativeMethodInfoPtr_get_Item_Public_Virtual_New_get_XmlSchemaObject_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaObject>(intPtr3) : null;
				}
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 412472, XrefRangeEnd = 412476, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlSchemaObjectCollection.NativeMethodInfoPtr_set_Item_Public_Virtual_New_set_Void_Int32_XmlSchemaObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060026FD RID: 9981 RVA: 0x000B648C File Offset: 0x000B468C
		[CallerCount(21)]
		[CachedScanResults(RefRangeStart = 412480, RefRangeEnd = 412501, XrefRangeStart = 412476, XrefRangeEnd = 412480, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe XmlSchemaObjectEnumerator GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaObjectCollection.NativeMethodInfoPtr_GetEnumerator_Public_XmlSchemaObjectEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaObjectEnumerator>(intPtr3) : null;
		}

		// Token: 0x060026FE RID: 9982 RVA: 0x000B64CC File Offset: 0x000B46CC
		[CallerCount(61)]
		[CachedScanResults(RefRangeStart = 412506, RefRangeEnd = 412567, XrefRangeStart = 412501, XrefRangeEnd = 412506, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int Add(XmlSchemaObject item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaObjectCollection.NativeMethodInfoPtr_Add_Public_Int32_XmlSchemaObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060026FF RID: 9983 RVA: 0x000B651C File Offset: 0x000B471C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 412571, RefRangeEnd = 412573, XrefRangeStart = 412567, XrefRangeEnd = 412571, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Insert(int index, XmlSchemaObject item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(item);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaObjectCollection.NativeMethodInfoPtr_Insert_Public_Void_Int32_XmlSchemaObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002700 RID: 9984 RVA: 0x000B656C File Offset: 0x000B476C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 412579, RefRangeEnd = 412581, XrefRangeStart = 412573, XrefRangeEnd = 412579, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Remove(XmlSchemaObject item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaObjectCollection.NativeMethodInfoPtr_Remove_Public_Void_XmlSchemaObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002701 RID: 9985 RVA: 0x000B65B0 File Offset: 0x000B47B0
		[CallerCount(0)]
		public unsafe override void OnInsert(int index, Object item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(item);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlSchemaObjectCollection.NativeMethodInfoPtr_OnInsert_Protected_Virtual_Void_Int32_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002702 RID: 9986 RVA: 0x000B660C File Offset: 0x000B480C
		[CallerCount(0)]
		public unsafe override void OnSet(int index, Object oldValue, Object newValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(oldValue);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(newValue);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlSchemaObjectCollection.NativeMethodInfoPtr_OnSet_Protected_Virtual_Void_Int32_Object_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002703 RID: 9987 RVA: 0x000B667C File Offset: 0x000B487C
		[CallerCount(0)]
		public unsafe override void OnClear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlSchemaObjectCollection.NativeMethodInfoPtr_OnClear_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002704 RID: 9988 RVA: 0x000B66B8 File Offset: 0x000B48B8
		[CallerCount(0)]
		public unsafe override void OnRemove(int index, Object item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(item);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlSchemaObjectCollection.NativeMethodInfoPtr_OnRemove_Protected_Virtual_Void_Int32_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002705 RID: 9989 RVA: 0x000B6714 File Offset: 0x000B4914
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 412585, RefRangeEnd = 412586, XrefRangeStart = 412581, XrefRangeEnd = 412585, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlSchemaObjectCollection Clone()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaObjectCollection.NativeMethodInfoPtr_Clone_Internal_XmlSchemaObjectCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaObjectCollection>(intPtr3) : null;
		}

		// Token: 0x06002706 RID: 9990 RVA: 0x000B6754 File Offset: 0x000B4954
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 412586, XrefRangeEnd = 412587, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Add(XmlSchemaObjectCollection collToAdd)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(collToAdd);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaObjectCollection.NativeMethodInfoPtr_Add_Private_Void_XmlSchemaObjectCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002707 RID: 9991 RVA: 0x000108B4 File Offset: 0x0000EAB4
		public XmlSchemaObjectCollection(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000D4E RID: 3406
		// (get) Token: 0x06002708 RID: 9992 RVA: 0x000B6798 File Offset: 0x000B4998
		// (set) Token: 0x06002709 RID: 9993 RVA: 0x000108BD File Offset: 0x0000EABD
		public unsafe XmlSchemaObject parent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaObjectCollection.NativeFieldInfoPtr_parent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaObjectCollection.NativeFieldInfoPtr_parent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001D69 RID: 7529
		private static readonly IntPtr NativeFieldInfoPtr_parent;

		// Token: 0x04001D6A RID: 7530
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001D6B RID: 7531
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_Virtual_New_get_XmlSchemaObject_Int32_0;

		// Token: 0x04001D6C RID: 7532
		private static readonly IntPtr NativeMethodInfoPtr_set_Item_Public_Virtual_New_set_Void_Int32_XmlSchemaObject_0;

		// Token: 0x04001D6D RID: 7533
		private static readonly IntPtr NativeMethodInfoPtr_GetEnumerator_Public_XmlSchemaObjectEnumerator_0;

		// Token: 0x04001D6E RID: 7534
		private static readonly IntPtr NativeMethodInfoPtr_Add_Public_Int32_XmlSchemaObject_0;

		// Token: 0x04001D6F RID: 7535
		private static readonly IntPtr NativeMethodInfoPtr_Insert_Public_Void_Int32_XmlSchemaObject_0;

		// Token: 0x04001D70 RID: 7536
		private static readonly IntPtr NativeMethodInfoPtr_Remove_Public_Void_XmlSchemaObject_0;

		// Token: 0x04001D71 RID: 7537
		private static readonly IntPtr NativeMethodInfoPtr_OnInsert_Protected_Virtual_Void_Int32_Object_0;

		// Token: 0x04001D72 RID: 7538
		private static readonly IntPtr NativeMethodInfoPtr_OnSet_Protected_Virtual_Void_Int32_Object_Object_0;

		// Token: 0x04001D73 RID: 7539
		private static readonly IntPtr NativeMethodInfoPtr_OnClear_Protected_Virtual_Void_0;

		// Token: 0x04001D74 RID: 7540
		private static readonly IntPtr NativeMethodInfoPtr_OnRemove_Protected_Virtual_Void_Int32_Object_0;

		// Token: 0x04001D75 RID: 7541
		private static readonly IntPtr NativeMethodInfoPtr_Clone_Internal_XmlSchemaObjectCollection_0;

		// Token: 0x04001D76 RID: 7542
		private static readonly IntPtr NativeMethodInfoPtr_Add_Private_Void_XmlSchemaObjectCollection_0;
	}
}
