using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.Localization.SmartFormat.Core.Parsing
{
	// Token: 0x0200007E RID: 126
	public class Placeholder : FormatItem
	{
		// Token: 0x060005F5 RID: 1525 RVA: 0x0001FC64 File Offset: 0x0001DE64
		// Note: this type is marked as 'beforefieldinit'.
		static Placeholder()
		{
			Il2CppClassPointerStore<Placeholder>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Localization.dll", "UnityEngine.Localization.SmartFormat.Core.Parsing", "Placeholder");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Placeholder>.NativeClassPtr);
			Placeholder.NativeFieldInfoPtr__NestedDepth_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Placeholder>.NativeClassPtr, "<NestedDepth>k__BackingField");
			Placeholder.NativeFieldInfoPtr__Selectors_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Placeholder>.NativeClassPtr, "<Selectors>k__BackingField");
			Placeholder.NativeFieldInfoPtr__Alignment_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Placeholder>.NativeClassPtr, "<Alignment>k__BackingField");
			Placeholder.NativeFieldInfoPtr__FormatterName_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Placeholder>.NativeClassPtr, "<FormatterName>k__BackingField");
			Placeholder.NativeFieldInfoPtr__FormatterOptions_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Placeholder>.NativeClassPtr, "<FormatterOptions>k__BackingField");
			Placeholder.NativeFieldInfoPtr__Format_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Placeholder>.NativeClassPtr, "<Format>k__BackingField");
			Placeholder.NativeMethodInfoPtr_ReleaseToPool_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Placeholder>.NativeClassPtr, 100664414);
			Placeholder.NativeMethodInfoPtr_get_NestedDepth_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Placeholder>.NativeClassPtr, 100664415);
			Placeholder.NativeMethodInfoPtr_set_NestedDepth_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Placeholder>.NativeClassPtr, 100664416);
			Placeholder.NativeMethodInfoPtr_get_Selectors_Public_get_List_1_Selector_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Placeholder>.NativeClassPtr, 100664417);
			Placeholder.NativeMethodInfoPtr_get_Alignment_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Placeholder>.NativeClassPtr, 100664418);
			Placeholder.NativeMethodInfoPtr_set_Alignment_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Placeholder>.NativeClassPtr, 100664419);
			Placeholder.NativeMethodInfoPtr_get_FormatterName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Placeholder>.NativeClassPtr, 100664420);
			Placeholder.NativeMethodInfoPtr_set_FormatterName_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Placeholder>.NativeClassPtr, 100664421);
			Placeholder.NativeMethodInfoPtr_get_FormatterOptions_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Placeholder>.NativeClassPtr, 100664422);
			Placeholder.NativeMethodInfoPtr_set_FormatterOptions_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Placeholder>.NativeClassPtr, 100664423);
			Placeholder.NativeMethodInfoPtr_get_Format_Public_get_Format_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Placeholder>.NativeClassPtr, 100664424);
			Placeholder.NativeMethodInfoPtr_set_Format_Public_set_Void_Format_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Placeholder>.NativeClassPtr, 100664425);
			Placeholder.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Placeholder>.NativeClassPtr, 100664426);
			Placeholder.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Placeholder>.NativeClassPtr, 100664427);
		}

		// Token: 0x060005F6 RID: 1526 RVA: 0x0001FE24 File Offset: 0x0001E024
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1074097, RefRangeEnd = 1074098, XrefRangeStart = 1074073, XrefRangeEnd = 1074097, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReleaseToPool()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Placeholder.NativeMethodInfoPtr_ReleaseToPool_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700018C RID: 396
		// (get) Token: 0x060005F7 RID: 1527 RVA: 0x0001FE58 File Offset: 0x0001E058
		// (set) Token: 0x060005F8 RID: 1528 RVA: 0x0001FE94 File Offset: 0x0001E094
		public unsafe int NestedDepth
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Placeholder.NativeMethodInfoPtr_get_NestedDepth_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Placeholder.NativeMethodInfoPtr_set_NestedDepth_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700018D RID: 397
		// (get) Token: 0x060005F9 RID: 1529 RVA: 0x0001FED4 File Offset: 0x0001E0D4
		public unsafe List<Selector> Selectors
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Placeholder.NativeMethodInfoPtr_get_Selectors_Public_get_List_1_Selector_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<Selector>>(intPtr3) : null;
			}
		}

		// Token: 0x1700018E RID: 398
		// (get) Token: 0x060005FA RID: 1530 RVA: 0x0001FF14 File Offset: 0x0001E114
		// (set) Token: 0x060005FB RID: 1531 RVA: 0x0001FF50 File Offset: 0x0001E150
		public unsafe int Alignment
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 318242, RefRangeEnd = 318245, XrefRangeStart = 318242, XrefRangeEnd = 318245, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Placeholder.NativeMethodInfoPtr_get_Alignment_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Placeholder.NativeMethodInfoPtr_set_Alignment_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700018F RID: 399
		// (get) Token: 0x060005FC RID: 1532 RVA: 0x0001FF90 File Offset: 0x0001E190
		// (set) Token: 0x060005FD RID: 1533 RVA: 0x0001FFC8 File Offset: 0x0001E1C8
		public unsafe string FormatterName
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Placeholder.NativeMethodInfoPtr_get_FormatterName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Placeholder.NativeMethodInfoPtr_set_FormatterName_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000190 RID: 400
		// (get) Token: 0x060005FE RID: 1534 RVA: 0x0002000C File Offset: 0x0001E20C
		// (set) Token: 0x060005FF RID: 1535 RVA: 0x00020044 File Offset: 0x0001E244
		public unsafe string FormatterOptions
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Placeholder.NativeMethodInfoPtr_get_FormatterOptions_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Placeholder.NativeMethodInfoPtr_set_FormatterOptions_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000191 RID: 401
		// (get) Token: 0x06000600 RID: 1536 RVA: 0x00020088 File Offset: 0x0001E288
		// (set) Token: 0x06000601 RID: 1537 RVA: 0x000200C8 File Offset: 0x0001E2C8
		public unsafe Format Format
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Placeholder.NativeMethodInfoPtr_get_Format_Public_get_Format_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Format>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Placeholder.NativeMethodInfoPtr_set_Format_Public_set_Void_Format_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000602 RID: 1538 RVA: 0x0002010C File Offset: 0x0001E30C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1074098, XrefRangeEnd = 1074141, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Placeholder.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000603 RID: 1539 RVA: 0x00020150 File Offset: 0x0001E350
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1074149, RefRangeEnd = 1074150, XrefRangeStart = 1074141, XrefRangeEnd = 1074149, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Placeholder()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Placeholder>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Placeholder.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000604 RID: 1540 RVA: 0x000044AB File Offset: 0x000026AB
		public Placeholder(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000186 RID: 390
		// (get) Token: 0x06000605 RID: 1541 RVA: 0x0002018C File Offset: 0x0001E38C
		// (set) Token: 0x06000606 RID: 1542 RVA: 0x000044B4 File Offset: 0x000026B4
		public unsafe int _NestedDepth_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Placeholder.NativeFieldInfoPtr__NestedDepth_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Placeholder.NativeFieldInfoPtr__NestedDepth_k__BackingField)) = value;
			}
		}

		// Token: 0x17000187 RID: 391
		// (get) Token: 0x06000607 RID: 1543 RVA: 0x000201B4 File Offset: 0x0001E3B4
		// (set) Token: 0x06000608 RID: 1544 RVA: 0x000044CF File Offset: 0x000026CF
		public unsafe List<Selector> _Selectors_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Placeholder.NativeFieldInfoPtr__Selectors_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Selector>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Placeholder.NativeFieldInfoPtr__Selectors_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000188 RID: 392
		// (get) Token: 0x06000609 RID: 1545 RVA: 0x000201E4 File Offset: 0x0001E3E4
		// (set) Token: 0x0600060A RID: 1546 RVA: 0x000044EE File Offset: 0x000026EE
		public unsafe int _Alignment_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Placeholder.NativeFieldInfoPtr__Alignment_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Placeholder.NativeFieldInfoPtr__Alignment_k__BackingField)) = value;
			}
		}

		// Token: 0x17000189 RID: 393
		// (get) Token: 0x0600060B RID: 1547 RVA: 0x0002020C File Offset: 0x0001E40C
		// (set) Token: 0x0600060C RID: 1548 RVA: 0x00004509 File Offset: 0x00002709
		public unsafe string _FormatterName_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Placeholder.NativeFieldInfoPtr__FormatterName_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Placeholder.NativeFieldInfoPtr__FormatterName_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700018A RID: 394
		// (get) Token: 0x0600060D RID: 1549 RVA: 0x00020234 File Offset: 0x0001E434
		// (set) Token: 0x0600060E RID: 1550 RVA: 0x00004528 File Offset: 0x00002728
		public unsafe string _FormatterOptions_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Placeholder.NativeFieldInfoPtr__FormatterOptions_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Placeholder.NativeFieldInfoPtr__FormatterOptions_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700018B RID: 395
		// (get) Token: 0x0600060F RID: 1551 RVA: 0x0002025C File Offset: 0x0001E45C
		// (set) Token: 0x06000610 RID: 1552 RVA: 0x00004547 File Offset: 0x00002747
		public unsafe Format _Format_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Placeholder.NativeFieldInfoPtr__Format_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Format>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Placeholder.NativeFieldInfoPtr__Format_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000437 RID: 1079
		private static readonly IntPtr NativeFieldInfoPtr__NestedDepth_k__BackingField;

		// Token: 0x04000438 RID: 1080
		private static readonly IntPtr NativeFieldInfoPtr__Selectors_k__BackingField;

		// Token: 0x04000439 RID: 1081
		private static readonly IntPtr NativeFieldInfoPtr__Alignment_k__BackingField;

		// Token: 0x0400043A RID: 1082
		private static readonly IntPtr NativeFieldInfoPtr__FormatterName_k__BackingField;

		// Token: 0x0400043B RID: 1083
		private static readonly IntPtr NativeFieldInfoPtr__FormatterOptions_k__BackingField;

		// Token: 0x0400043C RID: 1084
		private static readonly IntPtr NativeFieldInfoPtr__Format_k__BackingField;

		// Token: 0x0400043D RID: 1085
		private static readonly IntPtr NativeMethodInfoPtr_ReleaseToPool_Public_Void_0;

		// Token: 0x0400043E RID: 1086
		private static readonly IntPtr NativeMethodInfoPtr_get_NestedDepth_Public_get_Int32_0;

		// Token: 0x0400043F RID: 1087
		private static readonly IntPtr NativeMethodInfoPtr_set_NestedDepth_Public_set_Void_Int32_0;

		// Token: 0x04000440 RID: 1088
		private static readonly IntPtr NativeMethodInfoPtr_get_Selectors_Public_get_List_1_Selector_0;

		// Token: 0x04000441 RID: 1089
		private static readonly IntPtr NativeMethodInfoPtr_get_Alignment_Public_get_Int32_0;

		// Token: 0x04000442 RID: 1090
		private static readonly IntPtr NativeMethodInfoPtr_set_Alignment_Public_set_Void_Int32_0;

		// Token: 0x04000443 RID: 1091
		private static readonly IntPtr NativeMethodInfoPtr_get_FormatterName_Public_get_String_0;

		// Token: 0x04000444 RID: 1092
		private static readonly IntPtr NativeMethodInfoPtr_set_FormatterName_Public_set_Void_String_0;

		// Token: 0x04000445 RID: 1093
		private static readonly IntPtr NativeMethodInfoPtr_get_FormatterOptions_Public_get_String_0;

		// Token: 0x04000446 RID: 1094
		private static readonly IntPtr NativeMethodInfoPtr_set_FormatterOptions_Public_set_Void_String_0;

		// Token: 0x04000447 RID: 1095
		private static readonly IntPtr NativeMethodInfoPtr_get_Format_Public_get_Format_0;

		// Token: 0x04000448 RID: 1096
		private static readonly IntPtr NativeMethodInfoPtr_set_Format_Public_set_Void_Format_0;

		// Token: 0x04000449 RID: 1097
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x0400044A RID: 1098
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
