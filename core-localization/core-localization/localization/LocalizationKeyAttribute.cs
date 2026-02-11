using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace localization
{
	// Token: 0x02000008 RID: 8
	public class LocalizationKeyAttribute : PropertyAttribute
	{
		// Token: 0x06000022 RID: 34 RVA: 0x00002BDC File Offset: 0x00000DDC
		// Note: this type is marked as 'beforefieldinit'.
		static LocalizationKeyAttribute()
		{
			Il2CppClassPointerStore<LocalizationKeyAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-localization.dll", "localization", "LocalizationKeyAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LocalizationKeyAttribute>.NativeClassPtr);
			LocalizationKeyAttribute.NativeFieldInfoPtr__ShowMissingWarning_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalizationKeyAttribute>.NativeClassPtr, "<ShowMissingWarning>k__BackingField");
			LocalizationKeyAttribute.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizationKeyAttribute>.NativeClassPtr, 100663306);
			LocalizationKeyAttribute.NativeMethodInfoPtr_get_ShowMissingWarning_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizationKeyAttribute>.NativeClassPtr, 100663307);
		}

		// Token: 0x06000023 RID: 35 RVA: 0x00002C48 File Offset: 0x00000E48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LocalizationKeyAttribute(bool showMissingWarning = true)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LocalizationKeyAttribute>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref showMissingWarning;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizationKeyAttribute.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000024 RID: 36 RVA: 0x00002C90 File Offset: 0x00000E90
		public unsafe bool ShowMissingWarning
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizationKeyAttribute.NativeMethodInfoPtr_get_ShowMissingWarning_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000025 RID: 37 RVA: 0x00002171 File Offset: 0x00000371
		public LocalizationKeyAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000026 RID: 38 RVA: 0x00002CCC File Offset: 0x00000ECC
		// (set) Token: 0x06000027 RID: 39 RVA: 0x0000217A File Offset: 0x0000037A
		public unsafe bool _ShowMissingWarning_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalizationKeyAttribute.NativeFieldInfoPtr__ShowMissingWarning_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalizationKeyAttribute.NativeFieldInfoPtr__ShowMissingWarning_k__BackingField)) = value;
			}
		}

		// Token: 0x04000010 RID: 16
		private static readonly IntPtr NativeFieldInfoPtr__ShowMissingWarning_k__BackingField;

		// Token: 0x04000011 RID: 17
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_0;

		// Token: 0x04000012 RID: 18
		private static readonly IntPtr NativeMethodInfoPtr_get_ShowMissingWarning_Public_get_Boolean_0;
	}
}
