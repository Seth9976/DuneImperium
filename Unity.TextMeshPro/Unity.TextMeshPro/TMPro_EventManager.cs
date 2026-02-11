using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace TMPro
{
	// Token: 0x02000010 RID: 16
	public static class TMPro_EventManager : global::Il2CppSystem.Object
	{
		// Token: 0x060001E1 RID: 481 RVA: 0x00010B28 File Offset: 0x0000ED28
		// Note: this type is marked as 'beforefieldinit'.
		static TMPro_EventManager()
		{
			Il2CppClassPointerStore<TMPro_EventManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.TextMeshPro.dll", "TMPro", "TMPro_EventManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TMPro_EventManager>.NativeClassPtr);
			TMPro_EventManager.NativeFieldInfoPtr_COMPUTE_DT_EVENT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMPro_EventManager>.NativeClassPtr, "COMPUTE_DT_EVENT");
			TMPro_EventManager.NativeFieldInfoPtr_MATERIAL_PROPERTY_EVENT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMPro_EventManager>.NativeClassPtr, "MATERIAL_PROPERTY_EVENT");
			TMPro_EventManager.NativeFieldInfoPtr_FONT_PROPERTY_EVENT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMPro_EventManager>.NativeClassPtr, "FONT_PROPERTY_EVENT");
			TMPro_EventManager.NativeFieldInfoPtr_SPRITE_ASSET_PROPERTY_EVENT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMPro_EventManager>.NativeClassPtr, "SPRITE_ASSET_PROPERTY_EVENT");
			TMPro_EventManager.NativeFieldInfoPtr_TEXTMESHPRO_PROPERTY_EVENT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMPro_EventManager>.NativeClassPtr, "TEXTMESHPRO_PROPERTY_EVENT");
			TMPro_EventManager.NativeFieldInfoPtr_DRAG_AND_DROP_MATERIAL_EVENT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMPro_EventManager>.NativeClassPtr, "DRAG_AND_DROP_MATERIAL_EVENT");
			TMPro_EventManager.NativeFieldInfoPtr_TEXT_STYLE_PROPERTY_EVENT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMPro_EventManager>.NativeClassPtr, "TEXT_STYLE_PROPERTY_EVENT");
			TMPro_EventManager.NativeFieldInfoPtr_COLOR_GRADIENT_PROPERTY_EVENT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMPro_EventManager>.NativeClassPtr, "COLOR_GRADIENT_PROPERTY_EVENT");
			TMPro_EventManager.NativeFieldInfoPtr_TMP_SETTINGS_PROPERTY_EVENT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMPro_EventManager>.NativeClassPtr, "TMP_SETTINGS_PROPERTY_EVENT");
			TMPro_EventManager.NativeFieldInfoPtr_RESOURCE_LOAD_EVENT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMPro_EventManager>.NativeClassPtr, "RESOURCE_LOAD_EVENT");
			TMPro_EventManager.NativeFieldInfoPtr_TEXTMESHPRO_UGUI_PROPERTY_EVENT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMPro_EventManager>.NativeClassPtr, "TEXTMESHPRO_UGUI_PROPERTY_EVENT");
			TMPro_EventManager.NativeFieldInfoPtr_TEXT_CHANGED_EVENT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMPro_EventManager>.NativeClassPtr, "TEXT_CHANGED_EVENT");
			TMPro_EventManager.NativeMethodInfoPtr_ON_MATERIAL_PROPERTY_CHANGED_Public_Static_Void_Boolean_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMPro_EventManager>.NativeClassPtr, 100663538);
			TMPro_EventManager.NativeMethodInfoPtr_ON_FONT_PROPERTY_CHANGED_Public_Static_Void_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMPro_EventManager>.NativeClassPtr, 100663539);
			TMPro_EventManager.NativeMethodInfoPtr_ON_SPRITE_ASSET_PROPERTY_CHANGED_Public_Static_Void_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMPro_EventManager>.NativeClassPtr, 100663540);
			TMPro_EventManager.NativeMethodInfoPtr_ON_TEXTMESHPRO_PROPERTY_CHANGED_Public_Static_Void_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMPro_EventManager>.NativeClassPtr, 100663541);
			TMPro_EventManager.NativeMethodInfoPtr_ON_DRAG_AND_DROP_MATERIAL_CHANGED_Public_Static_Void_GameObject_Material_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMPro_EventManager>.NativeClassPtr, 100663542);
			TMPro_EventManager.NativeMethodInfoPtr_ON_TEXT_STYLE_PROPERTY_CHANGED_Public_Static_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMPro_EventManager>.NativeClassPtr, 100663543);
			TMPro_EventManager.NativeMethodInfoPtr_ON_COLOR_GRADIENT_PROPERTY_CHANGED_Public_Static_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMPro_EventManager>.NativeClassPtr, 100663544);
			TMPro_EventManager.NativeMethodInfoPtr_ON_TEXT_CHANGED_Public_Static_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMPro_EventManager>.NativeClassPtr, 100663545);
			TMPro_EventManager.NativeMethodInfoPtr_ON_TMP_SETTINGS_CHANGED_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMPro_EventManager>.NativeClassPtr, 100663546);
			TMPro_EventManager.NativeMethodInfoPtr_ON_RESOURCES_LOADED_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMPro_EventManager>.NativeClassPtr, 100663547);
			TMPro_EventManager.NativeMethodInfoPtr_ON_TEXTMESHPRO_UGUI_PROPERTY_CHANGED_Public_Static_Void_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMPro_EventManager>.NativeClassPtr, 100663548);
			TMPro_EventManager.NativeMethodInfoPtr_ON_COMPUTE_DT_EVENT_Public_Static_Void_Object_Compute_DT_EventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMPro_EventManager>.NativeClassPtr, 100663549);
		}

		// Token: 0x060001E2 RID: 482 RVA: 0x00010D38 File Offset: 0x0000EF38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1037659, XrefRangeEnd = 1037667, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ON_MATERIAL_PROPERTY_CHANGED(bool isChanged, Material mat)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref isChanged;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(mat);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMPro_EventManager.NativeMethodInfoPtr_ON_MATERIAL_PROPERTY_CHANGED_Public_Static_Void_Boolean_Material_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001E3 RID: 483 RVA: 0x00010D7C File Offset: 0x0000EF7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1037667, XrefRangeEnd = 1037675, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ON_FONT_PROPERTY_CHANGED(bool isChanged, global::UnityEngine.Object obj)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref isChanged;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(obj);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMPro_EventManager.NativeMethodInfoPtr_ON_FONT_PROPERTY_CHANGED_Public_Static_Void_Boolean_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001E4 RID: 484 RVA: 0x00010DC0 File Offset: 0x0000EFC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1037675, XrefRangeEnd = 1037683, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ON_SPRITE_ASSET_PROPERTY_CHANGED(bool isChanged, global::UnityEngine.Object obj)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref isChanged;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(obj);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMPro_EventManager.NativeMethodInfoPtr_ON_SPRITE_ASSET_PROPERTY_CHANGED_Public_Static_Void_Boolean_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001E5 RID: 485 RVA: 0x00010E04 File Offset: 0x0000F004
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1037683, XrefRangeEnd = 1037691, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ON_TEXTMESHPRO_PROPERTY_CHANGED(bool isChanged, global::UnityEngine.Object obj)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref isChanged;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(obj);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMPro_EventManager.NativeMethodInfoPtr_ON_TEXTMESHPRO_PROPERTY_CHANGED_Public_Static_Void_Boolean_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001E6 RID: 486 RVA: 0x00010E48 File Offset: 0x0000F048
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1037691, XrefRangeEnd = 1037698, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ON_DRAG_AND_DROP_MATERIAL_CHANGED(GameObject sender, Material currentMaterial, Material newMaterial)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sender);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(currentMaterial);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(newMaterial);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMPro_EventManager.NativeMethodInfoPtr_ON_DRAG_AND_DROP_MATERIAL_CHANGED_Public_Static_Void_GameObject_Material_Material_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001E7 RID: 487 RVA: 0x00010EA4 File Offset: 0x0000F0A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1037698, XrefRangeEnd = 1037706, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ON_TEXT_STYLE_PROPERTY_CHANGED(bool isChanged)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref isChanged;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMPro_EventManager.NativeMethodInfoPtr_ON_TEXT_STYLE_PROPERTY_CHANGED_Public_Static_Void_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060001E8 RID: 488 RVA: 0x00010ED8 File Offset: 0x0000F0D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1037706, XrefRangeEnd = 1037714, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ON_COLOR_GRADIENT_PROPERTY_CHANGED(global::UnityEngine.Object obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMPro_EventManager.NativeMethodInfoPtr_ON_COLOR_GRADIENT_PROPERTY_CHANGED_Public_Static_Void_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060001E9 RID: 489 RVA: 0x00010F10 File Offset: 0x0000F110
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1037722, RefRangeEnd = 1037726, XrefRangeStart = 1037714, XrefRangeEnd = 1037722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ON_TEXT_CHANGED(global::UnityEngine.Object obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMPro_EventManager.NativeMethodInfoPtr_ON_TEXT_CHANGED_Public_Static_Void_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060001EA RID: 490 RVA: 0x00010F48 File Offset: 0x0000F148
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1037726, XrefRangeEnd = 1037828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ON_TMP_SETTINGS_CHANGED()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMPro_EventManager.NativeMethodInfoPtr_ON_TMP_SETTINGS_CHANGED_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001EB RID: 491 RVA: 0x00010F70 File Offset: 0x0000F170
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1037828, XrefRangeEnd = 1037834, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ON_RESOURCES_LOADED()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMPro_EventManager.NativeMethodInfoPtr_ON_RESOURCES_LOADED_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001EC RID: 492 RVA: 0x00010F98 File Offset: 0x0000F198
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1037834, XrefRangeEnd = 1037842, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ON_TEXTMESHPRO_UGUI_PROPERTY_CHANGED(bool isChanged, global::UnityEngine.Object obj)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref isChanged;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(obj);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMPro_EventManager.NativeMethodInfoPtr_ON_TEXTMESHPRO_UGUI_PROPERTY_CHANGED_Public_Static_Void_Boolean_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001ED RID: 493 RVA: 0x00010FDC File Offset: 0x0000F1DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1037842, XrefRangeEnd = 1037850, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ON_COMPUTE_DT_EVENT(global::Il2CppSystem.Object Sender, Compute_DT_EventArgs e)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(Sender);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(e);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMPro_EventManager.NativeMethodInfoPtr_ON_COMPUTE_DT_EVENT_Public_Static_Void_Object_Compute_DT_EventArgs_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001EE RID: 494 RVA: 0x00002B7F File Offset: 0x00000D7F
		public TMPro_EventManager(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000091 RID: 145
		// (get) Token: 0x060001EF RID: 495 RVA: 0x00011024 File Offset: 0x0000F224
		// (set) Token: 0x060001F0 RID: 496 RVA: 0x00002B88 File Offset: 0x00000D88
		public unsafe static FastAction<global::Il2CppSystem.Object, Compute_DT_EventArgs> COMPUTE_DT_EVENT
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TMPro_EventManager.NativeFieldInfoPtr_COMPUTE_DT_EVENT, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FastAction<global::Il2CppSystem.Object, Compute_DT_EventArgs>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TMPro_EventManager.NativeFieldInfoPtr_COMPUTE_DT_EVENT, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000092 RID: 146
		// (get) Token: 0x060001F1 RID: 497 RVA: 0x0001104C File Offset: 0x0000F24C
		// (set) Token: 0x060001F2 RID: 498 RVA: 0x00002B9A File Offset: 0x00000D9A
		public unsafe static FastAction<bool, Material> MATERIAL_PROPERTY_EVENT
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TMPro_EventManager.NativeFieldInfoPtr_MATERIAL_PROPERTY_EVENT, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FastAction<bool, Material>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TMPro_EventManager.NativeFieldInfoPtr_MATERIAL_PROPERTY_EVENT, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000093 RID: 147
		// (get) Token: 0x060001F3 RID: 499 RVA: 0x00011074 File Offset: 0x0000F274
		// (set) Token: 0x060001F4 RID: 500 RVA: 0x00002BAC File Offset: 0x00000DAC
		public unsafe static FastAction<bool, global::UnityEngine.Object> FONT_PROPERTY_EVENT
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TMPro_EventManager.NativeFieldInfoPtr_FONT_PROPERTY_EVENT, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FastAction<bool, global::UnityEngine.Object>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TMPro_EventManager.NativeFieldInfoPtr_FONT_PROPERTY_EVENT, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000094 RID: 148
		// (get) Token: 0x060001F5 RID: 501 RVA: 0x0001109C File Offset: 0x0000F29C
		// (set) Token: 0x060001F6 RID: 502 RVA: 0x00002BBE File Offset: 0x00000DBE
		public unsafe static FastAction<bool, global::UnityEngine.Object> SPRITE_ASSET_PROPERTY_EVENT
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TMPro_EventManager.NativeFieldInfoPtr_SPRITE_ASSET_PROPERTY_EVENT, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FastAction<bool, global::UnityEngine.Object>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TMPro_EventManager.NativeFieldInfoPtr_SPRITE_ASSET_PROPERTY_EVENT, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000095 RID: 149
		// (get) Token: 0x060001F7 RID: 503 RVA: 0x000110C4 File Offset: 0x0000F2C4
		// (set) Token: 0x060001F8 RID: 504 RVA: 0x00002BD0 File Offset: 0x00000DD0
		public unsafe static FastAction<bool, global::UnityEngine.Object> TEXTMESHPRO_PROPERTY_EVENT
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TMPro_EventManager.NativeFieldInfoPtr_TEXTMESHPRO_PROPERTY_EVENT, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FastAction<bool, global::UnityEngine.Object>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TMPro_EventManager.NativeFieldInfoPtr_TEXTMESHPRO_PROPERTY_EVENT, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000096 RID: 150
		// (get) Token: 0x060001F9 RID: 505 RVA: 0x000110EC File Offset: 0x0000F2EC
		// (set) Token: 0x060001FA RID: 506 RVA: 0x00002BE2 File Offset: 0x00000DE2
		public unsafe static FastAction<GameObject, Material, Material> DRAG_AND_DROP_MATERIAL_EVENT
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TMPro_EventManager.NativeFieldInfoPtr_DRAG_AND_DROP_MATERIAL_EVENT, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FastAction<GameObject, Material, Material>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TMPro_EventManager.NativeFieldInfoPtr_DRAG_AND_DROP_MATERIAL_EVENT, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000097 RID: 151
		// (get) Token: 0x060001FB RID: 507 RVA: 0x00011114 File Offset: 0x0000F314
		// (set) Token: 0x060001FC RID: 508 RVA: 0x00002BF4 File Offset: 0x00000DF4
		public unsafe static FastAction<bool> TEXT_STYLE_PROPERTY_EVENT
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TMPro_EventManager.NativeFieldInfoPtr_TEXT_STYLE_PROPERTY_EVENT, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FastAction<bool>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TMPro_EventManager.NativeFieldInfoPtr_TEXT_STYLE_PROPERTY_EVENT, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000098 RID: 152
		// (get) Token: 0x060001FD RID: 509 RVA: 0x0001113C File Offset: 0x0000F33C
		// (set) Token: 0x060001FE RID: 510 RVA: 0x00002C06 File Offset: 0x00000E06
		public unsafe static FastAction<global::UnityEngine.Object> COLOR_GRADIENT_PROPERTY_EVENT
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TMPro_EventManager.NativeFieldInfoPtr_COLOR_GRADIENT_PROPERTY_EVENT, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FastAction<global::UnityEngine.Object>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TMPro_EventManager.NativeFieldInfoPtr_COLOR_GRADIENT_PROPERTY_EVENT, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000099 RID: 153
		// (get) Token: 0x060001FF RID: 511 RVA: 0x00011164 File Offset: 0x0000F364
		// (set) Token: 0x06000200 RID: 512 RVA: 0x00002C18 File Offset: 0x00000E18
		public unsafe static FastAction TMP_SETTINGS_PROPERTY_EVENT
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TMPro_EventManager.NativeFieldInfoPtr_TMP_SETTINGS_PROPERTY_EVENT, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FastAction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TMPro_EventManager.NativeFieldInfoPtr_TMP_SETTINGS_PROPERTY_EVENT, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700009A RID: 154
		// (get) Token: 0x06000201 RID: 513 RVA: 0x0001118C File Offset: 0x0000F38C
		// (set) Token: 0x06000202 RID: 514 RVA: 0x00002C2A File Offset: 0x00000E2A
		public unsafe static FastAction RESOURCE_LOAD_EVENT
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TMPro_EventManager.NativeFieldInfoPtr_RESOURCE_LOAD_EVENT, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FastAction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TMPro_EventManager.NativeFieldInfoPtr_RESOURCE_LOAD_EVENT, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700009B RID: 155
		// (get) Token: 0x06000203 RID: 515 RVA: 0x000111B4 File Offset: 0x0000F3B4
		// (set) Token: 0x06000204 RID: 516 RVA: 0x00002C3C File Offset: 0x00000E3C
		public unsafe static FastAction<bool, global::UnityEngine.Object> TEXTMESHPRO_UGUI_PROPERTY_EVENT
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TMPro_EventManager.NativeFieldInfoPtr_TEXTMESHPRO_UGUI_PROPERTY_EVENT, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FastAction<bool, global::UnityEngine.Object>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TMPro_EventManager.NativeFieldInfoPtr_TEXTMESHPRO_UGUI_PROPERTY_EVENT, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700009C RID: 156
		// (get) Token: 0x06000205 RID: 517 RVA: 0x000111DC File Offset: 0x0000F3DC
		// (set) Token: 0x06000206 RID: 518 RVA: 0x00002C4E File Offset: 0x00000E4E
		public unsafe static FastAction<global::UnityEngine.Object> TEXT_CHANGED_EVENT
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TMPro_EventManager.NativeFieldInfoPtr_TEXT_CHANGED_EVENT, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FastAction<global::UnityEngine.Object>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TMPro_EventManager.NativeFieldInfoPtr_TEXT_CHANGED_EVENT, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000163 RID: 355
		private static readonly IntPtr NativeFieldInfoPtr_COMPUTE_DT_EVENT;

		// Token: 0x04000164 RID: 356
		private static readonly IntPtr NativeFieldInfoPtr_MATERIAL_PROPERTY_EVENT;

		// Token: 0x04000165 RID: 357
		private static readonly IntPtr NativeFieldInfoPtr_FONT_PROPERTY_EVENT;

		// Token: 0x04000166 RID: 358
		private static readonly IntPtr NativeFieldInfoPtr_SPRITE_ASSET_PROPERTY_EVENT;

		// Token: 0x04000167 RID: 359
		private static readonly IntPtr NativeFieldInfoPtr_TEXTMESHPRO_PROPERTY_EVENT;

		// Token: 0x04000168 RID: 360
		private static readonly IntPtr NativeFieldInfoPtr_DRAG_AND_DROP_MATERIAL_EVENT;

		// Token: 0x04000169 RID: 361
		private static readonly IntPtr NativeFieldInfoPtr_TEXT_STYLE_PROPERTY_EVENT;

		// Token: 0x0400016A RID: 362
		private static readonly IntPtr NativeFieldInfoPtr_COLOR_GRADIENT_PROPERTY_EVENT;

		// Token: 0x0400016B RID: 363
		private static readonly IntPtr NativeFieldInfoPtr_TMP_SETTINGS_PROPERTY_EVENT;

		// Token: 0x0400016C RID: 364
		private static readonly IntPtr NativeFieldInfoPtr_RESOURCE_LOAD_EVENT;

		// Token: 0x0400016D RID: 365
		private static readonly IntPtr NativeFieldInfoPtr_TEXTMESHPRO_UGUI_PROPERTY_EVENT;

		// Token: 0x0400016E RID: 366
		private static readonly IntPtr NativeFieldInfoPtr_TEXT_CHANGED_EVENT;

		// Token: 0x0400016F RID: 367
		private static readonly IntPtr NativeMethodInfoPtr_ON_MATERIAL_PROPERTY_CHANGED_Public_Static_Void_Boolean_Material_0;

		// Token: 0x04000170 RID: 368
		private static readonly IntPtr NativeMethodInfoPtr_ON_FONT_PROPERTY_CHANGED_Public_Static_Void_Boolean_Object_0;

		// Token: 0x04000171 RID: 369
		private static readonly IntPtr NativeMethodInfoPtr_ON_SPRITE_ASSET_PROPERTY_CHANGED_Public_Static_Void_Boolean_Object_0;

		// Token: 0x04000172 RID: 370
		private static readonly IntPtr NativeMethodInfoPtr_ON_TEXTMESHPRO_PROPERTY_CHANGED_Public_Static_Void_Boolean_Object_0;

		// Token: 0x04000173 RID: 371
		private static readonly IntPtr NativeMethodInfoPtr_ON_DRAG_AND_DROP_MATERIAL_CHANGED_Public_Static_Void_GameObject_Material_Material_0;

		// Token: 0x04000174 RID: 372
		private static readonly IntPtr NativeMethodInfoPtr_ON_TEXT_STYLE_PROPERTY_CHANGED_Public_Static_Void_Boolean_0;

		// Token: 0x04000175 RID: 373
		private static readonly IntPtr NativeMethodInfoPtr_ON_COLOR_GRADIENT_PROPERTY_CHANGED_Public_Static_Void_Object_0;

		// Token: 0x04000176 RID: 374
		private static readonly IntPtr NativeMethodInfoPtr_ON_TEXT_CHANGED_Public_Static_Void_Object_0;

		// Token: 0x04000177 RID: 375
		private static readonly IntPtr NativeMethodInfoPtr_ON_TMP_SETTINGS_CHANGED_Public_Static_Void_0;

		// Token: 0x04000178 RID: 376
		private static readonly IntPtr NativeMethodInfoPtr_ON_RESOURCES_LOADED_Public_Static_Void_0;

		// Token: 0x04000179 RID: 377
		private static readonly IntPtr NativeMethodInfoPtr_ON_TEXTMESHPRO_UGUI_PROPERTY_CHANGED_Public_Static_Void_Boolean_Object_0;

		// Token: 0x0400017A RID: 378
		private static readonly IntPtr NativeMethodInfoPtr_ON_COMPUTE_DT_EVENT_Public_Static_Void_Object_Compute_DT_EventArgs_0;
	}
}
