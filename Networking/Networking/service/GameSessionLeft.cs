using System;
using Canis.json.events;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Networking.service
{
	// Token: 0x02000053 RID: 83
	public class GameSessionLeft : NetworkMessageEvent
	{
		// Token: 0x060002AE RID: 686 RVA: 0x0000CBE8 File Offset: 0x0000ADE8
		// Note: this type is marked as 'beforefieldinit'.
		static GameSessionLeft()
		{
			Il2CppClassPointerStore<GameSessionLeft>.NativeClassPtr = IL2CPP.GetIl2CppClass("Networking.dll", "Networking.service", "GameSessionLeft");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameSessionLeft>.NativeClassPtr);
			GameSessionLeft.NativeFieldInfoPtr_GameSessionID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameSessionLeft>.NativeClassPtr, "GameSessionID");
			GameSessionLeft.NativeFieldInfoPtr_PlayerAccountID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameSessionLeft>.NativeClassPtr, "PlayerAccountID");
			GameSessionLeft.NativeFieldInfoPtr_PlayerScreenName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameSessionLeft>.NativeClassPtr, "PlayerScreenName");
			GameSessionLeft.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameSessionLeft>.NativeClassPtr, 100663433);
		}

		// Token: 0x060002AF RID: 687 RVA: 0x0000CC68 File Offset: 0x0000AE68
		[CallerCount(114)]
		[CachedScanResults(RefRangeStart = 530639, RefRangeEnd = 530753, XrefRangeStart = 530639, XrefRangeEnd = 530753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GameSessionLeft()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameSessionLeft>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameSessionLeft.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002B0 RID: 688 RVA: 0x00003BD6 File Offset: 0x00001DD6
		public GameSessionLeft(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000CE RID: 206
		// (get) Token: 0x060002B1 RID: 689 RVA: 0x0000CCA4 File Offset: 0x0000AEA4
		// (set) Token: 0x060002B2 RID: 690 RVA: 0x00003BDF File Offset: 0x00001DDF
		public unsafe string GameSessionID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameSessionLeft.NativeFieldInfoPtr_GameSessionID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameSessionLeft.NativeFieldInfoPtr_GameSessionID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000CF RID: 207
		// (get) Token: 0x060002B3 RID: 691 RVA: 0x0000CCCC File Offset: 0x0000AECC
		// (set) Token: 0x060002B4 RID: 692 RVA: 0x00003BFE File Offset: 0x00001DFE
		public unsafe AccountID PlayerAccountID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameSessionLeft.NativeFieldInfoPtr_PlayerAccountID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AccountID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameSessionLeft.NativeFieldInfoPtr_PlayerAccountID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000D0 RID: 208
		// (get) Token: 0x060002B5 RID: 693 RVA: 0x0000CCFC File Offset: 0x0000AEFC
		// (set) Token: 0x060002B6 RID: 694 RVA: 0x00003C1D File Offset: 0x00001E1D
		public unsafe string PlayerScreenName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameSessionLeft.NativeFieldInfoPtr_PlayerScreenName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameSessionLeft.NativeFieldInfoPtr_PlayerScreenName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x0400014D RID: 333
		private static readonly IntPtr NativeFieldInfoPtr_GameSessionID;

		// Token: 0x0400014E RID: 334
		private static readonly IntPtr NativeFieldInfoPtr_PlayerAccountID;

		// Token: 0x0400014F RID: 335
		private static readonly IntPtr NativeFieldInfoPtr_PlayerScreenName;

		// Token: 0x04000150 RID: 336
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
