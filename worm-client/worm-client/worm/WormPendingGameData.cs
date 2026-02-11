using System;
using boardgames.data;
using Canis.messages;
using Canis.utils.ids;
using dwd.core.data.composition;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Networking.game;
using worm.canis.match;

namespace worm
{
	// Token: 0x02000050 RID: 80
	public class WormPendingGameData : PendingGameData<WormMatchInitData>
	{
		// Token: 0x0600034C RID: 844 RVA: 0x0002308C File Offset: 0x0002128C
		// Note: this type is marked as 'beforefieldinit'.
		static WormPendingGameData()
		{
			Il2CppClassPointerStore<WormPendingGameData>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm", "WormPendingGameData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormPendingGameData>.NativeClassPtr);
			WormPendingGameData.NativeMethodInfoPtr__ctor_Public_Void_DWDPendingGameMetadata_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPendingGameData>.NativeClassPtr, 100663820);
			WormPendingGameData.NativeMethodInfoPtr_additionalComponentsForPlayerComposition_Protected_Virtual_IEnumerable_1_DataComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPendingGameData>.NativeClassPtr, 100663821);
			WormPendingGameData.NativeMethodInfoPtr_updateWith_Protected_Virtual_Void_DWDPendingGameMetadata_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPendingGameData>.NativeClassPtr, 100663822);
			WormPendingGameData.NativeMethodInfoPtr_updatePlayerMetadata_Protected_Virtual_Void_AccountID_Dictionary_2_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPendingGameData>.NativeClassPtr, 100663823);
			WormPendingGameData.NativeMethodInfoPtr_updatePlayerMetadataComposition_Private_Void_DataComposition_Dictionary_2_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPendingGameData>.NativeClassPtr, 100663824);
		}

		// Token: 0x0600034D RID: 845 RVA: 0x00023120 File Offset: 0x00021320
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 691474, XrefRangeEnd = 691477, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormPendingGameData(DWDPendingGameMetadata gameMetadata)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormPendingGameData>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameMetadata);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPendingGameData.NativeMethodInfoPtr__ctor_Public_Void_DWDPendingGameMetadata_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600034E RID: 846 RVA: 0x0002316C File Offset: 0x0002136C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 691477, XrefRangeEnd = 691482, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerable<DataComponent> additionalComponentsForPlayerComposition()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormPendingGameData.NativeMethodInfoPtr_additionalComponentsForPlayerComposition_Protected_Virtual_IEnumerable_1_DataComponent_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<DataComponent>>(intPtr3) : null;
		}

		// Token: 0x0600034F RID: 847 RVA: 0x000231B8 File Offset: 0x000213B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 691482, XrefRangeEnd = 691533, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void updateWith(DWDPendingGameMetadata gameMetadata)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameMetadata);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormPendingGameData.NativeMethodInfoPtr_updateWith_Protected_Virtual_Void_DWDPendingGameMetadata_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000350 RID: 848 RVA: 0x00023208 File Offset: 0x00021408
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 691533, XrefRangeEnd = 691548, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void updatePlayerMetadata(AccountID accountID, Dictionary<string, string> metadata)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(accountID);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(metadata);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormPendingGameData.NativeMethodInfoPtr_updatePlayerMetadata_Protected_Virtual_Void_AccountID_Dictionary_2_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000351 RID: 849 RVA: 0x00023268 File Offset: 0x00021468
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 691572, RefRangeEnd = 691574, XrefRangeStart = 691548, XrefRangeEnd = 691572, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void updatePlayerMetadataComposition(DataComposition playerDataComposition, Dictionary<string, string> metadata)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(playerDataComposition);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(metadata);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPendingGameData.NativeMethodInfoPtr_updatePlayerMetadataComposition_Private_Void_DataComposition_Dictionary_2_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000352 RID: 850 RVA: 0x0000383D File Offset: 0x00001A3D
		public WormPendingGameData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040001F8 RID: 504
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_DWDPendingGameMetadata_0;

		// Token: 0x040001F9 RID: 505
		private static readonly IntPtr NativeMethodInfoPtr_additionalComponentsForPlayerComposition_Protected_Virtual_IEnumerable_1_DataComponent_0;

		// Token: 0x040001FA RID: 506
		private static readonly IntPtr NativeMethodInfoPtr_updateWith_Protected_Virtual_Void_DWDPendingGameMetadata_0;

		// Token: 0x040001FB RID: 507
		private static readonly IntPtr NativeMethodInfoPtr_updatePlayerMetadata_Protected_Virtual_Void_AccountID_Dictionary_2_String_String_0;

		// Token: 0x040001FC RID: 508
		private static readonly IntPtr NativeMethodInfoPtr_updatePlayerMetadataComposition_Private_Void_DataComposition_Dictionary_2_String_String_0;

		// Token: 0x020002E4 RID: 740
		[ObfuscatedName("worm.WormPendingGameData+<>c__DisplayClass2_0")]
		public sealed class __c__DisplayClass2_0 : Object
		{
			// Token: 0x06001E1A RID: 7706 RVA: 0x000744E4 File Offset: 0x000726E4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass2_0()
			{
				Il2CppClassPointerStore<WormPendingGameData.__c__DisplayClass2_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormPendingGameData>.NativeClassPtr, "<>c__DisplayClass2_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormPendingGameData.__c__DisplayClass2_0>.NativeClassPtr);
				WormPendingGameData.__c__DisplayClass2_0.NativeFieldInfoPtr_data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPendingGameData.__c__DisplayClass2_0>.NativeClassPtr, "data");
				WormPendingGameData.__c__DisplayClass2_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPendingGameData.__c__DisplayClass2_0>.NativeClassPtr, 100663825);
				WormPendingGameData.__c__DisplayClass2_0.NativeMethodInfoPtr__updateWith_b__0_Internal_Boolean_AccountIDUsernameMetadata_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPendingGameData.__c__DisplayClass2_0>.NativeClassPtr, 100663826);
			}

			// Token: 0x06001E1B RID: 7707 RVA: 0x0007454C File Offset: 0x0007274C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass2_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormPendingGameData.__c__DisplayClass2_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPendingGameData.__c__DisplayClass2_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001E1C RID: 7708 RVA: 0x00074588 File Offset: 0x00072788
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 691454, XrefRangeEnd = 691462, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _updateWith_b__0(AccountIDUsernameMetadata x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPendingGameData.__c__DisplayClass2_0.NativeMethodInfoPtr__updateWith_b__0_Internal_Boolean_AccountIDUsernameMetadata_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001E1D RID: 7709 RVA: 0x00011256 File Offset: 0x0000F456
			public __c__DisplayClass2_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000843 RID: 2115
			// (get) Token: 0x06001E1E RID: 7710 RVA: 0x000745D8 File Offset: 0x000727D8
			// (set) Token: 0x06001E1F RID: 7711 RVA: 0x0001125F File Offset: 0x0000F45F
			public unsafe DataComposition data
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPendingGameData.__c__DisplayClass2_0.NativeFieldInfoPtr_data);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DataComposition>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPendingGameData.__c__DisplayClass2_0.NativeFieldInfoPtr_data), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001171 RID: 4465
			private static readonly IntPtr NativeFieldInfoPtr_data;

			// Token: 0x04001172 RID: 4466
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001173 RID: 4467
			private static readonly IntPtr NativeMethodInfoPtr__updateWith_b__0_Internal_Boolean_AccountIDUsernameMetadata_0;
		}

		// Token: 0x020002E5 RID: 741
		[ObfuscatedName("worm.WormPendingGameData+<>c__DisplayClass3_0")]
		public sealed class __c__DisplayClass3_0 : Object
		{
			// Token: 0x06001E20 RID: 7712 RVA: 0x00074608 File Offset: 0x00072808
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass3_0()
			{
				Il2CppClassPointerStore<WormPendingGameData.__c__DisplayClass3_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormPendingGameData>.NativeClassPtr, "<>c__DisplayClass3_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormPendingGameData.__c__DisplayClass3_0>.NativeClassPtr);
				WormPendingGameData.__c__DisplayClass3_0.NativeFieldInfoPtr_accountID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPendingGameData.__c__DisplayClass3_0>.NativeClassPtr, "accountID");
				WormPendingGameData.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPendingGameData.__c__DisplayClass3_0>.NativeClassPtr, 100663827);
				WormPendingGameData.__c__DisplayClass3_0.NativeMethodInfoPtr__updatePlayerMetadata_b__0_Internal_Boolean_DataComposition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPendingGameData.__c__DisplayClass3_0>.NativeClassPtr, 100663828);
			}

			// Token: 0x06001E21 RID: 7713 RVA: 0x00074670 File Offset: 0x00072870
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass3_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormPendingGameData.__c__DisplayClass3_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPendingGameData.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001E22 RID: 7714 RVA: 0x000746AC File Offset: 0x000728AC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 691462, XrefRangeEnd = 691466, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _updatePlayerMetadata_b__0(DataComposition p)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPendingGameData.__c__DisplayClass3_0.NativeMethodInfoPtr__updatePlayerMetadata_b__0_Internal_Boolean_DataComposition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001E23 RID: 7715 RVA: 0x0001127E File Offset: 0x0000F47E
			public __c__DisplayClass3_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000844 RID: 2116
			// (get) Token: 0x06001E24 RID: 7716 RVA: 0x000746FC File Offset: 0x000728FC
			// (set) Token: 0x06001E25 RID: 7717 RVA: 0x00011287 File Offset: 0x0000F487
			public unsafe AccountID accountID
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPendingGameData.__c__DisplayClass3_0.NativeFieldInfoPtr_accountID);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AccountID>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPendingGameData.__c__DisplayClass3_0.NativeFieldInfoPtr_accountID), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001174 RID: 4468
			private static readonly IntPtr NativeFieldInfoPtr_accountID;

			// Token: 0x04001175 RID: 4469
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001176 RID: 4470
			private static readonly IntPtr NativeMethodInfoPtr__updatePlayerMetadata_b__0_Internal_Boolean_DataComposition_0;
		}

		// Token: 0x020002E6 RID: 742
		[ObfuscatedName("worm.WormPendingGameData+<additionalComponentsForPlayerComposition>d__1")]
		public sealed class _additionalComponentsForPlayerComposition_d__1 : Object
		{
			// Token: 0x06001E26 RID: 7718 RVA: 0x0007472C File Offset: 0x0007292C
			// Note: this type is marked as 'beforefieldinit'.
			static _additionalComponentsForPlayerComposition_d__1()
			{
				Il2CppClassPointerStore<WormPendingGameData._additionalComponentsForPlayerComposition_d__1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormPendingGameData>.NativeClassPtr, "<additionalComponentsForPlayerComposition>d__1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormPendingGameData._additionalComponentsForPlayerComposition_d__1>.NativeClassPtr);
				WormPendingGameData._additionalComponentsForPlayerComposition_d__1.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPendingGameData._additionalComponentsForPlayerComposition_d__1>.NativeClassPtr, "<>1__state");
				WormPendingGameData._additionalComponentsForPlayerComposition_d__1.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPendingGameData._additionalComponentsForPlayerComposition_d__1>.NativeClassPtr, "<>2__current");
				WormPendingGameData._additionalComponentsForPlayerComposition_d__1.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPendingGameData._additionalComponentsForPlayerComposition_d__1>.NativeClassPtr, "<>l__initialThreadId");
				WormPendingGameData._additionalComponentsForPlayerComposition_d__1.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPendingGameData._additionalComponentsForPlayerComposition_d__1>.NativeClassPtr, 100663829);
				WormPendingGameData._additionalComponentsForPlayerComposition_d__1.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPendingGameData._additionalComponentsForPlayerComposition_d__1>.NativeClassPtr, 100663830);
				WormPendingGameData._additionalComponentsForPlayerComposition_d__1.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPendingGameData._additionalComponentsForPlayerComposition_d__1>.NativeClassPtr, 100663831);
				WormPendingGameData._additionalComponentsForPlayerComposition_d__1.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_dwd_core_data_composition_DataComponent__get_Current_Private_Virtual_Final_New_get_DataComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPendingGameData._additionalComponentsForPlayerComposition_d__1>.NativeClassPtr, 100663832);
				WormPendingGameData._additionalComponentsForPlayerComposition_d__1.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPendingGameData._additionalComponentsForPlayerComposition_d__1>.NativeClassPtr, 100663833);
				WormPendingGameData._additionalComponentsForPlayerComposition_d__1.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPendingGameData._additionalComponentsForPlayerComposition_d__1>.NativeClassPtr, 100663834);
				WormPendingGameData._additionalComponentsForPlayerComposition_d__1.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_dwd_core_data_composition_DataComponent__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_DataComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPendingGameData._additionalComponentsForPlayerComposition_d__1>.NativeClassPtr, 100663835);
				WormPendingGameData._additionalComponentsForPlayerComposition_d__1.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPendingGameData._additionalComponentsForPlayerComposition_d__1>.NativeClassPtr, 100663836);
			}

			// Token: 0x06001E27 RID: 7719 RVA: 0x00074834 File Offset: 0x00072A34
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _additionalComponentsForPlayerComposition_d__1(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormPendingGameData._additionalComponentsForPlayerComposition_d__1>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPendingGameData._additionalComponentsForPlayerComposition_d__1.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001E28 RID: 7720 RVA: 0x0007487C File Offset: 0x00072A7C
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPendingGameData._additionalComponentsForPlayerComposition_d__1.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001E29 RID: 7721 RVA: 0x000748B0 File Offset: 0x00072AB0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 691466, XrefRangeEnd = 691467, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPendingGameData._additionalComponentsForPlayerComposition_d__1.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000848 RID: 2120
			// (get) Token: 0x06001E2A RID: 7722 RVA: 0x000748EC File Offset: 0x00072AEC
			public unsafe DataComponent System.Collections.Generic.IEnumerator<dwd.core.data.composition.DataComponent>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPendingGameData._additionalComponentsForPlayerComposition_d__1.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_dwd_core_data_composition_DataComponent__get_Current_Private_Virtual_Final_New_get_DataComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<DataComponent>(intPtr3) : null;
				}
			}

			// Token: 0x06001E2B RID: 7723 RVA: 0x0007492C File Offset: 0x00072B2C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 691467, XrefRangeEnd = 691472, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPendingGameData._additionalComponentsForPlayerComposition_d__1.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000849 RID: 2121
			// (get) Token: 0x06001E2C RID: 7724 RVA: 0x00074960 File Offset: 0x00072B60
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPendingGameData._additionalComponentsForPlayerComposition_d__1.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06001E2D RID: 7725 RVA: 0x000749A0 File Offset: 0x00072BA0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 691472, XrefRangeEnd = 691474, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<DataComponent> System_Collections_Generic_IEnumerable_dwd_core_data_composition_DataComponent__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPendingGameData._additionalComponentsForPlayerComposition_d__1.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_dwd_core_data_composition_DataComponent__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_DataComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<DataComponent>>(intPtr3) : null;
			}

			// Token: 0x06001E2E RID: 7726 RVA: 0x000749E0 File Offset: 0x00072BE0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPendingGameData._additionalComponentsForPlayerComposition_d__1.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06001E2F RID: 7727 RVA: 0x000112A6 File Offset: 0x0000F4A6
			public _additionalComponentsForPlayerComposition_d__1(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000845 RID: 2117
			// (get) Token: 0x06001E30 RID: 7728 RVA: 0x00074A20 File Offset: 0x00072C20
			// (set) Token: 0x06001E31 RID: 7729 RVA: 0x000112AF File Offset: 0x0000F4AF
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPendingGameData._additionalComponentsForPlayerComposition_d__1.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPendingGameData._additionalComponentsForPlayerComposition_d__1.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000846 RID: 2118
			// (get) Token: 0x06001E32 RID: 7730 RVA: 0x00074A48 File Offset: 0x00072C48
			// (set) Token: 0x06001E33 RID: 7731 RVA: 0x000112CA File Offset: 0x0000F4CA
			public unsafe DataComponent __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPendingGameData._additionalComponentsForPlayerComposition_d__1.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DataComponent>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPendingGameData._additionalComponentsForPlayerComposition_d__1.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000847 RID: 2119
			// (get) Token: 0x06001E34 RID: 7732 RVA: 0x00074A78 File Offset: 0x00072C78
			// (set) Token: 0x06001E35 RID: 7733 RVA: 0x000112E9 File Offset: 0x0000F4E9
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPendingGameData._additionalComponentsForPlayerComposition_d__1.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPendingGameData._additionalComponentsForPlayerComposition_d__1.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x04001177 RID: 4471
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001178 RID: 4472
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001179 RID: 4473
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x0400117A RID: 4474
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400117B RID: 4475
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400117C RID: 4476
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400117D RID: 4477
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_dwd_core_data_composition_DataComponent__get_Current_Private_Virtual_Final_New_get_DataComponent_0;

			// Token: 0x0400117E RID: 4478
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400117F RID: 4479
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001180 RID: 4480
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_dwd_core_data_composition_DataComponent__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_DataComponent_0;

			// Token: 0x04001181 RID: 4481
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}
	}
}
