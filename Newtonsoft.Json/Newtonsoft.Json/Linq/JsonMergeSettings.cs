using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Newtonsoft.Json.Linq
{
	// Token: 0x020000C1 RID: 193
	public class JsonMergeSettings : Object
	{
		// Token: 0x06001178 RID: 4472 RVA: 0x00061C8C File Offset: 0x0005FE8C
		// Note: this type is marked as 'beforefieldinit'.
		static JsonMergeSettings()
		{
			Il2CppClassPointerStore<JsonMergeSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("Newtonsoft.Json.dll", "Newtonsoft.Json.Linq", "JsonMergeSettings");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JsonMergeSettings>.NativeClassPtr);
			JsonMergeSettings.NativeFieldInfoPtr__mergeArrayHandling = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonMergeSettings>.NativeClassPtr, "_mergeArrayHandling");
			JsonMergeSettings.NativeFieldInfoPtr__mergeNullValueHandling = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonMergeSettings>.NativeClassPtr, "_mergeNullValueHandling");
			JsonMergeSettings.NativeFieldInfoPtr__propertyNameComparison = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonMergeSettings>.NativeClassPtr, "_propertyNameComparison");
			JsonMergeSettings.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonMergeSettings>.NativeClassPtr, 100666525);
			JsonMergeSettings.NativeMethodInfoPtr_get_MergeArrayHandling_Public_get_MergeArrayHandling_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonMergeSettings>.NativeClassPtr, 100666526);
			JsonMergeSettings.NativeMethodInfoPtr_set_MergeArrayHandling_Public_set_Void_MergeArrayHandling_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonMergeSettings>.NativeClassPtr, 100666527);
			JsonMergeSettings.NativeMethodInfoPtr_get_MergeNullValueHandling_Public_get_MergeNullValueHandling_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonMergeSettings>.NativeClassPtr, 100666528);
			JsonMergeSettings.NativeMethodInfoPtr_set_MergeNullValueHandling_Public_set_Void_MergeNullValueHandling_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonMergeSettings>.NativeClassPtr, 100666529);
			JsonMergeSettings.NativeMethodInfoPtr_get_PropertyNameComparison_Public_get_StringComparison_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonMergeSettings>.NativeClassPtr, 100666530);
			JsonMergeSettings.NativeMethodInfoPtr_set_PropertyNameComparison_Public_set_Void_StringComparison_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonMergeSettings>.NativeClassPtr, 100666531);
		}

		// Token: 0x06001179 RID: 4473 RVA: 0x00061D84 File Offset: 0x0005FF84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 759262, XrefRangeEnd = 759263, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe JsonMergeSettings()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JsonMergeSettings>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonMergeSettings.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170004AE RID: 1198
		// (get) Token: 0x0600117A RID: 4474 RVA: 0x00061DC0 File Offset: 0x0005FFC0
		// (set) Token: 0x0600117B RID: 4475 RVA: 0x00061DFC File Offset: 0x0005FFFC
		public unsafe MergeArrayHandling MergeArrayHandling
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 302497, RefRangeEnd = 302502, XrefRangeStart = 302497, XrefRangeEnd = 302502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonMergeSettings.NativeMethodInfoPtr_get_MergeArrayHandling_Public_get_MergeArrayHandling_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonMergeSettings.NativeMethodInfoPtr_set_MergeArrayHandling_Public_set_Void_MergeArrayHandling_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170004AF RID: 1199
		// (get) Token: 0x0600117C RID: 4476 RVA: 0x00061E3C File Offset: 0x0006003C
		// (set) Token: 0x0600117D RID: 4477 RVA: 0x00061E78 File Offset: 0x00060078
		public unsafe MergeNullValueHandling MergeNullValueHandling
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonMergeSettings.NativeMethodInfoPtr_get_MergeNullValueHandling_Public_get_MergeNullValueHandling_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonMergeSettings.NativeMethodInfoPtr_set_MergeNullValueHandling_Public_set_Void_MergeNullValueHandling_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170004B0 RID: 1200
		// (get) Token: 0x0600117E RID: 4478 RVA: 0x00061EB8 File Offset: 0x000600B8
		// (set) Token: 0x0600117F RID: 4479 RVA: 0x00061EF4 File Offset: 0x000600F4
		public unsafe StringComparison PropertyNameComparison
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonMergeSettings.NativeMethodInfoPtr_get_PropertyNameComparison_Public_get_StringComparison_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonMergeSettings.NativeMethodInfoPtr_set_PropertyNameComparison_Public_set_Void_StringComparison_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06001180 RID: 4480 RVA: 0x0000798A File Offset: 0x00005B8A
		public JsonMergeSettings(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004AB RID: 1195
		// (get) Token: 0x06001181 RID: 4481 RVA: 0x00061F34 File Offset: 0x00060134
		// (set) Token: 0x06001182 RID: 4482 RVA: 0x00007993 File Offset: 0x00005B93
		public unsafe MergeArrayHandling _mergeArrayHandling
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonMergeSettings.NativeFieldInfoPtr__mergeArrayHandling);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonMergeSettings.NativeFieldInfoPtr__mergeArrayHandling)) = value;
			}
		}

		// Token: 0x170004AC RID: 1196
		// (get) Token: 0x06001183 RID: 4483 RVA: 0x00061F5C File Offset: 0x0006015C
		// (set) Token: 0x06001184 RID: 4484 RVA: 0x000079AE File Offset: 0x00005BAE
		public unsafe MergeNullValueHandling _mergeNullValueHandling
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonMergeSettings.NativeFieldInfoPtr__mergeNullValueHandling);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonMergeSettings.NativeFieldInfoPtr__mergeNullValueHandling)) = value;
			}
		}

		// Token: 0x170004AD RID: 1197
		// (get) Token: 0x06001185 RID: 4485 RVA: 0x00061F84 File Offset: 0x00060184
		// (set) Token: 0x06001186 RID: 4486 RVA: 0x000079C9 File Offset: 0x00005BC9
		public unsafe StringComparison _propertyNameComparison
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonMergeSettings.NativeFieldInfoPtr__propertyNameComparison);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonMergeSettings.NativeFieldInfoPtr__propertyNameComparison)) = value;
			}
		}

		// Token: 0x04000E11 RID: 3601
		private static readonly IntPtr NativeFieldInfoPtr__mergeArrayHandling;

		// Token: 0x04000E12 RID: 3602
		private static readonly IntPtr NativeFieldInfoPtr__mergeNullValueHandling;

		// Token: 0x04000E13 RID: 3603
		private static readonly IntPtr NativeFieldInfoPtr__propertyNameComparison;

		// Token: 0x04000E14 RID: 3604
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000E15 RID: 3605
		private static readonly IntPtr NativeMethodInfoPtr_get_MergeArrayHandling_Public_get_MergeArrayHandling_0;

		// Token: 0x04000E16 RID: 3606
		private static readonly IntPtr NativeMethodInfoPtr_set_MergeArrayHandling_Public_set_Void_MergeArrayHandling_0;

		// Token: 0x04000E17 RID: 3607
		private static readonly IntPtr NativeMethodInfoPtr_get_MergeNullValueHandling_Public_get_MergeNullValueHandling_0;

		// Token: 0x04000E18 RID: 3608
		private static readonly IntPtr NativeMethodInfoPtr_set_MergeNullValueHandling_Public_set_Void_MergeNullValueHandling_0;

		// Token: 0x04000E19 RID: 3609
		private static readonly IntPtr NativeMethodInfoPtr_get_PropertyNameComparison_Public_get_StringComparison_0;

		// Token: 0x04000E1A RID: 3610
		private static readonly IntPtr NativeMethodInfoPtr_set_PropertyNameComparison_Public_set_Void_StringComparison_0;
	}
}
