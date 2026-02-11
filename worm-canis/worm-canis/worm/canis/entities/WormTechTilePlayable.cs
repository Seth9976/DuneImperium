using System;
using Canis;
using canis.archetypes;
using Canis.entities;
using Canis.entities.ai;
using Canis.messages;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.canis.entities
{
	// Token: 0x02000038 RID: 56
	public class WormTechTilePlayable : WormPlayable
	{
		// Token: 0x060004E4 RID: 1252 RVA: 0x0007D950 File Offset: 0x0007BB50
		// Note: this type is marked as 'beforefieldinit'.
		static WormTechTilePlayable()
		{
			Il2CppClassPointerStore<WormTechTilePlayable>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.entities", "WormTechTilePlayable");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormTechTilePlayable>.NativeClassPtr);
			WormTechTilePlayable.NativeMethodInfoPtr__ctor_Public_Void_Match_PlayerEntity_Archetype_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTechTilePlayable>.NativeClassPtr, 100664641);
			WormTechTilePlayable.NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_Match_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTechTilePlayable>.NativeClassPtr, 100664642);
			WormTechTilePlayable.NativeMethodInfoPtr_get_IsFlipped_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTechTilePlayable>.NativeClassPtr, 100664643);
			WormTechTilePlayable.NativeMethodInfoPtr_get_IsFaceUp_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTechTilePlayable>.NativeClassPtr, 100664644);
			WormTechTilePlayable.NativeMethodInfoPtr_get_IsHagalTech_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTechTilePlayable>.NativeClassPtr, 100664645);
			WormTechTilePlayable.NativeMethodInfoPtr_AcquireValue_Public_AIValueSummer_1_Double_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTechTilePlayable>.NativeClassPtr, 100664646);
			WormTechTilePlayable.NativeMethodInfoPtr_IsInPlay_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTechTilePlayable>.NativeClassPtr, 100664647);
		}

		// Token: 0x060004E5 RID: 1253 RVA: 0x0007DA0C File Offset: 0x0007BC0C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 47964, RefRangeEnd = 47965, XrefRangeStart = 47958, XrefRangeEnd = 47964, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormTechTilePlayable(Match m, PlayerEntity owner, Archetype arch)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormTechTilePlayable>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(owner);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(arch);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTechTilePlayable.NativeMethodInfoPtr__ctor_Public_Void_Match_PlayerEntity_Archetype_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004E6 RID: 1254 RVA: 0x0007DA7C File Offset: 0x0007BC7C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 47966, RefRangeEnd = 47968, XrefRangeStart = 47965, XrefRangeEnd = 47966, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormTechTilePlayable(SerializedEntity se, Match m, Entity parent)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormTechTilePlayable>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(se);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(m);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parent);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTechTilePlayable.NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_Match_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000187 RID: 391
		// (get) Token: 0x060004E7 RID: 1255 RVA: 0x0007DAEC File Offset: 0x0007BCEC
		public unsafe bool IsFlipped
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 47975, RefRangeEnd = 47976, XrefRangeStart = 47968, XrefRangeEnd = 47975, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTechTilePlayable.NativeMethodInfoPtr_get_IsFlipped_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000188 RID: 392
		// (get) Token: 0x060004E8 RID: 1256 RVA: 0x0007DB28 File Offset: 0x0007BD28
		public unsafe bool IsFaceUp
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 47983, RefRangeEnd = 47984, XrefRangeStart = 47976, XrefRangeEnd = 47983, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTechTilePlayable.NativeMethodInfoPtr_get_IsFaceUp_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000189 RID: 393
		// (get) Token: 0x060004E9 RID: 1257 RVA: 0x0007DB64 File Offset: 0x0007BD64
		public unsafe bool IsHagalTech
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 48001, RefRangeEnd = 48002, XrefRangeStart = 47984, XrefRangeEnd = 48001, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTechTilePlayable.NativeMethodInfoPtr_get_IsHagalTech_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060004EA RID: 1258 RVA: 0x0007DBA0 File Offset: 0x0007BDA0
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 48054, RefRangeEnd = 48061, XrefRangeStart = 48002, XrefRangeEnd = 48054, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AIValueSummer<double> AcquireValue(WormPlayer forPlayer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(forPlayer);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTechTilePlayable.NativeMethodInfoPtr_AcquireValue_Public_AIValueSummer_1_Double_WormPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AIValueSummer<double>>(intPtr3) : null;
			}
		}

		// Token: 0x060004EB RID: 1259 RVA: 0x0007DBF0 File Offset: 0x0007BDF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 48061, XrefRangeEnd = 48065, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool IsInPlay()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormTechTilePlayable.NativeMethodInfoPtr_IsInPlay_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060004EC RID: 1260 RVA: 0x00003CE2 File Offset: 0x00001EE2
		public WormTechTilePlayable(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000398 RID: 920
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Match_PlayerEntity_Archetype_0;

		// Token: 0x04000399 RID: 921
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_Match_Entity_0;

		// Token: 0x0400039A RID: 922
		private static readonly IntPtr NativeMethodInfoPtr_get_IsFlipped_Public_get_Boolean_0;

		// Token: 0x0400039B RID: 923
		private static readonly IntPtr NativeMethodInfoPtr_get_IsFaceUp_Public_get_Boolean_0;

		// Token: 0x0400039C RID: 924
		private static readonly IntPtr NativeMethodInfoPtr_get_IsHagalTech_Public_get_Boolean_0;

		// Token: 0x0400039D RID: 925
		private static readonly IntPtr NativeMethodInfoPtr_AcquireValue_Public_AIValueSummer_1_Double_WormPlayer_0;

		// Token: 0x0400039E RID: 926
		private static readonly IntPtr NativeMethodInfoPtr_IsInPlay_Public_Virtual_Boolean_0;
	}
}
