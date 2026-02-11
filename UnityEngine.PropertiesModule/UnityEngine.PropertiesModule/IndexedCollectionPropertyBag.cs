using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Unity.Properties
{
	// Token: 0x02000012 RID: 18
	public class IndexedCollectionPropertyBag<TList, TElement> : PropertyBag<TList>
	{
		// Token: 0x06000085 RID: 133 RVA: 0x00005204 File Offset: 0x00003404
		// Note: this type is marked as 'beforefieldinit'.
		static IndexedCollectionPropertyBag()
		{
			Il2CppClassPointerStore<IndexedCollectionPropertyBag<TList, TElement>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("UnityEngine.PropertiesModule.dll", "Unity.Properties", "IndexedCollectionPropertyBag`2"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TList>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TElement>.NativeClassPtr))
			})).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IndexedCollectionPropertyBag<TList, TElement>>.NativeClassPtr);
			IndexedCollectionPropertyBag<TList, TElement>.NativeFieldInfoPtr_m_Property = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IndexedCollectionPropertyBag<TList, TElement>>.NativeClassPtr, "m_Property");
			IndexedCollectionPropertyBag<TList, TElement>.NativeMethodInfoPtr_Unity_Properties_IConstructorWithCount_TList__InstantiateWithCount_Private_Virtual_Final_New_TList_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IndexedCollectionPropertyBag<TList, TElement>>.NativeClassPtr, 100663350);
			IndexedCollectionPropertyBag<TList, TElement>.NativeMethodInfoPtr_InstantiateWithCount_Protected_Virtual_New_TList_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IndexedCollectionPropertyBag<TList, TElement>>.NativeClassPtr, 100663351);
			IndexedCollectionPropertyBag<TList, TElement>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IndexedCollectionPropertyBag<TList, TElement>>.NativeClassPtr, 100663352);
		}

		// Token: 0x06000086 RID: 134 RVA: 0x000052D4 File Offset: 0x000034D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1230796, XrefRangeEnd = 1230802, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual TList Unity_Properties_IConstructorWithCount_TList__InstantiateWithCount(int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref count;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IndexedCollectionPropertyBag<TList, TElement>.NativeMethodInfoPtr_Unity_Properties_IConstructorWithCount_TList__InstantiateWithCount_Private_Virtual_Final_New_TList_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<TList>(intPtr, false, true);
			}
		}

		// Token: 0x06000087 RID: 135 RVA: 0x0000531C File Offset: 0x0000351C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1230802, XrefRangeEnd = 1230812, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual TList InstantiateWithCount(int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref count;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IndexedCollectionPropertyBag<TList, TElement>.NativeMethodInfoPtr_InstantiateWithCount_Protected_Virtual_New_TList_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<TList>(intPtr, false, true);
			}
		}

		// Token: 0x06000088 RID: 136 RVA: 0x00005370 File Offset: 0x00003570
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1230812, XrefRangeEnd = 1230820, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IndexedCollectionPropertyBag()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IndexedCollectionPropertyBag<TList, TElement>>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IndexedCollectionPropertyBag<TList, TElement>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000089 RID: 137 RVA: 0x00002447 File Offset: 0x00000647
		public IndexedCollectionPropertyBag(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x0600008A RID: 138 RVA: 0x000053AC File Offset: 0x000035AC
		// (set) Token: 0x0600008B RID: 139 RVA: 0x00002450 File Offset: 0x00000650
		public unsafe IndexedCollectionPropertyBag<TList, TElement>.ListElementProperty m_Property
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IndexedCollectionPropertyBag<TList, TElement>.NativeFieldInfoPtr_m_Property);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IndexedCollectionPropertyBag<TList, TElement>.ListElementProperty>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IndexedCollectionPropertyBag<TList, TElement>.NativeFieldInfoPtr_m_Property), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0600008C RID: 140 RVA: 0x0000246F File Offset: 0x0000066F
		public bool TryGetProperty(ref TList container, int index, out IProperty<TList> property)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600008D RID: 141 RVA: 0x0000247C File Offset: 0x0000067C
		public void Unity.Properties.ICollectionPropertyBagAccept<TList>.Accept(ICollectionPropertyBagVisitor visitor, ref TList container)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600008E RID: 142 RVA: 0x00002489 File Offset: 0x00000689
		public void Unity.Properties.IListPropertyBagAccept<TList>.Accept(IListPropertyBagVisitor visitor, ref TList list)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600008F RID: 143 RVA: 0x00002496 File Offset: 0x00000696
		public void Unity.Properties.IListPropertyAccept<TList>.Accept<TContainer>(IListPropertyVisitor visitor, Property<TContainer, TList> property, ref TContainer container, ref TList list)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000090 RID: 144 RVA: 0x000053DC File Offset: 0x000035DC
		public int Unity.Properties.IIndexedCollectionPropertyBagEnumerator<TList>.GetCount(ref TList container)
		{
			return container.Count;
		}

		// Token: 0x06000091 RID: 145 RVA: 0x000053FC File Offset: 0x000035FC
		public IProperty<TList> Unity.Properties.IIndexedCollectionPropertyBagEnumerator<TList>.GetSharedProperty()
		{
			return this.m_Property;
		}

		// Token: 0x0400003F RID: 63
		private static readonly IntPtr NativeFieldInfoPtr_m_Property;

		// Token: 0x04000040 RID: 64
		private static readonly IntPtr NativeMethodInfoPtr_Unity_Properties_IConstructorWithCount_TList__InstantiateWithCount_Private_Virtual_Final_New_TList_Int32_0;

		// Token: 0x04000041 RID: 65
		private static readonly IntPtr NativeMethodInfoPtr_InstantiateWithCount_Protected_Virtual_New_TList_Int32_0;

		// Token: 0x04000042 RID: 66
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000061 RID: 97
		public class ListElementProperty : Property<TList, TElement>
		{
			// Token: 0x06000201 RID: 513 RVA: 0x00008B90 File Offset: 0x00006D90
			// Note: this type is marked as 'beforefieldinit'.
			static ListElementProperty()
			{
				Il2CppClassPointerStore<IndexedCollectionPropertyBag<TList, TElement>.ListElementProperty>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<IndexedCollectionPropertyBag<TList, TElement>>.NativeClassPtr, "ListElementProperty"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
				{
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TList>.NativeClassPtr)),
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TElement>.NativeClassPtr))
				})).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IndexedCollectionPropertyBag<TList, TElement>.ListElementProperty>.NativeClassPtr);
				IndexedCollectionPropertyBag<TList, TElement>.ListElementProperty.NativeFieldInfoPtr_m_Index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IndexedCollectionPropertyBag<TList, TElement>.ListElementProperty>.NativeClassPtr, "m_Index");
				IndexedCollectionPropertyBag<TList, TElement>.ListElementProperty.NativeMethodInfoPtr_get_Index_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IndexedCollectionPropertyBag<TList, TElement>.ListElementProperty>.NativeClassPtr, 100663353);
				IndexedCollectionPropertyBag<TList, TElement>.ListElementProperty.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IndexedCollectionPropertyBag<TList, TElement>.ListElementProperty>.NativeClassPtr, 100663354);
				IndexedCollectionPropertyBag<TList, TElement>.ListElementProperty.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IndexedCollectionPropertyBag<TList, TElement>.ListElementProperty>.NativeClassPtr, 100663355);
			}

			// Token: 0x17000070 RID: 112
			// (get) Token: 0x06000202 RID: 514 RVA: 0x00008C58 File Offset: 0x00006E58
			public unsafe virtual int Index
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IndexedCollectionPropertyBag<TList, TElement>.ListElementProperty.NativeMethodInfoPtr_get_Index_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17000071 RID: 113
			// (get) Token: 0x06000203 RID: 515 RVA: 0x00008C94 File Offset: 0x00006E94
			public unsafe override string Name
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1230795, XrefRangeEnd = 1230796, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IndexedCollectionPropertyBag<TList, TElement>.ListElementProperty.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x06000204 RID: 516 RVA: 0x00008CD8 File Offset: 0x00006ED8
			[CallerCount(0)]
			public unsafe ListElementProperty()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IndexedCollectionPropertyBag<TList, TElement>.ListElementProperty>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IndexedCollectionPropertyBag<TList, TElement>.ListElementProperty.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000205 RID: 517 RVA: 0x00003138 File Offset: 0x00001338
			public ListElementProperty(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700006F RID: 111
			// (get) Token: 0x06000206 RID: 518 RVA: 0x00008D14 File Offset: 0x00006F14
			// (set) Token: 0x06000207 RID: 519 RVA: 0x00003141 File Offset: 0x00001341
			public unsafe int m_Index
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IndexedCollectionPropertyBag<TList, TElement>.ListElementProperty.NativeFieldInfoPtr_m_Index);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IndexedCollectionPropertyBag<TList, TElement>.ListElementProperty.NativeFieldInfoPtr_m_Index)) = value;
				}
			}

			// Token: 0x040000F0 RID: 240
			private static readonly IntPtr NativeFieldInfoPtr_m_Index;

			// Token: 0x040000F1 RID: 241
			private static readonly IntPtr NativeMethodInfoPtr_get_Index_Public_Virtual_Final_New_get_Int32_0;

			// Token: 0x040000F2 RID: 242
			private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0;

			// Token: 0x040000F3 RID: 243
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}
