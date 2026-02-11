using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace boardgames.ranked.menus
{
	// Token: 0x02000026 RID: 38
	public class RankedPlayQueueButton : VersionedView<RankedPlayProvider>
	{
		// Token: 0x06000152 RID: 338 RVA: 0x00007144 File Offset: 0x00005344
		// Note: this type is marked as 'beforefieldinit'.
		static RankedPlayQueueButton()
		{
			Il2CppClassPointerStore<RankedPlayQueueButton>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames-ranked.dll", "boardgames.ranked.menus", "RankedPlayQueueButton");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RankedPlayQueueButton>.NativeClassPtr);
			RankedPlayQueueButton.NativeFieldInfoPtr_label = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RankedPlayQueueButton>.NativeClassPtr, "label");
			RankedPlayQueueButton.NativeFieldInfoPtr_closedLabelLoc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RankedPlayQueueButton>.NativeClassPtr, "closedLabelLoc");
			RankedPlayQueueButton.NativeFieldInfoPtr_openLabelLoc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RankedPlayQueueButton>.NativeClassPtr, "openLabelLoc");
			RankedPlayQueueButton.NativeFieldInfoPtr_showOnOwnershipNeeded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RankedPlayQueueButton>.NativeClassPtr, "showOnOwnershipNeeded");
			RankedPlayQueueButton.NativeFieldInfoPtr_button = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RankedPlayQueueButton>.NativeClassPtr, "button");
			RankedPlayQueueButton.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RankedPlayQueueButton>.NativeClassPtr, 100663405);
			RankedPlayQueueButton.NativeMethodInfoPtr_Event_OnTimerEnded_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RankedPlayQueueButton>.NativeClassPtr, 100663406);
			RankedPlayQueueButton.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RankedPlayQueueButton>.NativeClassPtr, 100663407);
			RankedPlayQueueButton.NativeMethodInfoPtr_OwnsCurrentSets_Protected_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RankedPlayQueueButton>.NativeClassPtr, 100663408);
			RankedPlayQueueButton.NativeMethodInfoPtr_GameSpecificRequirements_Protected_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RankedPlayQueueButton>.NativeClassPtr, 100663409);
			RankedPlayQueueButton.NativeMethodInfoPtr_Event_Queue_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RankedPlayQueueButton>.NativeClassPtr, 100663410);
			RankedPlayQueueButton.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RankedPlayQueueButton>.NativeClassPtr, 100663411);
		}

		// Token: 0x06000153 RID: 339 RVA: 0x00007264 File Offset: 0x00005464
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1225448, RefRangeEnd = 1225449, XrefRangeStart = 1225438, XrefRangeEnd = 1225448, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RankedPlayQueueButton.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000154 RID: 340 RVA: 0x000072A0 File Offset: 0x000054A0
		[CallerCount(0)]
		public unsafe void Event_OnTimerEnded()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RankedPlayQueueButton.NativeMethodInfoPtr_Event_OnTimerEnded_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000155 RID: 341 RVA: 0x000072D4 File Offset: 0x000054D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1225449, XrefRangeEnd = 1225468, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void dirtyUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RankedPlayQueueButton.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000156 RID: 342 RVA: 0x00007310 File Offset: 0x00005510
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 25017, RefRangeEnd = 25031, XrefRangeStart = 25017, XrefRangeEnd = 25031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool OwnsCurrentSets()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RankedPlayQueueButton.NativeMethodInfoPtr_OwnsCurrentSets_Protected_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000157 RID: 343 RVA: 0x00007358 File Offset: 0x00005558
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 25017, RefRangeEnd = 25031, XrefRangeStart = 25017, XrefRangeEnd = 25031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool GameSpecificRequirements()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RankedPlayQueueButton.NativeMethodInfoPtr_GameSpecificRequirements_Protected_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000158 RID: 344 RVA: 0x000073A0 File Offset: 0x000055A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1225468, XrefRangeEnd = 1225473, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_Queue()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RankedPlayQueueButton.NativeMethodInfoPtr_Event_Queue_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000159 RID: 345 RVA: 0x000073D4 File Offset: 0x000055D4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1225488, RefRangeEnd = 1225489, XrefRangeStart = 1225473, XrefRangeEnd = 1225488, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RankedPlayQueueButton()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RankedPlayQueueButton>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RankedPlayQueueButton.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600015A RID: 346 RVA: 0x00002CEA File Offset: 0x00000EEA
		public RankedPlayQueueButton(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000060 RID: 96
		// (get) Token: 0x0600015B RID: 347 RVA: 0x00007410 File Offset: 0x00005610
		// (set) Token: 0x0600015C RID: 348 RVA: 0x00002CF3 File Offset: 0x00000EF3
		public unsafe TMP_Text label
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankedPlayQueueButton.NativeFieldInfoPtr_label);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankedPlayQueueButton.NativeFieldInfoPtr_label), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000061 RID: 97
		// (get) Token: 0x0600015D RID: 349 RVA: 0x00007440 File Offset: 0x00005640
		// (set) Token: 0x0600015E RID: 350 RVA: 0x00002D12 File Offset: 0x00000F12
		public unsafe string closedLabelLoc
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankedPlayQueueButton.NativeFieldInfoPtr_closedLabelLoc);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankedPlayQueueButton.NativeFieldInfoPtr_closedLabelLoc), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000062 RID: 98
		// (get) Token: 0x0600015F RID: 351 RVA: 0x00007468 File Offset: 0x00005668
		// (set) Token: 0x06000160 RID: 352 RVA: 0x00002D31 File Offset: 0x00000F31
		public unsafe string openLabelLoc
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankedPlayQueueButton.NativeFieldInfoPtr_openLabelLoc);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankedPlayQueueButton.NativeFieldInfoPtr_openLabelLoc), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000063 RID: 99
		// (get) Token: 0x06000161 RID: 353 RVA: 0x00007490 File Offset: 0x00005690
		// (set) Token: 0x06000162 RID: 354 RVA: 0x00002D50 File Offset: 0x00000F50
		public unsafe Il2CppReferenceArray<GameObject> showOnOwnershipNeeded
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankedPlayQueueButton.NativeFieldInfoPtr_showOnOwnershipNeeded);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankedPlayQueueButton.NativeFieldInfoPtr_showOnOwnershipNeeded), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000064 RID: 100
		// (get) Token: 0x06000163 RID: 355 RVA: 0x000074C0 File Offset: 0x000056C0
		// (set) Token: 0x06000164 RID: 356 RVA: 0x00002D6F File Offset: 0x00000F6F
		public unsafe Button button
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankedPlayQueueButton.NativeFieldInfoPtr_button);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankedPlayQueueButton.NativeFieldInfoPtr_button), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040000BB RID: 187
		private static readonly IntPtr NativeFieldInfoPtr_label;

		// Token: 0x040000BC RID: 188
		private static readonly IntPtr NativeFieldInfoPtr_closedLabelLoc;

		// Token: 0x040000BD RID: 189
		private static readonly IntPtr NativeFieldInfoPtr_openLabelLoc;

		// Token: 0x040000BE RID: 190
		private static readonly IntPtr NativeFieldInfoPtr_showOnOwnershipNeeded;

		// Token: 0x040000BF RID: 191
		private static readonly IntPtr NativeFieldInfoPtr_button;

		// Token: 0x040000C0 RID: 192
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x040000C1 RID: 193
		private static readonly IntPtr NativeMethodInfoPtr_Event_OnTimerEnded_Public_Void_0;

		// Token: 0x040000C2 RID: 194
		private static readonly IntPtr NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0;

		// Token: 0x040000C3 RID: 195
		private static readonly IntPtr NativeMethodInfoPtr_OwnsCurrentSets_Protected_Virtual_New_Boolean_0;

		// Token: 0x040000C4 RID: 196
		private static readonly IntPtr NativeMethodInfoPtr_GameSpecificRequirements_Protected_Virtual_New_Boolean_0;

		// Token: 0x040000C5 RID: 197
		private static readonly IntPtr NativeMethodInfoPtr_Event_Queue_Public_Void_0;

		// Token: 0x040000C6 RID: 198
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
