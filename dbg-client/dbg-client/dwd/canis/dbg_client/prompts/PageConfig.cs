using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace dwd.canis.dbg_client.prompts
{
	// Token: 0x0200006F RID: 111
	[Serializable]
	public sealed class PageConfig : ValueType
	{
		// Token: 0x06000428 RID: 1064 RVA: 0x0002A940 File Offset: 0x00028B40
		// Note: this type is marked as 'beforefieldinit'.
		static PageConfig()
		{
			Il2CppClassPointerStore<PageConfig>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "dwd.canis.dbg_client.prompts", "PageConfig");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PageConfig>.NativeClassPtr);
			PageConfig.NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PageConfig>.NativeClassPtr, "name");
			PageConfig.NativeFieldInfoPtr_tabRoot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PageConfig>.NativeClassPtr, "tabRoot");
			PageConfig.NativeFieldInfoPtr_items = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PageConfig>.NativeClassPtr, "items");
			PageConfig.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PageConfig>.NativeClassPtr, 100663926);
		}

		// Token: 0x06000429 RID: 1065 RVA: 0x0002A9C0 File Offset: 0x00028BC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 500518, XrefRangeEnd = 500521, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PageConfig(string name)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PageConfig>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PageConfig.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600042A RID: 1066 RVA: 0x00003DB5 File Offset: 0x00001FB5
		public PageConfig(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0600042B RID: 1067 RVA: 0x00003DBE File Offset: 0x00001FBE
		public PageConfig()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PageConfig>.NativeClassPtr))
		{
		}

		// Token: 0x170000FD RID: 253
		// (get) Token: 0x0600042C RID: 1068 RVA: 0x0002AA10 File Offset: 0x00028C10
		// (set) Token: 0x0600042D RID: 1069 RVA: 0x00003DD0 File Offset: 0x00001FD0
		public unsafe string name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PageConfig.NativeFieldInfoPtr_name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PageConfig.NativeFieldInfoPtr_name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000FE RID: 254
		// (get) Token: 0x0600042E RID: 1070 RVA: 0x0002AA38 File Offset: 0x00028C38
		// (set) Token: 0x0600042F RID: 1071 RVA: 0x00003DEF File Offset: 0x00001FEF
		public unsafe ItemConfig tabRoot
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PageConfig.NativeFieldInfoPtr_tabRoot);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemConfig>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PageConfig.NativeFieldInfoPtr_tabRoot), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000FF RID: 255
		// (get) Token: 0x06000430 RID: 1072 RVA: 0x0002AA68 File Offset: 0x00028C68
		// (set) Token: 0x06000431 RID: 1073 RVA: 0x00003E0E File Offset: 0x0000200E
		public unsafe List<ItemConfig> items
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PageConfig.NativeFieldInfoPtr_items);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ItemConfig>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PageConfig.NativeFieldInfoPtr_items), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000280 RID: 640
		private static readonly IntPtr NativeFieldInfoPtr_name;

		// Token: 0x04000281 RID: 641
		private static readonly IntPtr NativeFieldInfoPtr_tabRoot;

		// Token: 0x04000282 RID: 642
		private static readonly IntPtr NativeFieldInfoPtr_items;

		// Token: 0x04000283 RID: 643
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;
	}
}
