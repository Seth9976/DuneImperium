using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Canis.obfuscation
{
	// Token: 0x02000061 RID: 97
	public class AllDescendantsHidden : DescendantsVisibility
	{
		// Token: 0x06000589 RID: 1417 RVA: 0x0002EFF8 File Offset: 0x0002D1F8
		// Note: this type is marked as 'beforefieldinit'.
		static AllDescendantsHidden()
		{
			Il2CppClassPointerStore<AllDescendantsHidden>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.obfuscation", "AllDescendantsHidden");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AllDescendantsHidden>.NativeClassPtr);
			AllDescendantsHidden.NativeMethodInfoPtr_MakeVisibilityForDescendent_Public_Virtual_Visibility_EntityID_EntityID_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AllDescendantsHidden>.NativeClassPtr, 100664445);
			AllDescendantsHidden.NativeMethodInfoPtr_EntityChildrenHidden_Public_Virtual_Boolean_EntityID_AccountID_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AllDescendantsHidden>.NativeClassPtr, 100664446);
			AllDescendantsHidden.NativeMethodInfoPtr_NumChildrenHidden_Public_Virtual_Int32_EntityID_AccountID_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AllDescendantsHidden>.NativeClassPtr, 100664447);
			AllDescendantsHidden.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AllDescendantsHidden>.NativeClassPtr, 100664448);
		}

		// Token: 0x0600058A RID: 1418 RVA: 0x0002F078 File Offset: 0x0002D278
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 554879, XrefRangeEnd = 554883, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AllDescendantsHidden.NativeMethodInfoPtr_MakeVisibilityForDescendent_Public_Virtual_Visibility_EntityID_EntityID_Match_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Visibility>(intPtr3) : null;
		}

		// Token: 0x0600058B RID: 1419 RVA: 0x0002F0F8 File Offset: 0x0002D2F8
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 25017, RefRangeEnd = 25031, XrefRangeStart = 25017, XrefRangeEnd = 25031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AllDescendantsHidden.NativeMethodInfoPtr_EntityChildrenHidden_Public_Virtual_Boolean_EntityID_AccountID_Match_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600058C RID: 1420 RVA: 0x0002F174 File Offset: 0x0002D374
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 554883, XrefRangeEnd = 554887, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AllDescendantsHidden.NativeMethodInfoPtr_NumChildrenHidden_Public_Virtual_Int32_EntityID_AccountID_Match_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600058D RID: 1421 RVA: 0x0002F1F0 File Offset: 0x0002D3F0
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AllDescendantsHidden()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AllDescendantsHidden>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AllDescendantsHidden.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600058E RID: 1422 RVA: 0x00004661 File Offset: 0x00002861
		public AllDescendantsHidden(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000386 RID: 902
		private static readonly IntPtr NativeMethodInfoPtr_MakeVisibilityForDescendent_Public_Virtual_Visibility_EntityID_EntityID_Match_0;

		// Token: 0x04000387 RID: 903
		private static readonly IntPtr NativeMethodInfoPtr_EntityChildrenHidden_Public_Virtual_Boolean_EntityID_AccountID_Match_0;

		// Token: 0x04000388 RID: 904
		private static readonly IntPtr NativeMethodInfoPtr_NumChildrenHidden_Public_Virtual_Int32_EntityID_AccountID_Match_0;

		// Token: 0x04000389 RID: 905
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
