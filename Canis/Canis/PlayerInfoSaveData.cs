using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Canis
{
	// Token: 0x0200002A RID: 42
	public class PlayerInfoSaveData : Object
	{
		// Token: 0x060002E9 RID: 745 RVA: 0x00025300 File Offset: 0x00023500
		// Note: this type is marked as 'beforefieldinit'.
		static PlayerInfoSaveData()
		{
			Il2CppClassPointerStore<PlayerInfoSaveData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis", "PlayerInfoSaveData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerInfoSaveData>.NativeClassPtr);
			PlayerInfoSaveData.NativeFieldInfoPtr_AccountID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerInfoSaveData>.NativeClassPtr, "AccountID");
			PlayerInfoSaveData.NativeFieldInfoPtr_ScreenName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerInfoSaveData>.NativeClassPtr, "ScreenName");
			PlayerInfoSaveData.NativeFieldInfoPtr_IsHuman = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerInfoSaveData>.NativeClassPtr, "IsHuman");
			PlayerInfoSaveData.NativeFieldInfoPtr_AILevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerInfoSaveData>.NativeClassPtr, "AILevel");
			PlayerInfoSaveData.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInfoSaveData>.NativeClassPtr, 100663941);
			PlayerInfoSaveData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInfoSaveData>.NativeClassPtr, 100663942);
		}

		// Token: 0x060002EA RID: 746 RVA: 0x000253A8 File Offset: 0x000235A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 549294, XrefRangeEnd = 549314, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayerInfoSaveData.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060002EB RID: 747 RVA: 0x000253EC File Offset: 0x000235EC
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlayerInfoSaveData()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerInfoSaveData>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerInfoSaveData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002EC RID: 748 RVA: 0x00003465 File Offset: 0x00001665
		public PlayerInfoSaveData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000DC RID: 220
		// (get) Token: 0x060002ED RID: 749 RVA: 0x00025428 File Offset: 0x00023628
		// (set) Token: 0x060002EE RID: 750 RVA: 0x0000346E File Offset: 0x0000166E
		public unsafe AccountID AccountID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerInfoSaveData.NativeFieldInfoPtr_AccountID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AccountID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerInfoSaveData.NativeFieldInfoPtr_AccountID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000DD RID: 221
		// (get) Token: 0x060002EF RID: 751 RVA: 0x00025458 File Offset: 0x00023658
		// (set) Token: 0x060002F0 RID: 752 RVA: 0x0000348D File Offset: 0x0000168D
		public unsafe string ScreenName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerInfoSaveData.NativeFieldInfoPtr_ScreenName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerInfoSaveData.NativeFieldInfoPtr_ScreenName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000DE RID: 222
		// (get) Token: 0x060002F1 RID: 753 RVA: 0x00025480 File Offset: 0x00023680
		// (set) Token: 0x060002F2 RID: 754 RVA: 0x000034AC File Offset: 0x000016AC
		public unsafe bool IsHuman
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerInfoSaveData.NativeFieldInfoPtr_IsHuman);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerInfoSaveData.NativeFieldInfoPtr_IsHuman)) = value;
			}
		}

		// Token: 0x170000DF RID: 223
		// (get) Token: 0x060002F3 RID: 755 RVA: 0x000254A8 File Offset: 0x000236A8
		// (set) Token: 0x060002F4 RID: 756 RVA: 0x000034C7 File Offset: 0x000016C7
		public unsafe int AILevel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerInfoSaveData.NativeFieldInfoPtr_AILevel);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerInfoSaveData.NativeFieldInfoPtr_AILevel)) = value;
			}
		}

		// Token: 0x040001F5 RID: 501
		private static readonly IntPtr NativeFieldInfoPtr_AccountID;

		// Token: 0x040001F6 RID: 502
		private static readonly IntPtr NativeFieldInfoPtr_ScreenName;

		// Token: 0x040001F7 RID: 503
		private static readonly IntPtr NativeFieldInfoPtr_IsHuman;

		// Token: 0x040001F8 RID: 504
		private static readonly IntPtr NativeFieldInfoPtr_AILevel;

		// Token: 0x040001F9 RID: 505
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x040001FA RID: 506
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
