using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.Localization.Settings;
using UnityEngine.Localization.Tables;

namespace UnityEngine.Localization
{
	// Token: 0x02000013 RID: 19
	[Serializable]
	public class LocalizedReference : Object
	{
		// Token: 0x060000B6 RID: 182 RVA: 0x0000BA48 File Offset: 0x00009C48
		// Note: this type is marked as 'beforefieldinit'.
		static LocalizedReference()
		{
			Il2CppClassPointerStore<LocalizedReference>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Localization.dll", "UnityEngine.Localization", "LocalizedReference");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LocalizedReference>.NativeClassPtr);
			LocalizedReference.NativeFieldInfoPtr_m_TableReference = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalizedReference>.NativeClassPtr, "m_TableReference");
			LocalizedReference.NativeFieldInfoPtr_m_TableEntryReference = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalizedReference>.NativeClassPtr, "m_TableEntryReference");
			LocalizedReference.NativeFieldInfoPtr_m_FallbackState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalizedReference>.NativeClassPtr, "m_FallbackState");
			LocalizedReference.NativeFieldInfoPtr_m_WaitForCompletion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalizedReference>.NativeClassPtr, "m_WaitForCompletion");
			LocalizedReference.NativeFieldInfoPtr_m_LocaleOverride = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalizedReference>.NativeClassPtr, "m_LocaleOverride");
			LocalizedReference.NativeMethodInfoPtr_get_TableReference_Public_get_TableReference_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedReference>.NativeClassPtr, 100663431);
			LocalizedReference.NativeMethodInfoPtr_set_TableReference_Public_set_Void_TableReference_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedReference>.NativeClassPtr, 100663432);
			LocalizedReference.NativeMethodInfoPtr_get_TableEntryReference_Public_get_TableEntryReference_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedReference>.NativeClassPtr, 100663433);
			LocalizedReference.NativeMethodInfoPtr_set_TableEntryReference_Public_set_Void_TableEntryReference_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedReference>.NativeClassPtr, 100663434);
			LocalizedReference.NativeMethodInfoPtr_get_FallbackState_Public_get_FallbackBehavior_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedReference>.NativeClassPtr, 100663435);
			LocalizedReference.NativeMethodInfoPtr_set_FallbackState_Public_set_Void_FallbackBehavior_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedReference>.NativeClassPtr, 100663436);
			LocalizedReference.NativeMethodInfoPtr_get_LocaleOverride_Public_get_Locale_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedReference>.NativeClassPtr, 100663437);
			LocalizedReference.NativeMethodInfoPtr_set_LocaleOverride_Public_set_Void_Locale_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedReference>.NativeClassPtr, 100663438);
			LocalizedReference.NativeMethodInfoPtr_get_WaitForCompletion_Public_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedReference>.NativeClassPtr, 100663439);
			LocalizedReference.NativeMethodInfoPtr_set_WaitForCompletion_Public_Virtual_New_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedReference>.NativeClassPtr, 100663440);
			LocalizedReference.NativeMethodInfoPtr_get_ForceSynchronous_Internal_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedReference>.NativeClassPtr, 100663441);
			LocalizedReference.NativeMethodInfoPtr_get_IsEmpty_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedReference>.NativeClassPtr, 100663442);
			LocalizedReference.NativeMethodInfoPtr_SetReference_Public_Void_TableReference_TableEntryReference_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedReference>.NativeClassPtr, 100663443);
			LocalizedReference.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedReference>.NativeClassPtr, 100663444);
			LocalizedReference.NativeMethodInfoPtr_ForceUpdate_FamOrAssem_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedReference>.NativeClassPtr, 100663445);
			LocalizedReference.NativeMethodInfoPtr_Reset_Protected_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedReference>.NativeClassPtr, 100663446);
			LocalizedReference.NativeMethodInfoPtr_OnBeforeSerialize_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedReference>.NativeClassPtr, 100663447);
			LocalizedReference.NativeMethodInfoPtr_OnAfterDeserialize_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedReference>.NativeClassPtr, 100663448);
			LocalizedReference.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedReference>.NativeClassPtr, 100663449);
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x060000B7 RID: 183 RVA: 0x0000BC58 File Offset: 0x00009E58
		// (set) Token: 0x060000B8 RID: 184 RVA: 0x0000BC90 File Offset: 0x00009E90
		public unsafe TableReference TableReference
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizedReference.NativeMethodInfoPtr_get_TableReference_Public_get_TableReference_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new TableReference(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1065572, RefRangeEnd = 1065573, XrefRangeStart = 1065567, XrefRangeEnd = 1065572, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizedReference.NativeMethodInfoPtr_set_TableReference_Public_set_Void_TableReference_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x060000B9 RID: 185 RVA: 0x0000BCD8 File Offset: 0x00009ED8
		// (set) Token: 0x060000BA RID: 186 RVA: 0x0000BD10 File Offset: 0x00009F10
		public unsafe TableEntryReference TableEntryReference
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizedReference.NativeMethodInfoPtr_get_TableEntryReference_Public_get_TableEntryReference_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new TableEntryReference(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1065576, RefRangeEnd = 1065577, XrefRangeStart = 1065573, XrefRangeEnd = 1065576, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizedReference.NativeMethodInfoPtr_set_TableEntryReference_Public_set_Void_TableEntryReference_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x060000BB RID: 187 RVA: 0x0000BD58 File Offset: 0x00009F58
		// (set) Token: 0x060000BC RID: 188 RVA: 0x0000BD94 File Offset: 0x00009F94
		public unsafe FallbackBehavior FallbackState
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 366305, RefRangeEnd = 366308, XrefRangeStart = 366305, XrefRangeEnd = 366308, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizedReference.NativeMethodInfoPtr_get_FallbackState_Public_get_FallbackBehavior_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizedReference.NativeMethodInfoPtr_set_FallbackState_Public_set_Void_FallbackBehavior_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x060000BD RID: 189 RVA: 0x0000BDD4 File Offset: 0x00009FD4
		// (set) Token: 0x060000BE RID: 190 RVA: 0x0000BE14 File Offset: 0x0000A014
		public unsafe Locale LocaleOverride
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 129671, RefRangeEnd = 129672, XrefRangeStart = 129671, XrefRangeEnd = 129672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizedReference.NativeMethodInfoPtr_get_LocaleOverride_Public_get_Locale_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Locale>(intPtr3) : null;
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1065582, RefRangeEnd = 1065584, XrefRangeStart = 1065577, XrefRangeEnd = 1065582, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizedReference.NativeMethodInfoPtr_set_LocaleOverride_Public_set_Void_Locale_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x060000BF RID: 191 RVA: 0x0000BE58 File Offset: 0x0000A058
		// (set) Token: 0x060000C0 RID: 192 RVA: 0x0000BEA0 File Offset: 0x0000A0A0
		public unsafe virtual bool WaitForCompletion
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LocalizedReference.NativeMethodInfoPtr_get_WaitForCompletion_Public_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LocalizedReference.NativeMethodInfoPtr_set_WaitForCompletion_Public_Virtual_New_set_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x060000C1 RID: 193 RVA: 0x0000BEEC File Offset: 0x0000A0EC
		public unsafe virtual bool ForceSynchronous
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LocalizedReference.NativeMethodInfoPtr_get_ForceSynchronous_Internal_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x060000C2 RID: 194 RVA: 0x0000BF34 File Offset: 0x0000A134
		public unsafe bool IsEmpty
		{
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 1065587, RefRangeEnd = 1065595, XrefRangeStart = 1065584, XrefRangeEnd = 1065587, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizedReference.NativeMethodInfoPtr_get_IsEmpty_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000C3 RID: 195 RVA: 0x0000BF70 File Offset: 0x0000A170
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1065595, XrefRangeEnd = 1065604, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetReference(TableReference table, TableEntryReference entry)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(table));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(entry));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizedReference.NativeMethodInfoPtr_SetReference_Public_Void_TableReference_TableEntryReference_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000C4 RID: 196 RVA: 0x0000BFD0 File Offset: 0x0000A1D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1065604, XrefRangeEnd = 1065611, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LocalizedReference.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060000C5 RID: 197 RVA: 0x0000C014 File Offset: 0x0000A214
		[CallerCount(0)]
		public unsafe virtual void ForceUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LocalizedReference.NativeMethodInfoPtr_ForceUpdate_FamOrAssem_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000C6 RID: 198 RVA: 0x0000C050 File Offset: 0x0000A250
		[CallerCount(0)]
		public unsafe virtual void Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LocalizedReference.NativeMethodInfoPtr_Reset_Protected_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000C7 RID: 199 RVA: 0x0000C08C File Offset: 0x0000A28C
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnBeforeSerialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LocalizedReference.NativeMethodInfoPtr_OnBeforeSerialize_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000C8 RID: 200 RVA: 0x0000C0C8 File Offset: 0x0000A2C8
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnAfterDeserialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LocalizedReference.NativeMethodInfoPtr_OnAfterDeserialize_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000C9 RID: 201 RVA: 0x0000C104 File Offset: 0x0000A304
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LocalizedReference()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LocalizedReference>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizedReference.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000CA RID: 202 RVA: 0x00002532 File Offset: 0x00000732
		public LocalizedReference(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x060000CB RID: 203 RVA: 0x0000C140 File Offset: 0x0000A340
		// (set) Token: 0x060000CC RID: 204 RVA: 0x0000253B File Offset: 0x0000073B
		public TableReference m_TableReference
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalizedReference.NativeFieldInfoPtr_m_TableReference);
				return new TableReference(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TableReference>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalizedReference.NativeFieldInfoPtr_m_TableReference), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TableReference>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x060000CD RID: 205 RVA: 0x0000C170 File Offset: 0x0000A370
		// (set) Token: 0x060000CE RID: 206 RVA: 0x00002569 File Offset: 0x00000769
		public TableEntryReference m_TableEntryReference
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalizedReference.NativeFieldInfoPtr_m_TableEntryReference);
				return new TableEntryReference(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TableEntryReference>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalizedReference.NativeFieldInfoPtr_m_TableEntryReference), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TableEntryReference>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x060000CF RID: 207 RVA: 0x0000C1A0 File Offset: 0x0000A3A0
		// (set) Token: 0x060000D0 RID: 208 RVA: 0x00002597 File Offset: 0x00000797
		public unsafe FallbackBehavior m_FallbackState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalizedReference.NativeFieldInfoPtr_m_FallbackState);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalizedReference.NativeFieldInfoPtr_m_FallbackState)) = value;
			}
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x060000D1 RID: 209 RVA: 0x0000C1C8 File Offset: 0x0000A3C8
		// (set) Token: 0x060000D2 RID: 210 RVA: 0x000025B2 File Offset: 0x000007B2
		public unsafe bool m_WaitForCompletion
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalizedReference.NativeFieldInfoPtr_m_WaitForCompletion);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalizedReference.NativeFieldInfoPtr_m_WaitForCompletion)) = value;
			}
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x060000D3 RID: 211 RVA: 0x0000C1F0 File Offset: 0x0000A3F0
		// (set) Token: 0x060000D4 RID: 212 RVA: 0x000025CD File Offset: 0x000007CD
		public unsafe Locale m_LocaleOverride
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalizedReference.NativeFieldInfoPtr_m_LocaleOverride);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Locale>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalizedReference.NativeFieldInfoPtr_m_LocaleOverride), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000082 RID: 130
		private static readonly IntPtr NativeFieldInfoPtr_m_TableReference;

		// Token: 0x04000083 RID: 131
		private static readonly IntPtr NativeFieldInfoPtr_m_TableEntryReference;

		// Token: 0x04000084 RID: 132
		private static readonly IntPtr NativeFieldInfoPtr_m_FallbackState;

		// Token: 0x04000085 RID: 133
		private static readonly IntPtr NativeFieldInfoPtr_m_WaitForCompletion;

		// Token: 0x04000086 RID: 134
		private static readonly IntPtr NativeFieldInfoPtr_m_LocaleOverride;

		// Token: 0x04000087 RID: 135
		private static readonly IntPtr NativeMethodInfoPtr_get_TableReference_Public_get_TableReference_0;

		// Token: 0x04000088 RID: 136
		private static readonly IntPtr NativeMethodInfoPtr_set_TableReference_Public_set_Void_TableReference_0;

		// Token: 0x04000089 RID: 137
		private static readonly IntPtr NativeMethodInfoPtr_get_TableEntryReference_Public_get_TableEntryReference_0;

		// Token: 0x0400008A RID: 138
		private static readonly IntPtr NativeMethodInfoPtr_set_TableEntryReference_Public_set_Void_TableEntryReference_0;

		// Token: 0x0400008B RID: 139
		private static readonly IntPtr NativeMethodInfoPtr_get_FallbackState_Public_get_FallbackBehavior_0;

		// Token: 0x0400008C RID: 140
		private static readonly IntPtr NativeMethodInfoPtr_set_FallbackState_Public_set_Void_FallbackBehavior_0;

		// Token: 0x0400008D RID: 141
		private static readonly IntPtr NativeMethodInfoPtr_get_LocaleOverride_Public_get_Locale_0;

		// Token: 0x0400008E RID: 142
		private static readonly IntPtr NativeMethodInfoPtr_set_LocaleOverride_Public_set_Void_Locale_0;

		// Token: 0x0400008F RID: 143
		private static readonly IntPtr NativeMethodInfoPtr_get_WaitForCompletion_Public_Virtual_New_get_Boolean_0;

		// Token: 0x04000090 RID: 144
		private static readonly IntPtr NativeMethodInfoPtr_set_WaitForCompletion_Public_Virtual_New_set_Void_Boolean_0;

		// Token: 0x04000091 RID: 145
		private static readonly IntPtr NativeMethodInfoPtr_get_ForceSynchronous_Internal_Abstract_Virtual_New_get_Boolean_0;

		// Token: 0x04000092 RID: 146
		private static readonly IntPtr NativeMethodInfoPtr_get_IsEmpty_Public_get_Boolean_0;

		// Token: 0x04000093 RID: 147
		private static readonly IntPtr NativeMethodInfoPtr_SetReference_Public_Void_TableReference_TableEntryReference_0;

		// Token: 0x04000094 RID: 148
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04000095 RID: 149
		private static readonly IntPtr NativeMethodInfoPtr_ForceUpdate_FamOrAssem_Abstract_Virtual_New_Void_0;

		// Token: 0x04000096 RID: 150
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Protected_Abstract_Virtual_New_Void_0;

		// Token: 0x04000097 RID: 151
		private static readonly IntPtr NativeMethodInfoPtr_OnBeforeSerialize_Public_Virtual_New_Void_0;

		// Token: 0x04000098 RID: 152
		private static readonly IntPtr NativeMethodInfoPtr_OnAfterDeserialize_Public_Virtual_New_Void_0;

		// Token: 0x04000099 RID: 153
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
