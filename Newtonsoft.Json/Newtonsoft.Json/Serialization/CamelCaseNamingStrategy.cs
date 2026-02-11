using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x02000071 RID: 113
	public class CamelCaseNamingStrategy : NamingStrategy
	{
		// Token: 0x0600099C RID: 2460 RVA: 0x0003EE88 File Offset: 0x0003D088
		// Note: this type is marked as 'beforefieldinit'.
		static CamelCaseNamingStrategy()
		{
			Il2CppClassPointerStore<CamelCaseNamingStrategy>.NativeClassPtr = IL2CPP.GetIl2CppClass("Newtonsoft.Json.dll", "Newtonsoft.Json.Serialization", "CamelCaseNamingStrategy");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CamelCaseNamingStrategy>.NativeClassPtr);
			CamelCaseNamingStrategy.NativeMethodInfoPtr__ctor_Public_Void_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CamelCaseNamingStrategy>.NativeClassPtr, 100665141);
			CamelCaseNamingStrategy.NativeMethodInfoPtr__ctor_Public_Void_Boolean_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CamelCaseNamingStrategy>.NativeClassPtr, 100665142);
			CamelCaseNamingStrategy.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CamelCaseNamingStrategy>.NativeClassPtr, 100665143);
			CamelCaseNamingStrategy.NativeMethodInfoPtr_ResolvePropertyName_Protected_Virtual_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CamelCaseNamingStrategy>.NativeClassPtr, 100665144);
		}

		// Token: 0x0600099D RID: 2461 RVA: 0x0003EF08 File Offset: 0x0003D108
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 746756, XrefRangeEnd = 746757, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CamelCaseNamingStrategy(bool processDictionaryKeys, bool overrideSpecifiedNames)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CamelCaseNamingStrategy>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref processDictionaryKeys;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref overrideSpecifiedNames;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CamelCaseNamingStrategy.NativeMethodInfoPtr__ctor_Public_Void_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600099E RID: 2462 RVA: 0x0003EF60 File Offset: 0x0003D160
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 746757, XrefRangeEnd = 746758, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CamelCaseNamingStrategy(bool processDictionaryKeys, bool overrideSpecifiedNames, bool processExtensionDataNames)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CamelCaseNamingStrategy>.NativeClassPtr))
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CamelCaseNamingStrategy.NativeMethodInfoPtr__ctor_Public_Void_Boolean_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600099F RID: 2463 RVA: 0x0003EFC4 File Offset: 0x0003D1C4
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CamelCaseNamingStrategy()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CamelCaseNamingStrategy>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CamelCaseNamingStrategy.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009A0 RID: 2464 RVA: 0x0003F000 File Offset: 0x0003D200
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 746758, XrefRangeEnd = 746759, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ResolvePropertyName(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CamelCaseNamingStrategy.NativeMethodInfoPtr_ResolvePropertyName_Protected_Virtual_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060009A1 RID: 2465 RVA: 0x00004F13 File Offset: 0x00003113
		public CamelCaseNamingStrategy(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400080B RID: 2059
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_Boolean_0;

		// Token: 0x0400080C RID: 2060
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_Boolean_Boolean_0;

		// Token: 0x0400080D RID: 2061
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400080E RID: 2062
		private static readonly IntPtr NativeMethodInfoPtr_ResolvePropertyName_Protected_Virtual_String_String_0;
	}
}
