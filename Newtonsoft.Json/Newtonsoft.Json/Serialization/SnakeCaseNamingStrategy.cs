using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x0200009F RID: 159
	public class SnakeCaseNamingStrategy : NamingStrategy
	{
		// Token: 0x06000D82 RID: 3458 RVA: 0x000502D8 File Offset: 0x0004E4D8
		// Note: this type is marked as 'beforefieldinit'.
		static SnakeCaseNamingStrategy()
		{
			Il2CppClassPointerStore<SnakeCaseNamingStrategy>.NativeClassPtr = IL2CPP.GetIl2CppClass("Newtonsoft.Json.dll", "Newtonsoft.Json.Serialization", "SnakeCaseNamingStrategy");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SnakeCaseNamingStrategy>.NativeClassPtr);
			SnakeCaseNamingStrategy.NativeMethodInfoPtr__ctor_Public_Void_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SnakeCaseNamingStrategy>.NativeClassPtr, 100665751);
			SnakeCaseNamingStrategy.NativeMethodInfoPtr__ctor_Public_Void_Boolean_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SnakeCaseNamingStrategy>.NativeClassPtr, 100665752);
			SnakeCaseNamingStrategy.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SnakeCaseNamingStrategy>.NativeClassPtr, 100665753);
			SnakeCaseNamingStrategy.NativeMethodInfoPtr_ResolvePropertyName_Protected_Virtual_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SnakeCaseNamingStrategy>.NativeClassPtr, 100665754);
		}

		// Token: 0x06000D83 RID: 3459 RVA: 0x00050358 File Offset: 0x0004E558
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SnakeCaseNamingStrategy(bool processDictionaryKeys, bool overrideSpecifiedNames)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SnakeCaseNamingStrategy>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref processDictionaryKeys;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref overrideSpecifiedNames;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SnakeCaseNamingStrategy.NativeMethodInfoPtr__ctor_Public_Void_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D84 RID: 3460 RVA: 0x000503B0 File Offset: 0x0004E5B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SnakeCaseNamingStrategy(bool processDictionaryKeys, bool overrideSpecifiedNames, bool processExtensionDataNames)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SnakeCaseNamingStrategy>.NativeClassPtr))
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SnakeCaseNamingStrategy.NativeMethodInfoPtr__ctor_Public_Void_Boolean_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D85 RID: 3461 RVA: 0x00050414 File Offset: 0x0004E614
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SnakeCaseNamingStrategy()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SnakeCaseNamingStrategy>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SnakeCaseNamingStrategy.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D86 RID: 3462 RVA: 0x00050450 File Offset: 0x0004E650
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 753766, XrefRangeEnd = 753767, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ResolvePropertyName(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SnakeCaseNamingStrategy.NativeMethodInfoPtr_ResolvePropertyName_Protected_Virtual_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000D87 RID: 3463 RVA: 0x0000666C File Offset: 0x0000486C
		public SnakeCaseNamingStrategy(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000AE7 RID: 2791
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_Boolean_0;

		// Token: 0x04000AE8 RID: 2792
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_Boolean_Boolean_0;

		// Token: 0x04000AE9 RID: 2793
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000AEA RID: 2794
		private static readonly IntPtr NativeMethodInfoPtr_ResolvePropertyName_Protected_Virtual_String_String_0;
	}
}
