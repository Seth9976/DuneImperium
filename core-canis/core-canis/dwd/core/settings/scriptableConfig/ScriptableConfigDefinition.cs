using System;
using dwd.core.settings.config;
using dwd.core.settings.config.definitions;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace dwd.core.settings.scriptableConfig
{
	// Token: 0x020000C6 RID: 198
	public class ScriptableConfigDefinition<TScriptableObject> : ConfigDefinition<string> where TScriptableObject : ScriptableObject
	{
		// Token: 0x06000C5F RID: 3167 RVA: 0x00042FE8 File Offset: 0x000411E8
		// Note: this type is marked as 'beforefieldinit'.
		static ScriptableConfigDefinition()
		{
			Il2CppClassPointerStore<ScriptableConfigDefinition<TScriptableObject>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.settings.scriptableConfig", "ScriptableConfigDefinition`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TScriptableObject>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScriptableConfigDefinition<TScriptableObject>>.NativeClassPtr);
			ScriptableConfigDefinition<TScriptableObject>.NativeFieldInfoPtr_searchedForConfig = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableConfigDefinition<TScriptableObject>>.NativeClassPtr, "searchedForConfig");
			ScriptableConfigDefinition<TScriptableObject>.NativeFieldInfoPtr__config = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableConfigDefinition<TScriptableObject>>.NativeClassPtr, "_config");
			ScriptableConfigDefinition<TScriptableObject>.NativeMethodInfoPtr_get_config_Private_Static_get_TScriptableObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableConfigDefinition<TScriptableObject>>.NativeClassPtr, 100665044);
			ScriptableConfigDefinition<TScriptableObject>.NativeMethodInfoPtr__ctor_Public_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableConfigDefinition<TScriptableObject>>.NativeClassPtr, 100665045);
			ScriptableConfigDefinition<TScriptableObject>.NativeMethodInfoPtr_createSetting_Protected_Virtual_ConfigSetting_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableConfigDefinition<TScriptableObject>>.NativeClassPtr, 100665046);
			ScriptableConfigDefinition<TScriptableObject>.NativeMethodInfoPtr_convert_Protected_Virtual_Boolean_String_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableConfigDefinition<TScriptableObject>>.NativeClassPtr, 100665047);
		}

		// Token: 0x17000363 RID: 867
		// (get) Token: 0x06000C60 RID: 3168 RVA: 0x000430CC File Offset: 0x000412CC
		public new unsafe static TScriptableObject config
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 864446, RefRangeEnd = 864447, XrefRangeStart = 864430, XrefRangeEnd = 864446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableConfigDefinition<TScriptableObject>.NativeMethodInfoPtr_get_config_Private_Static_get_TScriptableObject_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<TScriptableObject>(intPtr, false, true);
			}
		}

		// Token: 0x06000C61 RID: 3169 RVA: 0x000430FC File Offset: 0x000412FC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 864451, RefRangeEnd = 864452, XrefRangeStart = 864447, XrefRangeEnd = 864451, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ScriptableConfigDefinition(string key, string defaultValue)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ScriptableConfigDefinition<TScriptableObject>>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(defaultValue);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableConfigDefinition<TScriptableObject>.NativeMethodInfoPtr__ctor_Public_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C62 RID: 3170 RVA: 0x0004315C File Offset: 0x0004135C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 864452, XrefRangeEnd = 864478, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override ConfigSetting<string> createSetting()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ScriptableConfigDefinition<TScriptableObject>.NativeMethodInfoPtr_createSetting_Protected_Virtual_ConfigSetting_1_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ConfigSetting<string>>(intPtr3) : null;
		}

		// Token: 0x06000C63 RID: 3171 RVA: 0x000431A8 File Offset: 0x000413A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 864478, XrefRangeEnd = 864479, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ScriptableConfigDefinition<TScriptableObject>.NativeMethodInfoPtr_convert_Protected_Virtual_Boolean_String_byref_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			value = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06000C64 RID: 3172 RVA: 0x000065FD File Offset: 0x000047FD
		public ScriptableConfigDefinition(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000361 RID: 865
		// (get) Token: 0x06000C65 RID: 3173 RVA: 0x0004321C File Offset: 0x0004141C
		// (set) Token: 0x06000C66 RID: 3174 RVA: 0x00006606 File Offset: 0x00004806
		public unsafe static bool searchedForConfig
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(ScriptableConfigDefinition<TScriptableObject>.NativeFieldInfoPtr_searchedForConfig, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ScriptableConfigDefinition<TScriptableObject>.NativeFieldInfoPtr_searchedForConfig, (void*)(&value));
			}
		}

		// Token: 0x17000362 RID: 866
		// (get) Token: 0x06000C67 RID: 3175 RVA: 0x00043238 File Offset: 0x00041438
		// (set) Token: 0x06000C68 RID: 3176 RVA: 0x0004325C File Offset: 0x0004145C
		public unsafe static TScriptableObject _config
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ScriptableConfigDefinition<TScriptableObject>.NativeFieldInfoPtr__config, (void*)(&intPtr));
				return IL2CPP.PointerToValueGeneric<TScriptableObject>(intPtr, false, false);
			}
			set
			{
				IntPtr nativeFieldInfoPtr__config = ScriptableConfigDefinition<TScriptableObject>.NativeFieldInfoPtr__config;
				ref TScriptableObject ptr2;
				if (!typeof(TScriptableObject).IsValueType)
				{
					TScriptableObject tscriptableObject = value;
					if (!(tscriptableObject is string))
					{
						ref TScriptableObject ptr = (ptr2 = IL2CPP.Il2CppObjectBaseToPtr(tscriptableObject as Il2CppObjectBase));
						if ((ref ptr) != null)
						{
							ptr2 = ref ptr;
							if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(ref ptr)))
							{
								ptr2 = IL2CPP.il2cpp_object_unbox(ref ptr);
							}
						}
					}
					else
					{
						ptr2 = IL2CPP.ManagedStringToIl2Cpp(tscriptableObject as string);
					}
				}
				else
				{
					ptr2 = ref value;
				}
				IL2CPP.il2cpp_field_static_set_value(nativeFieldInfoPtr__config, (void*)(&ptr2));
			}
		}

		// Token: 0x040008EC RID: 2284
		private static readonly IntPtr NativeFieldInfoPtr_searchedForConfig;

		// Token: 0x040008ED RID: 2285
		private static readonly IntPtr NativeFieldInfoPtr__config;

		// Token: 0x040008EE RID: 2286
		private static readonly IntPtr NativeMethodInfoPtr_get_config_Private_Static_get_TScriptableObject_0;

		// Token: 0x040008EF RID: 2287
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_0;

		// Token: 0x040008F0 RID: 2288
		private static readonly IntPtr NativeMethodInfoPtr_createSetting_Protected_Virtual_ConfigSetting_1_String_0;

		// Token: 0x040008F1 RID: 2289
		private static readonly IntPtr NativeMethodInfoPtr_convert_Protected_Virtual_Boolean_String_byref_String_0;
	}
}
