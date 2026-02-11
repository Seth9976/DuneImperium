using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace Canis.obfuscation
{
	// Token: 0x02000062 RID: 98
	public class AsymmetricDescendantsHidden : DescendantsVisibility
	{
		// Token: 0x0600058F RID: 1423 RVA: 0x0002F22C File Offset: 0x0002D42C
		// Note: this type is marked as 'beforefieldinit'.
		static AsymmetricDescendantsHidden()
		{
			Il2CppClassPointerStore<AsymmetricDescendantsHidden>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.obfuscation", "AsymmetricDescendantsHidden");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AsymmetricDescendantsHidden>.NativeClassPtr);
			AsymmetricDescendantsHidden.NativeFieldInfoPtr_OtherHidden = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsymmetricDescendantsHidden>.NativeClassPtr, "OtherHidden");
			AsymmetricDescendantsHidden.NativeFieldInfoPtr_visibility = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsymmetricDescendantsHidden>.NativeClassPtr, "visibility");
			AsymmetricDescendantsHidden.NativeMethodInfoPtr_WithOtherVisible_Public_AsymmetricDescendantsHidden_AccountID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsymmetricDescendantsHidden>.NativeClassPtr, 100664449);
			AsymmetricDescendantsHidden.NativeMethodInfoPtr_MakeVisibilityForDescendent_Public_Virtual_Visibility_EntityID_EntityID_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsymmetricDescendantsHidden>.NativeClassPtr, 100664450);
			AsymmetricDescendantsHidden.NativeMethodInfoPtr_EntityChildrenHidden_Public_Virtual_Boolean_EntityID_AccountID_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsymmetricDescendantsHidden>.NativeClassPtr, 100664451);
			AsymmetricDescendantsHidden.NativeMethodInfoPtr_NumChildrenHidden_Public_Virtual_Int32_EntityID_AccountID_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsymmetricDescendantsHidden>.NativeClassPtr, 100664452);
			AsymmetricDescendantsHidden.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsymmetricDescendantsHidden>.NativeClassPtr, 100664453);
		}

		// Token: 0x06000590 RID: 1424 RVA: 0x0002F2E8 File Offset: 0x0002D4E8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 554890, RefRangeEnd = 554891, XrefRangeStart = 554887, XrefRangeEnd = 554890, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AsymmetricDescendantsHidden WithOtherVisible(AccountID accountID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(accountID);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsymmetricDescendantsHidden.NativeMethodInfoPtr_WithOtherVisible_Public_AsymmetricDescendantsHidden_AccountID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AsymmetricDescendantsHidden>(intPtr3) : null;
			}
		}

		// Token: 0x06000591 RID: 1425 RVA: 0x0002F338 File Offset: 0x0002D538
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 554891, XrefRangeEnd = 554915, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Visibility MakeVisibilityForDescendent(EntityID ancestor, EntityID descendent, Match match)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AsymmetricDescendantsHidden.NativeMethodInfoPtr_MakeVisibilityForDescendent_Public_Virtual_Visibility_EntityID_EntityID_Match_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Visibility>(intPtr3) : null;
		}

		// Token: 0x06000592 RID: 1426 RVA: 0x0002F3B8 File Offset: 0x0002D5B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 554915, XrefRangeEnd = 554918, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool EntityChildrenHidden(EntityID parent, AccountID perspective, Match match)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AsymmetricDescendantsHidden.NativeMethodInfoPtr_EntityChildrenHidden_Public_Virtual_Boolean_EntityID_AccountID_Match_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000593 RID: 1427 RVA: 0x0002F434 File Offset: 0x0002D634
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 554918, XrefRangeEnd = 554925, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int NumChildrenHidden(EntityID parent, AccountID perspective, Match match)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AsymmetricDescendantsHidden.NativeMethodInfoPtr_NumChildrenHidden_Public_Virtual_Int32_EntityID_AccountID_Match_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000594 RID: 1428 RVA: 0x0002F4B0 File Offset: 0x0002D6B0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 554933, RefRangeEnd = 554934, XrefRangeStart = 554925, XrefRangeEnd = 554933, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AsymmetricDescendantsHidden()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AsymmetricDescendantsHidden>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsymmetricDescendantsHidden.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000595 RID: 1429 RVA: 0x0000466A File Offset: 0x0000286A
		public AsymmetricDescendantsHidden(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700016A RID: 362
		// (get) Token: 0x06000596 RID: 1430 RVA: 0x0002F4EC File Offset: 0x0002D6EC
		// (set) Token: 0x06000597 RID: 1431 RVA: 0x00004673 File Offset: 0x00002873
		public unsafe Dictionary<AccountID, bool> OtherHidden
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsymmetricDescendantsHidden.NativeFieldInfoPtr_OtherHidden);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<AccountID, bool>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsymmetricDescendantsHidden.NativeFieldInfoPtr_OtherHidden), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700016B RID: 363
		// (get) Token: 0x06000598 RID: 1432 RVA: 0x0002F51C File Offset: 0x0002D71C
		// (set) Token: 0x06000599 RID: 1433 RVA: 0x00004692 File Offset: 0x00002892
		public unsafe Visibility visibility
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsymmetricDescendantsHidden.NativeFieldInfoPtr_visibility);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Visibility>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsymmetricDescendantsHidden.NativeFieldInfoPtr_visibility), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400038A RID: 906
		private static readonly IntPtr NativeFieldInfoPtr_OtherHidden;

		// Token: 0x0400038B RID: 907
		private static readonly IntPtr NativeFieldInfoPtr_visibility;

		// Token: 0x0400038C RID: 908
		private static readonly IntPtr NativeMethodInfoPtr_WithOtherVisible_Public_AsymmetricDescendantsHidden_AccountID_0;

		// Token: 0x0400038D RID: 909
		private static readonly IntPtr NativeMethodInfoPtr_MakeVisibilityForDescendent_Public_Virtual_Visibility_EntityID_EntityID_Match_0;

		// Token: 0x0400038E RID: 910
		private static readonly IntPtr NativeMethodInfoPtr_EntityChildrenHidden_Public_Virtual_Boolean_EntityID_AccountID_Match_0;

		// Token: 0x0400038F RID: 911
		private static readonly IntPtr NativeMethodInfoPtr_NumChildrenHidden_Public_Virtual_Int32_EntityID_AccountID_Match_0;

		// Token: 0x04000390 RID: 912
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
