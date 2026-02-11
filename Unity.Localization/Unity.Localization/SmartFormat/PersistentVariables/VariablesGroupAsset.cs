using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine.Localization.SmartFormat.Core.Extensions;

namespace UnityEngine.Localization.SmartFormat.PersistentVariables
{
	// Token: 0x02000058 RID: 88
	public class VariablesGroupAsset : ScriptableObject
	{
		// Token: 0x06000472 RID: 1138 RVA: 0x0001A254 File Offset: 0x00018454
		// Note: this type is marked as 'beforefieldinit'.
		static VariablesGroupAsset()
		{
			Il2CppClassPointerStore<VariablesGroupAsset>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Localization.dll", "UnityEngine.Localization.SmartFormat.PersistentVariables", "VariablesGroupAsset");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VariablesGroupAsset>.NativeClassPtr);
			VariablesGroupAsset.NativeFieldInfoPtr_m_Variables = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VariablesGroupAsset>.NativeClassPtr, "m_Variables");
			VariablesGroupAsset.NativeFieldInfoPtr_m_VariableLookup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VariablesGroupAsset>.NativeClassPtr, "m_VariableLookup");
			VariablesGroupAsset.NativeMethodInfoPtr_get_Count_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VariablesGroupAsset>.NativeClassPtr, 100664123);
			VariablesGroupAsset.NativeMethodInfoPtr_get_Keys_Public_Virtual_Final_New_get_ICollection_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VariablesGroupAsset>.NativeClassPtr, 100664124);
			VariablesGroupAsset.NativeMethodInfoPtr_get_Values_Public_Virtual_Final_New_get_ICollection_1_IVariable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VariablesGroupAsset>.NativeClassPtr, 100664125);
			VariablesGroupAsset.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VariablesGroupAsset>.NativeClassPtr, 100664126);
			VariablesGroupAsset.NativeMethodInfoPtr_get_Item_Public_Virtual_Final_New_get_IVariable_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VariablesGroupAsset>.NativeClassPtr, 100664127);
			VariablesGroupAsset.NativeMethodInfoPtr_set_Item_Public_Virtual_Final_New_set_Void_String_IVariable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VariablesGroupAsset>.NativeClassPtr, 100664128);
			VariablesGroupAsset.NativeMethodInfoPtr_GetSourceValue_Public_Virtual_Final_New_Object_ISelectorInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VariablesGroupAsset>.NativeClassPtr, 100664129);
			VariablesGroupAsset.NativeMethodInfoPtr_TryGetValue_Public_Virtual_Final_New_Boolean_String_byref_IVariable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VariablesGroupAsset>.NativeClassPtr, 100664130);
			VariablesGroupAsset.NativeMethodInfoPtr_Add_Public_Virtual_Final_New_Void_String_IVariable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VariablesGroupAsset>.NativeClassPtr, 100664131);
			VariablesGroupAsset.NativeMethodInfoPtr_Add_Public_Virtual_Final_New_Void_KeyValuePair_2_String_IVariable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VariablesGroupAsset>.NativeClassPtr, 100664132);
			VariablesGroupAsset.NativeMethodInfoPtr_Remove_Public_Virtual_Final_New_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VariablesGroupAsset>.NativeClassPtr, 100664133);
			VariablesGroupAsset.NativeMethodInfoPtr_Remove_Public_Virtual_Final_New_Boolean_KeyValuePair_2_String_IVariable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VariablesGroupAsset>.NativeClassPtr, 100664134);
			VariablesGroupAsset.NativeMethodInfoPtr_ContainsKey_Public_Virtual_Final_New_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VariablesGroupAsset>.NativeClassPtr, 100664135);
			VariablesGroupAsset.NativeMethodInfoPtr_Contains_Public_Virtual_Final_New_Boolean_KeyValuePair_2_String_IVariable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VariablesGroupAsset>.NativeClassPtr, 100664136);
			VariablesGroupAsset.NativeMethodInfoPtr_CopyTo_Public_Virtual_Final_New_Void_Il2CppReferenceArray_1_KeyValuePair_2_String_IVariable_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VariablesGroupAsset>.NativeClassPtr, 100664137);
			VariablesGroupAsset.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_IEnumerator_1_KeyValuePair_2_String_IVariable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VariablesGroupAsset>.NativeClassPtr, 100664138);
			VariablesGroupAsset.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VariablesGroupAsset>.NativeClassPtr, 100664139);
			VariablesGroupAsset.NativeMethodInfoPtr_ContainsName_Public_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VariablesGroupAsset>.NativeClassPtr, 100664140);
			VariablesGroupAsset.NativeMethodInfoPtr_Clear_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VariablesGroupAsset>.NativeClassPtr, 100664141);
			VariablesGroupAsset.NativeMethodInfoPtr_OnBeforeSerialize_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VariablesGroupAsset>.NativeClassPtr, 100664142);
			VariablesGroupAsset.NativeMethodInfoPtr_OnAfterDeserialize_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VariablesGroupAsset>.NativeClassPtr, 100664143);
			VariablesGroupAsset.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VariablesGroupAsset>.NativeClassPtr, 100664144);
		}

		// Token: 0x17000120 RID: 288
		// (get) Token: 0x06000473 RID: 1139 RVA: 0x0001A464 File Offset: 0x00018664
		public unsafe virtual int Count
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1071280, XrefRangeEnd = 1071284, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VariablesGroupAsset.NativeMethodInfoPtr_get_Count_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000121 RID: 289
		// (get) Token: 0x06000474 RID: 1140 RVA: 0x0001A4A0 File Offset: 0x000186A0
		public unsafe virtual ICollection<string> Keys
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1071284, XrefRangeEnd = 1071288, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VariablesGroupAsset.NativeMethodInfoPtr_get_Keys_Public_Virtual_Final_New_get_ICollection_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ICollection<string>>(intPtr3) : null;
			}
		}

		// Token: 0x17000122 RID: 290
		// (get) Token: 0x06000475 RID: 1141 RVA: 0x0001A4E0 File Offset: 0x000186E0
		public unsafe virtual ICollection<IVariable> Values
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1071288, XrefRangeEnd = 1071313, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VariablesGroupAsset.NativeMethodInfoPtr_get_Values_Public_Virtual_Final_New_get_ICollection_1_IVariable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ICollection<IVariable>>(intPtr3) : null;
			}
		}

		// Token: 0x17000123 RID: 291
		// (get) Token: 0x06000476 RID: 1142 RVA: 0x0001A520 File Offset: 0x00018720
		public unsafe virtual bool IsReadOnly
		{
			[CallerCount(184)]
			[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VariablesGroupAsset.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000124 RID: 292
		public unsafe virtual IVariable this[string name]
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1071313, XrefRangeEnd = 1071316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VariablesGroupAsset.NativeMethodInfoPtr_get_Item_Public_Virtual_Final_New_get_IVariable_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IVariable>(intPtr3) : null;
				}
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1071316, XrefRangeEnd = 1071337, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VariablesGroupAsset.NativeMethodInfoPtr_set_Item_Public_Virtual_Final_New_set_Void_String_IVariable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000479 RID: 1145 RVA: 0x0001A600 File Offset: 0x00018800
		[CallerCount(1295)]
		[CachedScanResults(RefRangeStart = 308780, RefRangeEnd = 310075, XrefRangeStart = 308780, XrefRangeEnd = 310075, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Object GetSourceValue(ISelectorInfo _)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VariablesGroupAsset.NativeMethodInfoPtr_GetSourceValue_Public_Virtual_Final_New_Object_ISelectorInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x0600047A RID: 1146 RVA: 0x0001A650 File Offset: 0x00018850
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1071337, XrefRangeEnd = 1071341, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool TryGetValue(string name, out IVariable value)
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
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(VariablesGroupAsset.NativeMethodInfoPtr_TryGetValue_Public_Virtual_Final_New_Boolean_String_byref_IVariable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			value = ((intPtr4 == 0) ? null : new IVariable(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x0600047B RID: 1147 RVA: 0x0001A6C0 File Offset: 0x000188C0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1071360, RefRangeEnd = 1071362, XrefRangeStart = 1071341, XrefRangeEnd = 1071360, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Add(string name, IVariable variable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(variable);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VariablesGroupAsset.NativeMethodInfoPtr_Add_Public_Virtual_Final_New_Void_String_IVariable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600047C RID: 1148 RVA: 0x0001A714 File Offset: 0x00018914
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1071362, XrefRangeEnd = 1071365, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Add(KeyValuePair<string, IVariable> item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(item));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VariablesGroupAsset.NativeMethodInfoPtr_Add_Public_Virtual_Final_New_Void_KeyValuePair_2_String_IVariable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600047D RID: 1149 RVA: 0x0001A75C File Offset: 0x0001895C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1071365, XrefRangeEnd = 1071370, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool Remove(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VariablesGroupAsset.NativeMethodInfoPtr_Remove_Public_Virtual_Final_New_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600047E RID: 1150 RVA: 0x0001A7AC File Offset: 0x000189AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1071370, XrefRangeEnd = 1071376, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool Remove(KeyValuePair<string, IVariable> item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(item));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VariablesGroupAsset.NativeMethodInfoPtr_Remove_Public_Virtual_Final_New_Boolean_KeyValuePair_2_String_IVariable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600047F RID: 1151 RVA: 0x0001A800 File Offset: 0x00018A00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1071376, XrefRangeEnd = 1071380, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool ContainsKey(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VariablesGroupAsset.NativeMethodInfoPtr_ContainsKey_Public_Virtual_Final_New_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000480 RID: 1152 RVA: 0x0001A850 File Offset: 0x00018A50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1071380, XrefRangeEnd = 1071386, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool Contains(KeyValuePair<string, IVariable> item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(item));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VariablesGroupAsset.NativeMethodInfoPtr_Contains_Public_Virtual_Final_New_Boolean_KeyValuePair_2_String_IVariable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000481 RID: 1153 RVA: 0x0001A8A4 File Offset: 0x00018AA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1071386, XrefRangeEnd = 1071406, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void CopyTo(Il2CppReferenceArray<KeyValuePair<string, IVariable>> array, int arrayIndex)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VariablesGroupAsset.NativeMethodInfoPtr_CopyTo_Public_Virtual_Final_New_Void_Il2CppReferenceArray_1_KeyValuePair_2_String_IVariable_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000482 RID: 1154 RVA: 0x0001A8F4 File Offset: 0x00018AF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1071406, XrefRangeEnd = 1071411, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerator<KeyValuePair<string, IVariable>> Method_Private_Virtual_Final_New_IEnumerator_1_KeyValuePair_2_String_IVariable_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VariablesGroupAsset.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_IEnumerator_1_KeyValuePair_2_String_IVariable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<KeyValuePair<string, IVariable>>>(intPtr3) : null;
		}

		// Token: 0x06000483 RID: 1155 RVA: 0x0001A934 File Offset: 0x00018B34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1071411, XrefRangeEnd = 1071416, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerator GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VariablesGroupAsset.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06000484 RID: 1156 RVA: 0x0001A974 File Offset: 0x00018B74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ContainsName(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VariablesGroupAsset.NativeMethodInfoPtr_ContainsName_Public_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000485 RID: 1157 RVA: 0x0001A9C4 File Offset: 0x00018BC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1071416, XrefRangeEnd = 1071421, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Clear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VariablesGroupAsset.NativeMethodInfoPtr_Clear_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000486 RID: 1158 RVA: 0x0001A9F8 File Offset: 0x00018BF8
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnBeforeSerialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VariablesGroupAsset.NativeMethodInfoPtr_OnBeforeSerialize_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000487 RID: 1159 RVA: 0x0001AA2C File Offset: 0x00018C2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1071421, XrefRangeEnd = 1071449, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnAfterDeserialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VariablesGroupAsset.NativeMethodInfoPtr_OnAfterDeserialize_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000488 RID: 1160 RVA: 0x0001AA60 File Offset: 0x00018C60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1071449, XrefRangeEnd = 1071464, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VariablesGroupAsset()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VariablesGroupAsset>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VariablesGroupAsset.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000489 RID: 1161 RVA: 0x00003B72 File Offset: 0x00001D72
		public VariablesGroupAsset(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700011E RID: 286
		// (get) Token: 0x0600048A RID: 1162 RVA: 0x0001AA9C File Offset: 0x00018C9C
		// (set) Token: 0x0600048B RID: 1163 RVA: 0x00003B7B File Offset: 0x00001D7B
		public unsafe List<VariableNameValuePair> m_Variables
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VariablesGroupAsset.NativeFieldInfoPtr_m_Variables);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<VariableNameValuePair>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VariablesGroupAsset.NativeFieldInfoPtr_m_Variables), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700011F RID: 287
		// (get) Token: 0x0600048C RID: 1164 RVA: 0x0001AACC File Offset: 0x00018CCC
		// (set) Token: 0x0600048D RID: 1165 RVA: 0x00003B9A File Offset: 0x00001D9A
		public unsafe Dictionary<string, VariableNameValuePair> m_VariableLookup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VariablesGroupAsset.NativeFieldInfoPtr_m_VariableLookup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, VariableNameValuePair>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VariablesGroupAsset.NativeFieldInfoPtr_m_VariableLookup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400032C RID: 812
		private static readonly IntPtr NativeFieldInfoPtr_m_Variables;

		// Token: 0x0400032D RID: 813
		private static readonly IntPtr NativeFieldInfoPtr_m_VariableLookup;

		// Token: 0x0400032E RID: 814
		private static readonly IntPtr NativeMethodInfoPtr_get_Count_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x0400032F RID: 815
		private static readonly IntPtr NativeMethodInfoPtr_get_Keys_Public_Virtual_Final_New_get_ICollection_1_String_0;

		// Token: 0x04000330 RID: 816
		private static readonly IntPtr NativeMethodInfoPtr_get_Values_Public_Virtual_Final_New_get_ICollection_1_IVariable_0;

		// Token: 0x04000331 RID: 817
		private static readonly IntPtr NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04000332 RID: 818
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_Virtual_Final_New_get_IVariable_String_0;

		// Token: 0x04000333 RID: 819
		private static readonly IntPtr NativeMethodInfoPtr_set_Item_Public_Virtual_Final_New_set_Void_String_IVariable_0;

		// Token: 0x04000334 RID: 820
		private static readonly IntPtr NativeMethodInfoPtr_GetSourceValue_Public_Virtual_Final_New_Object_ISelectorInfo_0;

		// Token: 0x04000335 RID: 821
		private static readonly IntPtr NativeMethodInfoPtr_TryGetValue_Public_Virtual_Final_New_Boolean_String_byref_IVariable_0;

		// Token: 0x04000336 RID: 822
		private static readonly IntPtr NativeMethodInfoPtr_Add_Public_Virtual_Final_New_Void_String_IVariable_0;

		// Token: 0x04000337 RID: 823
		private static readonly IntPtr NativeMethodInfoPtr_Add_Public_Virtual_Final_New_Void_KeyValuePair_2_String_IVariable_0;

		// Token: 0x04000338 RID: 824
		private static readonly IntPtr NativeMethodInfoPtr_Remove_Public_Virtual_Final_New_Boolean_String_0;

		// Token: 0x04000339 RID: 825
		private static readonly IntPtr NativeMethodInfoPtr_Remove_Public_Virtual_Final_New_Boolean_KeyValuePair_2_String_IVariable_0;

		// Token: 0x0400033A RID: 826
		private static readonly IntPtr NativeMethodInfoPtr_ContainsKey_Public_Virtual_Final_New_Boolean_String_0;

		// Token: 0x0400033B RID: 827
		private static readonly IntPtr NativeMethodInfoPtr_Contains_Public_Virtual_Final_New_Boolean_KeyValuePair_2_String_IVariable_0;

		// Token: 0x0400033C RID: 828
		private static readonly IntPtr NativeMethodInfoPtr_CopyTo_Public_Virtual_Final_New_Void_Il2CppReferenceArray_1_KeyValuePair_2_String_IVariable_Int32_0;

		// Token: 0x0400033D RID: 829
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Virtual_Final_New_IEnumerator_1_KeyValuePair_2_String_IVariable_0;

		// Token: 0x0400033E RID: 830
		private static readonly IntPtr NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_0;

		// Token: 0x0400033F RID: 831
		private static readonly IntPtr NativeMethodInfoPtr_ContainsName_Public_Boolean_String_0;

		// Token: 0x04000340 RID: 832
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Virtual_Final_New_Void_0;

		// Token: 0x04000341 RID: 833
		private static readonly IntPtr NativeMethodInfoPtr_OnBeforeSerialize_Public_Virtual_Final_New_Void_0;

		// Token: 0x04000342 RID: 834
		private static readonly IntPtr NativeMethodInfoPtr_OnAfterDeserialize_Public_Virtual_Final_New_Void_0;

		// Token: 0x04000343 RID: 835
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000140 RID: 320
		[ObfuscatedName("UnityEngine.Localization.SmartFormat.PersistentVariables.VariablesGroupAsset+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06000E34 RID: 3636 RVA: 0x0003DFB4 File Offset: 0x0003C1B4
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<VariablesGroupAsset.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VariablesGroupAsset>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VariablesGroupAsset.__c>.NativeClassPtr);
				VariablesGroupAsset.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VariablesGroupAsset.__c>.NativeClassPtr, "<>9");
				VariablesGroupAsset.__c.NativeFieldInfoPtr___9__7_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VariablesGroupAsset.__c>.NativeClassPtr, "<>9__7_0");
				VariablesGroupAsset.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VariablesGroupAsset.__c>.NativeClassPtr, 100664146);
				VariablesGroupAsset.__c.NativeMethodInfoPtr__get_Values_b__7_0_Internal_IVariable_VariableNameValuePair_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VariablesGroupAsset.__c>.NativeClassPtr, 100664147);
			}

			// Token: 0x06000E35 RID: 3637 RVA: 0x0003E030 File Offset: 0x0003C230
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VariablesGroupAsset.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VariablesGroupAsset.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000E36 RID: 3638 RVA: 0x0003E06C File Offset: 0x0003C26C
			[CallerCount(0)]
			public unsafe IVariable _get_Values_b__7_0(VariableNameValuePair s)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(s);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VariablesGroupAsset.__c.NativeMethodInfoPtr__get_Values_b__7_0_Internal_IVariable_VariableNameValuePair_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IVariable>(intPtr3) : null;
				}
			}

			// Token: 0x06000E37 RID: 3639 RVA: 0x00007E7F File Offset: 0x0000607F
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170003D0 RID: 976
			// (get) Token: 0x06000E38 RID: 3640 RVA: 0x0003E0BC File Offset: 0x0003C2BC
			// (set) Token: 0x06000E39 RID: 3641 RVA: 0x00007E88 File Offset: 0x00006088
			public unsafe static VariablesGroupAsset.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(VariablesGroupAsset.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<VariablesGroupAsset.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(VariablesGroupAsset.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170003D1 RID: 977
			// (get) Token: 0x06000E3A RID: 3642 RVA: 0x0003E0E4 File Offset: 0x0003C2E4
			// (set) Token: 0x06000E3B RID: 3643 RVA: 0x00007E9A File Offset: 0x0000609A
			public unsafe static Func<VariableNameValuePair, IVariable> __9__7_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(VariablesGroupAsset.__c.NativeFieldInfoPtr___9__7_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<VariableNameValuePair, IVariable>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(VariablesGroupAsset.__c.NativeFieldInfoPtr___9__7_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040009CB RID: 2507
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040009CC RID: 2508
			private static readonly IntPtr NativeFieldInfoPtr___9__7_0;

			// Token: 0x040009CD RID: 2509
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040009CE RID: 2510
			private static readonly IntPtr NativeMethodInfoPtr__get_Values_b__7_0_Internal_IVariable_VariableNameValuePair_0;
		}

		// Token: 0x02000141 RID: 321
		[ObfuscatedName("UnityEngine.Localization.SmartFormat.PersistentVariables.VariablesGroupAsset+<GetEnumerator>d__23")]
		public sealed class _GetEnumerator_d__23 : Object
		{
			// Token: 0x06000E3C RID: 3644 RVA: 0x0003E10C File Offset: 0x0003C30C
			// Note: this type is marked as 'beforefieldinit'.
			static _GetEnumerator_d__23()
			{
				Il2CppClassPointerStore<VariablesGroupAsset._GetEnumerator_d__23>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VariablesGroupAsset>.NativeClassPtr, "<GetEnumerator>d__23");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VariablesGroupAsset._GetEnumerator_d__23>.NativeClassPtr);
				VariablesGroupAsset._GetEnumerator_d__23.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VariablesGroupAsset._GetEnumerator_d__23>.NativeClassPtr, "<>1__state");
				VariablesGroupAsset._GetEnumerator_d__23.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VariablesGroupAsset._GetEnumerator_d__23>.NativeClassPtr, "<>2__current");
				VariablesGroupAsset._GetEnumerator_d__23.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VariablesGroupAsset._GetEnumerator_d__23>.NativeClassPtr, "<>4__this");
				VariablesGroupAsset._GetEnumerator_d__23.NativeFieldInfoPtr___7__wrap1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VariablesGroupAsset._GetEnumerator_d__23>.NativeClassPtr, "<>7__wrap1");
				VariablesGroupAsset._GetEnumerator_d__23.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VariablesGroupAsset._GetEnumerator_d__23>.NativeClassPtr, 100664148);
				VariablesGroupAsset._GetEnumerator_d__23.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VariablesGroupAsset._GetEnumerator_d__23>.NativeClassPtr, 100664149);
				VariablesGroupAsset._GetEnumerator_d__23.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VariablesGroupAsset._GetEnumerator_d__23>.NativeClassPtr, 100664150);
				VariablesGroupAsset._GetEnumerator_d__23.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VariablesGroupAsset._GetEnumerator_d__23>.NativeClassPtr, 100664151);
				VariablesGroupAsset._GetEnumerator_d__23.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VariablesGroupAsset._GetEnumerator_d__23>.NativeClassPtr, 100664152);
				VariablesGroupAsset._GetEnumerator_d__23.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VariablesGroupAsset._GetEnumerator_d__23>.NativeClassPtr, 100664153);
				VariablesGroupAsset._GetEnumerator_d__23.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VariablesGroupAsset._GetEnumerator_d__23>.NativeClassPtr, 100664154);
			}

			// Token: 0x06000E3D RID: 3645 RVA: 0x0003E214 File Offset: 0x0003C414
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _GetEnumerator_d__23(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VariablesGroupAsset._GetEnumerator_d__23>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VariablesGroupAsset._GetEnumerator_d__23.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000E3E RID: 3646 RVA: 0x0003E25C File Offset: 0x0003C45C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1071206, XrefRangeEnd = 1071211, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VariablesGroupAsset._GetEnumerator_d__23.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000E3F RID: 3647 RVA: 0x0003E290 File Offset: 0x0003C490
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1071211, XrefRangeEnd = 1071235, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VariablesGroupAsset._GetEnumerator_d__23.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06000E40 RID: 3648 RVA: 0x0003E2CC File Offset: 0x0003C4CC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1071235, XrefRangeEnd = 1071238, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VariablesGroupAsset._GetEnumerator_d__23.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170003D6 RID: 982
			// (get) Token: 0x06000E41 RID: 3649 RVA: 0x0003E300 File Offset: 0x0003C500
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VariablesGroupAsset._GetEnumerator_d__23.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06000E42 RID: 3650 RVA: 0x0003E340 File Offset: 0x0003C540
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1071238, XrefRangeEnd = 1071243, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VariablesGroupAsset._GetEnumerator_d__23.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170003D7 RID: 983
			// (get) Token: 0x06000E43 RID: 3651 RVA: 0x0003E374 File Offset: 0x0003C574
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VariablesGroupAsset._GetEnumerator_d__23.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06000E44 RID: 3652 RVA: 0x00007EAC File Offset: 0x000060AC
			public _GetEnumerator_d__23(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170003D2 RID: 978
			// (get) Token: 0x06000E45 RID: 3653 RVA: 0x0003E3B4 File Offset: 0x0003C5B4
			// (set) Token: 0x06000E46 RID: 3654 RVA: 0x00007EB5 File Offset: 0x000060B5
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VariablesGroupAsset._GetEnumerator_d__23.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VariablesGroupAsset._GetEnumerator_d__23.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170003D3 RID: 979
			// (get) Token: 0x06000E47 RID: 3655 RVA: 0x0003E3DC File Offset: 0x0003C5DC
			// (set) Token: 0x06000E48 RID: 3656 RVA: 0x00007ED0 File Offset: 0x000060D0
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VariablesGroupAsset._GetEnumerator_d__23.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VariablesGroupAsset._GetEnumerator_d__23.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170003D4 RID: 980
			// (get) Token: 0x06000E49 RID: 3657 RVA: 0x0003E40C File Offset: 0x0003C60C
			// (set) Token: 0x06000E4A RID: 3658 RVA: 0x00007EEF File Offset: 0x000060EF
			public unsafe VariablesGroupAsset __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VariablesGroupAsset._GetEnumerator_d__23.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<VariablesGroupAsset>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VariablesGroupAsset._GetEnumerator_d__23.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170003D5 RID: 981
			// (get) Token: 0x06000E4B RID: 3659 RVA: 0x0003E43C File Offset: 0x0003C63C
			// (set) Token: 0x06000E4C RID: 3660 RVA: 0x00007F0E File Offset: 0x0000610E
			public Dictionary<string, VariableNameValuePair>.Enumerator __7__wrap1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VariablesGroupAsset._GetEnumerator_d__23.NativeFieldInfoPtr___7__wrap1);
					return new Dictionary<string, VariableNameValuePair>.Enumerator(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Dictionary<string, VariableNameValuePair>.Enumerator>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VariablesGroupAsset._GetEnumerator_d__23.NativeFieldInfoPtr___7__wrap1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Dictionary<string, VariableNameValuePair>.Enumerator>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x040009CF RID: 2511
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040009D0 RID: 2512
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040009D1 RID: 2513
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040009D2 RID: 2514
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap1;

			// Token: 0x040009D3 RID: 2515
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040009D4 RID: 2516
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040009D5 RID: 2517
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040009D6 RID: 2518
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x040009D7 RID: 2519
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040009D8 RID: 2520
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040009D9 RID: 2521
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000142 RID: 322
		[ObfuscatedName("UnityEngine.Localization.SmartFormat.PersistentVariables.VariablesGroupAsset+<System-Collections-Generic-IEnumerable<System-Collections-Generic-KeyValuePair<System-String,UnityEngine-Localization-SmartFormat-PersistentVariables-IVariable>>-GetEnumerator>d__22")]
		public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumeratorIDisposableInKe2StIVVaEnOb2StUnique : Object
		{
			// Token: 0x06000E4D RID: 3661 RVA: 0x0003E46C File Offset: 0x0003C66C
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectCompilerGeneratedNPrivateSealedIEnumeratorIDisposableInKe2StIVVaEnOb2StUnique()
			{
				Il2CppClassPointerStore<VariablesGroupAsset.ObjectCompilerGeneratedNPrivateSealedIEnumeratorIDisposableInKe2StIVVaEnOb2StUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VariablesGroupAsset>.NativeClassPtr, "<System-Collections-Generic-IEnumerable<System-Collections-Generic-KeyValuePair<System-String,UnityEngine-Localization-SmartFormat-PersistentVariables-IVariable>>-GetEnumerator>d__22");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VariablesGroupAsset.ObjectCompilerGeneratedNPrivateSealedIEnumeratorIDisposableInKe2StIVVaEnOb2StUnique>.NativeClassPtr);
				VariablesGroupAsset.ObjectCompilerGeneratedNPrivateSealedIEnumeratorIDisposableInKe2StIVVaEnOb2StUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VariablesGroupAsset.ObjectCompilerGeneratedNPrivateSealedIEnumeratorIDisposableInKe2StIVVaEnOb2StUnique>.NativeClassPtr, "<>1__state");
				VariablesGroupAsset.ObjectCompilerGeneratedNPrivateSealedIEnumeratorIDisposableInKe2StIVVaEnOb2StUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VariablesGroupAsset.ObjectCompilerGeneratedNPrivateSealedIEnumeratorIDisposableInKe2StIVVaEnOb2StUnique>.NativeClassPtr, "<>2__current");
				VariablesGroupAsset.ObjectCompilerGeneratedNPrivateSealedIEnumeratorIDisposableInKe2StIVVaEnOb2StUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VariablesGroupAsset.ObjectCompilerGeneratedNPrivateSealedIEnumeratorIDisposableInKe2StIVVaEnOb2StUnique>.NativeClassPtr, "<>4__this");
				VariablesGroupAsset.ObjectCompilerGeneratedNPrivateSealedIEnumeratorIDisposableInKe2StIVVaEnOb2StUnique.NativeFieldInfoPtr___7__wrap1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VariablesGroupAsset.ObjectCompilerGeneratedNPrivateSealedIEnumeratorIDisposableInKe2StIVVaEnOb2StUnique>.NativeClassPtr, "<>7__wrap1");
				VariablesGroupAsset.ObjectCompilerGeneratedNPrivateSealedIEnumeratorIDisposableInKe2StIVVaEnOb2StUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VariablesGroupAsset.ObjectCompilerGeneratedNPrivateSealedIEnumeratorIDisposableInKe2StIVVaEnOb2StUnique>.NativeClassPtr, 100664155);
				VariablesGroupAsset.ObjectCompilerGeneratedNPrivateSealedIEnumeratorIDisposableInKe2StIVVaEnOb2StUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VariablesGroupAsset.ObjectCompilerGeneratedNPrivateSealedIEnumeratorIDisposableInKe2StIVVaEnOb2StUnique>.NativeClassPtr, 100664156);
				VariablesGroupAsset.ObjectCompilerGeneratedNPrivateSealedIEnumeratorIDisposableInKe2StIVVaEnOb2StUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VariablesGroupAsset.ObjectCompilerGeneratedNPrivateSealedIEnumeratorIDisposableInKe2StIVVaEnOb2StUnique>.NativeClassPtr, 100664157);
				VariablesGroupAsset.ObjectCompilerGeneratedNPrivateSealedIEnumeratorIDisposableInKe2StIVVaEnOb2StUnique.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VariablesGroupAsset.ObjectCompilerGeneratedNPrivateSealedIEnumeratorIDisposableInKe2StIVVaEnOb2StUnique>.NativeClassPtr, 100664158);
				VariablesGroupAsset.ObjectCompilerGeneratedNPrivateSealedIEnumeratorIDisposableInKe2StIVVaEnOb2StUnique.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_KeyValuePair_2_String_IVariable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VariablesGroupAsset.ObjectCompilerGeneratedNPrivateSealedIEnumeratorIDisposableInKe2StIVVaEnOb2StUnique>.NativeClassPtr, 100664159);
				VariablesGroupAsset.ObjectCompilerGeneratedNPrivateSealedIEnumeratorIDisposableInKe2StIVVaEnOb2StUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VariablesGroupAsset.ObjectCompilerGeneratedNPrivateSealedIEnumeratorIDisposableInKe2StIVVaEnOb2StUnique>.NativeClassPtr, 100664160);
				VariablesGroupAsset.ObjectCompilerGeneratedNPrivateSealedIEnumeratorIDisposableInKe2StIVVaEnOb2StUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VariablesGroupAsset.ObjectCompilerGeneratedNPrivateSealedIEnumeratorIDisposableInKe2StIVVaEnOb2StUnique>.NativeClassPtr, 100664161);
			}

			// Token: 0x06000E4E RID: 3662 RVA: 0x0003E574 File Offset: 0x0003C774
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumeratorIDisposableInKe2StIVVaEnOb2StUnique(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VariablesGroupAsset.ObjectCompilerGeneratedNPrivateSealedIEnumeratorIDisposableInKe2StIVVaEnOb2StUnique>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VariablesGroupAsset.ObjectCompilerGeneratedNPrivateSealedIEnumeratorIDisposableInKe2StIVVaEnOb2StUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000E4F RID: 3663 RVA: 0x0003E5BC File Offset: 0x0003C7BC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1071243, XrefRangeEnd = 1071248, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VariablesGroupAsset.ObjectCompilerGeneratedNPrivateSealedIEnumeratorIDisposableInKe2StIVVaEnOb2StUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000E50 RID: 3664 RVA: 0x0003E5F0 File Offset: 0x0003C7F0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1071248, XrefRangeEnd = 1071269, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VariablesGroupAsset.ObjectCompilerGeneratedNPrivateSealedIEnumeratorIDisposableInKe2StIVVaEnOb2StUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06000E51 RID: 3665 RVA: 0x0003E62C File Offset: 0x0003C82C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1071269, XrefRangeEnd = 1071272, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VariablesGroupAsset.ObjectCompilerGeneratedNPrivateSealedIEnumeratorIDisposableInKe2StIVVaEnOb2StUnique.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170003DC RID: 988
			// (get) Token: 0x06000E52 RID: 3666 RVA: 0x0003E660 File Offset: 0x0003C860
			public unsafe KeyValuePair<string, IVariable> prop_KeyValuePair_2_String_IVariable_0
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VariablesGroupAsset.ObjectCompilerGeneratedNPrivateSealedIEnumeratorIDisposableInKe2StIVVaEnOb2StUnique.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_KeyValuePair_2_String_IVariable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return new KeyValuePair<string, IVariable>(intPtr);
				}
			}

			// Token: 0x06000E53 RID: 3667 RVA: 0x0003E698 File Offset: 0x0003C898
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1071272, XrefRangeEnd = 1071277, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VariablesGroupAsset.ObjectCompilerGeneratedNPrivateSealedIEnumeratorIDisposableInKe2StIVVaEnOb2StUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170003DD RID: 989
			// (get) Token: 0x06000E54 RID: 3668 RVA: 0x0003E6CC File Offset: 0x0003C8CC
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1071277, XrefRangeEnd = 1071280, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VariablesGroupAsset.ObjectCompilerGeneratedNPrivateSealedIEnumeratorIDisposableInKe2StIVVaEnOb2StUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06000E55 RID: 3669 RVA: 0x00007F3C File Offset: 0x0000613C
			public ObjectCompilerGeneratedNPrivateSealedIEnumeratorIDisposableInKe2StIVVaEnOb2StUnique(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170003D8 RID: 984
			// (get) Token: 0x06000E56 RID: 3670 RVA: 0x0003E70C File Offset: 0x0003C90C
			// (set) Token: 0x06000E57 RID: 3671 RVA: 0x00007F45 File Offset: 0x00006145
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VariablesGroupAsset.ObjectCompilerGeneratedNPrivateSealedIEnumeratorIDisposableInKe2StIVVaEnOb2StUnique.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VariablesGroupAsset.ObjectCompilerGeneratedNPrivateSealedIEnumeratorIDisposableInKe2StIVVaEnOb2StUnique.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170003D9 RID: 985
			// (get) Token: 0x06000E58 RID: 3672 RVA: 0x0003E734 File Offset: 0x0003C934
			// (set) Token: 0x06000E59 RID: 3673 RVA: 0x00007F60 File Offset: 0x00006160
			public KeyValuePair<string, IVariable> __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VariablesGroupAsset.ObjectCompilerGeneratedNPrivateSealedIEnumeratorIDisposableInKe2StIVVaEnOb2StUnique.NativeFieldInfoPtr___2__current);
					return new KeyValuePair<string, IVariable>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<KeyValuePair<string, IVariable>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VariablesGroupAsset.ObjectCompilerGeneratedNPrivateSealedIEnumeratorIDisposableInKe2StIVVaEnOb2StUnique.NativeFieldInfoPtr___2__current), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<KeyValuePair<string, IVariable>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170003DA RID: 986
			// (get) Token: 0x06000E5A RID: 3674 RVA: 0x0003E764 File Offset: 0x0003C964
			// (set) Token: 0x06000E5B RID: 3675 RVA: 0x00007F8E File Offset: 0x0000618E
			public unsafe VariablesGroupAsset __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VariablesGroupAsset.ObjectCompilerGeneratedNPrivateSealedIEnumeratorIDisposableInKe2StIVVaEnOb2StUnique.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<VariablesGroupAsset>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VariablesGroupAsset.ObjectCompilerGeneratedNPrivateSealedIEnumeratorIDisposableInKe2StIVVaEnOb2StUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170003DB RID: 987
			// (get) Token: 0x06000E5C RID: 3676 RVA: 0x0003E794 File Offset: 0x0003C994
			// (set) Token: 0x06000E5D RID: 3677 RVA: 0x00007FAD File Offset: 0x000061AD
			public Dictionary<string, VariableNameValuePair>.Enumerator __7__wrap1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VariablesGroupAsset.ObjectCompilerGeneratedNPrivateSealedIEnumeratorIDisposableInKe2StIVVaEnOb2StUnique.NativeFieldInfoPtr___7__wrap1);
					return new Dictionary<string, VariableNameValuePair>.Enumerator(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Dictionary<string, VariableNameValuePair>.Enumerator>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VariablesGroupAsset.ObjectCompilerGeneratedNPrivateSealedIEnumeratorIDisposableInKe2StIVVaEnOb2StUnique.NativeFieldInfoPtr___7__wrap1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Dictionary<string, VariableNameValuePair>.Enumerator>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x040009DA RID: 2522
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040009DB RID: 2523
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040009DC RID: 2524
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040009DD RID: 2525
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap1;

			// Token: 0x040009DE RID: 2526
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040009DF RID: 2527
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040009E0 RID: 2528
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040009E1 RID: 2529
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x040009E2 RID: 2530
			private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_KeyValuePair_2_String_IVariable_0;

			// Token: 0x040009E3 RID: 2531
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040009E4 RID: 2532
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
