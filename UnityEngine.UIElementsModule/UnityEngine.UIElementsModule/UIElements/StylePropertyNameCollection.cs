using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.UIElements
{
	// Token: 0x02000124 RID: 292
	public sealed class StylePropertyNameCollection : ValueType
	{
		// Token: 0x060015FB RID: 5627 RVA: 0x0006ACCC File Offset: 0x00068ECC
		// Note: this type is marked as 'beforefieldinit'.
		static StylePropertyNameCollection()
		{
			Il2CppClassPointerStore<StylePropertyNameCollection>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "StylePropertyNameCollection");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StylePropertyNameCollection>.NativeClassPtr);
			StylePropertyNameCollection.NativeFieldInfoPtr_propertiesList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StylePropertyNameCollection>.NativeClassPtr, "propertiesList");
			StylePropertyNameCollection.NativeMethodInfoPtr__ctor_Internal_Void_List_1_StylePropertyName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StylePropertyNameCollection>.NativeClassPtr, 100666565);
			StylePropertyNameCollection.NativeMethodInfoPtr_GetEnumerator_Public_Enumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StylePropertyNameCollection>.NativeClassPtr, 100666566);
			StylePropertyNameCollection.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_UnityEngine_UIElements_StylePropertyName__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_StylePropertyName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StylePropertyNameCollection>.NativeClassPtr, 100666567);
			StylePropertyNameCollection.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StylePropertyNameCollection>.NativeClassPtr, 100666568);
		}

		// Token: 0x060015FC RID: 5628 RVA: 0x0006AD60 File Offset: 0x00068F60
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 307804, RefRangeEnd = 307807, XrefRangeStart = 307804, XrefRangeEnd = 307807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StylePropertyNameCollection(List<StylePropertyName> list)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StylePropertyNameCollection>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(list);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StylePropertyNameCollection.NativeMethodInfoPtr__ctor_Internal_Void_List_1_StylePropertyName_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060015FD RID: 5629 RVA: 0x0006ADB0 File Offset: 0x00068FB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 317195, XrefRangeEnd = 317199, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StylePropertyNameCollection.Enumerator GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StylePropertyNameCollection.NativeMethodInfoPtr_GetEnumerator_Public_Enumerator_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new StylePropertyNameCollection.Enumerator(intPtr);
		}

		// Token: 0x060015FE RID: 5630 RVA: 0x0006ADEC File Offset: 0x00068FEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 317199, XrefRangeEnd = 317206, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator<StylePropertyName> System_Collections_Generic_IEnumerable_UnityEngine_UIElements_StylePropertyName__GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StylePropertyNameCollection.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_UnityEngine_UIElements_StylePropertyName__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_StylePropertyName_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<StylePropertyName>>(intPtr3) : null;
		}

		// Token: 0x060015FF RID: 5631 RVA: 0x0006AE30 File Offset: 0x00069030
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 317206, XrefRangeEnd = 317213, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StylePropertyNameCollection.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06001600 RID: 5632 RVA: 0x0000A39B File Offset: 0x0000859B
		public StylePropertyNameCollection(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06001601 RID: 5633 RVA: 0x0000A3A4 File Offset: 0x000085A4
		public StylePropertyNameCollection()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StylePropertyNameCollection>.NativeClassPtr))
		{
		}

		// Token: 0x170006AA RID: 1706
		// (get) Token: 0x06001602 RID: 5634 RVA: 0x0006AE74 File Offset: 0x00069074
		// (set) Token: 0x06001603 RID: 5635 RVA: 0x0000A3B6 File Offset: 0x000085B6
		public unsafe List<StylePropertyName> propertiesList
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StylePropertyNameCollection.NativeFieldInfoPtr_propertiesList);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<StylePropertyName>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StylePropertyNameCollection.NativeFieldInfoPtr_propertiesList), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x06001604 RID: 5636 RVA: 0x0006AEA4 File Offset: 0x000690A4
		public bool Contains(StylePropertyName stylePropertyName)
		{
			List<StylePropertyName>.Enumerator enumerator = this.propertiesList.GetEnumerator();
			bool flag2;
			try
			{
				while (enumerator.MoveNext())
				{
					StylePropertyName stylePropertyName2 = enumerator.Current;
					bool flag = stylePropertyName2 == stylePropertyName;
					if (flag)
					{
						return true;
					}
				}
				flag2 = false;
			}
			finally
			{
				enumerator.Dispose();
			}
			return flag2;
		}

		// Token: 0x04000EFE RID: 3838
		private static readonly IntPtr NativeFieldInfoPtr_propertiesList;

		// Token: 0x04000EFF RID: 3839
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_List_1_StylePropertyName_0;

		// Token: 0x04000F00 RID: 3840
		private static readonly IntPtr NativeMethodInfoPtr_GetEnumerator_Public_Enumerator_0;

		// Token: 0x04000F01 RID: 3841
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_UnityEngine_UIElements_StylePropertyName__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_StylePropertyName_0;

		// Token: 0x04000F02 RID: 3842
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;

		// Token: 0x0200045A RID: 1114
		public sealed class Enumerator : ValueType
		{
			// Token: 0x06003BBB RID: 15291 RVA: 0x000F0698 File Offset: 0x000EE898
			// Note: this type is marked as 'beforefieldinit'.
			static Enumerator()
			{
				Il2CppClassPointerStore<StylePropertyNameCollection.Enumerator>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StylePropertyNameCollection>.NativeClassPtr, "Enumerator");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StylePropertyNameCollection.Enumerator>.NativeClassPtr);
				StylePropertyNameCollection.Enumerator.NativeFieldInfoPtr_m_Enumerator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StylePropertyNameCollection.Enumerator>.NativeClassPtr, "m_Enumerator");
				StylePropertyNameCollection.Enumerator.NativeMethodInfoPtr__ctor_Internal_Void_Enumerator_StylePropertyName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StylePropertyNameCollection.Enumerator>.NativeClassPtr, 100666569);
				StylePropertyNameCollection.Enumerator.NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StylePropertyNameCollection.Enumerator>.NativeClassPtr, 100666570);
				StylePropertyNameCollection.Enumerator.NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_StylePropertyName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StylePropertyNameCollection.Enumerator>.NativeClassPtr, 100666571);
				StylePropertyNameCollection.Enumerator.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StylePropertyNameCollection.Enumerator>.NativeClassPtr, 100666572);
				StylePropertyNameCollection.Enumerator.NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StylePropertyNameCollection.Enumerator>.NativeClassPtr, 100666573);
				StylePropertyNameCollection.Enumerator.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StylePropertyNameCollection.Enumerator>.NativeClassPtr, 100666574);
			}

			// Token: 0x06003BBC RID: 15292 RVA: 0x000F0750 File Offset: 0x000EE950
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 317183, XrefRangeEnd = 317184, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Enumerator(List<StylePropertyName>.Enumerator enumerator)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StylePropertyNameCollection.Enumerator>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(enumerator));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StylePropertyNameCollection.Enumerator.NativeMethodInfoPtr__ctor_Internal_Void_Enumerator_StylePropertyName_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06003BBD RID: 15293 RVA: 0x000F07A8 File Offset: 0x000EE9A8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 317184, XrefRangeEnd = 317187, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StylePropertyNameCollection.Enumerator.NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17001229 RID: 4649
			// (get) Token: 0x06003BBE RID: 15294 RVA: 0x000F07EC File Offset: 0x000EE9EC
			public unsafe StylePropertyName Current
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 317187, XrefRangeEnd = 317188, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StylePropertyNameCollection.Enumerator.NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_StylePropertyName_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return new StylePropertyName(intPtr);
				}
			}

			// Token: 0x1700122A RID: 4650
			// (get) Token: 0x06003BBF RID: 15295 RVA: 0x000F0828 File Offset: 0x000EEA28
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 317188, XrefRangeEnd = 317192, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StylePropertyNameCollection.Enumerator.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06003BC0 RID: 15296 RVA: 0x000F086C File Offset: 0x000EEA6C
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StylePropertyNameCollection.Enumerator.NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003BC1 RID: 15297 RVA: 0x000F08A4 File Offset: 0x000EEAA4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 317192, XrefRangeEnd = 317195, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StylePropertyNameCollection.Enumerator.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003BC2 RID: 15298 RVA: 0x00019121 File Offset: 0x00017321
			public Enumerator(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06003BC3 RID: 15299 RVA: 0x0001912A File Offset: 0x0001732A
			public Enumerator()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StylePropertyNameCollection.Enumerator>.NativeClassPtr))
			{
			}

			// Token: 0x17001228 RID: 4648
			// (get) Token: 0x06003BC4 RID: 15300 RVA: 0x000F08DC File Offset: 0x000EEADC
			// (set) Token: 0x06003BC5 RID: 15301 RVA: 0x0001913C File Offset: 0x0001733C
			public List<StylePropertyName>.Enumerator m_Enumerator
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StylePropertyNameCollection.Enumerator.NativeFieldInfoPtr_m_Enumerator);
					return new List<StylePropertyName>.Enumerator(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<List<StylePropertyName>.Enumerator>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StylePropertyNameCollection.Enumerator.NativeFieldInfoPtr_m_Enumerator), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<List<StylePropertyName>.Enumerator>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04002A25 RID: 10789
			private static readonly IntPtr NativeFieldInfoPtr_m_Enumerator;

			// Token: 0x04002A26 RID: 10790
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Enumerator_StylePropertyName_0;

			// Token: 0x04002A27 RID: 10791
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0;

			// Token: 0x04002A28 RID: 10792
			private static readonly IntPtr NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_StylePropertyName_0;

			// Token: 0x04002A29 RID: 10793
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04002A2A RID: 10794
			private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0;

			// Token: 0x04002A2B RID: 10795
			private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
		}
	}
}
