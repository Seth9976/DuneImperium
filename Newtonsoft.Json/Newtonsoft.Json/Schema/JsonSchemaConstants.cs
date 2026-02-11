using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Newtonsoft.Json.Schema
{
	// Token: 0x020000A5 RID: 165
	public static class JsonSchemaConstants : Object
	{
		// Token: 0x06000EA8 RID: 3752 RVA: 0x000551C8 File Offset: 0x000533C8
		// Note: this type is marked as 'beforefieldinit'.
		static JsonSchemaConstants()
		{
			Il2CppClassPointerStore<JsonSchemaConstants>.NativeClassPtr = IL2CPP.GetIl2CppClass("Newtonsoft.Json.dll", "Newtonsoft.Json.Schema", "JsonSchemaConstants");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JsonSchemaConstants>.NativeClassPtr);
			JsonSchemaConstants.NativeFieldInfoPtr_TypePropertyName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonSchemaConstants>.NativeClassPtr, "TypePropertyName");
			JsonSchemaConstants.NativeFieldInfoPtr_PropertiesPropertyName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonSchemaConstants>.NativeClassPtr, "PropertiesPropertyName");
			JsonSchemaConstants.NativeFieldInfoPtr_ItemsPropertyName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonSchemaConstants>.NativeClassPtr, "ItemsPropertyName");
			JsonSchemaConstants.NativeFieldInfoPtr_AdditionalItemsPropertyName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonSchemaConstants>.NativeClassPtr, "AdditionalItemsPropertyName");
			JsonSchemaConstants.NativeFieldInfoPtr_RequiredPropertyName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonSchemaConstants>.NativeClassPtr, "RequiredPropertyName");
			JsonSchemaConstants.NativeFieldInfoPtr_PatternPropertiesPropertyName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonSchemaConstants>.NativeClassPtr, "PatternPropertiesPropertyName");
			JsonSchemaConstants.NativeFieldInfoPtr_AdditionalPropertiesPropertyName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonSchemaConstants>.NativeClassPtr, "AdditionalPropertiesPropertyName");
			JsonSchemaConstants.NativeFieldInfoPtr_RequiresPropertyName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonSchemaConstants>.NativeClassPtr, "RequiresPropertyName");
			JsonSchemaConstants.NativeFieldInfoPtr_MinimumPropertyName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonSchemaConstants>.NativeClassPtr, "MinimumPropertyName");
			JsonSchemaConstants.NativeFieldInfoPtr_MaximumPropertyName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonSchemaConstants>.NativeClassPtr, "MaximumPropertyName");
			JsonSchemaConstants.NativeFieldInfoPtr_ExclusiveMinimumPropertyName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonSchemaConstants>.NativeClassPtr, "ExclusiveMinimumPropertyName");
			JsonSchemaConstants.NativeFieldInfoPtr_ExclusiveMaximumPropertyName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonSchemaConstants>.NativeClassPtr, "ExclusiveMaximumPropertyName");
			JsonSchemaConstants.NativeFieldInfoPtr_MinimumItemsPropertyName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonSchemaConstants>.NativeClassPtr, "MinimumItemsPropertyName");
			JsonSchemaConstants.NativeFieldInfoPtr_MaximumItemsPropertyName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonSchemaConstants>.NativeClassPtr, "MaximumItemsPropertyName");
			JsonSchemaConstants.NativeFieldInfoPtr_PatternPropertyName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonSchemaConstants>.NativeClassPtr, "PatternPropertyName");
			JsonSchemaConstants.NativeFieldInfoPtr_MaximumLengthPropertyName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonSchemaConstants>.NativeClassPtr, "MaximumLengthPropertyName");
			JsonSchemaConstants.NativeFieldInfoPtr_MinimumLengthPropertyName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonSchemaConstants>.NativeClassPtr, "MinimumLengthPropertyName");
			JsonSchemaConstants.NativeFieldInfoPtr_EnumPropertyName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonSchemaConstants>.NativeClassPtr, "EnumPropertyName");
			JsonSchemaConstants.NativeFieldInfoPtr_ReadOnlyPropertyName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonSchemaConstants>.NativeClassPtr, "ReadOnlyPropertyName");
			JsonSchemaConstants.NativeFieldInfoPtr_TitlePropertyName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonSchemaConstants>.NativeClassPtr, "TitlePropertyName");
			JsonSchemaConstants.NativeFieldInfoPtr_DescriptionPropertyName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonSchemaConstants>.NativeClassPtr, "DescriptionPropertyName");
			JsonSchemaConstants.NativeFieldInfoPtr_FormatPropertyName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonSchemaConstants>.NativeClassPtr, "FormatPropertyName");
			JsonSchemaConstants.NativeFieldInfoPtr_DefaultPropertyName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonSchemaConstants>.NativeClassPtr, "DefaultPropertyName");
			JsonSchemaConstants.NativeFieldInfoPtr_TransientPropertyName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonSchemaConstants>.NativeClassPtr, "TransientPropertyName");
			JsonSchemaConstants.NativeFieldInfoPtr_DivisibleByPropertyName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonSchemaConstants>.NativeClassPtr, "DivisibleByPropertyName");
			JsonSchemaConstants.NativeFieldInfoPtr_HiddenPropertyName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonSchemaConstants>.NativeClassPtr, "HiddenPropertyName");
			JsonSchemaConstants.NativeFieldInfoPtr_DisallowPropertyName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonSchemaConstants>.NativeClassPtr, "DisallowPropertyName");
			JsonSchemaConstants.NativeFieldInfoPtr_ExtendsPropertyName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonSchemaConstants>.NativeClassPtr, "ExtendsPropertyName");
			JsonSchemaConstants.NativeFieldInfoPtr_IdPropertyName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonSchemaConstants>.NativeClassPtr, "IdPropertyName");
			JsonSchemaConstants.NativeFieldInfoPtr_UniqueItemsPropertyName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonSchemaConstants>.NativeClassPtr, "UniqueItemsPropertyName");
			JsonSchemaConstants.NativeFieldInfoPtr_OptionValuePropertyName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonSchemaConstants>.NativeClassPtr, "OptionValuePropertyName");
			JsonSchemaConstants.NativeFieldInfoPtr_OptionLabelPropertyName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonSchemaConstants>.NativeClassPtr, "OptionLabelPropertyName");
			JsonSchemaConstants.NativeFieldInfoPtr_JsonSchemaTypeMapping = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonSchemaConstants>.NativeClassPtr, "JsonSchemaTypeMapping");
		}

		// Token: 0x06000EA9 RID: 3753 RVA: 0x00006D3F File Offset: 0x00004F3F
		public JsonSchemaConstants(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003E9 RID: 1001
		// (get) Token: 0x06000EAA RID: 3754 RVA: 0x0005548C File Offset: 0x0005368C
		// (set) Token: 0x06000EAB RID: 3755 RVA: 0x00006D48 File Offset: 0x00004F48
		public unsafe static string TypePropertyName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(JsonSchemaConstants.NativeFieldInfoPtr_TypePropertyName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(JsonSchemaConstants.NativeFieldInfoPtr_TypePropertyName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170003EA RID: 1002
		// (get) Token: 0x06000EAC RID: 3756 RVA: 0x000554AC File Offset: 0x000536AC
		// (set) Token: 0x06000EAD RID: 3757 RVA: 0x00006D5A File Offset: 0x00004F5A
		public unsafe static string PropertiesPropertyName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(JsonSchemaConstants.NativeFieldInfoPtr_PropertiesPropertyName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(JsonSchemaConstants.NativeFieldInfoPtr_PropertiesPropertyName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170003EB RID: 1003
		// (get) Token: 0x06000EAE RID: 3758 RVA: 0x000554CC File Offset: 0x000536CC
		// (set) Token: 0x06000EAF RID: 3759 RVA: 0x00006D6C File Offset: 0x00004F6C
		public unsafe static string ItemsPropertyName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(JsonSchemaConstants.NativeFieldInfoPtr_ItemsPropertyName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(JsonSchemaConstants.NativeFieldInfoPtr_ItemsPropertyName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170003EC RID: 1004
		// (get) Token: 0x06000EB0 RID: 3760 RVA: 0x000554EC File Offset: 0x000536EC
		// (set) Token: 0x06000EB1 RID: 3761 RVA: 0x00006D7E File Offset: 0x00004F7E
		public unsafe static string AdditionalItemsPropertyName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(JsonSchemaConstants.NativeFieldInfoPtr_AdditionalItemsPropertyName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(JsonSchemaConstants.NativeFieldInfoPtr_AdditionalItemsPropertyName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170003ED RID: 1005
		// (get) Token: 0x06000EB2 RID: 3762 RVA: 0x0005550C File Offset: 0x0005370C
		// (set) Token: 0x06000EB3 RID: 3763 RVA: 0x00006D90 File Offset: 0x00004F90
		public unsafe static string RequiredPropertyName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(JsonSchemaConstants.NativeFieldInfoPtr_RequiredPropertyName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(JsonSchemaConstants.NativeFieldInfoPtr_RequiredPropertyName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170003EE RID: 1006
		// (get) Token: 0x06000EB4 RID: 3764 RVA: 0x0005552C File Offset: 0x0005372C
		// (set) Token: 0x06000EB5 RID: 3765 RVA: 0x00006DA2 File Offset: 0x00004FA2
		public unsafe static string PatternPropertiesPropertyName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(JsonSchemaConstants.NativeFieldInfoPtr_PatternPropertiesPropertyName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(JsonSchemaConstants.NativeFieldInfoPtr_PatternPropertiesPropertyName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170003EF RID: 1007
		// (get) Token: 0x06000EB6 RID: 3766 RVA: 0x0005554C File Offset: 0x0005374C
		// (set) Token: 0x06000EB7 RID: 3767 RVA: 0x00006DB4 File Offset: 0x00004FB4
		public unsafe static string AdditionalPropertiesPropertyName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(JsonSchemaConstants.NativeFieldInfoPtr_AdditionalPropertiesPropertyName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(JsonSchemaConstants.NativeFieldInfoPtr_AdditionalPropertiesPropertyName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170003F0 RID: 1008
		// (get) Token: 0x06000EB8 RID: 3768 RVA: 0x0005556C File Offset: 0x0005376C
		// (set) Token: 0x06000EB9 RID: 3769 RVA: 0x00006DC6 File Offset: 0x00004FC6
		public unsafe static string RequiresPropertyName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(JsonSchemaConstants.NativeFieldInfoPtr_RequiresPropertyName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(JsonSchemaConstants.NativeFieldInfoPtr_RequiresPropertyName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170003F1 RID: 1009
		// (get) Token: 0x06000EBA RID: 3770 RVA: 0x0005558C File Offset: 0x0005378C
		// (set) Token: 0x06000EBB RID: 3771 RVA: 0x00006DD8 File Offset: 0x00004FD8
		public unsafe static string MinimumPropertyName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(JsonSchemaConstants.NativeFieldInfoPtr_MinimumPropertyName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(JsonSchemaConstants.NativeFieldInfoPtr_MinimumPropertyName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170003F2 RID: 1010
		// (get) Token: 0x06000EBC RID: 3772 RVA: 0x000555AC File Offset: 0x000537AC
		// (set) Token: 0x06000EBD RID: 3773 RVA: 0x00006DEA File Offset: 0x00004FEA
		public unsafe static string MaximumPropertyName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(JsonSchemaConstants.NativeFieldInfoPtr_MaximumPropertyName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(JsonSchemaConstants.NativeFieldInfoPtr_MaximumPropertyName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170003F3 RID: 1011
		// (get) Token: 0x06000EBE RID: 3774 RVA: 0x000555CC File Offset: 0x000537CC
		// (set) Token: 0x06000EBF RID: 3775 RVA: 0x00006DFC File Offset: 0x00004FFC
		public unsafe static string ExclusiveMinimumPropertyName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(JsonSchemaConstants.NativeFieldInfoPtr_ExclusiveMinimumPropertyName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(JsonSchemaConstants.NativeFieldInfoPtr_ExclusiveMinimumPropertyName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170003F4 RID: 1012
		// (get) Token: 0x06000EC0 RID: 3776 RVA: 0x000555EC File Offset: 0x000537EC
		// (set) Token: 0x06000EC1 RID: 3777 RVA: 0x00006E0E File Offset: 0x0000500E
		public unsafe static string ExclusiveMaximumPropertyName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(JsonSchemaConstants.NativeFieldInfoPtr_ExclusiveMaximumPropertyName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(JsonSchemaConstants.NativeFieldInfoPtr_ExclusiveMaximumPropertyName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170003F5 RID: 1013
		// (get) Token: 0x06000EC2 RID: 3778 RVA: 0x0005560C File Offset: 0x0005380C
		// (set) Token: 0x06000EC3 RID: 3779 RVA: 0x00006E20 File Offset: 0x00005020
		public unsafe static string MinimumItemsPropertyName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(JsonSchemaConstants.NativeFieldInfoPtr_MinimumItemsPropertyName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(JsonSchemaConstants.NativeFieldInfoPtr_MinimumItemsPropertyName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170003F6 RID: 1014
		// (get) Token: 0x06000EC4 RID: 3780 RVA: 0x0005562C File Offset: 0x0005382C
		// (set) Token: 0x06000EC5 RID: 3781 RVA: 0x00006E32 File Offset: 0x00005032
		public unsafe static string MaximumItemsPropertyName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(JsonSchemaConstants.NativeFieldInfoPtr_MaximumItemsPropertyName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(JsonSchemaConstants.NativeFieldInfoPtr_MaximumItemsPropertyName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170003F7 RID: 1015
		// (get) Token: 0x06000EC6 RID: 3782 RVA: 0x0005564C File Offset: 0x0005384C
		// (set) Token: 0x06000EC7 RID: 3783 RVA: 0x00006E44 File Offset: 0x00005044
		public unsafe static string PatternPropertyName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(JsonSchemaConstants.NativeFieldInfoPtr_PatternPropertyName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(JsonSchemaConstants.NativeFieldInfoPtr_PatternPropertyName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170003F8 RID: 1016
		// (get) Token: 0x06000EC8 RID: 3784 RVA: 0x0005566C File Offset: 0x0005386C
		// (set) Token: 0x06000EC9 RID: 3785 RVA: 0x00006E56 File Offset: 0x00005056
		public unsafe static string MaximumLengthPropertyName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(JsonSchemaConstants.NativeFieldInfoPtr_MaximumLengthPropertyName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(JsonSchemaConstants.NativeFieldInfoPtr_MaximumLengthPropertyName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170003F9 RID: 1017
		// (get) Token: 0x06000ECA RID: 3786 RVA: 0x0005568C File Offset: 0x0005388C
		// (set) Token: 0x06000ECB RID: 3787 RVA: 0x00006E68 File Offset: 0x00005068
		public unsafe static string MinimumLengthPropertyName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(JsonSchemaConstants.NativeFieldInfoPtr_MinimumLengthPropertyName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(JsonSchemaConstants.NativeFieldInfoPtr_MinimumLengthPropertyName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170003FA RID: 1018
		// (get) Token: 0x06000ECC RID: 3788 RVA: 0x000556AC File Offset: 0x000538AC
		// (set) Token: 0x06000ECD RID: 3789 RVA: 0x00006E7A File Offset: 0x0000507A
		public unsafe static string EnumPropertyName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(JsonSchemaConstants.NativeFieldInfoPtr_EnumPropertyName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(JsonSchemaConstants.NativeFieldInfoPtr_EnumPropertyName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170003FB RID: 1019
		// (get) Token: 0x06000ECE RID: 3790 RVA: 0x000556CC File Offset: 0x000538CC
		// (set) Token: 0x06000ECF RID: 3791 RVA: 0x00006E8C File Offset: 0x0000508C
		public unsafe static string ReadOnlyPropertyName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(JsonSchemaConstants.NativeFieldInfoPtr_ReadOnlyPropertyName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(JsonSchemaConstants.NativeFieldInfoPtr_ReadOnlyPropertyName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170003FC RID: 1020
		// (get) Token: 0x06000ED0 RID: 3792 RVA: 0x000556EC File Offset: 0x000538EC
		// (set) Token: 0x06000ED1 RID: 3793 RVA: 0x00006E9E File Offset: 0x0000509E
		public unsafe static string TitlePropertyName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(JsonSchemaConstants.NativeFieldInfoPtr_TitlePropertyName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(JsonSchemaConstants.NativeFieldInfoPtr_TitlePropertyName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170003FD RID: 1021
		// (get) Token: 0x06000ED2 RID: 3794 RVA: 0x0005570C File Offset: 0x0005390C
		// (set) Token: 0x06000ED3 RID: 3795 RVA: 0x00006EB0 File Offset: 0x000050B0
		public unsafe static string DescriptionPropertyName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(JsonSchemaConstants.NativeFieldInfoPtr_DescriptionPropertyName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(JsonSchemaConstants.NativeFieldInfoPtr_DescriptionPropertyName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170003FE RID: 1022
		// (get) Token: 0x06000ED4 RID: 3796 RVA: 0x0005572C File Offset: 0x0005392C
		// (set) Token: 0x06000ED5 RID: 3797 RVA: 0x00006EC2 File Offset: 0x000050C2
		public unsafe static string FormatPropertyName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(JsonSchemaConstants.NativeFieldInfoPtr_FormatPropertyName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(JsonSchemaConstants.NativeFieldInfoPtr_FormatPropertyName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170003FF RID: 1023
		// (get) Token: 0x06000ED6 RID: 3798 RVA: 0x0005574C File Offset: 0x0005394C
		// (set) Token: 0x06000ED7 RID: 3799 RVA: 0x00006ED4 File Offset: 0x000050D4
		public unsafe static string DefaultPropertyName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(JsonSchemaConstants.NativeFieldInfoPtr_DefaultPropertyName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(JsonSchemaConstants.NativeFieldInfoPtr_DefaultPropertyName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000400 RID: 1024
		// (get) Token: 0x06000ED8 RID: 3800 RVA: 0x0005576C File Offset: 0x0005396C
		// (set) Token: 0x06000ED9 RID: 3801 RVA: 0x00006EE6 File Offset: 0x000050E6
		public unsafe static string TransientPropertyName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(JsonSchemaConstants.NativeFieldInfoPtr_TransientPropertyName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(JsonSchemaConstants.NativeFieldInfoPtr_TransientPropertyName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000401 RID: 1025
		// (get) Token: 0x06000EDA RID: 3802 RVA: 0x0005578C File Offset: 0x0005398C
		// (set) Token: 0x06000EDB RID: 3803 RVA: 0x00006EF8 File Offset: 0x000050F8
		public unsafe static string DivisibleByPropertyName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(JsonSchemaConstants.NativeFieldInfoPtr_DivisibleByPropertyName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(JsonSchemaConstants.NativeFieldInfoPtr_DivisibleByPropertyName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000402 RID: 1026
		// (get) Token: 0x06000EDC RID: 3804 RVA: 0x000557AC File Offset: 0x000539AC
		// (set) Token: 0x06000EDD RID: 3805 RVA: 0x00006F0A File Offset: 0x0000510A
		public unsafe static string HiddenPropertyName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(JsonSchemaConstants.NativeFieldInfoPtr_HiddenPropertyName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(JsonSchemaConstants.NativeFieldInfoPtr_HiddenPropertyName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000403 RID: 1027
		// (get) Token: 0x06000EDE RID: 3806 RVA: 0x000557CC File Offset: 0x000539CC
		// (set) Token: 0x06000EDF RID: 3807 RVA: 0x00006F1C File Offset: 0x0000511C
		public unsafe static string DisallowPropertyName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(JsonSchemaConstants.NativeFieldInfoPtr_DisallowPropertyName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(JsonSchemaConstants.NativeFieldInfoPtr_DisallowPropertyName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000404 RID: 1028
		// (get) Token: 0x06000EE0 RID: 3808 RVA: 0x000557EC File Offset: 0x000539EC
		// (set) Token: 0x06000EE1 RID: 3809 RVA: 0x00006F2E File Offset: 0x0000512E
		public unsafe static string ExtendsPropertyName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(JsonSchemaConstants.NativeFieldInfoPtr_ExtendsPropertyName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(JsonSchemaConstants.NativeFieldInfoPtr_ExtendsPropertyName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000405 RID: 1029
		// (get) Token: 0x06000EE2 RID: 3810 RVA: 0x0005580C File Offset: 0x00053A0C
		// (set) Token: 0x06000EE3 RID: 3811 RVA: 0x00006F40 File Offset: 0x00005140
		public unsafe static string IdPropertyName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(JsonSchemaConstants.NativeFieldInfoPtr_IdPropertyName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(JsonSchemaConstants.NativeFieldInfoPtr_IdPropertyName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000406 RID: 1030
		// (get) Token: 0x06000EE4 RID: 3812 RVA: 0x0005582C File Offset: 0x00053A2C
		// (set) Token: 0x06000EE5 RID: 3813 RVA: 0x00006F52 File Offset: 0x00005152
		public unsafe static string UniqueItemsPropertyName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(JsonSchemaConstants.NativeFieldInfoPtr_UniqueItemsPropertyName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(JsonSchemaConstants.NativeFieldInfoPtr_UniqueItemsPropertyName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000407 RID: 1031
		// (get) Token: 0x06000EE6 RID: 3814 RVA: 0x0005584C File Offset: 0x00053A4C
		// (set) Token: 0x06000EE7 RID: 3815 RVA: 0x00006F64 File Offset: 0x00005164
		public unsafe static string OptionValuePropertyName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(JsonSchemaConstants.NativeFieldInfoPtr_OptionValuePropertyName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(JsonSchemaConstants.NativeFieldInfoPtr_OptionValuePropertyName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000408 RID: 1032
		// (get) Token: 0x06000EE8 RID: 3816 RVA: 0x0005586C File Offset: 0x00053A6C
		// (set) Token: 0x06000EE9 RID: 3817 RVA: 0x00006F76 File Offset: 0x00005176
		public unsafe static string OptionLabelPropertyName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(JsonSchemaConstants.NativeFieldInfoPtr_OptionLabelPropertyName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(JsonSchemaConstants.NativeFieldInfoPtr_OptionLabelPropertyName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000409 RID: 1033
		// (get) Token: 0x06000EEA RID: 3818 RVA: 0x0005588C File Offset: 0x00053A8C
		// (set) Token: 0x06000EEB RID: 3819 RVA: 0x00006F88 File Offset: 0x00005188
		public unsafe static IDictionary<string, JsonSchemaType> JsonSchemaTypeMapping
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(JsonSchemaConstants.NativeFieldInfoPtr_JsonSchemaTypeMapping, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IDictionary<string, JsonSchemaType>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(JsonSchemaConstants.NativeFieldInfoPtr_JsonSchemaTypeMapping, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000BD1 RID: 3025
		private static readonly IntPtr NativeFieldInfoPtr_TypePropertyName;

		// Token: 0x04000BD2 RID: 3026
		private static readonly IntPtr NativeFieldInfoPtr_PropertiesPropertyName;

		// Token: 0x04000BD3 RID: 3027
		private static readonly IntPtr NativeFieldInfoPtr_ItemsPropertyName;

		// Token: 0x04000BD4 RID: 3028
		private static readonly IntPtr NativeFieldInfoPtr_AdditionalItemsPropertyName;

		// Token: 0x04000BD5 RID: 3029
		private static readonly IntPtr NativeFieldInfoPtr_RequiredPropertyName;

		// Token: 0x04000BD6 RID: 3030
		private static readonly IntPtr NativeFieldInfoPtr_PatternPropertiesPropertyName;

		// Token: 0x04000BD7 RID: 3031
		private static readonly IntPtr NativeFieldInfoPtr_AdditionalPropertiesPropertyName;

		// Token: 0x04000BD8 RID: 3032
		private static readonly IntPtr NativeFieldInfoPtr_RequiresPropertyName;

		// Token: 0x04000BD9 RID: 3033
		private static readonly IntPtr NativeFieldInfoPtr_MinimumPropertyName;

		// Token: 0x04000BDA RID: 3034
		private static readonly IntPtr NativeFieldInfoPtr_MaximumPropertyName;

		// Token: 0x04000BDB RID: 3035
		private static readonly IntPtr NativeFieldInfoPtr_ExclusiveMinimumPropertyName;

		// Token: 0x04000BDC RID: 3036
		private static readonly IntPtr NativeFieldInfoPtr_ExclusiveMaximumPropertyName;

		// Token: 0x04000BDD RID: 3037
		private static readonly IntPtr NativeFieldInfoPtr_MinimumItemsPropertyName;

		// Token: 0x04000BDE RID: 3038
		private static readonly IntPtr NativeFieldInfoPtr_MaximumItemsPropertyName;

		// Token: 0x04000BDF RID: 3039
		private static readonly IntPtr NativeFieldInfoPtr_PatternPropertyName;

		// Token: 0x04000BE0 RID: 3040
		private static readonly IntPtr NativeFieldInfoPtr_MaximumLengthPropertyName;

		// Token: 0x04000BE1 RID: 3041
		private static readonly IntPtr NativeFieldInfoPtr_MinimumLengthPropertyName;

		// Token: 0x04000BE2 RID: 3042
		private static readonly IntPtr NativeFieldInfoPtr_EnumPropertyName;

		// Token: 0x04000BE3 RID: 3043
		private static readonly IntPtr NativeFieldInfoPtr_ReadOnlyPropertyName;

		// Token: 0x04000BE4 RID: 3044
		private static readonly IntPtr NativeFieldInfoPtr_TitlePropertyName;

		// Token: 0x04000BE5 RID: 3045
		private static readonly IntPtr NativeFieldInfoPtr_DescriptionPropertyName;

		// Token: 0x04000BE6 RID: 3046
		private static readonly IntPtr NativeFieldInfoPtr_FormatPropertyName;

		// Token: 0x04000BE7 RID: 3047
		private static readonly IntPtr NativeFieldInfoPtr_DefaultPropertyName;

		// Token: 0x04000BE8 RID: 3048
		private static readonly IntPtr NativeFieldInfoPtr_TransientPropertyName;

		// Token: 0x04000BE9 RID: 3049
		private static readonly IntPtr NativeFieldInfoPtr_DivisibleByPropertyName;

		// Token: 0x04000BEA RID: 3050
		private static readonly IntPtr NativeFieldInfoPtr_HiddenPropertyName;

		// Token: 0x04000BEB RID: 3051
		private static readonly IntPtr NativeFieldInfoPtr_DisallowPropertyName;

		// Token: 0x04000BEC RID: 3052
		private static readonly IntPtr NativeFieldInfoPtr_ExtendsPropertyName;

		// Token: 0x04000BED RID: 3053
		private static readonly IntPtr NativeFieldInfoPtr_IdPropertyName;

		// Token: 0x04000BEE RID: 3054
		private static readonly IntPtr NativeFieldInfoPtr_UniqueItemsPropertyName;

		// Token: 0x04000BEF RID: 3055
		private static readonly IntPtr NativeFieldInfoPtr_OptionValuePropertyName;

		// Token: 0x04000BF0 RID: 3056
		private static readonly IntPtr NativeFieldInfoPtr_OptionLabelPropertyName;

		// Token: 0x04000BF1 RID: 3057
		private static readonly IntPtr NativeFieldInfoPtr_JsonSchemaTypeMapping;
	}
}
