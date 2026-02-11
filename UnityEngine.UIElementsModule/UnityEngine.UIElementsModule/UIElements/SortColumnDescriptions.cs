using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.UIElements
{
	// Token: 0x0200007C RID: 124
	[Serializable]
	public class SortColumnDescriptions : Object
	{
		// Token: 0x06000C6B RID: 3179 RVA: 0x00048E68 File Offset: 0x00047068
		// Note: this type is marked as 'beforefieldinit'.
		static SortColumnDescriptions()
		{
			Il2CppClassPointerStore<SortColumnDescriptions>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "SortColumnDescriptions");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SortColumnDescriptions>.NativeClassPtr);
			SortColumnDescriptions.NativeFieldInfoPtr_m_Descriptions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SortColumnDescriptions>.NativeClassPtr, "m_Descriptions");
			SortColumnDescriptions.NativeFieldInfoPtr_changed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SortColumnDescriptions>.NativeClassPtr, "changed");
			SortColumnDescriptions.NativeMethodInfoPtr_add_changed_Internal_add_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortColumnDescriptions>.NativeClassPtr, 100665087);
			SortColumnDescriptions.NativeMethodInfoPtr_remove_changed_Internal_rem_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortColumnDescriptions>.NativeClassPtr, 100665088);
			SortColumnDescriptions.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_1_SortColumnDescription_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortColumnDescriptions>.NativeClassPtr, 100665089);
			SortColumnDescriptions.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortColumnDescriptions>.NativeClassPtr, 100665090);
			SortColumnDescriptions.NativeMethodInfoPtr_Add_Public_Virtual_Final_New_Void_SortColumnDescription_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortColumnDescriptions>.NativeClassPtr, 100665091);
			SortColumnDescriptions.NativeMethodInfoPtr_Clear_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortColumnDescriptions>.NativeClassPtr, 100665092);
			SortColumnDescriptions.NativeMethodInfoPtr_Contains_Public_Virtual_Final_New_Boolean_SortColumnDescription_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortColumnDescriptions>.NativeClassPtr, 100665093);
			SortColumnDescriptions.NativeMethodInfoPtr_CopyTo_Public_Virtual_Final_New_Void_Il2CppReferenceArray_1_SortColumnDescription_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortColumnDescriptions>.NativeClassPtr, 100665094);
			SortColumnDescriptions.NativeMethodInfoPtr_Remove_Public_Virtual_Final_New_Boolean_SortColumnDescription_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortColumnDescriptions>.NativeClassPtr, 100665095);
			SortColumnDescriptions.NativeMethodInfoPtr_OnDescriptionChanged_Private_Void_SortColumnDescription_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortColumnDescriptions>.NativeClassPtr, 100665096);
			SortColumnDescriptions.NativeMethodInfoPtr_get_Count_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortColumnDescriptions>.NativeClassPtr, 100665097);
			SortColumnDescriptions.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortColumnDescriptions>.NativeClassPtr, 100665098);
			SortColumnDescriptions.NativeMethodInfoPtr_Insert_Public_Void_Int32_SortColumnDescription_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortColumnDescriptions>.NativeClassPtr, 100665099);
			SortColumnDescriptions.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortColumnDescriptions>.NativeClassPtr, 100665100);
		}

		// Token: 0x06000C6C RID: 3180 RVA: 0x00048FD8 File Offset: 0x000471D8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 302568, RefRangeEnd = 302570, XrefRangeStart = 302564, XrefRangeEnd = 302568, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_changed(Action value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortColumnDescriptions.NativeMethodInfoPtr_add_changed_Internal_add_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000C6D RID: 3181 RVA: 0x0004901C File Offset: 0x0004721C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 302574, RefRangeEnd = 302575, XrefRangeStart = 302570, XrefRangeEnd = 302574, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_changed(Action value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortColumnDescriptions.NativeMethodInfoPtr_remove_changed_Internal_rem_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000C6E RID: 3182 RVA: 0x00049060 File Offset: 0x00047260
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 302579, RefRangeEnd = 302581, XrefRangeStart = 302575, XrefRangeEnd = 302579, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerator<SortColumnDescription> GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortColumnDescriptions.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_1_SortColumnDescription_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<SortColumnDescription>>(intPtr3) : null;
		}

		// Token: 0x06000C6F RID: 3183 RVA: 0x000490A0 File Offset: 0x000472A0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 302579, RefRangeEnd = 302581, XrefRangeStart = 302579, XrefRangeEnd = 302581, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerator System_Collections_IEnumerable_GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortColumnDescriptions.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06000C70 RID: 3184 RVA: 0x000490E0 File Offset: 0x000472E0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 302586, RefRangeEnd = 302589, XrefRangeStart = 302581, XrefRangeEnd = 302586, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Add(SortColumnDescription item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortColumnDescriptions.NativeMethodInfoPtr_Add_Public_Virtual_Final_New_Void_SortColumnDescription_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000C71 RID: 3185 RVA: 0x00049124 File Offset: 0x00047324
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 302614, RefRangeEnd = 302618, XrefRangeStart = 302589, XrefRangeEnd = 302614, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Clear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortColumnDescriptions.NativeMethodInfoPtr_Clear_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C72 RID: 3186 RVA: 0x00049158 File Offset: 0x00047358
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 302622, RefRangeEnd = 302623, XrefRangeStart = 302618, XrefRangeEnd = 302622, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool Contains(SortColumnDescription item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortColumnDescriptions.NativeMethodInfoPtr_Contains_Public_Virtual_Final_New_Boolean_SortColumnDescription_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000C73 RID: 3187 RVA: 0x000491A8 File Offset: 0x000473A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 302623, XrefRangeEnd = 302628, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void CopyTo(Il2CppReferenceArray<SortColumnDescription> array, int arrayIndex)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortColumnDescriptions.NativeMethodInfoPtr_CopyTo_Public_Virtual_Final_New_Void_Il2CppReferenceArray_1_SortColumnDescription_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C74 RID: 3188 RVA: 0x000491F8 File Offset: 0x000473F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 302628, XrefRangeEnd = 302633, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool Remove(SortColumnDescription desc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(desc);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortColumnDescriptions.NativeMethodInfoPtr_Remove_Public_Virtual_Final_New_Boolean_SortColumnDescription_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000C75 RID: 3189 RVA: 0x00049248 File Offset: 0x00047448
		[CallerCount(0)]
		public unsafe void OnDescriptionChanged(SortColumnDescription desc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(desc);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortColumnDescriptions.NativeMethodInfoPtr_OnDescriptionChanged_Private_Void_SortColumnDescription_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170003BE RID: 958
		// (get) Token: 0x06000C76 RID: 3190 RVA: 0x0004928C File Offset: 0x0004748C
		public unsafe virtual int Count
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 302633, XrefRangeEnd = 302637, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortColumnDescriptions.NativeMethodInfoPtr_get_Count_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170003BF RID: 959
		// (get) Token: 0x06000C77 RID: 3191 RVA: 0x000492C8 File Offset: 0x000474C8
		public unsafe virtual bool IsReadOnly
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 302637, XrefRangeEnd = 302641, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortColumnDescriptions.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000C78 RID: 3192 RVA: 0x00049304 File Offset: 0x00047504
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 302660, RefRangeEnd = 302661, XrefRangeStart = 302641, XrefRangeEnd = 302660, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Insert(int index, SortColumnDescription desc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(desc);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortColumnDescriptions.NativeMethodInfoPtr_Insert_Public_Void_Int32_SortColumnDescription_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C79 RID: 3193 RVA: 0x00049354 File Offset: 0x00047554
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 302669, RefRangeEnd = 302671, XrefRangeStart = 302661, XrefRangeEnd = 302669, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SortColumnDescriptions()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SortColumnDescriptions>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortColumnDescriptions.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C7A RID: 3194 RVA: 0x000069AD File Offset: 0x00004BAD
		public SortColumnDescriptions(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003BC RID: 956
		// (get) Token: 0x06000C7B RID: 3195 RVA: 0x00049390 File Offset: 0x00047590
		// (set) Token: 0x06000C7C RID: 3196 RVA: 0x000069B6 File Offset: 0x00004BB6
		public unsafe IList<SortColumnDescription> m_Descriptions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortColumnDescriptions.NativeFieldInfoPtr_m_Descriptions);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IList<SortColumnDescription>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortColumnDescriptions.NativeFieldInfoPtr_m_Descriptions), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003BD RID: 957
		// (get) Token: 0x06000C7D RID: 3197 RVA: 0x000493C0 File Offset: 0x000475C0
		// (set) Token: 0x06000C7E RID: 3198 RVA: 0x000069D5 File Offset: 0x00004BD5
		public unsafe Action changed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortColumnDescriptions.NativeFieldInfoPtr_changed);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortColumnDescriptions.NativeFieldInfoPtr_changed), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x06000C7F RID: 3199 RVA: 0x000493F0 File Offset: 0x000475F0
		public int IndexOf(SortColumnDescription desc)
		{
			return this.m_Descriptions.IndexOf(desc);
		}

		// Token: 0x06000C80 RID: 3200 RVA: 0x000069F4 File Offset: 0x00004BF4
		public void RemoveAt(int index)
		{
			this.Remove(this.m_Descriptions[index]);
		}

		// Token: 0x170003C0 RID: 960
		public SortColumnDescription this[int index]
		{
			get
			{
				return this.m_Descriptions[index];
			}
		}

		// Token: 0x040008A4 RID: 2212
		private static readonly IntPtr NativeFieldInfoPtr_m_Descriptions;

		// Token: 0x040008A5 RID: 2213
		private static readonly IntPtr NativeFieldInfoPtr_changed;

		// Token: 0x040008A6 RID: 2214
		private static readonly IntPtr NativeMethodInfoPtr_add_changed_Internal_add_Void_Action_0;

		// Token: 0x040008A7 RID: 2215
		private static readonly IntPtr NativeMethodInfoPtr_remove_changed_Internal_rem_Void_Action_0;

		// Token: 0x040008A8 RID: 2216
		private static readonly IntPtr NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_1_SortColumnDescription_0;

		// Token: 0x040008A9 RID: 2217
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;

		// Token: 0x040008AA RID: 2218
		private static readonly IntPtr NativeMethodInfoPtr_Add_Public_Virtual_Final_New_Void_SortColumnDescription_0;

		// Token: 0x040008AB RID: 2219
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Virtual_Final_New_Void_0;

		// Token: 0x040008AC RID: 2220
		private static readonly IntPtr NativeMethodInfoPtr_Contains_Public_Virtual_Final_New_Boolean_SortColumnDescription_0;

		// Token: 0x040008AD RID: 2221
		private static readonly IntPtr NativeMethodInfoPtr_CopyTo_Public_Virtual_Final_New_Void_Il2CppReferenceArray_1_SortColumnDescription_Int32_0;

		// Token: 0x040008AE RID: 2222
		private static readonly IntPtr NativeMethodInfoPtr_Remove_Public_Virtual_Final_New_Boolean_SortColumnDescription_0;

		// Token: 0x040008AF RID: 2223
		private static readonly IntPtr NativeMethodInfoPtr_OnDescriptionChanged_Private_Void_SortColumnDescription_0;

		// Token: 0x040008B0 RID: 2224
		private static readonly IntPtr NativeMethodInfoPtr_get_Count_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x040008B1 RID: 2225
		private static readonly IntPtr NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x040008B2 RID: 2226
		private static readonly IntPtr NativeMethodInfoPtr_Insert_Public_Void_Int32_SortColumnDescription_0;

		// Token: 0x040008B3 RID: 2227
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020003AD RID: 941
		public class UxmlObjectFactory<T> : UxmlObjectFactory<T, SortColumnDescriptions.UxmlObjectTraits<T>> where T : SortColumnDescriptions, new()
		{
			// Token: 0x06003909 RID: 14601 RVA: 0x000E8290 File Offset: 0x000E6490
			// Note: this type is marked as 'beforefieldinit'.
			static UxmlObjectFactory()
			{
				Il2CppClassPointerStore<SortColumnDescriptions.UxmlObjectFactory<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SortColumnDescriptions>.NativeClassPtr, "UxmlObjectFactory`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SortColumnDescriptions.UxmlObjectFactory<T>>.NativeClassPtr);
				SortColumnDescriptions.UxmlObjectFactory<T>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortColumnDescriptions.UxmlObjectFactory<T>>.NativeClassPtr, 100665101);
			}

			// Token: 0x0600390A RID: 14602 RVA: 0x000E830C File Offset: 0x000E650C
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 300055, RefRangeEnd = 300059, XrefRangeStart = 300055, XrefRangeEnd = 300059, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe UxmlObjectFactory()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SortColumnDescriptions.UxmlObjectFactory<T>>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortColumnDescriptions.UxmlObjectFactory<T>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600390B RID: 14603 RVA: 0x00017DE7 File Offset: 0x00015FE7
			public UxmlObjectFactory(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0400286E RID: 10350
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020003AE RID: 942
		public class UxmlObjectTraits<T> : UnityEngine.UIElements.UxmlObjectTraits<T> where T : SortColumnDescriptions
		{
			// Token: 0x0600390C RID: 14604 RVA: 0x000E8348 File Offset: 0x000E6548
			// Note: this type is marked as 'beforefieldinit'.
			static UxmlObjectTraits()
			{
				Il2CppClassPointerStore<SortColumnDescriptions.UxmlObjectTraits<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SortColumnDescriptions>.NativeClassPtr, "UxmlObjectTraits`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SortColumnDescriptions.UxmlObjectTraits<T>>.NativeClassPtr);
				SortColumnDescriptions.UxmlObjectTraits<T>.NativeFieldInfoPtr_m_SortColumnDescriptions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SortColumnDescriptions.UxmlObjectTraits<T>>.NativeClassPtr, "m_SortColumnDescriptions");
				SortColumnDescriptions.UxmlObjectTraits<T>.NativeMethodInfoPtr_Init_Public_Virtual_Void_byref_T_IUxmlAttributes_CreationContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortColumnDescriptions.UxmlObjectTraits<T>>.NativeClassPtr, 100665102);
				SortColumnDescriptions.UxmlObjectTraits<T>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortColumnDescriptions.UxmlObjectTraits<T>>.NativeClassPtr, 100665103);
			}

			// Token: 0x0600390D RID: 14605 RVA: 0x000E83EC File Offset: 0x000E65EC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 302522, XrefRangeEnd = 302537, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Init(ref T obj, IUxmlAttributes bag, CreationContext cc)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				IntPtr intPtr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					ref IntPtr ptr2 = ref *ptr;
					intPtr = IL2CPP.Il2CppObjectBaseToPtr(obj);
					ptr2 = &intPtr;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(bag);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cc));
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SortColumnDescriptions.UxmlObjectTraits<T>.NativeMethodInfoPtr_Init_Public_Virtual_Void_byref_T_IUxmlAttributes_CreationContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr;
				obj = ((intPtr4 == 0) ? null : IL2CPP.PointerToValueGeneric<T>(intPtr4, false, false));
			}

			// Token: 0x0600390E RID: 14606 RVA: 0x000E847C File Offset: 0x000E667C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 302537, XrefRangeEnd = 302564, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe UxmlObjectTraits()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SortColumnDescriptions.UxmlObjectTraits<T>>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SortColumnDescriptions.UxmlObjectTraits<T>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600390F RID: 14607 RVA: 0x00017DF0 File Offset: 0x00015FF0
			public UxmlObjectTraits(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700118D RID: 4493
			// (get) Token: 0x06003910 RID: 14608 RVA: 0x000E84B8 File Offset: 0x000E66B8
			// (set) Token: 0x06003911 RID: 14609 RVA: 0x00017DF9 File Offset: 0x00015FF9
			public unsafe UxmlObjectListAttributeDescription<SortColumnDescription> m_SortColumnDescriptions
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortColumnDescriptions.UxmlObjectTraits<T>.NativeFieldInfoPtr_m_SortColumnDescriptions);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UxmlObjectListAttributeDescription<SortColumnDescription>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SortColumnDescriptions.UxmlObjectTraits<T>.NativeFieldInfoPtr_m_SortColumnDescriptions), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400286F RID: 10351
			private static readonly IntPtr NativeFieldInfoPtr_m_SortColumnDescriptions;

			// Token: 0x04002870 RID: 10352
			private static readonly IntPtr NativeMethodInfoPtr_Init_Public_Virtual_Void_byref_T_IUxmlAttributes_CreationContext_0;

			// Token: 0x04002871 RID: 10353
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}
