using System;
using boardgames.match.selection;
using Canis.utils.ids;
using dwd.core.match.selection;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using lotus;
using UnityEngine.UI;

namespace worm.match.commands.selectionCommands
{
	// Token: 0x0200027D RID: 637
	public class WormGraftCardCommand : DBGBasicEntityListSelectionCommand
	{
		// Token: 0x06001A11 RID: 6673 RVA: 0x00068200 File Offset: 0x00066400
		// Note: this type is marked as 'beforefieldinit'.
		static WormGraftCardCommand()
		{
			Il2CppClassPointerStore<WormGraftCardCommand>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.commands.selectionCommands", "WormGraftCardCommand");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormGraftCardCommand>.NativeClassPtr);
			WormGraftCardCommand.NativeMethodInfoPtr__ctor_Public_Void_ISelectionNode_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormGraftCardCommand>.NativeClassPtr, 100667086);
			WormGraftCardCommand.NativeMethodInfoPtr_enterNode_Protected_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormGraftCardCommand>.NativeClassPtr, 100667087);
			WormGraftCardCommand.NativeMethodInfoPtr_enterNodeHints_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormGraftCardCommand>.NativeClassPtr, 100667088);
			WormGraftCardCommand.NativeMethodInfoPtr_resetHints_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormGraftCardCommand>.NativeClassPtr, 100667089);
			WormGraftCardCommand.NativeMethodInfoPtr_GetHintedEntities_Private_IEnumerable_1_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormGraftCardCommand>.NativeClassPtr, 100667090);
		}

		// Token: 0x06001A12 RID: 6674 RVA: 0x00068294 File Offset: 0x00066494
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormGraftCardCommand(ISelectionNode node, bool fromCancel)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormGraftCardCommand>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fromCancel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormGraftCardCommand.NativeMethodInfoPtr__ctor_Public_Void_ISelectionNode_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A13 RID: 6675 RVA: 0x000682F0 File Offset: 0x000664F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 722110, XrefRangeEnd = 722168, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void enterNode(bool fromCancel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref fromCancel;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormGraftCardCommand.NativeMethodInfoPtr_enterNode_Protected_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001A14 RID: 6676 RVA: 0x0006833C File Offset: 0x0006653C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 722168, XrefRangeEnd = 722172, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void enterNodeHints()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormGraftCardCommand.NativeMethodInfoPtr_enterNodeHints_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A15 RID: 6677 RVA: 0x00068378 File Offset: 0x00066578
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 722172, XrefRangeEnd = 722176, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void resetHints()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormGraftCardCommand.NativeMethodInfoPtr_resetHints_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A16 RID: 6678 RVA: 0x000683B4 File Offset: 0x000665B4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 722202, RefRangeEnd = 722204, XrefRangeStart = 722176, XrefRangeEnd = 722202, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<EntityID> GetHintedEntities()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormGraftCardCommand.NativeMethodInfoPtr_GetHintedEntities_Private_IEnumerable_1_EntityID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<EntityID>>(intPtr3) : null;
		}

		// Token: 0x06001A17 RID: 6679 RVA: 0x0000F3F3 File Offset: 0x0000D5F3
		public WormGraftCardCommand(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000F0E RID: 3854
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ISelectionNode_Boolean_0;

		// Token: 0x04000F0F RID: 3855
		private static readonly IntPtr NativeMethodInfoPtr_enterNode_Protected_Virtual_Void_Boolean_0;

		// Token: 0x04000F10 RID: 3856
		private static readonly IntPtr NativeMethodInfoPtr_enterNodeHints_Protected_Virtual_Void_0;

		// Token: 0x04000F11 RID: 3857
		private static readonly IntPtr NativeMethodInfoPtr_resetHints_Protected_Virtual_Void_0;

		// Token: 0x04000F12 RID: 3858
		private static readonly IntPtr NativeMethodInfoPtr_GetHintedEntities_Private_IEnumerable_1_EntityID_0;

		// Token: 0x0200042C RID: 1068
		[ObfuscatedName("worm.match.commands.selectionCommands.WormGraftCardCommand+<>c__DisplayClass1_0")]
		public sealed class __c__DisplayClass1_0 : Object
		{
			// Token: 0x06002C4F RID: 11343 RVA: 0x0009E688 File Offset: 0x0009C888
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass1_0()
			{
				Il2CppClassPointerStore<WormGraftCardCommand.__c__DisplayClass1_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormGraftCardCommand>.NativeClassPtr, "<>c__DisplayClass1_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormGraftCardCommand.__c__DisplayClass1_0>.NativeClassPtr);
				WormGraftCardCommand.__c__DisplayClass1_0.NativeFieldInfoPtr_viewManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormGraftCardCommand.__c__DisplayClass1_0>.NativeClassPtr, "viewManager");
				WormGraftCardCommand.__c__DisplayClass1_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormGraftCardCommand.__c__DisplayClass1_0>.NativeClassPtr, 100667091);
				WormGraftCardCommand.__c__DisplayClass1_0.NativeMethodInfoPtr__enterNode_b__0_Internal_Boolean_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormGraftCardCommand.__c__DisplayClass1_0>.NativeClassPtr, 100667092);
				WormGraftCardCommand.__c__DisplayClass1_0.NativeMethodInfoPtr__enterNode_b__1_Internal_Selectable_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormGraftCardCommand.__c__DisplayClass1_0>.NativeClassPtr, 100667093);
			}

			// Token: 0x06002C50 RID: 11344 RVA: 0x0009E704 File Offset: 0x0009C904
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass1_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormGraftCardCommand.__c__DisplayClass1_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormGraftCardCommand.__c__DisplayClass1_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002C51 RID: 11345 RVA: 0x0009E740 File Offset: 0x0009C940
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 722103, XrefRangeEnd = 722105, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _enterNode_b__0(EntityID s)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(s);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormGraftCardCommand.__c__DisplayClass1_0.NativeMethodInfoPtr__enterNode_b__0_Internal_Boolean_EntityID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06002C52 RID: 11346 RVA: 0x0009E790 File Offset: 0x0009C990
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 722105, XrefRangeEnd = 722110, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Selectable _enterNode_b__1(EntityID s)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(s);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormGraftCardCommand.__c__DisplayClass1_0.NativeMethodInfoPtr__enterNode_b__1_Internal_Selectable_EntityID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Selectable>(intPtr3) : null;
				}
			}

			// Token: 0x06002C53 RID: 11347 RVA: 0x00018126 File Offset: 0x00016326
			public __c__DisplayClass1_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000CB0 RID: 3248
			// (get) Token: 0x06002C54 RID: 11348 RVA: 0x0009E7E0 File Offset: 0x0009C9E0
			// (set) Token: 0x06002C55 RID: 11349 RVA: 0x0001812F File Offset: 0x0001632F
			public unsafe ViewManager viewManager
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormGraftCardCommand.__c__DisplayClass1_0.NativeFieldInfoPtr_viewManager);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ViewManager>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormGraftCardCommand.__c__DisplayClass1_0.NativeFieldInfoPtr_viewManager), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040019C5 RID: 6597
			private static readonly IntPtr NativeFieldInfoPtr_viewManager;

			// Token: 0x040019C6 RID: 6598
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040019C7 RID: 6599
			private static readonly IntPtr NativeMethodInfoPtr__enterNode_b__0_Internal_Boolean_EntityID_0;

			// Token: 0x040019C8 RID: 6600
			private static readonly IntPtr NativeMethodInfoPtr__enterNode_b__1_Internal_Selectable_EntityID_0;
		}
	}
}
