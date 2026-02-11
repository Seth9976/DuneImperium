using System;
using dwd.core.match.selection;
using dwd.core.session;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using Networking.selection.targetinformation;
using tc.selection;

namespace boardgames.match.selection
{
	// Token: 0x0200012B RID: 299
	public class CanisSelectionNodeFactory : SelectionNodeFactory
	{
		// Token: 0x06000FA6 RID: 4006 RVA: 0x00040C04 File Offset: 0x0003EE04
		// Note: this type is marked as 'beforefieldinit'.
		static CanisSelectionNodeFactory()
		{
			Il2CppClassPointerStore<CanisSelectionNodeFactory>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "boardgames.match.selection", "CanisSelectionNodeFactory");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CanisSelectionNodeFactory>.NativeClassPtr);
			CanisSelectionNodeFactory.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanisSelectionNodeFactory>.NativeClassPtr, 100665530);
			CanisSelectionNodeFactory.NativeMethodInfoPtr_createEntityGrouping_Private_EntityGroupingTargetNode_TargetInformation_Boolean_ISelectionRoot_ISelectionNode_IEnumerable_1_TargetInformation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanisSelectionNodeFactory>.NativeClassPtr, 100665531);
			CanisSelectionNodeFactory.NativeMethodInfoPtr_get_SessionWriter_Public_Virtual_get_IAccountSessionWriter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanisSelectionNodeFactory>.NativeClassPtr, 100665532);
		}

		// Token: 0x06000FA7 RID: 4007 RVA: 0x00040C70 File Offset: 0x0003EE70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 998074, XrefRangeEnd = 998091, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CanisSelectionNodeFactory()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CanisSelectionNodeFactory>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanisSelectionNodeFactory.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FA8 RID: 4008 RVA: 0x00040CAC File Offset: 0x0003EEAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 998091, XrefRangeEnd = 998098, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EntityGroupingTargetNode createEntityGrouping(TargetInformation info, bool mayCancel, ISelectionRoot root, ISelectionNode parent, IEnumerable<TargetInformation> subsequent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mayCancel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(root);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parent);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(subsequent);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanisSelectionNodeFactory.NativeMethodInfoPtr_createEntityGrouping_Private_EntityGroupingTargetNode_TargetInformation_Boolean_ISelectionRoot_ISelectionNode_IEnumerable_1_TargetInformation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<EntityGroupingTargetNode>(intPtr3) : null;
		}

		// Token: 0x1700047B RID: 1147
		// (get) Token: 0x06000FA9 RID: 4009 RVA: 0x00040D44 File Offset: 0x0003EF44
		public unsafe override IAccountSessionWriter SessionWriter
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 998098, XrefRangeEnd = 998102, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CanisSelectionNodeFactory.NativeMethodInfoPtr_get_SessionWriter_Public_Virtual_get_IAccountSessionWriter_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAccountSessionWriter>(intPtr3) : null;
			}
		}

		// Token: 0x06000FAA RID: 4010 RVA: 0x000094C6 File Offset: 0x000076C6
		public CanisSelectionNodeFactory(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000984 RID: 2436
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000985 RID: 2437
		private static readonly IntPtr NativeMethodInfoPtr_createEntityGrouping_Private_EntityGroupingTargetNode_TargetInformation_Boolean_ISelectionRoot_ISelectionNode_IEnumerable_1_TargetInformation_0;

		// Token: 0x04000986 RID: 2438
		private static readonly IntPtr NativeMethodInfoPtr_get_SessionWriter_Public_Virtual_get_IAccountSessionWriter_0;
	}
}
