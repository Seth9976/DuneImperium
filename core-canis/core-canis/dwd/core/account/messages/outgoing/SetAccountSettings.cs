using System;
using Canis.json.events;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace dwd.core.account.messages.outgoing
{
	// Token: 0x02000226 RID: 550
	public class SetAccountSettings : NetworkMessageEvent
	{
		// Token: 0x06001DF6 RID: 7670 RVA: 0x00089E4C File Offset: 0x0008804C
		// Note: this type is marked as 'beforefieldinit'.
		static SetAccountSettings()
		{
			Il2CppClassPointerStore<SetAccountSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.account.messages.outgoing", "SetAccountSettings");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SetAccountSettings>.NativeClassPtr);
			SetAccountSettings.NativeFieldInfoPtr_Settings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetAccountSettings>.NativeClassPtr, "Settings");
			SetAccountSettings.NativeMethodInfoPtr__ctor_Public_Void_Dictionary_2_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetAccountSettings>.NativeClassPtr, 100668097);
		}

		// Token: 0x06001DF7 RID: 7671 RVA: 0x00089EA4 File Offset: 0x000880A4
		[CallerCount(43)]
		[CachedScanResults(RefRangeStart = 495240, RefRangeEnd = 495283, XrefRangeStart = 495240, XrefRangeEnd = 495283, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SetAccountSettings(Dictionary<int, int> settings)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SetAccountSettings>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(settings);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetAccountSettings.NativeMethodInfoPtr__ctor_Public_Void_Dictionary_2_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001DF8 RID: 7672 RVA: 0x0000CD08 File Offset: 0x0000AF08
		public SetAccountSettings(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700084B RID: 2123
		// (get) Token: 0x06001DF9 RID: 7673 RVA: 0x00089EF0 File Offset: 0x000880F0
		// (set) Token: 0x06001DFA RID: 7674 RVA: 0x0000CD11 File Offset: 0x0000AF11
		public unsafe Dictionary<int, int> Settings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetAccountSettings.NativeFieldInfoPtr_Settings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetAccountSettings.NativeFieldInfoPtr_Settings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040014ED RID: 5357
		private static readonly IntPtr NativeFieldInfoPtr_Settings;

		// Token: 0x040014EE RID: 5358
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Dictionary_2_Int32_Int32_0;
	}
}
