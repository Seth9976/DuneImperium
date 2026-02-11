using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace dwd.canis.dbg_client.prompts
{
	// Token: 0x0200006E RID: 110
	[Serializable]
	public class ItemConfig : global::Il2CppSystem.Object
	{
		// Token: 0x06000420 RID: 1056 RVA: 0x0002A7F8 File Offset: 0x000289F8
		// Note: this type is marked as 'beforefieldinit'.
		static ItemConfig()
		{
			Il2CppClassPointerStore<ItemConfig>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "dwd.canis.dbg_client.prompts", "ItemConfig");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ItemConfig>.NativeClassPtr);
			ItemConfig.NativeFieldInfoPtr_item = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemConfig>.NativeClassPtr, "item");
			ItemConfig.NativeFieldInfoPtr_enabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemConfig>.NativeClassPtr, "enabled");
			ItemConfig.NativeMethodInfoPtr_Resolve_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemConfig>.NativeClassPtr, 100663924);
			ItemConfig.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemConfig>.NativeClassPtr, 100663925);
		}

		// Token: 0x06000421 RID: 1057 RVA: 0x0002A878 File Offset: 0x00028A78
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 500514, RefRangeEnd = 500516, XrefRangeStart = 500509, XrefRangeEnd = 500514, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Resolve()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemConfig.NativeMethodInfoPtr_Resolve_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000422 RID: 1058 RVA: 0x0002A8AC File Offset: 0x00028AAC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 500517, RefRangeEnd = 500518, XrefRangeStart = 500516, XrefRangeEnd = 500517, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ItemConfig()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ItemConfig>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemConfig.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000423 RID: 1059 RVA: 0x00003D72 File Offset: 0x00001F72
		public ItemConfig(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000FB RID: 251
		// (get) Token: 0x06000424 RID: 1060 RVA: 0x0002A8E8 File Offset: 0x00028AE8
		// (set) Token: 0x06000425 RID: 1061 RVA: 0x00003D7B File Offset: 0x00001F7B
		public unsafe GameObject item
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemConfig.NativeFieldInfoPtr_item);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemConfig.NativeFieldInfoPtr_item), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000FC RID: 252
		// (get) Token: 0x06000426 RID: 1062 RVA: 0x0002A918 File Offset: 0x00028B18
		// (set) Token: 0x06000427 RID: 1063 RVA: 0x00003D9A File Offset: 0x00001F9A
		public unsafe bool enabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemConfig.NativeFieldInfoPtr_enabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemConfig.NativeFieldInfoPtr_enabled)) = value;
			}
		}

		// Token: 0x0400027C RID: 636
		private static readonly IntPtr NativeFieldInfoPtr_item;

		// Token: 0x0400027D RID: 637
		private static readonly IntPtr NativeFieldInfoPtr_enabled;

		// Token: 0x0400027E RID: 638
		private static readonly IntPtr NativeMethodInfoPtr_Resolve_Public_Void_0;

		// Token: 0x0400027F RID: 639
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
