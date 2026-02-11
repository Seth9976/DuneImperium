using System;
using dwd.core.input.compositeModule;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace lib.src.input.context
{
	// Token: 0x02000015 RID: 21
	public class InputModuleButton : Button
	{
		// Token: 0x0600008C RID: 140 RVA: 0x00008EE8 File Offset: 0x000070E8
		// Note: this type is marked as 'beforefieldinit'.
		static InputModuleButton()
		{
			Il2CppClassPointerStore<InputModuleButton>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-input.dll", "lib.src.input.context", "InputModuleButton");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InputModuleButton>.NativeClassPtr);
			InputModuleButton.NativeFieldInfoPtr_behavior = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputModuleButton>.NativeClassPtr, "behavior");
			InputModuleButton.NativeFieldInfoPtr_inputModuleType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputModuleButton>.NativeClassPtr, "inputModuleType");
			InputModuleButton.NativeFieldInfoPtr_onSelect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputModuleButton>.NativeClassPtr, "onSelect");
			InputModuleButton.NativeFieldInfoPtr_onDeselect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputModuleButton>.NativeClassPtr, "onDeselect");
			InputModuleButton.NativeFieldInfoPtr_currentInputModule = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputModuleButton>.NativeClassPtr, "currentInputModule");
			InputModuleButton.NativeFieldInfoPtr_cachedVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputModuleButton>.NativeClassPtr, "cachedVersion");
			InputModuleButton.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputModuleButton>.NativeClassPtr, 100663373);
			InputModuleButton.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputModuleButton>.NativeClassPtr, 100663374);
			InputModuleButton.NativeMethodInfoPtr_validateModuleType_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputModuleButton>.NativeClassPtr, 100663375);
			InputModuleButton.NativeMethodInfoPtr_OnPointerClick_Public_Virtual_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputModuleButton>.NativeClassPtr, 100663376);
			InputModuleButton.NativeMethodInfoPtr_OnSubmit_Public_Virtual_Void_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputModuleButton>.NativeClassPtr, 100663377);
			InputModuleButton.NativeMethodInfoPtr_OnSelect_Public_Virtual_Void_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputModuleButton>.NativeClassPtr, 100663378);
			InputModuleButton.NativeMethodInfoPtr_OnDeselect_Public_Virtual_Void_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputModuleButton>.NativeClassPtr, 100663379);
			InputModuleButton.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputModuleButton>.NativeClassPtr, 100663380);
		}

		// Token: 0x0600008D RID: 141 RVA: 0x00009030 File Offset: 0x00007230
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1119332, XrefRangeEnd = 1119340, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InputModuleButton.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600008E RID: 142 RVA: 0x0000906C File Offset: 0x0000726C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1119340, XrefRangeEnd = 1119345, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputModuleButton.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600008F RID: 143 RVA: 0x000090A0 File Offset: 0x000072A0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1119347, RefRangeEnd = 1119349, XrefRangeStart = 1119345, XrefRangeEnd = 1119347, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void validateModuleType()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputModuleButton.NativeMethodInfoPtr_validateModuleType_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000090 RID: 144 RVA: 0x000090D4 File Offset: 0x000072D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1119349, XrefRangeEnd = 1119351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPointerClick(PointerEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InputModuleButton.NativeMethodInfoPtr_OnPointerClick_Public_Virtual_Void_PointerEventData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000091 RID: 145 RVA: 0x00009124 File Offset: 0x00007324
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1119351, XrefRangeEnd = 1119353, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnSubmit(BaseEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InputModuleButton.NativeMethodInfoPtr_OnSubmit_Public_Virtual_Void_BaseEventData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000092 RID: 146 RVA: 0x00009174 File Offset: 0x00007374
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1119353, XrefRangeEnd = 1119356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnSelect(BaseEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InputModuleButton.NativeMethodInfoPtr_OnSelect_Public_Virtual_Void_BaseEventData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000093 RID: 147 RVA: 0x000091C4 File Offset: 0x000073C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1119356, XrefRangeEnd = 1119359, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnDeselect(BaseEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InputModuleButton.NativeMethodInfoPtr_OnDeselect_Public_Virtual_Void_BaseEventData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000094 RID: 148 RVA: 0x00009214 File Offset: 0x00007414
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1119359, XrefRangeEnd = 1119373, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InputModuleButton()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InputModuleButton>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputModuleButton.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000095 RID: 149 RVA: 0x000023AD File Offset: 0x000005AD
		public InputModuleButton(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x06000096 RID: 150 RVA: 0x00009250 File Offset: 0x00007450
		// (set) Token: 0x06000097 RID: 151 RVA: 0x000023B6 File Offset: 0x000005B6
		public unsafe ButtonBehavior behavior
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputModuleButton.NativeFieldInfoPtr_behavior);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputModuleButton.NativeFieldInfoPtr_behavior)) = value;
			}
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x06000098 RID: 152 RVA: 0x00009278 File Offset: 0x00007478
		// (set) Token: 0x06000099 RID: 153 RVA: 0x000023D1 File Offset: 0x000005D1
		public unsafe string inputModuleType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputModuleButton.NativeFieldInfoPtr_inputModuleType);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputModuleButton.NativeFieldInfoPtr_inputModuleType), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x0600009A RID: 154 RVA: 0x000092A0 File Offset: 0x000074A0
		// (set) Token: 0x0600009B RID: 155 RVA: 0x000023F0 File Offset: 0x000005F0
		public unsafe UnityEvent onSelect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputModuleButton.NativeFieldInfoPtr_onSelect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputModuleButton.NativeFieldInfoPtr_onSelect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x0600009C RID: 156 RVA: 0x000092D0 File Offset: 0x000074D0
		// (set) Token: 0x0600009D RID: 157 RVA: 0x0000240F File Offset: 0x0000060F
		public unsafe UnityEvent onDeselect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputModuleButton.NativeFieldInfoPtr_onDeselect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputModuleButton.NativeFieldInfoPtr_onDeselect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x0600009E RID: 158 RVA: 0x00009300 File Offset: 0x00007500
		// (set) Token: 0x0600009F RID: 159 RVA: 0x0000242E File Offset: 0x0000062E
		public unsafe CurrentInputModuleType currentInputModule
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputModuleButton.NativeFieldInfoPtr_currentInputModule);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CurrentInputModuleType>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputModuleButton.NativeFieldInfoPtr_currentInputModule), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x060000A0 RID: 160 RVA: 0x00009330 File Offset: 0x00007530
		// (set) Token: 0x060000A1 RID: 161 RVA: 0x0000244D File Offset: 0x0000064D
		public unsafe ulong cachedVersion
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputModuleButton.NativeFieldInfoPtr_cachedVersion);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputModuleButton.NativeFieldInfoPtr_cachedVersion)) = value;
			}
		}

		// Token: 0x04000057 RID: 87
		private static readonly IntPtr NativeFieldInfoPtr_behavior;

		// Token: 0x04000058 RID: 88
		private static readonly IntPtr NativeFieldInfoPtr_inputModuleType;

		// Token: 0x04000059 RID: 89
		private static readonly IntPtr NativeFieldInfoPtr_onSelect;

		// Token: 0x0400005A RID: 90
		private static readonly IntPtr NativeFieldInfoPtr_onDeselect;

		// Token: 0x0400005B RID: 91
		private static readonly IntPtr NativeFieldInfoPtr_currentInputModule;

		// Token: 0x0400005C RID: 92
		private static readonly IntPtr NativeFieldInfoPtr_cachedVersion;

		// Token: 0x0400005D RID: 93
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x0400005E RID: 94
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x0400005F RID: 95
		private static readonly IntPtr NativeMethodInfoPtr_validateModuleType_Private_Void_0;

		// Token: 0x04000060 RID: 96
		private static readonly IntPtr NativeMethodInfoPtr_OnPointerClick_Public_Virtual_Void_PointerEventData_0;

		// Token: 0x04000061 RID: 97
		private static readonly IntPtr NativeMethodInfoPtr_OnSubmit_Public_Virtual_Void_BaseEventData_0;

		// Token: 0x04000062 RID: 98
		private static readonly IntPtr NativeMethodInfoPtr_OnSelect_Public_Virtual_Void_BaseEventData_0;

		// Token: 0x04000063 RID: 99
		private static readonly IntPtr NativeMethodInfoPtr_OnDeselect_Public_Virtual_Void_BaseEventData_0;

		// Token: 0x04000064 RID: 100
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
