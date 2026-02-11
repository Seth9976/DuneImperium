using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace dwd.core.settings.serverSettings.definitions
{
	// Token: 0x020000C2 RID: 194
	public class BoolServerSettingDefinition : ServerSettingDefinition<bool>
	{
		// Token: 0x06000C32 RID: 3122 RVA: 0x00042248 File Offset: 0x00040448
		// Note: this type is marked as 'beforefieldinit'.
		static BoolServerSettingDefinition()
		{
			Il2CppClassPointerStore<BoolServerSettingDefinition>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.settings.serverSettings.definitions", "BoolServerSettingDefinition");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BoolServerSettingDefinition>.NativeClassPtr);
			BoolServerSettingDefinition.NativeMethodInfoPtr__ctor_Public_Void_Int32_Boolean_IUniqueKeyRegistry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoolServerSettingDefinition>.NativeClassPtr, 100665015);
			BoolServerSettingDefinition.NativeMethodInfoPtr_createSetting_Protected_Virtual_ServerSetting_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoolServerSettingDefinition>.NativeClassPtr, 100665016);
		}

		// Token: 0x06000C33 RID: 3123 RVA: 0x000422A0 File Offset: 0x000404A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 864266, XrefRangeEnd = 864269, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BoolServerSettingDefinition(int key, bool defaultValue, IUniqueKeyRegistry keyRegistry = null)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BoolServerSettingDefinition>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref key;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref defaultValue;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(keyRegistry);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoolServerSettingDefinition.NativeMethodInfoPtr__ctor_Public_Void_Int32_Boolean_IUniqueKeyRegistry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C34 RID: 3124 RVA: 0x00042308 File Offset: 0x00040508
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 864269, XrefRangeEnd = 864341, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override ServerSetting<bool> createSetting()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BoolServerSettingDefinition.NativeMethodInfoPtr_createSetting_Protected_Virtual_ServerSetting_1_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ServerSetting<bool>>(intPtr3) : null;
		}

		// Token: 0x06000C35 RID: 3125 RVA: 0x00006547 File Offset: 0x00004747
		public BoolServerSettingDefinition(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040008CB RID: 2251
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Boolean_IUniqueKeyRegistry_0;

		// Token: 0x040008CC RID: 2252
		private static readonly IntPtr NativeMethodInfoPtr_createSetting_Protected_Virtual_ServerSetting_1_Boolean_0;

		// Token: 0x0200029E RID: 670
		[ObfuscatedName("dwd.core.settings.serverSettings.definitions.BoolServerSettingDefinition+<>O")]
		public static class __O : Object
		{
			// Token: 0x06001FD8 RID: 8152 RVA: 0x00090424 File Offset: 0x0008E624
			// Note: this type is marked as 'beforefieldinit'.
			static __O()
			{
				Il2CppClassPointerStore<BoolServerSettingDefinition.__O>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BoolServerSettingDefinition>.NativeClassPtr, "<>O");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BoolServerSettingDefinition.__O>.NativeClassPtr);
				BoolServerSettingDefinition.__O.NativeFieldInfoPtr__0___ToBoolean = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoolServerSettingDefinition.__O>.NativeClassPtr, "<0>__ToBoolean");
				BoolServerSettingDefinition.__O.NativeFieldInfoPtr__1___ToInt32 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoolServerSettingDefinition.__O>.NativeClassPtr, "<1>__ToInt32");
			}

			// Token: 0x06001FD9 RID: 8153 RVA: 0x0000D90E File Offset: 0x0000BB0E
			public __O(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170008AF RID: 2223
			// (get) Token: 0x06001FDA RID: 8154 RVA: 0x00090478 File Offset: 0x0008E678
			// (set) Token: 0x06001FDB RID: 8155 RVA: 0x0000D917 File Offset: 0x0000BB17
			public unsafe static ServerSettingTranslator<bool>.FromStorage _0___ToBoolean
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(BoolServerSettingDefinition.__O.NativeFieldInfoPtr__0___ToBoolean, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ServerSettingTranslator<bool>.FromStorage>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(BoolServerSettingDefinition.__O.NativeFieldInfoPtr__0___ToBoolean, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170008B0 RID: 2224
			// (get) Token: 0x06001FDC RID: 8156 RVA: 0x000904A0 File Offset: 0x0008E6A0
			// (set) Token: 0x06001FDD RID: 8157 RVA: 0x0000D929 File Offset: 0x0000BB29
			public unsafe static ServerSettingTranslator<bool>.ToStorage _1___ToInt32
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(BoolServerSettingDefinition.__O.NativeFieldInfoPtr__1___ToInt32, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ServerSettingTranslator<bool>.ToStorage>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(BoolServerSettingDefinition.__O.NativeFieldInfoPtr__1___ToInt32, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001646 RID: 5702
			private static readonly IntPtr NativeFieldInfoPtr__0___ToBoolean;

			// Token: 0x04001647 RID: 5703
			private static readonly IntPtr NativeFieldInfoPtr__1___ToInt32;
		}
	}
}
