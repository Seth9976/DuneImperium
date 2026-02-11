using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;
using Il2CppSystem.Threading;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x020001A1 RID: 417
	public sealed class XmlSchemaCollection : Object
	{
		// Token: 0x06002461 RID: 9313 RVA: 0x000AC708 File Offset: 0x000AA908
		// Note: this type is marked as 'beforefieldinit'.
		static XmlSchemaCollection()
		{
			Il2CppClassPointerStore<XmlSchemaCollection>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "XmlSchemaCollection");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlSchemaCollection>.NativeClassPtr);
			XmlSchemaCollection.NativeFieldInfoPtr_collection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaCollection>.NativeClassPtr, "collection");
			XmlSchemaCollection.NativeFieldInfoPtr_nameTable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaCollection>.NativeClassPtr, "nameTable");
			XmlSchemaCollection.NativeFieldInfoPtr_schemaNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaCollection>.NativeClassPtr, "schemaNames");
			XmlSchemaCollection.NativeFieldInfoPtr_wLock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaCollection>.NativeClassPtr, "wLock");
			XmlSchemaCollection.NativeFieldInfoPtr_timeout = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaCollection>.NativeClassPtr, "timeout");
			XmlSchemaCollection.NativeFieldInfoPtr_isThreadSafe = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaCollection>.NativeClassPtr, "isThreadSafe");
			XmlSchemaCollection.NativeFieldInfoPtr_validationEventHandler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaCollection>.NativeClassPtr, "validationEventHandler");
			XmlSchemaCollection.NativeFieldInfoPtr_xmlResolver = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaCollection>.NativeClassPtr, "xmlResolver");
			XmlSchemaCollection.NativeMethodInfoPtr__ctor_Public_Void_XmlNameTable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaCollection>.NativeClassPtr, 100668573);
			XmlSchemaCollection.NativeMethodInfoPtr_get_Count_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaCollection>.NativeClassPtr, 100668574);
			XmlSchemaCollection.NativeMethodInfoPtr_get_NameTable_Public_get_XmlNameTable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaCollection>.NativeClassPtr, 100668575);
			XmlSchemaCollection.NativeMethodInfoPtr_set_XmlResolver_Internal_set_Void_XmlResolver_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaCollection>.NativeClassPtr, 100668576);
			XmlSchemaCollection.NativeMethodInfoPtr_get_Item_Public_get_XmlSchema_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaCollection>.NativeClassPtr, 100668577);
			XmlSchemaCollection.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaCollection>.NativeClassPtr, 100668578);
			XmlSchemaCollection.NativeMethodInfoPtr_GetEnumerator_Public_XmlSchemaCollectionEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaCollection>.NativeClassPtr, 100668579);
			XmlSchemaCollection.NativeMethodInfoPtr_System_Collections_ICollection_CopyTo_Private_Virtual_Final_New_Void_Array_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaCollection>.NativeClassPtr, 100668580);
			XmlSchemaCollection.NativeMethodInfoPtr_System_Collections_ICollection_get_IsSynchronized_Private_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaCollection>.NativeClassPtr, 100668581);
			XmlSchemaCollection.NativeMethodInfoPtr_System_Collections_ICollection_get_SyncRoot_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaCollection>.NativeClassPtr, 100668582);
			XmlSchemaCollection.NativeMethodInfoPtr_System_Collections_ICollection_get_Count_Private_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaCollection>.NativeClassPtr, 100668583);
			XmlSchemaCollection.NativeMethodInfoPtr_GetSchemaInfo_Internal_SchemaInfo_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaCollection>.NativeClassPtr, 100668584);
			XmlSchemaCollection.NativeMethodInfoPtr_GetSchemaNames_Internal_SchemaNames_XmlNameTable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaCollection>.NativeClassPtr, 100668585);
			XmlSchemaCollection.NativeMethodInfoPtr_Add_Internal_XmlSchema_String_SchemaInfo_XmlSchema_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaCollection>.NativeClassPtr, 100668586);
			XmlSchemaCollection.NativeMethodInfoPtr_Add_Private_XmlSchema_String_SchemaInfo_XmlSchema_Boolean_XmlResolver_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaCollection>.NativeClassPtr, 100668587);
			XmlSchemaCollection.NativeMethodInfoPtr_Add_Private_Void_String_XmlSchemaCollectionNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaCollection>.NativeClassPtr, 100668588);
			XmlSchemaCollection.NativeMethodInfoPtr_get_EventHandler_Internal_get_ValidationEventHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaCollection>.NativeClassPtr, 100668589);
			XmlSchemaCollection.NativeMethodInfoPtr_set_EventHandler_Internal_set_Void_ValidationEventHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaCollection>.NativeClassPtr, 100668590);
		}

		// Token: 0x06002462 RID: 9314 RVA: 0x000AC940 File Offset: 0x000AAB40
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 411147, RefRangeEnd = 411148, XrefRangeStart = 411132, XrefRangeEnd = 411147, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlSchemaCollection(XmlNameTable nametable)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlSchemaCollection>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(nametable);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaCollection.NativeMethodInfoPtr__ctor_Public_Void_XmlNameTable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000C54 RID: 3156
		// (get) Token: 0x06002463 RID: 9315 RVA: 0x000AC98C File Offset: 0x000AAB8C
		public unsafe int Count
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 375708, RefRangeEnd = 375709, XrefRangeStart = 375708, XrefRangeEnd = 375709, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaCollection.NativeMethodInfoPtr_get_Count_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000C55 RID: 3157
		// (get) Token: 0x06002464 RID: 9316 RVA: 0x000AC9C8 File Offset: 0x000AABC8
		public unsafe XmlNameTable NameTable
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaCollection.NativeMethodInfoPtr_get_NameTable_Public_get_XmlNameTable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlNameTable>(intPtr3) : null;
			}
		}

		// Token: 0x17000C56 RID: 3158
		// (set) Token: 0x06002465 RID: 9317 RVA: 0x000ACA08 File Offset: 0x000AAC08
		public unsafe XmlResolver XmlResolver
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaCollection.NativeMethodInfoPtr_set_XmlResolver_Internal_set_Void_XmlResolver_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000C57 RID: 3159
		public unsafe XmlSchema this[string ns]
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 411152, RefRangeEnd = 411153, XrefRangeStart = 411148, XrefRangeEnd = 411152, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(ns);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaCollection.NativeMethodInfoPtr_get_Item_Public_get_XmlSchema_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchema>(intPtr3) : null;
				}
			}
		}

		// Token: 0x06002467 RID: 9319 RVA: 0x000ACA9C File Offset: 0x000AAC9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 411153, XrefRangeEnd = 411158, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaCollection.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06002468 RID: 9320 RVA: 0x000ACADC File Offset: 0x000AACDC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 411163, RefRangeEnd = 411164, XrefRangeStart = 411158, XrefRangeEnd = 411163, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlSchemaCollectionEnumerator GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaCollection.NativeMethodInfoPtr_GetEnumerator_Public_XmlSchemaCollectionEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaCollectionEnumerator>(intPtr3) : null;
		}

		// Token: 0x06002469 RID: 9321 RVA: 0x000ACB1C File Offset: 0x000AAD1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 411164, XrefRangeEnd = 411177, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_Collections_ICollection_CopyTo(Array array, int index)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaCollection.NativeMethodInfoPtr_System_Collections_ICollection_CopyTo_Private_Virtual_Final_New_Void_Array_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000C58 RID: 3160
		// (get) Token: 0x0600246A RID: 9322 RVA: 0x000ACB6C File Offset: 0x000AAD6C
		public unsafe bool System.Collections.ICollection.IsSynchronized
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 25017, RefRangeEnd = 25031, XrefRangeStart = 25017, XrefRangeEnd = 25031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaCollection.NativeMethodInfoPtr_System_Collections_ICollection_get_IsSynchronized_Private_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000C59 RID: 3161
		// (get) Token: 0x0600246B RID: 9323 RVA: 0x000ACBA8 File Offset: 0x000AADA8
		public unsafe Object System.Collections.ICollection.SyncRoot
		{
			[CallerCount(1295)]
			[CachedScanResults(RefRangeStart = 308780, RefRangeEnd = 310075, XrefRangeStart = 308780, XrefRangeEnd = 310075, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaCollection.NativeMethodInfoPtr_System_Collections_ICollection_get_SyncRoot_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x17000C5A RID: 3162
		// (get) Token: 0x0600246C RID: 9324 RVA: 0x000ACBE8 File Offset: 0x000AADE8
		public unsafe int System.Collections.ICollection.Count
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 375708, RefRangeEnd = 375709, XrefRangeStart = 375708, XrefRangeEnd = 375709, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaCollection.NativeMethodInfoPtr_System_Collections_ICollection_get_Count_Private_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600246D RID: 9325 RVA: 0x000ACC24 File Offset: 0x000AAE24
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 411181, RefRangeEnd = 411182, XrefRangeStart = 411177, XrefRangeEnd = 411181, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SchemaInfo GetSchemaInfo(string ns)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(ns);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaCollection.NativeMethodInfoPtr_GetSchemaInfo_Internal_SchemaInfo_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SchemaInfo>(intPtr3) : null;
			}
		}

		// Token: 0x0600246E RID: 9326 RVA: 0x000ACC74 File Offset: 0x000AAE74
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 411187, RefRangeEnd = 411188, XrefRangeStart = 411182, XrefRangeEnd = 411187, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SchemaNames GetSchemaNames(XmlNameTable nt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(nt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaCollection.NativeMethodInfoPtr_GetSchemaNames_Internal_SchemaNames_XmlNameTable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SchemaNames>(intPtr3) : null;
			}
		}

		// Token: 0x0600246F RID: 9327 RVA: 0x000ACCC4 File Offset: 0x000AAEC4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 411201, RefRangeEnd = 411205, XrefRangeStart = 411188, XrefRangeEnd = 411201, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlSchema Add(string ns, SchemaInfo schemaInfo, XmlSchema schema, bool compile)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(ns);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(schemaInfo);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(schema);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref compile;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaCollection.NativeMethodInfoPtr_Add_Internal_XmlSchema_String_SchemaInfo_XmlSchema_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchema>(intPtr3) : null;
		}

		// Token: 0x06002470 RID: 9328 RVA: 0x000ACD48 File Offset: 0x000AAF48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 411205, XrefRangeEnd = 411211, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlSchema Add(string ns, SchemaInfo schemaInfo, XmlSchema schema, bool compile, XmlResolver resolver)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(ns);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(schemaInfo);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(schema);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref compile;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(resolver);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaCollection.NativeMethodInfoPtr_Add_Private_XmlSchema_String_SchemaInfo_XmlSchema_Boolean_XmlResolver_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchema>(intPtr3) : null;
		}

		// Token: 0x06002471 RID: 9329 RVA: 0x000ACDE0 File Offset: 0x000AAFE0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 411215, RefRangeEnd = 411216, XrefRangeStart = 411211, XrefRangeEnd = 411215, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Add(string ns, XmlSchemaCollectionNode node)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(ns);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(node);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaCollection.NativeMethodInfoPtr_Add_Private_Void_String_XmlSchemaCollectionNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000C5B RID: 3163
		// (get) Token: 0x06002472 RID: 9330 RVA: 0x000ACE34 File Offset: 0x000AB034
		// (set) Token: 0x06002473 RID: 9331 RVA: 0x000ACE74 File Offset: 0x000AB074
		public unsafe ValidationEventHandler EventHandler
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 139770, RefRangeEnd = 139777, XrefRangeStart = 139770, XrefRangeEnd = 139777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaCollection.NativeMethodInfoPtr_get_EventHandler_Internal_get_ValidationEventHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ValidationEventHandler>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaCollection.NativeMethodInfoPtr_set_EventHandler_Internal_set_Void_ValidationEventHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06002474 RID: 9332 RVA: 0x0000F64E File Offset: 0x0000D84E
		public XmlSchemaCollection(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000C4C RID: 3148
		// (get) Token: 0x06002475 RID: 9333 RVA: 0x000ACEB8 File Offset: 0x000AB0B8
		// (set) Token: 0x06002476 RID: 9334 RVA: 0x0000F657 File Offset: 0x0000D857
		public unsafe Hashtable collection
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaCollection.NativeFieldInfoPtr_collection);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaCollection.NativeFieldInfoPtr_collection), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C4D RID: 3149
		// (get) Token: 0x06002477 RID: 9335 RVA: 0x000ACEE8 File Offset: 0x000AB0E8
		// (set) Token: 0x06002478 RID: 9336 RVA: 0x0000F676 File Offset: 0x0000D876
		public unsafe XmlNameTable nameTable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaCollection.NativeFieldInfoPtr_nameTable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlNameTable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaCollection.NativeFieldInfoPtr_nameTable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C4E RID: 3150
		// (get) Token: 0x06002479 RID: 9337 RVA: 0x000ACF18 File Offset: 0x000AB118
		// (set) Token: 0x0600247A RID: 9338 RVA: 0x0000F695 File Offset: 0x0000D895
		public unsafe SchemaNames schemaNames
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaCollection.NativeFieldInfoPtr_schemaNames);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SchemaNames>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaCollection.NativeFieldInfoPtr_schemaNames), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C4F RID: 3151
		// (get) Token: 0x0600247B RID: 9339 RVA: 0x000ACF48 File Offset: 0x000AB148
		// (set) Token: 0x0600247C RID: 9340 RVA: 0x0000F6B4 File Offset: 0x0000D8B4
		public unsafe ReaderWriterLock wLock
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaCollection.NativeFieldInfoPtr_wLock);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ReaderWriterLock>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaCollection.NativeFieldInfoPtr_wLock), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C50 RID: 3152
		// (get) Token: 0x0600247D RID: 9341 RVA: 0x000ACF78 File Offset: 0x000AB178
		// (set) Token: 0x0600247E RID: 9342 RVA: 0x0000F6D3 File Offset: 0x0000D8D3
		public unsafe int timeout
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaCollection.NativeFieldInfoPtr_timeout);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaCollection.NativeFieldInfoPtr_timeout)) = value;
			}
		}

		// Token: 0x17000C51 RID: 3153
		// (get) Token: 0x0600247F RID: 9343 RVA: 0x000ACFA0 File Offset: 0x000AB1A0
		// (set) Token: 0x06002480 RID: 9344 RVA: 0x0000F6EE File Offset: 0x0000D8EE
		public unsafe bool isThreadSafe
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaCollection.NativeFieldInfoPtr_isThreadSafe);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaCollection.NativeFieldInfoPtr_isThreadSafe)) = value;
			}
		}

		// Token: 0x17000C52 RID: 3154
		// (get) Token: 0x06002481 RID: 9345 RVA: 0x000ACFC8 File Offset: 0x000AB1C8
		// (set) Token: 0x06002482 RID: 9346 RVA: 0x0000F709 File Offset: 0x0000D909
		public unsafe ValidationEventHandler validationEventHandler
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaCollection.NativeFieldInfoPtr_validationEventHandler);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ValidationEventHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaCollection.NativeFieldInfoPtr_validationEventHandler), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C53 RID: 3155
		// (get) Token: 0x06002483 RID: 9347 RVA: 0x000ACFF8 File Offset: 0x000AB1F8
		// (set) Token: 0x06002484 RID: 9348 RVA: 0x0000F728 File Offset: 0x0000D928
		public unsafe XmlResolver xmlResolver
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaCollection.NativeFieldInfoPtr_xmlResolver);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlResolver>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaCollection.NativeFieldInfoPtr_xmlResolver), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001B74 RID: 7028
		private static readonly IntPtr NativeFieldInfoPtr_collection;

		// Token: 0x04001B75 RID: 7029
		private static readonly IntPtr NativeFieldInfoPtr_nameTable;

		// Token: 0x04001B76 RID: 7030
		private static readonly IntPtr NativeFieldInfoPtr_schemaNames;

		// Token: 0x04001B77 RID: 7031
		private static readonly IntPtr NativeFieldInfoPtr_wLock;

		// Token: 0x04001B78 RID: 7032
		private static readonly IntPtr NativeFieldInfoPtr_timeout;

		// Token: 0x04001B79 RID: 7033
		private static readonly IntPtr NativeFieldInfoPtr_isThreadSafe;

		// Token: 0x04001B7A RID: 7034
		private static readonly IntPtr NativeFieldInfoPtr_validationEventHandler;

		// Token: 0x04001B7B RID: 7035
		private static readonly IntPtr NativeFieldInfoPtr_xmlResolver;

		// Token: 0x04001B7C RID: 7036
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_XmlNameTable_0;

		// Token: 0x04001B7D RID: 7037
		private static readonly IntPtr NativeMethodInfoPtr_get_Count_Public_get_Int32_0;

		// Token: 0x04001B7E RID: 7038
		private static readonly IntPtr NativeMethodInfoPtr_get_NameTable_Public_get_XmlNameTable_0;

		// Token: 0x04001B7F RID: 7039
		private static readonly IntPtr NativeMethodInfoPtr_set_XmlResolver_Internal_set_Void_XmlResolver_0;

		// Token: 0x04001B80 RID: 7040
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_get_XmlSchema_String_0;

		// Token: 0x04001B81 RID: 7041
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;

		// Token: 0x04001B82 RID: 7042
		private static readonly IntPtr NativeMethodInfoPtr_GetEnumerator_Public_XmlSchemaCollectionEnumerator_0;

		// Token: 0x04001B83 RID: 7043
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_ICollection_CopyTo_Private_Virtual_Final_New_Void_Array_Int32_0;

		// Token: 0x04001B84 RID: 7044
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_ICollection_get_IsSynchronized_Private_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04001B85 RID: 7045
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_ICollection_get_SyncRoot_Private_Virtual_Final_New_get_Object_0;

		// Token: 0x04001B86 RID: 7046
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_ICollection_get_Count_Private_Virtual_Final_New_get_Int32_0;

		// Token: 0x04001B87 RID: 7047
		private static readonly IntPtr NativeMethodInfoPtr_GetSchemaInfo_Internal_SchemaInfo_String_0;

		// Token: 0x04001B88 RID: 7048
		private static readonly IntPtr NativeMethodInfoPtr_GetSchemaNames_Internal_SchemaNames_XmlNameTable_0;

		// Token: 0x04001B89 RID: 7049
		private static readonly IntPtr NativeMethodInfoPtr_Add_Internal_XmlSchema_String_SchemaInfo_XmlSchema_Boolean_0;

		// Token: 0x04001B8A RID: 7050
		private static readonly IntPtr NativeMethodInfoPtr_Add_Private_XmlSchema_String_SchemaInfo_XmlSchema_Boolean_XmlResolver_0;

		// Token: 0x04001B8B RID: 7051
		private static readonly IntPtr NativeMethodInfoPtr_Add_Private_Void_String_XmlSchemaCollectionNode_0;

		// Token: 0x04001B8C RID: 7052
		private static readonly IntPtr NativeMethodInfoPtr_get_EventHandler_Internal_get_ValidationEventHandler_0;

		// Token: 0x04001B8D RID: 7053
		private static readonly IntPtr NativeMethodInfoPtr_set_EventHandler_Internal_set_Void_ValidationEventHandler_0;
	}
}
