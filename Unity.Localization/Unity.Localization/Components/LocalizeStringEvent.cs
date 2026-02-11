using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine.Localization.Events;

namespace UnityEngine.Localization.Components
{
	// Token: 0x020000CB RID: 203
	public class LocalizeStringEvent : LocalizedMonoBehaviour
	{
		// Token: 0x06000A9A RID: 2714 RVA: 0x00031404 File Offset: 0x0002F604
		// Note: this type is marked as 'beforefieldinit'.
		static LocalizeStringEvent()
		{
			Il2CppClassPointerStore<LocalizeStringEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Localization.dll", "UnityEngine.Localization.Components", "LocalizeStringEvent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LocalizeStringEvent>.NativeClassPtr);
			LocalizeStringEvent.NativeFieldInfoPtr_m_StringReference = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalizeStringEvent>.NativeClassPtr, "m_StringReference");
			LocalizeStringEvent.NativeFieldInfoPtr_m_FormatArguments = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalizeStringEvent>.NativeClassPtr, "m_FormatArguments");
			LocalizeStringEvent.NativeFieldInfoPtr_m_UpdateString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalizeStringEvent>.NativeClassPtr, "m_UpdateString");
			LocalizeStringEvent.NativeFieldInfoPtr_m_ChangeHandler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalizeStringEvent>.NativeClassPtr, "m_ChangeHandler");
			LocalizeStringEvent.NativeMethodInfoPtr_get_StringReference_Public_get_LocalizedString_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizeStringEvent>.NativeClassPtr, 100665068);
			LocalizeStringEvent.NativeMethodInfoPtr_set_StringReference_Public_set_Void_LocalizedString_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizeStringEvent>.NativeClassPtr, 100665069);
			LocalizeStringEvent.NativeMethodInfoPtr_get_OnUpdateString_Public_get_UnityEventString_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizeStringEvent>.NativeClassPtr, 100665070);
			LocalizeStringEvent.NativeMethodInfoPtr_set_OnUpdateString_Public_set_Void_UnityEventString_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizeStringEvent>.NativeClassPtr, 100665071);
			LocalizeStringEvent.NativeMethodInfoPtr_RefreshString_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizeStringEvent>.NativeClassPtr, 100665072);
			LocalizeStringEvent.NativeMethodInfoPtr_SetTable_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizeStringEvent>.NativeClassPtr, 100665073);
			LocalizeStringEvent.NativeMethodInfoPtr_SetEntry_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizeStringEvent>.NativeClassPtr, 100665074);
			LocalizeStringEvent.NativeMethodInfoPtr_OnEnable_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizeStringEvent>.NativeClassPtr, 100665075);
			LocalizeStringEvent.NativeMethodInfoPtr_OnDisable_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizeStringEvent>.NativeClassPtr, 100665076);
			LocalizeStringEvent.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizeStringEvent>.NativeClassPtr, 100665077);
			LocalizeStringEvent.NativeMethodInfoPtr_UpdateString_Protected_Virtual_New_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizeStringEvent>.NativeClassPtr, 100665078);
			LocalizeStringEvent.NativeMethodInfoPtr_OnValidate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizeStringEvent>.NativeClassPtr, 100665079);
			LocalizeStringEvent.NativeMethodInfoPtr_RegisterChangeHandler_Internal_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizeStringEvent>.NativeClassPtr, 100665080);
			LocalizeStringEvent.NativeMethodInfoPtr_ClearChangeHandler_Internal_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizeStringEvent>.NativeClassPtr, 100665081);
			LocalizeStringEvent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizeStringEvent>.NativeClassPtr, 100665082);
		}

		// Token: 0x1700030C RID: 780
		// (get) Token: 0x06000A9B RID: 2715 RVA: 0x000315B0 File Offset: 0x0002F7B0
		// (set) Token: 0x06000A9C RID: 2716 RVA: 0x000315F0 File Offset: 0x0002F7F0
		public unsafe LocalizedString StringReference
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizeStringEvent.NativeMethodInfoPtr_get_StringReference_Public_get_LocalizedString_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<LocalizedString>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1078820, XrefRangeEnd = 1078822, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizeStringEvent.NativeMethodInfoPtr_set_StringReference_Public_set_Void_LocalizedString_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700030D RID: 781
		// (get) Token: 0x06000A9D RID: 2717 RVA: 0x00031634 File Offset: 0x0002F834
		// (set) Token: 0x06000A9E RID: 2718 RVA: 0x00031674 File Offset: 0x0002F874
		public unsafe UnityEventString OnUpdateString
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 131885, RefRangeEnd = 131899, XrefRangeStart = 131885, XrefRangeEnd = 131899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizeStringEvent.NativeMethodInfoPtr_get_OnUpdateString_Public_get_UnityEventString_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<UnityEventString>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizeStringEvent.NativeMethodInfoPtr_set_OnUpdateString_Public_set_Void_UnityEventString_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000A9F RID: 2719 RVA: 0x000316B8 File Offset: 0x0002F8B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1078822, XrefRangeEnd = 1078823, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RefreshString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizeStringEvent.NativeMethodInfoPtr_RefreshString_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AA0 RID: 2720 RVA: 0x000316EC File Offset: 0x0002F8EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1078823, XrefRangeEnd = 1078834, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetTable(string tableReference)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(tableReference);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizeStringEvent.NativeMethodInfoPtr_SetTable_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000AA1 RID: 2721 RVA: 0x00031730 File Offset: 0x0002F930
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1078834, XrefRangeEnd = 1078842, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetEntry(string entryName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(entryName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizeStringEvent.NativeMethodInfoPtr_SetEntry_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000AA2 RID: 2722 RVA: 0x00031774 File Offset: 0x0002F974
		[CallerCount(0)]
		public unsafe virtual void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LocalizeStringEvent.NativeMethodInfoPtr_OnEnable_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AA3 RID: 2723 RVA: 0x000317B0 File Offset: 0x0002F9B0
		[CallerCount(0)]
		public unsafe virtual void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LocalizeStringEvent.NativeMethodInfoPtr_OnDisable_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AA4 RID: 2724 RVA: 0x000317EC File Offset: 0x0002F9EC
		[CallerCount(0)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizeStringEvent.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AA5 RID: 2725 RVA: 0x00031820 File Offset: 0x0002FA20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1078842, XrefRangeEnd = 1078846, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void UpdateString(string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LocalizeStringEvent.NativeMethodInfoPtr_UpdateString_Protected_Virtual_New_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000AA6 RID: 2726 RVA: 0x00031870 File Offset: 0x0002FA70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnValidate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizeStringEvent.NativeMethodInfoPtr_OnValidate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AA7 RID: 2727 RVA: 0x000318A4 File Offset: 0x0002FAA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1078846, XrefRangeEnd = 1078875, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RegisterChangeHandler()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LocalizeStringEvent.NativeMethodInfoPtr_RegisterChangeHandler_Internal_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AA8 RID: 2728 RVA: 0x000318E0 File Offset: 0x0002FAE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1078875, XrefRangeEnd = 1078876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ClearChangeHandler()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LocalizeStringEvent.NativeMethodInfoPtr_ClearChangeHandler_Internal_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AA9 RID: 2729 RVA: 0x0003191C File Offset: 0x0002FB1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1078876, XrefRangeEnd = 1078896, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LocalizeStringEvent()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LocalizeStringEvent>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizeStringEvent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AAA RID: 2730 RVA: 0x000066F3 File Offset: 0x000048F3
		public LocalizeStringEvent(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000308 RID: 776
		// (get) Token: 0x06000AAB RID: 2731 RVA: 0x00031958 File Offset: 0x0002FB58
		// (set) Token: 0x06000AAC RID: 2732 RVA: 0x000066FC File Offset: 0x000048FC
		public unsafe LocalizedString m_StringReference
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalizeStringEvent.NativeFieldInfoPtr_m_StringReference);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LocalizedString>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalizeStringEvent.NativeFieldInfoPtr_m_StringReference), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000309 RID: 777
		// (get) Token: 0x06000AAD RID: 2733 RVA: 0x00031988 File Offset: 0x0002FB88
		// (set) Token: 0x06000AAE RID: 2734 RVA: 0x0000671B File Offset: 0x0000491B
		public unsafe List<Object> m_FormatArguments
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalizeStringEvent.NativeFieldInfoPtr_m_FormatArguments);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Object>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalizeStringEvent.NativeFieldInfoPtr_m_FormatArguments), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700030A RID: 778
		// (get) Token: 0x06000AAF RID: 2735 RVA: 0x000319B8 File Offset: 0x0002FBB8
		// (set) Token: 0x06000AB0 RID: 2736 RVA: 0x0000673A File Offset: 0x0000493A
		public unsafe UnityEventString m_UpdateString
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalizeStringEvent.NativeFieldInfoPtr_m_UpdateString);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEventString>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalizeStringEvent.NativeFieldInfoPtr_m_UpdateString), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700030B RID: 779
		// (get) Token: 0x06000AB1 RID: 2737 RVA: 0x000319E8 File Offset: 0x0002FBE8
		// (set) Token: 0x06000AB2 RID: 2738 RVA: 0x00006759 File Offset: 0x00004959
		public unsafe LocalizedString.ChangeHandler m_ChangeHandler
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalizeStringEvent.NativeFieldInfoPtr_m_ChangeHandler);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LocalizedString.ChangeHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalizeStringEvent.NativeFieldInfoPtr_m_ChangeHandler), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400076A RID: 1898
		private static readonly IntPtr NativeFieldInfoPtr_m_StringReference;

		// Token: 0x0400076B RID: 1899
		private static readonly IntPtr NativeFieldInfoPtr_m_FormatArguments;

		// Token: 0x0400076C RID: 1900
		private static readonly IntPtr NativeFieldInfoPtr_m_UpdateString;

		// Token: 0x0400076D RID: 1901
		private static readonly IntPtr NativeFieldInfoPtr_m_ChangeHandler;

		// Token: 0x0400076E RID: 1902
		private static readonly IntPtr NativeMethodInfoPtr_get_StringReference_Public_get_LocalizedString_0;

		// Token: 0x0400076F RID: 1903
		private static readonly IntPtr NativeMethodInfoPtr_set_StringReference_Public_set_Void_LocalizedString_0;

		// Token: 0x04000770 RID: 1904
		private static readonly IntPtr NativeMethodInfoPtr_get_OnUpdateString_Public_get_UnityEventString_0;

		// Token: 0x04000771 RID: 1905
		private static readonly IntPtr NativeMethodInfoPtr_set_OnUpdateString_Public_set_Void_UnityEventString_0;

		// Token: 0x04000772 RID: 1906
		private static readonly IntPtr NativeMethodInfoPtr_RefreshString_Public_Void_0;

		// Token: 0x04000773 RID: 1907
		private static readonly IntPtr NativeMethodInfoPtr_SetTable_Public_Void_String_0;

		// Token: 0x04000774 RID: 1908
		private static readonly IntPtr NativeMethodInfoPtr_SetEntry_Public_Void_String_0;

		// Token: 0x04000775 RID: 1909
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Protected_Virtual_New_Void_0;

		// Token: 0x04000776 RID: 1910
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Protected_Virtual_New_Void_0;

		// Token: 0x04000777 RID: 1911
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x04000778 RID: 1912
		private static readonly IntPtr NativeMethodInfoPtr_UpdateString_Protected_Virtual_New_Void_String_0;

		// Token: 0x04000779 RID: 1913
		private static readonly IntPtr NativeMethodInfoPtr_OnValidate_Private_Void_0;

		// Token: 0x0400077A RID: 1914
		private static readonly IntPtr NativeMethodInfoPtr_RegisterChangeHandler_Internal_Virtual_New_Void_0;

		// Token: 0x0400077B RID: 1915
		private static readonly IntPtr NativeMethodInfoPtr_ClearChangeHandler_Internal_Virtual_New_Void_0;

		// Token: 0x0400077C RID: 1916
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
