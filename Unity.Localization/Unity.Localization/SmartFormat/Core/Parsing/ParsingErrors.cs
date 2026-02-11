using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.Localization.SmartFormat.Core.Parsing
{
	// Token: 0x0200007D RID: 125
	public class ParsingErrors : Exception
	{
		// Token: 0x060005E7 RID: 1511 RVA: 0x0001F900 File Offset: 0x0001DB00
		// Note: this type is marked as 'beforefieldinit'.
		static ParsingErrors()
		{
			Il2CppClassPointerStore<ParsingErrors>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Localization.dll", "UnityEngine.Localization.SmartFormat.Core.Parsing", "ParsingErrors");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ParsingErrors>.NativeClassPtr);
			ParsingErrors.NativeFieldInfoPtr_result = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParsingErrors>.NativeClassPtr, "result");
			ParsingErrors.NativeFieldInfoPtr__Issues_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParsingErrors>.NativeClassPtr, "<Issues>k__BackingField");
			ParsingErrors.NativeMethodInfoPtr_Init_Public_Void_Format_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParsingErrors>.NativeClassPtr, 100664398);
			ParsingErrors.NativeMethodInfoPtr_Clear_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParsingErrors>.NativeClassPtr, 100664399);
			ParsingErrors.NativeMethodInfoPtr_get_Issues_Public_get_List_1_ParsingIssue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParsingErrors>.NativeClassPtr, 100664400);
			ParsingErrors.NativeMethodInfoPtr_get_HasIssues_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParsingErrors>.NativeClassPtr, 100664401);
			ParsingErrors.NativeMethodInfoPtr_get_MessageShort_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParsingErrors>.NativeClassPtr, 100664402);
			ParsingErrors.NativeMethodInfoPtr_get_Message_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParsingErrors>.NativeClassPtr, 100664403);
			ParsingErrors.NativeMethodInfoPtr_AddIssue_Public_Void_String_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParsingErrors>.NativeClassPtr, 100664404);
			ParsingErrors.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParsingErrors>.NativeClassPtr, 100664405);
		}

		// Token: 0x060005E8 RID: 1512 RVA: 0x0001F9F8 File Offset: 0x0001DBF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Init(Format result)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParsingErrors.NativeMethodInfoPtr_Init_Public_Void_Format_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060005E9 RID: 1513 RVA: 0x0001FA3C File Offset: 0x0001DC3C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1073936, RefRangeEnd = 1073937, XrefRangeStart = 1073934, XrefRangeEnd = 1073936, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Clear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParsingErrors.NativeMethodInfoPtr_Clear_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000182 RID: 386
		// (get) Token: 0x060005EA RID: 1514 RVA: 0x0001FA70 File Offset: 0x0001DC70
		public unsafe List<ParsingErrors.ParsingIssue> Issues
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParsingErrors.NativeMethodInfoPtr_get_Issues_Public_get_List_1_ParsingIssue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<ParsingErrors.ParsingIssue>>(intPtr3) : null;
			}
		}

		// Token: 0x17000183 RID: 387
		// (get) Token: 0x060005EB RID: 1515 RVA: 0x0001FAB0 File Offset: 0x0001DCB0
		public unsafe bool HasIssues
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1073937, XrefRangeEnd = 1073938, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParsingErrors.NativeMethodInfoPtr_get_HasIssues_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000184 RID: 388
		// (get) Token: 0x060005EC RID: 1516 RVA: 0x0001FAEC File Offset: 0x0001DCEC
		public unsafe string MessageShort
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1073938, XrefRangeEnd = 1073973, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParsingErrors.NativeMethodInfoPtr_get_MessageShort_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000185 RID: 389
		// (get) Token: 0x060005ED RID: 1517 RVA: 0x0001FB24 File Offset: 0x0001DD24
		public unsafe override string Message
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1073973, XrefRangeEnd = 1074048, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ParsingErrors.NativeMethodInfoPtr_get_Message_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060005EE RID: 1518 RVA: 0x0001FB68 File Offset: 0x0001DD68
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1074056, RefRangeEnd = 1074061, XrefRangeStart = 1074048, XrefRangeEnd = 1074056, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddIssue(string issue, int startIndex, int endIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(issue);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref endIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParsingErrors.NativeMethodInfoPtr_AddIssue_Public_Void_String_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005EF RID: 1519 RVA: 0x0001FBC8 File Offset: 0x0001DDC8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1074072, RefRangeEnd = 1074073, XrefRangeStart = 1074061, XrefRangeEnd = 1074072, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ParsingErrors()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ParsingErrors>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParsingErrors.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005F0 RID: 1520 RVA: 0x00004464 File Offset: 0x00002664
		public ParsingErrors(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000180 RID: 384
		// (get) Token: 0x060005F1 RID: 1521 RVA: 0x0001FC04 File Offset: 0x0001DE04
		// (set) Token: 0x060005F2 RID: 1522 RVA: 0x0000446D File Offset: 0x0000266D
		public unsafe Format result
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParsingErrors.NativeFieldInfoPtr_result);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Format>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParsingErrors.NativeFieldInfoPtr_result), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000181 RID: 385
		// (get) Token: 0x060005F3 RID: 1523 RVA: 0x0001FC34 File Offset: 0x0001DE34
		// (set) Token: 0x060005F4 RID: 1524 RVA: 0x0000448C File Offset: 0x0000268C
		public unsafe List<ParsingErrors.ParsingIssue> _Issues_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParsingErrors.NativeFieldInfoPtr__Issues_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ParsingErrors.ParsingIssue>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParsingErrors.NativeFieldInfoPtr__Issues_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400042D RID: 1069
		private static readonly IntPtr NativeFieldInfoPtr_result;

		// Token: 0x0400042E RID: 1070
		private static readonly IntPtr NativeFieldInfoPtr__Issues_k__BackingField;

		// Token: 0x0400042F RID: 1071
		private static readonly IntPtr NativeMethodInfoPtr_Init_Public_Void_Format_0;

		// Token: 0x04000430 RID: 1072
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Void_0;

		// Token: 0x04000431 RID: 1073
		private static readonly IntPtr NativeMethodInfoPtr_get_Issues_Public_get_List_1_ParsingIssue_0;

		// Token: 0x04000432 RID: 1074
		private static readonly IntPtr NativeMethodInfoPtr_get_HasIssues_Public_get_Boolean_0;

		// Token: 0x04000433 RID: 1075
		private static readonly IntPtr NativeMethodInfoPtr_get_MessageShort_Public_get_String_0;

		// Token: 0x04000434 RID: 1076
		private static readonly IntPtr NativeMethodInfoPtr_get_Message_Public_Virtual_get_String_0;

		// Token: 0x04000435 RID: 1077
		private static readonly IntPtr NativeMethodInfoPtr_AddIssue_Public_Void_String_Int32_Int32_0;

		// Token: 0x04000436 RID: 1078
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000154 RID: 340
		public class ParsingIssue : Object
		{
			// Token: 0x06000EF2 RID: 3826 RVA: 0x00040408 File Offset: 0x0003E608
			// Note: this type is marked as 'beforefieldinit'.
			static ParsingIssue()
			{
				Il2CppClassPointerStore<ParsingErrors.ParsingIssue>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ParsingErrors>.NativeClassPtr, "ParsingIssue");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ParsingErrors.ParsingIssue>.NativeClassPtr);
				ParsingErrors.ParsingIssue.NativeFieldInfoPtr__Index_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParsingErrors.ParsingIssue>.NativeClassPtr, "<Index>k__BackingField");
				ParsingErrors.ParsingIssue.NativeFieldInfoPtr__Length_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParsingErrors.ParsingIssue>.NativeClassPtr, "<Length>k__BackingField");
				ParsingErrors.ParsingIssue.NativeFieldInfoPtr__Issue_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParsingErrors.ParsingIssue>.NativeClassPtr, "<Issue>k__BackingField");
				ParsingErrors.ParsingIssue.NativeMethodInfoPtr__ctor_Public_Void_String_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParsingErrors.ParsingIssue>.NativeClassPtr, 100664406);
				ParsingErrors.ParsingIssue.NativeMethodInfoPtr_get_Index_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParsingErrors.ParsingIssue>.NativeClassPtr, 100664407);
				ParsingErrors.ParsingIssue.NativeMethodInfoPtr_get_Length_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParsingErrors.ParsingIssue>.NativeClassPtr, 100664408);
				ParsingErrors.ParsingIssue.NativeMethodInfoPtr_get_Issue_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParsingErrors.ParsingIssue>.NativeClassPtr, 100664409);
			}

			// Token: 0x06000EF3 RID: 3827 RVA: 0x000404C0 File Offset: 0x0003E6C0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ParsingIssue(string issue, int index, int length)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ParsingErrors.ParsingIssue>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(issue);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParsingErrors.ParsingIssue.NativeMethodInfoPtr__ctor_Public_Void_String_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700040A RID: 1034
			// (get) Token: 0x06000EF4 RID: 3828 RVA: 0x00040528 File Offset: 0x0003E728
			public unsafe int Index
			{
				[CallerCount(5)]
				[CachedScanResults(RefRangeStart = 302497, RefRangeEnd = 302502, XrefRangeStart = 302497, XrefRangeEnd = 302502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParsingErrors.ParsingIssue.NativeMethodInfoPtr_get_Index_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x1700040B RID: 1035
			// (get) Token: 0x06000EF5 RID: 3829 RVA: 0x00040564 File Offset: 0x0003E764
			public unsafe int Length
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParsingErrors.ParsingIssue.NativeMethodInfoPtr_get_Length_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x1700040C RID: 1036
			// (get) Token: 0x06000EF6 RID: 3830 RVA: 0x000405A0 File Offset: 0x0003E7A0
			public unsafe string Issue
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParsingErrors.ParsingIssue.NativeMethodInfoPtr_get_Issue_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x06000EF7 RID: 3831 RVA: 0x0000848C File Offset: 0x0000668C
			public ParsingIssue(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000407 RID: 1031
			// (get) Token: 0x06000EF8 RID: 3832 RVA: 0x000405D8 File Offset: 0x0003E7D8
			// (set) Token: 0x06000EF9 RID: 3833 RVA: 0x00008495 File Offset: 0x00006695
			public unsafe int _Index_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParsingErrors.ParsingIssue.NativeFieldInfoPtr__Index_k__BackingField);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParsingErrors.ParsingIssue.NativeFieldInfoPtr__Index_k__BackingField)) = value;
				}
			}

			// Token: 0x17000408 RID: 1032
			// (get) Token: 0x06000EFA RID: 3834 RVA: 0x00040600 File Offset: 0x0003E800
			// (set) Token: 0x06000EFB RID: 3835 RVA: 0x000084B0 File Offset: 0x000066B0
			public unsafe int _Length_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParsingErrors.ParsingIssue.NativeFieldInfoPtr__Length_k__BackingField);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParsingErrors.ParsingIssue.NativeFieldInfoPtr__Length_k__BackingField)) = value;
				}
			}

			// Token: 0x17000409 RID: 1033
			// (get) Token: 0x06000EFC RID: 3836 RVA: 0x00040628 File Offset: 0x0003E828
			// (set) Token: 0x06000EFD RID: 3837 RVA: 0x000084CB File Offset: 0x000066CB
			public unsafe string _Issue_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParsingErrors.ParsingIssue.NativeFieldInfoPtr__Issue_k__BackingField);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParsingErrors.ParsingIssue.NativeFieldInfoPtr__Issue_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04000A43 RID: 2627
			private static readonly IntPtr NativeFieldInfoPtr__Index_k__BackingField;

			// Token: 0x04000A44 RID: 2628
			private static readonly IntPtr NativeFieldInfoPtr__Length_k__BackingField;

			// Token: 0x04000A45 RID: 2629
			private static readonly IntPtr NativeFieldInfoPtr__Issue_k__BackingField;

			// Token: 0x04000A46 RID: 2630
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Int32_Int32_0;

			// Token: 0x04000A47 RID: 2631
			private static readonly IntPtr NativeMethodInfoPtr_get_Index_Public_get_Int32_0;

			// Token: 0x04000A48 RID: 2632
			private static readonly IntPtr NativeMethodInfoPtr_get_Length_Public_get_Int32_0;

			// Token: 0x04000A49 RID: 2633
			private static readonly IntPtr NativeMethodInfoPtr_get_Issue_Public_get_String_0;
		}

		// Token: 0x02000155 RID: 341
		[ObfuscatedName("UnityEngine.Localization.SmartFormat.Core.Parsing.ParsingErrors+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06000EFE RID: 3838 RVA: 0x00040650 File Offset: 0x0003E850
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<ParsingErrors.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ParsingErrors>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ParsingErrors.__c>.NativeClassPtr);
				ParsingErrors.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParsingErrors.__c>.NativeClassPtr, "<>9");
				ParsingErrors.__c.NativeFieldInfoPtr___9__9_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParsingErrors.__c>.NativeClassPtr, "<>9__9_0");
				ParsingErrors.__c.NativeFieldInfoPtr___9__11_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParsingErrors.__c>.NativeClassPtr, "<>9__11_0");
				ParsingErrors.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParsingErrors.__c>.NativeClassPtr, 100664411);
				ParsingErrors.__c.NativeMethodInfoPtr__get_MessageShort_b__9_0_Internal_String_ParsingIssue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParsingErrors.__c>.NativeClassPtr, 100664412);
				ParsingErrors.__c.NativeMethodInfoPtr__get_Message_b__11_0_Internal_String_ParsingIssue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParsingErrors.__c>.NativeClassPtr, 100664413);
			}

			// Token: 0x06000EFF RID: 3839 RVA: 0x000406F4 File Offset: 0x0003E8F4
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ParsingErrors.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParsingErrors.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000F00 RID: 3840 RVA: 0x00040730 File Offset: 0x0003E930
			[CallerCount(0)]
			public unsafe string _get_MessageShort_b__9_0(ParsingErrors.ParsingIssue i)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(i);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParsingErrors.__c.NativeMethodInfoPtr__get_MessageShort_b__9_0_Internal_String_ParsingIssue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x06000F01 RID: 3841 RVA: 0x00040778 File Offset: 0x0003E978
			[CallerCount(0)]
			public unsafe string _get_Message_b__11_0(ParsingErrors.ParsingIssue i)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(i);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParsingErrors.__c.NativeMethodInfoPtr__get_Message_b__11_0_Internal_String_ParsingIssue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x06000F02 RID: 3842 RVA: 0x000084EA File Offset: 0x000066EA
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700040D RID: 1037
			// (get) Token: 0x06000F03 RID: 3843 RVA: 0x000407C0 File Offset: 0x0003E9C0
			// (set) Token: 0x06000F04 RID: 3844 RVA: 0x000084F3 File Offset: 0x000066F3
			public unsafe static ParsingErrors.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ParsingErrors.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ParsingErrors.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ParsingErrors.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700040E RID: 1038
			// (get) Token: 0x06000F05 RID: 3845 RVA: 0x000407E8 File Offset: 0x0003E9E8
			// (set) Token: 0x06000F06 RID: 3846 RVA: 0x00008505 File Offset: 0x00006705
			public unsafe static Func<ParsingErrors.ParsingIssue, string> __9__9_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ParsingErrors.__c.NativeFieldInfoPtr___9__9_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<ParsingErrors.ParsingIssue, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ParsingErrors.__c.NativeFieldInfoPtr___9__9_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700040F RID: 1039
			// (get) Token: 0x06000F07 RID: 3847 RVA: 0x00040810 File Offset: 0x0003EA10
			// (set) Token: 0x06000F08 RID: 3848 RVA: 0x00008517 File Offset: 0x00006717
			public unsafe static Func<ParsingErrors.ParsingIssue, string> __9__11_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ParsingErrors.__c.NativeFieldInfoPtr___9__11_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<ParsingErrors.ParsingIssue, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ParsingErrors.__c.NativeFieldInfoPtr___9__11_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000A4A RID: 2634
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04000A4B RID: 2635
			private static readonly IntPtr NativeFieldInfoPtr___9__9_0;

			// Token: 0x04000A4C RID: 2636
			private static readonly IntPtr NativeFieldInfoPtr___9__11_0;

			// Token: 0x04000A4D RID: 2637
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000A4E RID: 2638
			private static readonly IntPtr NativeMethodInfoPtr__get_MessageShort_b__9_0_Internal_String_ParsingIssue_0;

			// Token: 0x04000A4F RID: 2639
			private static readonly IntPtr NativeMethodInfoPtr__get_Message_b__11_0_Internal_String_ParsingIssue_0;
		}
	}
}
