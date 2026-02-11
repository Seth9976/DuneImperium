using System;
using Canis.attributes;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Networking.selection.messages.outgoing;
using worm.canis.abilities;

namespace worm.canis.ai.choices
{
	// Token: 0x02000220 RID: 544
	public class WormAIChoiceGameCustomChoice : WormAIChoice
	{
		// Token: 0x060017E8 RID: 6120 RVA: 0x000B5A64 File Offset: 0x000B3C64
		// Note: this type is marked as 'beforefieldinit'.
		static WormAIChoiceGameCustomChoice()
		{
			Il2CppClassPointerStore<WormAIChoiceGameCustomChoice>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.ai.choices", "WormAIChoiceGameCustomChoice");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormAIChoiceGameCustomChoice>.NativeClassPtr);
			WormAIChoiceGameCustomChoice.NativeFieldInfoPtr_response = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAIChoiceGameCustomChoice>.NativeClassPtr, "response");
			WormAIChoiceGameCustomChoice.NativeFieldInfoPtr_selection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAIChoiceGameCustomChoice>.NativeClassPtr, "selection");
			WormAIChoiceGameCustomChoice.NativeMethodInfoPtr__ctor_Public_Void_WormAIChoiceContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAIChoiceGameCustomChoice>.NativeClassPtr, 100667334);
			WormAIChoiceGameCustomChoice.NativeMethodInfoPtr__ctor_Public_Void_WormAbilityDefinition_WormAIChoiceContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAIChoiceGameCustomChoice>.NativeClassPtr, 100667335);
			WormAIChoiceGameCustomChoice.NativeMethodInfoPtr_GetEnabledOptions_Public_IEnumerable_1_ValueTuple_2_SerializableAttributes_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAIChoiceGameCustomChoice>.NativeClassPtr, 100667336);
			WormAIChoiceGameCustomChoice.NativeMethodInfoPtr_UpdateResponses_Public_Void_Double_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAIChoiceGameCustomChoice>.NativeClassPtr, 100667337);
			WormAIChoiceGameCustomChoice.NativeMethodInfoPtr_GetResponse_Public_Virtual_ISelectionCounter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAIChoiceGameCustomChoice>.NativeClassPtr, 100667338);
		}

		// Token: 0x060017E9 RID: 6121 RVA: 0x000B5B20 File Offset: 0x000B3D20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129632, XrefRangeEnd = 129641, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormAIChoiceGameCustomChoice(WormAIChoiceContext context)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormAIChoiceGameCustomChoice>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAIChoiceGameCustomChoice.NativeMethodInfoPtr__ctor_Public_Void_WormAIChoiceContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060017EA RID: 6122 RVA: 0x000B5B6C File Offset: 0x000B3D6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129641, XrefRangeEnd = 129650, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormAIChoiceGameCustomChoice(WormAbilityDefinition ability, WormAIChoiceContext context)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormAIChoiceGameCustomChoice>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ability);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(context);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAIChoiceGameCustomChoice.NativeMethodInfoPtr__ctor_Public_Void_WormAbilityDefinition_WormAIChoiceContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060017EB RID: 6123 RVA: 0x000B5BCC File Offset: 0x000B3DCC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 129656, RefRangeEnd = 129657, XrefRangeStart = 129650, XrefRangeEnd = 129656, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<ValueTuple<SerializableAttributes, int>> GetEnabledOptions()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAIChoiceGameCustomChoice.NativeMethodInfoPtr_GetEnabledOptions_Public_IEnumerable_1_ValueTuple_2_SerializableAttributes_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<ValueTuple<SerializableAttributes, int>>>(intPtr3) : null;
		}

		// Token: 0x060017EC RID: 6124 RVA: 0x000B5C0C File Offset: 0x000B3E0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129657, XrefRangeEnd = 129658, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateResponses(double value, int choice)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref choice;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAIChoiceGameCustomChoice.NativeMethodInfoPtr_UpdateResponses_Public_Void_Double_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060017ED RID: 6125 RVA: 0x000B5C58 File Offset: 0x000B3E58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129658, XrefRangeEnd = 129659, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override ISelectionCounter GetResponse()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormAIChoiceGameCustomChoice.NativeMethodInfoPtr_GetResponse_Public_Virtual_ISelectionCounter_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ISelectionCounter>(intPtr3) : null;
		}

		// Token: 0x060017EE RID: 6126 RVA: 0x0000A692 File Offset: 0x00008892
		public WormAIChoiceGameCustomChoice(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170008A1 RID: 2209
		// (get) Token: 0x060017EF RID: 6127 RVA: 0x000B5CA4 File Offset: 0x000B3EA4
		// (set) Token: 0x060017F0 RID: 6128 RVA: 0x0000A69B File Offset: 0x0000889B
		public unsafe int response
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAIChoiceGameCustomChoice.NativeFieldInfoPtr_response);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAIChoiceGameCustomChoice.NativeFieldInfoPtr_response)) = value;
			}
		}

		// Token: 0x170008A2 RID: 2210
		// (get) Token: 0x060017F1 RID: 6129 RVA: 0x000B5CCC File Offset: 0x000B3ECC
		// (set) Token: 0x060017F2 RID: 6130 RVA: 0x0000A6B6 File Offset: 0x000088B6
		public unsafe ArchetypeCustomChoiceRequired selection
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAIChoiceGameCustomChoice.NativeFieldInfoPtr_selection);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeCustomChoiceRequired>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAIChoiceGameCustomChoice.NativeFieldInfoPtr_selection), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000EC1 RID: 3777
		private static readonly IntPtr NativeFieldInfoPtr_response;

		// Token: 0x04000EC2 RID: 3778
		private static readonly IntPtr NativeFieldInfoPtr_selection;

		// Token: 0x04000EC3 RID: 3779
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_WormAIChoiceContext_0;

		// Token: 0x04000EC4 RID: 3780
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_WormAbilityDefinition_WormAIChoiceContext_0;

		// Token: 0x04000EC5 RID: 3781
		private static readonly IntPtr NativeMethodInfoPtr_GetEnabledOptions_Public_IEnumerable_1_ValueTuple_2_SerializableAttributes_Int32_0;

		// Token: 0x04000EC6 RID: 3782
		private static readonly IntPtr NativeMethodInfoPtr_UpdateResponses_Public_Void_Double_Int32_0;

		// Token: 0x04000EC7 RID: 3783
		private static readonly IntPtr NativeMethodInfoPtr_GetResponse_Public_Virtual_ISelectionCounter_0;

		// Token: 0x0200064C RID: 1612
		[ObfuscatedName("worm.canis.ai.choices.WormAIChoiceGameCustomChoice+<GetEnabledOptions>d__4")]
		public sealed class _GetEnabledOptions_d__4 : Object
		{
			// Token: 0x060051D6 RID: 20950 RVA: 0x001AEA3C File Offset: 0x001ACC3C
			// Note: this type is marked as 'beforefieldinit'.
			static _GetEnabledOptions_d__4()
			{
				Il2CppClassPointerStore<WormAIChoiceGameCustomChoice._GetEnabledOptions_d__4>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormAIChoiceGameCustomChoice>.NativeClassPtr, "<GetEnabledOptions>d__4");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormAIChoiceGameCustomChoice._GetEnabledOptions_d__4>.NativeClassPtr);
				WormAIChoiceGameCustomChoice._GetEnabledOptions_d__4.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAIChoiceGameCustomChoice._GetEnabledOptions_d__4>.NativeClassPtr, "<>1__state");
				WormAIChoiceGameCustomChoice._GetEnabledOptions_d__4.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAIChoiceGameCustomChoice._GetEnabledOptions_d__4>.NativeClassPtr, "<>2__current");
				WormAIChoiceGameCustomChoice._GetEnabledOptions_d__4.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAIChoiceGameCustomChoice._GetEnabledOptions_d__4>.NativeClassPtr, "<>l__initialThreadId");
				WormAIChoiceGameCustomChoice._GetEnabledOptions_d__4.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAIChoiceGameCustomChoice._GetEnabledOptions_d__4>.NativeClassPtr, "<>4__this");
				WormAIChoiceGameCustomChoice._GetEnabledOptions_d__4.NativeFieldInfoPtr__i_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAIChoiceGameCustomChoice._GetEnabledOptions_d__4>.NativeClassPtr, "<i>5__2");
				WormAIChoiceGameCustomChoice._GetEnabledOptions_d__4.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAIChoiceGameCustomChoice._GetEnabledOptions_d__4>.NativeClassPtr, 100667339);
				WormAIChoiceGameCustomChoice._GetEnabledOptions_d__4.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAIChoiceGameCustomChoice._GetEnabledOptions_d__4>.NativeClassPtr, 100667340);
				WormAIChoiceGameCustomChoice._GetEnabledOptions_d__4.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAIChoiceGameCustomChoice._GetEnabledOptions_d__4>.NativeClassPtr, 100667341);
				WormAIChoiceGameCustomChoice._GetEnabledOptions_d__4.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_ValueTuple_2_SerializableAttributes_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAIChoiceGameCustomChoice._GetEnabledOptions_d__4>.NativeClassPtr, 100667342);
				WormAIChoiceGameCustomChoice._GetEnabledOptions_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAIChoiceGameCustomChoice._GetEnabledOptions_d__4>.NativeClassPtr, 100667343);
				WormAIChoiceGameCustomChoice._GetEnabledOptions_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAIChoiceGameCustomChoice._GetEnabledOptions_d__4>.NativeClassPtr, 100667344);
				WormAIChoiceGameCustomChoice._GetEnabledOptions_d__4.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_IEnumerator_1_ValueTuple_2_SerializableAttributes_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAIChoiceGameCustomChoice._GetEnabledOptions_d__4>.NativeClassPtr, 100667345);
				WormAIChoiceGameCustomChoice._GetEnabledOptions_d__4.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAIChoiceGameCustomChoice._GetEnabledOptions_d__4>.NativeClassPtr, 100667346);
			}

			// Token: 0x060051D7 RID: 20951 RVA: 0x001AEB6C File Offset: 0x001ACD6C
			[CallerCount(21)]
			[CachedScanResults(RefRangeStart = 26131, RefRangeEnd = 26152, XrefRangeStart = 26131, XrefRangeEnd = 26152, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _GetEnabledOptions_d__4(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormAIChoiceGameCustomChoice._GetEnabledOptions_d__4>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAIChoiceGameCustomChoice._GetEnabledOptions_d__4.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060051D8 RID: 20952 RVA: 0x001AEBB4 File Offset: 0x001ACDB4
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAIChoiceGameCustomChoice._GetEnabledOptions_d__4.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060051D9 RID: 20953 RVA: 0x001AEBE8 File Offset: 0x001ACDE8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129595, XrefRangeEnd = 129622, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAIChoiceGameCustomChoice._GetEnabledOptions_d__4.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x1700143A RID: 5178
			// (get) Token: 0x060051DA RID: 20954 RVA: 0x001AEC24 File Offset: 0x001ACE24
			public unsafe ValueTuple<SerializableAttributes, int> prop_ValueTuple_2_SerializableAttributes_Int32_0
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAIChoiceGameCustomChoice._GetEnabledOptions_d__4.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_ValueTuple_2_SerializableAttributes_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return new ValueTuple<SerializableAttributes, int>(intPtr);
				}
			}

			// Token: 0x060051DB RID: 20955 RVA: 0x001AEC5C File Offset: 0x001ACE5C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129622, XrefRangeEnd = 129627, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAIChoiceGameCustomChoice._GetEnabledOptions_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700143B RID: 5179
			// (get) Token: 0x060051DC RID: 20956 RVA: 0x001AEC90 File Offset: 0x001ACE90
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129627, XrefRangeEnd = 129630, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAIChoiceGameCustomChoice._GetEnabledOptions_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060051DD RID: 20957 RVA: 0x001AECD0 File Offset: 0x001ACED0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129630, XrefRangeEnd = 129632, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<ValueTuple<SerializableAttributes, int>> Method_Private_Virtual_Final_New_IEnumerator_1_ValueTuple_2_SerializableAttributes_Int32_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAIChoiceGameCustomChoice._GetEnabledOptions_d__4.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_IEnumerator_1_ValueTuple_2_SerializableAttributes_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<ValueTuple<SerializableAttributes, int>>>(intPtr3) : null;
			}

			// Token: 0x060051DE RID: 20958 RVA: 0x001AED10 File Offset: 0x001ACF10
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAIChoiceGameCustomChoice._GetEnabledOptions_d__4.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x060051DF RID: 20959 RVA: 0x0001C6DA File Offset: 0x0001A8DA
			public _GetEnabledOptions_d__4(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001435 RID: 5173
			// (get) Token: 0x060051E0 RID: 20960 RVA: 0x001AED50 File Offset: 0x001ACF50
			// (set) Token: 0x060051E1 RID: 20961 RVA: 0x0001C6E3 File Offset: 0x0001A8E3
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAIChoiceGameCustomChoice._GetEnabledOptions_d__4.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAIChoiceGameCustomChoice._GetEnabledOptions_d__4.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001436 RID: 5174
			// (get) Token: 0x060051E2 RID: 20962 RVA: 0x001AED78 File Offset: 0x001ACF78
			// (set) Token: 0x060051E3 RID: 20963 RVA: 0x0001C6FE File Offset: 0x0001A8FE
			public ValueTuple<SerializableAttributes, int> __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAIChoiceGameCustomChoice._GetEnabledOptions_d__4.NativeFieldInfoPtr___2__current);
					return new ValueTuple<SerializableAttributes, int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ValueTuple<SerializableAttributes, int>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAIChoiceGameCustomChoice._GetEnabledOptions_d__4.NativeFieldInfoPtr___2__current), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ValueTuple<SerializableAttributes, int>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17001437 RID: 5175
			// (get) Token: 0x060051E4 RID: 20964 RVA: 0x001AEDA8 File Offset: 0x001ACFA8
			// (set) Token: 0x060051E5 RID: 20965 RVA: 0x0001C72C File Offset: 0x0001A92C
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAIChoiceGameCustomChoice._GetEnabledOptions_d__4.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAIChoiceGameCustomChoice._GetEnabledOptions_d__4.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17001438 RID: 5176
			// (get) Token: 0x060051E6 RID: 20966 RVA: 0x001AEDD0 File Offset: 0x001ACFD0
			// (set) Token: 0x060051E7 RID: 20967 RVA: 0x0001C747 File Offset: 0x0001A947
			public unsafe WormAIChoiceGameCustomChoice __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAIChoiceGameCustomChoice._GetEnabledOptions_d__4.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormAIChoiceGameCustomChoice>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAIChoiceGameCustomChoice._GetEnabledOptions_d__4.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001439 RID: 5177
			// (get) Token: 0x060051E8 RID: 20968 RVA: 0x001AEE00 File Offset: 0x001AD000
			// (set) Token: 0x060051E9 RID: 20969 RVA: 0x0001C766 File Offset: 0x0001A966
			public unsafe int _i_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAIChoiceGameCustomChoice._GetEnabledOptions_d__4.NativeFieldInfoPtr__i_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAIChoiceGameCustomChoice._GetEnabledOptions_d__4.NativeFieldInfoPtr__i_5__2)) = value;
				}
			}

			// Token: 0x040035A2 RID: 13730
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040035A3 RID: 13731
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040035A4 RID: 13732
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x040035A5 RID: 13733
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040035A6 RID: 13734
			private static readonly IntPtr NativeFieldInfoPtr__i_5__2;

			// Token: 0x040035A7 RID: 13735
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040035A8 RID: 13736
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040035A9 RID: 13737
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040035AA RID: 13738
			private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_ValueTuple_2_SerializableAttributes_Int32_0;

			// Token: 0x040035AB RID: 13739
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040035AC RID: 13740
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040035AD RID: 13741
			private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Virtual_Final_New_IEnumerator_1_ValueTuple_2_SerializableAttributes_Int32_0;

			// Token: 0x040035AE RID: 13742
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}
	}
}
