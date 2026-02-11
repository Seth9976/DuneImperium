using System;
using Canis.utils.localization;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace lib.canis.worm_canis.data.Skirmish.ScoringMethods
{
	// Token: 0x02000009 RID: 9
	public class SkirmishScoreItem : Object
	{
		// Token: 0x0600001E RID: 30 RVA: 0x000693C0 File Offset: 0x000675C0
		// Note: this type is marked as 'beforefieldinit'.
		static SkirmishScoreItem()
		{
			Il2CppClassPointerStore<SkirmishScoreItem>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "lib.canis.worm_canis.data.Skirmish.ScoringMethods", "SkirmishScoreItem");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SkirmishScoreItem>.NativeClassPtr);
			SkirmishScoreItem.NativeFieldInfoPtr_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkirmishScoreItem>.NativeClassPtr, "Value");
			SkirmishScoreItem.NativeFieldInfoPtr_Prompt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkirmishScoreItem>.NativeClassPtr, "Prompt");
			SkirmishScoreItem.NativeMethodInfoPtr__ctor_Public_Void_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkirmishScoreItem>.NativeClassPtr, 100663309);
			SkirmishScoreItem.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkirmishScoreItem>.NativeClassPtr, 100663310);
		}

		// Token: 0x0600001F RID: 31 RVA: 0x00069440 File Offset: 0x00067640
		[CallerCount(42)]
		[CachedScanResults(RefRangeStart = 3050, RefRangeEnd = 3092, XrefRangeStart = 3044, XrefRangeEnd = 3050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SkirmishScoreItem(int value, string prompt)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SkirmishScoreItem>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(prompt);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkirmishScoreItem.NativeMethodInfoPtr__ctor_Public_Void_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000020 RID: 32 RVA: 0x0006949C File Offset: 0x0006769C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 3092, XrefRangeEnd = 3100, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SkirmishScoreItem.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000021 RID: 33 RVA: 0x00002108 File Offset: 0x00000308
		public SkirmishScoreItem(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000022 RID: 34 RVA: 0x000694E0 File Offset: 0x000676E0
		// (set) Token: 0x06000023 RID: 35 RVA: 0x00002111 File Offset: 0x00000311
		public unsafe int Value
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkirmishScoreItem.NativeFieldInfoPtr_Value);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkirmishScoreItem.NativeFieldInfoPtr_Value)) = value;
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000024 RID: 36 RVA: 0x00069508 File Offset: 0x00067708
		// (set) Token: 0x06000025 RID: 37 RVA: 0x0000212C File Offset: 0x0000032C
		public unsafe LocalizableTextVariables Prompt
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkirmishScoreItem.NativeFieldInfoPtr_Prompt);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LocalizableTextVariables>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkirmishScoreItem.NativeFieldInfoPtr_Prompt), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000014 RID: 20
		private static readonly IntPtr NativeFieldInfoPtr_Value;

		// Token: 0x04000015 RID: 21
		private static readonly IntPtr NativeFieldInfoPtr_Prompt;

		// Token: 0x04000016 RID: 22
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_String_0;

		// Token: 0x04000017 RID: 23
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
	}
}
