using System;
using boardgames.menus.prompts;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace dbgclient.prompts
{
	// Token: 0x02000095 RID: 149
	public class ShopPrompt : DBGTopLevelMenuPrompt
	{
		// Token: 0x060005D6 RID: 1494 RVA: 0x0003026C File Offset: 0x0002E46C
		// Note: this type is marked as 'beforefieldinit'.
		static ShopPrompt()
		{
			Il2CppClassPointerStore<ShopPrompt>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "dbgclient.prompts", "ShopPrompt");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShopPrompt>.NativeClassPtr);
			ShopPrompt.NativeFieldInfoPtr__StartingTab_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopPrompt>.NativeClassPtr, "<StartingTab>k__BackingField");
			ShopPrompt.NativeMethodInfoPtr_get_StartingTab_Public_get_ShopPromptTab_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopPrompt>.NativeClassPtr, 100664203);
			ShopPrompt.NativeMethodInfoPtr_set_StartingTab_Private_set_Void_ShopPromptTab_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopPrompt>.NativeClassPtr, 100664204);
			ShopPrompt.NativeMethodInfoPtr__ctor_Public_Void_ShopPromptTab_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopPrompt>.NativeClassPtr, 100664205);
		}

		// Token: 0x1700016E RID: 366
		// (get) Token: 0x060005D7 RID: 1495 RVA: 0x000302EC File Offset: 0x0002E4EC
		// (set) Token: 0x060005D8 RID: 1496 RVA: 0x00030328 File Offset: 0x0002E528
		public unsafe ShopPromptTab StartingTab
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopPrompt.NativeMethodInfoPtr_get_StartingTab_Public_get_ShopPromptTab_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopPrompt.NativeMethodInfoPtr_set_StartingTab_Private_set_Void_ShopPromptTab_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060005D9 RID: 1497 RVA: 0x00030368 File Offset: 0x0002E568
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 502450, RefRangeEnd = 502451, XrefRangeStart = 502449, XrefRangeEnd = 502450, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ShopPrompt(ShopPromptTab startingTab)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShopPrompt>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref startingTab;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopPrompt.NativeMethodInfoPtr__ctor_Public_Void_ShopPromptTab_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060005DA RID: 1498 RVA: 0x000049A0 File Offset: 0x00002BA0
		public ShopPrompt(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700016D RID: 365
		// (get) Token: 0x060005DB RID: 1499 RVA: 0x000303B0 File Offset: 0x0002E5B0
		// (set) Token: 0x060005DC RID: 1500 RVA: 0x000049A9 File Offset: 0x00002BA9
		public unsafe ShopPromptTab _StartingTab_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopPrompt.NativeFieldInfoPtr__StartingTab_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopPrompt.NativeFieldInfoPtr__StartingTab_k__BackingField)) = value;
			}
		}

		// Token: 0x0400039C RID: 924
		private static readonly IntPtr NativeFieldInfoPtr__StartingTab_k__BackingField;

		// Token: 0x0400039D RID: 925
		private static readonly IntPtr NativeMethodInfoPtr_get_StartingTab_Public_get_ShopPromptTab_0;

		// Token: 0x0400039E RID: 926
		private static readonly IntPtr NativeMethodInfoPtr_set_StartingTab_Private_set_Void_ShopPromptTab_0;

		// Token: 0x0400039F RID: 927
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ShopPromptTab_0;
	}
}
