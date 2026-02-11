using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.UI
{
	// Token: 0x0200000E RID: 14
	public static class DefaultControls : Object
	{
		// Token: 0x06000098 RID: 152 RVA: 0x00009750 File Offset: 0x00007950
		// Note: this type is marked as 'beforefieldinit'.
		static DefaultControls()
		{
			Il2CppClassPointerStore<DefaultControls>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UI.dll", "UnityEngine.UI", "DefaultControls");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DefaultControls>.NativeClassPtr);
			DefaultControls.NativeFieldInfoPtr_m_CurrentFactory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultControls>.NativeClassPtr, "m_CurrentFactory");
			DefaultControls.NativeFieldInfoPtr_kWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultControls>.NativeClassPtr, "kWidth");
			DefaultControls.NativeFieldInfoPtr_kThickHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultControls>.NativeClassPtr, "kThickHeight");
			DefaultControls.NativeFieldInfoPtr_kThinHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultControls>.NativeClassPtr, "kThinHeight");
			DefaultControls.NativeFieldInfoPtr_s_ThickElementSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultControls>.NativeClassPtr, "s_ThickElementSize");
			DefaultControls.NativeFieldInfoPtr_s_ThinElementSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultControls>.NativeClassPtr, "s_ThinElementSize");
			DefaultControls.NativeFieldInfoPtr_s_ImageElementSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultControls>.NativeClassPtr, "s_ImageElementSize");
			DefaultControls.NativeFieldInfoPtr_s_DefaultSelectableColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultControls>.NativeClassPtr, "s_DefaultSelectableColor");
			DefaultControls.NativeFieldInfoPtr_s_PanelColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultControls>.NativeClassPtr, "s_PanelColor");
			DefaultControls.NativeFieldInfoPtr_s_TextColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultControls>.NativeClassPtr, "s_TextColor");
			DefaultControls.NativeMethodInfoPtr_get_factory_Public_Static_get_IFactoryControls_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultControls>.NativeClassPtr, 100663387);
			DefaultControls.NativeMethodInfoPtr_CreateUIElementRoot_Private_Static_GameObject_String_Vector2_Il2CppReferenceArray_1_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultControls>.NativeClassPtr, 100663388);
			DefaultControls.NativeMethodInfoPtr_CreateUIObject_Private_Static_GameObject_String_GameObject_Il2CppReferenceArray_1_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultControls>.NativeClassPtr, 100663389);
			DefaultControls.NativeMethodInfoPtr_SetDefaultTextValues_Private_Static_Void_Text_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultControls>.NativeClassPtr, 100663390);
			DefaultControls.NativeMethodInfoPtr_SetDefaultColorTransitionValues_Private_Static_Void_Selectable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultControls>.NativeClassPtr, 100663391);
			DefaultControls.NativeMethodInfoPtr_SetParentAndAlign_Private_Static_Void_GameObject_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultControls>.NativeClassPtr, 100663392);
			DefaultControls.NativeMethodInfoPtr_SetLayerRecursively_Private_Static_Void_GameObject_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultControls>.NativeClassPtr, 100663393);
			DefaultControls.NativeMethodInfoPtr_CreatePanel_Public_Static_GameObject_Resources_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultControls>.NativeClassPtr, 100663394);
			DefaultControls.NativeMethodInfoPtr_CreateButton_Public_Static_GameObject_Resources_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultControls>.NativeClassPtr, 100663395);
			DefaultControls.NativeMethodInfoPtr_CreateText_Public_Static_GameObject_Resources_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultControls>.NativeClassPtr, 100663396);
			DefaultControls.NativeMethodInfoPtr_CreateImage_Public_Static_GameObject_Resources_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultControls>.NativeClassPtr, 100663397);
			DefaultControls.NativeMethodInfoPtr_CreateRawImage_Public_Static_GameObject_Resources_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultControls>.NativeClassPtr, 100663398);
			DefaultControls.NativeMethodInfoPtr_CreateSlider_Public_Static_GameObject_Resources_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultControls>.NativeClassPtr, 100663399);
			DefaultControls.NativeMethodInfoPtr_CreateScrollbar_Public_Static_GameObject_Resources_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultControls>.NativeClassPtr, 100663400);
			DefaultControls.NativeMethodInfoPtr_CreateToggle_Public_Static_GameObject_Resources_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultControls>.NativeClassPtr, 100663401);
			DefaultControls.NativeMethodInfoPtr_CreateInputField_Public_Static_GameObject_Resources_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultControls>.NativeClassPtr, 100663402);
			DefaultControls.NativeMethodInfoPtr_CreateDropdown_Public_Static_GameObject_Resources_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultControls>.NativeClassPtr, 100663403);
			DefaultControls.NativeMethodInfoPtr_CreateScrollView_Public_Static_GameObject_Resources_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultControls>.NativeClassPtr, 100663404);
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x06000099 RID: 153 RVA: 0x000099B0 File Offset: 0x00007BB0
		public unsafe static DefaultControls.IFactoryControls factory
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1081642, XrefRangeEnd = 1081646, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultControls.NativeMethodInfoPtr_get_factory_Public_Static_get_IFactoryControls_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DefaultControls.IFactoryControls>(intPtr3) : null;
			}
		}

		// Token: 0x0600009A RID: 154 RVA: 0x000099E4 File Offset: 0x00007BE4
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 1081660, RefRangeEnd = 1081671, XrefRangeStart = 1081646, XrefRangeEnd = 1081660, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static GameObject CreateUIElementRoot(string name, Vector2 size, [Optional] Il2CppReferenceArray<Type> components)
		{
			if (components == null)
			{
				components = new Il2CppReferenceArray<Type>(0L);
			}
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(components);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultControls.NativeMethodInfoPtr_CreateUIElementRoot_Private_Static_GameObject_String_Vector2_Il2CppReferenceArray_1_Type_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr3) : null;
		}

		// Token: 0x0600009B RID: 155 RVA: 0x00009A58 File Offset: 0x00007C58
		[CallerCount(24)]
		[CachedScanResults(RefRangeStart = 1081682, RefRangeEnd = 1081706, XrefRangeStart = 1081671, XrefRangeEnd = 1081682, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static GameObject CreateUIObject(string name, GameObject parent, [Optional] Il2CppReferenceArray<Type> components)
		{
			if (components == null)
			{
				components = new Il2CppReferenceArray<Type>(0L);
			}
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parent);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(components);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultControls.NativeMethodInfoPtr_CreateUIObject_Private_Static_GameObject_String_GameObject_Il2CppReferenceArray_1_Type_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr3) : null;
		}

		// Token: 0x0600009C RID: 156 RVA: 0x00009AD0 File Offset: 0x00007CD0
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1081716, RefRangeEnd = 1081722, XrefRangeStart = 1081706, XrefRangeEnd = 1081716, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetDefaultTextValues(Text lbl)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(lbl);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultControls.NativeMethodInfoPtr_SetDefaultTextValues_Private_Static_Void_Text_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600009D RID: 157 RVA: 0x00009B08 File Offset: 0x00007D08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1081722, XrefRangeEnd = 1081725, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetDefaultColorTransitionValues(Selectable slider)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(slider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultControls.NativeMethodInfoPtr_SetDefaultColorTransitionValues_Private_Static_Void_Selectable_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600009E RID: 158 RVA: 0x00009B40 File Offset: 0x00007D40
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1081737, RefRangeEnd = 1081741, XrefRangeStart = 1081725, XrefRangeEnd = 1081737, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetParentAndAlign(GameObject child, GameObject parent)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(child);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parent);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultControls.NativeMethodInfoPtr_SetParentAndAlign_Private_Static_Void_GameObject_GameObject_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600009F RID: 159 RVA: 0x00009B88 File Offset: 0x00007D88
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1081751, RefRangeEnd = 1081753, XrefRangeStart = 1081741, XrefRangeEnd = 1081751, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetLayerRecursively(GameObject go, int layer)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(go);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref layer;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultControls.NativeMethodInfoPtr_SetLayerRecursively_Private_Static_Void_GameObject_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000A0 RID: 160 RVA: 0x00009BCC File Offset: 0x00007DCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1081753, XrefRangeEnd = 1081794, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static GameObject CreatePanel(DefaultControls.Resources resources)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(resources));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultControls.NativeMethodInfoPtr_CreatePanel_Public_Static_GameObject_Resources_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr3) : null;
			}
		}

		// Token: 0x060000A1 RID: 161 RVA: 0x00009C18 File Offset: 0x00007E18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1081794, XrefRangeEnd = 1081860, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static GameObject CreateButton(DefaultControls.Resources resources)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(resources));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultControls.NativeMethodInfoPtr_CreateButton_Public_Static_GameObject_Resources_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr3) : null;
			}
		}

		// Token: 0x060000A2 RID: 162 RVA: 0x00009C64 File Offset: 0x00007E64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1081860, XrefRangeEnd = 1081884, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static GameObject CreateText(DefaultControls.Resources resources)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(resources));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultControls.NativeMethodInfoPtr_CreateText_Public_Static_GameObject_Resources_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr3) : null;
			}
		}

		// Token: 0x060000A3 RID: 163 RVA: 0x00009CB0 File Offset: 0x00007EB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1081884, XrefRangeEnd = 1081906, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static GameObject CreateImage(DefaultControls.Resources resources)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(resources));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultControls.NativeMethodInfoPtr_CreateImage_Public_Static_GameObject_Resources_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr3) : null;
			}
		}

		// Token: 0x060000A4 RID: 164 RVA: 0x00009CFC File Offset: 0x00007EFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1081906, XrefRangeEnd = 1081928, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static GameObject CreateRawImage(DefaultControls.Resources resources)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(resources));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultControls.NativeMethodInfoPtr_CreateRawImage_Public_Static_GameObject_Resources_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr3) : null;
			}
		}

		// Token: 0x060000A5 RID: 165 RVA: 0x00009D48 File Offset: 0x00007F48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1081928, XrefRangeEnd = 1082049, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static GameObject CreateSlider(DefaultControls.Resources resources)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(resources));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultControls.NativeMethodInfoPtr_CreateSlider_Public_Static_GameObject_Resources_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr3) : null;
			}
		}

		// Token: 0x060000A6 RID: 166 RVA: 0x00009D94 File Offset: 0x00007F94
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1082127, RefRangeEnd = 1082130, XrefRangeStart = 1082049, XrefRangeEnd = 1082127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static GameObject CreateScrollbar(DefaultControls.Resources resources)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(resources));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultControls.NativeMethodInfoPtr_CreateScrollbar_Public_Static_GameObject_Resources_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr3) : null;
			}
		}

		// Token: 0x060000A7 RID: 167 RVA: 0x00009DE0 File Offset: 0x00007FE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1082130, XrefRangeEnd = 1082223, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static GameObject CreateToggle(DefaultControls.Resources resources)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(resources));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultControls.NativeMethodInfoPtr_CreateToggle_Public_Static_GameObject_Resources_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr3) : null;
			}
		}

		// Token: 0x060000A8 RID: 168 RVA: 0x00009E2C File Offset: 0x0000802C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1082223, XrefRangeEnd = 1082320, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static GameObject CreateInputField(DefaultControls.Resources resources)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(resources));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultControls.NativeMethodInfoPtr_CreateInputField_Public_Static_GameObject_Resources_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr3) : null;
			}
		}

		// Token: 0x060000A9 RID: 169 RVA: 0x00009E78 File Offset: 0x00008078
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1082320, XrefRangeEnd = 1082637, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static GameObject CreateDropdown(DefaultControls.Resources resources)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(resources));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultControls.NativeMethodInfoPtr_CreateDropdown_Public_Static_GameObject_Resources_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr3) : null;
			}
		}

		// Token: 0x060000AA RID: 170 RVA: 0x00009EC4 File Offset: 0x000080C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1082637, XrefRangeEnd = 1082783, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static GameObject CreateScrollView(DefaultControls.Resources resources)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(resources));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultControls.NativeMethodInfoPtr_CreateScrollView_Public_Static_GameObject_Resources_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr3) : null;
			}
		}

		// Token: 0x060000AB RID: 171 RVA: 0x0000237E File Offset: 0x0000057E
		public static GameObject CreateUIElementRoot(string name, Vector2 size, params Type[] components)
		{
			return DefaultControls.CreateUIElementRoot(name, size, new Il2CppReferenceArray<Type>(components));
		}

		// Token: 0x060000AC RID: 172 RVA: 0x0000238D File Offset: 0x0000058D
		public static GameObject CreateUIObject(string name, GameObject parent, params Type[] components)
		{
			return DefaultControls.CreateUIObject(name, parent, new Il2CppReferenceArray<Type>(components));
		}

		// Token: 0x060000AD RID: 173 RVA: 0x0000239C File Offset: 0x0000059C
		public DefaultControls(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x060000AE RID: 174 RVA: 0x00009F10 File Offset: 0x00008110
		// (set) Token: 0x060000AF RID: 175 RVA: 0x000023A5 File Offset: 0x000005A5
		public unsafe static DefaultControls.IFactoryControls m_CurrentFactory
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DefaultControls.NativeFieldInfoPtr_m_CurrentFactory, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DefaultControls.IFactoryControls>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DefaultControls.NativeFieldInfoPtr_m_CurrentFactory, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x060000B0 RID: 176 RVA: 0x00009F38 File Offset: 0x00008138
		// (set) Token: 0x060000B1 RID: 177 RVA: 0x000023B7 File Offset: 0x000005B7
		public unsafe static float kWidth
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(DefaultControls.NativeFieldInfoPtr_kWidth, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DefaultControls.NativeFieldInfoPtr_kWidth, (void*)(&value));
			}
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x060000B2 RID: 178 RVA: 0x00009F54 File Offset: 0x00008154
		// (set) Token: 0x060000B3 RID: 179 RVA: 0x000023C5 File Offset: 0x000005C5
		public unsafe static float kThickHeight
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(DefaultControls.NativeFieldInfoPtr_kThickHeight, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DefaultControls.NativeFieldInfoPtr_kThickHeight, (void*)(&value));
			}
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x060000B4 RID: 180 RVA: 0x00009F70 File Offset: 0x00008170
		// (set) Token: 0x060000B5 RID: 181 RVA: 0x000023D3 File Offset: 0x000005D3
		public unsafe static float kThinHeight
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(DefaultControls.NativeFieldInfoPtr_kThinHeight, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DefaultControls.NativeFieldInfoPtr_kThinHeight, (void*)(&value));
			}
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x060000B6 RID: 182 RVA: 0x00009F8C File Offset: 0x0000818C
		// (set) Token: 0x060000B7 RID: 183 RVA: 0x000023E1 File Offset: 0x000005E1
		public unsafe static Vector2 s_ThickElementSize
		{
			get
			{
				Vector2 vector;
				IL2CPP.il2cpp_field_static_get_value(DefaultControls.NativeFieldInfoPtr_s_ThickElementSize, (void*)(&vector));
				return vector;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DefaultControls.NativeFieldInfoPtr_s_ThickElementSize, (void*)(&value));
			}
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x060000B8 RID: 184 RVA: 0x00009FA8 File Offset: 0x000081A8
		// (set) Token: 0x060000B9 RID: 185 RVA: 0x000023EF File Offset: 0x000005EF
		public unsafe static Vector2 s_ThinElementSize
		{
			get
			{
				Vector2 vector;
				IL2CPP.il2cpp_field_static_get_value(DefaultControls.NativeFieldInfoPtr_s_ThinElementSize, (void*)(&vector));
				return vector;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DefaultControls.NativeFieldInfoPtr_s_ThinElementSize, (void*)(&value));
			}
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x060000BA RID: 186 RVA: 0x00009FC4 File Offset: 0x000081C4
		// (set) Token: 0x060000BB RID: 187 RVA: 0x000023FD File Offset: 0x000005FD
		public unsafe static Vector2 s_ImageElementSize
		{
			get
			{
				Vector2 vector;
				IL2CPP.il2cpp_field_static_get_value(DefaultControls.NativeFieldInfoPtr_s_ImageElementSize, (void*)(&vector));
				return vector;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DefaultControls.NativeFieldInfoPtr_s_ImageElementSize, (void*)(&value));
			}
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x060000BC RID: 188 RVA: 0x00009FE0 File Offset: 0x000081E0
		// (set) Token: 0x060000BD RID: 189 RVA: 0x0000240B File Offset: 0x0000060B
		public unsafe static Color s_DefaultSelectableColor
		{
			get
			{
				Color color;
				IL2CPP.il2cpp_field_static_get_value(DefaultControls.NativeFieldInfoPtr_s_DefaultSelectableColor, (void*)(&color));
				return color;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DefaultControls.NativeFieldInfoPtr_s_DefaultSelectableColor, (void*)(&value));
			}
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x060000BE RID: 190 RVA: 0x00009FFC File Offset: 0x000081FC
		// (set) Token: 0x060000BF RID: 191 RVA: 0x00002419 File Offset: 0x00000619
		public unsafe static Color s_PanelColor
		{
			get
			{
				Color color;
				IL2CPP.il2cpp_field_static_get_value(DefaultControls.NativeFieldInfoPtr_s_PanelColor, (void*)(&color));
				return color;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DefaultControls.NativeFieldInfoPtr_s_PanelColor, (void*)(&value));
			}
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x060000C0 RID: 192 RVA: 0x0000A018 File Offset: 0x00008218
		// (set) Token: 0x060000C1 RID: 193 RVA: 0x00002427 File Offset: 0x00000627
		public unsafe static Color s_TextColor
		{
			get
			{
				Color color;
				IL2CPP.il2cpp_field_static_get_value(DefaultControls.NativeFieldInfoPtr_s_TextColor, (void*)(&color));
				return color;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DefaultControls.NativeFieldInfoPtr_s_TextColor, (void*)(&value));
			}
		}

		// Token: 0x0400007F RID: 127
		private static readonly IntPtr NativeFieldInfoPtr_m_CurrentFactory;

		// Token: 0x04000080 RID: 128
		private static readonly IntPtr NativeFieldInfoPtr_kWidth;

		// Token: 0x04000081 RID: 129
		private static readonly IntPtr NativeFieldInfoPtr_kThickHeight;

		// Token: 0x04000082 RID: 130
		private static readonly IntPtr NativeFieldInfoPtr_kThinHeight;

		// Token: 0x04000083 RID: 131
		private static readonly IntPtr NativeFieldInfoPtr_s_ThickElementSize;

		// Token: 0x04000084 RID: 132
		private static readonly IntPtr NativeFieldInfoPtr_s_ThinElementSize;

		// Token: 0x04000085 RID: 133
		private static readonly IntPtr NativeFieldInfoPtr_s_ImageElementSize;

		// Token: 0x04000086 RID: 134
		private static readonly IntPtr NativeFieldInfoPtr_s_DefaultSelectableColor;

		// Token: 0x04000087 RID: 135
		private static readonly IntPtr NativeFieldInfoPtr_s_PanelColor;

		// Token: 0x04000088 RID: 136
		private static readonly IntPtr NativeFieldInfoPtr_s_TextColor;

		// Token: 0x04000089 RID: 137
		private static readonly IntPtr NativeMethodInfoPtr_get_factory_Public_Static_get_IFactoryControls_0;

		// Token: 0x0400008A RID: 138
		private static readonly IntPtr NativeMethodInfoPtr_CreateUIElementRoot_Private_Static_GameObject_String_Vector2_Il2CppReferenceArray_1_Type_0;

		// Token: 0x0400008B RID: 139
		private static readonly IntPtr NativeMethodInfoPtr_CreateUIObject_Private_Static_GameObject_String_GameObject_Il2CppReferenceArray_1_Type_0;

		// Token: 0x0400008C RID: 140
		private static readonly IntPtr NativeMethodInfoPtr_SetDefaultTextValues_Private_Static_Void_Text_0;

		// Token: 0x0400008D RID: 141
		private static readonly IntPtr NativeMethodInfoPtr_SetDefaultColorTransitionValues_Private_Static_Void_Selectable_0;

		// Token: 0x0400008E RID: 142
		private static readonly IntPtr NativeMethodInfoPtr_SetParentAndAlign_Private_Static_Void_GameObject_GameObject_0;

		// Token: 0x0400008F RID: 143
		private static readonly IntPtr NativeMethodInfoPtr_SetLayerRecursively_Private_Static_Void_GameObject_Int32_0;

		// Token: 0x04000090 RID: 144
		private static readonly IntPtr NativeMethodInfoPtr_CreatePanel_Public_Static_GameObject_Resources_0;

		// Token: 0x04000091 RID: 145
		private static readonly IntPtr NativeMethodInfoPtr_CreateButton_Public_Static_GameObject_Resources_0;

		// Token: 0x04000092 RID: 146
		private static readonly IntPtr NativeMethodInfoPtr_CreateText_Public_Static_GameObject_Resources_0;

		// Token: 0x04000093 RID: 147
		private static readonly IntPtr NativeMethodInfoPtr_CreateImage_Public_Static_GameObject_Resources_0;

		// Token: 0x04000094 RID: 148
		private static readonly IntPtr NativeMethodInfoPtr_CreateRawImage_Public_Static_GameObject_Resources_0;

		// Token: 0x04000095 RID: 149
		private static readonly IntPtr NativeMethodInfoPtr_CreateSlider_Public_Static_GameObject_Resources_0;

		// Token: 0x04000096 RID: 150
		private static readonly IntPtr NativeMethodInfoPtr_CreateScrollbar_Public_Static_GameObject_Resources_0;

		// Token: 0x04000097 RID: 151
		private static readonly IntPtr NativeMethodInfoPtr_CreateToggle_Public_Static_GameObject_Resources_0;

		// Token: 0x04000098 RID: 152
		private static readonly IntPtr NativeMethodInfoPtr_CreateInputField_Public_Static_GameObject_Resources_0;

		// Token: 0x04000099 RID: 153
		private static readonly IntPtr NativeMethodInfoPtr_CreateDropdown_Public_Static_GameObject_Resources_0;

		// Token: 0x0400009A RID: 154
		private static readonly IntPtr NativeMethodInfoPtr_CreateScrollView_Public_Static_GameObject_Resources_0;

		// Token: 0x0200007B RID: 123
		public class IFactoryControls : Il2CppObjectBase
		{
			// Token: 0x06000BD5 RID: 3029 RVA: 0x00006487 File Offset: 0x00004687
			// Note: this type is marked as 'beforefieldinit'.
			static IFactoryControls()
			{
				Il2CppClassPointerStore<DefaultControls.IFactoryControls>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DefaultControls>.NativeClassPtr, "IFactoryControls");
				DefaultControls.IFactoryControls.NativeMethodInfoPtr_CreateGameObject_Public_Abstract_Virtual_New_GameObject_String_Il2CppReferenceArray_1_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultControls.IFactoryControls>.NativeClassPtr, 100663406);
			}

			// Token: 0x06000BD6 RID: 3030 RVA: 0x000348E8 File Offset: 0x00032AE8
			[CallerCount(0)]
			public unsafe virtual GameObject CreateGameObject(string name, [Optional] Il2CppReferenceArray<Type> components)
			{
				if (components == null)
				{
					components = new Il2CppReferenceArray<Type>(0L);
				}
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(components);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DefaultControls.IFactoryControls.NativeMethodInfoPtr_CreateGameObject_Public_Abstract_Virtual_New_GameObject_String_Il2CppReferenceArray_1_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr3) : null;
			}

			// Token: 0x06000BD7 RID: 3031 RVA: 0x000064B1 File Offset: 0x000046B1
			public virtual GameObject CreateGameObject(string name, params Type[] components)
			{
				return this.CreateGameObject(name, new Il2CppReferenceArray<Type>(components));
			}

			// Token: 0x06000BD8 RID: 3032 RVA: 0x000064C0 File Offset: 0x000046C0
			public IFactoryControls(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x040008EA RID: 2282
			private static readonly IntPtr NativeMethodInfoPtr_CreateGameObject_Public_Abstract_Virtual_New_GameObject_String_Il2CppReferenceArray_1_Type_0;
		}

		// Token: 0x0200007C RID: 124
		public class DefaultRuntimeFactory : Object
		{
			// Token: 0x06000BD9 RID: 3033 RVA: 0x00034964 File Offset: 0x00032B64
			// Note: this type is marked as 'beforefieldinit'.
			static DefaultRuntimeFactory()
			{
				Il2CppClassPointerStore<DefaultControls.DefaultRuntimeFactory>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DefaultControls>.NativeClassPtr, "DefaultRuntimeFactory");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DefaultControls.DefaultRuntimeFactory>.NativeClassPtr);
				DefaultControls.DefaultRuntimeFactory.NativeFieldInfoPtr_Default = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultControls.DefaultRuntimeFactory>.NativeClassPtr, "Default");
				DefaultControls.DefaultRuntimeFactory.NativeMethodInfoPtr_CreateGameObject_Public_Virtual_Final_New_GameObject_String_Il2CppReferenceArray_1_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultControls.DefaultRuntimeFactory>.NativeClassPtr, 100663407);
				DefaultControls.DefaultRuntimeFactory.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultControls.DefaultRuntimeFactory>.NativeClassPtr, 100663408);
			}

			// Token: 0x06000BDA RID: 3034 RVA: 0x000349CC File Offset: 0x00032BCC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1081638, XrefRangeEnd = 1081642, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual GameObject CreateGameObject(string name, [Optional] Il2CppReferenceArray<Type> components)
			{
				if (components == null)
				{
					components = new Il2CppReferenceArray<Type>(0L);
				}
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(components);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultControls.DefaultRuntimeFactory.NativeMethodInfoPtr_CreateGameObject_Public_Virtual_Final_New_GameObject_String_Il2CppReferenceArray_1_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr3) : null;
			}

			// Token: 0x06000BDB RID: 3035 RVA: 0x00034A3C File Offset: 0x00032C3C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe DefaultRuntimeFactory()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DefaultControls.DefaultRuntimeFactory>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultControls.DefaultRuntimeFactory.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000BDC RID: 3036 RVA: 0x000064C9 File Offset: 0x000046C9
			public virtual GameObject CreateGameObject(string name, params Type[] components)
			{
				return this.CreateGameObject(name, new Il2CppReferenceArray<Type>(components));
			}

			// Token: 0x06000BDD RID: 3037 RVA: 0x000064D8 File Offset: 0x000046D8
			public DefaultRuntimeFactory(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170003F4 RID: 1012
			// (get) Token: 0x06000BDE RID: 3038 RVA: 0x00034A78 File Offset: 0x00032C78
			// (set) Token: 0x06000BDF RID: 3039 RVA: 0x000064E1 File Offset: 0x000046E1
			public unsafe static DefaultControls.IFactoryControls Default
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DefaultControls.DefaultRuntimeFactory.NativeFieldInfoPtr_Default, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DefaultControls.IFactoryControls>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DefaultControls.DefaultRuntimeFactory.NativeFieldInfoPtr_Default, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040008EB RID: 2283
			private static readonly IntPtr NativeFieldInfoPtr_Default;

			// Token: 0x040008EC RID: 2284
			private static readonly IntPtr NativeMethodInfoPtr_CreateGameObject_Public_Virtual_Final_New_GameObject_String_Il2CppReferenceArray_1_Type_0;

			// Token: 0x040008ED RID: 2285
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x0200007D RID: 125
		public sealed class Resources : ValueType
		{
			// Token: 0x06000BE0 RID: 3040 RVA: 0x00034AA0 File Offset: 0x00032CA0
			// Note: this type is marked as 'beforefieldinit'.
			static Resources()
			{
				Il2CppClassPointerStore<DefaultControls.Resources>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DefaultControls>.NativeClassPtr, "Resources");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DefaultControls.Resources>.NativeClassPtr);
				DefaultControls.Resources.NativeFieldInfoPtr_standard = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultControls.Resources>.NativeClassPtr, "standard");
				DefaultControls.Resources.NativeFieldInfoPtr_background = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultControls.Resources>.NativeClassPtr, "background");
				DefaultControls.Resources.NativeFieldInfoPtr_inputField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultControls.Resources>.NativeClassPtr, "inputField");
				DefaultControls.Resources.NativeFieldInfoPtr_knob = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultControls.Resources>.NativeClassPtr, "knob");
				DefaultControls.Resources.NativeFieldInfoPtr_checkmark = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultControls.Resources>.NativeClassPtr, "checkmark");
				DefaultControls.Resources.NativeFieldInfoPtr_dropdown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultControls.Resources>.NativeClassPtr, "dropdown");
				DefaultControls.Resources.NativeFieldInfoPtr_mask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultControls.Resources>.NativeClassPtr, "mask");
			}

			// Token: 0x06000BE1 RID: 3041 RVA: 0x000064F3 File Offset: 0x000046F3
			public Resources(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06000BE2 RID: 3042 RVA: 0x000064FC File Offset: 0x000046FC
			public Resources()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DefaultControls.Resources>.NativeClassPtr))
			{
			}

			// Token: 0x170003F5 RID: 1013
			// (get) Token: 0x06000BE3 RID: 3043 RVA: 0x00034B58 File Offset: 0x00032D58
			// (set) Token: 0x06000BE4 RID: 3044 RVA: 0x0000650E File Offset: 0x0000470E
			public unsafe Sprite standard
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultControls.Resources.NativeFieldInfoPtr_standard);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultControls.Resources.NativeFieldInfoPtr_standard), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170003F6 RID: 1014
			// (get) Token: 0x06000BE5 RID: 3045 RVA: 0x00034B88 File Offset: 0x00032D88
			// (set) Token: 0x06000BE6 RID: 3046 RVA: 0x0000652D File Offset: 0x0000472D
			public unsafe Sprite background
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultControls.Resources.NativeFieldInfoPtr_background);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultControls.Resources.NativeFieldInfoPtr_background), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170003F7 RID: 1015
			// (get) Token: 0x06000BE7 RID: 3047 RVA: 0x00034BB8 File Offset: 0x00032DB8
			// (set) Token: 0x06000BE8 RID: 3048 RVA: 0x0000654C File Offset: 0x0000474C
			public unsafe Sprite inputField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultControls.Resources.NativeFieldInfoPtr_inputField);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultControls.Resources.NativeFieldInfoPtr_inputField), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170003F8 RID: 1016
			// (get) Token: 0x06000BE9 RID: 3049 RVA: 0x00034BE8 File Offset: 0x00032DE8
			// (set) Token: 0x06000BEA RID: 3050 RVA: 0x0000656B File Offset: 0x0000476B
			public unsafe Sprite knob
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultControls.Resources.NativeFieldInfoPtr_knob);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultControls.Resources.NativeFieldInfoPtr_knob), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170003F9 RID: 1017
			// (get) Token: 0x06000BEB RID: 3051 RVA: 0x00034C18 File Offset: 0x00032E18
			// (set) Token: 0x06000BEC RID: 3052 RVA: 0x0000658A File Offset: 0x0000478A
			public unsafe Sprite checkmark
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultControls.Resources.NativeFieldInfoPtr_checkmark);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultControls.Resources.NativeFieldInfoPtr_checkmark), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170003FA RID: 1018
			// (get) Token: 0x06000BED RID: 3053 RVA: 0x00034C48 File Offset: 0x00032E48
			// (set) Token: 0x06000BEE RID: 3054 RVA: 0x000065A9 File Offset: 0x000047A9
			public unsafe Sprite dropdown
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultControls.Resources.NativeFieldInfoPtr_dropdown);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultControls.Resources.NativeFieldInfoPtr_dropdown), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170003FB RID: 1019
			// (get) Token: 0x06000BEF RID: 3055 RVA: 0x00034C78 File Offset: 0x00032E78
			// (set) Token: 0x06000BF0 RID: 3056 RVA: 0x000065C8 File Offset: 0x000047C8
			public unsafe Sprite mask
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultControls.Resources.NativeFieldInfoPtr_mask);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultControls.Resources.NativeFieldInfoPtr_mask), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040008EE RID: 2286
			private static readonly IntPtr NativeFieldInfoPtr_standard;

			// Token: 0x040008EF RID: 2287
			private static readonly IntPtr NativeFieldInfoPtr_background;

			// Token: 0x040008F0 RID: 2288
			private static readonly IntPtr NativeFieldInfoPtr_inputField;

			// Token: 0x040008F1 RID: 2289
			private static readonly IntPtr NativeFieldInfoPtr_knob;

			// Token: 0x040008F2 RID: 2290
			private static readonly IntPtr NativeFieldInfoPtr_checkmark;

			// Token: 0x040008F3 RID: 2291
			private static readonly IntPtr NativeFieldInfoPtr_dropdown;

			// Token: 0x040008F4 RID: 2292
			private static readonly IntPtr NativeFieldInfoPtr_mask;
		}
	}
}
