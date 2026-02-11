using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace boardgames.hints
{
	// Token: 0x02000140 RID: 320
	public class DBGHintManager : MonoBehaviour
	{
		// Token: 0x06000EB1 RID: 3761 RVA: 0x0004C548 File Offset: 0x0004A748
		// Note: this type is marked as 'beforefieldinit'.
		static DBGHintManager()
		{
			Il2CppClassPointerStore<DBGHintManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.hints", "DBGHintManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DBGHintManager>.NativeClassPtr);
			DBGHintManager.NativeFieldInfoPtr_hinterMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGHintManager>.NativeClassPtr, "hinterMap");
			DBGHintManager.NativeFieldInfoPtr_suppressedViewLayers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGHintManager>.NativeClassPtr, "suppressedViewLayers");
			DBGHintManager.NativeMethodInfoPtr_RegisterHinter_Public_Void_EntityID_IHinter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGHintManager>.NativeClassPtr, 100665436);
			DBGHintManager.NativeMethodInfoPtr_UnRegisterHinter_Public_Void_EntityID_IHinter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGHintManager>.NativeClassPtr, 100665437);
			DBGHintManager.NativeMethodInfoPtr_InitHinterStates_Public_Void_EntityID_IHinter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGHintManager>.NativeClassPtr, 100665438);
			DBGHintManager.NativeMethodInfoPtr_SyncHintStates_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGHintManager>.NativeClassPtr, 100665439);
			DBGHintManager.NativeMethodInfoPtr_SuppressViewLayer_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGHintManager>.NativeClassPtr, 100665440);
			DBGHintManager.NativeMethodInfoPtr_SuppressViewLayers_Public_Void_IEnumerable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGHintManager>.NativeClassPtr, 100665441);
			DBGHintManager.NativeMethodInfoPtr_ClearSuppressedViewLayers_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGHintManager>.NativeClassPtr, 100665442);
			DBGHintManager.NativeMethodInfoPtr_AnyViewLayerSuppressed_Public_Boolean_IEnumerable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGHintManager>.NativeClassPtr, 100665443);
			DBGHintManager.NativeMethodInfoPtr_SetHint_Public_Void_EntityID_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGHintManager>.NativeClassPtr, 100665444);
			DBGHintManager.NativeMethodInfoPtr_SetHints_Public_Void_IEnumerable_1_EntityID_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGHintManager>.NativeClassPtr, 100665445);
			DBGHintManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGHintManager>.NativeClassPtr, 100665446);
			DBGHintManager.NativeMethodInfoPtr__AnyViewLayerSuppressed_b__10_0_Private_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGHintManager>.NativeClassPtr, 100665447);
		}

		// Token: 0x06000EB2 RID: 3762 RVA: 0x0004C690 File Offset: 0x0004A890
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 512443, RefRangeEnd = 512445, XrefRangeStart = 512429, XrefRangeEnd = 512443, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RegisterHinter(EntityID entityID, IHinter hinter)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(entityID);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(hinter);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGHintManager.NativeMethodInfoPtr_RegisterHinter_Public_Void_EntityID_IHinter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EB3 RID: 3763 RVA: 0x0004C6E4 File Offset: 0x0004A8E4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 512454, RefRangeEnd = 512458, XrefRangeStart = 512445, XrefRangeEnd = 512454, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UnRegisterHinter(EntityID entityID, IHinter hinter)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(entityID);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(hinter);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGHintManager.NativeMethodInfoPtr_UnRegisterHinter_Public_Void_EntityID_IHinter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EB4 RID: 3764 RVA: 0x0004C738 File Offset: 0x0004A938
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 512493, RefRangeEnd = 512496, XrefRangeStart = 512458, XrefRangeEnd = 512493, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitHinterStates(EntityID entityID, IHinter hinter)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(entityID);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(hinter);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGHintManager.NativeMethodInfoPtr_InitHinterStates_Public_Void_EntityID_IHinter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EB5 RID: 3765 RVA: 0x0004C78C File Offset: 0x0004A98C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 512512, RefRangeEnd = 512515, XrefRangeStart = 512496, XrefRangeEnd = 512512, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SyncHintStates()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGHintManager.NativeMethodInfoPtr_SyncHintStates_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EB6 RID: 3766 RVA: 0x0004C7C0 File Offset: 0x0004A9C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 512515, XrefRangeEnd = 512522, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SuppressViewLayer(int viewLayer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref viewLayer;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGHintManager.NativeMethodInfoPtr_SuppressViewLayer_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000EB7 RID: 3767 RVA: 0x0004C800 File Offset: 0x0004AA00
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 512527, RefRangeEnd = 512530, XrefRangeStart = 512522, XrefRangeEnd = 512527, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SuppressViewLayers(IEnumerable<int> viewLayers)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(viewLayers);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGHintManager.NativeMethodInfoPtr_SuppressViewLayers_Public_Void_IEnumerable_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000EB8 RID: 3768 RVA: 0x0004C844 File Offset: 0x0004AA44
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 512533, RefRangeEnd = 512536, XrefRangeStart = 512530, XrefRangeEnd = 512533, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearSuppressedViewLayers()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGHintManager.NativeMethodInfoPtr_ClearSuppressedViewLayers_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EB9 RID: 3769 RVA: 0x0004C878 File Offset: 0x0004AA78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 512536, XrefRangeEnd = 512545, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool AnyViewLayerSuppressed(IEnumerable<int> viewLayers)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(viewLayers);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGHintManager.NativeMethodInfoPtr_AnyViewLayerSuppressed_Public_Boolean_IEnumerable_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000EBA RID: 3770 RVA: 0x0004C8C8 File Offset: 0x0004AAC8
		[CallerCount(21)]
		[CachedScanResults(RefRangeStart = 512596, RefRangeEnd = 512617, XrefRangeStart = 512545, XrefRangeEnd = 512596, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetHint(EntityID hint, string flavor, bool val)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(hint);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(flavor);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref val;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGHintManager.NativeMethodInfoPtr_SetHint_Public_Void_EntityID_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EBB RID: 3771 RVA: 0x0004C92C File Offset: 0x0004AB2C
		[CallerCount(22)]
		[CachedScanResults(RefRangeStart = 512635, RefRangeEnd = 512657, XrefRangeStart = 512617, XrefRangeEnd = 512635, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetHints(IEnumerable<EntityID> hints, string flavor, bool val)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(hints);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(flavor);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref val;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGHintManager.NativeMethodInfoPtr_SetHints_Public_Void_IEnumerable_1_EntityID_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EBC RID: 3772 RVA: 0x0004C990 File Offset: 0x0004AB90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 512657, XrefRangeEnd = 512672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DBGHintManager()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DBGHintManager>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGHintManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EBD RID: 3773 RVA: 0x0004C9CC File Offset: 0x0004ABCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 512672, XrefRangeEnd = 512676, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _AnyViewLayerSuppressed_b__10_0(int s)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref s;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGHintManager.NativeMethodInfoPtr__AnyViewLayerSuppressed_b__10_0_Private_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000EBE RID: 3774 RVA: 0x000091A4 File Offset: 0x000073A4
		public DBGHintManager(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003F4 RID: 1012
		// (get) Token: 0x06000EBF RID: 3775 RVA: 0x0004CA18 File Offset: 0x0004AC18
		// (set) Token: 0x06000EC0 RID: 3776 RVA: 0x000091AD File Offset: 0x000073AD
		public unsafe Dictionary<EntityID, DBGHintManager.HinterEntry> hinterMap
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGHintManager.NativeFieldInfoPtr_hinterMap);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<EntityID, DBGHintManager.HinterEntry>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGHintManager.NativeFieldInfoPtr_hinterMap), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003F5 RID: 1013
		// (get) Token: 0x06000EC1 RID: 3777 RVA: 0x0004CA48 File Offset: 0x0004AC48
		// (set) Token: 0x06000EC2 RID: 3778 RVA: 0x000091CC File Offset: 0x000073CC
		public unsafe List<int> suppressedViewLayers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGHintManager.NativeFieldInfoPtr_suppressedViewLayers);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGHintManager.NativeFieldInfoPtr_suppressedViewLayers), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000911 RID: 2321
		private static readonly IntPtr NativeFieldInfoPtr_hinterMap;

		// Token: 0x04000912 RID: 2322
		private static readonly IntPtr NativeFieldInfoPtr_suppressedViewLayers;

		// Token: 0x04000913 RID: 2323
		private static readonly IntPtr NativeMethodInfoPtr_RegisterHinter_Public_Void_EntityID_IHinter_0;

		// Token: 0x04000914 RID: 2324
		private static readonly IntPtr NativeMethodInfoPtr_UnRegisterHinter_Public_Void_EntityID_IHinter_0;

		// Token: 0x04000915 RID: 2325
		private static readonly IntPtr NativeMethodInfoPtr_InitHinterStates_Public_Void_EntityID_IHinter_0;

		// Token: 0x04000916 RID: 2326
		private static readonly IntPtr NativeMethodInfoPtr_SyncHintStates_Private_Void_0;

		// Token: 0x04000917 RID: 2327
		private static readonly IntPtr NativeMethodInfoPtr_SuppressViewLayer_Public_Void_Int32_0;

		// Token: 0x04000918 RID: 2328
		private static readonly IntPtr NativeMethodInfoPtr_SuppressViewLayers_Public_Void_IEnumerable_1_Int32_0;

		// Token: 0x04000919 RID: 2329
		private static readonly IntPtr NativeMethodInfoPtr_ClearSuppressedViewLayers_Public_Void_0;

		// Token: 0x0400091A RID: 2330
		private static readonly IntPtr NativeMethodInfoPtr_AnyViewLayerSuppressed_Public_Boolean_IEnumerable_1_Int32_0;

		// Token: 0x0400091B RID: 2331
		private static readonly IntPtr NativeMethodInfoPtr_SetHint_Public_Void_EntityID_String_Boolean_0;

		// Token: 0x0400091C RID: 2332
		private static readonly IntPtr NativeMethodInfoPtr_SetHints_Public_Void_IEnumerable_1_EntityID_String_Boolean_0;

		// Token: 0x0400091D RID: 2333
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400091E RID: 2334
		private static readonly IntPtr NativeMethodInfoPtr__AnyViewLayerSuppressed_b__10_0_Private_Boolean_Int32_0;

		// Token: 0x02000368 RID: 872
		public sealed class HinterEntry : ValueType
		{
			// Token: 0x06002925 RID: 10533 RVA: 0x000A3C2C File Offset: 0x000A1E2C
			// Note: this type is marked as 'beforefieldinit'.
			static HinterEntry()
			{
				Il2CppClassPointerStore<DBGHintManager.HinterEntry>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DBGHintManager>.NativeClassPtr, "HinterEntry");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DBGHintManager.HinterEntry>.NativeClassPtr);
				DBGHintManager.HinterEntry.NativeFieldInfoPtr_hinters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGHintManager.HinterEntry>.NativeClassPtr, "hinters");
				DBGHintManager.HinterEntry.NativeFieldInfoPtr_hintStates = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGHintManager.HinterEntry>.NativeClassPtr, "hintStates");
				DBGHintManager.HinterEntry.NativeMethodInfoPtr__ctor_Public_Void_List_1_IHinter_Dictionary_2_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGHintManager.HinterEntry>.NativeClassPtr, 100665448);
				DBGHintManager.HinterEntry.NativeMethodInfoPtr_SyncStates_Public_Void_IReadOnlyCollection_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGHintManager.HinterEntry>.NativeClassPtr, 100665449);
			}

			// Token: 0x06002926 RID: 10534 RVA: 0x000A3CA8 File Offset: 0x000A1EA8
			[CallerCount(238)]
			[CachedScanResults(RefRangeStart = 342357, RefRangeEnd = 342595, XrefRangeStart = 342357, XrefRangeEnd = 342595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe HinterEntry(List<IHinter> hinters, Dictionary<string, bool> hintStates)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DBGHintManager.HinterEntry>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(hinters);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(hintStates);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGHintManager.HinterEntry.NativeMethodInfoPtr__ctor_Public_Void_List_1_IHinter_Dictionary_2_String_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002927 RID: 10535 RVA: 0x000A3D0C File Offset: 0x000A1F0C
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 512428, RefRangeEnd = 512429, XrefRangeStart = 512385, XrefRangeEnd = 512428, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SyncStates(IReadOnlyCollection<int> suppressedViewLayers)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(suppressedViewLayers);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGHintManager.HinterEntry.NativeMethodInfoPtr_SyncStates_Public_Void_IReadOnlyCollection_1_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002928 RID: 10536 RVA: 0x000153AC File Offset: 0x000135AC
			public HinterEntry(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06002929 RID: 10537 RVA: 0x000153B5 File Offset: 0x000135B5
			public HinterEntry()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DBGHintManager.HinterEntry>.NativeClassPtr))
			{
			}

			// Token: 0x17000B91 RID: 2961
			// (get) Token: 0x0600292A RID: 10538 RVA: 0x000A3D54 File Offset: 0x000A1F54
			// (set) Token: 0x0600292B RID: 10539 RVA: 0x000153C7 File Offset: 0x000135C7
			public unsafe List<IHinter> hinters
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGHintManager.HinterEntry.NativeFieldInfoPtr_hinters);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<IHinter>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGHintManager.HinterEntry.NativeFieldInfoPtr_hinters), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000B92 RID: 2962
			// (get) Token: 0x0600292C RID: 10540 RVA: 0x000A3D84 File Offset: 0x000A1F84
			// (set) Token: 0x0600292D RID: 10541 RVA: 0x000153E6 File Offset: 0x000135E6
			public unsafe Dictionary<string, bool> hintStates
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGHintManager.HinterEntry.NativeFieldInfoPtr_hintStates);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGHintManager.HinterEntry.NativeFieldInfoPtr_hintStates), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040019BF RID: 6591
			private static readonly IntPtr NativeFieldInfoPtr_hinters;

			// Token: 0x040019C0 RID: 6592
			private static readonly IntPtr NativeFieldInfoPtr_hintStates;

			// Token: 0x040019C1 RID: 6593
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_List_1_IHinter_Dictionary_2_String_Boolean_0;

			// Token: 0x040019C2 RID: 6594
			private static readonly IntPtr NativeMethodInfoPtr_SyncStates_Public_Void_IReadOnlyCollection_1_Int32_0;
		}
	}
}
