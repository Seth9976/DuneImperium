using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.UI
{
	// Token: 0x02000003 RID: 3
	[Serializable]
	public class AnimationTriggers : Object
	{
		// Token: 0x06000005 RID: 5 RVA: 0x00007664 File Offset: 0x00005864
		// Note: this type is marked as 'beforefieldinit'.
		static AnimationTriggers()
		{
			Il2CppClassPointerStore<AnimationTriggers>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UI.dll", "UnityEngine.UI", "AnimationTriggers");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AnimationTriggers>.NativeClassPtr);
			AnimationTriggers.NativeFieldInfoPtr_kDefaultNormalAnimName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationTriggers>.NativeClassPtr, "kDefaultNormalAnimName");
			AnimationTriggers.NativeFieldInfoPtr_kDefaultHighlightedAnimName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationTriggers>.NativeClassPtr, "kDefaultHighlightedAnimName");
			AnimationTriggers.NativeFieldInfoPtr_kDefaultPressedAnimName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationTriggers>.NativeClassPtr, "kDefaultPressedAnimName");
			AnimationTriggers.NativeFieldInfoPtr_kDefaultSelectedAnimName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationTriggers>.NativeClassPtr, "kDefaultSelectedAnimName");
			AnimationTriggers.NativeFieldInfoPtr_kDefaultDisabledAnimName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationTriggers>.NativeClassPtr, "kDefaultDisabledAnimName");
			AnimationTriggers.NativeFieldInfoPtr_m_NormalTrigger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationTriggers>.NativeClassPtr, "m_NormalTrigger");
			AnimationTriggers.NativeFieldInfoPtr_m_HighlightedTrigger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationTriggers>.NativeClassPtr, "m_HighlightedTrigger");
			AnimationTriggers.NativeFieldInfoPtr_m_PressedTrigger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationTriggers>.NativeClassPtr, "m_PressedTrigger");
			AnimationTriggers.NativeFieldInfoPtr_m_SelectedTrigger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationTriggers>.NativeClassPtr, "m_SelectedTrigger");
			AnimationTriggers.NativeFieldInfoPtr_m_DisabledTrigger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationTriggers>.NativeClassPtr, "m_DisabledTrigger");
			AnimationTriggers.NativeMethodInfoPtr_get_normalTrigger_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationTriggers>.NativeClassPtr, 100663299);
			AnimationTriggers.NativeMethodInfoPtr_set_normalTrigger_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationTriggers>.NativeClassPtr, 100663300);
			AnimationTriggers.NativeMethodInfoPtr_get_highlightedTrigger_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationTriggers>.NativeClassPtr, 100663301);
			AnimationTriggers.NativeMethodInfoPtr_set_highlightedTrigger_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationTriggers>.NativeClassPtr, 100663302);
			AnimationTriggers.NativeMethodInfoPtr_get_pressedTrigger_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationTriggers>.NativeClassPtr, 100663303);
			AnimationTriggers.NativeMethodInfoPtr_set_pressedTrigger_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationTriggers>.NativeClassPtr, 100663304);
			AnimationTriggers.NativeMethodInfoPtr_get_selectedTrigger_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationTriggers>.NativeClassPtr, 100663305);
			AnimationTriggers.NativeMethodInfoPtr_set_selectedTrigger_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationTriggers>.NativeClassPtr, 100663306);
			AnimationTriggers.NativeMethodInfoPtr_get_disabledTrigger_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationTriggers>.NativeClassPtr, 100663307);
			AnimationTriggers.NativeMethodInfoPtr_set_disabledTrigger_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationTriggers>.NativeClassPtr, 100663308);
			AnimationTriggers.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationTriggers>.NativeClassPtr, 100663309);
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000006 RID: 6 RVA: 0x00007838 File Offset: 0x00005A38
		// (set) Token: 0x06000007 RID: 7 RVA: 0x00007870 File Offset: 0x00005A70
		public unsafe string normalTrigger
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationTriggers.NativeMethodInfoPtr_get_normalTrigger_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 287292, RefRangeEnd = 287294, XrefRangeStart = 287292, XrefRangeEnd = 287294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationTriggers.NativeMethodInfoPtr_set_normalTrigger_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000008 RID: 8 RVA: 0x000078B4 File Offset: 0x00005AB4
		// (set) Token: 0x06000009 RID: 9 RVA: 0x000078EC File Offset: 0x00005AEC
		public unsafe string highlightedTrigger
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationTriggers.NativeMethodInfoPtr_get_highlightedTrigger_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationTriggers.NativeMethodInfoPtr_set_highlightedTrigger_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x0600000A RID: 10 RVA: 0x00007930 File Offset: 0x00005B30
		// (set) Token: 0x0600000B RID: 11 RVA: 0x00007968 File Offset: 0x00005B68
		public unsafe string pressedTrigger
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationTriggers.NativeMethodInfoPtr_get_pressedTrigger_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationTriggers.NativeMethodInfoPtr_set_pressedTrigger_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x0600000C RID: 12 RVA: 0x000079AC File Offset: 0x00005BAC
		// (set) Token: 0x0600000D RID: 13 RVA: 0x000079E4 File Offset: 0x00005BE4
		public unsafe string selectedTrigger
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationTriggers.NativeMethodInfoPtr_get_selectedTrigger_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationTriggers.NativeMethodInfoPtr_set_selectedTrigger_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x0600000E RID: 14 RVA: 0x00007A28 File Offset: 0x00005C28
		// (set) Token: 0x0600000F RID: 15 RVA: 0x00007A60 File Offset: 0x00005C60
		public unsafe string disabledTrigger
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 131885, RefRangeEnd = 131899, XrefRangeStart = 131885, XrefRangeEnd = 131899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationTriggers.NativeMethodInfoPtr_get_disabledTrigger_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationTriggers.NativeMethodInfoPtr_set_disabledTrigger_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000010 RID: 16 RVA: 0x00007AA4 File Offset: 0x00005CA4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1081007, RefRangeEnd = 1081008, XrefRangeStart = 1080986, XrefRangeEnd = 1081007, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AnimationTriggers()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AnimationTriggers>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationTriggers.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000011 RID: 17 RVA: 0x00002059 File Offset: 0x00000259
		public AnimationTriggers(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000012 RID: 18 RVA: 0x00007AE0 File Offset: 0x00005CE0
		// (set) Token: 0x06000013 RID: 19 RVA: 0x00002062 File Offset: 0x00000262
		public unsafe static string kDefaultNormalAnimName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AnimationTriggers.NativeFieldInfoPtr_kDefaultNormalAnimName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AnimationTriggers.NativeFieldInfoPtr_kDefaultNormalAnimName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000014 RID: 20 RVA: 0x00007B00 File Offset: 0x00005D00
		// (set) Token: 0x06000015 RID: 21 RVA: 0x00002074 File Offset: 0x00000274
		public unsafe static string kDefaultHighlightedAnimName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AnimationTriggers.NativeFieldInfoPtr_kDefaultHighlightedAnimName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AnimationTriggers.NativeFieldInfoPtr_kDefaultHighlightedAnimName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000016 RID: 22 RVA: 0x00007B20 File Offset: 0x00005D20
		// (set) Token: 0x06000017 RID: 23 RVA: 0x00002086 File Offset: 0x00000286
		public unsafe static string kDefaultPressedAnimName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AnimationTriggers.NativeFieldInfoPtr_kDefaultPressedAnimName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AnimationTriggers.NativeFieldInfoPtr_kDefaultPressedAnimName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000018 RID: 24 RVA: 0x00007B40 File Offset: 0x00005D40
		// (set) Token: 0x06000019 RID: 25 RVA: 0x00002098 File Offset: 0x00000298
		public unsafe static string kDefaultSelectedAnimName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AnimationTriggers.NativeFieldInfoPtr_kDefaultSelectedAnimName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AnimationTriggers.NativeFieldInfoPtr_kDefaultSelectedAnimName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x0600001A RID: 26 RVA: 0x00007B60 File Offset: 0x00005D60
		// (set) Token: 0x0600001B RID: 27 RVA: 0x000020AA File Offset: 0x000002AA
		public unsafe static string kDefaultDisabledAnimName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AnimationTriggers.NativeFieldInfoPtr_kDefaultDisabledAnimName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AnimationTriggers.NativeFieldInfoPtr_kDefaultDisabledAnimName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x0600001C RID: 28 RVA: 0x00007B80 File Offset: 0x00005D80
		// (set) Token: 0x0600001D RID: 29 RVA: 0x000020BC File Offset: 0x000002BC
		public unsafe string m_NormalTrigger
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationTriggers.NativeFieldInfoPtr_m_NormalTrigger);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationTriggers.NativeFieldInfoPtr_m_NormalTrigger), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x0600001E RID: 30 RVA: 0x00007BA8 File Offset: 0x00005DA8
		// (set) Token: 0x0600001F RID: 31 RVA: 0x000020DB File Offset: 0x000002DB
		public unsafe string m_HighlightedTrigger
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationTriggers.NativeFieldInfoPtr_m_HighlightedTrigger);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationTriggers.NativeFieldInfoPtr_m_HighlightedTrigger), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000020 RID: 32 RVA: 0x00007BD0 File Offset: 0x00005DD0
		// (set) Token: 0x06000021 RID: 33 RVA: 0x000020FA File Offset: 0x000002FA
		public unsafe string m_PressedTrigger
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationTriggers.NativeFieldInfoPtr_m_PressedTrigger);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationTriggers.NativeFieldInfoPtr_m_PressedTrigger), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000022 RID: 34 RVA: 0x00007BF8 File Offset: 0x00005DF8
		// (set) Token: 0x06000023 RID: 35 RVA: 0x00002119 File Offset: 0x00000319
		public unsafe string m_SelectedTrigger
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationTriggers.NativeFieldInfoPtr_m_SelectedTrigger);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationTriggers.NativeFieldInfoPtr_m_SelectedTrigger), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000024 RID: 36 RVA: 0x00007C20 File Offset: 0x00005E20
		// (set) Token: 0x06000025 RID: 37 RVA: 0x00002138 File Offset: 0x00000338
		public unsafe string m_DisabledTrigger
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationTriggers.NativeFieldInfoPtr_m_DisabledTrigger);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationTriggers.NativeFieldInfoPtr_m_DisabledTrigger), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000003 RID: 3
		private static readonly IntPtr NativeFieldInfoPtr_kDefaultNormalAnimName;

		// Token: 0x04000004 RID: 4
		private static readonly IntPtr NativeFieldInfoPtr_kDefaultHighlightedAnimName;

		// Token: 0x04000005 RID: 5
		private static readonly IntPtr NativeFieldInfoPtr_kDefaultPressedAnimName;

		// Token: 0x04000006 RID: 6
		private static readonly IntPtr NativeFieldInfoPtr_kDefaultSelectedAnimName;

		// Token: 0x04000007 RID: 7
		private static readonly IntPtr NativeFieldInfoPtr_kDefaultDisabledAnimName;

		// Token: 0x04000008 RID: 8
		private static readonly IntPtr NativeFieldInfoPtr_m_NormalTrigger;

		// Token: 0x04000009 RID: 9
		private static readonly IntPtr NativeFieldInfoPtr_m_HighlightedTrigger;

		// Token: 0x0400000A RID: 10
		private static readonly IntPtr NativeFieldInfoPtr_m_PressedTrigger;

		// Token: 0x0400000B RID: 11
		private static readonly IntPtr NativeFieldInfoPtr_m_SelectedTrigger;

		// Token: 0x0400000C RID: 12
		private static readonly IntPtr NativeFieldInfoPtr_m_DisabledTrigger;

		// Token: 0x0400000D RID: 13
		private static readonly IntPtr NativeMethodInfoPtr_get_normalTrigger_Public_get_String_0;

		// Token: 0x0400000E RID: 14
		private static readonly IntPtr NativeMethodInfoPtr_set_normalTrigger_Public_set_Void_String_0;

		// Token: 0x0400000F RID: 15
		private static readonly IntPtr NativeMethodInfoPtr_get_highlightedTrigger_Public_get_String_0;

		// Token: 0x04000010 RID: 16
		private static readonly IntPtr NativeMethodInfoPtr_set_highlightedTrigger_Public_set_Void_String_0;

		// Token: 0x04000011 RID: 17
		private static readonly IntPtr NativeMethodInfoPtr_get_pressedTrigger_Public_get_String_0;

		// Token: 0x04000012 RID: 18
		private static readonly IntPtr NativeMethodInfoPtr_set_pressedTrigger_Public_set_Void_String_0;

		// Token: 0x04000013 RID: 19
		private static readonly IntPtr NativeMethodInfoPtr_get_selectedTrigger_Public_get_String_0;

		// Token: 0x04000014 RID: 20
		private static readonly IntPtr NativeMethodInfoPtr_set_selectedTrigger_Public_set_Void_String_0;

		// Token: 0x04000015 RID: 21
		private static readonly IntPtr NativeMethodInfoPtr_get_disabledTrigger_Public_get_String_0;

		// Token: 0x04000016 RID: 22
		private static readonly IntPtr NativeMethodInfoPtr_set_disabledTrigger_Public_set_Void_String_0;

		// Token: 0x04000017 RID: 23
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
