using System;
using Canis.utils.ids;
using dwd.core.archetypes;
using dwd.core.data.composition;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;

namespace game.src.cheats
{
	// Token: 0x02000032 RID: 50
	public class CheatArchetypeTranslator : Object
	{
		// Token: 0x06000218 RID: 536 RVA: 0x00017890 File Offset: 0x00015A90
		// Note: this type is marked as 'beforefieldinit'.
		static CheatArchetypeTranslator()
		{
			Il2CppClassPointerStore<CheatArchetypeTranslator>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "game.src.cheats", "CheatArchetypeTranslator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CheatArchetypeTranslator>.NativeClassPtr);
			CheatArchetypeTranslator.NativeFieldInfoPtr_source = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CheatArchetypeTranslator>.NativeClassPtr, "source");
			CheatArchetypeTranslator.NativeMethodInfoPtr__ctor_Public_Void_IDictionary_2_ArchetypeID_ArchetypeComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheatArchetypeTranslator>.NativeClassPtr, 100663689);
			CheatArchetypeTranslator.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_Void_ArchetypeID_DataComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheatArchetypeTranslator>.NativeClassPtr, 100663690);
			CheatArchetypeTranslator.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_Boolean_ArchetypeID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheatArchetypeTranslator>.NativeClassPtr, 100663691);
			CheatArchetypeTranslator.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_ICollection_1_ArchetypeID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheatArchetypeTranslator>.NativeClassPtr, 100663692);
			CheatArchetypeTranslator.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_Boolean_ArchetypeID_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheatArchetypeTranslator>.NativeClassPtr, 100663693);
			CheatArchetypeTranslator.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_Boolean_ArchetypeID_byref_DataComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheatArchetypeTranslator>.NativeClassPtr, 100663694);
			CheatArchetypeTranslator.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_ICollection_1_DataComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheatArchetypeTranslator>.NativeClassPtr, 100663695);
			CheatArchetypeTranslator.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_DataComponent_ArchetypeID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheatArchetypeTranslator>.NativeClassPtr, 100663696);
			CheatArchetypeTranslator.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_set_Void_ArchetypeID_DataComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheatArchetypeTranslator>.NativeClassPtr, 100663697);
			CheatArchetypeTranslator.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_Void_KeyValuePair_2_ArchetypeID_DataComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheatArchetypeTranslator>.NativeClassPtr, 100663698);
			CheatArchetypeTranslator.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheatArchetypeTranslator>.NativeClassPtr, 100663699);
			CheatArchetypeTranslator.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_Boolean_KeyValuePair_2_ArchetypeID_DataComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheatArchetypeTranslator>.NativeClassPtr, 100663700);
			CheatArchetypeTranslator.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_Void_Il2CppReferenceArray_1_KeyValuePair_2_ArchetypeID_DataComponent_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheatArchetypeTranslator>.NativeClassPtr, 100663701);
			CheatArchetypeTranslator.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheatArchetypeTranslator>.NativeClassPtr, 100663702);
			CheatArchetypeTranslator.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheatArchetypeTranslator>.NativeClassPtr, 100663703);
			CheatArchetypeTranslator.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_Boolean_KeyValuePair_2_ArchetypeID_DataComponent_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheatArchetypeTranslator>.NativeClassPtr, 100663704);
			CheatArchetypeTranslator.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_IEnumerator_1_KeyValuePair_2_ArchetypeID_DataComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheatArchetypeTranslator>.NativeClassPtr, 100663705);
			CheatArchetypeTranslator.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheatArchetypeTranslator>.NativeClassPtr, 100663706);
		}

		// Token: 0x06000219 RID: 537 RVA: 0x00017A3C File Offset: 0x00015C3C
		[CallerCount(148)]
		[CachedScanResults(RefRangeStart = 286435, RefRangeEnd = 286583, XrefRangeStart = 286435, XrefRangeEnd = 286583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CheatArchetypeTranslator(IDictionary<ArchetypeID, ArchetypeComponent> source)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CheatArchetypeTranslator>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CheatArchetypeTranslator.NativeMethodInfoPtr__ctor_Public_Void_IDictionary_2_ArchetypeID_ArchetypeComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600021A RID: 538 RVA: 0x00017A88 File Offset: 0x00015C88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 984672, XrefRangeEnd = 984677, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Method_Private_Virtual_Final_New_Void_ArchetypeID_DataComponent_0(ArchetypeID key, DataComponent value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CheatArchetypeTranslator.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_Void_ArchetypeID_DataComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600021B RID: 539 RVA: 0x00017ADC File Offset: 0x00015CDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 984677, XrefRangeEnd = 984681, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool Method_Private_Virtual_Final_New_Boolean_ArchetypeID_0(ArchetypeID key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CheatArchetypeTranslator.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_Boolean_ArchetypeID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000083 RID: 131
		// (get) Token: 0x0600021C RID: 540 RVA: 0x00017B2C File Offset: 0x00015D2C
		public unsafe virtual ICollection<ArchetypeID> prop_ICollection_1_ArchetypeID_0
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 984681, XrefRangeEnd = 984685, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CheatArchetypeTranslator.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_ICollection_1_ArchetypeID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ICollection<ArchetypeID>>(intPtr3) : null;
			}
		}

		// Token: 0x0600021D RID: 541 RVA: 0x00017B6C File Offset: 0x00015D6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 984685, XrefRangeEnd = 984689, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool Method_Private_Virtual_Final_New_Boolean_ArchetypeID_1(ArchetypeID key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CheatArchetypeTranslator.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_Boolean_ArchetypeID_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600021E RID: 542 RVA: 0x00017BBC File Offset: 0x00015DBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 984689, XrefRangeEnd = 984693, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool Method_Private_Virtual_Final_New_Boolean_ArchetypeID_byref_DataComponent_0(ArchetypeID key, out DataComponent value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(CheatArchetypeTranslator.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_Boolean_ArchetypeID_byref_DataComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			value = ((intPtr4 == 0) ? null : new DataComponent(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x17000084 RID: 132
		// (get) Token: 0x0600021F RID: 543 RVA: 0x00017C2C File Offset: 0x00015E2C
		public unsafe virtual ICollection<DataComponent> prop_ICollection_1_DataComponent_0
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 984693, XrefRangeEnd = 984698, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CheatArchetypeTranslator.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_ICollection_1_DataComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ICollection<DataComponent>>(intPtr3) : null;
			}
		}

		// Token: 0x17000085 RID: 133
		// (get) Token: 0x06000220 RID: 544 RVA: 0x00017C6C File Offset: 0x00015E6C
		// (set) Token: 0x06000221 RID: 545 RVA: 0x00017CBC File Offset: 0x00015EBC
		public unsafe virtual DataComponent prop_DataComponent_0
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 984698, XrefRangeEnd = 984703, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CheatArchetypeTranslator.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_DataComponent_ArchetypeID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<DataComponent>(intPtr3) : null;
				}
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 984703, XrefRangeEnd = 984708, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CheatArchetypeTranslator.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_set_Void_ArchetypeID_DataComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000222 RID: 546 RVA: 0x00017D10 File Offset: 0x00015F10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 984708, XrefRangeEnd = 984713, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Method_Private_Virtual_Final_New_Void_KeyValuePair_2_ArchetypeID_DataComponent_0(KeyValuePair<ArchetypeID, DataComponent> item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(item));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CheatArchetypeTranslator.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_Void_KeyValuePair_2_ArchetypeID_DataComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000223 RID: 547 RVA: 0x00017D58 File Offset: 0x00015F58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 984713, XrefRangeEnd = 984717, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Method_Private_Virtual_Final_New_Void_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CheatArchetypeTranslator.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000224 RID: 548 RVA: 0x00017D8C File Offset: 0x00015F8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 984717, XrefRangeEnd = 984722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool Method_Private_Virtual_Final_New_Boolean_KeyValuePair_2_ArchetypeID_DataComponent_0(KeyValuePair<ArchetypeID, DataComponent> item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(item));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CheatArchetypeTranslator.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_Boolean_KeyValuePair_2_ArchetypeID_DataComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000225 RID: 549 RVA: 0x00017DE0 File Offset: 0x00015FE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 984722, XrefRangeEnd = 984727, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Method_Private_Virtual_Final_New_Void_Il2CppReferenceArray_1_KeyValuePair_2_ArchetypeID_DataComponent_Int32_0(Il2CppReferenceArray<KeyValuePair<ArchetypeID, DataComponent>> array, int arrayIndex)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CheatArchetypeTranslator.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_Void_Il2CppReferenceArray_1_KeyValuePair_2_ArchetypeID_DataComponent_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000086 RID: 134
		// (get) Token: 0x06000226 RID: 550 RVA: 0x00017E30 File Offset: 0x00016030
		public unsafe virtual int prop_Int32_0
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 984727, XrefRangeEnd = 984731, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CheatArchetypeTranslator.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000087 RID: 135
		// (get) Token: 0x06000227 RID: 551 RVA: 0x00017E6C File Offset: 0x0001606C
		public unsafe virtual bool prop_Boolean_0
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 984731, XrefRangeEnd = 984735, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CheatArchetypeTranslator.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000228 RID: 552 RVA: 0x00017EA8 File Offset: 0x000160A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 984735, XrefRangeEnd = 984740, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool Method_Private_Virtual_Final_New_Boolean_KeyValuePair_2_ArchetypeID_DataComponent_1(KeyValuePair<ArchetypeID, DataComponent> item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(item));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CheatArchetypeTranslator.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_Boolean_KeyValuePair_2_ArchetypeID_DataComponent_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000229 RID: 553 RVA: 0x00017EFC File Offset: 0x000160FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 984740, XrefRangeEnd = 984748, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerator<KeyValuePair<ArchetypeID, DataComponent>> Method_Private_Virtual_Final_New_IEnumerator_1_KeyValuePair_2_ArchetypeID_DataComponent_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CheatArchetypeTranslator.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_IEnumerator_1_KeyValuePair_2_ArchetypeID_DataComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<KeyValuePair<ArchetypeID, DataComponent>>>(intPtr3) : null;
		}

		// Token: 0x0600022A RID: 554 RVA: 0x00017F3C File Offset: 0x0001613C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 984748, XrefRangeEnd = 984752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerator System_Collections_IEnumerable_GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CheatArchetypeTranslator.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600022B RID: 555 RVA: 0x00002EF3 File Offset: 0x000010F3
		public CheatArchetypeTranslator(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000082 RID: 130
		// (get) Token: 0x0600022C RID: 556 RVA: 0x00017F7C File Offset: 0x0001617C
		// (set) Token: 0x0600022D RID: 557 RVA: 0x00002EFC File Offset: 0x000010FC
		public unsafe IDictionary<ArchetypeID, ArchetypeComponent> source
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CheatArchetypeTranslator.NativeFieldInfoPtr_source);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IDictionary<ArchetypeID, ArchetypeComponent>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CheatArchetypeTranslator.NativeFieldInfoPtr_source), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400015D RID: 349
		private static readonly IntPtr NativeFieldInfoPtr_source;

		// Token: 0x0400015E RID: 350
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IDictionary_2_ArchetypeID_ArchetypeComponent_0;

		// Token: 0x0400015F RID: 351
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Virtual_Final_New_Void_ArchetypeID_DataComponent_0;

		// Token: 0x04000160 RID: 352
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Virtual_Final_New_Boolean_ArchetypeID_0;

		// Token: 0x04000161 RID: 353
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_ICollection_1_ArchetypeID_0;

		// Token: 0x04000162 RID: 354
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Virtual_Final_New_Boolean_ArchetypeID_1;

		// Token: 0x04000163 RID: 355
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Virtual_Final_New_Boolean_ArchetypeID_byref_DataComponent_0;

		// Token: 0x04000164 RID: 356
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_ICollection_1_DataComponent_0;

		// Token: 0x04000165 RID: 357
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_DataComponent_ArchetypeID_0;

		// Token: 0x04000166 RID: 358
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Virtual_Final_New_set_Void_ArchetypeID_DataComponent_0;

		// Token: 0x04000167 RID: 359
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Virtual_Final_New_Void_KeyValuePair_2_ArchetypeID_DataComponent_0;

		// Token: 0x04000168 RID: 360
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Virtual_Final_New_Void_0;

		// Token: 0x04000169 RID: 361
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Virtual_Final_New_Boolean_KeyValuePair_2_ArchetypeID_DataComponent_0;

		// Token: 0x0400016A RID: 362
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Virtual_Final_New_Void_Il2CppReferenceArray_1_KeyValuePair_2_ArchetypeID_DataComponent_Int32_0;

		// Token: 0x0400016B RID: 363
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_Int32_0;

		// Token: 0x0400016C RID: 364
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_Boolean_0;

		// Token: 0x0400016D RID: 365
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Virtual_Final_New_Boolean_KeyValuePair_2_ArchetypeID_DataComponent_1;

		// Token: 0x0400016E RID: 366
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Virtual_Final_New_IEnumerator_1_KeyValuePair_2_ArchetypeID_DataComponent_0;

		// Token: 0x0400016F RID: 367
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;

		// Token: 0x020001B3 RID: 435
		public class Enumerator : Object
		{
			// Token: 0x060014F3 RID: 5363 RVA: 0x00051938 File Offset: 0x0004FB38
			// Note: this type is marked as 'beforefieldinit'.
			static Enumerator()
			{
				Il2CppClassPointerStore<CheatArchetypeTranslator.Enumerator>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CheatArchetypeTranslator>.NativeClassPtr, "Enumerator");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CheatArchetypeTranslator.Enumerator>.NativeClassPtr);
				CheatArchetypeTranslator.Enumerator.NativeFieldInfoPtr_source = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CheatArchetypeTranslator.Enumerator>.NativeClassPtr, "source");
				CheatArchetypeTranslator.Enumerator.NativeMethodInfoPtr__ctor_Public_Void_IEnumerator_1_KeyValuePair_2_ArchetypeID_ArchetypeComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheatArchetypeTranslator.Enumerator>.NativeClassPtr, 100663707);
				CheatArchetypeTranslator.Enumerator.NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_KeyValuePair_2_ArchetypeID_DataComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheatArchetypeTranslator.Enumerator>.NativeClassPtr, 100663708);
				CheatArchetypeTranslator.Enumerator.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheatArchetypeTranslator.Enumerator>.NativeClassPtr, 100663709);
				CheatArchetypeTranslator.Enumerator.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheatArchetypeTranslator.Enumerator>.NativeClassPtr, 100663710);
				CheatArchetypeTranslator.Enumerator.NativeMethodInfoPtr_System_Collections_IEnumerator_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheatArchetypeTranslator.Enumerator>.NativeClassPtr, 100663711);
				CheatArchetypeTranslator.Enumerator.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheatArchetypeTranslator.Enumerator>.NativeClassPtr, 100663712);
			}

			// Token: 0x060014F4 RID: 5364 RVA: 0x000519F0 File Offset: 0x0004FBF0
			[CallerCount(148)]
			[CachedScanResults(RefRangeStart = 286435, RefRangeEnd = 286583, XrefRangeStart = 286435, XrefRangeEnd = 286583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Enumerator(IEnumerator<KeyValuePair<ArchetypeID, ArchetypeComponent>> source)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CheatArchetypeTranslator.Enumerator>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CheatArchetypeTranslator.Enumerator.NativeMethodInfoPtr__ctor_Public_Void_IEnumerator_1_KeyValuePair_2_ArchetypeID_ArchetypeComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x170005F7 RID: 1527
			// (get) Token: 0x060014F5 RID: 5365 RVA: 0x00051A3C File Offset: 0x0004FC3C
			public unsafe virtual KeyValuePair<ArchetypeID, DataComponent> Current
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 984641, XrefRangeEnd = 984649, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CheatArchetypeTranslator.Enumerator.NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_KeyValuePair_2_ArchetypeID_DataComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return new KeyValuePair<ArchetypeID, DataComponent>(intPtr);
				}
			}

			// Token: 0x060014F6 RID: 5366 RVA: 0x00051A74 File Offset: 0x0004FC74
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 984649, XrefRangeEnd = 984653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CheatArchetypeTranslator.Enumerator.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170005F8 RID: 1528
			// (get) Token: 0x060014F7 RID: 5367 RVA: 0x00051AA8 File Offset: 0x0004FCA8
			public unsafe virtual Object System.Collections.IEnumerator.Current
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 984653, XrefRangeEnd = 984664, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CheatArchetypeTranslator.Enumerator.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060014F8 RID: 5368 RVA: 0x00051AE8 File Offset: 0x0004FCE8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 984664, XrefRangeEnd = 984668, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual bool System_Collections_IEnumerator_MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CheatArchetypeTranslator.Enumerator.NativeMethodInfoPtr_System_Collections_IEnumerator_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060014F9 RID: 5369 RVA: 0x00051B24 File Offset: 0x0004FD24
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 984668, XrefRangeEnd = 984672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CheatArchetypeTranslator.Enumerator.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060014FA RID: 5370 RVA: 0x0000BD26 File Offset: 0x00009F26
			public Enumerator(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170005F6 RID: 1526
			// (get) Token: 0x060014FB RID: 5371 RVA: 0x00051B58 File Offset: 0x0004FD58
			// (set) Token: 0x060014FC RID: 5372 RVA: 0x0000BD2F File Offset: 0x00009F2F
			public unsafe IEnumerator<KeyValuePair<ArchetypeID, ArchetypeComponent>> source
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CheatArchetypeTranslator.Enumerator.NativeFieldInfoPtr_source);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<KeyValuePair<ArchetypeID, ArchetypeComponent>>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CheatArchetypeTranslator.Enumerator.NativeFieldInfoPtr_source), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000CAF RID: 3247
			private static readonly IntPtr NativeFieldInfoPtr_source;

			// Token: 0x04000CB0 RID: 3248
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IEnumerator_1_KeyValuePair_2_ArchetypeID_ArchetypeComponent_0;

			// Token: 0x04000CB1 RID: 3249
			private static readonly IntPtr NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_KeyValuePair_2_ArchetypeID_DataComponent_0;

			// Token: 0x04000CB2 RID: 3250
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000CB3 RID: 3251
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04000CB4 RID: 3252
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04000CB5 RID: 3253
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;
		}
	}
}
