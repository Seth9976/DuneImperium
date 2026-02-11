using System;
using System.Reflection;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;
using Il2CppSystem.Globalization;

namespace Il2CppSystem.ComponentModel.Design
{
	// Token: 0x02000154 RID: 340
	public class DesignerOptionService : Object
	{
		// Token: 0x06001489 RID: 5257 RVA: 0x000091E0 File Offset: 0x000073E0
		// Note: this type is marked as 'beforefieldinit'.
		static DesignerOptionService()
		{
			Il2CppClassPointerStore<DesignerOptionService>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.ComponentModel.Design", "DesignerOptionService");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DesignerOptionService>.NativeClassPtr);
			DesignerOptionService.NativeMethodInfoPtr_PopulateOptionCollection_Protected_Virtual_New_Void_DesignerOptionCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DesignerOptionService>.NativeClassPtr, 100666360);
		}

		// Token: 0x0600148A RID: 5258 RVA: 0x0006BC80 File Offset: 0x00069E80
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void PopulateOptionCollection(DesignerOptionService.DesignerOptionCollection options)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(options);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DesignerOptionService.NativeMethodInfoPtr_PopulateOptionCollection_Protected_Virtual_New_Void_DesignerOptionCollection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600148B RID: 5259 RVA: 0x00009219 File Offset: 0x00007419
		public DesignerOptionService(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001020 RID: 4128
		private static readonly IntPtr NativeMethodInfoPtr_PopulateOptionCollection_Protected_Virtual_New_Void_DesignerOptionCollection_0;

		// Token: 0x020002EB RID: 747
		[DefaultMember("Item")]
		public sealed class DesignerOptionCollection : Object
		{
			// Token: 0x06002CBA RID: 11450 RVA: 0x000C4C2C File Offset: 0x000C2E2C
			// Note: this type is marked as 'beforefieldinit'.
			static DesignerOptionCollection()
			{
				Il2CppClassPointerStore<DesignerOptionService.DesignerOptionCollection>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DesignerOptionService>.NativeClassPtr, "DesignerOptionCollection");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DesignerOptionService.DesignerOptionCollection>.NativeClassPtr);
				DesignerOptionService.DesignerOptionCollection.NativeFieldInfoPtr__service = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DesignerOptionService.DesignerOptionCollection>.NativeClassPtr, "_service");
				DesignerOptionService.DesignerOptionCollection.NativeFieldInfoPtr__name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DesignerOptionService.DesignerOptionCollection>.NativeClassPtr, "_name");
				DesignerOptionService.DesignerOptionCollection.NativeFieldInfoPtr__value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DesignerOptionService.DesignerOptionCollection>.NativeClassPtr, "_value");
				DesignerOptionService.DesignerOptionCollection.NativeFieldInfoPtr__children = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DesignerOptionService.DesignerOptionCollection>.NativeClassPtr, "_children");
				DesignerOptionService.DesignerOptionCollection.NativeFieldInfoPtr__properties = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DesignerOptionService.DesignerOptionCollection>.NativeClassPtr, "_properties");
				DesignerOptionService.DesignerOptionCollection.NativeMethodInfoPtr_get_Count_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DesignerOptionService.DesignerOptionCollection>.NativeClassPtr, 100666361);
				DesignerOptionService.DesignerOptionCollection.NativeMethodInfoPtr_get_Name_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DesignerOptionService.DesignerOptionCollection>.NativeClassPtr, 100666362);
				DesignerOptionService.DesignerOptionCollection.NativeMethodInfoPtr_get_Properties_Public_get_PropertyDescriptorCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DesignerOptionService.DesignerOptionCollection>.NativeClassPtr, 100666363);
				DesignerOptionService.DesignerOptionCollection.NativeMethodInfoPtr_CopyTo_Public_Virtual_Final_New_Void_Array_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DesignerOptionService.DesignerOptionCollection>.NativeClassPtr, 100666364);
				DesignerOptionService.DesignerOptionCollection.NativeMethodInfoPtr_EnsurePopulated_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DesignerOptionService.DesignerOptionCollection>.NativeClassPtr, 100666365);
				DesignerOptionService.DesignerOptionCollection.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DesignerOptionService.DesignerOptionCollection>.NativeClassPtr, 100666366);
				DesignerOptionService.DesignerOptionCollection.NativeMethodInfoPtr_System_Collections_ICollection_get_IsSynchronized_Private_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DesignerOptionService.DesignerOptionCollection>.NativeClassPtr, 100666367);
				DesignerOptionService.DesignerOptionCollection.NativeMethodInfoPtr_System_Collections_ICollection_get_SyncRoot_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DesignerOptionService.DesignerOptionCollection>.NativeClassPtr, 100666368);
			}

			// Token: 0x17000E04 RID: 3588
			// (get) Token: 0x06002CBB RID: 11451 RVA: 0x000C4D5C File Offset: 0x000C2F5C
			public unsafe int Count
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 466017, XrefRangeEnd = 466019, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DesignerOptionService.DesignerOptionCollection.NativeMethodInfoPtr_get_Count_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17000E05 RID: 3589
			// (get) Token: 0x06002CBC RID: 11452 RVA: 0x000C4D98 File Offset: 0x000C2F98
			public unsafe string Name
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DesignerOptionService.DesignerOptionCollection.NativeMethodInfoPtr_get_Name_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x17000E06 RID: 3590
			// (get) Token: 0x06002CBD RID: 11453 RVA: 0x000C4DD0 File Offset: 0x000C2FD0
			public unsafe PropertyDescriptorCollection Properties
			{
				[CallerCount(2)]
				[CachedScanResults(RefRangeStart = 466091, RefRangeEnd = 466093, XrefRangeStart = 466019, XrefRangeEnd = 466091, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DesignerOptionService.DesignerOptionCollection.NativeMethodInfoPtr_get_Properties_Public_get_PropertyDescriptorCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<PropertyDescriptorCollection>(intPtr3) : null;
				}
			}

			// Token: 0x06002CBE RID: 11454 RVA: 0x000C4E10 File Offset: 0x000C3010
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 466093, XrefRangeEnd = 466095, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void CopyTo(Array array, int index)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DesignerOptionService.DesignerOptionCollection.NativeMethodInfoPtr_CopyTo_Public_Virtual_Final_New_Void_Array_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002CBF RID: 11455 RVA: 0x000C4E60 File Offset: 0x000C3060
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 466100, RefRangeEnd = 466105, XrefRangeStart = 466095, XrefRangeEnd = 466100, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void EnsurePopulated()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DesignerOptionService.DesignerOptionCollection.NativeMethodInfoPtr_EnsurePopulated_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002CC0 RID: 11456 RVA: 0x000C4E94 File Offset: 0x000C3094
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 466105, XrefRangeEnd = 466107, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DesignerOptionService.DesignerOptionCollection.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x17000E07 RID: 3591
			// (get) Token: 0x06002CC1 RID: 11457 RVA: 0x000C4ED4 File Offset: 0x000C30D4
			public unsafe bool System.Collections.ICollection.IsSynchronized
			{
				[CallerCount(184)]
				[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DesignerOptionService.DesignerOptionCollection.NativeMethodInfoPtr_System_Collections_ICollection_get_IsSynchronized_Private_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17000E08 RID: 3592
			// (get) Token: 0x06002CC2 RID: 11458 RVA: 0x000C4F10 File Offset: 0x000C3110
			public unsafe Object System.Collections.ICollection.SyncRoot
			{
				[CallerCount(1295)]
				[CachedScanResults(RefRangeStart = 308780, RefRangeEnd = 310075, XrefRangeStart = 308780, XrefRangeEnd = 310075, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DesignerOptionService.DesignerOptionCollection.NativeMethodInfoPtr_System_Collections_ICollection_get_SyncRoot_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002CC3 RID: 11459 RVA: 0x00014233 File Offset: 0x00012433
			public DesignerOptionCollection(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000DFF RID: 3583
			// (get) Token: 0x06002CC4 RID: 11460 RVA: 0x000C4F50 File Offset: 0x000C3150
			// (set) Token: 0x06002CC5 RID: 11461 RVA: 0x0001423C File Offset: 0x0001243C
			public unsafe DesignerOptionService _service
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DesignerOptionService.DesignerOptionCollection.NativeFieldInfoPtr__service);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DesignerOptionService>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DesignerOptionService.DesignerOptionCollection.NativeFieldInfoPtr__service), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000E00 RID: 3584
			// (get) Token: 0x06002CC6 RID: 11462 RVA: 0x000C4F80 File Offset: 0x000C3180
			// (set) Token: 0x06002CC7 RID: 11463 RVA: 0x0001425B File Offset: 0x0001245B
			public unsafe string _name
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DesignerOptionService.DesignerOptionCollection.NativeFieldInfoPtr__name);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DesignerOptionService.DesignerOptionCollection.NativeFieldInfoPtr__name), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000E01 RID: 3585
			// (get) Token: 0x06002CC8 RID: 11464 RVA: 0x000C4FA8 File Offset: 0x000C31A8
			// (set) Token: 0x06002CC9 RID: 11465 RVA: 0x0001427A File Offset: 0x0001247A
			public unsafe Object _value
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DesignerOptionService.DesignerOptionCollection.NativeFieldInfoPtr__value);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DesignerOptionService.DesignerOptionCollection.NativeFieldInfoPtr__value), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000E02 RID: 3586
			// (get) Token: 0x06002CCA RID: 11466 RVA: 0x000C4FD8 File Offset: 0x000C31D8
			// (set) Token: 0x06002CCB RID: 11467 RVA: 0x00014299 File Offset: 0x00012499
			public unsafe ArrayList _children
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DesignerOptionService.DesignerOptionCollection.NativeFieldInfoPtr__children);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArrayList>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DesignerOptionService.DesignerOptionCollection.NativeFieldInfoPtr__children), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000E03 RID: 3587
			// (get) Token: 0x06002CCC RID: 11468 RVA: 0x000C5008 File Offset: 0x000C3208
			// (set) Token: 0x06002CCD RID: 11469 RVA: 0x000142B8 File Offset: 0x000124B8
			public unsafe PropertyDescriptorCollection _properties
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DesignerOptionService.DesignerOptionCollection.NativeFieldInfoPtr__properties);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PropertyDescriptorCollection>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DesignerOptionService.DesignerOptionCollection.NativeFieldInfoPtr__properties), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002341 RID: 9025
			private static readonly IntPtr NativeFieldInfoPtr__service;

			// Token: 0x04002342 RID: 9026
			private static readonly IntPtr NativeFieldInfoPtr__name;

			// Token: 0x04002343 RID: 9027
			private static readonly IntPtr NativeFieldInfoPtr__value;

			// Token: 0x04002344 RID: 9028
			private static readonly IntPtr NativeFieldInfoPtr__children;

			// Token: 0x04002345 RID: 9029
			private static readonly IntPtr NativeFieldInfoPtr__properties;

			// Token: 0x04002346 RID: 9030
			private static readonly IntPtr NativeMethodInfoPtr_get_Count_Public_Virtual_Final_New_get_Int32_0;

			// Token: 0x04002347 RID: 9031
			private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_get_String_0;

			// Token: 0x04002348 RID: 9032
			private static readonly IntPtr NativeMethodInfoPtr_get_Properties_Public_get_PropertyDescriptorCollection_0;

			// Token: 0x04002349 RID: 9033
			private static readonly IntPtr NativeMethodInfoPtr_CopyTo_Public_Virtual_Final_New_Void_Array_Int32_0;

			// Token: 0x0400234A RID: 9034
			private static readonly IntPtr NativeMethodInfoPtr_EnsurePopulated_Private_Void_0;

			// Token: 0x0400234B RID: 9035
			private static readonly IntPtr NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_0;

			// Token: 0x0400234C RID: 9036
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_ICollection_get_IsSynchronized_Private_Virtual_Final_New_get_Boolean_0;

			// Token: 0x0400234D RID: 9037
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_ICollection_get_SyncRoot_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x020003BA RID: 954
			public sealed class WrappedPropertyDescriptor : PropertyDescriptor
			{
				// Token: 0x0600357D RID: 13693 RVA: 0x000DE0A4 File Offset: 0x000DC2A4
				// Note: this type is marked as 'beforefieldinit'.
				static WrappedPropertyDescriptor()
				{
					Il2CppClassPointerStore<DesignerOptionService.DesignerOptionCollection.WrappedPropertyDescriptor>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DesignerOptionService.DesignerOptionCollection>.NativeClassPtr, "WrappedPropertyDescriptor");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DesignerOptionService.DesignerOptionCollection.WrappedPropertyDescriptor>.NativeClassPtr);
					DesignerOptionService.DesignerOptionCollection.WrappedPropertyDescriptor.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DesignerOptionService.DesignerOptionCollection.WrappedPropertyDescriptor>.NativeClassPtr, "target");
					DesignerOptionService.DesignerOptionCollection.WrappedPropertyDescriptor.NativeFieldInfoPtr_property = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DesignerOptionService.DesignerOptionCollection.WrappedPropertyDescriptor>.NativeClassPtr, "property");
					DesignerOptionService.DesignerOptionCollection.WrappedPropertyDescriptor.NativeMethodInfoPtr__ctor_Internal_Void_PropertyDescriptor_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DesignerOptionService.DesignerOptionCollection.WrappedPropertyDescriptor>.NativeClassPtr, 100666369);
					DesignerOptionService.DesignerOptionCollection.WrappedPropertyDescriptor.NativeMethodInfoPtr_get_Attributes_Public_Virtual_get_AttributeCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DesignerOptionService.DesignerOptionCollection.WrappedPropertyDescriptor>.NativeClassPtr, 100666370);
					DesignerOptionService.DesignerOptionCollection.WrappedPropertyDescriptor.NativeMethodInfoPtr_get_ComponentType_Public_Virtual_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DesignerOptionService.DesignerOptionCollection.WrappedPropertyDescriptor>.NativeClassPtr, 100666371);
					DesignerOptionService.DesignerOptionCollection.WrappedPropertyDescriptor.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DesignerOptionService.DesignerOptionCollection.WrappedPropertyDescriptor>.NativeClassPtr, 100666372);
					DesignerOptionService.DesignerOptionCollection.WrappedPropertyDescriptor.NativeMethodInfoPtr_get_PropertyType_Public_Virtual_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DesignerOptionService.DesignerOptionCollection.WrappedPropertyDescriptor>.NativeClassPtr, 100666373);
					DesignerOptionService.DesignerOptionCollection.WrappedPropertyDescriptor.NativeMethodInfoPtr_CanResetValue_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DesignerOptionService.DesignerOptionCollection.WrappedPropertyDescriptor>.NativeClassPtr, 100666374);
					DesignerOptionService.DesignerOptionCollection.WrappedPropertyDescriptor.NativeMethodInfoPtr_GetValue_Public_Virtual_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DesignerOptionService.DesignerOptionCollection.WrappedPropertyDescriptor>.NativeClassPtr, 100666375);
					DesignerOptionService.DesignerOptionCollection.WrappedPropertyDescriptor.NativeMethodInfoPtr_ResetValue_Public_Virtual_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DesignerOptionService.DesignerOptionCollection.WrappedPropertyDescriptor>.NativeClassPtr, 100666376);
					DesignerOptionService.DesignerOptionCollection.WrappedPropertyDescriptor.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DesignerOptionService.DesignerOptionCollection.WrappedPropertyDescriptor>.NativeClassPtr, 100666377);
					DesignerOptionService.DesignerOptionCollection.WrappedPropertyDescriptor.NativeMethodInfoPtr_ShouldSerializeValue_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DesignerOptionService.DesignerOptionCollection.WrappedPropertyDescriptor>.NativeClassPtr, 100666378);
				}

				// Token: 0x0600357E RID: 13694 RVA: 0x000DE1C0 File Offset: 0x000DC3C0
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 466004, XrefRangeEnd = 466008, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe WrappedPropertyDescriptor(PropertyDescriptor property, Object target)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DesignerOptionService.DesignerOptionCollection.WrappedPropertyDescriptor>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(property);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(target);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DesignerOptionService.DesignerOptionCollection.WrappedPropertyDescriptor.NativeMethodInfoPtr__ctor_Internal_Void_PropertyDescriptor_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x170010B7 RID: 4279
				// (get) Token: 0x0600357F RID: 13695 RVA: 0x000DE220 File Offset: 0x000DC420
				public unsafe override AttributeCollection Attributes
				{
					[CallerCount(0)]
					[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 466008, XrefRangeEnd = 466009, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DesignerOptionService.DesignerOptionCollection.WrappedPropertyDescriptor.NativeMethodInfoPtr_get_Attributes_Public_Virtual_get_AttributeCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<AttributeCollection>(intPtr3) : null;
					}
				}

				// Token: 0x170010B8 RID: 4280
				// (get) Token: 0x06003580 RID: 13696 RVA: 0x000DE260 File Offset: 0x000DC460
				public unsafe override Type ComponentType
				{
					[CallerCount(0)]
					[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 466009, XrefRangeEnd = 466010, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DesignerOptionService.DesignerOptionCollection.WrappedPropertyDescriptor.NativeMethodInfoPtr_get_ComponentType_Public_Virtual_get_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
					}
				}

				// Token: 0x170010B9 RID: 4281
				// (get) Token: 0x06003581 RID: 13697 RVA: 0x000DE2A0 File Offset: 0x000DC4A0
				public unsafe override bool IsReadOnly
				{
					[CallerCount(0)]
					[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 466010, XrefRangeEnd = 466011, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DesignerOptionService.DesignerOptionCollection.WrappedPropertyDescriptor.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return *IL2CPP.il2cpp_object_unbox(intPtr);
					}
				}

				// Token: 0x170010BA RID: 4282
				// (get) Token: 0x06003582 RID: 13698 RVA: 0x000DE2DC File Offset: 0x000DC4DC
				public unsafe override Type PropertyType
				{
					[CallerCount(0)]
					[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 466011, XrefRangeEnd = 466012, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DesignerOptionService.DesignerOptionCollection.WrappedPropertyDescriptor.NativeMethodInfoPtr_get_PropertyType_Public_Virtual_get_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
					}
				}

				// Token: 0x06003583 RID: 13699 RVA: 0x000DE31C File Offset: 0x000DC51C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 466012, XrefRangeEnd = 466013, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe override bool CanResetValue(Object component)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(component);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DesignerOptionService.DesignerOptionCollection.WrappedPropertyDescriptor.NativeMethodInfoPtr_CanResetValue_Public_Virtual_Boolean_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return *IL2CPP.il2cpp_object_unbox(intPtr);
					}
				}

				// Token: 0x06003584 RID: 13700 RVA: 0x000DE36C File Offset: 0x000DC56C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 466013, XrefRangeEnd = 466014, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe override Object GetValue(Object component)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(component);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DesignerOptionService.DesignerOptionCollection.WrappedPropertyDescriptor.NativeMethodInfoPtr_GetValue_Public_Virtual_Object_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
					}
				}

				// Token: 0x06003585 RID: 13701 RVA: 0x000DE3BC File Offset: 0x000DC5BC
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 466014, XrefRangeEnd = 466015, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe override void ResetValue(Object component)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(component);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DesignerOptionService.DesignerOptionCollection.WrappedPropertyDescriptor.NativeMethodInfoPtr_ResetValue_Public_Virtual_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}

				// Token: 0x06003586 RID: 13702 RVA: 0x000DE400 File Offset: 0x000DC600
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 466015, XrefRangeEnd = 466016, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe override void SetValue(Object component, Object value)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(component);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DesignerOptionService.DesignerOptionCollection.WrappedPropertyDescriptor.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_Object_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06003587 RID: 13703 RVA: 0x000DE454 File Offset: 0x000DC654
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 466016, XrefRangeEnd = 466017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe override bool ShouldSerializeValue(Object component)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(component);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DesignerOptionService.DesignerOptionCollection.WrappedPropertyDescriptor.NativeMethodInfoPtr_ShouldSerializeValue_Public_Virtual_Boolean_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return *IL2CPP.il2cpp_object_unbox(intPtr);
					}
				}

				// Token: 0x06003588 RID: 13704 RVA: 0x0001A45F File Offset: 0x0001865F
				public WrappedPropertyDescriptor(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x170010B5 RID: 4277
				// (get) Token: 0x06003589 RID: 13705 RVA: 0x000DE4A4 File Offset: 0x000DC6A4
				// (set) Token: 0x0600358A RID: 13706 RVA: 0x0001A468 File Offset: 0x00018668
				public unsafe Object target
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DesignerOptionService.DesignerOptionCollection.WrappedPropertyDescriptor.NativeFieldInfoPtr_target);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DesignerOptionService.DesignerOptionCollection.WrappedPropertyDescriptor.NativeFieldInfoPtr_target), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x170010B6 RID: 4278
				// (get) Token: 0x0600358B RID: 13707 RVA: 0x000DE4D4 File Offset: 0x000DC6D4
				// (set) Token: 0x0600358C RID: 13708 RVA: 0x0001A487 File Offset: 0x00018687
				public unsafe PropertyDescriptor property
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DesignerOptionService.DesignerOptionCollection.WrappedPropertyDescriptor.NativeFieldInfoPtr_property);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<PropertyDescriptor>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DesignerOptionService.DesignerOptionCollection.WrappedPropertyDescriptor.NativeFieldInfoPtr_property), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x0400286D RID: 10349
				private static readonly IntPtr NativeFieldInfoPtr_target;

				// Token: 0x0400286E RID: 10350
				private static readonly IntPtr NativeFieldInfoPtr_property;

				// Token: 0x0400286F RID: 10351
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_PropertyDescriptor_Object_0;

				// Token: 0x04002870 RID: 10352
				private static readonly IntPtr NativeMethodInfoPtr_get_Attributes_Public_Virtual_get_AttributeCollection_0;

				// Token: 0x04002871 RID: 10353
				private static readonly IntPtr NativeMethodInfoPtr_get_ComponentType_Public_Virtual_get_Type_0;

				// Token: 0x04002872 RID: 10354
				private static readonly IntPtr NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0;

				// Token: 0x04002873 RID: 10355
				private static readonly IntPtr NativeMethodInfoPtr_get_PropertyType_Public_Virtual_get_Type_0;

				// Token: 0x04002874 RID: 10356
				private static readonly IntPtr NativeMethodInfoPtr_CanResetValue_Public_Virtual_Boolean_Object_0;

				// Token: 0x04002875 RID: 10357
				private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Virtual_Object_Object_0;

				// Token: 0x04002876 RID: 10358
				private static readonly IntPtr NativeMethodInfoPtr_ResetValue_Public_Virtual_Void_Object_0;

				// Token: 0x04002877 RID: 10359
				private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_Virtual_Void_Object_Object_0;

				// Token: 0x04002878 RID: 10360
				private static readonly IntPtr NativeMethodInfoPtr_ShouldSerializeValue_Public_Virtual_Boolean_Object_0;
			}
		}

		// Token: 0x020002EC RID: 748
		public sealed class DesignerOptionConverter : TypeConverter
		{
			// Token: 0x06002CCE RID: 11470 RVA: 0x000C5038 File Offset: 0x000C3238
			// Note: this type is marked as 'beforefieldinit'.
			static DesignerOptionConverter()
			{
				Il2CppClassPointerStore<DesignerOptionService.DesignerOptionConverter>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DesignerOptionService>.NativeClassPtr, "DesignerOptionConverter");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DesignerOptionService.DesignerOptionConverter>.NativeClassPtr);
				DesignerOptionService.DesignerOptionConverter.NativeMethodInfoPtr_GetPropertiesSupported_Public_Virtual_Boolean_ITypeDescriptorContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DesignerOptionService.DesignerOptionConverter>.NativeClassPtr, 100666379);
				DesignerOptionService.DesignerOptionConverter.NativeMethodInfoPtr_GetProperties_Public_Virtual_PropertyDescriptorCollection_ITypeDescriptorContext_Object_Il2CppReferenceArray_1_Attribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DesignerOptionService.DesignerOptionConverter>.NativeClassPtr, 100666380);
				DesignerOptionService.DesignerOptionConverter.NativeMethodInfoPtr_ConvertTo_Public_Virtual_Object_ITypeDescriptorContext_CultureInfo_Object_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DesignerOptionService.DesignerOptionConverter>.NativeClassPtr, 100666381);
				DesignerOptionService.DesignerOptionConverter.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DesignerOptionService.DesignerOptionConverter>.NativeClassPtr, 100666382);
			}

			// Token: 0x06002CCF RID: 11471 RVA: 0x000C50B4 File Offset: 0x000C32B4
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 25017, RefRangeEnd = 25031, XrefRangeStart = 25017, XrefRangeEnd = 25031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override bool GetPropertiesSupported(ITypeDescriptorContext cxt)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(cxt);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DesignerOptionService.DesignerOptionConverter.NativeMethodInfoPtr_GetPropertiesSupported_Public_Virtual_Boolean_ITypeDescriptorContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06002CD0 RID: 11472 RVA: 0x000C5104 File Offset: 0x000C3304
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 466112, XrefRangeEnd = 466158, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override PropertyDescriptorCollection GetProperties(ITypeDescriptorContext cxt, Object value, Il2CppReferenceArray<Attribute> attributes)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(cxt);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(attributes);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DesignerOptionService.DesignerOptionConverter.NativeMethodInfoPtr_GetProperties_Public_Virtual_PropertyDescriptorCollection_ITypeDescriptorContext_Object_Il2CppReferenceArray_1_Attribute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PropertyDescriptorCollection>(intPtr3) : null;
			}

			// Token: 0x06002CD1 RID: 11473 RVA: 0x000C5178 File Offset: 0x000C3378
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 466158, XrefRangeEnd = 466170, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override Object ConvertTo(ITypeDescriptorContext cxt, CultureInfo culture, Object value, Type destinationType)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(cxt);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(culture);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(destinationType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DesignerOptionService.DesignerOptionConverter.NativeMethodInfoPtr_ConvertTo_Public_Virtual_Object_ITypeDescriptorContext_CultureInfo_Object_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}

			// Token: 0x06002CD2 RID: 11474 RVA: 0x000C5200 File Offset: 0x000C3400
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe DesignerOptionConverter()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DesignerOptionService.DesignerOptionConverter>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DesignerOptionService.DesignerOptionConverter.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002CD3 RID: 11475 RVA: 0x000142D7 File Offset: 0x000124D7
			public DesignerOptionConverter(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0400234E RID: 9038
			private static readonly IntPtr NativeMethodInfoPtr_GetPropertiesSupported_Public_Virtual_Boolean_ITypeDescriptorContext_0;

			// Token: 0x0400234F RID: 9039
			private static readonly IntPtr NativeMethodInfoPtr_GetProperties_Public_Virtual_PropertyDescriptorCollection_ITypeDescriptorContext_Object_Il2CppReferenceArray_1_Attribute_0;

			// Token: 0x04002350 RID: 9040
			private static readonly IntPtr NativeMethodInfoPtr_ConvertTo_Public_Virtual_Object_ITypeDescriptorContext_CultureInfo_Object_Type_0;

			// Token: 0x04002351 RID: 9041
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x020003BB RID: 955
			public class OptionPropertyDescriptor : PropertyDescriptor
			{
				// Token: 0x0600358D RID: 13709 RVA: 0x000DE504 File Offset: 0x000DC704
				// Note: this type is marked as 'beforefieldinit'.
				static OptionPropertyDescriptor()
				{
					Il2CppClassPointerStore<DesignerOptionService.DesignerOptionConverter.OptionPropertyDescriptor>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DesignerOptionService.DesignerOptionConverter>.NativeClassPtr, "OptionPropertyDescriptor");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DesignerOptionService.DesignerOptionConverter.OptionPropertyDescriptor>.NativeClassPtr);
					DesignerOptionService.DesignerOptionConverter.OptionPropertyDescriptor.NativeFieldInfoPtr__option = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DesignerOptionService.DesignerOptionConverter.OptionPropertyDescriptor>.NativeClassPtr, "_option");
					DesignerOptionService.DesignerOptionConverter.OptionPropertyDescriptor.NativeMethodInfoPtr__ctor_Internal_Void_DesignerOptionCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DesignerOptionService.DesignerOptionConverter.OptionPropertyDescriptor>.NativeClassPtr, 100666383);
					DesignerOptionService.DesignerOptionConverter.OptionPropertyDescriptor.NativeMethodInfoPtr_get_ComponentType_Public_Virtual_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DesignerOptionService.DesignerOptionConverter.OptionPropertyDescriptor>.NativeClassPtr, 100666384);
					DesignerOptionService.DesignerOptionConverter.OptionPropertyDescriptor.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DesignerOptionService.DesignerOptionConverter.OptionPropertyDescriptor>.NativeClassPtr, 100666385);
					DesignerOptionService.DesignerOptionConverter.OptionPropertyDescriptor.NativeMethodInfoPtr_get_PropertyType_Public_Virtual_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DesignerOptionService.DesignerOptionConverter.OptionPropertyDescriptor>.NativeClassPtr, 100666386);
					DesignerOptionService.DesignerOptionConverter.OptionPropertyDescriptor.NativeMethodInfoPtr_CanResetValue_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DesignerOptionService.DesignerOptionConverter.OptionPropertyDescriptor>.NativeClassPtr, 100666387);
					DesignerOptionService.DesignerOptionConverter.OptionPropertyDescriptor.NativeMethodInfoPtr_GetValue_Public_Virtual_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DesignerOptionService.DesignerOptionConverter.OptionPropertyDescriptor>.NativeClassPtr, 100666388);
					DesignerOptionService.DesignerOptionConverter.OptionPropertyDescriptor.NativeMethodInfoPtr_ResetValue_Public_Virtual_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DesignerOptionService.DesignerOptionConverter.OptionPropertyDescriptor>.NativeClassPtr, 100666389);
					DesignerOptionService.DesignerOptionConverter.OptionPropertyDescriptor.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DesignerOptionService.DesignerOptionConverter.OptionPropertyDescriptor>.NativeClassPtr, 100666390);
					DesignerOptionService.DesignerOptionConverter.OptionPropertyDescriptor.NativeMethodInfoPtr_ShouldSerializeValue_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DesignerOptionService.DesignerOptionConverter.OptionPropertyDescriptor>.NativeClassPtr, 100666391);
				}

				// Token: 0x0600358E RID: 13710 RVA: 0x000DE5F8 File Offset: 0x000DC7F8
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 466107, XrefRangeEnd = 466110, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe OptionPropertyDescriptor(DesignerOptionService.DesignerOptionCollection option)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DesignerOptionService.DesignerOptionConverter.OptionPropertyDescriptor>.NativeClassPtr))
				{
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(option);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DesignerOptionService.DesignerOptionConverter.OptionPropertyDescriptor.NativeMethodInfoPtr__ctor_Internal_Void_DesignerOptionCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}

				// Token: 0x170010BC RID: 4284
				// (get) Token: 0x0600358F RID: 13711 RVA: 0x000DE644 File Offset: 0x000DC844
				public unsafe override Type ComponentType
				{
					[CallerCount(0)]
					[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 466110, XrefRangeEnd = 466112, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DesignerOptionService.DesignerOptionConverter.OptionPropertyDescriptor.NativeMethodInfoPtr_get_ComponentType_Public_Virtual_get_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
					}
				}

				// Token: 0x170010BD RID: 4285
				// (get) Token: 0x06003590 RID: 13712 RVA: 0x000DE690 File Offset: 0x000DC890
				public unsafe override bool IsReadOnly
				{
					[CallerCount(14)]
					[CachedScanResults(RefRangeStart = 25017, RefRangeEnd = 25031, XrefRangeStart = 25017, XrefRangeEnd = 25031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DesignerOptionService.DesignerOptionConverter.OptionPropertyDescriptor.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return *IL2CPP.il2cpp_object_unbox(intPtr);
					}
				}

				// Token: 0x170010BE RID: 4286
				// (get) Token: 0x06003591 RID: 13713 RVA: 0x000DE6D8 File Offset: 0x000DC8D8
				public unsafe override Type PropertyType
				{
					[CallerCount(0)]
					[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DesignerOptionService.DesignerOptionConverter.OptionPropertyDescriptor.NativeMethodInfoPtr_get_PropertyType_Public_Virtual_get_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
					}
				}

				// Token: 0x06003592 RID: 13714 RVA: 0x000DE724 File Offset: 0x000DC924
				[CallerCount(184)]
				[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe override bool CanResetValue(Object component)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(component);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DesignerOptionService.DesignerOptionConverter.OptionPropertyDescriptor.NativeMethodInfoPtr_CanResetValue_Public_Virtual_Boolean_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return *IL2CPP.il2cpp_object_unbox(intPtr);
					}
				}

				// Token: 0x06003593 RID: 13715 RVA: 0x000DE77C File Offset: 0x000DC97C
				[CallerCount(0)]
				public unsafe override Object GetValue(Object component)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(component);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DesignerOptionService.DesignerOptionConverter.OptionPropertyDescriptor.NativeMethodInfoPtr_GetValue_Public_Virtual_Object_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
					}
				}

				// Token: 0x06003594 RID: 13716 RVA: 0x000DE7D8 File Offset: 0x000DC9D8
				[CallerCount(21425)]
				[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe override void ResetValue(Object component)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(component);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DesignerOptionService.DesignerOptionConverter.OptionPropertyDescriptor.NativeMethodInfoPtr_ResetValue_Public_Virtual_Void_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}

				// Token: 0x06003595 RID: 13717 RVA: 0x000DE828 File Offset: 0x000DCA28
				[CallerCount(21425)]
				[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe override void SetValue(Object component, Object value)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(component);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DesignerOptionService.DesignerOptionConverter.OptionPropertyDescriptor.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_Object_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06003596 RID: 13718 RVA: 0x000DE888 File Offset: 0x000DCA88
				[CallerCount(184)]
				[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe override bool ShouldSerializeValue(Object component)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(component);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DesignerOptionService.DesignerOptionConverter.OptionPropertyDescriptor.NativeMethodInfoPtr_ShouldSerializeValue_Public_Virtual_Boolean_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return *IL2CPP.il2cpp_object_unbox(intPtr);
					}
				}

				// Token: 0x06003597 RID: 13719 RVA: 0x0001A4A6 File Offset: 0x000186A6
				public OptionPropertyDescriptor(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x170010BB RID: 4283
				// (get) Token: 0x06003598 RID: 13720 RVA: 0x000DE8E0 File Offset: 0x000DCAE0
				// (set) Token: 0x06003599 RID: 13721 RVA: 0x0001A4AF File Offset: 0x000186AF
				public unsafe DesignerOptionService.DesignerOptionCollection _option
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DesignerOptionService.DesignerOptionConverter.OptionPropertyDescriptor.NativeFieldInfoPtr__option);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<DesignerOptionService.DesignerOptionCollection>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DesignerOptionService.DesignerOptionConverter.OptionPropertyDescriptor.NativeFieldInfoPtr__option), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x04002879 RID: 10361
				private static readonly IntPtr NativeFieldInfoPtr__option;

				// Token: 0x0400287A RID: 10362
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_DesignerOptionCollection_0;

				// Token: 0x0400287B RID: 10363
				private static readonly IntPtr NativeMethodInfoPtr_get_ComponentType_Public_Virtual_get_Type_0;

				// Token: 0x0400287C RID: 10364
				private static readonly IntPtr NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0;

				// Token: 0x0400287D RID: 10365
				private static readonly IntPtr NativeMethodInfoPtr_get_PropertyType_Public_Virtual_get_Type_0;

				// Token: 0x0400287E RID: 10366
				private static readonly IntPtr NativeMethodInfoPtr_CanResetValue_Public_Virtual_Boolean_Object_0;

				// Token: 0x0400287F RID: 10367
				private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Virtual_Object_Object_0;

				// Token: 0x04002880 RID: 10368
				private static readonly IntPtr NativeMethodInfoPtr_ResetValue_Public_Virtual_Void_Object_0;

				// Token: 0x04002881 RID: 10369
				private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_Virtual_Void_Object_Object_0;

				// Token: 0x04002882 RID: 10370
				private static readonly IntPtr NativeMethodInfoPtr_ShouldSerializeValue_Public_Virtual_Boolean_Object_0;
			}
		}
	}
}
