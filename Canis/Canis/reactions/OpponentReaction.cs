using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Canis.reactions
{
	// Token: 0x0200005D RID: 93
	public class OpponentReaction : Object
	{
		// Token: 0x06000561 RID: 1377 RVA: 0x0002E3D0 File Offset: 0x0002C5D0
		// Note: this type is marked as 'beforefieldinit'.
		static OpponentReaction()
		{
			Il2CppClassPointerStore<OpponentReaction>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.reactions", "OpponentReaction");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OpponentReaction>.NativeClassPtr);
			OpponentReaction.NativeFieldInfoPtr_Ability = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OpponentReaction>.NativeClassPtr, "Ability");
			OpponentReaction.NativeFieldInfoPtr_Source = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OpponentReaction>.NativeClassPtr, "Source");
			OpponentReaction.NativeFieldInfoPtr_Amount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OpponentReaction>.NativeClassPtr, "Amount");
			OpponentReaction.NativeFieldInfoPtr_Card = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OpponentReaction>.NativeClassPtr, "Card");
			OpponentReaction.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OpponentReaction>.NativeClassPtr, 100664415);
			OpponentReaction.NativeMethodInfoPtr__ctor_Public_Void_EntityID_EntityID_Int32_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OpponentReaction>.NativeClassPtr, 100664416);
			OpponentReaction.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OpponentReaction>.NativeClassPtr, 100664417);
		}

		// Token: 0x06000562 RID: 1378 RVA: 0x0002E48C File Offset: 0x0002C68C
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe OpponentReaction()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OpponentReaction>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OpponentReaction.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000563 RID: 1379 RVA: 0x0002E4C8 File Offset: 0x0002C6C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 554766, XrefRangeEnd = 554770, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe OpponentReaction(EntityID a, EntityID s, int am, EntityID card)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OpponentReaction>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(s);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref am;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(card);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OpponentReaction.NativeMethodInfoPtr__ctor_Public_Void_EntityID_EntityID_Int32_EntityID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000564 RID: 1380 RVA: 0x0002E548 File Offset: 0x0002C748
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 554770, XrefRangeEnd = 554776, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), OpponentReaction.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000565 RID: 1381 RVA: 0x000045A6 File Offset: 0x000027A6
		public OpponentReaction(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000163 RID: 355
		// (get) Token: 0x06000566 RID: 1382 RVA: 0x0002E58C File Offset: 0x0002C78C
		// (set) Token: 0x06000567 RID: 1383 RVA: 0x000045AF File Offset: 0x000027AF
		public unsafe EntityID Ability
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OpponentReaction.NativeFieldInfoPtr_Ability);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OpponentReaction.NativeFieldInfoPtr_Ability), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000164 RID: 356
		// (get) Token: 0x06000568 RID: 1384 RVA: 0x0002E5BC File Offset: 0x0002C7BC
		// (set) Token: 0x06000569 RID: 1385 RVA: 0x000045CE File Offset: 0x000027CE
		public unsafe EntityID Source
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OpponentReaction.NativeFieldInfoPtr_Source);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OpponentReaction.NativeFieldInfoPtr_Source), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000165 RID: 357
		// (get) Token: 0x0600056A RID: 1386 RVA: 0x0002E5EC File Offset: 0x0002C7EC
		// (set) Token: 0x0600056B RID: 1387 RVA: 0x000045ED File Offset: 0x000027ED
		public unsafe int Amount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OpponentReaction.NativeFieldInfoPtr_Amount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OpponentReaction.NativeFieldInfoPtr_Amount)) = value;
			}
		}

		// Token: 0x17000166 RID: 358
		// (get) Token: 0x0600056C RID: 1388 RVA: 0x0002E614 File Offset: 0x0002C814
		// (set) Token: 0x0600056D RID: 1389 RVA: 0x00004608 File Offset: 0x00002808
		public unsafe EntityID Card
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OpponentReaction.NativeFieldInfoPtr_Card);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OpponentReaction.NativeFieldInfoPtr_Card), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400036B RID: 875
		private static readonly IntPtr NativeFieldInfoPtr_Ability;

		// Token: 0x0400036C RID: 876
		private static readonly IntPtr NativeFieldInfoPtr_Source;

		// Token: 0x0400036D RID: 877
		private static readonly IntPtr NativeFieldInfoPtr_Amount;

		// Token: 0x0400036E RID: 878
		private static readonly IntPtr NativeFieldInfoPtr_Card;

		// Token: 0x0400036F RID: 879
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000370 RID: 880
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_EntityID_EntityID_Int32_EntityID_0;

		// Token: 0x04000371 RID: 881
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
	}
}
