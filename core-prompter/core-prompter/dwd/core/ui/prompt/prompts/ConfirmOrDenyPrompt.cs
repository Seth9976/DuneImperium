using System;
using Canis.utils.localization;
using dwd.core.data.composition;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace dwd.core.ui.prompt.prompts
{
	// Token: 0x02000019 RID: 25
	public class ConfirmOrDenyPrompt : ChoicePrompt<bool>
	{
		// Token: 0x0600011E RID: 286 RVA: 0x00007448 File Offset: 0x00005648
		// Note: this type is marked as 'beforefieldinit'.
		static ConfirmOrDenyPrompt()
		{
			Il2CppClassPointerStore<ConfirmOrDenyPrompt>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-prompter.dll", "dwd.core.ui.prompt.prompts", "ConfirmOrDenyPrompt");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConfirmOrDenyPrompt>.NativeClassPtr);
			ConfirmOrDenyPrompt.NativeFieldInfoPtr__PromptData_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfirmOrDenyPrompt>.NativeClassPtr, "<PromptData>k__BackingField");
			ConfirmOrDenyPrompt.NativeFieldInfoPtr__ConfirmKey_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfirmOrDenyPrompt>.NativeClassPtr, "<ConfirmKey>k__BackingField");
			ConfirmOrDenyPrompt.NativeFieldInfoPtr__CancelKey_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfirmOrDenyPrompt>.NativeClassPtr, "<CancelKey>k__BackingField");
			ConfirmOrDenyPrompt.NativeFieldInfoPtr_DefaultConfirmKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfirmOrDenyPrompt>.NativeClassPtr, "DefaultConfirmKey");
			ConfirmOrDenyPrompt.NativeFieldInfoPtr_DefaultCancelKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfirmOrDenyPrompt>.NativeClassPtr, "DefaultCancelKey");
			ConfirmOrDenyPrompt.NativeMethodInfoPtr_get_PromptData_Public_Virtual_Final_New_get_DataComposition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfirmOrDenyPrompt>.NativeClassPtr, 100663397);
			ConfirmOrDenyPrompt.NativeMethodInfoPtr_get_ConfirmKey_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfirmOrDenyPrompt>.NativeClassPtr, 100663398);
			ConfirmOrDenyPrompt.NativeMethodInfoPtr_set_ConfirmKey_Private_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfirmOrDenyPrompt>.NativeClassPtr, 100663399);
			ConfirmOrDenyPrompt.NativeMethodInfoPtr_get_CancelKey_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfirmOrDenyPrompt>.NativeClassPtr, 100663400);
			ConfirmOrDenyPrompt.NativeMethodInfoPtr_set_CancelKey_Private_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfirmOrDenyPrompt>.NativeClassPtr, 100663401);
			ConfirmOrDenyPrompt.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfirmOrDenyPrompt>.NativeClassPtr, 100663402);
			ConfirmOrDenyPrompt.NativeMethodInfoPtr__ctor_Public_Void_LocalizedString_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfirmOrDenyPrompt>.NativeClassPtr, 100663403);
			ConfirmOrDenyPrompt.NativeMethodInfoPtr__ctor_Public_Void_DataComposition_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfirmOrDenyPrompt>.NativeClassPtr, 100663404);
			ConfirmOrDenyPrompt.NativeMethodInfoPtr_WithFlavor_Public_ConfirmOrDenyPrompt_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfirmOrDenyPrompt>.NativeClassPtr, 100663405);
		}

		// Token: 0x1700006B RID: 107
		// (get) Token: 0x0600011F RID: 287 RVA: 0x00007590 File Offset: 0x00005790
		public unsafe virtual DataComposition PromptData
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 131885, RefRangeEnd = 131899, XrefRangeStart = 131885, XrefRangeEnd = 131899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfirmOrDenyPrompt.NativeMethodInfoPtr_get_PromptData_Public_Virtual_Final_New_get_DataComposition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DataComposition>(intPtr3) : null;
			}
		}

		// Token: 0x1700006C RID: 108
		// (get) Token: 0x06000120 RID: 288 RVA: 0x000075D0 File Offset: 0x000057D0
		// (set) Token: 0x06000121 RID: 289 RVA: 0x00007608 File Offset: 0x00005808
		public unsafe string ConfirmKey
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 139770, RefRangeEnd = 139777, XrefRangeStart = 139770, XrefRangeEnd = 139777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfirmOrDenyPrompt.NativeMethodInfoPtr_get_ConfirmKey_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfirmOrDenyPrompt.NativeMethodInfoPtr_set_ConfirmKey_Private_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700006D RID: 109
		// (get) Token: 0x06000122 RID: 290 RVA: 0x0000764C File Offset: 0x0000584C
		// (set) Token: 0x06000123 RID: 291 RVA: 0x00007684 File Offset: 0x00005884
		public unsafe string CancelKey
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 329189, RefRangeEnd = 329190, XrefRangeStart = 329189, XrefRangeEnd = 329190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfirmOrDenyPrompt.NativeMethodInfoPtr_get_CancelKey_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfirmOrDenyPrompt.NativeMethodInfoPtr_set_CancelKey_Private_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000124 RID: 292 RVA: 0x000076C8 File Offset: 0x000058C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1213598, XrefRangeEnd = 1213606, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ConfirmOrDenyPrompt()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConfirmOrDenyPrompt>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfirmOrDenyPrompt.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000125 RID: 293 RVA: 0x00007704 File Offset: 0x00005904
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 1213623, RefRangeEnd = 1213636, XrefRangeStart = 1213606, XrefRangeEnd = 1213623, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ConfirmOrDenyPrompt(LocalizedString message, string confirmKey = null, string cancelKey = null)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConfirmOrDenyPrompt>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(confirmKey);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(cancelKey);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfirmOrDenyPrompt.NativeMethodInfoPtr__ctor_Public_Void_LocalizedString_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000126 RID: 294 RVA: 0x00007774 File Offset: 0x00005974
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 1213688, RefRangeEnd = 1213701, XrefRangeStart = 1213636, XrefRangeEnd = 1213688, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ConfirmOrDenyPrompt(DataComposition promptData, string confirmKey = null, string cancelKey = null)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConfirmOrDenyPrompt>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(promptData);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(confirmKey);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(cancelKey);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfirmOrDenyPrompt.NativeMethodInfoPtr__ctor_Public_Void_DataComposition_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000127 RID: 295 RVA: 0x000077E4 File Offset: 0x000059E4
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 1213704, RefRangeEnd = 1213716, XrefRangeStart = 1213701, XrefRangeEnd = 1213704, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ConfirmOrDenyPrompt WithFlavor(string flavor)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(flavor);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfirmOrDenyPrompt.NativeMethodInfoPtr_WithFlavor_Public_ConfirmOrDenyPrompt_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ConfirmOrDenyPrompt>(intPtr3) : null;
			}
		}

		// Token: 0x06000128 RID: 296 RVA: 0x00002903 File Offset: 0x00000B03
		public ConfirmOrDenyPrompt(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000066 RID: 102
		// (get) Token: 0x06000129 RID: 297 RVA: 0x00007834 File Offset: 0x00005A34
		// (set) Token: 0x0600012A RID: 298 RVA: 0x0000290C File Offset: 0x00000B0C
		public unsafe DataComposition _PromptData_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfirmOrDenyPrompt.NativeFieldInfoPtr__PromptData_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DataComposition>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfirmOrDenyPrompt.NativeFieldInfoPtr__PromptData_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000067 RID: 103
		// (get) Token: 0x0600012B RID: 299 RVA: 0x00007864 File Offset: 0x00005A64
		// (set) Token: 0x0600012C RID: 300 RVA: 0x0000292B File Offset: 0x00000B2B
		public unsafe string _ConfirmKey_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfirmOrDenyPrompt.NativeFieldInfoPtr__ConfirmKey_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfirmOrDenyPrompt.NativeFieldInfoPtr__ConfirmKey_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000068 RID: 104
		// (get) Token: 0x0600012D RID: 301 RVA: 0x0000788C File Offset: 0x00005A8C
		// (set) Token: 0x0600012E RID: 302 RVA: 0x0000294A File Offset: 0x00000B4A
		public unsafe string _CancelKey_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfirmOrDenyPrompt.NativeFieldInfoPtr__CancelKey_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfirmOrDenyPrompt.NativeFieldInfoPtr__CancelKey_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000069 RID: 105
		// (get) Token: 0x0600012F RID: 303 RVA: 0x000078B4 File Offset: 0x00005AB4
		// (set) Token: 0x06000130 RID: 304 RVA: 0x00002969 File Offset: 0x00000B69
		public unsafe static string DefaultConfirmKey
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ConfirmOrDenyPrompt.NativeFieldInfoPtr_DefaultConfirmKey, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ConfirmOrDenyPrompt.NativeFieldInfoPtr_DefaultConfirmKey, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700006A RID: 106
		// (get) Token: 0x06000131 RID: 305 RVA: 0x000078D4 File Offset: 0x00005AD4
		// (set) Token: 0x06000132 RID: 306 RVA: 0x0000297B File Offset: 0x00000B7B
		public unsafe static string DefaultCancelKey
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ConfirmOrDenyPrompt.NativeFieldInfoPtr_DefaultCancelKey, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ConfirmOrDenyPrompt.NativeFieldInfoPtr_DefaultCancelKey, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x0400009D RID: 157
		private static readonly IntPtr NativeFieldInfoPtr__PromptData_k__BackingField;

		// Token: 0x0400009E RID: 158
		private static readonly IntPtr NativeFieldInfoPtr__ConfirmKey_k__BackingField;

		// Token: 0x0400009F RID: 159
		private static readonly IntPtr NativeFieldInfoPtr__CancelKey_k__BackingField;

		// Token: 0x040000A0 RID: 160
		private static readonly IntPtr NativeFieldInfoPtr_DefaultConfirmKey;

		// Token: 0x040000A1 RID: 161
		private static readonly IntPtr NativeFieldInfoPtr_DefaultCancelKey;

		// Token: 0x040000A2 RID: 162
		private static readonly IntPtr NativeMethodInfoPtr_get_PromptData_Public_Virtual_Final_New_get_DataComposition_0;

		// Token: 0x040000A3 RID: 163
		private static readonly IntPtr NativeMethodInfoPtr_get_ConfirmKey_Public_get_String_0;

		// Token: 0x040000A4 RID: 164
		private static readonly IntPtr NativeMethodInfoPtr_set_ConfirmKey_Private_set_Void_String_0;

		// Token: 0x040000A5 RID: 165
		private static readonly IntPtr NativeMethodInfoPtr_get_CancelKey_Public_get_String_0;

		// Token: 0x040000A6 RID: 166
		private static readonly IntPtr NativeMethodInfoPtr_set_CancelKey_Private_set_Void_String_0;

		// Token: 0x040000A7 RID: 167
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040000A8 RID: 168
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_LocalizedString_String_String_0;

		// Token: 0x040000A9 RID: 169
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_DataComposition_String_String_0;

		// Token: 0x040000AA RID: 170
		private static readonly IntPtr NativeMethodInfoPtr_WithFlavor_Public_ConfirmOrDenyPrompt_String_0;
	}
}
