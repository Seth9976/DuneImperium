using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x0200010D RID: 269
	public sealed class ConstraintStruct : Object
	{
		// Token: 0x0600183F RID: 6207 RVA: 0x0007DBD8 File Offset: 0x0007BDD8
		// Note: this type is marked as 'beforefieldinit'.
		static ConstraintStruct()
		{
			Il2CppClassPointerStore<ConstraintStruct>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "ConstraintStruct");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConstraintStruct>.NativeClassPtr);
			ConstraintStruct.NativeFieldInfoPtr_constraint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstraintStruct>.NativeClassPtr, "constraint");
			ConstraintStruct.NativeFieldInfoPtr_axisSelector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstraintStruct>.NativeClassPtr, "axisSelector");
			ConstraintStruct.NativeFieldInfoPtr_axisFields = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstraintStruct>.NativeClassPtr, "axisFields");
			ConstraintStruct.NativeFieldInfoPtr_qualifiedTable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstraintStruct>.NativeClassPtr, "qualifiedTable");
			ConstraintStruct.NativeFieldInfoPtr_keyrefTable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstraintStruct>.NativeClassPtr, "keyrefTable");
			ConstraintStruct.NativeFieldInfoPtr_tableDim = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstraintStruct>.NativeClassPtr, "tableDim");
			ConstraintStruct.NativeMethodInfoPtr_get_TableDim_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstraintStruct>.NativeClassPtr, 100667072);
			ConstraintStruct.NativeMethodInfoPtr__ctor_Internal_Void_CompiledIdentityConstraint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstraintStruct>.NativeClassPtr, 100667073);
		}

		// Token: 0x170007D8 RID: 2008
		// (get) Token: 0x06001840 RID: 6208 RVA: 0x0007DCA8 File Offset: 0x0007BEA8
		public unsafe int TableDim
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstraintStruct.NativeMethodInfoPtr_get_TableDim_Internal_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001841 RID: 6209 RVA: 0x0007DCE4 File Offset: 0x0007BEE4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 391888, RefRangeEnd = 391890, XrefRangeStart = 391865, XrefRangeEnd = 391888, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ConstraintStruct(CompiledIdentityConstraint constraint)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConstraintStruct>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(constraint);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstraintStruct.NativeMethodInfoPtr__ctor_Internal_Void_CompiledIdentityConstraint_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001842 RID: 6210 RVA: 0x0000A59B File Offset: 0x0000879B
		public ConstraintStruct(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170007D2 RID: 2002
		// (get) Token: 0x06001843 RID: 6211 RVA: 0x0007DD30 File Offset: 0x0007BF30
		// (set) Token: 0x06001844 RID: 6212 RVA: 0x0000A5A4 File Offset: 0x000087A4
		public unsafe CompiledIdentityConstraint constraint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstraintStruct.NativeFieldInfoPtr_constraint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CompiledIdentityConstraint>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstraintStruct.NativeFieldInfoPtr_constraint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007D3 RID: 2003
		// (get) Token: 0x06001845 RID: 6213 RVA: 0x0007DD60 File Offset: 0x0007BF60
		// (set) Token: 0x06001846 RID: 6214 RVA: 0x0000A5C3 File Offset: 0x000087C3
		public unsafe SelectorActiveAxis axisSelector
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstraintStruct.NativeFieldInfoPtr_axisSelector);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SelectorActiveAxis>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstraintStruct.NativeFieldInfoPtr_axisSelector), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007D4 RID: 2004
		// (get) Token: 0x06001847 RID: 6215 RVA: 0x0007DD90 File Offset: 0x0007BF90
		// (set) Token: 0x06001848 RID: 6216 RVA: 0x0000A5E2 File Offset: 0x000087E2
		public unsafe ArrayList axisFields
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstraintStruct.NativeFieldInfoPtr_axisFields);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArrayList>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstraintStruct.NativeFieldInfoPtr_axisFields), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007D5 RID: 2005
		// (get) Token: 0x06001849 RID: 6217 RVA: 0x0007DDC0 File Offset: 0x0007BFC0
		// (set) Token: 0x0600184A RID: 6218 RVA: 0x0000A601 File Offset: 0x00008801
		public unsafe Hashtable qualifiedTable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstraintStruct.NativeFieldInfoPtr_qualifiedTable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstraintStruct.NativeFieldInfoPtr_qualifiedTable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007D6 RID: 2006
		// (get) Token: 0x0600184B RID: 6219 RVA: 0x0007DDF0 File Offset: 0x0007BFF0
		// (set) Token: 0x0600184C RID: 6220 RVA: 0x0000A620 File Offset: 0x00008820
		public unsafe Hashtable keyrefTable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstraintStruct.NativeFieldInfoPtr_keyrefTable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstraintStruct.NativeFieldInfoPtr_keyrefTable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007D7 RID: 2007
		// (get) Token: 0x0600184D RID: 6221 RVA: 0x0007DE20 File Offset: 0x0007C020
		// (set) Token: 0x0600184E RID: 6222 RVA: 0x0000A63F File Offset: 0x0000883F
		public unsafe int tableDim
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstraintStruct.NativeFieldInfoPtr_tableDim);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstraintStruct.NativeFieldInfoPtr_tableDim)) = value;
			}
		}

		// Token: 0x04001304 RID: 4868
		private static readonly IntPtr NativeFieldInfoPtr_constraint;

		// Token: 0x04001305 RID: 4869
		private static readonly IntPtr NativeFieldInfoPtr_axisSelector;

		// Token: 0x04001306 RID: 4870
		private static readonly IntPtr NativeFieldInfoPtr_axisFields;

		// Token: 0x04001307 RID: 4871
		private static readonly IntPtr NativeFieldInfoPtr_qualifiedTable;

		// Token: 0x04001308 RID: 4872
		private static readonly IntPtr NativeFieldInfoPtr_keyrefTable;

		// Token: 0x04001309 RID: 4873
		private static readonly IntPtr NativeFieldInfoPtr_tableDim;

		// Token: 0x0400130A RID: 4874
		private static readonly IntPtr NativeMethodInfoPtr_get_TableDim_Internal_get_Int32_0;

		// Token: 0x0400130B RID: 4875
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_CompiledIdentityConstraint_0;
	}
}
