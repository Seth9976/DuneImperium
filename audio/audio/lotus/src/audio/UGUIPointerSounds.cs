using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace lotus.src.audio
{
	// Token: 0x02000010 RID: 16
	public class UGUIPointerSounds : MonoBehaviour
	{
		// Token: 0x06000078 RID: 120 RVA: 0x00004074 File Offset: 0x00002274
		// Note: this type is marked as 'beforefieldinit'.
		static UGUIPointerSounds()
		{
			Il2CppClassPointerStore<UGUIPointerSounds>.NativeClassPtr = IL2CPP.GetIl2CppClass("audio.dll", "lotus.src.audio", "UGUIPointerSounds");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UGUIPointerSounds>.NativeClassPtr);
			UGUIPointerSounds.NativeFieldInfoPtr_withinSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UGUIPointerSounds>.NativeClassPtr, "withinSound");
			UGUIPointerSounds.NativeFieldInfoPtr_exitSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UGUIPointerSounds>.NativeClassPtr, "exitSound");
			UGUIPointerSounds.NativeFieldInfoPtr_downSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UGUIPointerSounds>.NativeClassPtr, "downSound");
			UGUIPointerSounds.NativeFieldInfoPtr_upSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UGUIPointerSounds>.NativeClassPtr, "upSound");
			UGUIPointerSounds.NativeFieldInfoPtr_selectSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UGUIPointerSounds>.NativeClassPtr, "selectSound");
			UGUIPointerSounds.NativeFieldInfoPtr_submitSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UGUIPointerSounds>.NativeClassPtr, "submitSound");
			UGUIPointerSounds.NativeFieldInfoPtr_cancelSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UGUIPointerSounds>.NativeClassPtr, "cancelSound");
			UGUIPointerSounds.NativeFieldInfoPtr_leftClickOnly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UGUIPointerSounds>.NativeClassPtr, "leftClickOnly");
			UGUIPointerSounds.NativeFieldInfoPtr_isWithin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UGUIPointerSounds>.NativeClassPtr, "isWithin");
			UGUIPointerSounds.NativeFieldInfoPtr_selectable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UGUIPointerSounds>.NativeClassPtr, "selectable");
			UGUIPointerSounds.NativeFieldInfoPtr_withinLoop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UGUIPointerSounds>.NativeClassPtr, "withinLoop");
			UGUIPointerSounds.NativeMethodInfoPtr_get_IsInteractable_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UGUIPointerSounds>.NativeClassPtr, 100663345);
			UGUIPointerSounds.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UGUIPointerSounds>.NativeClassPtr, 100663346);
			UGUIPointerSounds.NativeMethodInfoPtr_UnityEngine_EventSystems_IPointerDownHandler_OnPointerDown_Private_Virtual_Final_New_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UGUIPointerSounds>.NativeClassPtr, 100663347);
			UGUIPointerSounds.NativeMethodInfoPtr_UnityEngine_EventSystems_IPointerUpHandler_OnPointerUp_Private_Virtual_Final_New_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UGUIPointerSounds>.NativeClassPtr, 100663348);
			UGUIPointerSounds.NativeMethodInfoPtr_OnPointerEnter_Public_Virtual_Final_New_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UGUIPointerSounds>.NativeClassPtr, 100663349);
			UGUIPointerSounds.NativeMethodInfoPtr_OnPointerExit_Public_Virtual_Final_New_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UGUIPointerSounds>.NativeClassPtr, 100663350);
			UGUIPointerSounds.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UGUIPointerSounds>.NativeClassPtr, 100663351);
			UGUIPointerSounds.NativeMethodInfoPtr_stopWithin_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UGUIPointerSounds>.NativeClassPtr, 100663352);
			UGUIPointerSounds.NativeMethodInfoPtr_OnSelect_Public_Virtual_Final_New_Void_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UGUIPointerSounds>.NativeClassPtr, 100663353);
			UGUIPointerSounds.NativeMethodInfoPtr_OnSubmit_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UGUIPointerSounds>.NativeClassPtr, 100663354);
			UGUIPointerSounds.NativeMethodInfoPtr_OnSubmit_Public_Virtual_Final_New_Void_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UGUIPointerSounds>.NativeClassPtr, 100663355);
			UGUIPointerSounds.NativeMethodInfoPtr_OnCancel_Public_Virtual_Final_New_Void_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UGUIPointerSounds>.NativeClassPtr, 100663356);
			UGUIPointerSounds.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UGUIPointerSounds>.NativeClassPtr, 100663357);
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x06000079 RID: 121 RVA: 0x00004284 File Offset: 0x00002484
		public unsafe bool IsInteractable
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 1261517, RefRangeEnd = 1261524, XrefRangeStart = 1261512, XrefRangeEnd = 1261517, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UGUIPointerSounds.NativeMethodInfoPtr_get_IsInteractable_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600007A RID: 122 RVA: 0x000042C0 File Offset: 0x000024C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1261524, XrefRangeEnd = 1261542, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UGUIPointerSounds.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600007B RID: 123 RVA: 0x000042F4 File Offset: 0x000024F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1261542, XrefRangeEnd = 1261544, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void UnityEngine_EventSystems_IPointerDownHandler_OnPointerDown(PointerEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UGUIPointerSounds.NativeMethodInfoPtr_UnityEngine_EventSystems_IPointerDownHandler_OnPointerDown_Private_Virtual_Final_New_Void_PointerEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600007C RID: 124 RVA: 0x00004338 File Offset: 0x00002538
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1261544, XrefRangeEnd = 1261546, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void UnityEngine_EventSystems_IPointerUpHandler_OnPointerUp(PointerEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UGUIPointerSounds.NativeMethodInfoPtr_UnityEngine_EventSystems_IPointerUpHandler_OnPointerUp_Private_Virtual_Final_New_Void_PointerEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600007D RID: 125 RVA: 0x0000437C File Offset: 0x0000257C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1261546, XrefRangeEnd = 1261549, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnPointerEnter(PointerEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UGUIPointerSounds.NativeMethodInfoPtr_OnPointerEnter_Public_Virtual_Final_New_Void_PointerEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600007E RID: 126 RVA: 0x000043C0 File Offset: 0x000025C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1261549, XrefRangeEnd = 1261550, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnPointerExit(PointerEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UGUIPointerSounds.NativeMethodInfoPtr_OnPointerExit_Public_Virtual_Final_New_Void_PointerEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600007F RID: 127 RVA: 0x00004404 File Offset: 0x00002604
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UGUIPointerSounds.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000080 RID: 128 RVA: 0x00004438 File Offset: 0x00002638
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1261559, RefRangeEnd = 1261561, XrefRangeStart = 1261550, XrefRangeEnd = 1261559, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void stopWithin()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UGUIPointerSounds.NativeMethodInfoPtr_stopWithin_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000081 RID: 129 RVA: 0x0000446C File Offset: 0x0000266C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1261561, XrefRangeEnd = 1261571, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnSelect(BaseEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UGUIPointerSounds.NativeMethodInfoPtr_OnSelect_Public_Virtual_Final_New_Void_BaseEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000082 RID: 130 RVA: 0x000044B0 File Offset: 0x000026B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1261571, XrefRangeEnd = 1261573, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnSubmit()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UGUIPointerSounds.NativeMethodInfoPtr_OnSubmit_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000083 RID: 131 RVA: 0x000044E4 File Offset: 0x000026E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnSubmit(BaseEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UGUIPointerSounds.NativeMethodInfoPtr_OnSubmit_Public_Virtual_Final_New_Void_BaseEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000084 RID: 132 RVA: 0x00004528 File Offset: 0x00002728
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1261573, XrefRangeEnd = 1261575, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnCancel(BaseEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UGUIPointerSounds.NativeMethodInfoPtr_OnCancel_Public_Virtual_Final_New_Void_BaseEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000085 RID: 133 RVA: 0x0000456C File Offset: 0x0000276C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1261575, XrefRangeEnd = 1261591, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UGUIPointerSounds()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UGUIPointerSounds>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UGUIPointerSounds.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000086 RID: 134 RVA: 0x000023D9 File Offset: 0x000005D9
		public UGUIPointerSounds(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x06000087 RID: 135 RVA: 0x000045A8 File Offset: 0x000027A8
		// (set) Token: 0x06000088 RID: 136 RVA: 0x000023E2 File Offset: 0x000005E2
		public unsafe string withinSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UGUIPointerSounds.NativeFieldInfoPtr_withinSound);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UGUIPointerSounds.NativeFieldInfoPtr_withinSound), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x06000089 RID: 137 RVA: 0x000045D0 File Offset: 0x000027D0
		// (set) Token: 0x0600008A RID: 138 RVA: 0x00002401 File Offset: 0x00000601
		public unsafe string exitSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UGUIPointerSounds.NativeFieldInfoPtr_exitSound);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UGUIPointerSounds.NativeFieldInfoPtr_exitSound), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x0600008B RID: 139 RVA: 0x000045F8 File Offset: 0x000027F8
		// (set) Token: 0x0600008C RID: 140 RVA: 0x00002420 File Offset: 0x00000620
		public unsafe string downSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UGUIPointerSounds.NativeFieldInfoPtr_downSound);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UGUIPointerSounds.NativeFieldInfoPtr_downSound), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x0600008D RID: 141 RVA: 0x00004620 File Offset: 0x00002820
		// (set) Token: 0x0600008E RID: 142 RVA: 0x0000243F File Offset: 0x0000063F
		public unsafe string upSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UGUIPointerSounds.NativeFieldInfoPtr_upSound);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UGUIPointerSounds.NativeFieldInfoPtr_upSound), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x0600008F RID: 143 RVA: 0x00004648 File Offset: 0x00002848
		// (set) Token: 0x06000090 RID: 144 RVA: 0x0000245E File Offset: 0x0000065E
		public unsafe string selectSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UGUIPointerSounds.NativeFieldInfoPtr_selectSound);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UGUIPointerSounds.NativeFieldInfoPtr_selectSound), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x06000091 RID: 145 RVA: 0x00004670 File Offset: 0x00002870
		// (set) Token: 0x06000092 RID: 146 RVA: 0x0000247D File Offset: 0x0000067D
		public unsafe string submitSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UGUIPointerSounds.NativeFieldInfoPtr_submitSound);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UGUIPointerSounds.NativeFieldInfoPtr_submitSound), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x06000093 RID: 147 RVA: 0x00004698 File Offset: 0x00002898
		// (set) Token: 0x06000094 RID: 148 RVA: 0x0000249C File Offset: 0x0000069C
		public unsafe string cancelSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UGUIPointerSounds.NativeFieldInfoPtr_cancelSound);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UGUIPointerSounds.NativeFieldInfoPtr_cancelSound), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x06000095 RID: 149 RVA: 0x000046C0 File Offset: 0x000028C0
		// (set) Token: 0x06000096 RID: 150 RVA: 0x000024BB File Offset: 0x000006BB
		public unsafe bool leftClickOnly
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UGUIPointerSounds.NativeFieldInfoPtr_leftClickOnly);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UGUIPointerSounds.NativeFieldInfoPtr_leftClickOnly)) = value;
			}
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x06000097 RID: 151 RVA: 0x000046E8 File Offset: 0x000028E8
		// (set) Token: 0x06000098 RID: 152 RVA: 0x000024D6 File Offset: 0x000006D6
		public unsafe bool isWithin
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UGUIPointerSounds.NativeFieldInfoPtr_isWithin);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UGUIPointerSounds.NativeFieldInfoPtr_isWithin)) = value;
			}
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x06000099 RID: 153 RVA: 0x00004710 File Offset: 0x00002910
		// (set) Token: 0x0600009A RID: 154 RVA: 0x000024F1 File Offset: 0x000006F1
		public unsafe Selectable selectable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UGUIPointerSounds.NativeFieldInfoPtr_selectable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Selectable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UGUIPointerSounds.NativeFieldInfoPtr_selectable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x0600009B RID: 155 RVA: 0x00004740 File Offset: 0x00002940
		// (set) Token: 0x0600009C RID: 156 RVA: 0x00002510 File Offset: 0x00000710
		public unsafe AudioObject withinLoop
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UGUIPointerSounds.NativeFieldInfoPtr_withinLoop);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UGUIPointerSounds.NativeFieldInfoPtr_withinLoop), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000043 RID: 67
		private static readonly IntPtr NativeFieldInfoPtr_withinSound;

		// Token: 0x04000044 RID: 68
		private static readonly IntPtr NativeFieldInfoPtr_exitSound;

		// Token: 0x04000045 RID: 69
		private static readonly IntPtr NativeFieldInfoPtr_downSound;

		// Token: 0x04000046 RID: 70
		private static readonly IntPtr NativeFieldInfoPtr_upSound;

		// Token: 0x04000047 RID: 71
		private static readonly IntPtr NativeFieldInfoPtr_selectSound;

		// Token: 0x04000048 RID: 72
		private static readonly IntPtr NativeFieldInfoPtr_submitSound;

		// Token: 0x04000049 RID: 73
		private static readonly IntPtr NativeFieldInfoPtr_cancelSound;

		// Token: 0x0400004A RID: 74
		private static readonly IntPtr NativeFieldInfoPtr_leftClickOnly;

		// Token: 0x0400004B RID: 75
		private static readonly IntPtr NativeFieldInfoPtr_isWithin;

		// Token: 0x0400004C RID: 76
		private static readonly IntPtr NativeFieldInfoPtr_selectable;

		// Token: 0x0400004D RID: 77
		private static readonly IntPtr NativeFieldInfoPtr_withinLoop;

		// Token: 0x0400004E RID: 78
		private static readonly IntPtr NativeMethodInfoPtr_get_IsInteractable_Private_get_Boolean_0;

		// Token: 0x0400004F RID: 79
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04000050 RID: 80
		private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_EventSystems_IPointerDownHandler_OnPointerDown_Private_Virtual_Final_New_Void_PointerEventData_0;

		// Token: 0x04000051 RID: 81
		private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_EventSystems_IPointerUpHandler_OnPointerUp_Private_Virtual_Final_New_Void_PointerEventData_0;

		// Token: 0x04000052 RID: 82
		private static readonly IntPtr NativeMethodInfoPtr_OnPointerEnter_Public_Virtual_Final_New_Void_PointerEventData_0;

		// Token: 0x04000053 RID: 83
		private static readonly IntPtr NativeMethodInfoPtr_OnPointerExit_Public_Virtual_Final_New_Void_PointerEventData_0;

		// Token: 0x04000054 RID: 84
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;

		// Token: 0x04000055 RID: 85
		private static readonly IntPtr NativeMethodInfoPtr_stopWithin_Private_Void_0;

		// Token: 0x04000056 RID: 86
		private static readonly IntPtr NativeMethodInfoPtr_OnSelect_Public_Virtual_Final_New_Void_BaseEventData_0;

		// Token: 0x04000057 RID: 87
		private static readonly IntPtr NativeMethodInfoPtr_OnSubmit_Public_Virtual_Final_New_Void_0;

		// Token: 0x04000058 RID: 88
		private static readonly IntPtr NativeMethodInfoPtr_OnSubmit_Public_Virtual_Final_New_Void_BaseEventData_0;

		// Token: 0x04000059 RID: 89
		private static readonly IntPtr NativeMethodInfoPtr_OnCancel_Public_Virtual_Final_New_Void_BaseEventData_0;

		// Token: 0x0400005A RID: 90
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
