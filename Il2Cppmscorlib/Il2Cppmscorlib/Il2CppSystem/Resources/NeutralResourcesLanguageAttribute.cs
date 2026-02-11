using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Resources
{
	// Token: 0x020003E5 RID: 997
	public sealed class NeutralResourcesLanguageAttribute : Attribute
	{
		// Token: 0x06003A6A RID: 14954 RVA: 0x001199CC File Offset: 0x00117BCC
		// Note: this type is marked as 'beforefieldinit'.
		static NeutralResourcesLanguageAttribute()
		{
			Il2CppClassPointerStore<NeutralResourcesLanguageAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Resources", "NeutralResourcesLanguageAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NeutralResourcesLanguageAttribute>.NativeClassPtr);
			NeutralResourcesLanguageAttribute.NativeFieldInfoPtr__CultureName_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NeutralResourcesLanguageAttribute>.NativeClassPtr, "<CultureName>k__BackingField");
			NeutralResourcesLanguageAttribute.NativeFieldInfoPtr__Location_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NeutralResourcesLanguageAttribute>.NativeClassPtr, "<Location>k__BackingField");
			NeutralResourcesLanguageAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NeutralResourcesLanguageAttribute>.NativeClassPtr, 100672021);
			NeutralResourcesLanguageAttribute.NativeMethodInfoPtr_get_CultureName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NeutralResourcesLanguageAttribute>.NativeClassPtr, 100672022);
			NeutralResourcesLanguageAttribute.NativeMethodInfoPtr_get_Location_Public_get_UltimateResourceFallbackLocation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NeutralResourcesLanguageAttribute>.NativeClassPtr, 100672023);
		}

		// Token: 0x06003A6B RID: 14955 RVA: 0x00119A60 File Offset: 0x00117C60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1396471, XrefRangeEnd = 1396473, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NeutralResourcesLanguageAttribute(string cultureName)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NeutralResourcesLanguageAttribute>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(cultureName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NeutralResourcesLanguageAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000D99 RID: 3481
		// (get) Token: 0x06003A6C RID: 14956 RVA: 0x00119AAC File Offset: 0x00117CAC
		public unsafe string CultureName
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NeutralResourcesLanguageAttribute.NativeMethodInfoPtr_get_CultureName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000D9A RID: 3482
		// (get) Token: 0x06003A6D RID: 14957 RVA: 0x00119AE4 File Offset: 0x00117CE4
		public unsafe UltimateResourceFallbackLocation Location
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NeutralResourcesLanguageAttribute.NativeMethodInfoPtr_get_Location_Public_get_UltimateResourceFallbackLocation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003A6E RID: 14958 RVA: 0x00015AFD File Offset: 0x00013CFD
		public NeutralResourcesLanguageAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000D97 RID: 3479
		// (get) Token: 0x06003A6F RID: 14959 RVA: 0x00119B20 File Offset: 0x00117D20
		// (set) Token: 0x06003A70 RID: 14960 RVA: 0x00015B06 File Offset: 0x00013D06
		public unsafe string _CultureName_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NeutralResourcesLanguageAttribute.NativeFieldInfoPtr__CultureName_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NeutralResourcesLanguageAttribute.NativeFieldInfoPtr__CultureName_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000D98 RID: 3480
		// (get) Token: 0x06003A71 RID: 14961 RVA: 0x00119B48 File Offset: 0x00117D48
		// (set) Token: 0x06003A72 RID: 14962 RVA: 0x00015B25 File Offset: 0x00013D25
		public unsafe UltimateResourceFallbackLocation _Location_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NeutralResourcesLanguageAttribute.NativeFieldInfoPtr__Location_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NeutralResourcesLanguageAttribute.NativeFieldInfoPtr__Location_k__BackingField)) = value;
			}
		}

		// Token: 0x04002F48 RID: 12104
		private static readonly IntPtr NativeFieldInfoPtr__CultureName_k__BackingField;

		// Token: 0x04002F49 RID: 12105
		private static readonly IntPtr NativeFieldInfoPtr__Location_k__BackingField;

		// Token: 0x04002F4A RID: 12106
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x04002F4B RID: 12107
		private static readonly IntPtr NativeMethodInfoPtr_get_CultureName_Public_get_String_0;

		// Token: 0x04002F4C RID: 12108
		private static readonly IntPtr NativeMethodInfoPtr_get_Location_Public_get_UltimateResourceFallbackLocation_0;
	}
}
