using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.UIElements
{
	// Token: 0x02000093 RID: 147
	public sealed class TreeViewItemData<T> : ValueType
	{
		// Token: 0x06000EBA RID: 3770 RVA: 0x00050D94 File Offset: 0x0004EF94
		// Note: this type is marked as 'beforefieldinit'.
		static TreeViewItemData()
		{
			Il2CppClassPointerStore<TreeViewItemData<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "TreeViewItemData`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TreeViewItemData<T>>.NativeClassPtr);
			TreeViewItemData<T>.NativeFieldInfoPtr__id_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TreeViewItemData<T>>.NativeClassPtr, "<id>k__BackingField");
			TreeViewItemData<T>.NativeFieldInfoPtr_m_Data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TreeViewItemData<T>>.NativeClassPtr, "m_Data");
			TreeViewItemData<T>.NativeFieldInfoPtr_m_Children = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TreeViewItemData<T>>.NativeClassPtr, "m_Children");
			TreeViewItemData<T>.NativeMethodInfoPtr_get_id_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TreeViewItemData<T>>.NativeClassPtr, 100665389);
			TreeViewItemData<T>.NativeMethodInfoPtr_get_data_Public_get_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TreeViewItemData<T>>.NativeClassPtr, 100665390);
			TreeViewItemData<T>.NativeMethodInfoPtr_get_children_Public_get_IEnumerable_1_TreeViewItemData_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TreeViewItemData<T>>.NativeClassPtr, 100665391);
			TreeViewItemData<T>.NativeMethodInfoPtr_get_hasChildren_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TreeViewItemData<T>>.NativeClassPtr, 100665392);
			TreeViewItemData<T>.NativeMethodInfoPtr_InsertChild_Internal_Void_TreeViewItemData_1_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TreeViewItemData<T>>.NativeClassPtr, 100665393);
			TreeViewItemData<T>.NativeMethodInfoPtr_RemoveChild_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TreeViewItemData<T>>.NativeClassPtr, 100665394);
			TreeViewItemData<T>.NativeMethodInfoPtr_GetChildIndex_Internal_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TreeViewItemData<T>>.NativeClassPtr, 100665395);
			TreeViewItemData<T>.NativeMethodInfoPtr_ReplaceChild_Internal_Void_TreeViewItemData_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TreeViewItemData<T>>.NativeClassPtr, 100665396);
		}

		// Token: 0x1700048A RID: 1162
		// (get) Token: 0x06000EBB RID: 3771 RVA: 0x00050EDC File Offset: 0x0004F0DC
		public unsafe int id
		{
			[CallerCount(200)]
			[CachedScanResults(RefRangeStart = 306429, RefRangeEnd = 306629, XrefRangeStart = 306429, XrefRangeEnd = 306629, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TreeViewItemData<T>.NativeMethodInfoPtr_get_id_Public_get_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700048B RID: 1163
		// (get) Token: 0x06000EBC RID: 3772 RVA: 0x00050F20 File Offset: 0x0004F120
		public unsafe T data
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 306629, RefRangeEnd = 306630, XrefRangeStart = 306629, XrefRangeEnd = 306630, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TreeViewItemData<T>.NativeMethodInfoPtr_get_data_Public_get_T_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
			}
		}

		// Token: 0x1700048C RID: 1164
		// (get) Token: 0x06000EBD RID: 3773 RVA: 0x00050F60 File Offset: 0x0004F160
		public unsafe IEnumerable<TreeViewItemData<T>> children
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TreeViewItemData<T>.NativeMethodInfoPtr_get_children_Public_get_IEnumerable_1_TreeViewItemData_1_T_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<TreeViewItemData<T>>>(intPtr3) : null;
			}
		}

		// Token: 0x1700048D RID: 1165
		// (get) Token: 0x06000EBE RID: 3774 RVA: 0x00050FA4 File Offset: 0x0004F1A4
		public unsafe bool hasChildren
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TreeViewItemData<T>.NativeMethodInfoPtr_get_hasChildren_Public_get_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000EBF RID: 3775 RVA: 0x00050FE8 File Offset: 0x0004F1E8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 306645, RefRangeEnd = 306646, XrefRangeStart = 306642, XrefRangeEnd = 306645, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InsertChild(TreeViewItemData<T> child, int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(child));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TreeViewItemData<T>.NativeMethodInfoPtr_InsertChild_Internal_Void_TreeViewItemData_1_T_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EC0 RID: 3776 RVA: 0x00051044 File Offset: 0x0004F244
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 306658, RefRangeEnd = 306659, XrefRangeStart = 306646, XrefRangeEnd = 306658, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveChild(int childId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref childId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TreeViewItemData<T>.NativeMethodInfoPtr_RemoveChild_Internal_Void_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000EC1 RID: 3777 RVA: 0x00051088 File Offset: 0x0004F288
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 306679, RefRangeEnd = 306680, XrefRangeStart = 306659, XrefRangeEnd = 306679, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetChildIndex(int itemId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref itemId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TreeViewItemData<T>.NativeMethodInfoPtr_GetChildIndex_Internal_Int32_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000EC2 RID: 3778 RVA: 0x000510D8 File Offset: 0x0004F2D8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 306706, RefRangeEnd = 306707, XrefRangeStart = 306680, XrefRangeEnd = 306706, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReplaceChild(TreeViewItemData<T> newChild)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(newChild));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TreeViewItemData<T>.NativeMethodInfoPtr_ReplaceChild_Internal_Void_TreeViewItemData_1_T_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000EC3 RID: 3779 RVA: 0x000078A9 File Offset: 0x00005AA9
		public TreeViewItemData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06000EC4 RID: 3780 RVA: 0x000078B2 File Offset: 0x00005AB2
		public TreeViewItemData()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TreeViewItemData<T>>.NativeClassPtr))
		{
		}

		// Token: 0x17000487 RID: 1159
		// (get) Token: 0x06000EC5 RID: 3781 RVA: 0x00051124 File Offset: 0x0004F324
		// (set) Token: 0x06000EC6 RID: 3782 RVA: 0x000078C4 File Offset: 0x00005AC4
		public unsafe int _id_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TreeViewItemData<T>.NativeFieldInfoPtr__id_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TreeViewItemData<T>.NativeFieldInfoPtr__id_k__BackingField)) = value;
			}
		}

		// Token: 0x17000488 RID: 1160
		// (get) Token: 0x06000EC7 RID: 3783 RVA: 0x0005114C File Offset: 0x0004F34C
		// (set) Token: 0x06000EC8 RID: 3784 RVA: 0x00051174 File Offset: 0x0004F374
		public unsafe T m_Data
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TreeViewItemData<T>.NativeFieldInfoPtr_m_Data);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, true, false);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TreeViewItemData<T>.NativeFieldInfoPtr_m_Data);
				Type typeFromHandle = typeof(T);
				if (!typeFromHandle.IsValueType)
				{
					if (!string.Equals(typeFromHandle.FullName, "System.String"))
					{
						IntPtr intPtr4;
						IntPtr intPtr3 = (intPtr4 = IL2CPP.Il2CppObjectBaseToPtr(value as Il2CppObjectBase));
						if (intPtr3 != 0)
						{
							intPtr4 = intPtr3;
							if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(intPtr3)))
							{
								IntPtr intPtr5 = intPtr3;
								cpblk(intPtr2, IL2CPP.il2cpp_object_unbox(intPtr3), IL2CPP.il2cpp_class_value_size(IL2CPP.il2cpp_object_get_class(intPtr5), (UIntPtr)0));
								return;
							}
						}
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, intPtr4);
					}
					else
					{
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, IL2CPP.ManagedStringToIl2Cpp(value as string));
					}
				}
				else
				{
					*intPtr2 = value;
				}
			}
		}

		// Token: 0x17000489 RID: 1161
		// (get) Token: 0x06000EC9 RID: 3785 RVA: 0x0005121C File Offset: 0x0004F41C
		// (set) Token: 0x06000ECA RID: 3786 RVA: 0x000078DF File Offset: 0x00005ADF
		public unsafe IList<TreeViewItemData<T>> m_Children
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TreeViewItemData<T>.NativeFieldInfoPtr_m_Children);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IList<TreeViewItemData<T>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TreeViewItemData<T>.NativeFieldInfoPtr_m_Children), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x06000ECB RID: 3787 RVA: 0x000078FE File Offset: 0x00005AFE
		public void AddChild(TreeViewItemData<T> child)
		{
			this.m_Children.Add(child);
		}

		// Token: 0x06000ECC RID: 3788 RVA: 0x0005124C File Offset: 0x0004F44C
		public void AddChildren(IList<TreeViewItemData<T>> children)
		{
			foreach (TreeViewItemData<T> treeViewItemData in children)
			{
				this.AddChild(treeViewItemData);
			}
		}

		// Token: 0x04000A3A RID: 2618
		private static readonly IntPtr NativeFieldInfoPtr__id_k__BackingField;

		// Token: 0x04000A3B RID: 2619
		private static readonly IntPtr NativeFieldInfoPtr_m_Data;

		// Token: 0x04000A3C RID: 2620
		private static readonly IntPtr NativeFieldInfoPtr_m_Children;

		// Token: 0x04000A3D RID: 2621
		private static readonly IntPtr NativeMethodInfoPtr_get_id_Public_get_Int32_0;

		// Token: 0x04000A3E RID: 2622
		private static readonly IntPtr NativeMethodInfoPtr_get_data_Public_get_T_0;

		// Token: 0x04000A3F RID: 2623
		private static readonly IntPtr NativeMethodInfoPtr_get_children_Public_get_IEnumerable_1_TreeViewItemData_1_T_0;

		// Token: 0x04000A40 RID: 2624
		private static readonly IntPtr NativeMethodInfoPtr_get_hasChildren_Public_get_Boolean_0;

		// Token: 0x04000A41 RID: 2625
		private static readonly IntPtr NativeMethodInfoPtr_InsertChild_Internal_Void_TreeViewItemData_1_T_Int32_0;

		// Token: 0x04000A42 RID: 2626
		private static readonly IntPtr NativeMethodInfoPtr_RemoveChild_Internal_Void_Int32_0;

		// Token: 0x04000A43 RID: 2627
		private static readonly IntPtr NativeMethodInfoPtr_GetChildIndex_Internal_Int32_Int32_0;

		// Token: 0x04000A44 RID: 2628
		private static readonly IntPtr NativeMethodInfoPtr_ReplaceChild_Internal_Void_TreeViewItemData_1_T_0;
	}
}
