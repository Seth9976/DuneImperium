using System;
using Canis.entities;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Canis.obfuscation
{
	// Token: 0x0200005E RID: 94
	[Serializable]
	public class DescendantsHidden : Object
	{
		// Token: 0x0600056E RID: 1390 RVA: 0x0002E644 File Offset: 0x0002C844
		// Note: this type is marked as 'beforefieldinit'.
		static DescendantsHidden()
		{
			Il2CppClassPointerStore<DescendantsHidden>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.obfuscation", "DescendantsHidden");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DescendantsHidden>.NativeClassPtr);
			DescendantsHidden.NativeFieldInfoPtr_DescendantsVisibility = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DescendantsHidden>.NativeClassPtr, "DescendantsVisibility");
			DescendantsHidden.NativeMethodInfoPtr_MakeVisibilityForDescendent_Public_Visibility_EntityID_EntityID_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DescendantsHidden>.NativeClassPtr, 100664418);
			DescendantsHidden.NativeMethodInfoPtr_MakeVisibilityForDescendent_Public_Visibility_Entity_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DescendantsHidden>.NativeClassPtr, 100664419);
			DescendantsHidden.NativeMethodInfoPtr_EntityChildrenHidden_Public_Boolean_EntityID_AccountID_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DescendantsHidden>.NativeClassPtr, 100664420);
			DescendantsHidden.NativeMethodInfoPtr_EntityChildrenHidden_Public_Boolean_Entity_AccountID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DescendantsHidden>.NativeClassPtr, 100664421);
			DescendantsHidden.NativeMethodInfoPtr_NumChildrenHidden_Public_Int32_EntityID_AccountID_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DescendantsHidden>.NativeClassPtr, 100664422);
			DescendantsHidden.NativeMethodInfoPtr_NumChildrenHidden_Public_Int32_Entity_AccountID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DescendantsHidden>.NativeClassPtr, 100664423);
			DescendantsHidden.NativeMethodInfoPtr_get_Public_Public_Static_get_DescendantsHidden_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DescendantsHidden>.NativeClassPtr, 100664424);
			DescendantsHidden.NativeMethodInfoPtr_get_DeckStyle_Public_Static_get_DescendantsHidden_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DescendantsHidden>.NativeClassPtr, 100664425);
			DescendantsHidden.NativeMethodInfoPtr_HandStyle_Public_Static_DescendantsHidden_AccountID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DescendantsHidden>.NativeClassPtr, 100664426);
			DescendantsHidden.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DescendantsHidden>.NativeClassPtr, 100664427);
		}

		// Token: 0x0600056F RID: 1391 RVA: 0x0002E750 File Offset: 0x0002C950
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 554776, XrefRangeEnd = 554777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Visibility MakeVisibilityForDescendent(EntityID ancestor, EntityID descendent, Match match)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ancestor);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(descendent);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(match);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DescendantsHidden.NativeMethodInfoPtr_MakeVisibilityForDescendent_Public_Visibility_EntityID_EntityID_Match_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Visibility>(intPtr3) : null;
		}

		// Token: 0x06000570 RID: 1392 RVA: 0x0002E7C4 File Offset: 0x0002C9C4
		[CallerCount(0)]
		public unsafe Visibility MakeVisibilityForDescendent(Entity ancestor, Entity descendent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ancestor);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(descendent);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DescendantsHidden.NativeMethodInfoPtr_MakeVisibilityForDescendent_Public_Visibility_Entity_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Visibility>(intPtr3) : null;
		}

		// Token: 0x06000571 RID: 1393 RVA: 0x0002E828 File Offset: 0x0002CA28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 554777, XrefRangeEnd = 554778, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool EntityChildrenHidden(EntityID parent, AccountID perspective, Match match)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(parent);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(perspective);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(match);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DescendantsHidden.NativeMethodInfoPtr_EntityChildrenHidden_Public_Boolean_EntityID_AccountID_Match_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000572 RID: 1394 RVA: 0x0002E89C File Offset: 0x0002CA9C
		[CallerCount(0)]
		public unsafe bool EntityChildrenHidden(Entity parent, AccountID perspective)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(parent);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(perspective);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DescendantsHidden.NativeMethodInfoPtr_EntityChildrenHidden_Public_Boolean_Entity_AccountID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000573 RID: 1395 RVA: 0x0002E8FC File Offset: 0x0002CAFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 554778, XrefRangeEnd = 554779, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int NumChildrenHidden(EntityID parent, AccountID perspective, Match match)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(parent);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(perspective);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(match);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DescendantsHidden.NativeMethodInfoPtr_NumChildrenHidden_Public_Int32_EntityID_AccountID_Match_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000574 RID: 1396 RVA: 0x0002E970 File Offset: 0x0002CB70
		[CallerCount(0)]
		public unsafe int NumChildrenHidden(Entity parent, AccountID perspective)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(parent);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(perspective);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DescendantsHidden.NativeMethodInfoPtr_NumChildrenHidden_Public_Int32_Entity_AccountID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000168 RID: 360
		// (get) Token: 0x06000575 RID: 1397 RVA: 0x0002E9D0 File Offset: 0x0002CBD0
		public unsafe static DescendantsHidden Public
		{
			[CallerCount(37)]
			[CachedScanResults(RefRangeStart = 554788, RefRangeEnd = 554825, XrefRangeStart = 554779, XrefRangeEnd = 554788, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DescendantsHidden.NativeMethodInfoPtr_get_Public_Public_Static_get_DescendantsHidden_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DescendantsHidden>(intPtr3) : null;
			}
		}

		// Token: 0x17000169 RID: 361
		// (get) Token: 0x06000576 RID: 1398 RVA: 0x0002EA04 File Offset: 0x0002CC04
		public unsafe static DescendantsHidden DeckStyle
		{
			[CallerCount(9)]
			[CachedScanResults(RefRangeStart = 554834, RefRangeEnd = 554843, XrefRangeStart = 554825, XrefRangeEnd = 554834, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DescendantsHidden.NativeMethodInfoPtr_get_DeckStyle_Public_Static_get_DescendantsHidden_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DescendantsHidden>(intPtr3) : null;
			}
		}

		// Token: 0x06000577 RID: 1399 RVA: 0x0002EA38 File Offset: 0x0002CC38
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 554862, RefRangeEnd = 554863, XrefRangeStart = 554843, XrefRangeEnd = 554862, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DescendantsHidden HandStyle(AccountID accountID)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(accountID);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DescendantsHidden.NativeMethodInfoPtr_HandStyle_Public_Static_DescendantsHidden_AccountID_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DescendantsHidden>(intPtr3) : null;
			}
		}

		// Token: 0x06000578 RID: 1400 RVA: 0x0002EA7C File Offset: 0x0002CC7C
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DescendantsHidden()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DescendantsHidden>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DescendantsHidden.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000579 RID: 1401 RVA: 0x00004627 File Offset: 0x00002827
		public DescendantsHidden(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000167 RID: 359
		// (get) Token: 0x0600057A RID: 1402 RVA: 0x0002EAB8 File Offset: 0x0002CCB8
		// (set) Token: 0x0600057B RID: 1403 RVA: 0x00004630 File Offset: 0x00002830
		public unsafe DescendantsVisibility DescendantsVisibility
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DescendantsHidden.NativeFieldInfoPtr_DescendantsVisibility);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DescendantsVisibility>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DescendantsHidden.NativeFieldInfoPtr_DescendantsVisibility), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000372 RID: 882
		private static readonly IntPtr NativeFieldInfoPtr_DescendantsVisibility;

		// Token: 0x04000373 RID: 883
		private static readonly IntPtr NativeMethodInfoPtr_MakeVisibilityForDescendent_Public_Visibility_EntityID_EntityID_Match_0;

		// Token: 0x04000374 RID: 884
		private static readonly IntPtr NativeMethodInfoPtr_MakeVisibilityForDescendent_Public_Visibility_Entity_Entity_0;

		// Token: 0x04000375 RID: 885
		private static readonly IntPtr NativeMethodInfoPtr_EntityChildrenHidden_Public_Boolean_EntityID_AccountID_Match_0;

		// Token: 0x04000376 RID: 886
		private static readonly IntPtr NativeMethodInfoPtr_EntityChildrenHidden_Public_Boolean_Entity_AccountID_0;

		// Token: 0x04000377 RID: 887
		private static readonly IntPtr NativeMethodInfoPtr_NumChildrenHidden_Public_Int32_EntityID_AccountID_Match_0;

		// Token: 0x04000378 RID: 888
		private static readonly IntPtr NativeMethodInfoPtr_NumChildrenHidden_Public_Int32_Entity_AccountID_0;

		// Token: 0x04000379 RID: 889
		private static readonly IntPtr NativeMethodInfoPtr_get_Public_Public_Static_get_DescendantsHidden_0;

		// Token: 0x0400037A RID: 890
		private static readonly IntPtr NativeMethodInfoPtr_get_DeckStyle_Public_Static_get_DescendantsHidden_0;

		// Token: 0x0400037B RID: 891
		private static readonly IntPtr NativeMethodInfoPtr_HandStyle_Public_Static_DescendantsHidden_AccountID_0;

		// Token: 0x0400037C RID: 892
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
