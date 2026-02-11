using System;
using boardgames.data;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace dwd.canis.lib.canis.dbg_client.dataRenderers
{
	// Token: 0x0200005C RID: 92
	public class SetAnimFromPlayerSlotData : VersionedSubscriber<PlayerTypeData>
	{
		// Token: 0x06000384 RID: 900 RVA: 0x00028B78 File Offset: 0x00026D78
		// Note: this type is marked as 'beforefieldinit'.
		static SetAnimFromPlayerSlotData()
		{
			Il2CppClassPointerStore<SetAnimFromPlayerSlotData>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "dwd.canis.lib.canis.dbg_client.dataRenderers", "SetAnimFromPlayerSlotData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SetAnimFromPlayerSlotData>.NativeClassPtr);
			SetAnimFromPlayerSlotData.NativeFieldInfoPtr_DisabledBool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetAnimFromPlayerSlotData>.NativeClassPtr, "DisabledBool");
			SetAnimFromPlayerSlotData.NativeFieldInfoPtr_OpenBool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetAnimFromPlayerSlotData>.NativeClassPtr, "OpenBool");
			SetAnimFromPlayerSlotData.NativeFieldInfoPtr_FilledBool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetAnimFromPlayerSlotData>.NativeClassPtr, "FilledBool");
			SetAnimFromPlayerSlotData.NativeFieldInfoPtr_animator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetAnimFromPlayerSlotData>.NativeClassPtr, "animator");
			SetAnimFromPlayerSlotData.NativeMethodInfoPtr_start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetAnimFromPlayerSlotData>.NativeClassPtr, 100663844);
			SetAnimFromPlayerSlotData.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetAnimFromPlayerSlotData>.NativeClassPtr, 100663845);
			SetAnimFromPlayerSlotData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetAnimFromPlayerSlotData>.NativeClassPtr, 100663846);
		}

		// Token: 0x06000385 RID: 901 RVA: 0x00028C34 File Offset: 0x00026E34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 499864, XrefRangeEnd = 499869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SetAnimFromPlayerSlotData.NativeMethodInfoPtr_start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000386 RID: 902 RVA: 0x00028C70 File Offset: 0x00026E70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 499869, XrefRangeEnd = 499878, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void dirtyUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SetAnimFromPlayerSlotData.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000387 RID: 903 RVA: 0x00028CAC File Offset: 0x00026EAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 499878, XrefRangeEnd = 499893, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SetAnimFromPlayerSlotData()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SetAnimFromPlayerSlotData>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetAnimFromPlayerSlotData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000388 RID: 904 RVA: 0x00003889 File Offset: 0x00001A89
		public SetAnimFromPlayerSlotData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000D5 RID: 213
		// (get) Token: 0x06000389 RID: 905 RVA: 0x00028CE8 File Offset: 0x00026EE8
		// (set) Token: 0x0600038A RID: 906 RVA: 0x00003892 File Offset: 0x00001A92
		public unsafe string DisabledBool
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetAnimFromPlayerSlotData.NativeFieldInfoPtr_DisabledBool);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetAnimFromPlayerSlotData.NativeFieldInfoPtr_DisabledBool), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000D6 RID: 214
		// (get) Token: 0x0600038B RID: 907 RVA: 0x00028D10 File Offset: 0x00026F10
		// (set) Token: 0x0600038C RID: 908 RVA: 0x000038B1 File Offset: 0x00001AB1
		public unsafe string OpenBool
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetAnimFromPlayerSlotData.NativeFieldInfoPtr_OpenBool);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetAnimFromPlayerSlotData.NativeFieldInfoPtr_OpenBool), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000D7 RID: 215
		// (get) Token: 0x0600038D RID: 909 RVA: 0x00028D38 File Offset: 0x00026F38
		// (set) Token: 0x0600038E RID: 910 RVA: 0x000038D0 File Offset: 0x00001AD0
		public unsafe string FilledBool
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetAnimFromPlayerSlotData.NativeFieldInfoPtr_FilledBool);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetAnimFromPlayerSlotData.NativeFieldInfoPtr_FilledBool), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000D8 RID: 216
		// (get) Token: 0x0600038F RID: 911 RVA: 0x00028D60 File Offset: 0x00026F60
		// (set) Token: 0x06000390 RID: 912 RVA: 0x000038EF File Offset: 0x00001AEF
		public unsafe Animator animator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetAnimFromPlayerSlotData.NativeFieldInfoPtr_animator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetAnimFromPlayerSlotData.NativeFieldInfoPtr_animator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000227 RID: 551
		private static readonly IntPtr NativeFieldInfoPtr_DisabledBool;

		// Token: 0x04000228 RID: 552
		private static readonly IntPtr NativeFieldInfoPtr_OpenBool;

		// Token: 0x04000229 RID: 553
		private static readonly IntPtr NativeFieldInfoPtr_FilledBool;

		// Token: 0x0400022A RID: 554
		private static readonly IntPtr NativeFieldInfoPtr_animator;

		// Token: 0x0400022B RID: 555
		private static readonly IntPtr NativeMethodInfoPtr_start_Protected_Virtual_Void_0;

		// Token: 0x0400022C RID: 556
		private static readonly IntPtr NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0;

		// Token: 0x0400022D RID: 557
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
