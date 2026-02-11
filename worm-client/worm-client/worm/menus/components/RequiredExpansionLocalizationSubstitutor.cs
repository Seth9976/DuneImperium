using System;
using boardgames.data;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace worm.menus.components
{
	// Token: 0x0200009E RID: 158
	public class RequiredExpansionLocalizationSubstitutor : Subscriber<PendingGameData>
	{
		// Token: 0x06000638 RID: 1592 RVA: 0x0002BA10 File Offset: 0x00029C10
		// Note: this type is marked as 'beforefieldinit'.
		static RequiredExpansionLocalizationSubstitutor()
		{
			Il2CppClassPointerStore<RequiredExpansionLocalizationSubstitutor>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.menus.components", "RequiredExpansionLocalizationSubstitutor");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RequiredExpansionLocalizationSubstitutor>.NativeClassPtr);
			RequiredExpansionLocalizationSubstitutor.NativeFieldInfoPtr_ixSuffix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RequiredExpansionLocalizationSubstitutor>.NativeClassPtr, "ixSuffix");
			RequiredExpansionLocalizationSubstitutor.NativeFieldInfoPtr_immortalitySuffix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RequiredExpansionLocalizationSubstitutor>.NativeClassPtr, "immortalitySuffix");
			RequiredExpansionLocalizationSubstitutor.NativeFieldInfoPtr_locKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RequiredExpansionLocalizationSubstitutor>.NativeClassPtr, "locKey");
			RequiredExpansionLocalizationSubstitutor.NativeMethodInfoPtr_Substitute_Public_Virtual_Final_New_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequiredExpansionLocalizationSubstitutor>.NativeClassPtr, 100664176);
			RequiredExpansionLocalizationSubstitutor.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequiredExpansionLocalizationSubstitutor>.NativeClassPtr, 100664177);
		}

		// Token: 0x06000639 RID: 1593 RVA: 0x0002BAA4 File Offset: 0x00029CA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 696138, XrefRangeEnd = 696153, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string Substitute(string key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RequiredExpansionLocalizationSubstitutor.NativeMethodInfoPtr_Substitute_Public_Virtual_Final_New_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600063A RID: 1594 RVA: 0x0002BAEC File Offset: 0x00029CEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 696153, XrefRangeEnd = 696163, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RequiredExpansionLocalizationSubstitutor()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RequiredExpansionLocalizationSubstitutor>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RequiredExpansionLocalizationSubstitutor.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600063B RID: 1595 RVA: 0x000051E1 File Offset: 0x000033E1
		public RequiredExpansionLocalizationSubstitutor(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000193 RID: 403
		// (get) Token: 0x0600063C RID: 1596 RVA: 0x0002BB28 File Offset: 0x00029D28
		// (set) Token: 0x0600063D RID: 1597 RVA: 0x000051EA File Offset: 0x000033EA
		public unsafe string ixSuffix
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RequiredExpansionLocalizationSubstitutor.NativeFieldInfoPtr_ixSuffix);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RequiredExpansionLocalizationSubstitutor.NativeFieldInfoPtr_ixSuffix), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000194 RID: 404
		// (get) Token: 0x0600063E RID: 1598 RVA: 0x0002BB50 File Offset: 0x00029D50
		// (set) Token: 0x0600063F RID: 1599 RVA: 0x00005209 File Offset: 0x00003409
		public unsafe string immortalitySuffix
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RequiredExpansionLocalizationSubstitutor.NativeFieldInfoPtr_immortalitySuffix);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RequiredExpansionLocalizationSubstitutor.NativeFieldInfoPtr_immortalitySuffix), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000195 RID: 405
		// (get) Token: 0x06000640 RID: 1600 RVA: 0x0002BB78 File Offset: 0x00029D78
		// (set) Token: 0x06000641 RID: 1601 RVA: 0x00005228 File Offset: 0x00003428
		public unsafe string locKey
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RequiredExpansionLocalizationSubstitutor.NativeFieldInfoPtr_locKey);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RequiredExpansionLocalizationSubstitutor.NativeFieldInfoPtr_locKey), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000395 RID: 917
		private static readonly IntPtr NativeFieldInfoPtr_ixSuffix;

		// Token: 0x04000396 RID: 918
		private static readonly IntPtr NativeFieldInfoPtr_immortalitySuffix;

		// Token: 0x04000397 RID: 919
		private static readonly IntPtr NativeFieldInfoPtr_locKey;

		// Token: 0x04000398 RID: 920
		private static readonly IntPtr NativeMethodInfoPtr_Substitute_Public_Virtual_Final_New_String_String_0;

		// Token: 0x04000399 RID: 921
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
