using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;
using UnityEngine.UI;

namespace TMPro
{
	// Token: 0x0200002C RID: 44
	public static class TMP_DefaultControls : global::Il2CppSystem.Object
	{
		// Token: 0x060003E0 RID: 992 RVA: 0x00016318 File Offset: 0x00014518
		// Note: this type is marked as 'beforefieldinit'.
		static TMP_DefaultControls()
		{
			Il2CppClassPointerStore<TMP_DefaultControls>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.TextMeshPro.dll", "TMPro", "TMP_DefaultControls");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TMP_DefaultControls>.NativeClassPtr);
			TMP_DefaultControls.NativeFieldInfoPtr_kWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_DefaultControls>.NativeClassPtr, "kWidth");
			TMP_DefaultControls.NativeFieldInfoPtr_kThickHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_DefaultControls>.NativeClassPtr, "kThickHeight");
			TMP_DefaultControls.NativeFieldInfoPtr_kThinHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_DefaultControls>.NativeClassPtr, "kThinHeight");
			TMP_DefaultControls.NativeFieldInfoPtr_s_TextElementSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_DefaultControls>.NativeClassPtr, "s_TextElementSize");
			TMP_DefaultControls.NativeFieldInfoPtr_s_ThickElementSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_DefaultControls>.NativeClassPtr, "s_ThickElementSize");
			TMP_DefaultControls.NativeFieldInfoPtr_s_ThinElementSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_DefaultControls>.NativeClassPtr, "s_ThinElementSize");
			TMP_DefaultControls.NativeFieldInfoPtr_s_DefaultSelectableColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_DefaultControls>.NativeClassPtr, "s_DefaultSelectableColor");
			TMP_DefaultControls.NativeFieldInfoPtr_s_TextColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_DefaultControls>.NativeClassPtr, "s_TextColor");
			TMP_DefaultControls.NativeMethodInfoPtr_CreateUIElementRoot_Private_Static_GameObject_String_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_DefaultControls>.NativeClassPtr, 100663669);
			TMP_DefaultControls.NativeMethodInfoPtr_CreateUIObject_Private_Static_GameObject_String_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_DefaultControls>.NativeClassPtr, 100663670);
			TMP_DefaultControls.NativeMethodInfoPtr_SetDefaultTextValues_Private_Static_Void_TMP_Text_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_DefaultControls>.NativeClassPtr, 100663671);
			TMP_DefaultControls.NativeMethodInfoPtr_SetDefaultColorTransitionValues_Private_Static_Void_Selectable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_DefaultControls>.NativeClassPtr, 100663672);
			TMP_DefaultControls.NativeMethodInfoPtr_SetParentAndAlign_Private_Static_Void_GameObject_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_DefaultControls>.NativeClassPtr, 100663673);
			TMP_DefaultControls.NativeMethodInfoPtr_SetLayerRecursively_Private_Static_Void_GameObject_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_DefaultControls>.NativeClassPtr, 100663674);
			TMP_DefaultControls.NativeMethodInfoPtr_CreateScrollbar_Public_Static_GameObject_Resources_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_DefaultControls>.NativeClassPtr, 100663675);
			TMP_DefaultControls.NativeMethodInfoPtr_CreateButton_Public_Static_GameObject_Resources_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_DefaultControls>.NativeClassPtr, 100663676);
			TMP_DefaultControls.NativeMethodInfoPtr_CreateText_Public_Static_GameObject_Resources_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_DefaultControls>.NativeClassPtr, 100663677);
			TMP_DefaultControls.NativeMethodInfoPtr_CreateInputField_Public_Static_GameObject_Resources_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_DefaultControls>.NativeClassPtr, 100663678);
			TMP_DefaultControls.NativeMethodInfoPtr_CreateDropdown_Public_Static_GameObject_Resources_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_DefaultControls>.NativeClassPtr, 100663679);
		}

		// Token: 0x060003E1 RID: 993 RVA: 0x000164C4 File Offset: 0x000146C4
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1038202, RefRangeEnd = 1038207, XrefRangeStart = 1038194, XrefRangeEnd = 1038202, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static GameObject CreateUIElementRoot(string name, Vector2 size)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_DefaultControls.NativeMethodInfoPtr_CreateUIElementRoot_Private_Static_GameObject_String_Vector2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr3) : null;
		}

		// Token: 0x060003E2 RID: 994 RVA: 0x00016518 File Offset: 0x00014718
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 1038218, RefRangeEnd = 1038232, XrefRangeStart = 1038207, XrefRangeEnd = 1038218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static GameObject CreateUIObject(string name, GameObject parent)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parent);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_DefaultControls.NativeMethodInfoPtr_CreateUIObject_Private_Static_GameObject_String_GameObject_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr3) : null;
		}

		// Token: 0x060003E3 RID: 995 RVA: 0x00016570 File Offset: 0x00014770
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1038232, XrefRangeEnd = 1038238, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetDefaultTextValues(TMP_Text lbl)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(lbl);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_DefaultControls.NativeMethodInfoPtr_SetDefaultTextValues_Private_Static_Void_TMP_Text_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060003E4 RID: 996 RVA: 0x000165A8 File Offset: 0x000147A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1038238, XrefRangeEnd = 1038241, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetDefaultColorTransitionValues(Selectable slider)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(slider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_DefaultControls.NativeMethodInfoPtr_SetDefaultColorTransitionValues_Private_Static_Void_Selectable_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060003E5 RID: 997 RVA: 0x000165E0 File Offset: 0x000147E0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1038253, RefRangeEnd = 1038256, XrefRangeStart = 1038241, XrefRangeEnd = 1038253, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_DefaultControls.NativeMethodInfoPtr_SetParentAndAlign_Private_Static_Void_GameObject_GameObject_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003E6 RID: 998 RVA: 0x00016628 File Offset: 0x00014828
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1038266, RefRangeEnd = 1038268, XrefRangeStart = 1038256, XrefRangeEnd = 1038266, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_DefaultControls.NativeMethodInfoPtr_SetLayerRecursively_Private_Static_Void_GameObject_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003E7 RID: 999 RVA: 0x0001666C File Offset: 0x0001486C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1038313, RefRangeEnd = 1038314, XrefRangeStart = 1038268, XrefRangeEnd = 1038313, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static GameObject CreateScrollbar(TMP_DefaultControls.Resources resources)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(resources));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_DefaultControls.NativeMethodInfoPtr_CreateScrollbar_Public_Static_GameObject_Resources_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr3) : null;
			}
		}

		// Token: 0x060003E8 RID: 1000 RVA: 0x000166B8 File Offset: 0x000148B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1038314, XrefRangeEnd = 1038365, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static GameObject CreateButton(TMP_DefaultControls.Resources resources)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(resources));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_DefaultControls.NativeMethodInfoPtr_CreateButton_Public_Static_GameObject_Resources_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr3) : null;
			}
		}

		// Token: 0x060003E9 RID: 1001 RVA: 0x00016704 File Offset: 0x00014904
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1038365, XrefRangeEnd = 1038375, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static GameObject CreateText(TMP_DefaultControls.Resources resources)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(resources));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_DefaultControls.NativeMethodInfoPtr_CreateText_Public_Static_GameObject_Resources_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr3) : null;
			}
		}

		// Token: 0x060003EA RID: 1002 RVA: 0x00016750 File Offset: 0x00014950
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1038375, XrefRangeEnd = 1038496, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static GameObject CreateInputField(TMP_DefaultControls.Resources resources)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(resources));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_DefaultControls.NativeMethodInfoPtr_CreateInputField_Public_Static_GameObject_Resources_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr3) : null;
			}
		}

		// Token: 0x060003EB RID: 1003 RVA: 0x0001679C File Offset: 0x0001499C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1038496, XrefRangeEnd = 1038733, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static GameObject CreateDropdown(TMP_DefaultControls.Resources resources)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(resources));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_DefaultControls.NativeMethodInfoPtr_CreateDropdown_Public_Static_GameObject_Resources_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr3) : null;
			}
		}

		// Token: 0x060003EC RID: 1004 RVA: 0x00003F5F File Offset: 0x0000215F
		public TMP_DefaultControls(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700014D RID: 333
		// (get) Token: 0x060003ED RID: 1005 RVA: 0x000167E8 File Offset: 0x000149E8
		// (set) Token: 0x060003EE RID: 1006 RVA: 0x00003F68 File Offset: 0x00002168
		public unsafe static float kWidth
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(TMP_DefaultControls.NativeFieldInfoPtr_kWidth, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TMP_DefaultControls.NativeFieldInfoPtr_kWidth, (void*)(&value));
			}
		}

		// Token: 0x1700014E RID: 334
		// (get) Token: 0x060003EF RID: 1007 RVA: 0x00016804 File Offset: 0x00014A04
		// (set) Token: 0x060003F0 RID: 1008 RVA: 0x00003F76 File Offset: 0x00002176
		public unsafe static float kThickHeight
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(TMP_DefaultControls.NativeFieldInfoPtr_kThickHeight, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TMP_DefaultControls.NativeFieldInfoPtr_kThickHeight, (void*)(&value));
			}
		}

		// Token: 0x1700014F RID: 335
		// (get) Token: 0x060003F1 RID: 1009 RVA: 0x00016820 File Offset: 0x00014A20
		// (set) Token: 0x060003F2 RID: 1010 RVA: 0x00003F84 File Offset: 0x00002184
		public unsafe static float kThinHeight
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(TMP_DefaultControls.NativeFieldInfoPtr_kThinHeight, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TMP_DefaultControls.NativeFieldInfoPtr_kThinHeight, (void*)(&value));
			}
		}

		// Token: 0x17000150 RID: 336
		// (get) Token: 0x060003F3 RID: 1011 RVA: 0x0001683C File Offset: 0x00014A3C
		// (set) Token: 0x060003F4 RID: 1012 RVA: 0x00003F92 File Offset: 0x00002192
		public unsafe static Vector2 s_TextElementSize
		{
			get
			{
				Vector2 vector;
				IL2CPP.il2cpp_field_static_get_value(TMP_DefaultControls.NativeFieldInfoPtr_s_TextElementSize, (void*)(&vector));
				return vector;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TMP_DefaultControls.NativeFieldInfoPtr_s_TextElementSize, (void*)(&value));
			}
		}

		// Token: 0x17000151 RID: 337
		// (get) Token: 0x060003F5 RID: 1013 RVA: 0x00016858 File Offset: 0x00014A58
		// (set) Token: 0x060003F6 RID: 1014 RVA: 0x00003FA0 File Offset: 0x000021A0
		public unsafe static Vector2 s_ThickElementSize
		{
			get
			{
				Vector2 vector;
				IL2CPP.il2cpp_field_static_get_value(TMP_DefaultControls.NativeFieldInfoPtr_s_ThickElementSize, (void*)(&vector));
				return vector;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TMP_DefaultControls.NativeFieldInfoPtr_s_ThickElementSize, (void*)(&value));
			}
		}

		// Token: 0x17000152 RID: 338
		// (get) Token: 0x060003F7 RID: 1015 RVA: 0x00016874 File Offset: 0x00014A74
		// (set) Token: 0x060003F8 RID: 1016 RVA: 0x00003FAE File Offset: 0x000021AE
		public unsafe static Vector2 s_ThinElementSize
		{
			get
			{
				Vector2 vector;
				IL2CPP.il2cpp_field_static_get_value(TMP_DefaultControls.NativeFieldInfoPtr_s_ThinElementSize, (void*)(&vector));
				return vector;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TMP_DefaultControls.NativeFieldInfoPtr_s_ThinElementSize, (void*)(&value));
			}
		}

		// Token: 0x17000153 RID: 339
		// (get) Token: 0x060003F9 RID: 1017 RVA: 0x00016890 File Offset: 0x00014A90
		// (set) Token: 0x060003FA RID: 1018 RVA: 0x00003FBC File Offset: 0x000021BC
		public unsafe static Color s_DefaultSelectableColor
		{
			get
			{
				Color color;
				IL2CPP.il2cpp_field_static_get_value(TMP_DefaultControls.NativeFieldInfoPtr_s_DefaultSelectableColor, (void*)(&color));
				return color;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TMP_DefaultControls.NativeFieldInfoPtr_s_DefaultSelectableColor, (void*)(&value));
			}
		}

		// Token: 0x17000154 RID: 340
		// (get) Token: 0x060003FB RID: 1019 RVA: 0x000168AC File Offset: 0x00014AAC
		// (set) Token: 0x060003FC RID: 1020 RVA: 0x00003FCA File Offset: 0x000021CA
		public unsafe static Color s_TextColor
		{
			get
			{
				Color color;
				IL2CPP.il2cpp_field_static_get_value(TMP_DefaultControls.NativeFieldInfoPtr_s_TextColor, (void*)(&color));
				return color;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TMP_DefaultControls.NativeFieldInfoPtr_s_TextColor, (void*)(&value));
			}
		}

		// Token: 0x040002D5 RID: 725
		private static readonly IntPtr NativeFieldInfoPtr_kWidth;

		// Token: 0x040002D6 RID: 726
		private static readonly IntPtr NativeFieldInfoPtr_kThickHeight;

		// Token: 0x040002D7 RID: 727
		private static readonly IntPtr NativeFieldInfoPtr_kThinHeight;

		// Token: 0x040002D8 RID: 728
		private static readonly IntPtr NativeFieldInfoPtr_s_TextElementSize;

		// Token: 0x040002D9 RID: 729
		private static readonly IntPtr NativeFieldInfoPtr_s_ThickElementSize;

		// Token: 0x040002DA RID: 730
		private static readonly IntPtr NativeFieldInfoPtr_s_ThinElementSize;

		// Token: 0x040002DB RID: 731
		private static readonly IntPtr NativeFieldInfoPtr_s_DefaultSelectableColor;

		// Token: 0x040002DC RID: 732
		private static readonly IntPtr NativeFieldInfoPtr_s_TextColor;

		// Token: 0x040002DD RID: 733
		private static readonly IntPtr NativeMethodInfoPtr_CreateUIElementRoot_Private_Static_GameObject_String_Vector2_0;

		// Token: 0x040002DE RID: 734
		private static readonly IntPtr NativeMethodInfoPtr_CreateUIObject_Private_Static_GameObject_String_GameObject_0;

		// Token: 0x040002DF RID: 735
		private static readonly IntPtr NativeMethodInfoPtr_SetDefaultTextValues_Private_Static_Void_TMP_Text_0;

		// Token: 0x040002E0 RID: 736
		private static readonly IntPtr NativeMethodInfoPtr_SetDefaultColorTransitionValues_Private_Static_Void_Selectable_0;

		// Token: 0x040002E1 RID: 737
		private static readonly IntPtr NativeMethodInfoPtr_SetParentAndAlign_Private_Static_Void_GameObject_GameObject_0;

		// Token: 0x040002E2 RID: 738
		private static readonly IntPtr NativeMethodInfoPtr_SetLayerRecursively_Private_Static_Void_GameObject_Int32_0;

		// Token: 0x040002E3 RID: 739
		private static readonly IntPtr NativeMethodInfoPtr_CreateScrollbar_Public_Static_GameObject_Resources_0;

		// Token: 0x040002E4 RID: 740
		private static readonly IntPtr NativeMethodInfoPtr_CreateButton_Public_Static_GameObject_Resources_0;

		// Token: 0x040002E5 RID: 741
		private static readonly IntPtr NativeMethodInfoPtr_CreateText_Public_Static_GameObject_Resources_0;

		// Token: 0x040002E6 RID: 742
		private static readonly IntPtr NativeMethodInfoPtr_CreateInputField_Public_Static_GameObject_Resources_0;

		// Token: 0x040002E7 RID: 743
		private static readonly IntPtr NativeMethodInfoPtr_CreateDropdown_Public_Static_GameObject_Resources_0;

		// Token: 0x02000080 RID: 128
		public sealed class Resources : ValueType
		{
			// Token: 0x06000EC7 RID: 3783 RVA: 0x0003B810 File Offset: 0x00039A10
			// Note: this type is marked as 'beforefieldinit'.
			static Resources()
			{
				Il2CppClassPointerStore<TMP_DefaultControls.Resources>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TMP_DefaultControls>.NativeClassPtr, "Resources");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TMP_DefaultControls.Resources>.NativeClassPtr);
				TMP_DefaultControls.Resources.NativeFieldInfoPtr_standard = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_DefaultControls.Resources>.NativeClassPtr, "standard");
				TMP_DefaultControls.Resources.NativeFieldInfoPtr_background = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_DefaultControls.Resources>.NativeClassPtr, "background");
				TMP_DefaultControls.Resources.NativeFieldInfoPtr_inputField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_DefaultControls.Resources>.NativeClassPtr, "inputField");
				TMP_DefaultControls.Resources.NativeFieldInfoPtr_knob = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_DefaultControls.Resources>.NativeClassPtr, "knob");
				TMP_DefaultControls.Resources.NativeFieldInfoPtr_checkmark = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_DefaultControls.Resources>.NativeClassPtr, "checkmark");
				TMP_DefaultControls.Resources.NativeFieldInfoPtr_dropdown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_DefaultControls.Resources>.NativeClassPtr, "dropdown");
				TMP_DefaultControls.Resources.NativeFieldInfoPtr_mask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_DefaultControls.Resources>.NativeClassPtr, "mask");
			}

			// Token: 0x06000EC8 RID: 3784 RVA: 0x00008F81 File Offset: 0x00007181
			public Resources(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06000EC9 RID: 3785 RVA: 0x00008F8A File Offset: 0x0000718A
			public Resources()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TMP_DefaultControls.Resources>.NativeClassPtr))
			{
			}

			// Token: 0x17000573 RID: 1395
			// (get) Token: 0x06000ECA RID: 3786 RVA: 0x0003B8C8 File Offset: 0x00039AC8
			// (set) Token: 0x06000ECB RID: 3787 RVA: 0x00008F9C File Offset: 0x0000719C
			public unsafe Sprite standard
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_DefaultControls.Resources.NativeFieldInfoPtr_standard);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_DefaultControls.Resources.NativeFieldInfoPtr_standard), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000574 RID: 1396
			// (get) Token: 0x06000ECC RID: 3788 RVA: 0x0003B8F8 File Offset: 0x00039AF8
			// (set) Token: 0x06000ECD RID: 3789 RVA: 0x00008FBB File Offset: 0x000071BB
			public unsafe Sprite background
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_DefaultControls.Resources.NativeFieldInfoPtr_background);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_DefaultControls.Resources.NativeFieldInfoPtr_background), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000575 RID: 1397
			// (get) Token: 0x06000ECE RID: 3790 RVA: 0x0003B928 File Offset: 0x00039B28
			// (set) Token: 0x06000ECF RID: 3791 RVA: 0x00008FDA File Offset: 0x000071DA
			public unsafe Sprite inputField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_DefaultControls.Resources.NativeFieldInfoPtr_inputField);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_DefaultControls.Resources.NativeFieldInfoPtr_inputField), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000576 RID: 1398
			// (get) Token: 0x06000ED0 RID: 3792 RVA: 0x0003B958 File Offset: 0x00039B58
			// (set) Token: 0x06000ED1 RID: 3793 RVA: 0x00008FF9 File Offset: 0x000071F9
			public unsafe Sprite knob
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_DefaultControls.Resources.NativeFieldInfoPtr_knob);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_DefaultControls.Resources.NativeFieldInfoPtr_knob), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000577 RID: 1399
			// (get) Token: 0x06000ED2 RID: 3794 RVA: 0x0003B988 File Offset: 0x00039B88
			// (set) Token: 0x06000ED3 RID: 3795 RVA: 0x00009018 File Offset: 0x00007218
			public unsafe Sprite checkmark
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_DefaultControls.Resources.NativeFieldInfoPtr_checkmark);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_DefaultControls.Resources.NativeFieldInfoPtr_checkmark), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000578 RID: 1400
			// (get) Token: 0x06000ED4 RID: 3796 RVA: 0x0003B9B8 File Offset: 0x00039BB8
			// (set) Token: 0x06000ED5 RID: 3797 RVA: 0x00009037 File Offset: 0x00007237
			public unsafe Sprite dropdown
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_DefaultControls.Resources.NativeFieldInfoPtr_dropdown);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_DefaultControls.Resources.NativeFieldInfoPtr_dropdown), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000579 RID: 1401
			// (get) Token: 0x06000ED6 RID: 3798 RVA: 0x0003B9E8 File Offset: 0x00039BE8
			// (set) Token: 0x06000ED7 RID: 3799 RVA: 0x00009056 File Offset: 0x00007256
			public unsafe Sprite mask
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_DefaultControls.Resources.NativeFieldInfoPtr_mask);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_DefaultControls.Resources.NativeFieldInfoPtr_mask), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000BB4 RID: 2996
			private static readonly IntPtr NativeFieldInfoPtr_standard;

			// Token: 0x04000BB5 RID: 2997
			private static readonly IntPtr NativeFieldInfoPtr_background;

			// Token: 0x04000BB6 RID: 2998
			private static readonly IntPtr NativeFieldInfoPtr_inputField;

			// Token: 0x04000BB7 RID: 2999
			private static readonly IntPtr NativeFieldInfoPtr_knob;

			// Token: 0x04000BB8 RID: 3000
			private static readonly IntPtr NativeFieldInfoPtr_checkmark;

			// Token: 0x04000BB9 RID: 3001
			private static readonly IntPtr NativeFieldInfoPtr_dropdown;

			// Token: 0x04000BBA RID: 3002
			private static readonly IntPtr NativeFieldInfoPtr_mask;
		}
	}
}
