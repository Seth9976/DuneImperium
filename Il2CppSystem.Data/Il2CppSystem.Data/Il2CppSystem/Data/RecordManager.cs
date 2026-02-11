using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace Il2CppSystem.Data
{
	// Token: 0x02000070 RID: 112
	public sealed class RecordManager : Object
	{
		// Token: 0x06000A6F RID: 2671 RVA: 0x0003620C File Offset: 0x0003440C
		// Note: this type is marked as 'beforefieldinit'.
		static RecordManager()
		{
			Il2CppClassPointerStore<RecordManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Data.dll", "System.Data", "RecordManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RecordManager>.NativeClassPtr);
			RecordManager.NativeFieldInfoPtr__table = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RecordManager>.NativeClassPtr, "_table");
			RecordManager.NativeFieldInfoPtr__lastFreeRecord = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RecordManager>.NativeClassPtr, "_lastFreeRecord");
			RecordManager.NativeFieldInfoPtr__minimumCapacity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RecordManager>.NativeClassPtr, "_minimumCapacity");
			RecordManager.NativeFieldInfoPtr__recordCapacity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RecordManager>.NativeClassPtr, "_recordCapacity");
			RecordManager.NativeFieldInfoPtr__freeRecordList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RecordManager>.NativeClassPtr, "_freeRecordList");
			RecordManager.NativeFieldInfoPtr__rows = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RecordManager>.NativeClassPtr, "_rows");
			RecordManager.NativeMethodInfoPtr__ctor_Internal_Void_DataTable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RecordManager>.NativeClassPtr, 100665031);
			RecordManager.NativeMethodInfoPtr_GrowRecordCapacity_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RecordManager>.NativeClassPtr, 100665032);
			RecordManager.NativeMethodInfoPtr_get_LastFreeRecord_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RecordManager>.NativeClassPtr, 100665033);
			RecordManager.NativeMethodInfoPtr_get_MinimumCapacity_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RecordManager>.NativeClassPtr, 100665034);
			RecordManager.NativeMethodInfoPtr_set_MinimumCapacity_Internal_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RecordManager>.NativeClassPtr, 100665035);
			RecordManager.NativeMethodInfoPtr_get_RecordCapacity_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RecordManager>.NativeClassPtr, 100665036);
			RecordManager.NativeMethodInfoPtr_set_RecordCapacity_Internal_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RecordManager>.NativeClassPtr, 100665037);
			RecordManager.NativeMethodInfoPtr_NewCapacity_Internal_Static_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RecordManager>.NativeClassPtr, 100665038);
			RecordManager.NativeMethodInfoPtr_NormalizedMinimumCapacity_Private_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RecordManager>.NativeClassPtr, 100665039);
			RecordManager.NativeMethodInfoPtr_NewRecordBase_Internal_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RecordManager>.NativeClassPtr, 100665040);
			RecordManager.NativeMethodInfoPtr_FreeRecord_Internal_Void_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RecordManager>.NativeClassPtr, 100665041);
			RecordManager.NativeMethodInfoPtr_Clear_Internal_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RecordManager>.NativeClassPtr, 100665042);
			RecordManager.NativeMethodInfoPtr_get_Item_Internal_get_DataRow_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RecordManager>.NativeClassPtr, 100665043);
			RecordManager.NativeMethodInfoPtr_set_Item_Internal_set_Void_Int32_DataRow_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RecordManager>.NativeClassPtr, 100665044);
			RecordManager.NativeMethodInfoPtr_ImportRecord_Internal_Int32_DataTable_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RecordManager>.NativeClassPtr, 100665045);
			RecordManager.NativeMethodInfoPtr_CopyRecord_Internal_Int32_DataTable_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RecordManager>.NativeClassPtr, 100665046);
			RecordManager.NativeMethodInfoPtr_SetRowCache_Internal_Void_Il2CppReferenceArray_1_DataRow_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RecordManager>.NativeClassPtr, 100665047);
		}

		// Token: 0x06000A70 RID: 2672 RVA: 0x00036408 File Offset: 0x00034608
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 906146, RefRangeEnd = 906147, XrefRangeStart = 906133, XrefRangeEnd = 906146, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RecordManager(DataTable table)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RecordManager>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(table);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RecordManager.NativeMethodInfoPtr__ctor_Internal_Void_DataTable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000A71 RID: 2673 RVA: 0x00036454 File Offset: 0x00034654
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 906164, RefRangeEnd = 906165, XrefRangeStart = 906147, XrefRangeEnd = 906164, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GrowRecordCapacity()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RecordManager.NativeMethodInfoPtr_GrowRecordCapacity_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000294 RID: 660
		// (get) Token: 0x06000A72 RID: 2674 RVA: 0x00036488 File Offset: 0x00034688
		public unsafe int LastFreeRecord
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RecordManager.NativeMethodInfoPtr_get_LastFreeRecord_Internal_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000295 RID: 661
		// (get) Token: 0x06000A73 RID: 2675 RVA: 0x000364C4 File Offset: 0x000346C4
		// (set) Token: 0x06000A74 RID: 2676 RVA: 0x00036500 File Offset: 0x00034700
		public unsafe int MinimumCapacity
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RecordManager.NativeMethodInfoPtr_get_MinimumCapacity_Internal_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 906165, RefRangeEnd = 906168, XrefRangeStart = 906165, XrefRangeEnd = 906165, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RecordManager.NativeMethodInfoPtr_set_MinimumCapacity_Internal_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000296 RID: 662
		// (get) Token: 0x06000A75 RID: 2677 RVA: 0x00036540 File Offset: 0x00034740
		// (set) Token: 0x06000A76 RID: 2678 RVA: 0x0003657C File Offset: 0x0003477C
		public unsafe int RecordCapacity
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RecordManager.NativeMethodInfoPtr_get_RecordCapacity_Internal_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 906168, XrefRangeEnd = 906171, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RecordManager.NativeMethodInfoPtr_set_RecordCapacity_Internal_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000A77 RID: 2679 RVA: 0x000365BC File Offset: 0x000347BC
		[CallerCount(0)]
		public unsafe static int NewCapacity(int capacity)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref capacity;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RecordManager.NativeMethodInfoPtr_NewCapacity_Internal_Static_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000A78 RID: 2680 RVA: 0x000365FC File Offset: 0x000347FC
		[CallerCount(0)]
		public unsafe int NormalizedMinimumCapacity(int capacity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref capacity;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RecordManager.NativeMethodInfoPtr_NormalizedMinimumCapacity_Private_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000A79 RID: 2681 RVA: 0x00036648 File Offset: 0x00034848
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 906175, RefRangeEnd = 906179, XrefRangeStart = 906171, XrefRangeEnd = 906175, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int NewRecordBase()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RecordManager.NativeMethodInfoPtr_NewRecordBase_Internal_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000A7A RID: 2682 RVA: 0x00036684 File Offset: 0x00034884
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 906187, RefRangeEnd = 906191, XrefRangeStart = 906179, XrefRangeEnd = 906187, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FreeRecord(ref int record)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &record;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RecordManager.NativeMethodInfoPtr_FreeRecord_Internal_Void_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000A7B RID: 2683 RVA: 0x000366C4 File Offset: 0x000348C4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 906197, RefRangeEnd = 906198, XrefRangeStart = 906191, XrefRangeEnd = 906197, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Clear(bool clearAll)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref clearAll;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RecordManager.NativeMethodInfoPtr_Clear_Internal_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000297 RID: 663
		public unsafe DataRow this[int record]
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 906198, RefRangeEnd = 906205, XrefRangeStart = 906198, XrefRangeEnd = 906198, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref record;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RecordManager.NativeMethodInfoPtr_get_Item_Internal_get_DataRow_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<DataRow>(intPtr3) : null;
				}
			}
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 906211, RefRangeEnd = 906221, XrefRangeStart = 906205, XrefRangeEnd = 906211, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref record;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RecordManager.NativeMethodInfoPtr_set_Item_Internal_set_Void_Int32_DataRow_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000A7E RID: 2686 RVA: 0x000367A0 File Offset: 0x000349A0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 906222, RefRangeEnd = 906224, XrefRangeStart = 906221, XrefRangeEnd = 906222, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int ImportRecord(DataTable src, int record)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(src);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref record;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RecordManager.NativeMethodInfoPtr_ImportRecord_Internal_Int32_DataTable_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000A7F RID: 2687 RVA: 0x000367FC File Offset: 0x000349FC
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 906240, RefRangeEnd = 906248, XrefRangeStart = 906224, XrefRangeEnd = 906240, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int CopyRecord(DataTable src, int record, int copy)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(src);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref record;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref copy;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RecordManager.NativeMethodInfoPtr_CopyRecord_Internal_Int32_DataTable_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000A80 RID: 2688 RVA: 0x00036868 File Offset: 0x00034A68
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 906249, RefRangeEnd = 906250, XrefRangeStart = 906248, XrefRangeEnd = 906249, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetRowCache(Il2CppReferenceArray<DataRow> newRows)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(newRows);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RecordManager.NativeMethodInfoPtr_SetRowCache_Internal_Void_Il2CppReferenceArray_1_DataRow_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000A81 RID: 2689 RVA: 0x000051DD File Offset: 0x000033DD
		public RecordManager(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700028E RID: 654
		// (get) Token: 0x06000A82 RID: 2690 RVA: 0x000368AC File Offset: 0x00034AAC
		// (set) Token: 0x06000A83 RID: 2691 RVA: 0x000051E6 File Offset: 0x000033E6
		public unsafe DataTable _table
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RecordManager.NativeFieldInfoPtr__table);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DataTable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RecordManager.NativeFieldInfoPtr__table), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700028F RID: 655
		// (get) Token: 0x06000A84 RID: 2692 RVA: 0x000368DC File Offset: 0x00034ADC
		// (set) Token: 0x06000A85 RID: 2693 RVA: 0x00005205 File Offset: 0x00003405
		public unsafe int _lastFreeRecord
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RecordManager.NativeFieldInfoPtr__lastFreeRecord);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RecordManager.NativeFieldInfoPtr__lastFreeRecord)) = value;
			}
		}

		// Token: 0x17000290 RID: 656
		// (get) Token: 0x06000A86 RID: 2694 RVA: 0x00036904 File Offset: 0x00034B04
		// (set) Token: 0x06000A87 RID: 2695 RVA: 0x00005220 File Offset: 0x00003420
		public unsafe int _minimumCapacity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RecordManager.NativeFieldInfoPtr__minimumCapacity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RecordManager.NativeFieldInfoPtr__minimumCapacity)) = value;
			}
		}

		// Token: 0x17000291 RID: 657
		// (get) Token: 0x06000A88 RID: 2696 RVA: 0x0003692C File Offset: 0x00034B2C
		// (set) Token: 0x06000A89 RID: 2697 RVA: 0x0000523B File Offset: 0x0000343B
		public unsafe int _recordCapacity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RecordManager.NativeFieldInfoPtr__recordCapacity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RecordManager.NativeFieldInfoPtr__recordCapacity)) = value;
			}
		}

		// Token: 0x17000292 RID: 658
		// (get) Token: 0x06000A8A RID: 2698 RVA: 0x00036954 File Offset: 0x00034B54
		// (set) Token: 0x06000A8B RID: 2699 RVA: 0x00005256 File Offset: 0x00003456
		public unsafe List<int> _freeRecordList
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RecordManager.NativeFieldInfoPtr__freeRecordList);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RecordManager.NativeFieldInfoPtr__freeRecordList), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000293 RID: 659
		// (get) Token: 0x06000A8C RID: 2700 RVA: 0x00036984 File Offset: 0x00034B84
		// (set) Token: 0x06000A8D RID: 2701 RVA: 0x00005275 File Offset: 0x00003475
		public unsafe Il2CppReferenceArray<DataRow> _rows
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RecordManager.NativeFieldInfoPtr__rows);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<DataRow>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RecordManager.NativeFieldInfoPtr__rows), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040008C3 RID: 2243
		private static readonly IntPtr NativeFieldInfoPtr__table;

		// Token: 0x040008C4 RID: 2244
		private static readonly IntPtr NativeFieldInfoPtr__lastFreeRecord;

		// Token: 0x040008C5 RID: 2245
		private static readonly IntPtr NativeFieldInfoPtr__minimumCapacity;

		// Token: 0x040008C6 RID: 2246
		private static readonly IntPtr NativeFieldInfoPtr__recordCapacity;

		// Token: 0x040008C7 RID: 2247
		private static readonly IntPtr NativeFieldInfoPtr__freeRecordList;

		// Token: 0x040008C8 RID: 2248
		private static readonly IntPtr NativeFieldInfoPtr__rows;

		// Token: 0x040008C9 RID: 2249
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_DataTable_0;

		// Token: 0x040008CA RID: 2250
		private static readonly IntPtr NativeMethodInfoPtr_GrowRecordCapacity_Private_Void_0;

		// Token: 0x040008CB RID: 2251
		private static readonly IntPtr NativeMethodInfoPtr_get_LastFreeRecord_Internal_get_Int32_0;

		// Token: 0x040008CC RID: 2252
		private static readonly IntPtr NativeMethodInfoPtr_get_MinimumCapacity_Internal_get_Int32_0;

		// Token: 0x040008CD RID: 2253
		private static readonly IntPtr NativeMethodInfoPtr_set_MinimumCapacity_Internal_set_Void_Int32_0;

		// Token: 0x040008CE RID: 2254
		private static readonly IntPtr NativeMethodInfoPtr_get_RecordCapacity_Internal_get_Int32_0;

		// Token: 0x040008CF RID: 2255
		private static readonly IntPtr NativeMethodInfoPtr_set_RecordCapacity_Internal_set_Void_Int32_0;

		// Token: 0x040008D0 RID: 2256
		private static readonly IntPtr NativeMethodInfoPtr_NewCapacity_Internal_Static_Int32_Int32_0;

		// Token: 0x040008D1 RID: 2257
		private static readonly IntPtr NativeMethodInfoPtr_NormalizedMinimumCapacity_Private_Int32_Int32_0;

		// Token: 0x040008D2 RID: 2258
		private static readonly IntPtr NativeMethodInfoPtr_NewRecordBase_Internal_Int32_0;

		// Token: 0x040008D3 RID: 2259
		private static readonly IntPtr NativeMethodInfoPtr_FreeRecord_Internal_Void_byref_Int32_0;

		// Token: 0x040008D4 RID: 2260
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Internal_Void_Boolean_0;

		// Token: 0x040008D5 RID: 2261
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Internal_get_DataRow_Int32_0;

		// Token: 0x040008D6 RID: 2262
		private static readonly IntPtr NativeMethodInfoPtr_set_Item_Internal_set_Void_Int32_DataRow_0;

		// Token: 0x040008D7 RID: 2263
		private static readonly IntPtr NativeMethodInfoPtr_ImportRecord_Internal_Int32_DataTable_Int32_0;

		// Token: 0x040008D8 RID: 2264
		private static readonly IntPtr NativeMethodInfoPtr_CopyRecord_Internal_Int32_DataTable_Int32_Int32_0;

		// Token: 0x040008D9 RID: 2265
		private static readonly IntPtr NativeMethodInfoPtr_SetRowCache_Internal_Void_Il2CppReferenceArray_1_DataRow_0;
	}
}
