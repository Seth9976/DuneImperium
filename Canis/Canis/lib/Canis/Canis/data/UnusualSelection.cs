using System;
using Canis.utils.ids;
using Canis.utils.localization;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace lib.canis.Canis.data
{
	// Token: 0x0200001F RID: 31
	public class UnusualSelection : Object
	{
		// Token: 0x0600011C RID: 284 RVA: 0x0001D7DC File Offset: 0x0001B9DC
		// Note: this type is marked as 'beforefieldinit'.
		static UnusualSelection()
		{
			Il2CppClassPointerStore<UnusualSelection>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "lib.canis.Canis.data", "UnusualSelection");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnusualSelection>.NativeClassPtr);
			UnusualSelection.NativeFieldInfoPtr_Warning = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnusualSelection>.NativeClassPtr, "Warning");
			UnusualSelection.NativeFieldInfoPtr_Entities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnusualSelection>.NativeClassPtr, "Entities");
			UnusualSelection.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnusualSelection>.NativeClassPtr, 100663474);
		}

		// Token: 0x0600011D RID: 285 RVA: 0x0001D848 File Offset: 0x0001BA48
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UnusualSelection()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnusualSelection>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnusualSelection.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600011E RID: 286 RVA: 0x0000289B File Offset: 0x00000A9B
		public UnusualSelection(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x0600011F RID: 287 RVA: 0x0001D884 File Offset: 0x0001BA84
		// (set) Token: 0x06000120 RID: 288 RVA: 0x000028A4 File Offset: 0x00000AA4
		public unsafe LocalizableTextVariables Warning
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnusualSelection.NativeFieldInfoPtr_Warning);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LocalizableTextVariables>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnusualSelection.NativeFieldInfoPtr_Warning), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x06000121 RID: 289 RVA: 0x0001D8B4 File Offset: 0x0001BAB4
		// (set) Token: 0x06000122 RID: 290 RVA: 0x000028C3 File Offset: 0x00000AC3
		public unsafe List<EntityID> Entities
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnusualSelection.NativeFieldInfoPtr_Entities);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<EntityID>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnusualSelection.NativeFieldInfoPtr_Entities), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400009E RID: 158
		private static readonly IntPtr NativeFieldInfoPtr_Warning;

		// Token: 0x0400009F RID: 159
		private static readonly IntPtr NativeFieldInfoPtr_Entities;

		// Token: 0x040000A0 RID: 160
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
