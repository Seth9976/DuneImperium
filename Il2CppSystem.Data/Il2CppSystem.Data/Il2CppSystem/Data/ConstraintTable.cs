using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Xml.Schema;

namespace Il2CppSystem.Data
{
	// Token: 0x0200007D RID: 125
	public sealed class ConstraintTable : Object
	{
		// Token: 0x06000BB5 RID: 2997 RVA: 0x0003BB88 File Offset: 0x00039D88
		// Note: this type is marked as 'beforefieldinit'.
		static ConstraintTable()
		{
			Il2CppClassPointerStore<ConstraintTable>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Data.dll", "System.Data", "ConstraintTable");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConstraintTable>.NativeClassPtr);
			ConstraintTable.NativeFieldInfoPtr_table = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstraintTable>.NativeClassPtr, "table");
			ConstraintTable.NativeFieldInfoPtr_constraint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstraintTable>.NativeClassPtr, "constraint");
			ConstraintTable.NativeMethodInfoPtr__ctor_Public_Void_DataTable_XmlSchemaIdentityConstraint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstraintTable>.NativeClassPtr, 100665232);
		}

		// Token: 0x06000BB6 RID: 2998 RVA: 0x0003BBF4 File Offset: 0x00039DF4
		[CallerCount(54)]
		[CachedScanResults(RefRangeStart = 296744, RefRangeEnd = 296798, XrefRangeStart = 296744, XrefRangeEnd = 296798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ConstraintTable(DataTable t, XmlSchemaIdentityConstraint c)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConstraintTable>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(c);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstraintTable.NativeMethodInfoPtr__ctor_Public_Void_DataTable_XmlSchemaIdentityConstraint_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000BB7 RID: 2999 RVA: 0x00005928 File Offset: 0x00003B28
		public ConstraintTable(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002E7 RID: 743
		// (get) Token: 0x06000BB8 RID: 3000 RVA: 0x0003BC54 File Offset: 0x00039E54
		// (set) Token: 0x06000BB9 RID: 3001 RVA: 0x00005931 File Offset: 0x00003B31
		public unsafe DataTable table
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstraintTable.NativeFieldInfoPtr_table);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DataTable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstraintTable.NativeFieldInfoPtr_table), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002E8 RID: 744
		// (get) Token: 0x06000BBA RID: 3002 RVA: 0x0003BC84 File Offset: 0x00039E84
		// (set) Token: 0x06000BBB RID: 3003 RVA: 0x00005950 File Offset: 0x00003B50
		public unsafe XmlSchemaIdentityConstraint constraint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstraintTable.NativeFieldInfoPtr_constraint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaIdentityConstraint>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstraintTable.NativeFieldInfoPtr_constraint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040009BF RID: 2495
		private static readonly IntPtr NativeFieldInfoPtr_table;

		// Token: 0x040009C0 RID: 2496
		private static readonly IntPtr NativeFieldInfoPtr_constraint;

		// Token: 0x040009C1 RID: 2497
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_DataTable_XmlSchemaIdentityConstraint_0;
	}
}
