using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace dwd.core.settings.config.definitions
{
	// Token: 0x020000F2 RID: 242
	public class IntConfigDefinition : ConfigDefinition<int>
	{
		// Token: 0x06000E64 RID: 3684 RVA: 0x0004CA34 File Offset: 0x0004AC34
		// Note: this type is marked as 'beforefieldinit'.
		static IntConfigDefinition()
		{
			Il2CppClassPointerStore<IntConfigDefinition>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.settings.config.definitions", "IntConfigDefinition");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IntConfigDefinition>.NativeClassPtr);
			IntConfigDefinition.NativeMethodInfoPtr__ctor_Public_Void_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntConfigDefinition>.NativeClassPtr, 100665377);
			IntConfigDefinition.NativeMethodInfoPtr__ctor_Public_Void_String_Func_2_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntConfigDefinition>.NativeClassPtr, 100665378);
			IntConfigDefinition.NativeMethodInfoPtr_createSetting_Protected_Virtual_ConfigSetting_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntConfigDefinition>.NativeClassPtr, 100665379);
			IntConfigDefinition.NativeMethodInfoPtr_convert_Protected_Virtual_Boolean_String_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntConfigDefinition>.NativeClassPtr, 100665380);
		}

		// Token: 0x06000E65 RID: 3685 RVA: 0x0004CAB4 File Offset: 0x0004ACB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 867266, XrefRangeEnd = 867269, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IntConfigDefinition(string key, int defaultValue)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IntConfigDefinition>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref defaultValue;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntConfigDefinition.NativeMethodInfoPtr__ctor_Public_Void_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E66 RID: 3686 RVA: 0x0004CB10 File Offset: 0x0004AD10
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 867272, RefRangeEnd = 867273, XrefRangeStart = 867269, XrefRangeEnd = 867272, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IntConfigDefinition(string key, Func<string, int> getDefaultValue)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IntConfigDefinition>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(getDefaultValue);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntConfigDefinition.NativeMethodInfoPtr__ctor_Public_Void_String_Func_2_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E67 RID: 3687 RVA: 0x0004CB70 File Offset: 0x0004AD70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 867273, XrefRangeEnd = 867289, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override ConfigSetting<int> createSetting()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IntConfigDefinition.NativeMethodInfoPtr_createSetting_Protected_Virtual_ConfigSetting_1_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ConfigSetting<int>>(intPtr3) : null;
		}

		// Token: 0x06000E68 RID: 3688 RVA: 0x0004CBBC File Offset: 0x0004ADBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 867289, XrefRangeEnd = 867290, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool convert(string stored, out int value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(stored);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IntConfigDefinition.NativeMethodInfoPtr_convert_Protected_Virtual_Boolean_String_byref_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000E69 RID: 3689 RVA: 0x00006E4F File Offset: 0x0000504F
		public IntConfigDefinition(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000A59 RID: 2649
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Int32_0;

		// Token: 0x04000A5A RID: 2650
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Func_2_String_Int32_0;

		// Token: 0x04000A5B RID: 2651
		private static readonly IntPtr NativeMethodInfoPtr_createSetting_Protected_Virtual_ConfigSetting_1_Int32_0;

		// Token: 0x04000A5C RID: 2652
		private static readonly IntPtr NativeMethodInfoPtr_convert_Protected_Virtual_Boolean_String_byref_Int32_0;
	}
}
