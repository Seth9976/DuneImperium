using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace Il2CppSystem.Data
{
	// Token: 0x02000060 RID: 96
	public sealed class NameNode : ExpressionNode
	{
		// Token: 0x06000963 RID: 2403 RVA: 0x00031208 File Offset: 0x0002F408
		// Note: this type is marked as 'beforefieldinit'.
		static NameNode()
		{
			Il2CppClassPointerStore<NameNode>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Data.dll", "System.Data", "NameNode");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NameNode>.NativeClassPtr);
			NameNode.NativeFieldInfoPtr__name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NameNode>.NativeClassPtr, "_name");
			NameNode.NativeFieldInfoPtr__found = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NameNode>.NativeClassPtr, "_found");
			NameNode.NativeFieldInfoPtr__column = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NameNode>.NativeClassPtr, "_column");
			NameNode.NativeMethodInfoPtr__ctor_Internal_Void_DataTable_Il2CppStructArray_1_Char_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NameNode>.NativeClassPtr, 100664843);
			NameNode.NativeMethodInfoPtr__ctor_Internal_Void_DataTable_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NameNode>.NativeClassPtr, 100664844);
			NameNode.NativeMethodInfoPtr_get_IsSqlColumn_Internal_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NameNode>.NativeClassPtr, 100664845);
			NameNode.NativeMethodInfoPtr_Bind_Internal_Virtual_Void_DataTable_List_1_DataColumn_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NameNode>.NativeClassPtr, 100664846);
			NameNode.NativeMethodInfoPtr_Eval_Internal_Virtual_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NameNode>.NativeClassPtr, 100664847);
			NameNode.NativeMethodInfoPtr_Eval_Internal_Virtual_Object_DataRow_DataRowVersion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NameNode>.NativeClassPtr, 100664848);
			NameNode.NativeMethodInfoPtr_Eval_Internal_Virtual_Object_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NameNode>.NativeClassPtr, 100664849);
			NameNode.NativeMethodInfoPtr_IsConstant_Internal_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NameNode>.NativeClassPtr, 100664850);
			NameNode.NativeMethodInfoPtr_IsTableConstant_Internal_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NameNode>.NativeClassPtr, 100664851);
			NameNode.NativeMethodInfoPtr_HasLocalAggregate_Internal_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NameNode>.NativeClassPtr, 100664852);
			NameNode.NativeMethodInfoPtr_HasRemoteAggregate_Internal_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NameNode>.NativeClassPtr, 100664853);
			NameNode.NativeMethodInfoPtr_DependsOn_Internal_Virtual_Boolean_DataColumn_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NameNode>.NativeClassPtr, 100664854);
			NameNode.NativeMethodInfoPtr_Optimize_Internal_Virtual_ExpressionNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NameNode>.NativeClassPtr, 100664855);
			NameNode.NativeMethodInfoPtr_ParseName_Internal_Static_String_Il2CppStructArray_1_Char_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NameNode>.NativeClassPtr, 100664856);
		}

		// Token: 0x06000964 RID: 2404 RVA: 0x0003138C File Offset: 0x0002F58C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 904597, RefRangeEnd = 904598, XrefRangeStart = 904593, XrefRangeEnd = 904597, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NameNode(DataTable table, Il2CppStructArray<char> text, int start, int pos)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NameNode>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(table);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(text);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pos;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NameNode.NativeMethodInfoPtr__ctor_Internal_Void_DataTable_Il2CppStructArray_1_Char_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000965 RID: 2405 RVA: 0x00031408 File Offset: 0x0002F608
		[CallerCount(54)]
		[CachedScanResults(RefRangeStart = 296744, RefRangeEnd = 296798, XrefRangeStart = 296744, XrefRangeEnd = 296798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NameNode(DataTable table, string name)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NameNode>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(table);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NameNode.NativeMethodInfoPtr__ctor_Internal_Void_DataTable_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700025B RID: 603
		// (get) Token: 0x06000966 RID: 2406 RVA: 0x00031468 File Offset: 0x0002F668
		public unsafe override bool IsSqlColumn
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NameNode.NativeMethodInfoPtr_get_IsSqlColumn_Internal_Virtual_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000967 RID: 2407 RVA: 0x000314A4 File Offset: 0x0002F6A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 904598, XrefRangeEnd = 904610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Bind(DataTable table, List<DataColumn> list)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(table);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(list);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NameNode.NativeMethodInfoPtr_Bind_Internal_Virtual_Void_DataTable_List_1_DataColumn_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000968 RID: 2408 RVA: 0x000314F8 File Offset: 0x0002F6F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 904610, XrefRangeEnd = 904613, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Object Eval()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NameNode.NativeMethodInfoPtr_Eval_Internal_Virtual_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06000969 RID: 2409 RVA: 0x00031538 File Offset: 0x0002F738
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 904613, XrefRangeEnd = 904623, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Object Eval(DataRow row, DataRowVersion version)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(row);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref version;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NameNode.NativeMethodInfoPtr_Eval_Internal_Virtual_Object_DataRow_DataRowVersion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x0600096A RID: 2410 RVA: 0x00031598 File Offset: 0x0002F798
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 904623, XrefRangeEnd = 904627, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Object Eval(Il2CppStructArray<int> records)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(records);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NameNode.NativeMethodInfoPtr_Eval_Internal_Virtual_Object_Il2CppStructArray_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x0600096B RID: 2411 RVA: 0x000315E8 File Offset: 0x0002F7E8
		[CallerCount(184)]
		[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool IsConstant()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NameNode.NativeMethodInfoPtr_IsConstant_Internal_Virtual_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600096C RID: 2412 RVA: 0x00031624 File Offset: 0x0002F824
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 904627, XrefRangeEnd = 904628, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool IsTableConstant()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NameNode.NativeMethodInfoPtr_IsTableConstant_Internal_Virtual_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600096D RID: 2413 RVA: 0x00031660 File Offset: 0x0002F860
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 904628, XrefRangeEnd = 904629, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool HasLocalAggregate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NameNode.NativeMethodInfoPtr_HasLocalAggregate_Internal_Virtual_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600096E RID: 2414 RVA: 0x0003169C File Offset: 0x0002F89C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 904629, XrefRangeEnd = 904630, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool HasRemoteAggregate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NameNode.NativeMethodInfoPtr_HasRemoteAggregate_Internal_Virtual_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600096F RID: 2415 RVA: 0x000316D8 File Offset: 0x0002F8D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 904630, XrefRangeEnd = 904631, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool DependsOn(DataColumn column)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(column);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NameNode.NativeMethodInfoPtr_DependsOn_Internal_Virtual_Boolean_DataColumn_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000970 RID: 2416 RVA: 0x00031728 File Offset: 0x0002F928
		[CallerCount(1295)]
		[CachedScanResults(RefRangeStart = 308780, RefRangeEnd = 310075, XrefRangeStart = 308780, XrefRangeEnd = 310075, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override ExpressionNode Optimize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NameNode.NativeMethodInfoPtr_Optimize_Internal_Virtual_ExpressionNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ExpressionNode>(intPtr3) : null;
		}

		// Token: 0x06000971 RID: 2417 RVA: 0x00031768 File Offset: 0x0002F968
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 904640, RefRangeEnd = 904646, XrefRangeStart = 904631, XrefRangeEnd = 904640, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ParseName(Il2CppStructArray<char> text, int start, int pos)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(text);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pos;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NameNode.NativeMethodInfoPtr_ParseName_Internal_Static_String_Il2CppStructArray_1_Char_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000972 RID: 2418 RVA: 0x00004D63 File Offset: 0x00002F63
		public NameNode(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000258 RID: 600
		// (get) Token: 0x06000973 RID: 2419 RVA: 0x000317C0 File Offset: 0x0002F9C0
		// (set) Token: 0x06000974 RID: 2420 RVA: 0x00004D6C File Offset: 0x00002F6C
		public unsafe string _name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NameNode.NativeFieldInfoPtr__name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NameNode.NativeFieldInfoPtr__name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000259 RID: 601
		// (get) Token: 0x06000975 RID: 2421 RVA: 0x000317E8 File Offset: 0x0002F9E8
		// (set) Token: 0x06000976 RID: 2422 RVA: 0x00004D8B File Offset: 0x00002F8B
		public unsafe bool _found
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NameNode.NativeFieldInfoPtr__found);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NameNode.NativeFieldInfoPtr__found)) = value;
			}
		}

		// Token: 0x1700025A RID: 602
		// (get) Token: 0x06000977 RID: 2423 RVA: 0x00031810 File Offset: 0x0002FA10
		// (set) Token: 0x06000978 RID: 2424 RVA: 0x00004DA6 File Offset: 0x00002FA6
		public unsafe DataColumn _column
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NameNode.NativeFieldInfoPtr__column);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DataColumn>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NameNode.NativeFieldInfoPtr__column), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040007CE RID: 1998
		private static readonly IntPtr NativeFieldInfoPtr__name;

		// Token: 0x040007CF RID: 1999
		private static readonly IntPtr NativeFieldInfoPtr__found;

		// Token: 0x040007D0 RID: 2000
		private static readonly IntPtr NativeFieldInfoPtr__column;

		// Token: 0x040007D1 RID: 2001
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_DataTable_Il2CppStructArray_1_Char_Int32_Int32_0;

		// Token: 0x040007D2 RID: 2002
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_DataTable_String_0;

		// Token: 0x040007D3 RID: 2003
		private static readonly IntPtr NativeMethodInfoPtr_get_IsSqlColumn_Internal_Virtual_get_Boolean_0;

		// Token: 0x040007D4 RID: 2004
		private static readonly IntPtr NativeMethodInfoPtr_Bind_Internal_Virtual_Void_DataTable_List_1_DataColumn_0;

		// Token: 0x040007D5 RID: 2005
		private static readonly IntPtr NativeMethodInfoPtr_Eval_Internal_Virtual_Object_0;

		// Token: 0x040007D6 RID: 2006
		private static readonly IntPtr NativeMethodInfoPtr_Eval_Internal_Virtual_Object_DataRow_DataRowVersion_0;

		// Token: 0x040007D7 RID: 2007
		private static readonly IntPtr NativeMethodInfoPtr_Eval_Internal_Virtual_Object_Il2CppStructArray_1_Int32_0;

		// Token: 0x040007D8 RID: 2008
		private static readonly IntPtr NativeMethodInfoPtr_IsConstant_Internal_Virtual_Boolean_0;

		// Token: 0x040007D9 RID: 2009
		private static readonly IntPtr NativeMethodInfoPtr_IsTableConstant_Internal_Virtual_Boolean_0;

		// Token: 0x040007DA RID: 2010
		private static readonly IntPtr NativeMethodInfoPtr_HasLocalAggregate_Internal_Virtual_Boolean_0;

		// Token: 0x040007DB RID: 2011
		private static readonly IntPtr NativeMethodInfoPtr_HasRemoteAggregate_Internal_Virtual_Boolean_0;

		// Token: 0x040007DC RID: 2012
		private static readonly IntPtr NativeMethodInfoPtr_DependsOn_Internal_Virtual_Boolean_DataColumn_0;

		// Token: 0x040007DD RID: 2013
		private static readonly IntPtr NativeMethodInfoPtr_Optimize_Internal_Virtual_ExpressionNode_0;

		// Token: 0x040007DE RID: 2014
		private static readonly IntPtr NativeMethodInfoPtr_ParseName_Internal_Static_String_Il2CppStructArray_1_Char_Int32_Int32_0;
	}
}
