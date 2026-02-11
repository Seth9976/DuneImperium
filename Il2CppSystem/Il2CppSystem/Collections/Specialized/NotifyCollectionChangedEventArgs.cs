using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Collections.Specialized
{
	// Token: 0x02000160 RID: 352
	public class NotifyCollectionChangedEventArgs : EventArgs
	{
		// Token: 0x0600153A RID: 5434 RVA: 0x0006EB54 File Offset: 0x0006CD54
		// Note: this type is marked as 'beforefieldinit'.
		static NotifyCollectionChangedEventArgs()
		{
			Il2CppClassPointerStore<NotifyCollectionChangedEventArgs>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Collections.Specialized", "NotifyCollectionChangedEventArgs");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NotifyCollectionChangedEventArgs>.NativeClassPtr);
			NotifyCollectionChangedEventArgs.NativeFieldInfoPtr__action = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NotifyCollectionChangedEventArgs>.NativeClassPtr, "_action");
			NotifyCollectionChangedEventArgs.NativeFieldInfoPtr__newItems = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NotifyCollectionChangedEventArgs>.NativeClassPtr, "_newItems");
			NotifyCollectionChangedEventArgs.NativeFieldInfoPtr__oldItems = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NotifyCollectionChangedEventArgs>.NativeClassPtr, "_oldItems");
			NotifyCollectionChangedEventArgs.NativeFieldInfoPtr__newStartingIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NotifyCollectionChangedEventArgs>.NativeClassPtr, "_newStartingIndex");
			NotifyCollectionChangedEventArgs.NativeFieldInfoPtr__oldStartingIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NotifyCollectionChangedEventArgs>.NativeClassPtr, "_oldStartingIndex");
			NotifyCollectionChangedEventArgs.NativeMethodInfoPtr__ctor_Public_Void_NotifyCollectionChangedAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NotifyCollectionChangedEventArgs>.NativeClassPtr, 100666531);
			NotifyCollectionChangedEventArgs.NativeMethodInfoPtr__ctor_Public_Void_NotifyCollectionChangedAction_Object_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NotifyCollectionChangedEventArgs>.NativeClassPtr, 100666532);
			NotifyCollectionChangedEventArgs.NativeMethodInfoPtr__ctor_Public_Void_NotifyCollectionChangedAction_Object_Object_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NotifyCollectionChangedEventArgs>.NativeClassPtr, 100666533);
			NotifyCollectionChangedEventArgs.NativeMethodInfoPtr__ctor_Public_Void_NotifyCollectionChangedAction_IList_IList_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NotifyCollectionChangedEventArgs>.NativeClassPtr, 100666534);
			NotifyCollectionChangedEventArgs.NativeMethodInfoPtr_InitializeAddOrRemove_Private_Void_NotifyCollectionChangedAction_IList_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NotifyCollectionChangedEventArgs>.NativeClassPtr, 100666535);
			NotifyCollectionChangedEventArgs.NativeMethodInfoPtr_InitializeAdd_Private_Void_NotifyCollectionChangedAction_IList_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NotifyCollectionChangedEventArgs>.NativeClassPtr, 100666536);
			NotifyCollectionChangedEventArgs.NativeMethodInfoPtr_InitializeRemove_Private_Void_NotifyCollectionChangedAction_IList_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NotifyCollectionChangedEventArgs>.NativeClassPtr, 100666537);
			NotifyCollectionChangedEventArgs.NativeMethodInfoPtr_InitializeMoveOrReplace_Private_Void_NotifyCollectionChangedAction_IList_IList_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NotifyCollectionChangedEventArgs>.NativeClassPtr, 100666538);
		}

		// Token: 0x0600153B RID: 5435 RVA: 0x0006EC88 File Offset: 0x0006CE88
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 466920, RefRangeEnd = 466921, XrefRangeStart = 466914, XrefRangeEnd = 466920, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction action)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NotifyCollectionChangedEventArgs>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref action;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NotifyCollectionChangedEventArgs.NativeMethodInfoPtr__ctor_Public_Void_NotifyCollectionChangedAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600153C RID: 5436 RVA: 0x0006ECD0 File Offset: 0x0006CED0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 466939, RefRangeEnd = 466941, XrefRangeStart = 466921, XrefRangeEnd = 466939, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction action, Object changedItem, int index)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NotifyCollectionChangedEventArgs>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref action;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(changedItem);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NotifyCollectionChangedEventArgs.NativeMethodInfoPtr__ctor_Public_Void_NotifyCollectionChangedAction_Object_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600153D RID: 5437 RVA: 0x0006ED38 File Offset: 0x0006CF38
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 466955, RefRangeEnd = 466956, XrefRangeStart = 466941, XrefRangeEnd = 466955, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction action, Object newItem, Object oldItem, int index)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NotifyCollectionChangedEventArgs>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref action;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(newItem);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(oldItem);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NotifyCollectionChangedEventArgs.NativeMethodInfoPtr__ctor_Public_Void_NotifyCollectionChangedAction_Object_Object_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600153E RID: 5438 RVA: 0x0006EDB4 File Offset: 0x0006CFB4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 466961, RefRangeEnd = 466963, XrefRangeStart = 466956, XrefRangeEnd = 466961, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction action, IList newItems, IList oldItems, int startingIndex)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NotifyCollectionChangedEventArgs>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref action;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(newItems);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(oldItems);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startingIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NotifyCollectionChangedEventArgs.NativeMethodInfoPtr__ctor_Public_Void_NotifyCollectionChangedAction_IList_IList_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600153F RID: 5439 RVA: 0x0006EE30 File Offset: 0x0006D030
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 466963, XrefRangeEnd = 466977, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitializeAddOrRemove(NotifyCollectionChangedAction action, IList changedItems, int startingIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref action;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(changedItems);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startingIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NotifyCollectionChangedEventArgs.NativeMethodInfoPtr_InitializeAddOrRemove_Private_Void_NotifyCollectionChangedAction_IList_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001540 RID: 5440 RVA: 0x0006EE90 File Offset: 0x0006D090
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 466977, XrefRangeEnd = 466984, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitializeAdd(NotifyCollectionChangedAction action, IList newItems, int newStartingIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref action;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(newItems);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref newStartingIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NotifyCollectionChangedEventArgs.NativeMethodInfoPtr_InitializeAdd_Private_Void_NotifyCollectionChangedAction_IList_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001541 RID: 5441 RVA: 0x0006EEF0 File Offset: 0x0006D0F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 466984, XrefRangeEnd = 466991, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitializeRemove(NotifyCollectionChangedAction action, IList oldItems, int oldStartingIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref action;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(oldItems);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref oldStartingIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NotifyCollectionChangedEventArgs.NativeMethodInfoPtr_InitializeRemove_Private_Void_NotifyCollectionChangedAction_IList_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001542 RID: 5442 RVA: 0x0006EF50 File Offset: 0x0006D150
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 467004, RefRangeEnd = 467006, XrefRangeStart = 466991, XrefRangeEnd = 467004, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitializeMoveOrReplace(NotifyCollectionChangedAction action, IList newItems, IList oldItems, int startingIndex, int oldStartingIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref action;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(newItems);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(oldItems);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startingIndex;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref oldStartingIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NotifyCollectionChangedEventArgs.NativeMethodInfoPtr_InitializeMoveOrReplace_Private_Void_NotifyCollectionChangedAction_IList_IList_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001543 RID: 5443 RVA: 0x0000958A File Offset: 0x0000778A
		public NotifyCollectionChangedEventArgs(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000636 RID: 1590
		// (get) Token: 0x06001544 RID: 5444 RVA: 0x0006EFD0 File Offset: 0x0006D1D0
		// (set) Token: 0x06001545 RID: 5445 RVA: 0x00009593 File Offset: 0x00007793
		public unsafe NotifyCollectionChangedAction _action
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NotifyCollectionChangedEventArgs.NativeFieldInfoPtr__action);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NotifyCollectionChangedEventArgs.NativeFieldInfoPtr__action)) = value;
			}
		}

		// Token: 0x17000637 RID: 1591
		// (get) Token: 0x06001546 RID: 5446 RVA: 0x0006EFF8 File Offset: 0x0006D1F8
		// (set) Token: 0x06001547 RID: 5447 RVA: 0x000095AE File Offset: 0x000077AE
		public unsafe IList _newItems
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NotifyCollectionChangedEventArgs.NativeFieldInfoPtr__newItems);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IList>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NotifyCollectionChangedEventArgs.NativeFieldInfoPtr__newItems), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000638 RID: 1592
		// (get) Token: 0x06001548 RID: 5448 RVA: 0x0006F028 File Offset: 0x0006D228
		// (set) Token: 0x06001549 RID: 5449 RVA: 0x000095CD File Offset: 0x000077CD
		public unsafe IList _oldItems
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NotifyCollectionChangedEventArgs.NativeFieldInfoPtr__oldItems);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IList>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NotifyCollectionChangedEventArgs.NativeFieldInfoPtr__oldItems), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000639 RID: 1593
		// (get) Token: 0x0600154A RID: 5450 RVA: 0x0006F058 File Offset: 0x0006D258
		// (set) Token: 0x0600154B RID: 5451 RVA: 0x000095EC File Offset: 0x000077EC
		public unsafe int _newStartingIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NotifyCollectionChangedEventArgs.NativeFieldInfoPtr__newStartingIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NotifyCollectionChangedEventArgs.NativeFieldInfoPtr__newStartingIndex)) = value;
			}
		}

		// Token: 0x1700063A RID: 1594
		// (get) Token: 0x0600154C RID: 5452 RVA: 0x0006F080 File Offset: 0x0006D280
		// (set) Token: 0x0600154D RID: 5453 RVA: 0x00009607 File Offset: 0x00007807
		public unsafe int _oldStartingIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NotifyCollectionChangedEventArgs.NativeFieldInfoPtr__oldStartingIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NotifyCollectionChangedEventArgs.NativeFieldInfoPtr__oldStartingIndex)) = value;
			}
		}

		// Token: 0x040010AC RID: 4268
		private static readonly IntPtr NativeFieldInfoPtr__action;

		// Token: 0x040010AD RID: 4269
		private static readonly IntPtr NativeFieldInfoPtr__newItems;

		// Token: 0x040010AE RID: 4270
		private static readonly IntPtr NativeFieldInfoPtr__oldItems;

		// Token: 0x040010AF RID: 4271
		private static readonly IntPtr NativeFieldInfoPtr__newStartingIndex;

		// Token: 0x040010B0 RID: 4272
		private static readonly IntPtr NativeFieldInfoPtr__oldStartingIndex;

		// Token: 0x040010B1 RID: 4273
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_NotifyCollectionChangedAction_0;

		// Token: 0x040010B2 RID: 4274
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_NotifyCollectionChangedAction_Object_Int32_0;

		// Token: 0x040010B3 RID: 4275
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_NotifyCollectionChangedAction_Object_Object_Int32_0;

		// Token: 0x040010B4 RID: 4276
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_NotifyCollectionChangedAction_IList_IList_Int32_0;

		// Token: 0x040010B5 RID: 4277
		private static readonly IntPtr NativeMethodInfoPtr_InitializeAddOrRemove_Private_Void_NotifyCollectionChangedAction_IList_Int32_0;

		// Token: 0x040010B6 RID: 4278
		private static readonly IntPtr NativeMethodInfoPtr_InitializeAdd_Private_Void_NotifyCollectionChangedAction_IList_Int32_0;

		// Token: 0x040010B7 RID: 4279
		private static readonly IntPtr NativeMethodInfoPtr_InitializeRemove_Private_Void_NotifyCollectionChangedAction_IList_Int32_0;

		// Token: 0x040010B8 RID: 4280
		private static readonly IntPtr NativeMethodInfoPtr_InitializeMoveOrReplace_Private_Void_NotifyCollectionChangedAction_IList_IList_Int32_Int32_0;
	}
}
