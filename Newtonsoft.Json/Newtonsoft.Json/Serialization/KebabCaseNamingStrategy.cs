using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x02000097 RID: 151
	public class KebabCaseNamingStrategy : NamingStrategy
	{
		// Token: 0x06000D37 RID: 3383 RVA: 0x0004F074 File Offset: 0x0004D274
		// Note: this type is marked as 'beforefieldinit'.
		static KebabCaseNamingStrategy()
		{
			Il2CppClassPointerStore<KebabCaseNamingStrategy>.NativeClassPtr = IL2CPP.GetIl2CppClass("Newtonsoft.Json.dll", "Newtonsoft.Json.Serialization", "KebabCaseNamingStrategy");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<KebabCaseNamingStrategy>.NativeClassPtr);
			KebabCaseNamingStrategy.NativeMethodInfoPtr__ctor_Public_Void_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KebabCaseNamingStrategy>.NativeClassPtr, 100665713);
			KebabCaseNamingStrategy.NativeMethodInfoPtr__ctor_Public_Void_Boolean_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KebabCaseNamingStrategy>.NativeClassPtr, 100665714);
			KebabCaseNamingStrategy.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KebabCaseNamingStrategy>.NativeClassPtr, 100665715);
			KebabCaseNamingStrategy.NativeMethodInfoPtr_ResolvePropertyName_Protected_Virtual_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KebabCaseNamingStrategy>.NativeClassPtr, 100665716);
		}

		// Token: 0x06000D38 RID: 3384 RVA: 0x0004F0F4 File Offset: 0x0004D2F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 753625, XrefRangeEnd = 753626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe KebabCaseNamingStrategy(bool processDictionaryKeys, bool overrideSpecifiedNames)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<KebabCaseNamingStrategy>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref processDictionaryKeys;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref overrideSpecifiedNames;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KebabCaseNamingStrategy.NativeMethodInfoPtr__ctor_Public_Void_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D39 RID: 3385 RVA: 0x0004F14C File Offset: 0x0004D34C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 753626, XrefRangeEnd = 753627, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe KebabCaseNamingStrategy(bool processDictionaryKeys, bool overrideSpecifiedNames, bool processExtensionDataNames)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<KebabCaseNamingStrategy>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref processDictionaryKeys;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref overrideSpecifiedNames;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref processExtensionDataNames;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KebabCaseNamingStrategy.NativeMethodInfoPtr__ctor_Public_Void_Boolean_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D3A RID: 3386 RVA: 0x0004F1B0 File Offset: 0x0004D3B0
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe KebabCaseNamingStrategy()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<KebabCaseNamingStrategy>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KebabCaseNamingStrategy.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D3B RID: 3387 RVA: 0x0004F1EC File Offset: 0x0004D3EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 753627, XrefRangeEnd = 753628, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ResolvePropertyName(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), KebabCaseNamingStrategy.NativeMethodInfoPtr_ResolvePropertyName_Protected_Virtual_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000D3C RID: 3388 RVA: 0x000064BD File Offset: 0x000046BD
		public KebabCaseNamingStrategy(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000AB8 RID: 2744
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_Boolean_0;

		// Token: 0x04000AB9 RID: 2745
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_Boolean_Boolean_0;

		// Token: 0x04000ABA RID: 2746
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000ABB RID: 2747
		private static readonly IntPtr NativeMethodInfoPtr_ResolvePropertyName_Protected_Virtual_String_String_0;
	}
}
