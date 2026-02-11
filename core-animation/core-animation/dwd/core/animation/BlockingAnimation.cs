using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace dwd.core.animation
{
	// Token: 0x02000004 RID: 4
	public class BlockingAnimation : MonoBehaviour
	{
		// Token: 0x0600000C RID: 12 RVA: 0x00002DAC File Offset: 0x00000FAC
		// Note: this type is marked as 'beforefieldinit'.
		static BlockingAnimation()
		{
			Il2CppClassPointerStore<BlockingAnimation>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-animation.dll", "dwd.core.animation", "BlockingAnimation");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BlockingAnimation>.NativeClassPtr);
			BlockingAnimation.NativeFieldInfoPtr__Blocking_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlockingAnimation>.NativeClassPtr, "<Blocking>k__BackingField");
			BlockingAnimation.NativeMethodInfoPtr_get_Blocking_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlockingAnimation>.NativeClassPtr, 100663302);
			BlockingAnimation.NativeMethodInfoPtr_set_Blocking_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlockingAnimation>.NativeClassPtr, 100663303);
			BlockingAnimation.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlockingAnimation>.NativeClassPtr, 100663304);
			BlockingAnimation.NativeMethodInfoPtr_UnblockAnimation_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlockingAnimation>.NativeClassPtr, 100663305);
			BlockingAnimation.NativeMethodInfoPtr_Event_Unblock_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlockingAnimation>.NativeClassPtr, 100663306);
			BlockingAnimation.NativeMethodInfoPtr_BlockAnimation_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlockingAnimation>.NativeClassPtr, 100663307);
			BlockingAnimation.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlockingAnimation>.NativeClassPtr, 100663308);
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x0600000D RID: 13 RVA: 0x00002E7C File Offset: 0x0000107C
		// (set) Token: 0x0600000E RID: 14 RVA: 0x00002EB8 File Offset: 0x000010B8
		public unsafe bool Blocking
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 308625, RefRangeEnd = 308626, XrefRangeStart = 308625, XrefRangeEnd = 308626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlockingAnimation.NativeMethodInfoPtr_get_Blocking_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlockingAnimation.NativeMethodInfoPtr_set_Blocking_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600000F RID: 15 RVA: 0x00002EF8 File Offset: 0x000010F8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 497606, RefRangeEnd = 497607, XrefRangeStart = 497606, XrefRangeEnd = 497607, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlockingAnimation.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000010 RID: 16 RVA: 0x00002F2C File Offset: 0x0000112C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 497606, RefRangeEnd = 497607, XrefRangeStart = 497606, XrefRangeEnd = 497607, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UnblockAnimation()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlockingAnimation.NativeMethodInfoPtr_UnblockAnimation_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000011 RID: 17 RVA: 0x00002F60 File Offset: 0x00001160
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 497606, RefRangeEnd = 497607, XrefRangeStart = 497606, XrefRangeEnd = 497607, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_Unblock()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlockingAnimation.NativeMethodInfoPtr_Event_Unblock_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000012 RID: 18 RVA: 0x00002F94 File Offset: 0x00001194
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1263133, RefRangeEnd = 1263136, XrefRangeStart = 1263125, XrefRangeEnd = 1263133, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BlockAnimation()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlockingAnimation.NativeMethodInfoPtr_BlockAnimation_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000013 RID: 19 RVA: 0x00002FC8 File Offset: 0x000011C8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 506167, RefRangeEnd = 506168, XrefRangeStart = 506167, XrefRangeEnd = 506168, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BlockingAnimation()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BlockingAnimation>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlockingAnimation.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000014 RID: 20 RVA: 0x00002081 File Offset: 0x00000281
		public BlockingAnimation(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000015 RID: 21 RVA: 0x00003004 File Offset: 0x00001204
		// (set) Token: 0x06000016 RID: 22 RVA: 0x0000208A File Offset: 0x0000028A
		public unsafe bool _Blocking_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlockingAnimation.NativeFieldInfoPtr__Blocking_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlockingAnimation.NativeFieldInfoPtr__Blocking_k__BackingField)) = value;
			}
		}

		// Token: 0x04000007 RID: 7
		private static readonly IntPtr NativeFieldInfoPtr__Blocking_k__BackingField;

		// Token: 0x04000008 RID: 8
		private static readonly IntPtr NativeMethodInfoPtr_get_Blocking_Public_get_Boolean_0;

		// Token: 0x04000009 RID: 9
		private static readonly IntPtr NativeMethodInfoPtr_set_Blocking_Public_set_Void_Boolean_0;

		// Token: 0x0400000A RID: 10
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;

		// Token: 0x0400000B RID: 11
		private static readonly IntPtr NativeMethodInfoPtr_UnblockAnimation_Public_Void_0;

		// Token: 0x0400000C RID: 12
		private static readonly IntPtr NativeMethodInfoPtr_Event_Unblock_Public_Void_0;

		// Token: 0x0400000D RID: 13
		private static readonly IntPtr NativeMethodInfoPtr_BlockAnimation_Public_Void_0;

		// Token: 0x0400000E RID: 14
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
