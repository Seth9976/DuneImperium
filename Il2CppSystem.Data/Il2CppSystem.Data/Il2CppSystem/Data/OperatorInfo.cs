using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Data
{
	// Token: 0x02000059 RID: 89
	public sealed class OperatorInfo : Object
	{
		// Token: 0x060008FC RID: 2300 RVA: 0x0002F48C File Offset: 0x0002D68C
		// Note: this type is marked as 'beforefieldinit'.
		static OperatorInfo()
		{
			Il2CppClassPointerStore<OperatorInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Data.dll", "System.Data", "OperatorInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OperatorInfo>.NativeClassPtr);
			OperatorInfo.NativeFieldInfoPtr__type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OperatorInfo>.NativeClassPtr, "_type");
			OperatorInfo.NativeFieldInfoPtr__op = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OperatorInfo>.NativeClassPtr, "_op");
			OperatorInfo.NativeFieldInfoPtr__priority = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OperatorInfo>.NativeClassPtr, "_priority");
			OperatorInfo.NativeMethodInfoPtr__ctor_Internal_Void_Nodes_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OperatorInfo>.NativeClassPtr, 100664768);
		}

		// Token: 0x060008FD RID: 2301 RVA: 0x0002F50C File Offset: 0x0002D70C
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 904096, RefRangeEnd = 904103, XrefRangeStart = 904095, XrefRangeEnd = 904096, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe OperatorInfo(Nodes type, int op, int pri)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OperatorInfo>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref type;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref op;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pri;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OperatorInfo.NativeMethodInfoPtr__ctor_Internal_Void_Nodes_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008FE RID: 2302 RVA: 0x00004C28 File Offset: 0x00002E28
		public OperatorInfo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000251 RID: 593
		// (get) Token: 0x060008FF RID: 2303 RVA: 0x0002F570 File Offset: 0x0002D770
		// (set) Token: 0x06000900 RID: 2304 RVA: 0x00004C31 File Offset: 0x00002E31
		public unsafe Nodes _type
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OperatorInfo.NativeFieldInfoPtr__type);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OperatorInfo.NativeFieldInfoPtr__type)) = value;
			}
		}

		// Token: 0x17000252 RID: 594
		// (get) Token: 0x06000901 RID: 2305 RVA: 0x0002F598 File Offset: 0x0002D798
		// (set) Token: 0x06000902 RID: 2306 RVA: 0x00004C4C File Offset: 0x00002E4C
		public unsafe int _op
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OperatorInfo.NativeFieldInfoPtr__op);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OperatorInfo.NativeFieldInfoPtr__op)) = value;
			}
		}

		// Token: 0x17000253 RID: 595
		// (get) Token: 0x06000903 RID: 2307 RVA: 0x0002F5C0 File Offset: 0x0002D7C0
		// (set) Token: 0x06000904 RID: 2308 RVA: 0x00004C67 File Offset: 0x00002E67
		public unsafe int _priority
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OperatorInfo.NativeFieldInfoPtr__priority);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OperatorInfo.NativeFieldInfoPtr__priority)) = value;
			}
		}

		// Token: 0x0400077C RID: 1916
		private static readonly IntPtr NativeFieldInfoPtr__type;

		// Token: 0x0400077D RID: 1917
		private static readonly IntPtr NativeFieldInfoPtr__op;

		// Token: 0x0400077E RID: 1918
		private static readonly IntPtr NativeFieldInfoPtr__priority;

		// Token: 0x0400077F RID: 1919
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Nodes_Int32_Int32_0;
	}
}
