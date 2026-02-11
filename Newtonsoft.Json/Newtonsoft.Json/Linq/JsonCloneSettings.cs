using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Newtonsoft.Json.Linq
{
	// Token: 0x020000BF RID: 191
	public class JsonCloneSettings : Object
	{
		// Token: 0x06001160 RID: 4448 RVA: 0x000617D0 File Offset: 0x0005F9D0
		// Note: this type is marked as 'beforefieldinit'.
		static JsonCloneSettings()
		{
			Il2CppClassPointerStore<JsonCloneSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("Newtonsoft.Json.dll", "Newtonsoft.Json.Linq", "JsonCloneSettings");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JsonCloneSettings>.NativeClassPtr);
			JsonCloneSettings.NativeFieldInfoPtr_SkipCopyAnnotations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonCloneSettings>.NativeClassPtr, "SkipCopyAnnotations");
			JsonCloneSettings.NativeFieldInfoPtr__CopyAnnotations_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonCloneSettings>.NativeClassPtr, "<CopyAnnotations>k__BackingField");
			JsonCloneSettings.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonCloneSettings>.NativeClassPtr, 100666514);
			JsonCloneSettings.NativeMethodInfoPtr_get_CopyAnnotations_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonCloneSettings>.NativeClassPtr, 100666515);
			JsonCloneSettings.NativeMethodInfoPtr_set_CopyAnnotations_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonCloneSettings>.NativeClassPtr, 100666516);
		}

		// Token: 0x06001161 RID: 4449 RVA: 0x00061864 File Offset: 0x0005FA64
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 344029, RefRangeEnd = 344037, XrefRangeStart = 344029, XrefRangeEnd = 344037, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe JsonCloneSettings()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JsonCloneSettings>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonCloneSettings.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170004A4 RID: 1188
		// (get) Token: 0x06001162 RID: 4450 RVA: 0x000618A0 File Offset: 0x0005FAA0
		// (set) Token: 0x06001163 RID: 4451 RVA: 0x000618DC File Offset: 0x0005FADC
		public unsafe bool CopyAnnotations
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonCloneSettings.NativeMethodInfoPtr_get_CopyAnnotations_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 288083, RefRangeEnd = 288084, XrefRangeStart = 288083, XrefRangeEnd = 288084, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonCloneSettings.NativeMethodInfoPtr_set_CopyAnnotations_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06001164 RID: 4452 RVA: 0x000078FA File Offset: 0x00005AFA
		public JsonCloneSettings(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004A2 RID: 1186
		// (get) Token: 0x06001165 RID: 4453 RVA: 0x0006191C File Offset: 0x0005FB1C
		// (set) Token: 0x06001166 RID: 4454 RVA: 0x00007903 File Offset: 0x00005B03
		public unsafe static JsonCloneSettings SkipCopyAnnotations
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(JsonCloneSettings.NativeFieldInfoPtr_SkipCopyAnnotations, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<JsonCloneSettings>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(JsonCloneSettings.NativeFieldInfoPtr_SkipCopyAnnotations, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004A3 RID: 1187
		// (get) Token: 0x06001167 RID: 4455 RVA: 0x00061944 File Offset: 0x0005FB44
		// (set) Token: 0x06001168 RID: 4456 RVA: 0x00007915 File Offset: 0x00005B15
		public unsafe bool _CopyAnnotations_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonCloneSettings.NativeFieldInfoPtr__CopyAnnotations_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonCloneSettings.NativeFieldInfoPtr__CopyAnnotations_k__BackingField)) = value;
			}
		}

		// Token: 0x04000E02 RID: 3586
		private static readonly IntPtr NativeFieldInfoPtr_SkipCopyAnnotations;

		// Token: 0x04000E03 RID: 3587
		private static readonly IntPtr NativeFieldInfoPtr__CopyAnnotations_k__BackingField;

		// Token: 0x04000E04 RID: 3588
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000E05 RID: 3589
		private static readonly IntPtr NativeMethodInfoPtr_get_CopyAnnotations_Public_get_Boolean_0;

		// Token: 0x04000E06 RID: 3590
		private static readonly IntPtr NativeMethodInfoPtr_set_CopyAnnotations_Public_set_Void_Boolean_0;
	}
}
