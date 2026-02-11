using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine.Localization.SmartFormat.Core.Extensions;
using UnityEngine.Localization.SmartFormat.PersistentVariables;

namespace UnityEngine.Localization.SmartFormat.Extensions
{
	// Token: 0x0200006B RID: 107
	[Serializable]
	public class PersistentVariablesSource : Object
	{
		// Token: 0x060004E4 RID: 1252 RVA: 0x0001BBB0 File Offset: 0x00019DB0
		// Note: this type is marked as 'beforefieldinit'.
		static PersistentVariablesSource()
		{
			Il2CppClassPointerStore<PersistentVariablesSource>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Localization.dll", "UnityEngine.Localization.SmartFormat.Extensions", "PersistentVariablesSource");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PersistentVariablesSource>.NativeClassPtr);
			PersistentVariablesSource.NativeFieldInfoPtr_m_Groups = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PersistentVariablesSource>.NativeClassPtr, "m_Groups");
			PersistentVariablesSource.NativeFieldInfoPtr_m_GroupLookup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PersistentVariablesSource>.NativeClassPtr, "m_GroupLookup");
			PersistentVariablesSource.NativeFieldInfoPtr_s_IsUpdating = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PersistentVariablesSource>.NativeClassPtr, "s_IsUpdating");
			PersistentVariablesSource.NativeFieldInfoPtr_EndUpdate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PersistentVariablesSource>.NativeClassPtr, "EndUpdate");
			PersistentVariablesSource.NativeMethodInfoPtr_get_IsUpdating_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PersistentVariablesSource>.NativeClassPtr, 100664206);
			PersistentVariablesSource.NativeMethodInfoPtr_get_Count_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PersistentVariablesSource>.NativeClassPtr, 100664207);
			PersistentVariablesSource.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PersistentVariablesSource>.NativeClassPtr, 100664208);
			PersistentVariablesSource.NativeMethodInfoPtr_get_Keys_Public_Virtual_Final_New_get_ICollection_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PersistentVariablesSource>.NativeClassPtr, 100664209);
			PersistentVariablesSource.NativeMethodInfoPtr_get_Values_Public_Virtual_Final_New_get_ICollection_1_VariablesGroupAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PersistentVariablesSource>.NativeClassPtr, 100664210);
			PersistentVariablesSource.NativeMethodInfoPtr_get_Item_Public_Virtual_Final_New_get_VariablesGroupAsset_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PersistentVariablesSource>.NativeClassPtr, 100664211);
			PersistentVariablesSource.NativeMethodInfoPtr_set_Item_Public_Virtual_Final_New_set_Void_String_VariablesGroupAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PersistentVariablesSource>.NativeClassPtr, 100664212);
			PersistentVariablesSource.NativeMethodInfoPtr_add_EndUpdate_Public_Static_add_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PersistentVariablesSource>.NativeClassPtr, 100664213);
			PersistentVariablesSource.NativeMethodInfoPtr_remove_EndUpdate_Public_Static_rem_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PersistentVariablesSource>.NativeClassPtr, 100664214);
			PersistentVariablesSource.NativeMethodInfoPtr__ctor_Public_Void_SmartFormatter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PersistentVariablesSource>.NativeClassPtr, 100664215);
			PersistentVariablesSource.NativeMethodInfoPtr_BeginUpdating_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PersistentVariablesSource>.NativeClassPtr, 100664216);
			PersistentVariablesSource.NativeMethodInfoPtr_EndUpdating_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PersistentVariablesSource>.NativeClassPtr, 100664217);
			PersistentVariablesSource.NativeMethodInfoPtr_UpdateScope_Public_Static_IDisposable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PersistentVariablesSource>.NativeClassPtr, 100664218);
			PersistentVariablesSource.NativeMethodInfoPtr_TryGetValue_Public_Virtual_Final_New_Boolean_String_byref_VariablesGroupAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PersistentVariablesSource>.NativeClassPtr, 100664219);
			PersistentVariablesSource.NativeMethodInfoPtr_Add_Public_Virtual_Final_New_Void_String_VariablesGroupAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PersistentVariablesSource>.NativeClassPtr, 100664220);
			PersistentVariablesSource.NativeMethodInfoPtr_Add_Public_Virtual_Final_New_Void_KeyValuePair_2_String_VariablesGroupAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PersistentVariablesSource>.NativeClassPtr, 100664221);
			PersistentVariablesSource.NativeMethodInfoPtr_Remove_Public_Virtual_Final_New_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PersistentVariablesSource>.NativeClassPtr, 100664222);
			PersistentVariablesSource.NativeMethodInfoPtr_Remove_Public_Virtual_Final_New_Boolean_KeyValuePair_2_String_VariablesGroupAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PersistentVariablesSource>.NativeClassPtr, 100664223);
			PersistentVariablesSource.NativeMethodInfoPtr_Clear_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PersistentVariablesSource>.NativeClassPtr, 100664224);
			PersistentVariablesSource.NativeMethodInfoPtr_ContainsKey_Public_Virtual_Final_New_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PersistentVariablesSource>.NativeClassPtr, 100664225);
			PersistentVariablesSource.NativeMethodInfoPtr_Contains_Public_Virtual_Final_New_Boolean_KeyValuePair_2_String_VariablesGroupAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PersistentVariablesSource>.NativeClassPtr, 100664226);
			PersistentVariablesSource.NativeMethodInfoPtr_CopyTo_Public_Virtual_Final_New_Void_Il2CppReferenceArray_1_KeyValuePair_2_String_VariablesGroupAsset_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PersistentVariablesSource>.NativeClassPtr, 100664227);
			PersistentVariablesSource.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_IEnumerator_1_KeyValuePair_2_String_VariablesGroupAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PersistentVariablesSource>.NativeClassPtr, 100664228);
			PersistentVariablesSource.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PersistentVariablesSource>.NativeClassPtr, 100664229);
			PersistentVariablesSource.NativeMethodInfoPtr_TryEvaluateSelector_Public_Virtual_Final_New_Boolean_ISelectorInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PersistentVariablesSource>.NativeClassPtr, 100664230);
			PersistentVariablesSource.NativeMethodInfoPtr_EvaluateLocalGroup_Private_Static_Boolean_ISelectorInfo_IVariableGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PersistentVariablesSource>.NativeClassPtr, 100664231);
			PersistentVariablesSource.NativeMethodInfoPtr_OnBeforeSerialize_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PersistentVariablesSource>.NativeClassPtr, 100664232);
			PersistentVariablesSource.NativeMethodInfoPtr_OnAfterDeserialize_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PersistentVariablesSource>.NativeClassPtr, 100664233);
		}

		// Token: 0x17000136 RID: 310
		// (get) Token: 0x060004E5 RID: 1253 RVA: 0x0001BE60 File Offset: 0x0001A060
		public unsafe static bool IsUpdating
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1072231, RefRangeEnd = 1072232, XrefRangeStart = 1072229, XrefRangeEnd = 1072231, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PersistentVariablesSource.NativeMethodInfoPtr_get_IsUpdating_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000137 RID: 311
		// (get) Token: 0x060004E6 RID: 1254 RVA: 0x0001BE90 File Offset: 0x0001A090
		public unsafe virtual int Count
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1072232, XrefRangeEnd = 1072233, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PersistentVariablesSource.NativeMethodInfoPtr_get_Count_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000138 RID: 312
		// (get) Token: 0x060004E7 RID: 1255 RVA: 0x0001BECC File Offset: 0x0001A0CC
		public unsafe virtual bool IsReadOnly
		{
			[CallerCount(184)]
			[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PersistentVariablesSource.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000139 RID: 313
		// (get) Token: 0x060004E8 RID: 1256 RVA: 0x0001BF08 File Offset: 0x0001A108
		public unsafe virtual ICollection<string> Keys
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1072233, XrefRangeEnd = 1072237, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PersistentVariablesSource.NativeMethodInfoPtr_get_Keys_Public_Virtual_Final_New_get_ICollection_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ICollection<string>>(intPtr3) : null;
			}
		}

		// Token: 0x1700013A RID: 314
		// (get) Token: 0x060004E9 RID: 1257 RVA: 0x0001BF48 File Offset: 0x0001A148
		public unsafe virtual ICollection<VariablesGroupAsset> Values
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1072237, XrefRangeEnd = 1072262, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PersistentVariablesSource.NativeMethodInfoPtr_get_Values_Public_Virtual_Final_New_get_ICollection_1_VariablesGroupAsset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ICollection<VariablesGroupAsset>>(intPtr3) : null;
			}
		}

		// Token: 0x1700013B RID: 315
		public unsafe virtual VariablesGroupAsset this[string name]
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1072262, XrefRangeEnd = 1072265, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PersistentVariablesSource.NativeMethodInfoPtr_get_Item_Public_Virtual_Final_New_get_VariablesGroupAsset_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<VariablesGroupAsset>(intPtr3) : null;
				}
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1072265, XrefRangeEnd = 1072266, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PersistentVariablesSource.NativeMethodInfoPtr_set_Item_Public_Virtual_Final_New_set_Void_String_VariablesGroupAsset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060004EC RID: 1260 RVA: 0x0001C02C File Offset: 0x0001A22C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1072273, RefRangeEnd = 1072274, XrefRangeStart = 1072266, XrefRangeEnd = 1072273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void add_EndUpdate(Action value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PersistentVariablesSource.NativeMethodInfoPtr_add_EndUpdate_Public_Static_add_Void_Action_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060004ED RID: 1261 RVA: 0x0001C064 File Offset: 0x0001A264
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1072281, RefRangeEnd = 1072282, XrefRangeStart = 1072274, XrefRangeEnd = 1072281, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void remove_EndUpdate(Action value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PersistentVariablesSource.NativeMethodInfoPtr_remove_EndUpdate_Public_Static_rem_Void_Action_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060004EE RID: 1262 RVA: 0x0001C09C File Offset: 0x0001A29C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1071864, RefRangeEnd = 1071865, XrefRangeStart = 1071864, XrefRangeEnd = 1071865, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PersistentVariablesSource(SmartFormatter formatter)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PersistentVariablesSource>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(formatter);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PersistentVariablesSource.NativeMethodInfoPtr__ctor_Public_Void_SmartFormatter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060004EF RID: 1263 RVA: 0x0001C0E8 File Offset: 0x0001A2E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1072282, XrefRangeEnd = 1072284, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void BeginUpdating()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PersistentVariablesSource.NativeMethodInfoPtr_BeginUpdating_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004F0 RID: 1264 RVA: 0x0001C110 File Offset: 0x0001A310
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void EndUpdating()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PersistentVariablesSource.NativeMethodInfoPtr_EndUpdating_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004F1 RID: 1265 RVA: 0x0001C138 File Offset: 0x0001A338
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1072284, XrefRangeEnd = 1072289, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IDisposable UpdateScope()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PersistentVariablesSource.NativeMethodInfoPtr_UpdateScope_Public_Static_IDisposable_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IDisposable>(intPtr3) : null;
		}

		// Token: 0x060004F2 RID: 1266 RVA: 0x0001C16C File Offset: 0x0001A36C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1072293, RefRangeEnd = 1072294, XrefRangeStart = 1072289, XrefRangeEnd = 1072293, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool TryGetValue(string name, out VariablesGroupAsset value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(PersistentVariablesSource.NativeMethodInfoPtr_TryGetValue_Public_Virtual_Final_New_Boolean_String_byref_VariablesGroupAsset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			value = ((intPtr4 == 0) ? null : new VariablesGroupAsset(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x060004F3 RID: 1267 RVA: 0x0001C1DC File Offset: 0x0001A3DC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1072317, RefRangeEnd = 1072319, XrefRangeStart = 1072294, XrefRangeEnd = 1072317, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Add(string name, VariablesGroupAsset group)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(group);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PersistentVariablesSource.NativeMethodInfoPtr_Add_Public_Virtual_Final_New_Void_String_VariablesGroupAsset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004F4 RID: 1268 RVA: 0x0001C230 File Offset: 0x0001A430
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1072319, XrefRangeEnd = 1072322, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Add(KeyValuePair<string, VariablesGroupAsset> item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(item));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PersistentVariablesSource.NativeMethodInfoPtr_Add_Public_Virtual_Final_New_Void_KeyValuePair_2_String_VariablesGroupAsset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060004F5 RID: 1269 RVA: 0x0001C278 File Offset: 0x0001A478
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1072322, XrefRangeEnd = 1072327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool Remove(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PersistentVariablesSource.NativeMethodInfoPtr_Remove_Public_Virtual_Final_New_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060004F6 RID: 1270 RVA: 0x0001C2C8 File Offset: 0x0001A4C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1072327, XrefRangeEnd = 1072333, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool Remove(KeyValuePair<string, VariablesGroupAsset> item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(item));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PersistentVariablesSource.NativeMethodInfoPtr_Remove_Public_Virtual_Final_New_Boolean_KeyValuePair_2_String_VariablesGroupAsset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060004F7 RID: 1271 RVA: 0x0001C31C File Offset: 0x0001A51C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1072333, XrefRangeEnd = 1072338, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Clear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PersistentVariablesSource.NativeMethodInfoPtr_Clear_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004F8 RID: 1272 RVA: 0x0001C350 File Offset: 0x0001A550
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1072338, XrefRangeEnd = 1072342, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool ContainsKey(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PersistentVariablesSource.NativeMethodInfoPtr_ContainsKey_Public_Virtual_Final_New_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060004F9 RID: 1273 RVA: 0x0001C3A0 File Offset: 0x0001A5A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1072342, XrefRangeEnd = 1072349, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool Contains(KeyValuePair<string, VariablesGroupAsset> item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(item));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PersistentVariablesSource.NativeMethodInfoPtr_Contains_Public_Virtual_Final_New_Boolean_KeyValuePair_2_String_VariablesGroupAsset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060004FA RID: 1274 RVA: 0x0001C3F4 File Offset: 0x0001A5F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1072349, XrefRangeEnd = 1072369, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void CopyTo(Il2CppReferenceArray<KeyValuePair<string, VariablesGroupAsset>> array, int arrayIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref arrayIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PersistentVariablesSource.NativeMethodInfoPtr_CopyTo_Public_Virtual_Final_New_Void_Il2CppReferenceArray_1_KeyValuePair_2_String_VariablesGroupAsset_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004FB RID: 1275 RVA: 0x0001C444 File Offset: 0x0001A644
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1072369, XrefRangeEnd = 1072374, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerator<KeyValuePair<string, VariablesGroupAsset>> Method_Private_Virtual_Final_New_IEnumerator_1_KeyValuePair_2_String_VariablesGroupAsset_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PersistentVariablesSource.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_IEnumerator_1_KeyValuePair_2_String_VariablesGroupAsset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<KeyValuePair<string, VariablesGroupAsset>>>(intPtr3) : null;
		}

		// Token: 0x060004FC RID: 1276 RVA: 0x0001C484 File Offset: 0x0001A684
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1072374, XrefRangeEnd = 1072379, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerator GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PersistentVariablesSource.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060004FD RID: 1277 RVA: 0x0001C4C4 File Offset: 0x0001A6C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1072379, XrefRangeEnd = 1072397, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool TryEvaluateSelector(ISelectorInfo selectorInfo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(selectorInfo);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PersistentVariablesSource.NativeMethodInfoPtr_TryEvaluateSelector_Public_Virtual_Final_New_Boolean_ISelectorInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060004FE RID: 1278 RVA: 0x0001C514 File Offset: 0x0001A714
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1072424, RefRangeEnd = 1072426, XrefRangeStart = 1072397, XrefRangeEnd = 1072424, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool EvaluateLocalGroup(ISelectorInfo selectorInfo, IVariableGroup variablleGroup)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(selectorInfo);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(variablleGroup);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PersistentVariablesSource.NativeMethodInfoPtr_EvaluateLocalGroup_Private_Static_Boolean_ISelectorInfo_IVariableGroup_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060004FF RID: 1279 RVA: 0x0001C568 File Offset: 0x0001A768
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnBeforeSerialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PersistentVariablesSource.NativeMethodInfoPtr_OnBeforeSerialize_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000500 RID: 1280 RVA: 0x0001C59C File Offset: 0x0001A79C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1072426, XrefRangeEnd = 1072454, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnAfterDeserialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PersistentVariablesSource.NativeMethodInfoPtr_OnAfterDeserialize_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000501 RID: 1281 RVA: 0x00003EB0 File Offset: 0x000020B0
		public PersistentVariablesSource(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000132 RID: 306
		// (get) Token: 0x06000502 RID: 1282 RVA: 0x0001C5D0 File Offset: 0x0001A7D0
		// (set) Token: 0x06000503 RID: 1283 RVA: 0x00003EB9 File Offset: 0x000020B9
		public unsafe List<PersistentVariablesSource.NameValuePair> m_Groups
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PersistentVariablesSource.NativeFieldInfoPtr_m_Groups);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<PersistentVariablesSource.NameValuePair>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PersistentVariablesSource.NativeFieldInfoPtr_m_Groups), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000133 RID: 307
		// (get) Token: 0x06000504 RID: 1284 RVA: 0x0001C600 File Offset: 0x0001A800
		// (set) Token: 0x06000505 RID: 1285 RVA: 0x00003ED8 File Offset: 0x000020D8
		public unsafe Dictionary<string, PersistentVariablesSource.NameValuePair> m_GroupLookup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PersistentVariablesSource.NativeFieldInfoPtr_m_GroupLookup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, PersistentVariablesSource.NameValuePair>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PersistentVariablesSource.NativeFieldInfoPtr_m_GroupLookup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000134 RID: 308
		// (get) Token: 0x06000506 RID: 1286 RVA: 0x0001C630 File Offset: 0x0001A830
		// (set) Token: 0x06000507 RID: 1287 RVA: 0x00003EF7 File Offset: 0x000020F7
		public unsafe static int s_IsUpdating
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(PersistentVariablesSource.NativeFieldInfoPtr_s_IsUpdating, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PersistentVariablesSource.NativeFieldInfoPtr_s_IsUpdating, (void*)(&value));
			}
		}

		// Token: 0x17000135 RID: 309
		// (get) Token: 0x06000508 RID: 1288 RVA: 0x0001C64C File Offset: 0x0001A84C
		// (set) Token: 0x06000509 RID: 1289 RVA: 0x00003F05 File Offset: 0x00002105
		public unsafe static Action EndUpdate
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(PersistentVariablesSource.NativeFieldInfoPtr_EndUpdate, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PersistentVariablesSource.NativeFieldInfoPtr_EndUpdate, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000371 RID: 881
		private static readonly IntPtr NativeFieldInfoPtr_m_Groups;

		// Token: 0x04000372 RID: 882
		private static readonly IntPtr NativeFieldInfoPtr_m_GroupLookup;

		// Token: 0x04000373 RID: 883
		private static readonly IntPtr NativeFieldInfoPtr_s_IsUpdating;

		// Token: 0x04000374 RID: 884
		private static readonly IntPtr NativeFieldInfoPtr_EndUpdate;

		// Token: 0x04000375 RID: 885
		private static readonly IntPtr NativeMethodInfoPtr_get_IsUpdating_Public_Static_get_Boolean_0;

		// Token: 0x04000376 RID: 886
		private static readonly IntPtr NativeMethodInfoPtr_get_Count_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x04000377 RID: 887
		private static readonly IntPtr NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04000378 RID: 888
		private static readonly IntPtr NativeMethodInfoPtr_get_Keys_Public_Virtual_Final_New_get_ICollection_1_String_0;

		// Token: 0x04000379 RID: 889
		private static readonly IntPtr NativeMethodInfoPtr_get_Values_Public_Virtual_Final_New_get_ICollection_1_VariablesGroupAsset_0;

		// Token: 0x0400037A RID: 890
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_Virtual_Final_New_get_VariablesGroupAsset_String_0;

		// Token: 0x0400037B RID: 891
		private static readonly IntPtr NativeMethodInfoPtr_set_Item_Public_Virtual_Final_New_set_Void_String_VariablesGroupAsset_0;

		// Token: 0x0400037C RID: 892
		private static readonly IntPtr NativeMethodInfoPtr_add_EndUpdate_Public_Static_add_Void_Action_0;

		// Token: 0x0400037D RID: 893
		private static readonly IntPtr NativeMethodInfoPtr_remove_EndUpdate_Public_Static_rem_Void_Action_0;

		// Token: 0x0400037E RID: 894
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SmartFormatter_0;

		// Token: 0x0400037F RID: 895
		private static readonly IntPtr NativeMethodInfoPtr_BeginUpdating_Public_Static_Void_0;

		// Token: 0x04000380 RID: 896
		private static readonly IntPtr NativeMethodInfoPtr_EndUpdating_Public_Static_Void_0;

		// Token: 0x04000381 RID: 897
		private static readonly IntPtr NativeMethodInfoPtr_UpdateScope_Public_Static_IDisposable_0;

		// Token: 0x04000382 RID: 898
		private static readonly IntPtr NativeMethodInfoPtr_TryGetValue_Public_Virtual_Final_New_Boolean_String_byref_VariablesGroupAsset_0;

		// Token: 0x04000383 RID: 899
		private static readonly IntPtr NativeMethodInfoPtr_Add_Public_Virtual_Final_New_Void_String_VariablesGroupAsset_0;

		// Token: 0x04000384 RID: 900
		private static readonly IntPtr NativeMethodInfoPtr_Add_Public_Virtual_Final_New_Void_KeyValuePair_2_String_VariablesGroupAsset_0;

		// Token: 0x04000385 RID: 901
		private static readonly IntPtr NativeMethodInfoPtr_Remove_Public_Virtual_Final_New_Boolean_String_0;

		// Token: 0x04000386 RID: 902
		private static readonly IntPtr NativeMethodInfoPtr_Remove_Public_Virtual_Final_New_Boolean_KeyValuePair_2_String_VariablesGroupAsset_0;

		// Token: 0x04000387 RID: 903
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Virtual_Final_New_Void_0;

		// Token: 0x04000388 RID: 904
		private static readonly IntPtr NativeMethodInfoPtr_ContainsKey_Public_Virtual_Final_New_Boolean_String_0;

		// Token: 0x04000389 RID: 905
		private static readonly IntPtr NativeMethodInfoPtr_Contains_Public_Virtual_Final_New_Boolean_KeyValuePair_2_String_VariablesGroupAsset_0;

		// Token: 0x0400038A RID: 906
		private static readonly IntPtr NativeMethodInfoPtr_CopyTo_Public_Virtual_Final_New_Void_Il2CppReferenceArray_1_KeyValuePair_2_String_VariablesGroupAsset_Int32_0;

		// Token: 0x0400038B RID: 907
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Virtual_Final_New_IEnumerator_1_KeyValuePair_2_String_VariablesGroupAsset_0;

		// Token: 0x0400038C RID: 908
		private static readonly IntPtr NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_0;

		// Token: 0x0400038D RID: 909
		private static readonly IntPtr NativeMethodInfoPtr_TryEvaluateSelector_Public_Virtual_Final_New_Boolean_ISelectorInfo_0;

		// Token: 0x0400038E RID: 910
		private static readonly IntPtr NativeMethodInfoPtr_EvaluateLocalGroup_Private_Static_Boolean_ISelectorInfo_IVariableGroup_0;

		// Token: 0x0400038F RID: 911
		private static readonly IntPtr NativeMethodInfoPtr_OnBeforeSerialize_Public_Virtual_Final_New_Void_0;

		// Token: 0x04000390 RID: 912
		private static readonly IntPtr NativeMethodInfoPtr_OnAfterDeserialize_Public_Virtual_Final_New_Void_0;

		// Token: 0x02000144 RID: 324
		[Serializable]
		public class NameValuePair : Object
		{
			// Token: 0x06000E66 RID: 3686 RVA: 0x0003E928 File Offset: 0x0003CB28
			// Note: this type is marked as 'beforefieldinit'.
			static NameValuePair()
			{
				Il2CppClassPointerStore<PersistentVariablesSource.NameValuePair>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PersistentVariablesSource>.NativeClassPtr, "NameValuePair");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PersistentVariablesSource.NameValuePair>.NativeClassPtr);
				PersistentVariablesSource.NameValuePair.NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PersistentVariablesSource.NameValuePair>.NativeClassPtr, "name");
				PersistentVariablesSource.NameValuePair.NativeFieldInfoPtr_group = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PersistentVariablesSource.NameValuePair>.NativeClassPtr, "group");
				PersistentVariablesSource.NameValuePair.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PersistentVariablesSource.NameValuePair>.NativeClassPtr, 100664234);
			}

			// Token: 0x06000E67 RID: 3687 RVA: 0x0003E990 File Offset: 0x0003CB90
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe NameValuePair()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PersistentVariablesSource.NameValuePair>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PersistentVariablesSource.NameValuePair.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000E68 RID: 3688 RVA: 0x00008022 File Offset: 0x00006222
			public NameValuePair(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170003E0 RID: 992
			// (get) Token: 0x06000E69 RID: 3689 RVA: 0x0003E9CC File Offset: 0x0003CBCC
			// (set) Token: 0x06000E6A RID: 3690 RVA: 0x0000802B File Offset: 0x0000622B
			public unsafe string name
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PersistentVariablesSource.NameValuePair.NativeFieldInfoPtr_name);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PersistentVariablesSource.NameValuePair.NativeFieldInfoPtr_name), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170003E1 RID: 993
			// (get) Token: 0x06000E6B RID: 3691 RVA: 0x0003E9F4 File Offset: 0x0003CBF4
			// (set) Token: 0x06000E6C RID: 3692 RVA: 0x0000804A File Offset: 0x0000624A
			public unsafe VariablesGroupAsset group
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PersistentVariablesSource.NameValuePair.NativeFieldInfoPtr_group);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<VariablesGroupAsset>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PersistentVariablesSource.NameValuePair.NativeFieldInfoPtr_group), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040009E9 RID: 2537
			private static readonly IntPtr NativeFieldInfoPtr_name;

			// Token: 0x040009EA RID: 2538
			private static readonly IntPtr NativeFieldInfoPtr_group;

			// Token: 0x040009EB RID: 2539
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000145 RID: 325
		[StructLayout(2)]
		public struct ScopedUpdate
		{
			// Token: 0x06000E6D RID: 3693 RVA: 0x00008069 File Offset: 0x00006269
			// Note: this type is marked as 'beforefieldinit'.
			static ScopedUpdate()
			{
				Il2CppClassPointerStore<PersistentVariablesSource.ScopedUpdate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PersistentVariablesSource>.NativeClassPtr, "ScopedUpdate");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PersistentVariablesSource.ScopedUpdate>.NativeClassPtr);
				PersistentVariablesSource.ScopedUpdate.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PersistentVariablesSource.ScopedUpdate>.NativeClassPtr, 100664235);
			}

			// Token: 0x06000E6E RID: 3694 RVA: 0x0003EA24 File Offset: 0x0003CC24
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1072145, XrefRangeEnd = 1072155, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Dispose()
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PersistentVariablesSource.ScopedUpdate.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000E6F RID: 3695 RVA: 0x0000809D File Offset: 0x0000629D
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PersistentVariablesSource.ScopedUpdate>.NativeClassPtr, ref this));
			}

			// Token: 0x040009EC RID: 2540
			private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
		}

		// Token: 0x02000146 RID: 326
		[ObfuscatedName("UnityEngine.Localization.SmartFormat.Extensions.PersistentVariablesSource+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06000E70 RID: 3696 RVA: 0x0003EA4C File Offset: 0x0003CC4C
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<PersistentVariablesSource.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PersistentVariablesSource>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PersistentVariablesSource.__c>.NativeClassPtr);
				PersistentVariablesSource.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PersistentVariablesSource.__c>.NativeClassPtr, "<>9");
				PersistentVariablesSource.__c.NativeFieldInfoPtr___9__14_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PersistentVariablesSource.__c>.NativeClassPtr, "<>9__14_0");
				PersistentVariablesSource.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PersistentVariablesSource.__c>.NativeClassPtr, 100664237);
				PersistentVariablesSource.__c.NativeMethodInfoPtr__get_Values_b__14_0_Internal_VariablesGroupAsset_NameValuePair_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PersistentVariablesSource.__c>.NativeClassPtr, 100664238);
			}

			// Token: 0x06000E71 RID: 3697 RVA: 0x0003EAC8 File Offset: 0x0003CCC8
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PersistentVariablesSource.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PersistentVariablesSource.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000E72 RID: 3698 RVA: 0x0003EB04 File Offset: 0x0003CD04
			[CallerCount(0)]
			public unsafe VariablesGroupAsset _get_Values_b__14_0(PersistentVariablesSource.NameValuePair k)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(k);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PersistentVariablesSource.__c.NativeMethodInfoPtr__get_Values_b__14_0_Internal_VariablesGroupAsset_NameValuePair_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<VariablesGroupAsset>(intPtr3) : null;
				}
			}

			// Token: 0x06000E73 RID: 3699 RVA: 0x000080AF File Offset: 0x000062AF
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170003E2 RID: 994
			// (get) Token: 0x06000E74 RID: 3700 RVA: 0x0003EB54 File Offset: 0x0003CD54
			// (set) Token: 0x06000E75 RID: 3701 RVA: 0x000080B8 File Offset: 0x000062B8
			public unsafe static PersistentVariablesSource.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PersistentVariablesSource.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PersistentVariablesSource.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PersistentVariablesSource.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170003E3 RID: 995
			// (get) Token: 0x06000E76 RID: 3702 RVA: 0x0003EB7C File Offset: 0x0003CD7C
			// (set) Token: 0x06000E77 RID: 3703 RVA: 0x000080CA File Offset: 0x000062CA
			public unsafe static Func<PersistentVariablesSource.NameValuePair, VariablesGroupAsset> __9__14_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PersistentVariablesSource.__c.NativeFieldInfoPtr___9__14_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<PersistentVariablesSource.NameValuePair, VariablesGroupAsset>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PersistentVariablesSource.__c.NativeFieldInfoPtr___9__14_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040009ED RID: 2541
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040009EE RID: 2542
			private static readonly IntPtr NativeFieldInfoPtr___9__14_0;

			// Token: 0x040009EF RID: 2543
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040009F0 RID: 2544
			private static readonly IntPtr NativeMethodInfoPtr__get_Values_b__14_0_Internal_VariablesGroupAsset_NameValuePair_0;
		}

		// Token: 0x02000147 RID: 327
		[ObfuscatedName("UnityEngine.Localization.SmartFormat.Extensions.PersistentVariablesSource+<GetEnumerator>d__35")]
		public sealed class _GetEnumerator_d__35 : Object
		{
			// Token: 0x06000E78 RID: 3704 RVA: 0x0003EBA4 File Offset: 0x0003CDA4
			// Note: this type is marked as 'beforefieldinit'.
			static _GetEnumerator_d__35()
			{
				Il2CppClassPointerStore<PersistentVariablesSource._GetEnumerator_d__35>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PersistentVariablesSource>.NativeClassPtr, "<GetEnumerator>d__35");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PersistentVariablesSource._GetEnumerator_d__35>.NativeClassPtr);
				PersistentVariablesSource._GetEnumerator_d__35.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PersistentVariablesSource._GetEnumerator_d__35>.NativeClassPtr, "<>1__state");
				PersistentVariablesSource._GetEnumerator_d__35.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PersistentVariablesSource._GetEnumerator_d__35>.NativeClassPtr, "<>2__current");
				PersistentVariablesSource._GetEnumerator_d__35.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PersistentVariablesSource._GetEnumerator_d__35>.NativeClassPtr, "<>4__this");
				PersistentVariablesSource._GetEnumerator_d__35.NativeFieldInfoPtr___7__wrap1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PersistentVariablesSource._GetEnumerator_d__35>.NativeClassPtr, "<>7__wrap1");
				PersistentVariablesSource._GetEnumerator_d__35.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PersistentVariablesSource._GetEnumerator_d__35>.NativeClassPtr, 100664239);
				PersistentVariablesSource._GetEnumerator_d__35.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PersistentVariablesSource._GetEnumerator_d__35>.NativeClassPtr, 100664240);
				PersistentVariablesSource._GetEnumerator_d__35.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PersistentVariablesSource._GetEnumerator_d__35>.NativeClassPtr, 100664241);
				PersistentVariablesSource._GetEnumerator_d__35.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PersistentVariablesSource._GetEnumerator_d__35>.NativeClassPtr, 100664242);
				PersistentVariablesSource._GetEnumerator_d__35.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PersistentVariablesSource._GetEnumerator_d__35>.NativeClassPtr, 100664243);
				PersistentVariablesSource._GetEnumerator_d__35.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PersistentVariablesSource._GetEnumerator_d__35>.NativeClassPtr, 100664244);
				PersistentVariablesSource._GetEnumerator_d__35.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PersistentVariablesSource._GetEnumerator_d__35>.NativeClassPtr, 100664245);
			}

			// Token: 0x06000E79 RID: 3705 RVA: 0x0003ECAC File Offset: 0x0003CEAC
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _GetEnumerator_d__35(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PersistentVariablesSource._GetEnumerator_d__35>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PersistentVariablesSource._GetEnumerator_d__35.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000E7A RID: 3706 RVA: 0x0003ECF4 File Offset: 0x0003CEF4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1072155, XrefRangeEnd = 1072160, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PersistentVariablesSource._GetEnumerator_d__35.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000E7B RID: 3707 RVA: 0x0003ED28 File Offset: 0x0003CF28
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1072160, XrefRangeEnd = 1072184, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PersistentVariablesSource._GetEnumerator_d__35.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06000E7C RID: 3708 RVA: 0x0003ED64 File Offset: 0x0003CF64
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1072184, XrefRangeEnd = 1072187, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PersistentVariablesSource._GetEnumerator_d__35.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170003E8 RID: 1000
			// (get) Token: 0x06000E7D RID: 3709 RVA: 0x0003ED98 File Offset: 0x0003CF98
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PersistentVariablesSource._GetEnumerator_d__35.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06000E7E RID: 3710 RVA: 0x0003EDD8 File Offset: 0x0003CFD8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1072187, XrefRangeEnd = 1072192, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PersistentVariablesSource._GetEnumerator_d__35.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170003E9 RID: 1001
			// (get) Token: 0x06000E7F RID: 3711 RVA: 0x0003EE0C File Offset: 0x0003D00C
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PersistentVariablesSource._GetEnumerator_d__35.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06000E80 RID: 3712 RVA: 0x000080DC File Offset: 0x000062DC
			public _GetEnumerator_d__35(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170003E4 RID: 996
			// (get) Token: 0x06000E81 RID: 3713 RVA: 0x0003EE4C File Offset: 0x0003D04C
			// (set) Token: 0x06000E82 RID: 3714 RVA: 0x000080E5 File Offset: 0x000062E5
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PersistentVariablesSource._GetEnumerator_d__35.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PersistentVariablesSource._GetEnumerator_d__35.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170003E5 RID: 997
			// (get) Token: 0x06000E83 RID: 3715 RVA: 0x0003EE74 File Offset: 0x0003D074
			// (set) Token: 0x06000E84 RID: 3716 RVA: 0x00008100 File Offset: 0x00006300
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PersistentVariablesSource._GetEnumerator_d__35.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PersistentVariablesSource._GetEnumerator_d__35.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170003E6 RID: 998
			// (get) Token: 0x06000E85 RID: 3717 RVA: 0x0003EEA4 File Offset: 0x0003D0A4
			// (set) Token: 0x06000E86 RID: 3718 RVA: 0x0000811F File Offset: 0x0000631F
			public unsafe PersistentVariablesSource __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PersistentVariablesSource._GetEnumerator_d__35.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PersistentVariablesSource>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PersistentVariablesSource._GetEnumerator_d__35.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170003E7 RID: 999
			// (get) Token: 0x06000E87 RID: 3719 RVA: 0x0003EED4 File Offset: 0x0003D0D4
			// (set) Token: 0x06000E88 RID: 3720 RVA: 0x0000813E File Offset: 0x0000633E
			public Dictionary<string, PersistentVariablesSource.NameValuePair>.Enumerator __7__wrap1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PersistentVariablesSource._GetEnumerator_d__35.NativeFieldInfoPtr___7__wrap1);
					return new Dictionary<string, PersistentVariablesSource.NameValuePair>.Enumerator(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Dictionary<string, PersistentVariablesSource.NameValuePair>.Enumerator>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PersistentVariablesSource._GetEnumerator_d__35.NativeFieldInfoPtr___7__wrap1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Dictionary<string, PersistentVariablesSource.NameValuePair>.Enumerator>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x040009F1 RID: 2545
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040009F2 RID: 2546
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040009F3 RID: 2547
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040009F4 RID: 2548
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap1;

			// Token: 0x040009F5 RID: 2549
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040009F6 RID: 2550
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040009F7 RID: 2551
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040009F8 RID: 2552
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x040009F9 RID: 2553
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040009FA RID: 2554
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040009FB RID: 2555
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000148 RID: 328
		[ObfuscatedName("UnityEngine.Localization.SmartFormat.Extensions.PersistentVariablesSource+<System-Collections-Generic-IEnumerable<System-Collections-Generic-KeyValuePair<System-String,UnityEngine-Localization-SmartFormat-PersistentVariables-VariablesGroupAsset>>-GetEnumerator>d__34")]
		public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumeratorIDisposableInKe2StVaPeEnNa2StUnique : Object
		{
			// Token: 0x06000E89 RID: 3721 RVA: 0x0003EF04 File Offset: 0x0003D104
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectCompilerGeneratedNPrivateSealedIEnumeratorIDisposableInKe2StVaPeEnNa2StUnique()
			{
				Il2CppClassPointerStore<PersistentVariablesSource.ObjectCompilerGeneratedNPrivateSealedIEnumeratorIDisposableInKe2StVaPeEnNa2StUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PersistentVariablesSource>.NativeClassPtr, "<System-Collections-Generic-IEnumerable<System-Collections-Generic-KeyValuePair<System-String,UnityEngine-Localization-SmartFormat-PersistentVariables-VariablesGroupAsset>>-GetEnumerator>d__34");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PersistentVariablesSource.ObjectCompilerGeneratedNPrivateSealedIEnumeratorIDisposableInKe2StVaPeEnNa2StUnique>.NativeClassPtr);
				PersistentVariablesSource.ObjectCompilerGeneratedNPrivateSealedIEnumeratorIDisposableInKe2StVaPeEnNa2StUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PersistentVariablesSource.ObjectCompilerGeneratedNPrivateSealedIEnumeratorIDisposableInKe2StVaPeEnNa2StUnique>.NativeClassPtr, "<>1__state");
				PersistentVariablesSource.ObjectCompilerGeneratedNPrivateSealedIEnumeratorIDisposableInKe2StVaPeEnNa2StUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PersistentVariablesSource.ObjectCompilerGeneratedNPrivateSealedIEnumeratorIDisposableInKe2StVaPeEnNa2StUnique>.NativeClassPtr, "<>2__current");
				PersistentVariablesSource.ObjectCompilerGeneratedNPrivateSealedIEnumeratorIDisposableInKe2StVaPeEnNa2StUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PersistentVariablesSource.ObjectCompilerGeneratedNPrivateSealedIEnumeratorIDisposableInKe2StVaPeEnNa2StUnique>.NativeClassPtr, "<>4__this");
				PersistentVariablesSource.ObjectCompilerGeneratedNPrivateSealedIEnumeratorIDisposableInKe2StVaPeEnNa2StUnique.NativeFieldInfoPtr___7__wrap1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PersistentVariablesSource.ObjectCompilerGeneratedNPrivateSealedIEnumeratorIDisposableInKe2StVaPeEnNa2StUnique>.NativeClassPtr, "<>7__wrap1");
				PersistentVariablesSource.ObjectCompilerGeneratedNPrivateSealedIEnumeratorIDisposableInKe2StVaPeEnNa2StUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PersistentVariablesSource.ObjectCompilerGeneratedNPrivateSealedIEnumeratorIDisposableInKe2StVaPeEnNa2StUnique>.NativeClassPtr, 100664246);
				PersistentVariablesSource.ObjectCompilerGeneratedNPrivateSealedIEnumeratorIDisposableInKe2StVaPeEnNa2StUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PersistentVariablesSource.ObjectCompilerGeneratedNPrivateSealedIEnumeratorIDisposableInKe2StVaPeEnNa2StUnique>.NativeClassPtr, 100664247);
				PersistentVariablesSource.ObjectCompilerGeneratedNPrivateSealedIEnumeratorIDisposableInKe2StVaPeEnNa2StUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PersistentVariablesSource.ObjectCompilerGeneratedNPrivateSealedIEnumeratorIDisposableInKe2StVaPeEnNa2StUnique>.NativeClassPtr, 100664248);
				PersistentVariablesSource.ObjectCompilerGeneratedNPrivateSealedIEnumeratorIDisposableInKe2StVaPeEnNa2StUnique.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PersistentVariablesSource.ObjectCompilerGeneratedNPrivateSealedIEnumeratorIDisposableInKe2StVaPeEnNa2StUnique>.NativeClassPtr, 100664249);
				PersistentVariablesSource.ObjectCompilerGeneratedNPrivateSealedIEnumeratorIDisposableInKe2StVaPeEnNa2StUnique.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_KeyValuePair_2_String_VariablesGroupAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PersistentVariablesSource.ObjectCompilerGeneratedNPrivateSealedIEnumeratorIDisposableInKe2StVaPeEnNa2StUnique>.NativeClassPtr, 100664250);
				PersistentVariablesSource.ObjectCompilerGeneratedNPrivateSealedIEnumeratorIDisposableInKe2StVaPeEnNa2StUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PersistentVariablesSource.ObjectCompilerGeneratedNPrivateSealedIEnumeratorIDisposableInKe2StVaPeEnNa2StUnique>.NativeClassPtr, 100664251);
				PersistentVariablesSource.ObjectCompilerGeneratedNPrivateSealedIEnumeratorIDisposableInKe2StVaPeEnNa2StUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PersistentVariablesSource.ObjectCompilerGeneratedNPrivateSealedIEnumeratorIDisposableInKe2StVaPeEnNa2StUnique>.NativeClassPtr, 100664252);
			}

			// Token: 0x06000E8A RID: 3722 RVA: 0x0003F00C File Offset: 0x0003D20C
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumeratorIDisposableInKe2StVaPeEnNa2StUnique(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PersistentVariablesSource.ObjectCompilerGeneratedNPrivateSealedIEnumeratorIDisposableInKe2StVaPeEnNa2StUnique>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PersistentVariablesSource.ObjectCompilerGeneratedNPrivateSealedIEnumeratorIDisposableInKe2StVaPeEnNa2StUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000E8B RID: 3723 RVA: 0x0003F054 File Offset: 0x0003D254
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1072192, XrefRangeEnd = 1072197, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PersistentVariablesSource.ObjectCompilerGeneratedNPrivateSealedIEnumeratorIDisposableInKe2StVaPeEnNa2StUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000E8C RID: 3724 RVA: 0x0003F088 File Offset: 0x0003D288
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1072197, XrefRangeEnd = 1072218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PersistentVariablesSource.ObjectCompilerGeneratedNPrivateSealedIEnumeratorIDisposableInKe2StVaPeEnNa2StUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06000E8D RID: 3725 RVA: 0x0003F0C4 File Offset: 0x0003D2C4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1072218, XrefRangeEnd = 1072221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PersistentVariablesSource.ObjectCompilerGeneratedNPrivateSealedIEnumeratorIDisposableInKe2StVaPeEnNa2StUnique.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170003EE RID: 1006
			// (get) Token: 0x06000E8E RID: 3726 RVA: 0x0003F0F8 File Offset: 0x0003D2F8
			public unsafe KeyValuePair<string, VariablesGroupAsset> prop_KeyValuePair_2_String_VariablesGroupAsset_0
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PersistentVariablesSource.ObjectCompilerGeneratedNPrivateSealedIEnumeratorIDisposableInKe2StVaPeEnNa2StUnique.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_KeyValuePair_2_String_VariablesGroupAsset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return new KeyValuePair<string, VariablesGroupAsset>(intPtr);
				}
			}

			// Token: 0x06000E8F RID: 3727 RVA: 0x0003F130 File Offset: 0x0003D330
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1072221, XrefRangeEnd = 1072226, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PersistentVariablesSource.ObjectCompilerGeneratedNPrivateSealedIEnumeratorIDisposableInKe2StVaPeEnNa2StUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170003EF RID: 1007
			// (get) Token: 0x06000E90 RID: 3728 RVA: 0x0003F164 File Offset: 0x0003D364
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1072226, XrefRangeEnd = 1072229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PersistentVariablesSource.ObjectCompilerGeneratedNPrivateSealedIEnumeratorIDisposableInKe2StVaPeEnNa2StUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06000E91 RID: 3729 RVA: 0x0000816C File Offset: 0x0000636C
			public ObjectCompilerGeneratedNPrivateSealedIEnumeratorIDisposableInKe2StVaPeEnNa2StUnique(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170003EA RID: 1002
			// (get) Token: 0x06000E92 RID: 3730 RVA: 0x0003F1A4 File Offset: 0x0003D3A4
			// (set) Token: 0x06000E93 RID: 3731 RVA: 0x00008175 File Offset: 0x00006375
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PersistentVariablesSource.ObjectCompilerGeneratedNPrivateSealedIEnumeratorIDisposableInKe2StVaPeEnNa2StUnique.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PersistentVariablesSource.ObjectCompilerGeneratedNPrivateSealedIEnumeratorIDisposableInKe2StVaPeEnNa2StUnique.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170003EB RID: 1003
			// (get) Token: 0x06000E94 RID: 3732 RVA: 0x0003F1CC File Offset: 0x0003D3CC
			// (set) Token: 0x06000E95 RID: 3733 RVA: 0x00008190 File Offset: 0x00006390
			public KeyValuePair<string, VariablesGroupAsset> __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PersistentVariablesSource.ObjectCompilerGeneratedNPrivateSealedIEnumeratorIDisposableInKe2StVaPeEnNa2StUnique.NativeFieldInfoPtr___2__current);
					return new KeyValuePair<string, VariablesGroupAsset>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<KeyValuePair<string, VariablesGroupAsset>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PersistentVariablesSource.ObjectCompilerGeneratedNPrivateSealedIEnumeratorIDisposableInKe2StVaPeEnNa2StUnique.NativeFieldInfoPtr___2__current), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<KeyValuePair<string, VariablesGroupAsset>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170003EC RID: 1004
			// (get) Token: 0x06000E96 RID: 3734 RVA: 0x0003F1FC File Offset: 0x0003D3FC
			// (set) Token: 0x06000E97 RID: 3735 RVA: 0x000081BE File Offset: 0x000063BE
			public unsafe PersistentVariablesSource __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PersistentVariablesSource.ObjectCompilerGeneratedNPrivateSealedIEnumeratorIDisposableInKe2StVaPeEnNa2StUnique.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PersistentVariablesSource>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PersistentVariablesSource.ObjectCompilerGeneratedNPrivateSealedIEnumeratorIDisposableInKe2StVaPeEnNa2StUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170003ED RID: 1005
			// (get) Token: 0x06000E98 RID: 3736 RVA: 0x0003F22C File Offset: 0x0003D42C
			// (set) Token: 0x06000E99 RID: 3737 RVA: 0x000081DD File Offset: 0x000063DD
			public Dictionary<string, PersistentVariablesSource.NameValuePair>.Enumerator __7__wrap1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PersistentVariablesSource.ObjectCompilerGeneratedNPrivateSealedIEnumeratorIDisposableInKe2StVaPeEnNa2StUnique.NativeFieldInfoPtr___7__wrap1);
					return new Dictionary<string, PersistentVariablesSource.NameValuePair>.Enumerator(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Dictionary<string, PersistentVariablesSource.NameValuePair>.Enumerator>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PersistentVariablesSource.ObjectCompilerGeneratedNPrivateSealedIEnumeratorIDisposableInKe2StVaPeEnNa2StUnique.NativeFieldInfoPtr___7__wrap1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Dictionary<string, PersistentVariablesSource.NameValuePair>.Enumerator>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x040009FC RID: 2556
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040009FD RID: 2557
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040009FE RID: 2558
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040009FF RID: 2559
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap1;

			// Token: 0x04000A00 RID: 2560
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04000A01 RID: 2561
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000A02 RID: 2562
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04000A03 RID: 2563
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x04000A04 RID: 2564
			private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_KeyValuePair_2_String_VariablesGroupAsset_0;

			// Token: 0x04000A05 RID: 2565
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000A06 RID: 2566
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
