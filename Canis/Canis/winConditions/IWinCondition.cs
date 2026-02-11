using System;
using Canis.actions;
using Canis.entities;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Canis.winConditions
{
	// Token: 0x0200002F RID: 47
	public class IWinCondition : Object
	{
		// Token: 0x0600032D RID: 813 RVA: 0x00025FD0 File Offset: 0x000241D0
		// Note: this type is marked as 'beforefieldinit'.
		static IWinCondition()
		{
			Il2CppClassPointerStore<IWinCondition>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.winConditions", "IWinCondition");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IWinCondition>.NativeClassPtr);
			IWinCondition.NativeMethodInfoPtr_DidWin_Public_Abstract_Virtual_New_Boolean_PlayerEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IWinCondition>.NativeClassPtr, 100663962);
			IWinCondition.NativeMethodInfoPtr_ExtraActions_Public_Virtual_New_IEnumerable_1_Action_PlayerEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IWinCondition>.NativeClassPtr, 100663963);
			IWinCondition.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IWinCondition>.NativeClassPtr, 100663964);
		}

		// Token: 0x0600032E RID: 814 RVA: 0x0002603C File Offset: 0x0002423C
		[CallerCount(0)]
		public unsafe virtual bool DidWin(PlayerEntity player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IWinCondition.NativeMethodInfoPtr_DidWin_Public_Abstract_Virtual_New_Boolean_PlayerEntity_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600032F RID: 815 RVA: 0x00026094 File Offset: 0x00024294
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 549496, XrefRangeEnd = 549499, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerable<Canis.actions.Action> ExtraActions(PlayerEntity player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IWinCondition.NativeMethodInfoPtr_ExtraActions_Public_Virtual_New_IEnumerable_1_Action_PlayerEntity_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Canis.actions.Action>>(intPtr3) : null;
			}
		}

		// Token: 0x06000330 RID: 816 RVA: 0x000260F0 File Offset: 0x000242F0
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IWinCondition()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IWinCondition>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IWinCondition.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000331 RID: 817 RVA: 0x000036E6 File Offset: 0x000018E6
		public IWinCondition(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400021B RID: 539
		private static readonly IntPtr NativeMethodInfoPtr_DidWin_Public_Abstract_Virtual_New_Boolean_PlayerEntity_0;

		// Token: 0x0400021C RID: 540
		private static readonly IntPtr NativeMethodInfoPtr_ExtraActions_Public_Virtual_New_IEnumerable_1_Action_PlayerEntity_0;

		// Token: 0x0400021D RID: 541
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
