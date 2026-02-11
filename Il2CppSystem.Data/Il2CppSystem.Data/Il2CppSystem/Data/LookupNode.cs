using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace Il2CppSystem.Data
{
	// Token: 0x0200005F RID: 95
	public sealed class LookupNode : ExpressionNode
	{
		// Token: 0x0600094E RID: 2382 RVA: 0x00030CC8 File Offset: 0x0002EEC8
		// Note: this type is marked as 'beforefieldinit'.
		static LookupNode()
		{
			Il2CppClassPointerStore<LookupNode>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Data.dll", "System.Data", "LookupNode");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LookupNode>.NativeClassPtr);
			LookupNode.NativeFieldInfoPtr__relationName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LookupNode>.NativeClassPtr, "_relationName");
			LookupNode.NativeFieldInfoPtr__columnName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LookupNode>.NativeClassPtr, "_columnName");
			LookupNode.NativeFieldInfoPtr__column = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LookupNode>.NativeClassPtr, "_column");
			LookupNode.NativeFieldInfoPtr__relation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LookupNode>.NativeClassPtr, "_relation");
			LookupNode.NativeMethodInfoPtr__ctor_Internal_Void_DataTable_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LookupNode>.NativeClassPtr, 100664832);
			LookupNode.NativeMethodInfoPtr_Bind_Internal_Virtual_Void_DataTable_List_1_DataColumn_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LookupNode>.NativeClassPtr, 100664833);
			LookupNode.NativeMethodInfoPtr_Eval_Internal_Virtual_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LookupNode>.NativeClassPtr, 100664834);
			LookupNode.NativeMethodInfoPtr_Eval_Internal_Virtual_Object_DataRow_DataRowVersion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LookupNode>.NativeClassPtr, 100664835);
			LookupNode.NativeMethodInfoPtr_Eval_Internal_Virtual_Object_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LookupNode>.NativeClassPtr, 100664836);
			LookupNode.NativeMethodInfoPtr_IsConstant_Internal_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LookupNode>.NativeClassPtr, 100664837);
			LookupNode.NativeMethodInfoPtr_IsTableConstant_Internal_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LookupNode>.NativeClassPtr, 100664838);
			LookupNode.NativeMethodInfoPtr_HasLocalAggregate_Internal_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LookupNode>.NativeClassPtr, 100664839);
			LookupNode.NativeMethodInfoPtr_HasRemoteAggregate_Internal_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LookupNode>.NativeClassPtr, 100664840);
			LookupNode.NativeMethodInfoPtr_DependsOn_Internal_Virtual_Boolean_DataColumn_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LookupNode>.NativeClassPtr, 100664841);
			LookupNode.NativeMethodInfoPtr_Optimize_Internal_Virtual_ExpressionNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LookupNode>.NativeClassPtr, 100664842);
		}

		// Token: 0x0600094F RID: 2383 RVA: 0x00030E24 File Offset: 0x0002F024
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 904548, RefRangeEnd = 904549, XrefRangeStart = 904544, XrefRangeEnd = 904548, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LookupNode(DataTable table, string columnName, string relationName)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LookupNode>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(table);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(columnName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(relationName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LookupNode.NativeMethodInfoPtr__ctor_Internal_Void_DataTable_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000950 RID: 2384 RVA: 0x00030E94 File Offset: 0x0002F094
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 904549, XrefRangeEnd = 904579, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LookupNode.NativeMethodInfoPtr_Bind_Internal_Virtual_Void_DataTable_List_1_DataColumn_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000951 RID: 2385 RVA: 0x00030EE8 File Offset: 0x0002F0E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 904579, XrefRangeEnd = 904582, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Object Eval()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LookupNode.NativeMethodInfoPtr_Eval_Internal_Virtual_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06000952 RID: 2386 RVA: 0x00030F28 File Offset: 0x0002F128
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 904582, XrefRangeEnd = 904589, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LookupNode.NativeMethodInfoPtr_Eval_Internal_Virtual_Object_DataRow_DataRowVersion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06000953 RID: 2387 RVA: 0x00030F88 File Offset: 0x0002F188
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 904589, XrefRangeEnd = 904593, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Object Eval(Il2CppStructArray<int> recordNos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(recordNos);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LookupNode.NativeMethodInfoPtr_Eval_Internal_Virtual_Object_Il2CppStructArray_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06000954 RID: 2388 RVA: 0x00030FD8 File Offset: 0x0002F1D8
		[CallerCount(184)]
		[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool IsConstant()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LookupNode.NativeMethodInfoPtr_IsConstant_Internal_Virtual_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000955 RID: 2389 RVA: 0x00031014 File Offset: 0x0002F214
		[CallerCount(184)]
		[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool IsTableConstant()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LookupNode.NativeMethodInfoPtr_IsTableConstant_Internal_Virtual_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000956 RID: 2390 RVA: 0x00031050 File Offset: 0x0002F250
		[CallerCount(184)]
		[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool HasLocalAggregate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LookupNode.NativeMethodInfoPtr_HasLocalAggregate_Internal_Virtual_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000957 RID: 2391 RVA: 0x0003108C File Offset: 0x0002F28C
		[CallerCount(184)]
		[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool HasRemoteAggregate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LookupNode.NativeMethodInfoPtr_HasRemoteAggregate_Internal_Virtual_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000958 RID: 2392 RVA: 0x000310C8 File Offset: 0x0002F2C8
		[CallerCount(0)]
		public unsafe override bool DependsOn(DataColumn column)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(column);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LookupNode.NativeMethodInfoPtr_DependsOn_Internal_Virtual_Boolean_DataColumn_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000959 RID: 2393 RVA: 0x00031118 File Offset: 0x0002F318
		[CallerCount(1295)]
		[CachedScanResults(RefRangeStart = 308780, RefRangeEnd = 310075, XrefRangeStart = 308780, XrefRangeEnd = 310075, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override ExpressionNode Optimize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LookupNode.NativeMethodInfoPtr_Optimize_Internal_Virtual_ExpressionNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ExpressionNode>(intPtr3) : null;
		}

		// Token: 0x0600095A RID: 2394 RVA: 0x00004CDE File Offset: 0x00002EDE
		public LookupNode(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000254 RID: 596
		// (get) Token: 0x0600095B RID: 2395 RVA: 0x00031158 File Offset: 0x0002F358
		// (set) Token: 0x0600095C RID: 2396 RVA: 0x00004CE7 File Offset: 0x00002EE7
		public unsafe string _relationName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LookupNode.NativeFieldInfoPtr__relationName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LookupNode.NativeFieldInfoPtr__relationName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000255 RID: 597
		// (get) Token: 0x0600095D RID: 2397 RVA: 0x00031180 File Offset: 0x0002F380
		// (set) Token: 0x0600095E RID: 2398 RVA: 0x00004D06 File Offset: 0x00002F06
		public unsafe string _columnName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LookupNode.NativeFieldInfoPtr__columnName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LookupNode.NativeFieldInfoPtr__columnName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000256 RID: 598
		// (get) Token: 0x0600095F RID: 2399 RVA: 0x000311A8 File Offset: 0x0002F3A8
		// (set) Token: 0x06000960 RID: 2400 RVA: 0x00004D25 File Offset: 0x00002F25
		public unsafe DataColumn _column
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LookupNode.NativeFieldInfoPtr__column);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DataColumn>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LookupNode.NativeFieldInfoPtr__column), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000257 RID: 599
		// (get) Token: 0x06000961 RID: 2401 RVA: 0x000311D8 File Offset: 0x0002F3D8
		// (set) Token: 0x06000962 RID: 2402 RVA: 0x00004D44 File Offset: 0x00002F44
		public unsafe DataRelation _relation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LookupNode.NativeFieldInfoPtr__relation);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DataRelation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LookupNode.NativeFieldInfoPtr__relation), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040007BF RID: 1983
		private static readonly IntPtr NativeFieldInfoPtr__relationName;

		// Token: 0x040007C0 RID: 1984
		private static readonly IntPtr NativeFieldInfoPtr__columnName;

		// Token: 0x040007C1 RID: 1985
		private static readonly IntPtr NativeFieldInfoPtr__column;

		// Token: 0x040007C2 RID: 1986
		private static readonly IntPtr NativeFieldInfoPtr__relation;

		// Token: 0x040007C3 RID: 1987
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_DataTable_String_String_0;

		// Token: 0x040007C4 RID: 1988
		private static readonly IntPtr NativeMethodInfoPtr_Bind_Internal_Virtual_Void_DataTable_List_1_DataColumn_0;

		// Token: 0x040007C5 RID: 1989
		private static readonly IntPtr NativeMethodInfoPtr_Eval_Internal_Virtual_Object_0;

		// Token: 0x040007C6 RID: 1990
		private static readonly IntPtr NativeMethodInfoPtr_Eval_Internal_Virtual_Object_DataRow_DataRowVersion_0;

		// Token: 0x040007C7 RID: 1991
		private static readonly IntPtr NativeMethodInfoPtr_Eval_Internal_Virtual_Object_Il2CppStructArray_1_Int32_0;

		// Token: 0x040007C8 RID: 1992
		private static readonly IntPtr NativeMethodInfoPtr_IsConstant_Internal_Virtual_Boolean_0;

		// Token: 0x040007C9 RID: 1993
		private static readonly IntPtr NativeMethodInfoPtr_IsTableConstant_Internal_Virtual_Boolean_0;

		// Token: 0x040007CA RID: 1994
		private static readonly IntPtr NativeMethodInfoPtr_HasLocalAggregate_Internal_Virtual_Boolean_0;

		// Token: 0x040007CB RID: 1995
		private static readonly IntPtr NativeMethodInfoPtr_HasRemoteAggregate_Internal_Virtual_Boolean_0;

		// Token: 0x040007CC RID: 1996
		private static readonly IntPtr NativeMethodInfoPtr_DependsOn_Internal_Virtual_Boolean_DataColumn_0;

		// Token: 0x040007CD RID: 1997
		private static readonly IntPtr NativeMethodInfoPtr_Optimize_Internal_Virtual_ExpressionNode_0;
	}
}
