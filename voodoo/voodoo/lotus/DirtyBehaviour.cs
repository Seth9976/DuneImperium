using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace lotus
{
	// Token: 0x0200004C RID: 76
	public class DirtyBehaviour : MonoBehaviour
	{
		// Token: 0x060004A0 RID: 1184 RVA: 0x00018508 File Offset: 0x00016708
		// Note: this type is marked as 'beforefieldinit'.
		static DirtyBehaviour()
		{
			Il2CppClassPointerStore<DirtyBehaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("voodoo.dll", "lotus", "DirtyBehaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DirtyBehaviour>.NativeClassPtr);
			DirtyBehaviour.NativeFieldInfoPtr_dirtyNode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DirtyBehaviour>.NativeClassPtr, "dirtyNode");
			DirtyBehaviour.NativeMethodInfoPtr_DirtyUpdate_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DirtyBehaviour>.NativeClassPtr, 100663842);
			DirtyBehaviour.NativeMethodInfoPtr_get_DirtyNode_Public_Virtual_Final_New_get_LinkedListNode_1_IAmDirty_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DirtyBehaviour>.NativeClassPtr, 100663843);
			DirtyBehaviour.NativeMethodInfoPtr_set_DirtyNode_Private_set_Void_LinkedListNode_1_IAmDirty_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DirtyBehaviour>.NativeClassPtr, 100663844);
			DirtyBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DirtyBehaviour>.NativeClassPtr, 100663845);
		}

		// Token: 0x060004A1 RID: 1185 RVA: 0x0001859C File Offset: 0x0001679C
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void DirtyUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DirtyBehaviour.NativeMethodInfoPtr_DirtyUpdate_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000181 RID: 385
		// (get) Token: 0x060004A2 RID: 1186 RVA: 0x000185D8 File Offset: 0x000167D8
		// (set) Token: 0x060004A3 RID: 1187 RVA: 0x00018618 File Offset: 0x00016818
		public unsafe virtual LinkedListNode<IAmDirty> DirtyNode
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1110621, XrefRangeEnd = 1110628, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DirtyBehaviour.NativeMethodInfoPtr_get_DirtyNode_Public_Virtual_Final_New_get_LinkedListNode_1_IAmDirty_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<LinkedListNode<IAmDirty>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DirtyBehaviour.NativeMethodInfoPtr_set_DirtyNode_Private_set_Void_LinkedListNode_1_IAmDirty_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060004A4 RID: 1188 RVA: 0x0001865C File Offset: 0x0001685C
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DirtyBehaviour()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DirtyBehaviour>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DirtyBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004A5 RID: 1189 RVA: 0x000045A1 File Offset: 0x000027A1
		public DirtyBehaviour(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000180 RID: 384
		// (get) Token: 0x060004A6 RID: 1190 RVA: 0x00018698 File Offset: 0x00016898
		// (set) Token: 0x060004A7 RID: 1191 RVA: 0x000045AA File Offset: 0x000027AA
		public unsafe LinkedListNode<IAmDirty> dirtyNode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DirtyBehaviour.NativeFieldInfoPtr_dirtyNode);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LinkedListNode<IAmDirty>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DirtyBehaviour.NativeFieldInfoPtr_dirtyNode), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040002DF RID: 735
		private static readonly IntPtr NativeFieldInfoPtr_dirtyNode;

		// Token: 0x040002E0 RID: 736
		private static readonly IntPtr NativeMethodInfoPtr_DirtyUpdate_Public_Virtual_New_Void_0;

		// Token: 0x040002E1 RID: 737
		private static readonly IntPtr NativeMethodInfoPtr_get_DirtyNode_Public_Virtual_Final_New_get_LinkedListNode_1_IAmDirty_0;

		// Token: 0x040002E2 RID: 738
		private static readonly IntPtr NativeMethodInfoPtr_set_DirtyNode_Private_set_Void_LinkedListNode_1_IAmDirty_0;

		// Token: 0x040002E3 RID: 739
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
