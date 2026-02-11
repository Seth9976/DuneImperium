using System;
using dwd.core.ui.prompt.behaviours;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace dbgclient.prompts.behaviours
{
	// Token: 0x02000099 RID: 153
	public class ShopPage : TabulatedPromptPage
	{
		// Token: 0x060005E9 RID: 1513 RVA: 0x00030628 File Offset: 0x0002E828
		// Note: this type is marked as 'beforefieldinit'.
		static ShopPage()
		{
			Il2CppClassPointerStore<ShopPage>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "dbgclient.prompts.behaviours", "ShopPage");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShopPage>.NativeClassPtr);
			ShopPage.NativeFieldInfoPtr_tabType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopPage>.NativeClassPtr, "tabType");
			ShopPage.NativeFieldInfoPtr_shopPromptBehavior = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopPage>.NativeClassPtr, "shopPromptBehavior");
			ShopPage.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopPage>.NativeClassPtr, 100664210);
			ShopPage.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopPage>.NativeClassPtr, 100664211);
		}

		// Token: 0x060005EA RID: 1514 RVA: 0x000306A8 File Offset: 0x0002E8A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 502462, XrefRangeEnd = 502480, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopPage.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005EB RID: 1515 RVA: 0x000306DC File Offset: 0x0002E8DC
		[CallerCount(197)]
		[CachedScanResults(RefRangeStart = 496077, RefRangeEnd = 496274, XrefRangeStart = 496077, XrefRangeEnd = 496274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ShopPage()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShopPage>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopPage.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005EC RID: 1516 RVA: 0x00004A14 File Offset: 0x00002C14
		public ShopPage(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000173 RID: 371
		// (get) Token: 0x060005ED RID: 1517 RVA: 0x00030718 File Offset: 0x0002E918
		// (set) Token: 0x060005EE RID: 1518 RVA: 0x00004A1D File Offset: 0x00002C1D
		public unsafe ShopPromptTab tabType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopPage.NativeFieldInfoPtr_tabType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopPage.NativeFieldInfoPtr_tabType)) = value;
			}
		}

		// Token: 0x17000174 RID: 372
		// (get) Token: 0x060005EF RID: 1519 RVA: 0x00030740 File Offset: 0x0002E940
		// (set) Token: 0x060005F0 RID: 1520 RVA: 0x00004A38 File Offset: 0x00002C38
		public unsafe ShopPromptBehaviour shopPromptBehavior
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopPage.NativeFieldInfoPtr_shopPromptBehavior);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ShopPromptBehaviour>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopPage.NativeFieldInfoPtr_shopPromptBehavior), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040003AA RID: 938
		private static readonly IntPtr NativeFieldInfoPtr_tabType;

		// Token: 0x040003AB RID: 939
		private static readonly IntPtr NativeFieldInfoPtr_shopPromptBehavior;

		// Token: 0x040003AC RID: 940
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x040003AD RID: 941
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
