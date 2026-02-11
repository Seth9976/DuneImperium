using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace dwd.core.settings.config.definitions
{
	// Token: 0x020000F3 RID: 243
	public class StringConfigDefinition : ConfigDefinition<string>
	{
		// Token: 0x06000E6A RID: 3690 RVA: 0x0004CC24 File Offset: 0x0004AE24
		// Note: this type is marked as 'beforefieldinit'.
		static StringConfigDefinition()
		{
			Il2CppClassPointerStore<StringConfigDefinition>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.settings.config.definitions", "StringConfigDefinition");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StringConfigDefinition>.NativeClassPtr);
			StringConfigDefinition.NativeMethodInfoPtr__ctor_Public_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringConfigDefinition>.NativeClassPtr, 100665381);
			StringConfigDefinition.NativeMethodInfoPtr__ctor_Public_Void_String_Func_2_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringConfigDefinition>.NativeClassPtr, 100665382);
			StringConfigDefinition.NativeMethodInfoPtr_createSetting_Protected_Virtual_ConfigSetting_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringConfigDefinition>.NativeClassPtr, 100665383);
			StringConfigDefinition.NativeMethodInfoPtr_convert_Protected_Virtual_Boolean_String_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringConfigDefinition>.NativeClassPtr, 100665384);
		}

		// Token: 0x06000E6B RID: 3691 RVA: 0x0004CCA4 File Offset: 0x0004AEA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 867290, XrefRangeEnd = 867293, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StringConfigDefinition(string key, string defaultValue)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StringConfigDefinition>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(defaultValue);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringConfigDefinition.NativeMethodInfoPtr__ctor_Public_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E6C RID: 3692 RVA: 0x0004CD04 File Offset: 0x0004AF04
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 867296, RefRangeEnd = 867297, XrefRangeStart = 867293, XrefRangeEnd = 867296, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StringConfigDefinition(string key, Func<string, string> getDefaultValue)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StringConfigDefinition>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(getDefaultValue);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringConfigDefinition.NativeMethodInfoPtr__ctor_Public_Void_String_Func_2_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E6D RID: 3693 RVA: 0x0004CD64 File Offset: 0x0004AF64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 867297, XrefRangeEnd = 867313, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override ConfigSetting<string> createSetting()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StringConfigDefinition.NativeMethodInfoPtr_createSetting_Protected_Virtual_ConfigSetting_1_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ConfigSetting<string>>(intPtr3) : null;
		}

		// Token: 0x06000E6E RID: 3694 RVA: 0x0004CDB0 File Offset: 0x0004AFB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool convert(string stored, out string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(stored);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StringConfigDefinition.NativeMethodInfoPtr_convert_Protected_Virtual_Boolean_String_byref_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			value = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06000E6F RID: 3695 RVA: 0x00006E58 File Offset: 0x00005058
		public StringConfigDefinition(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000A5D RID: 2653
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_0;

		// Token: 0x04000A5E RID: 2654
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Func_2_String_String_0;

		// Token: 0x04000A5F RID: 2655
		private static readonly IntPtr NativeMethodInfoPtr_createSetting_Protected_Virtual_ConfigSetting_1_String_0;

		// Token: 0x04000A60 RID: 2656
		private static readonly IntPtr NativeMethodInfoPtr_convert_Protected_Virtual_Boolean_String_byref_String_0;
	}
}
