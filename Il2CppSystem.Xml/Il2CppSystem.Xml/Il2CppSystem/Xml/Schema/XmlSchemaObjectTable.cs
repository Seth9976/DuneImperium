using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x020001D2 RID: 466
	public class XmlSchemaObjectTable : Object
	{
		// Token: 0x06002714 RID: 10004 RVA: 0x000B6A2C File Offset: 0x000B4C2C
		// Note: this type is marked as 'beforefieldinit'.
		static XmlSchemaObjectTable()
		{
			Il2CppClassPointerStore<XmlSchemaObjectTable>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "XmlSchemaObjectTable");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlSchemaObjectTable>.NativeClassPtr);
			XmlSchemaObjectTable.NativeFieldInfoPtr_table = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaObjectTable>.NativeClassPtr, "table");
			XmlSchemaObjectTable.NativeFieldInfoPtr_entries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaObjectTable>.NativeClassPtr, "entries");
			XmlSchemaObjectTable.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaObjectTable>.NativeClassPtr, 100668942);
			XmlSchemaObjectTable.NativeMethodInfoPtr_Add_Internal_Void_XmlQualifiedName_XmlSchemaObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaObjectTable>.NativeClassPtr, 100668943);
			XmlSchemaObjectTable.NativeMethodInfoPtr_Insert_Internal_Void_XmlQualifiedName_XmlSchemaObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaObjectTable>.NativeClassPtr, 100668944);
			XmlSchemaObjectTable.NativeMethodInfoPtr_Replace_Internal_Void_XmlQualifiedName_XmlSchemaObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaObjectTable>.NativeClassPtr, 100668945);
			XmlSchemaObjectTable.NativeMethodInfoPtr_Clear_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaObjectTable>.NativeClassPtr, 100668946);
			XmlSchemaObjectTable.NativeMethodInfoPtr_Remove_Internal_Void_XmlQualifiedName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaObjectTable>.NativeClassPtr, 100668947);
			XmlSchemaObjectTable.NativeMethodInfoPtr_FindIndexByValue_Private_Int32_XmlSchemaObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaObjectTable>.NativeClassPtr, 100668948);
			XmlSchemaObjectTable.NativeMethodInfoPtr_get_Count_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaObjectTable>.NativeClassPtr, 100668949);
			XmlSchemaObjectTable.NativeMethodInfoPtr_Contains_Public_Boolean_XmlQualifiedName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaObjectTable>.NativeClassPtr, 100668950);
			XmlSchemaObjectTable.NativeMethodInfoPtr_get_Item_Public_get_XmlSchemaObject_XmlQualifiedName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaObjectTable>.NativeClassPtr, 100668951);
			XmlSchemaObjectTable.NativeMethodInfoPtr_get_Values_Public_get_ICollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaObjectTable>.NativeClassPtr, 100668952);
			XmlSchemaObjectTable.NativeMethodInfoPtr_GetEnumerator_Public_IDictionaryEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaObjectTable>.NativeClassPtr, 100668953);
		}

		// Token: 0x06002715 RID: 10005 RVA: 0x000B6B74 File Offset: 0x000B4D74
		[CallerCount(40)]
		[CachedScanResults(RefRangeStart = 412703, RefRangeEnd = 412743, XrefRangeStart = 412688, XrefRangeEnd = 412703, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlSchemaObjectTable()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlSchemaObjectTable>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaObjectTable.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002716 RID: 10006 RVA: 0x000B6BB0 File Offset: 0x000B4DB0
		[CallerCount(19)]
		[CachedScanResults(RefRangeStart = 412751, RefRangeEnd = 412770, XrefRangeStart = 412743, XrefRangeEnd = 412751, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Add(XmlQualifiedName name, XmlSchemaObject value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaObjectTable.NativeMethodInfoPtr_Add_Internal_Void_XmlQualifiedName_XmlSchemaObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002717 RID: 10007 RVA: 0x000B6C04 File Offset: 0x000B4E04
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 412776, RefRangeEnd = 412786, XrefRangeStart = 412770, XrefRangeEnd = 412776, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Insert(XmlQualifiedName name, XmlSchemaObject value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaObjectTable.NativeMethodInfoPtr_Insert_Internal_Void_XmlQualifiedName_XmlSchemaObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002718 RID: 10008 RVA: 0x000B6C58 File Offset: 0x000B4E58
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 412798, RefRangeEnd = 412803, XrefRangeStart = 412786, XrefRangeEnd = 412798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Replace(XmlQualifiedName name, XmlSchemaObject value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaObjectTable.NativeMethodInfoPtr_Replace_Internal_Void_XmlQualifiedName_XmlSchemaObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002719 RID: 10009 RVA: 0x000B6CAC File Offset: 0x000B4EAC
		[CallerCount(56)]
		[CachedScanResults(RefRangeStart = 412808, RefRangeEnd = 412864, XrefRangeStart = 412803, XrefRangeEnd = 412808, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Clear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaObjectTable.NativeMethodInfoPtr_Clear_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600271A RID: 10010 RVA: 0x000B6CE0 File Offset: 0x000B4EE0
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 412874, RefRangeEnd = 412881, XrefRangeStart = 412864, XrefRangeEnd = 412874, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Remove(XmlQualifiedName name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaObjectTable.NativeMethodInfoPtr_Remove_Internal_Void_XmlQualifiedName_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600271B RID: 10011 RVA: 0x000B6D24 File Offset: 0x000B4F24
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 412886, RefRangeEnd = 412888, XrefRangeStart = 412881, XrefRangeEnd = 412886, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int FindIndexByValue(XmlSchemaObject xso)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(xso);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaObjectTable.NativeMethodInfoPtr_FindIndexByValue_Private_Int32_XmlSchemaObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000D55 RID: 3413
		// (get) Token: 0x0600271C RID: 10012 RVA: 0x000B6D74 File Offset: 0x000B4F74
		public unsafe int Count
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 412892, RefRangeEnd = 412897, XrefRangeStart = 412888, XrefRangeEnd = 412892, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaObjectTable.NativeMethodInfoPtr_get_Count_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600271D RID: 10013 RVA: 0x000B6DB0 File Offset: 0x000B4FB0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 412901, RefRangeEnd = 412902, XrefRangeStart = 412897, XrefRangeEnd = 412901, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Contains(XmlQualifiedName name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaObjectTable.NativeMethodInfoPtr_Contains_Public_Boolean_XmlQualifiedName_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000D56 RID: 3414
		public unsafe XmlSchemaObject this[XmlQualifiedName name]
		{
			[CallerCount(81)]
			[CachedScanResults(RefRangeStart = 412905, RefRangeEnd = 412986, XrefRangeStart = 412902, XrefRangeEnd = 412905, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(name);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaObjectTable.NativeMethodInfoPtr_get_Item_Public_get_XmlSchemaObject_XmlQualifiedName_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaObject>(intPtr3) : null;
				}
			}
		}

		// Token: 0x17000D57 RID: 3415
		// (get) Token: 0x0600271F RID: 10015 RVA: 0x000B6E50 File Offset: 0x000B5050
		public unsafe ICollection Values
		{
			[CallerCount(84)]
			[CachedScanResults(RefRangeStart = 412994, RefRangeEnd = 413078, XrefRangeStart = 412986, XrefRangeEnd = 412994, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaObjectTable.NativeMethodInfoPtr_get_Values_Public_get_ICollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ICollection>(intPtr3) : null;
			}
		}

		// Token: 0x06002720 RID: 10016 RVA: 0x000B6E90 File Offset: 0x000B5090
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 413086, RefRangeEnd = 413089, XrefRangeStart = 413078, XrefRangeEnd = 413086, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IDictionaryEnumerator GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaObjectTable.NativeMethodInfoPtr_GetEnumerator_Public_IDictionaryEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IDictionaryEnumerator>(intPtr3) : null;
		}

		// Token: 0x06002721 RID: 10017 RVA: 0x00010904 File Offset: 0x0000EB04
		public XmlSchemaObjectTable(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000D53 RID: 3411
		// (get) Token: 0x06002722 RID: 10018 RVA: 0x000B6ED0 File Offset: 0x000B50D0
		// (set) Token: 0x06002723 RID: 10019 RVA: 0x0001090D File Offset: 0x0000EB0D
		public unsafe Dictionary<XmlQualifiedName, XmlSchemaObject> table
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaObjectTable.NativeFieldInfoPtr_table);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<XmlQualifiedName, XmlSchemaObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaObjectTable.NativeFieldInfoPtr_table), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D54 RID: 3412
		// (get) Token: 0x06002724 RID: 10020 RVA: 0x000B6F00 File Offset: 0x000B5100
		// (set) Token: 0x06002725 RID: 10021 RVA: 0x0001092C File Offset: 0x0000EB2C
		public unsafe List<XmlSchemaObjectTable.XmlSchemaObjectEntry> entries
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaObjectTable.NativeFieldInfoPtr_entries);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<XmlSchemaObjectTable.XmlSchemaObjectEntry>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaObjectTable.NativeFieldInfoPtr_entries), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001D7E RID: 7550
		private static readonly IntPtr NativeFieldInfoPtr_table;

		// Token: 0x04001D7F RID: 7551
		private static readonly IntPtr NativeFieldInfoPtr_entries;

		// Token: 0x04001D80 RID: 7552
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

		// Token: 0x04001D81 RID: 7553
		private static readonly IntPtr NativeMethodInfoPtr_Add_Internal_Void_XmlQualifiedName_XmlSchemaObject_0;

		// Token: 0x04001D82 RID: 7554
		private static readonly IntPtr NativeMethodInfoPtr_Insert_Internal_Void_XmlQualifiedName_XmlSchemaObject_0;

		// Token: 0x04001D83 RID: 7555
		private static readonly IntPtr NativeMethodInfoPtr_Replace_Internal_Void_XmlQualifiedName_XmlSchemaObject_0;

		// Token: 0x04001D84 RID: 7556
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Internal_Void_0;

		// Token: 0x04001D85 RID: 7557
		private static readonly IntPtr NativeMethodInfoPtr_Remove_Internal_Void_XmlQualifiedName_0;

		// Token: 0x04001D86 RID: 7558
		private static readonly IntPtr NativeMethodInfoPtr_FindIndexByValue_Private_Int32_XmlSchemaObject_0;

		// Token: 0x04001D87 RID: 7559
		private static readonly IntPtr NativeMethodInfoPtr_get_Count_Public_get_Int32_0;

		// Token: 0x04001D88 RID: 7560
		private static readonly IntPtr NativeMethodInfoPtr_Contains_Public_Boolean_XmlQualifiedName_0;

		// Token: 0x04001D89 RID: 7561
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_get_XmlSchemaObject_XmlQualifiedName_0;

		// Token: 0x04001D8A RID: 7562
		private static readonly IntPtr NativeMethodInfoPtr_get_Values_Public_get_ICollection_0;

		// Token: 0x04001D8B RID: 7563
		private static readonly IntPtr NativeMethodInfoPtr_GetEnumerator_Public_IDictionaryEnumerator_0;

		// Token: 0x0200026C RID: 620
		public enum EnumeratorType
		{
			// Token: 0x04002749 RID: 10057
			Keys,
			// Token: 0x0400274A RID: 10058
			Values,
			// Token: 0x0400274B RID: 10059
			DictionaryEntry
		}

		// Token: 0x0200026D RID: 621
		public sealed class XmlSchemaObjectEntry : ValueType
		{
			// Token: 0x0600324C RID: 12876 RVA: 0x000DF4E8 File Offset: 0x000DD6E8
			// Note: this type is marked as 'beforefieldinit'.
			static XmlSchemaObjectEntry()
			{
				Il2CppClassPointerStore<XmlSchemaObjectTable.XmlSchemaObjectEntry>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<XmlSchemaObjectTable>.NativeClassPtr, "XmlSchemaObjectEntry");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlSchemaObjectTable.XmlSchemaObjectEntry>.NativeClassPtr);
				XmlSchemaObjectTable.XmlSchemaObjectEntry.NativeFieldInfoPtr_qname = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaObjectTable.XmlSchemaObjectEntry>.NativeClassPtr, "qname");
				XmlSchemaObjectTable.XmlSchemaObjectEntry.NativeFieldInfoPtr_xso = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaObjectTable.XmlSchemaObjectEntry>.NativeClassPtr, "xso");
				XmlSchemaObjectTable.XmlSchemaObjectEntry.NativeMethodInfoPtr__ctor_Public_Void_XmlQualifiedName_XmlSchemaObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaObjectTable.XmlSchemaObjectEntry>.NativeClassPtr, 100668954);
			}

			// Token: 0x0600324D RID: 12877 RVA: 0x000DF550 File Offset: 0x000DD750
			[CallerCount(238)]
			[CachedScanResults(RefRangeStart = 342357, RefRangeEnd = 342595, XrefRangeStart = 342357, XrefRangeEnd = 342595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe XmlSchemaObjectEntry(XmlQualifiedName name, XmlSchemaObject value)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlSchemaObjectTable.XmlSchemaObjectEntry>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(name);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaObjectTable.XmlSchemaObjectEntry.NativeMethodInfoPtr__ctor_Public_Void_XmlQualifiedName_XmlSchemaObject_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600324E RID: 12878 RVA: 0x000158A4 File Offset: 0x00013AA4
			public XmlSchemaObjectEntry(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0600324F RID: 12879 RVA: 0x000158AD File Offset: 0x00013AAD
			public XmlSchemaObjectEntry()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlSchemaObjectTable.XmlSchemaObjectEntry>.NativeClassPtr))
			{
			}

			// Token: 0x170010EA RID: 4330
			// (get) Token: 0x06003250 RID: 12880 RVA: 0x000DF5B4 File Offset: 0x000DD7B4
			// (set) Token: 0x06003251 RID: 12881 RVA: 0x000158BF File Offset: 0x00013ABF
			public unsafe XmlQualifiedName qname
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaObjectTable.XmlSchemaObjectEntry.NativeFieldInfoPtr_qname);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaObjectTable.XmlSchemaObjectEntry.NativeFieldInfoPtr_qname), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170010EB RID: 4331
			// (get) Token: 0x06003252 RID: 12882 RVA: 0x000DF5E4 File Offset: 0x000DD7E4
			// (set) Token: 0x06003253 RID: 12883 RVA: 0x000158DE File Offset: 0x00013ADE
			public unsafe XmlSchemaObject xso
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaObjectTable.XmlSchemaObjectEntry.NativeFieldInfoPtr_xso);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaObject>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaObjectTable.XmlSchemaObjectEntry.NativeFieldInfoPtr_xso), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400274C RID: 10060
			private static readonly IntPtr NativeFieldInfoPtr_qname;

			// Token: 0x0400274D RID: 10061
			private static readonly IntPtr NativeFieldInfoPtr_xso;

			// Token: 0x0400274E RID: 10062
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_XmlQualifiedName_XmlSchemaObject_0;
		}

		// Token: 0x0200026E RID: 622
		public class ValuesCollection : Object
		{
			// Token: 0x06003254 RID: 12884 RVA: 0x000DF614 File Offset: 0x000DD814
			// Note: this type is marked as 'beforefieldinit'.
			static ValuesCollection()
			{
				Il2CppClassPointerStore<XmlSchemaObjectTable.ValuesCollection>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<XmlSchemaObjectTable>.NativeClassPtr, "ValuesCollection");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlSchemaObjectTable.ValuesCollection>.NativeClassPtr);
				XmlSchemaObjectTable.ValuesCollection.NativeFieldInfoPtr_entries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaObjectTable.ValuesCollection>.NativeClassPtr, "entries");
				XmlSchemaObjectTable.ValuesCollection.NativeFieldInfoPtr_size = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaObjectTable.ValuesCollection>.NativeClassPtr, "size");
				XmlSchemaObjectTable.ValuesCollection.NativeMethodInfoPtr__ctor_Internal_Void_List_1_XmlSchemaObjectEntry_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaObjectTable.ValuesCollection>.NativeClassPtr, 100668955);
				XmlSchemaObjectTable.ValuesCollection.NativeMethodInfoPtr_get_Count_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaObjectTable.ValuesCollection>.NativeClassPtr, 100668956);
				XmlSchemaObjectTable.ValuesCollection.NativeMethodInfoPtr_get_SyncRoot_Public_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaObjectTable.ValuesCollection>.NativeClassPtr, 100668957);
				XmlSchemaObjectTable.ValuesCollection.NativeMethodInfoPtr_get_IsSynchronized_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaObjectTable.ValuesCollection>.NativeClassPtr, 100668958);
				XmlSchemaObjectTable.ValuesCollection.NativeMethodInfoPtr_CopyTo_Public_Virtual_Final_New_Void_Array_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaObjectTable.ValuesCollection>.NativeClassPtr, 100668959);
				XmlSchemaObjectTable.ValuesCollection.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaObjectTable.ValuesCollection>.NativeClassPtr, 100668960);
			}

			// Token: 0x06003255 RID: 12885 RVA: 0x000DF6E0 File Offset: 0x000DD8E0
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 412652, RefRangeEnd = 412658, XrefRangeStart = 412650, XrefRangeEnd = 412652, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ValuesCollection(List<XmlSchemaObjectTable.XmlSchemaObjectEntry> entries, int size)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlSchemaObjectTable.ValuesCollection>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(entries);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaObjectTable.ValuesCollection.NativeMethodInfoPtr__ctor_Internal_Void_List_1_XmlSchemaObjectEntry_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170010EE RID: 4334
			// (get) Token: 0x06003256 RID: 12886 RVA: 0x000DF73C File Offset: 0x000DD93C
			public unsafe virtual int Count
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaObjectTable.ValuesCollection.NativeMethodInfoPtr_get_Count_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x170010EF RID: 4335
			// (get) Token: 0x06003257 RID: 12887 RVA: 0x000DF778 File Offset: 0x000DD978
			public unsafe virtual Object SyncRoot
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 412658, XrefRangeEnd = 412662, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaObjectTable.ValuesCollection.NativeMethodInfoPtr_get_SyncRoot_Public_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x170010F0 RID: 4336
			// (get) Token: 0x06003258 RID: 12888 RVA: 0x000DF7B8 File Offset: 0x000DD9B8
			public unsafe virtual bool IsSynchronized
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 412662, XrefRangeEnd = 412666, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaObjectTable.ValuesCollection.NativeMethodInfoPtr_get_IsSynchronized_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06003259 RID: 12889 RVA: 0x000DF7F4 File Offset: 0x000DD9F4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 412666, XrefRangeEnd = 412670, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual void CopyTo(Array array, int arrayIndex)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref arrayIndex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaObjectTable.ValuesCollection.NativeMethodInfoPtr_CopyTo_Public_Virtual_Final_New_Void_Array_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600325A RID: 12890 RVA: 0x000DF844 File Offset: 0x000DDA44
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 412670, XrefRangeEnd = 412675, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual IEnumerator GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaObjectTable.ValuesCollection.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600325B RID: 12891 RVA: 0x000158FD File Offset: 0x00013AFD
			public ValuesCollection(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170010EC RID: 4332
			// (get) Token: 0x0600325C RID: 12892 RVA: 0x000DF884 File Offset: 0x000DDA84
			// (set) Token: 0x0600325D RID: 12893 RVA: 0x00015906 File Offset: 0x00013B06
			public unsafe List<XmlSchemaObjectTable.XmlSchemaObjectEntry> entries
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaObjectTable.ValuesCollection.NativeFieldInfoPtr_entries);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<XmlSchemaObjectTable.XmlSchemaObjectEntry>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaObjectTable.ValuesCollection.NativeFieldInfoPtr_entries), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170010ED RID: 4333
			// (get) Token: 0x0600325E RID: 12894 RVA: 0x000DF8B4 File Offset: 0x000DDAB4
			// (set) Token: 0x0600325F RID: 12895 RVA: 0x00015925 File Offset: 0x00013B25
			public unsafe int size
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaObjectTable.ValuesCollection.NativeFieldInfoPtr_size);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaObjectTable.ValuesCollection.NativeFieldInfoPtr_size)) = value;
				}
			}

			// Token: 0x0400274F RID: 10063
			private static readonly IntPtr NativeFieldInfoPtr_entries;

			// Token: 0x04002750 RID: 10064
			private static readonly IntPtr NativeFieldInfoPtr_size;

			// Token: 0x04002751 RID: 10065
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_List_1_XmlSchemaObjectEntry_Int32_0;

			// Token: 0x04002752 RID: 10066
			private static readonly IntPtr NativeMethodInfoPtr_get_Count_Public_Virtual_Final_New_get_Int32_0;

			// Token: 0x04002753 RID: 10067
			private static readonly IntPtr NativeMethodInfoPtr_get_SyncRoot_Public_Virtual_Final_New_get_Object_0;

			// Token: 0x04002754 RID: 10068
			private static readonly IntPtr NativeMethodInfoPtr_get_IsSynchronized_Public_Virtual_Final_New_get_Boolean_0;

			// Token: 0x04002755 RID: 10069
			private static readonly IntPtr NativeMethodInfoPtr_CopyTo_Public_Virtual_Final_New_Void_Array_Int32_0;

			// Token: 0x04002756 RID: 10070
			private static readonly IntPtr NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x0200026F RID: 623
		public class XSOEnumerator : Object
		{
			// Token: 0x06003260 RID: 12896 RVA: 0x000DF8DC File Offset: 0x000DDADC
			// Note: this type is marked as 'beforefieldinit'.
			static XSOEnumerator()
			{
				Il2CppClassPointerStore<XmlSchemaObjectTable.XSOEnumerator>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<XmlSchemaObjectTable>.NativeClassPtr, "XSOEnumerator");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlSchemaObjectTable.XSOEnumerator>.NativeClassPtr);
				XmlSchemaObjectTable.XSOEnumerator.NativeFieldInfoPtr_entries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaObjectTable.XSOEnumerator>.NativeClassPtr, "entries");
				XmlSchemaObjectTable.XSOEnumerator.NativeFieldInfoPtr_enumType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaObjectTable.XSOEnumerator>.NativeClassPtr, "enumType");
				XmlSchemaObjectTable.XSOEnumerator.NativeFieldInfoPtr_currentIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaObjectTable.XSOEnumerator>.NativeClassPtr, "currentIndex");
				XmlSchemaObjectTable.XSOEnumerator.NativeFieldInfoPtr_size = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaObjectTable.XSOEnumerator>.NativeClassPtr, "size");
				XmlSchemaObjectTable.XSOEnumerator.NativeFieldInfoPtr_currentKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaObjectTable.XSOEnumerator>.NativeClassPtr, "currentKey");
				XmlSchemaObjectTable.XSOEnumerator.NativeFieldInfoPtr_currentValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaObjectTable.XSOEnumerator>.NativeClassPtr, "currentValue");
				XmlSchemaObjectTable.XSOEnumerator.NativeMethodInfoPtr__ctor_Internal_Void_List_1_XmlSchemaObjectEntry_Int32_EnumeratorType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaObjectTable.XSOEnumerator>.NativeClassPtr, 100668961);
				XmlSchemaObjectTable.XSOEnumerator.NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaObjectTable.XSOEnumerator>.NativeClassPtr, 100668962);
				XmlSchemaObjectTable.XSOEnumerator.NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaObjectTable.XSOEnumerator>.NativeClassPtr, 100668963);
				XmlSchemaObjectTable.XSOEnumerator.NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaObjectTable.XSOEnumerator>.NativeClassPtr, 100668964);
			}

			// Token: 0x06003261 RID: 12897 RVA: 0x000DF9D0 File Offset: 0x000DDBD0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 412675, XrefRangeEnd = 412677, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe XSOEnumerator(List<XmlSchemaObjectTable.XmlSchemaObjectEntry> entries, int size, XmlSchemaObjectTable.EnumeratorType enumType)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlSchemaObjectTable.XSOEnumerator>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(entries);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref enumType;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaObjectTable.XSOEnumerator.NativeMethodInfoPtr__ctor_Internal_Void_List_1_XmlSchemaObjectEntry_Int32_EnumeratorType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170010F7 RID: 4343
			// (get) Token: 0x06003262 RID: 12898 RVA: 0x000DFA38 File Offset: 0x000DDC38
			public unsafe virtual Object Current
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 412677, XrefRangeEnd = 412678, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaObjectTable.XSOEnumerator.NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06003263 RID: 12899 RVA: 0x000DFA78 File Offset: 0x000DDC78
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 412678, XrefRangeEnd = 412685, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaObjectTable.XSOEnumerator.NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06003264 RID: 12900 RVA: 0x000DFAB4 File Offset: 0x000DDCB4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 412685, XrefRangeEnd = 412687, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual void Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaObjectTable.XSOEnumerator.NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003265 RID: 12901 RVA: 0x00015940 File Offset: 0x00013B40
			public XSOEnumerator(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170010F1 RID: 4337
			// (get) Token: 0x06003266 RID: 12902 RVA: 0x000DFAE8 File Offset: 0x000DDCE8
			// (set) Token: 0x06003267 RID: 12903 RVA: 0x00015949 File Offset: 0x00013B49
			public unsafe List<XmlSchemaObjectTable.XmlSchemaObjectEntry> entries
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaObjectTable.XSOEnumerator.NativeFieldInfoPtr_entries);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<XmlSchemaObjectTable.XmlSchemaObjectEntry>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaObjectTable.XSOEnumerator.NativeFieldInfoPtr_entries), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170010F2 RID: 4338
			// (get) Token: 0x06003268 RID: 12904 RVA: 0x000DFB18 File Offset: 0x000DDD18
			// (set) Token: 0x06003269 RID: 12905 RVA: 0x00015968 File Offset: 0x00013B68
			public unsafe XmlSchemaObjectTable.EnumeratorType enumType
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaObjectTable.XSOEnumerator.NativeFieldInfoPtr_enumType);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaObjectTable.XSOEnumerator.NativeFieldInfoPtr_enumType)) = value;
				}
			}

			// Token: 0x170010F3 RID: 4339
			// (get) Token: 0x0600326A RID: 12906 RVA: 0x000DFB40 File Offset: 0x000DDD40
			// (set) Token: 0x0600326B RID: 12907 RVA: 0x00015983 File Offset: 0x00013B83
			public unsafe int currentIndex
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaObjectTable.XSOEnumerator.NativeFieldInfoPtr_currentIndex);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaObjectTable.XSOEnumerator.NativeFieldInfoPtr_currentIndex)) = value;
				}
			}

			// Token: 0x170010F4 RID: 4340
			// (get) Token: 0x0600326C RID: 12908 RVA: 0x000DFB68 File Offset: 0x000DDD68
			// (set) Token: 0x0600326D RID: 12909 RVA: 0x0001599E File Offset: 0x00013B9E
			public unsafe int size
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaObjectTable.XSOEnumerator.NativeFieldInfoPtr_size);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaObjectTable.XSOEnumerator.NativeFieldInfoPtr_size)) = value;
				}
			}

			// Token: 0x170010F5 RID: 4341
			// (get) Token: 0x0600326E RID: 12910 RVA: 0x000DFB90 File Offset: 0x000DDD90
			// (set) Token: 0x0600326F RID: 12911 RVA: 0x000159B9 File Offset: 0x00013BB9
			public unsafe XmlQualifiedName currentKey
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaObjectTable.XSOEnumerator.NativeFieldInfoPtr_currentKey);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaObjectTable.XSOEnumerator.NativeFieldInfoPtr_currentKey), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170010F6 RID: 4342
			// (get) Token: 0x06003270 RID: 12912 RVA: 0x000DFBC0 File Offset: 0x000DDDC0
			// (set) Token: 0x06003271 RID: 12913 RVA: 0x000159D8 File Offset: 0x00013BD8
			public unsafe XmlSchemaObject currentValue
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaObjectTable.XSOEnumerator.NativeFieldInfoPtr_currentValue);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaObject>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaObjectTable.XSOEnumerator.NativeFieldInfoPtr_currentValue), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002757 RID: 10071
			private static readonly IntPtr NativeFieldInfoPtr_entries;

			// Token: 0x04002758 RID: 10072
			private static readonly IntPtr NativeFieldInfoPtr_enumType;

			// Token: 0x04002759 RID: 10073
			private static readonly IntPtr NativeFieldInfoPtr_currentIndex;

			// Token: 0x0400275A RID: 10074
			private static readonly IntPtr NativeFieldInfoPtr_size;

			// Token: 0x0400275B RID: 10075
			private static readonly IntPtr NativeFieldInfoPtr_currentKey;

			// Token: 0x0400275C RID: 10076
			private static readonly IntPtr NativeFieldInfoPtr_currentValue;

			// Token: 0x0400275D RID: 10077
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_List_1_XmlSchemaObjectEntry_Int32_EnumeratorType_0;

			// Token: 0x0400275E RID: 10078
			private static readonly IntPtr NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_Object_0;

			// Token: 0x0400275F RID: 10079
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0;

			// Token: 0x04002760 RID: 10080
			private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0;
		}

		// Token: 0x02000270 RID: 624
		public class XSODictionaryEnumerator : XmlSchemaObjectTable.XSOEnumerator
		{
			// Token: 0x06003272 RID: 12914 RVA: 0x000DFBF0 File Offset: 0x000DDDF0
			// Note: this type is marked as 'beforefieldinit'.
			static XSODictionaryEnumerator()
			{
				Il2CppClassPointerStore<XmlSchemaObjectTable.XSODictionaryEnumerator>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<XmlSchemaObjectTable>.NativeClassPtr, "XSODictionaryEnumerator");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlSchemaObjectTable.XSODictionaryEnumerator>.NativeClassPtr);
				XmlSchemaObjectTable.XSODictionaryEnumerator.NativeMethodInfoPtr__ctor_Internal_Void_List_1_XmlSchemaObjectEntry_Int32_EnumeratorType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaObjectTable.XSODictionaryEnumerator>.NativeClassPtr, 100668965);
				XmlSchemaObjectTable.XSODictionaryEnumerator.NativeMethodInfoPtr_get_Entry_Public_Virtual_Final_New_get_DictionaryEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaObjectTable.XSODictionaryEnumerator>.NativeClassPtr, 100668966);
				XmlSchemaObjectTable.XSODictionaryEnumerator.NativeMethodInfoPtr_get_Key_Public_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaObjectTable.XSODictionaryEnumerator>.NativeClassPtr, 100668967);
				XmlSchemaObjectTable.XSODictionaryEnumerator.NativeMethodInfoPtr_get_Value_Public_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaObjectTable.XSODictionaryEnumerator>.NativeClassPtr, 100668968);
			}

			// Token: 0x06003273 RID: 12915 RVA: 0x000DFC6C File Offset: 0x000DDE6C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe XSODictionaryEnumerator(List<XmlSchemaObjectTable.XmlSchemaObjectEntry> entries, int size, XmlSchemaObjectTable.EnumeratorType enumType)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlSchemaObjectTable.XSODictionaryEnumerator>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(entries);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref enumType;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaObjectTable.XSODictionaryEnumerator.NativeMethodInfoPtr__ctor_Internal_Void_List_1_XmlSchemaObjectEntry_Int32_EnumeratorType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170010F8 RID: 4344
			// (get) Token: 0x06003274 RID: 12916 RVA: 0x000DFCD4 File Offset: 0x000DDED4
			public unsafe virtual DictionaryEntry Entry
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 412687, XrefRangeEnd = 412688, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaObjectTable.XSODictionaryEnumerator.NativeMethodInfoPtr_get_Entry_Public_Virtual_Final_New_get_DictionaryEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return new DictionaryEntry(intPtr);
				}
			}

			// Token: 0x170010F9 RID: 4345
			// (get) Token: 0x06003275 RID: 12917 RVA: 0x000DFD0C File Offset: 0x000DDF0C
			public unsafe virtual Object Key
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaObjectTable.XSODictionaryEnumerator.NativeMethodInfoPtr_get_Key_Public_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x170010FA RID: 4346
			// (get) Token: 0x06003276 RID: 12918 RVA: 0x000DFD4C File Offset: 0x000DDF4C
			public unsafe virtual Object Value
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaObjectTable.XSODictionaryEnumerator.NativeMethodInfoPtr_get_Value_Public_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06003277 RID: 12919 RVA: 0x000159F7 File Offset: 0x00013BF7
			public XSODictionaryEnumerator(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04002761 RID: 10081
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_List_1_XmlSchemaObjectEntry_Int32_EnumeratorType_0;

			// Token: 0x04002762 RID: 10082
			private static readonly IntPtr NativeMethodInfoPtr_get_Entry_Public_Virtual_Final_New_get_DictionaryEntry_0;

			// Token: 0x04002763 RID: 10083
			private static readonly IntPtr NativeMethodInfoPtr_get_Key_Public_Virtual_Final_New_get_Object_0;

			// Token: 0x04002764 RID: 10084
			private static readonly IntPtr NativeMethodInfoPtr_get_Value_Public_Virtual_Final_New_get_Object_0;
		}
	}
}
