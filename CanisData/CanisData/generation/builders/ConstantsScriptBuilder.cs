using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace CanisData.generation.builders
{
	// Token: 0x02000029 RID: 41
	public class ConstantsScriptBuilder : ScriptBuilder
	{
		// Token: 0x06000181 RID: 385 RVA: 0x00009380 File Offset: 0x00007580
		// Note: this type is marked as 'beforefieldinit'.
		static ConstantsScriptBuilder()
		{
			Il2CppClassPointerStore<ConstantsScriptBuilder>.NativeClassPtr = IL2CPP.GetIl2CppClass("CanisData.dll", "CanisData.generation.builders", "ConstantsScriptBuilder");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConstantsScriptBuilder>.NativeClassPtr);
			ConstantsScriptBuilder.NativeFieldInfoPtr__ProjectName_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstantsScriptBuilder>.NativeClassPtr, "<ProjectName>k__BackingField");
			ConstantsScriptBuilder.NativeFieldInfoPtr__SetName_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstantsScriptBuilder>.NativeClassPtr, "<SetName>k__BackingField");
			ConstantsScriptBuilder.NativeFieldInfoPtr__UseDirective_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstantsScriptBuilder>.NativeClassPtr, "<UseDirective>k__BackingField");
			ConstantsScriptBuilder.NativeFieldInfoPtr__DirectiveName_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstantsScriptBuilder>.NativeClassPtr, "<DirectiveName>k__BackingField");
			ConstantsScriptBuilder.NativeFieldInfoPtr_ConstantDefinitions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstantsScriptBuilder>.NativeClassPtr, "ConstantDefinitions");
			ConstantsScriptBuilder.NativeMethodInfoPtr_get_ProjectName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstantsScriptBuilder>.NativeClassPtr, 100663487);
			ConstantsScriptBuilder.NativeMethodInfoPtr_set_ProjectName_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstantsScriptBuilder>.NativeClassPtr, 100663488);
			ConstantsScriptBuilder.NativeMethodInfoPtr_get_SetName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstantsScriptBuilder>.NativeClassPtr, 100663489);
			ConstantsScriptBuilder.NativeMethodInfoPtr_set_SetName_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstantsScriptBuilder>.NativeClassPtr, 100663490);
			ConstantsScriptBuilder.NativeMethodInfoPtr_get_UseDirective_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstantsScriptBuilder>.NativeClassPtr, 100663491);
			ConstantsScriptBuilder.NativeMethodInfoPtr_set_UseDirective_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstantsScriptBuilder>.NativeClassPtr, 100663492);
			ConstantsScriptBuilder.NativeMethodInfoPtr_get_DirectiveName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstantsScriptBuilder>.NativeClassPtr, 100663493);
			ConstantsScriptBuilder.NativeMethodInfoPtr_set_DirectiveName_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstantsScriptBuilder>.NativeClassPtr, 100663494);
			ConstantsScriptBuilder.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstantsScriptBuilder>.NativeClassPtr, 100663495);
			ConstantsScriptBuilder.NativeMethodInfoPtr_get_HardConstantsMap_Public_get_Dictionary_2_String_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstantsScriptBuilder>.NativeClassPtr, 100663496);
			ConstantsScriptBuilder.NativeMethodInfoPtr_get_MediumConstantsMap_Public_get_Dictionary_2_String_Nullable_1_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstantsScriptBuilder>.NativeClassPtr, 100663497);
			ConstantsScriptBuilder.NativeMethodInfoPtr_get_EasyConstantsMap_Public_get_Dictionary_2_String_Nullable_1_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstantsScriptBuilder>.NativeClassPtr, 100663498);
		}

		// Token: 0x1700006F RID: 111
		// (get) Token: 0x06000182 RID: 386 RVA: 0x00009504 File Offset: 0x00007704
		// (set) Token: 0x06000183 RID: 387 RVA: 0x0000953C File Offset: 0x0000773C
		public unsafe string ProjectName
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstantsScriptBuilder.NativeMethodInfoPtr_get_ProjectName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstantsScriptBuilder.NativeMethodInfoPtr_set_ProjectName_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000070 RID: 112
		// (get) Token: 0x06000184 RID: 388 RVA: 0x00009580 File Offset: 0x00007780
		// (set) Token: 0x06000185 RID: 389 RVA: 0x000095B8 File Offset: 0x000077B8
		public unsafe string SetName
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 131885, RefRangeEnd = 131899, XrefRangeStart = 131885, XrefRangeEnd = 131899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstantsScriptBuilder.NativeMethodInfoPtr_get_SetName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstantsScriptBuilder.NativeMethodInfoPtr_set_SetName_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000071 RID: 113
		// (get) Token: 0x06000186 RID: 390 RVA: 0x000095FC File Offset: 0x000077FC
		// (set) Token: 0x06000187 RID: 391 RVA: 0x00009638 File Offset: 0x00007838
		public unsafe bool UseDirective
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstantsScriptBuilder.NativeMethodInfoPtr_get_UseDirective_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstantsScriptBuilder.NativeMethodInfoPtr_set_UseDirective_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000072 RID: 114
		// (get) Token: 0x06000188 RID: 392 RVA: 0x00009678 File Offset: 0x00007878
		// (set) Token: 0x06000189 RID: 393 RVA: 0x000096B0 File Offset: 0x000078B0
		public unsafe string DirectiveName
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 329189, RefRangeEnd = 329190, XrefRangeStart = 329189, XrefRangeEnd = 329190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstantsScriptBuilder.NativeMethodInfoPtr_get_DirectiveName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstantsScriptBuilder.NativeMethodInfoPtr_set_DirectiveName_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600018A RID: 394 RVA: 0x000096F4 File Offset: 0x000078F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1224473, XrefRangeEnd = 1224490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ConstantsScriptBuilder()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConstantsScriptBuilder>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstantsScriptBuilder.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000073 RID: 115
		// (get) Token: 0x0600018B RID: 395 RVA: 0x00009730 File Offset: 0x00007930
		public unsafe Dictionary<string, double> HardConstantsMap
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1224490, XrefRangeEnd = 1224522, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstantsScriptBuilder.NativeMethodInfoPtr_get_HardConstantsMap_Public_get_Dictionary_2_String_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<string, double>>(intPtr3) : null;
			}
		}

		// Token: 0x17000074 RID: 116
		// (get) Token: 0x0600018C RID: 396 RVA: 0x00009770 File Offset: 0x00007970
		public unsafe Dictionary<string, Nullable<double>> MediumConstantsMap
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1224571, RefRangeEnd = 1224572, XrefRangeStart = 1224522, XrefRangeEnd = 1224571, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstantsScriptBuilder.NativeMethodInfoPtr_get_MediumConstantsMap_Public_get_Dictionary_2_String_Nullable_1_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<string, Nullable<double>>>(intPtr3) : null;
			}
		}

		// Token: 0x17000075 RID: 117
		// (get) Token: 0x0600018D RID: 397 RVA: 0x000097B0 File Offset: 0x000079B0
		public unsafe Dictionary<string, Nullable<double>> EasyConstantsMap
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1224621, RefRangeEnd = 1224622, XrefRangeStart = 1224572, XrefRangeEnd = 1224621, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstantsScriptBuilder.NativeMethodInfoPtr_get_EasyConstantsMap_Public_get_Dictionary_2_String_Nullable_1_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<string, Nullable<double>>>(intPtr3) : null;
			}
		}

		// Token: 0x0600018E RID: 398 RVA: 0x00002BCD File Offset: 0x00000DCD
		public ConstantsScriptBuilder(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700006A RID: 106
		// (get) Token: 0x0600018F RID: 399 RVA: 0x000097F0 File Offset: 0x000079F0
		// (set) Token: 0x06000190 RID: 400 RVA: 0x00002BD6 File Offset: 0x00000DD6
		public unsafe string _ProjectName_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstantsScriptBuilder.NativeFieldInfoPtr__ProjectName_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstantsScriptBuilder.NativeFieldInfoPtr__ProjectName_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700006B RID: 107
		// (get) Token: 0x06000191 RID: 401 RVA: 0x00009818 File Offset: 0x00007A18
		// (set) Token: 0x06000192 RID: 402 RVA: 0x00002BF5 File Offset: 0x00000DF5
		public unsafe string _SetName_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstantsScriptBuilder.NativeFieldInfoPtr__SetName_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstantsScriptBuilder.NativeFieldInfoPtr__SetName_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700006C RID: 108
		// (get) Token: 0x06000193 RID: 403 RVA: 0x00009840 File Offset: 0x00007A40
		// (set) Token: 0x06000194 RID: 404 RVA: 0x00002C14 File Offset: 0x00000E14
		public unsafe bool _UseDirective_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstantsScriptBuilder.NativeFieldInfoPtr__UseDirective_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstantsScriptBuilder.NativeFieldInfoPtr__UseDirective_k__BackingField)) = value;
			}
		}

		// Token: 0x1700006D RID: 109
		// (get) Token: 0x06000195 RID: 405 RVA: 0x00009868 File Offset: 0x00007A68
		// (set) Token: 0x06000196 RID: 406 RVA: 0x00002C2F File Offset: 0x00000E2F
		public unsafe string _DirectiveName_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstantsScriptBuilder.NativeFieldInfoPtr__DirectiveName_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstantsScriptBuilder.NativeFieldInfoPtr__DirectiveName_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700006E RID: 110
		// (get) Token: 0x06000197 RID: 407 RVA: 0x00009890 File Offset: 0x00007A90
		// (set) Token: 0x06000198 RID: 408 RVA: 0x00002C4E File Offset: 0x00000E4E
		public unsafe IReadOnlyList<ConstantsScriptBuilder.ConstantDefinitionBuilder> ConstantDefinitions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstantsScriptBuilder.NativeFieldInfoPtr_ConstantDefinitions);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IReadOnlyList<ConstantsScriptBuilder.ConstantDefinitionBuilder>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstantsScriptBuilder.NativeFieldInfoPtr_ConstantDefinitions), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040000ED RID: 237
		private static readonly IntPtr NativeFieldInfoPtr__ProjectName_k__BackingField;

		// Token: 0x040000EE RID: 238
		private static readonly IntPtr NativeFieldInfoPtr__SetName_k__BackingField;

		// Token: 0x040000EF RID: 239
		private static readonly IntPtr NativeFieldInfoPtr__UseDirective_k__BackingField;

		// Token: 0x040000F0 RID: 240
		private static readonly IntPtr NativeFieldInfoPtr__DirectiveName_k__BackingField;

		// Token: 0x040000F1 RID: 241
		private static readonly IntPtr NativeFieldInfoPtr_ConstantDefinitions;

		// Token: 0x040000F2 RID: 242
		private static readonly IntPtr NativeMethodInfoPtr_get_ProjectName_Public_get_String_0;

		// Token: 0x040000F3 RID: 243
		private static readonly IntPtr NativeMethodInfoPtr_set_ProjectName_Public_set_Void_String_0;

		// Token: 0x040000F4 RID: 244
		private static readonly IntPtr NativeMethodInfoPtr_get_SetName_Public_get_String_0;

		// Token: 0x040000F5 RID: 245
		private static readonly IntPtr NativeMethodInfoPtr_set_SetName_Public_set_Void_String_0;

		// Token: 0x040000F6 RID: 246
		private static readonly IntPtr NativeMethodInfoPtr_get_UseDirective_Public_get_Boolean_0;

		// Token: 0x040000F7 RID: 247
		private static readonly IntPtr NativeMethodInfoPtr_set_UseDirective_Public_set_Void_Boolean_0;

		// Token: 0x040000F8 RID: 248
		private static readonly IntPtr NativeMethodInfoPtr_get_DirectiveName_Public_get_String_0;

		// Token: 0x040000F9 RID: 249
		private static readonly IntPtr NativeMethodInfoPtr_set_DirectiveName_Public_set_Void_String_0;

		// Token: 0x040000FA RID: 250
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040000FB RID: 251
		private static readonly IntPtr NativeMethodInfoPtr_get_HardConstantsMap_Public_get_Dictionary_2_String_Double_0;

		// Token: 0x040000FC RID: 252
		private static readonly IntPtr NativeMethodInfoPtr_get_MediumConstantsMap_Public_get_Dictionary_2_String_Nullable_1_Double_0;

		// Token: 0x040000FD RID: 253
		private static readonly IntPtr NativeMethodInfoPtr_get_EasyConstantsMap_Public_get_Dictionary_2_String_Nullable_1_Double_0;

		// Token: 0x02000042 RID: 66
		public class ConstantDefinitionBuilder : Object
		{
			// Token: 0x060002A2 RID: 674 RVA: 0x0000C3A4 File Offset: 0x0000A5A4
			// Note: this type is marked as 'beforefieldinit'.
			static ConstantDefinitionBuilder()
			{
				Il2CppClassPointerStore<ConstantsScriptBuilder.ConstantDefinitionBuilder>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ConstantsScriptBuilder>.NativeClassPtr, "ConstantDefinitionBuilder");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConstantsScriptBuilder.ConstantDefinitionBuilder>.NativeClassPtr);
				ConstantsScriptBuilder.ConstantDefinitionBuilder.NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstantsScriptBuilder.ConstantDefinitionBuilder>.NativeClassPtr, "Name");
				ConstantsScriptBuilder.ConstantDefinitionBuilder.NativeFieldInfoPtr_HardValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstantsScriptBuilder.ConstantDefinitionBuilder>.NativeClassPtr, "HardValue");
				ConstantsScriptBuilder.ConstantDefinitionBuilder.NativeFieldInfoPtr_MediumValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstantsScriptBuilder.ConstantDefinitionBuilder>.NativeClassPtr, "MediumValue");
				ConstantsScriptBuilder.ConstantDefinitionBuilder.NativeFieldInfoPtr_EasyValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstantsScriptBuilder.ConstantDefinitionBuilder>.NativeClassPtr, "EasyValue");
				ConstantsScriptBuilder.ConstantDefinitionBuilder.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstantsScriptBuilder.ConstantDefinitionBuilder>.NativeClassPtr, 100663499);
			}

			// Token: 0x060002A3 RID: 675 RVA: 0x0000C434 File Offset: 0x0000A634
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1224467, XrefRangeEnd = 1224471, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ConstantDefinitionBuilder()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConstantsScriptBuilder.ConstantDefinitionBuilder>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstantsScriptBuilder.ConstantDefinitionBuilder.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060002A4 RID: 676 RVA: 0x0000369A File Offset: 0x0000189A
			public ConstantDefinitionBuilder(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170000CC RID: 204
			// (get) Token: 0x060002A5 RID: 677 RVA: 0x0000C470 File Offset: 0x0000A670
			// (set) Token: 0x060002A6 RID: 678 RVA: 0x000036A3 File Offset: 0x000018A3
			public unsafe string Name
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstantsScriptBuilder.ConstantDefinitionBuilder.NativeFieldInfoPtr_Name);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstantsScriptBuilder.ConstantDefinitionBuilder.NativeFieldInfoPtr_Name), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170000CD RID: 205
			// (get) Token: 0x060002A7 RID: 679 RVA: 0x0000C498 File Offset: 0x0000A698
			// (set) Token: 0x060002A8 RID: 680 RVA: 0x000036C2 File Offset: 0x000018C2
			public unsafe double HardValue
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstantsScriptBuilder.ConstantDefinitionBuilder.NativeFieldInfoPtr_HardValue);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstantsScriptBuilder.ConstantDefinitionBuilder.NativeFieldInfoPtr_HardValue)) = value;
				}
			}

			// Token: 0x170000CE RID: 206
			// (get) Token: 0x060002A9 RID: 681 RVA: 0x0000C4C0 File Offset: 0x0000A6C0
			// (set) Token: 0x060002AA RID: 682 RVA: 0x000036DD File Offset: 0x000018DD
			public Nullable<double> MediumValue
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstantsScriptBuilder.ConstantDefinitionBuilder.NativeFieldInfoPtr_MediumValue);
					return new Nullable<double>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<double>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstantsScriptBuilder.ConstantDefinitionBuilder.NativeFieldInfoPtr_MediumValue), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<double>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170000CF RID: 207
			// (get) Token: 0x060002AB RID: 683 RVA: 0x0000C4F0 File Offset: 0x0000A6F0
			// (set) Token: 0x060002AC RID: 684 RVA: 0x0000370B File Offset: 0x0000190B
			public Nullable<double> EasyValue
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstantsScriptBuilder.ConstantDefinitionBuilder.NativeFieldInfoPtr_EasyValue);
					return new Nullable<double>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<double>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstantsScriptBuilder.ConstantDefinitionBuilder.NativeFieldInfoPtr_EasyValue), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<double>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04000184 RID: 388
			private static readonly IntPtr NativeFieldInfoPtr_Name;

			// Token: 0x04000185 RID: 389
			private static readonly IntPtr NativeFieldInfoPtr_HardValue;

			// Token: 0x04000186 RID: 390
			private static readonly IntPtr NativeFieldInfoPtr_MediumValue;

			// Token: 0x04000187 RID: 391
			private static readonly IntPtr NativeFieldInfoPtr_EasyValue;

			// Token: 0x04000188 RID: 392
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000043 RID: 67
		[ObfuscatedName("CanisData.generation.builders.ConstantsScriptBuilder+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x060002AD RID: 685 RVA: 0x0000C520 File Offset: 0x0000A720
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<ConstantsScriptBuilder.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ConstantsScriptBuilder>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConstantsScriptBuilder.__c>.NativeClassPtr);
				ConstantsScriptBuilder.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstantsScriptBuilder.__c>.NativeClassPtr, "<>9");
				ConstantsScriptBuilder.__c.NativeFieldInfoPtr___9__20_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstantsScriptBuilder.__c>.NativeClassPtr, "<>9__20_0");
				ConstantsScriptBuilder.__c.NativeFieldInfoPtr___9__20_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstantsScriptBuilder.__c>.NativeClassPtr, "<>9__20_1");
				ConstantsScriptBuilder.__c.NativeFieldInfoPtr___9__22_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstantsScriptBuilder.__c>.NativeClassPtr, "<>9__22_0");
				ConstantsScriptBuilder.__c.NativeFieldInfoPtr___9__22_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstantsScriptBuilder.__c>.NativeClassPtr, "<>9__22_1");
				ConstantsScriptBuilder.__c.NativeFieldInfoPtr___9__22_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstantsScriptBuilder.__c>.NativeClassPtr, "<>9__22_2");
				ConstantsScriptBuilder.__c.NativeFieldInfoPtr___9__24_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstantsScriptBuilder.__c>.NativeClassPtr, "<>9__24_0");
				ConstantsScriptBuilder.__c.NativeFieldInfoPtr___9__24_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstantsScriptBuilder.__c>.NativeClassPtr, "<>9__24_1");
				ConstantsScriptBuilder.__c.NativeFieldInfoPtr___9__24_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstantsScriptBuilder.__c>.NativeClassPtr, "<>9__24_2");
				ConstantsScriptBuilder.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstantsScriptBuilder.__c>.NativeClassPtr, 100663501);
				ConstantsScriptBuilder.__c.NativeMethodInfoPtr__get_HardConstantsMap_b__20_0_Internal_String_ConstantDefinitionBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstantsScriptBuilder.__c>.NativeClassPtr, 100663502);
				ConstantsScriptBuilder.__c.NativeMethodInfoPtr__get_HardConstantsMap_b__20_1_Internal_Double_ConstantDefinitionBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstantsScriptBuilder.__c>.NativeClassPtr, 100663503);
				ConstantsScriptBuilder.__c.NativeMethodInfoPtr__get_MediumConstantsMap_b__22_0_Internal_Boolean_ConstantDefinitionBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstantsScriptBuilder.__c>.NativeClassPtr, 100663504);
				ConstantsScriptBuilder.__c.NativeMethodInfoPtr__get_MediumConstantsMap_b__22_1_Internal_String_ConstantDefinitionBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstantsScriptBuilder.__c>.NativeClassPtr, 100663505);
				ConstantsScriptBuilder.__c.NativeMethodInfoPtr__get_MediumConstantsMap_b__22_2_Internal_Nullable_1_Double_ConstantDefinitionBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstantsScriptBuilder.__c>.NativeClassPtr, 100663506);
				ConstantsScriptBuilder.__c.NativeMethodInfoPtr__get_EasyConstantsMap_b__24_0_Internal_Boolean_ConstantDefinitionBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstantsScriptBuilder.__c>.NativeClassPtr, 100663507);
				ConstantsScriptBuilder.__c.NativeMethodInfoPtr__get_EasyConstantsMap_b__24_1_Internal_String_ConstantDefinitionBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstantsScriptBuilder.__c>.NativeClassPtr, 100663508);
				ConstantsScriptBuilder.__c.NativeMethodInfoPtr__get_EasyConstantsMap_b__24_2_Internal_Nullable_1_Double_ConstantDefinitionBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstantsScriptBuilder.__c>.NativeClassPtr, 100663509);
			}

			// Token: 0x060002AE RID: 686 RVA: 0x0000C6B4 File Offset: 0x0000A8B4
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConstantsScriptBuilder.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstantsScriptBuilder.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060002AF RID: 687 RVA: 0x0000C6F0 File Offset: 0x0000A8F0
			[CallerCount(0)]
			public unsafe string _get_HardConstantsMap_b__20_0(ConstantsScriptBuilder.ConstantDefinitionBuilder _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstantsScriptBuilder.__c.NativeMethodInfoPtr__get_HardConstantsMap_b__20_0_Internal_String_ConstantDefinitionBuilder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x060002B0 RID: 688 RVA: 0x0000C738 File Offset: 0x0000A938
			[CallerCount(0)]
			public unsafe double _get_HardConstantsMap_b__20_1(ConstantsScriptBuilder.ConstantDefinitionBuilder _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstantsScriptBuilder.__c.NativeMethodInfoPtr__get_HardConstantsMap_b__20_1_Internal_Double_ConstantDefinitionBuilder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060002B1 RID: 689 RVA: 0x0000C788 File Offset: 0x0000A988
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1224471, XrefRangeEnd = 1224472, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _get_MediumConstantsMap_b__22_0(ConstantsScriptBuilder.ConstantDefinitionBuilder _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstantsScriptBuilder.__c.NativeMethodInfoPtr__get_MediumConstantsMap_b__22_0_Internal_Boolean_ConstantDefinitionBuilder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060002B2 RID: 690 RVA: 0x0000C7D8 File Offset: 0x0000A9D8
			[CallerCount(0)]
			public unsafe string _get_MediumConstantsMap_b__22_1(ConstantsScriptBuilder.ConstantDefinitionBuilder _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstantsScriptBuilder.__c.NativeMethodInfoPtr__get_MediumConstantsMap_b__22_1_Internal_String_ConstantDefinitionBuilder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x060002B3 RID: 691 RVA: 0x0000C820 File Offset: 0x0000AA20
			[CallerCount(0)]
			public unsafe Nullable<double> _get_MediumConstantsMap_b__22_2(ConstantsScriptBuilder.ConstantDefinitionBuilder _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstantsScriptBuilder.__c.NativeMethodInfoPtr__get_MediumConstantsMap_b__22_2_Internal_Nullable_1_Double_ConstantDefinitionBuilder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return new Nullable<double>(intPtr);
				}
			}

			// Token: 0x060002B4 RID: 692 RVA: 0x0000C868 File Offset: 0x0000AA68
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1224472, XrefRangeEnd = 1224473, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _get_EasyConstantsMap_b__24_0(ConstantsScriptBuilder.ConstantDefinitionBuilder _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstantsScriptBuilder.__c.NativeMethodInfoPtr__get_EasyConstantsMap_b__24_0_Internal_Boolean_ConstantDefinitionBuilder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060002B5 RID: 693 RVA: 0x0000C8B8 File Offset: 0x0000AAB8
			[CallerCount(0)]
			public unsafe string _get_EasyConstantsMap_b__24_1(ConstantsScriptBuilder.ConstantDefinitionBuilder _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstantsScriptBuilder.__c.NativeMethodInfoPtr__get_EasyConstantsMap_b__24_1_Internal_String_ConstantDefinitionBuilder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x060002B6 RID: 694 RVA: 0x0000C900 File Offset: 0x0000AB00
			[CallerCount(0)]
			public unsafe Nullable<double> _get_EasyConstantsMap_b__24_2(ConstantsScriptBuilder.ConstantDefinitionBuilder _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstantsScriptBuilder.__c.NativeMethodInfoPtr__get_EasyConstantsMap_b__24_2_Internal_Nullable_1_Double_ConstantDefinitionBuilder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return new Nullable<double>(intPtr);
				}
			}

			// Token: 0x060002B7 RID: 695 RVA: 0x00003739 File Offset: 0x00001939
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170000D0 RID: 208
			// (get) Token: 0x060002B8 RID: 696 RVA: 0x0000C948 File Offset: 0x0000AB48
			// (set) Token: 0x060002B9 RID: 697 RVA: 0x00003742 File Offset: 0x00001942
			public unsafe static ConstantsScriptBuilder.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ConstantsScriptBuilder.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConstantsScriptBuilder.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ConstantsScriptBuilder.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170000D1 RID: 209
			// (get) Token: 0x060002BA RID: 698 RVA: 0x0000C970 File Offset: 0x0000AB70
			// (set) Token: 0x060002BB RID: 699 RVA: 0x00003754 File Offset: 0x00001954
			public unsafe static Func<ConstantsScriptBuilder.ConstantDefinitionBuilder, string> __9__20_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ConstantsScriptBuilder.__c.NativeFieldInfoPtr___9__20_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<ConstantsScriptBuilder.ConstantDefinitionBuilder, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ConstantsScriptBuilder.__c.NativeFieldInfoPtr___9__20_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170000D2 RID: 210
			// (get) Token: 0x060002BC RID: 700 RVA: 0x0000C998 File Offset: 0x0000AB98
			// (set) Token: 0x060002BD RID: 701 RVA: 0x00003766 File Offset: 0x00001966
			public unsafe static Func<ConstantsScriptBuilder.ConstantDefinitionBuilder, double> __9__20_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ConstantsScriptBuilder.__c.NativeFieldInfoPtr___9__20_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<ConstantsScriptBuilder.ConstantDefinitionBuilder, double>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ConstantsScriptBuilder.__c.NativeFieldInfoPtr___9__20_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170000D3 RID: 211
			// (get) Token: 0x060002BE RID: 702 RVA: 0x0000C9C0 File Offset: 0x0000ABC0
			// (set) Token: 0x060002BF RID: 703 RVA: 0x00003778 File Offset: 0x00001978
			public unsafe static Func<ConstantsScriptBuilder.ConstantDefinitionBuilder, bool> __9__22_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ConstantsScriptBuilder.__c.NativeFieldInfoPtr___9__22_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<ConstantsScriptBuilder.ConstantDefinitionBuilder, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ConstantsScriptBuilder.__c.NativeFieldInfoPtr___9__22_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170000D4 RID: 212
			// (get) Token: 0x060002C0 RID: 704 RVA: 0x0000C9E8 File Offset: 0x0000ABE8
			// (set) Token: 0x060002C1 RID: 705 RVA: 0x0000378A File Offset: 0x0000198A
			public unsafe static Func<ConstantsScriptBuilder.ConstantDefinitionBuilder, string> __9__22_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ConstantsScriptBuilder.__c.NativeFieldInfoPtr___9__22_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<ConstantsScriptBuilder.ConstantDefinitionBuilder, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ConstantsScriptBuilder.__c.NativeFieldInfoPtr___9__22_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170000D5 RID: 213
			// (get) Token: 0x060002C2 RID: 706 RVA: 0x0000CA10 File Offset: 0x0000AC10
			// (set) Token: 0x060002C3 RID: 707 RVA: 0x0000379C File Offset: 0x0000199C
			public unsafe static Func<ConstantsScriptBuilder.ConstantDefinitionBuilder, Nullable<double>> __9__22_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ConstantsScriptBuilder.__c.NativeFieldInfoPtr___9__22_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<ConstantsScriptBuilder.ConstantDefinitionBuilder, Nullable<double>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ConstantsScriptBuilder.__c.NativeFieldInfoPtr___9__22_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170000D6 RID: 214
			// (get) Token: 0x060002C4 RID: 708 RVA: 0x0000CA38 File Offset: 0x0000AC38
			// (set) Token: 0x060002C5 RID: 709 RVA: 0x000037AE File Offset: 0x000019AE
			public unsafe static Func<ConstantsScriptBuilder.ConstantDefinitionBuilder, bool> __9__24_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ConstantsScriptBuilder.__c.NativeFieldInfoPtr___9__24_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<ConstantsScriptBuilder.ConstantDefinitionBuilder, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ConstantsScriptBuilder.__c.NativeFieldInfoPtr___9__24_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170000D7 RID: 215
			// (get) Token: 0x060002C6 RID: 710 RVA: 0x0000CA60 File Offset: 0x0000AC60
			// (set) Token: 0x060002C7 RID: 711 RVA: 0x000037C0 File Offset: 0x000019C0
			public unsafe static Func<ConstantsScriptBuilder.ConstantDefinitionBuilder, string> __9__24_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ConstantsScriptBuilder.__c.NativeFieldInfoPtr___9__24_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<ConstantsScriptBuilder.ConstantDefinitionBuilder, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ConstantsScriptBuilder.__c.NativeFieldInfoPtr___9__24_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170000D8 RID: 216
			// (get) Token: 0x060002C8 RID: 712 RVA: 0x0000CA88 File Offset: 0x0000AC88
			// (set) Token: 0x060002C9 RID: 713 RVA: 0x000037D2 File Offset: 0x000019D2
			public unsafe static Func<ConstantsScriptBuilder.ConstantDefinitionBuilder, Nullable<double>> __9__24_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ConstantsScriptBuilder.__c.NativeFieldInfoPtr___9__24_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<ConstantsScriptBuilder.ConstantDefinitionBuilder, Nullable<double>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ConstantsScriptBuilder.__c.NativeFieldInfoPtr___9__24_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000189 RID: 393
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400018A RID: 394
			private static readonly IntPtr NativeFieldInfoPtr___9__20_0;

			// Token: 0x0400018B RID: 395
			private static readonly IntPtr NativeFieldInfoPtr___9__20_1;

			// Token: 0x0400018C RID: 396
			private static readonly IntPtr NativeFieldInfoPtr___9__22_0;

			// Token: 0x0400018D RID: 397
			private static readonly IntPtr NativeFieldInfoPtr___9__22_1;

			// Token: 0x0400018E RID: 398
			private static readonly IntPtr NativeFieldInfoPtr___9__22_2;

			// Token: 0x0400018F RID: 399
			private static readonly IntPtr NativeFieldInfoPtr___9__24_0;

			// Token: 0x04000190 RID: 400
			private static readonly IntPtr NativeFieldInfoPtr___9__24_1;

			// Token: 0x04000191 RID: 401
			private static readonly IntPtr NativeFieldInfoPtr___9__24_2;

			// Token: 0x04000192 RID: 402
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000193 RID: 403
			private static readonly IntPtr NativeMethodInfoPtr__get_HardConstantsMap_b__20_0_Internal_String_ConstantDefinitionBuilder_0;

			// Token: 0x04000194 RID: 404
			private static readonly IntPtr NativeMethodInfoPtr__get_HardConstantsMap_b__20_1_Internal_Double_ConstantDefinitionBuilder_0;

			// Token: 0x04000195 RID: 405
			private static readonly IntPtr NativeMethodInfoPtr__get_MediumConstantsMap_b__22_0_Internal_Boolean_ConstantDefinitionBuilder_0;

			// Token: 0x04000196 RID: 406
			private static readonly IntPtr NativeMethodInfoPtr__get_MediumConstantsMap_b__22_1_Internal_String_ConstantDefinitionBuilder_0;

			// Token: 0x04000197 RID: 407
			private static readonly IntPtr NativeMethodInfoPtr__get_MediumConstantsMap_b__22_2_Internal_Nullable_1_Double_ConstantDefinitionBuilder_0;

			// Token: 0x04000198 RID: 408
			private static readonly IntPtr NativeMethodInfoPtr__get_EasyConstantsMap_b__24_0_Internal_Boolean_ConstantDefinitionBuilder_0;

			// Token: 0x04000199 RID: 409
			private static readonly IntPtr NativeMethodInfoPtr__get_EasyConstantsMap_b__24_1_Internal_String_ConstantDefinitionBuilder_0;

			// Token: 0x0400019A RID: 410
			private static readonly IntPtr NativeMethodInfoPtr__get_EasyConstantsMap_b__24_2_Internal_Nullable_1_Double_ConstantDefinitionBuilder_0;
		}
	}
}
