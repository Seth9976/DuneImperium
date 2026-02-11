using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Collections.ObjectModel;

namespace Newtonsoft.Json.Linq
{
	// Token: 0x020000BD RID: 189
	public class JPropertyKeyedCollection : Collection<JToken>
	{
		// Token: 0x0600113F RID: 4415 RVA: 0x00060D54 File Offset: 0x0005EF54
		// Note: this type is marked as 'beforefieldinit'.
		static JPropertyKeyedCollection()
		{
			Il2CppClassPointerStore<JPropertyKeyedCollection>.NativeClassPtr = IL2CPP.GetIl2CppClass("Newtonsoft.Json.dll", "Newtonsoft.Json.Linq", "JPropertyKeyedCollection");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JPropertyKeyedCollection>.NativeClassPtr);
			JPropertyKeyedCollection.NativeFieldInfoPtr_Comparer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JPropertyKeyedCollection>.NativeClassPtr, "Comparer");
			JPropertyKeyedCollection.NativeFieldInfoPtr__dictionary = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JPropertyKeyedCollection>.NativeClassPtr, "_dictionary");
			JPropertyKeyedCollection.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JPropertyKeyedCollection>.NativeClassPtr, 100666486);
			JPropertyKeyedCollection.NativeMethodInfoPtr_AddKey_Private_Void_String_JToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JPropertyKeyedCollection>.NativeClassPtr, 100666487);
			JPropertyKeyedCollection.NativeMethodInfoPtr_ChangeItemKey_Protected_Void_JToken_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JPropertyKeyedCollection>.NativeClassPtr, 100666488);
			JPropertyKeyedCollection.NativeMethodInfoPtr_ClearItems_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JPropertyKeyedCollection>.NativeClassPtr, 100666489);
			JPropertyKeyedCollection.NativeMethodInfoPtr_Contains_Public_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JPropertyKeyedCollection>.NativeClassPtr, 100666490);
			JPropertyKeyedCollection.NativeMethodInfoPtr_ContainsItem_Private_Boolean_JToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JPropertyKeyedCollection>.NativeClassPtr, 100666491);
			JPropertyKeyedCollection.NativeMethodInfoPtr_EnsureDictionary_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JPropertyKeyedCollection>.NativeClassPtr, 100666492);
			JPropertyKeyedCollection.NativeMethodInfoPtr_GetKeyForItem_Private_String_JToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JPropertyKeyedCollection>.NativeClassPtr, 100666493);
			JPropertyKeyedCollection.NativeMethodInfoPtr_InsertItem_Protected_Virtual_Void_Int32_JToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JPropertyKeyedCollection>.NativeClassPtr, 100666494);
			JPropertyKeyedCollection.NativeMethodInfoPtr_Remove_Public_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JPropertyKeyedCollection>.NativeClassPtr, 100666495);
			JPropertyKeyedCollection.NativeMethodInfoPtr_RemoveItem_Protected_Virtual_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JPropertyKeyedCollection>.NativeClassPtr, 100666496);
			JPropertyKeyedCollection.NativeMethodInfoPtr_RemoveKey_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JPropertyKeyedCollection>.NativeClassPtr, 100666497);
			JPropertyKeyedCollection.NativeMethodInfoPtr_SetItem_Protected_Virtual_Void_Int32_JToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JPropertyKeyedCollection>.NativeClassPtr, 100666498);
			JPropertyKeyedCollection.NativeMethodInfoPtr_get_Item_Public_get_JToken_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JPropertyKeyedCollection>.NativeClassPtr, 100666499);
			JPropertyKeyedCollection.NativeMethodInfoPtr_TryGetValue_Public_Boolean_String_byref_JToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JPropertyKeyedCollection>.NativeClassPtr, 100666500);
			JPropertyKeyedCollection.NativeMethodInfoPtr_get_Keys_Public_get_ICollection_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JPropertyKeyedCollection>.NativeClassPtr, 100666501);
			JPropertyKeyedCollection.NativeMethodInfoPtr_get_Values_Public_get_ICollection_1_JToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JPropertyKeyedCollection>.NativeClassPtr, 100666502);
			JPropertyKeyedCollection.NativeMethodInfoPtr_IndexOfReference_Public_Int32_JToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JPropertyKeyedCollection>.NativeClassPtr, 100666503);
			JPropertyKeyedCollection.NativeMethodInfoPtr_Compare_Public_Boolean_JPropertyKeyedCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JPropertyKeyedCollection>.NativeClassPtr, 100666504);
		}

		// Token: 0x06001140 RID: 4416 RVA: 0x00060F28 File Offset: 0x0005F128
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 758967, RefRangeEnd = 758973, XrefRangeStart = 758958, XrefRangeEnd = 758967, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe JPropertyKeyedCollection()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JPropertyKeyedCollection>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JPropertyKeyedCollection.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001141 RID: 4417 RVA: 0x00060F64 File Offset: 0x0005F164
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 758978, RefRangeEnd = 758979, XrefRangeStart = 758973, XrefRangeEnd = 758978, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddKey(string key, JToken item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(item);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JPropertyKeyedCollection.NativeMethodInfoPtr_AddKey_Private_Void_String_JToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001142 RID: 4418 RVA: 0x00060FB8 File Offset: 0x0005F1B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 758979, XrefRangeEnd = 758995, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ChangeItemKey(JToken item, string newKey)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(newKey);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JPropertyKeyedCollection.NativeMethodInfoPtr_ChangeItemKey_Protected_Void_JToken_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001143 RID: 4419 RVA: 0x0006100C File Offset: 0x0005F20C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 758995, XrefRangeEnd = 759001, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ClearItems()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JPropertyKeyedCollection.NativeMethodInfoPtr_ClearItems_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001144 RID: 4420 RVA: 0x00061048 File Offset: 0x0005F248
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 759001, XrefRangeEnd = 759002, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Contains(string key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JPropertyKeyedCollection.NativeMethodInfoPtr_Contains_Public_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001145 RID: 4421 RVA: 0x00061098 File Offset: 0x0005F298
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 759002, XrefRangeEnd = 759007, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ContainsItem(JToken item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JPropertyKeyedCollection.NativeMethodInfoPtr_ContainsItem_Private_Boolean_JToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001146 RID: 4422 RVA: 0x000610E8 File Offset: 0x0005F2E8
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 759018, RefRangeEnd = 759024, XrefRangeStart = 759007, XrefRangeEnd = 759018, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EnsureDictionary()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JPropertyKeyedCollection.NativeMethodInfoPtr_EnsureDictionary_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001147 RID: 4423 RVA: 0x0006111C File Offset: 0x0005F31C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 759024, XrefRangeEnd = 759026, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetKeyForItem(JToken item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JPropertyKeyedCollection.NativeMethodInfoPtr_GetKeyForItem_Private_String_JToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06001148 RID: 4424 RVA: 0x00061164 File Offset: 0x0005F364
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 759026, XrefRangeEnd = 759037, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void InsertItem(int index, JToken item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(item);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JPropertyKeyedCollection.NativeMethodInfoPtr_InsertItem_Protected_Virtual_Void_Int32_JToken_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001149 RID: 4425 RVA: 0x000611C0 File Offset: 0x0005F3C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 759037, XrefRangeEnd = 759041, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Remove(string key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JPropertyKeyedCollection.NativeMethodInfoPtr_Remove_Public_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600114A RID: 4426 RVA: 0x00061210 File Offset: 0x0005F410
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 759041, XrefRangeEnd = 759055, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void RemoveItem(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JPropertyKeyedCollection.NativeMethodInfoPtr_RemoveItem_Protected_Virtual_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600114B RID: 4427 RVA: 0x0006125C File Offset: 0x0005F45C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 759058, RefRangeEnd = 759059, XrefRangeStart = 759055, XrefRangeEnd = 759058, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveKey(string key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JPropertyKeyedCollection.NativeMethodInfoPtr_RemoveKey_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600114C RID: 4428 RVA: 0x000612A0 File Offset: 0x0005F4A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 759059, XrefRangeEnd = 759091, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SetItem(int index, JToken item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(item);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JPropertyKeyedCollection.NativeMethodInfoPtr_SetItem_Protected_Virtual_Void_Int32_JToken_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700049F RID: 1183
		public unsafe JToken this[string key]
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 759091, XrefRangeEnd = 759106, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JPropertyKeyedCollection.NativeMethodInfoPtr_get_Item_Public_get_JToken_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<JToken>(intPtr3) : null;
				}
			}
		}

		// Token: 0x0600114E RID: 4430 RVA: 0x0006134C File Offset: 0x0005F54C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 759106, XrefRangeEnd = 759110, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TryGetValue(string key, out JToken value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(JPropertyKeyedCollection.NativeMethodInfoPtr_TryGetValue_Public_Boolean_String_byref_JToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			value = ((intPtr4 == 0) ? null : new JToken(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x170004A0 RID: 1184
		// (get) Token: 0x0600114F RID: 4431 RVA: 0x000613BC File Offset: 0x0005F5BC
		public unsafe ICollection<string> Keys
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 759110, XrefRangeEnd = 759115, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JPropertyKeyedCollection.NativeMethodInfoPtr_get_Keys_Public_get_ICollection_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ICollection<string>>(intPtr3) : null;
			}
		}

		// Token: 0x170004A1 RID: 1185
		// (get) Token: 0x06001150 RID: 4432 RVA: 0x000613FC File Offset: 0x0005F5FC
		public unsafe ICollection<JToken> Values
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 759115, XrefRangeEnd = 759120, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JPropertyKeyedCollection.NativeMethodInfoPtr_get_Values_Public_get_ICollection_1_JToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ICollection<JToken>>(intPtr3) : null;
			}
		}

		// Token: 0x06001151 RID: 4433 RVA: 0x0006143C File Offset: 0x0005F63C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 759120, XrefRangeEnd = 759127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int IndexOfReference(JToken t)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JPropertyKeyedCollection.NativeMethodInfoPtr_IndexOfReference_Public_Int32_JToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001152 RID: 4434 RVA: 0x0006148C File Offset: 0x0005F68C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 759168, RefRangeEnd = 759169, XrefRangeStart = 759127, XrefRangeEnd = 759168, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Compare(JPropertyKeyedCollection other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JPropertyKeyedCollection.NativeMethodInfoPtr_Compare_Public_Boolean_JPropertyKeyedCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001153 RID: 4435 RVA: 0x000078B7 File Offset: 0x00005AB7
		public JPropertyKeyedCollection(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700049D RID: 1181
		// (get) Token: 0x06001154 RID: 4436 RVA: 0x000614DC File Offset: 0x0005F6DC
		// (set) Token: 0x06001155 RID: 4437 RVA: 0x000078C0 File Offset: 0x00005AC0
		public unsafe static IEqualityComparer<string> Comparer
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(JPropertyKeyedCollection.NativeFieldInfoPtr_Comparer, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEqualityComparer<string>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(JPropertyKeyedCollection.NativeFieldInfoPtr_Comparer, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700049E RID: 1182
		// (get) Token: 0x06001156 RID: 4438 RVA: 0x00061504 File Offset: 0x0005F704
		// (set) Token: 0x06001157 RID: 4439 RVA: 0x000078D2 File Offset: 0x00005AD2
		public unsafe Dictionary<string, JToken> _dictionary
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JPropertyKeyedCollection.NativeFieldInfoPtr__dictionary);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, JToken>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JPropertyKeyedCollection.NativeFieldInfoPtr__dictionary), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000DE7 RID: 3559
		private static readonly IntPtr NativeFieldInfoPtr_Comparer;

		// Token: 0x04000DE8 RID: 3560
		private static readonly IntPtr NativeFieldInfoPtr__dictionary;

		// Token: 0x04000DE9 RID: 3561
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000DEA RID: 3562
		private static readonly IntPtr NativeMethodInfoPtr_AddKey_Private_Void_String_JToken_0;

		// Token: 0x04000DEB RID: 3563
		private static readonly IntPtr NativeMethodInfoPtr_ChangeItemKey_Protected_Void_JToken_String_0;

		// Token: 0x04000DEC RID: 3564
		private static readonly IntPtr NativeMethodInfoPtr_ClearItems_Protected_Virtual_Void_0;

		// Token: 0x04000DED RID: 3565
		private static readonly IntPtr NativeMethodInfoPtr_Contains_Public_Boolean_String_0;

		// Token: 0x04000DEE RID: 3566
		private static readonly IntPtr NativeMethodInfoPtr_ContainsItem_Private_Boolean_JToken_0;

		// Token: 0x04000DEF RID: 3567
		private static readonly IntPtr NativeMethodInfoPtr_EnsureDictionary_Private_Void_0;

		// Token: 0x04000DF0 RID: 3568
		private static readonly IntPtr NativeMethodInfoPtr_GetKeyForItem_Private_String_JToken_0;

		// Token: 0x04000DF1 RID: 3569
		private static readonly IntPtr NativeMethodInfoPtr_InsertItem_Protected_Virtual_Void_Int32_JToken_0;

		// Token: 0x04000DF2 RID: 3570
		private static readonly IntPtr NativeMethodInfoPtr_Remove_Public_Boolean_String_0;

		// Token: 0x04000DF3 RID: 3571
		private static readonly IntPtr NativeMethodInfoPtr_RemoveItem_Protected_Virtual_Void_Int32_0;

		// Token: 0x04000DF4 RID: 3572
		private static readonly IntPtr NativeMethodInfoPtr_RemoveKey_Private_Void_String_0;

		// Token: 0x04000DF5 RID: 3573
		private static readonly IntPtr NativeMethodInfoPtr_SetItem_Protected_Virtual_Void_Int32_JToken_0;

		// Token: 0x04000DF6 RID: 3574
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_get_JToken_String_0;

		// Token: 0x04000DF7 RID: 3575
		private static readonly IntPtr NativeMethodInfoPtr_TryGetValue_Public_Boolean_String_byref_JToken_0;

		// Token: 0x04000DF8 RID: 3576
		private static readonly IntPtr NativeMethodInfoPtr_get_Keys_Public_get_ICollection_1_String_0;

		// Token: 0x04000DF9 RID: 3577
		private static readonly IntPtr NativeMethodInfoPtr_get_Values_Public_get_ICollection_1_JToken_0;

		// Token: 0x04000DFA RID: 3578
		private static readonly IntPtr NativeMethodInfoPtr_IndexOfReference_Public_Int32_JToken_0;

		// Token: 0x04000DFB RID: 3579
		private static readonly IntPtr NativeMethodInfoPtr_Compare_Public_Boolean_JPropertyKeyedCollection_0;
	}
}
