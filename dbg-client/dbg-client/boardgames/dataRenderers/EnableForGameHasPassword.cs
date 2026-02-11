using System;
using boardgames.data;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace boardgames.dataRenderers
{
	// Token: 0x02000145 RID: 325
	public class EnableForGameHasPassword : VersionedSubscriber<PendingGameData>
	{
		// Token: 0x06000EDA RID: 3802 RVA: 0x0004CF08 File Offset: 0x0004B108
		// Note: this type is marked as 'beforefieldinit'.
		static EnableForGameHasPassword()
		{
			Il2CppClassPointerStore<EnableForGameHasPassword>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.dataRenderers", "EnableForGameHasPassword");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EnableForGameHasPassword>.NativeClassPtr);
			EnableForGameHasPassword.NativeFieldInfoPtr_hasPasswordObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnableForGameHasPassword>.NativeClassPtr, "hasPasswordObject");
			EnableForGameHasPassword.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnableForGameHasPassword>.NativeClassPtr, 100665459);
			EnableForGameHasPassword.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnableForGameHasPassword>.NativeClassPtr, 100665460);
		}

		// Token: 0x06000EDB RID: 3803 RVA: 0x0004CF74 File Offset: 0x0004B174
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 512724, XrefRangeEnd = 512727, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void dirtyUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EnableForGameHasPassword.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EDC RID: 3804 RVA: 0x0004CFB0 File Offset: 0x0004B1B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 512727, XrefRangeEnd = 512730, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EnableForGameHasPassword()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EnableForGameHasPassword>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnableForGameHasPassword.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EDD RID: 3805 RVA: 0x0000926C File Offset: 0x0000746C
		public EnableForGameHasPassword(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003F9 RID: 1017
		// (get) Token: 0x06000EDE RID: 3806 RVA: 0x0004CFEC File Offset: 0x0004B1EC
		// (set) Token: 0x06000EDF RID: 3807 RVA: 0x00009275 File Offset: 0x00007475
		public unsafe GameObject hasPasswordObject
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnableForGameHasPassword.NativeFieldInfoPtr_hasPasswordObject);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnableForGameHasPassword.NativeFieldInfoPtr_hasPasswordObject), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400092B RID: 2347
		private static readonly IntPtr NativeFieldInfoPtr_hasPasswordObject;

		// Token: 0x0400092C RID: 2348
		private static readonly IntPtr NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0;

		// Token: 0x0400092D RID: 2349
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
