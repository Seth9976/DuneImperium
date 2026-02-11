using System;
using boardgames.match.behaviours;
using dwd.core.match;
using dwd.core.match.selection;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using lotus;
using UnityEngine;

namespace boardgames.match.validators
{
	// Token: 0x02000251 RID: 593
	public class SelectableChildValidator : MonoBehaviour
	{
		// Token: 0x06001AFC RID: 6908 RVA: 0x0007578C File Offset: 0x0007398C
		// Note: this type is marked as 'beforefieldinit'.
		static SelectableChildValidator()
		{
			Il2CppClassPointerStore<SelectableChildValidator>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.match.validators", "SelectableChildValidator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SelectableChildValidator>.NativeClassPtr);
			SelectableChildValidator.NativeFieldInfoPtr_childIsSelectable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectableChildValidator>.NativeClassPtr, "childIsSelectable");
			SelectableChildValidator.NativeFieldInfoPtr_entities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectableChildValidator>.NativeClassPtr, "entities");
			SelectableChildValidator.NativeFieldInfoPtr_entityView = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectableChildValidator>.NativeClassPtr, "entityView");
			SelectableChildValidator.NativeFieldInfoPtr_selection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectableChildValidator>.NativeClassPtr, "selection");
			SelectableChildValidator.NativeFieldInfoPtr_cachedSelection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectableChildValidator>.NativeClassPtr, "cachedSelection");
			SelectableChildValidator.NativeFieldInfoPtr_initialized = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectableChildValidator>.NativeClassPtr, "initialized");
			SelectableChildValidator.NativeMethodInfoPtr_get_Valid_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectableChildValidator>.NativeClassPtr, 100667597);
			SelectableChildValidator.NativeMethodInfoPtr_set_Valid_Public_Virtual_Final_New_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectableChildValidator>.NativeClassPtr, 100667598);
			SelectableChildValidator.NativeMethodInfoPtr_Start_Protected_Virtual_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectableChildValidator>.NativeClassPtr, 100667599);
			SelectableChildValidator.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectableChildValidator>.NativeClassPtr, 100667600);
			SelectableChildValidator.NativeMethodInfoPtr_checkSelectableChildren_Protected_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectableChildValidator>.NativeClassPtr, 100667601);
			SelectableChildValidator.NativeMethodInfoPtr_isValid_Protected_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectableChildValidator>.NativeClassPtr, 100667602);
			SelectableChildValidator.NativeMethodInfoPtr_isChildOfEntity_Private_Boolean_EntityComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectableChildValidator>.NativeClassPtr, 100667603);
			SelectableChildValidator.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectableChildValidator>.NativeClassPtr, 100667604);
		}

		// Token: 0x17000736 RID: 1846
		// (get) Token: 0x06001AFD RID: 6909 RVA: 0x000758D4 File Offset: 0x00073AD4
		// (set) Token: 0x06001AFE RID: 6910 RVA: 0x00075910 File Offset: 0x00073B10
		public unsafe virtual bool Valid
		{
			[CallerCount(41)]
			[CachedScanResults(RefRangeStart = 381934, RefRangeEnd = 381975, XrefRangeStart = 381934, XrefRangeEnd = 381975, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectableChildValidator.NativeMethodInfoPtr_get_Valid_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectableChildValidator.NativeMethodInfoPtr_set_Valid_Public_Virtual_Final_New_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06001AFF RID: 6911 RVA: 0x00075950 File Offset: 0x00073B50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 532894, XrefRangeEnd = 532899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerator Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SelectableChildValidator.NativeMethodInfoPtr_Start_Protected_Virtual_New_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06001B00 RID: 6912 RVA: 0x0007599C File Offset: 0x00073B9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 532899, XrefRangeEnd = 532902, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectableChildValidator.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B01 RID: 6913 RVA: 0x000759D0 File Offset: 0x00073BD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 532902, XrefRangeEnd = 532929, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool checkSelectableChildren()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SelectableChildValidator.NativeMethodInfoPtr_checkSelectableChildren_Protected_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001B02 RID: 6914 RVA: 0x00075A18 File Offset: 0x00073C18
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 308625, RefRangeEnd = 308626, XrefRangeStart = 308625, XrefRangeEnd = 308626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool isValid()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SelectableChildValidator.NativeMethodInfoPtr_isValid_Protected_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001B03 RID: 6915 RVA: 0x00075A60 File Offset: 0x00073C60
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 532930, RefRangeEnd = 532933, XrefRangeStart = 532929, XrefRangeEnd = 532930, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool isChildOfEntity(EntityComponent component)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(component);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectableChildValidator.NativeMethodInfoPtr_isChildOfEntity_Private_Boolean_EntityComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001B04 RID: 6916 RVA: 0x00075AB0 File Offset: 0x00073CB0
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SelectableChildValidator()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SelectableChildValidator>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectableChildValidator.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B05 RID: 6917 RVA: 0x0000EBA8 File Offset: 0x0000CDA8
		public SelectableChildValidator(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000730 RID: 1840
		// (get) Token: 0x06001B06 RID: 6918 RVA: 0x00075AEC File Offset: 0x00073CEC
		// (set) Token: 0x06001B07 RID: 6919 RVA: 0x0000EBB1 File Offset: 0x0000CDB1
		public unsafe bool childIsSelectable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectableChildValidator.NativeFieldInfoPtr_childIsSelectable);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectableChildValidator.NativeFieldInfoPtr_childIsSelectable)) = value;
			}
		}

		// Token: 0x17000731 RID: 1841
		// (get) Token: 0x06001B08 RID: 6920 RVA: 0x00075B14 File Offset: 0x00073D14
		// (set) Token: 0x06001B09 RID: 6921 RVA: 0x0000EBCC File Offset: 0x0000CDCC
		public unsafe DBGEntities entities
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectableChildValidator.NativeFieldInfoPtr_entities);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DBGEntities>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectableChildValidator.NativeFieldInfoPtr_entities), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000732 RID: 1842
		// (get) Token: 0x06001B0A RID: 6922 RVA: 0x00075B44 File Offset: 0x00073D44
		// (set) Token: 0x06001B0B RID: 6923 RVA: 0x0000EBEB File Offset: 0x0000CDEB
		public unsafe EntityView entityView
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectableChildValidator.NativeFieldInfoPtr_entityView);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityView>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectableChildValidator.NativeFieldInfoPtr_entityView), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000733 RID: 1843
		// (get) Token: 0x06001B0C RID: 6924 RVA: 0x00075B74 File Offset: 0x00073D74
		// (set) Token: 0x06001B0D RID: 6925 RVA: 0x0000EC0A File Offset: 0x0000CE0A
		public unsafe Selection selection
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectableChildValidator.NativeFieldInfoPtr_selection);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Selection>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectableChildValidator.NativeFieldInfoPtr_selection), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000734 RID: 1844
		// (get) Token: 0x06001B0E RID: 6926 RVA: 0x00075BA4 File Offset: 0x00073DA4
		// (set) Token: 0x06001B0F RID: 6927 RVA: 0x0000EC29 File Offset: 0x0000CE29
		public unsafe ISelectionNode cachedSelection
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectableChildValidator.NativeFieldInfoPtr_cachedSelection);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ISelectionNode>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectableChildValidator.NativeFieldInfoPtr_cachedSelection), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000735 RID: 1845
		// (get) Token: 0x06001B10 RID: 6928 RVA: 0x00075BD4 File Offset: 0x00073DD4
		// (set) Token: 0x06001B11 RID: 6929 RVA: 0x0000EC48 File Offset: 0x0000CE48
		public unsafe bool initialized
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectableChildValidator.NativeFieldInfoPtr_initialized);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectableChildValidator.NativeFieldInfoPtr_initialized)) = value;
			}
		}

		// Token: 0x040010D8 RID: 4312
		private static readonly IntPtr NativeFieldInfoPtr_childIsSelectable;

		// Token: 0x040010D9 RID: 4313
		private static readonly IntPtr NativeFieldInfoPtr_entities;

		// Token: 0x040010DA RID: 4314
		private static readonly IntPtr NativeFieldInfoPtr_entityView;

		// Token: 0x040010DB RID: 4315
		private static readonly IntPtr NativeFieldInfoPtr_selection;

		// Token: 0x040010DC RID: 4316
		private static readonly IntPtr NativeFieldInfoPtr_cachedSelection;

		// Token: 0x040010DD RID: 4317
		private static readonly IntPtr NativeFieldInfoPtr_initialized;

		// Token: 0x040010DE RID: 4318
		private static readonly IntPtr NativeMethodInfoPtr_get_Valid_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x040010DF RID: 4319
		private static readonly IntPtr NativeMethodInfoPtr_set_Valid_Public_Virtual_Final_New_set_Void_Boolean_0;

		// Token: 0x040010E0 RID: 4320
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_New_IEnumerator_0;

		// Token: 0x040010E1 RID: 4321
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x040010E2 RID: 4322
		private static readonly IntPtr NativeMethodInfoPtr_checkSelectableChildren_Protected_Virtual_New_Boolean_0;

		// Token: 0x040010E3 RID: 4323
		private static readonly IntPtr NativeMethodInfoPtr_isValid_Protected_Virtual_New_Boolean_0;

		// Token: 0x040010E4 RID: 4324
		private static readonly IntPtr NativeMethodInfoPtr_isChildOfEntity_Private_Boolean_EntityComponent_0;

		// Token: 0x040010E5 RID: 4325
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000440 RID: 1088
		[ObfuscatedName("boardgames.match.validators.SelectableChildValidator+<Start>d__9")]
		public sealed class _Start_d__9 : global::Il2CppSystem.Object
		{
			// Token: 0x06003370 RID: 13168 RVA: 0x000C1F8C File Offset: 0x000C018C
			// Note: this type is marked as 'beforefieldinit'.
			static _Start_d__9()
			{
				Il2CppClassPointerStore<SelectableChildValidator._Start_d__9>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SelectableChildValidator>.NativeClassPtr, "<Start>d__9");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SelectableChildValidator._Start_d__9>.NativeClassPtr);
				SelectableChildValidator._Start_d__9.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectableChildValidator._Start_d__9>.NativeClassPtr, "<>1__state");
				SelectableChildValidator._Start_d__9.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectableChildValidator._Start_d__9>.NativeClassPtr, "<>2__current");
				SelectableChildValidator._Start_d__9.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectableChildValidator._Start_d__9>.NativeClassPtr, "<>4__this");
				SelectableChildValidator._Start_d__9.NativeFieldInfoPtr__entitiesProvider_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectableChildValidator._Start_d__9>.NativeClassPtr, "<entitiesProvider>5__2");
				SelectableChildValidator._Start_d__9.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectableChildValidator._Start_d__9>.NativeClassPtr, 100667605);
				SelectableChildValidator._Start_d__9.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectableChildValidator._Start_d__9>.NativeClassPtr, 100667606);
				SelectableChildValidator._Start_d__9.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectableChildValidator._Start_d__9>.NativeClassPtr, 100667607);
				SelectableChildValidator._Start_d__9.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectableChildValidator._Start_d__9>.NativeClassPtr, 100667608);
				SelectableChildValidator._Start_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectableChildValidator._Start_d__9>.NativeClassPtr, 100667609);
				SelectableChildValidator._Start_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectableChildValidator._Start_d__9>.NativeClassPtr, 100667610);
			}

			// Token: 0x06003371 RID: 13169 RVA: 0x000C2080 File Offset: 0x000C0280
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _Start_d__9(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SelectableChildValidator._Start_d__9>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectableChildValidator._Start_d__9.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06003372 RID: 13170 RVA: 0x000C20C8 File Offset: 0x000C02C8
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectableChildValidator._Start_d__9.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003373 RID: 13171 RVA: 0x000C20FC File Offset: 0x000C02FC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 532882, XrefRangeEnd = 532889, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectableChildValidator._Start_d__9.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000F06 RID: 3846
			// (get) Token: 0x06003374 RID: 13172 RVA: 0x000C2138 File Offset: 0x000C0338
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectableChildValidator._Start_d__9.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06003375 RID: 13173 RVA: 0x000C2178 File Offset: 0x000C0378
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 532889, XrefRangeEnd = 532894, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectableChildValidator._Start_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000F07 RID: 3847
			// (get) Token: 0x06003376 RID: 13174 RVA: 0x000C21AC File Offset: 0x000C03AC
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectableChildValidator._Start_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06003377 RID: 13175 RVA: 0x0001A8E9 File Offset: 0x00018AE9
			public _Start_d__9(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000F02 RID: 3842
			// (get) Token: 0x06003378 RID: 13176 RVA: 0x000C21EC File Offset: 0x000C03EC
			// (set) Token: 0x06003379 RID: 13177 RVA: 0x0001A8F2 File Offset: 0x00018AF2
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectableChildValidator._Start_d__9.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectableChildValidator._Start_d__9.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000F03 RID: 3843
			// (get) Token: 0x0600337A RID: 13178 RVA: 0x000C2214 File Offset: 0x000C0414
			// (set) Token: 0x0600337B RID: 13179 RVA: 0x0001A90D File Offset: 0x00018B0D
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectableChildValidator._Start_d__9.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectableChildValidator._Start_d__9.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000F04 RID: 3844
			// (get) Token: 0x0600337C RID: 13180 RVA: 0x000C2244 File Offset: 0x000C0444
			// (set) Token: 0x0600337D RID: 13181 RVA: 0x0001A92C File Offset: 0x00018B2C
			public unsafe SelectableChildValidator __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectableChildValidator._Start_d__9.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SelectableChildValidator>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectableChildValidator._Start_d__9.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000F05 RID: 3845
			// (get) Token: 0x0600337E RID: 13182 RVA: 0x000C2274 File Offset: 0x000C0474
			// (set) Token: 0x0600337F RID: 13183 RVA: 0x0001A94B File Offset: 0x00018B4B
			public unsafe DBGEntitiesProvider _entitiesProvider_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectableChildValidator._Start_d__9.NativeFieldInfoPtr__entitiesProvider_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DBGEntitiesProvider>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectableChildValidator._Start_d__9.NativeFieldInfoPtr__entitiesProvider_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001FB9 RID: 8121
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001FBA RID: 8122
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001FBB RID: 8123
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001FBC RID: 8124
			private static readonly IntPtr NativeFieldInfoPtr__entitiesProvider_5__2;

			// Token: 0x04001FBD RID: 8125
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001FBE RID: 8126
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001FBF RID: 8127
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001FC0 RID: 8128
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001FC1 RID: 8129
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001FC2 RID: 8130
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
