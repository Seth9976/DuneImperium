using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace dwd.core.settings.config.definitions
{
	// Token: 0x020000EF RID: 239
	public class BoolConfigDefinition : ConfigDefinition<bool>
	{
		// Token: 0x06000E3A RID: 3642 RVA: 0x0004BD00 File Offset: 0x00049F00
		// Note: this type is marked as 'beforefieldinit'.
		static BoolConfigDefinition()
		{
			Il2CppClassPointerStore<BoolConfigDefinition>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.settings.config.definitions", "BoolConfigDefinition");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BoolConfigDefinition>.NativeClassPtr);
			BoolConfigDefinition.NativeMethodInfoPtr__ctor_Public_Void_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoolConfigDefinition>.NativeClassPtr, 100665351);
			BoolConfigDefinition.NativeMethodInfoPtr__ctor_Public_Void_String_Func_2_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoolConfigDefinition>.NativeClassPtr, 100665352);
			BoolConfigDefinition.NativeMethodInfoPtr_createSetting_Protected_Virtual_ConfigSetting_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoolConfigDefinition>.NativeClassPtr, 100665353);
			BoolConfigDefinition.NativeMethodInfoPtr_convert_Protected_Virtual_Boolean_String_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoolConfigDefinition>.NativeClassPtr, 100665354);
		}

		// Token: 0x06000E3B RID: 3643 RVA: 0x0004BD80 File Offset: 0x00049F80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 867047, XrefRangeEnd = 867050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BoolConfigDefinition(string key, bool defaultValue)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BoolConfigDefinition>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref defaultValue;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoolConfigDefinition.NativeMethodInfoPtr__ctor_Public_Void_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E3C RID: 3644 RVA: 0x0004BDDC File Offset: 0x00049FDC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 867053, RefRangeEnd = 867054, XrefRangeStart = 867050, XrefRangeEnd = 867053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BoolConfigDefinition(string key, Func<string, bool> getDefaultValue)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BoolConfigDefinition>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(getDefaultValue);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoolConfigDefinition.NativeMethodInfoPtr__ctor_Public_Void_String_Func_2_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E3D RID: 3645 RVA: 0x0004BE3C File Offset: 0x0004A03C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 867054, XrefRangeEnd = 867070, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override ConfigSetting<bool> createSetting()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BoolConfigDefinition.NativeMethodInfoPtr_createSetting_Protected_Virtual_ConfigSetting_1_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ConfigSetting<bool>>(intPtr3) : null;
		}

		// Token: 0x06000E3E RID: 3646 RVA: 0x0004BE88 File Offset: 0x0004A088
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 867070, XrefRangeEnd = 867074, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool convert(string stored, out bool value)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BoolConfigDefinition.NativeMethodInfoPtr_convert_Protected_Virtual_Boolean_String_byref_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000E3F RID: 3647 RVA: 0x00006DC5 File Offset: 0x00004FC5
		public BoolConfigDefinition(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000A3A RID: 2618
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Boolean_0;

		// Token: 0x04000A3B RID: 2619
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Func_2_String_Boolean_0;

		// Token: 0x04000A3C RID: 2620
		private static readonly IntPtr NativeMethodInfoPtr_createSetting_Protected_Virtual_ConfigSetting_1_Boolean_0;

		// Token: 0x04000A3D RID: 2621
		private static readonly IntPtr NativeMethodInfoPtr_convert_Protected_Virtual_Boolean_String_byref_Boolean_0;
	}
}
