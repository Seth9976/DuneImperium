using System;
using Canis.attributes;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace boardgames.attributes
{
	// Token: 0x0200015F RID: 351
	public class AttributeView : VersionedView<IAttribute>
	{
		// Token: 0x060011D1 RID: 4561 RVA: 0x00047C3C File Offset: 0x00045E3C
		// Note: this type is marked as 'beforefieldinit'.
		static AttributeView()
		{
			Il2CppClassPointerStore<AttributeView>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "boardgames.attributes", "AttributeView");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AttributeView>.NativeClassPtr);
			AttributeView.NativeFieldInfoPtr_attribute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttributeView>.NativeClassPtr, "attribute");
			AttributeView.NativeFieldInfoPtr_view = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttributeView>.NativeClassPtr, "view");
			AttributeView.NativeFieldInfoPtr_provider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttributeView>.NativeClassPtr, "provider");
			AttributeView.NativeFieldInfoPtr_lastData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttributeView>.NativeClassPtr, "lastData");
			AttributeView.NativeMethodInfoPtr_Start_Protected_Virtual_Final_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeView>.NativeClassPtr, 100665917);
			AttributeView.NativeMethodInfoPtr_start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeView>.NativeClassPtr, 100665918);
			AttributeView.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeView>.NativeClassPtr, 100665919);
			AttributeView.NativeMethodInfoPtr_GetView_Protected_Virtual_New_IAttributesProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeView>.NativeClassPtr, 100665920);
			AttributeView.NativeMethodInfoPtr_Update_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeView>.NativeClassPtr, 100665921);
			AttributeView.NativeMethodInfoPtr_UpdateData_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeView>.NativeClassPtr, 100665922);
			AttributeView.NativeMethodInfoPtr_OnAttributesChanged_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeView>.NativeClassPtr, 100665923);
			AttributeView.NativeMethodInfoPtr_OnViewChanged_Protected_Virtual_New_Void_IHasAttributes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeView>.NativeClassPtr, 100665924);
			AttributeView.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeView>.NativeClassPtr, 100665925);
			AttributeView.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeView>.NativeClassPtr, 100665926);
			AttributeView.NativeMethodInfoPtr__GetView_b__7_0_Private_Boolean_IAttributesProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeView>.NativeClassPtr, 100665927);
		}

		// Token: 0x060011D2 RID: 4562 RVA: 0x00047D98 File Offset: 0x00045F98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1000434, XrefRangeEnd = 1000437, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AttributeView.NativeMethodInfoPtr_Start_Protected_Virtual_Final_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060011D3 RID: 4563 RVA: 0x00047DCC File Offset: 0x00045FCC
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1000449, RefRangeEnd = 1000455, XrefRangeStart = 1000437, XrefRangeEnd = 1000449, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AttributeView.NativeMethodInfoPtr_start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060011D4 RID: 4564 RVA: 0x00047E08 File Offset: 0x00046008
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1000455, XrefRangeEnd = 1000459, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AttributeView.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060011D5 RID: 4565 RVA: 0x00047E3C File Offset: 0x0004603C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1000459, XrefRangeEnd = 1000477, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IAttributesProvider GetView()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AttributeView.NativeMethodInfoPtr_GetView_Protected_Virtual_New_IAttributesProvider_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAttributesProvider>(intPtr3) : null;
		}

		// Token: 0x060011D6 RID: 4566 RVA: 0x00047E88 File Offset: 0x00046088
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1000481, RefRangeEnd = 1000482, XrefRangeStart = 1000477, XrefRangeEnd = 1000481, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AttributeView.NativeMethodInfoPtr_Update_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060011D7 RID: 4567 RVA: 0x00047EC4 File Offset: 0x000460C4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1000493, RefRangeEnd = 1000496, XrefRangeStart = 1000482, XrefRangeEnd = 1000493, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AttributeView.NativeMethodInfoPtr_UpdateData_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060011D8 RID: 4568 RVA: 0x00047EF8 File Offset: 0x000460F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1000496, XrefRangeEnd = 1000500, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnAttributesChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AttributeView.NativeMethodInfoPtr_OnAttributesChanged_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060011D9 RID: 4569 RVA: 0x00047F2C File Offset: 0x0004612C
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnViewChanged(IHasAttributes newView)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(newView);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AttributeView.NativeMethodInfoPtr_OnViewChanged_Protected_Virtual_New_Void_IHasAttributes_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060011DA RID: 4570 RVA: 0x00047F7C File Offset: 0x0004617C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1000500, XrefRangeEnd = 1000509, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AttributeView.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060011DB RID: 4571 RVA: 0x00047FB0 File Offset: 0x000461B0
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1000333, RefRangeEnd = 1000339, XrefRangeStart = 1000333, XrefRangeEnd = 1000339, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AttributeView()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AttributeView>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AttributeView.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060011DC RID: 4572 RVA: 0x00047FEC File Offset: 0x000461EC
		[CallerCount(0)]
		public unsafe bool _GetView_b__7_0(IAttributesProvider p)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AttributeView.NativeMethodInfoPtr__GetView_b__7_0_Private_Boolean_IAttributesProvider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060011DD RID: 4573 RVA: 0x0000A544 File Offset: 0x00008744
		public AttributeView(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700051F RID: 1311
		// (get) Token: 0x060011DE RID: 4574 RVA: 0x0004803C File Offset: 0x0004623C
		// (set) Token: 0x060011DF RID: 4575 RVA: 0x0000A54D File Offset: 0x0000874D
		public unsafe int attribute
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributeView.NativeFieldInfoPtr_attribute);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributeView.NativeFieldInfoPtr_attribute)) = value;
			}
		}

		// Token: 0x17000520 RID: 1312
		// (get) Token: 0x060011E0 RID: 4576 RVA: 0x00048064 File Offset: 0x00046264
		// (set) Token: 0x060011E1 RID: 4577 RVA: 0x0000A568 File Offset: 0x00008768
		public unsafe Object view
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributeView.NativeFieldInfoPtr_view);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributeView.NativeFieldInfoPtr_view), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000521 RID: 1313
		// (get) Token: 0x060011E2 RID: 4578 RVA: 0x00048094 File Offset: 0x00046294
		// (set) Token: 0x060011E3 RID: 4579 RVA: 0x0000A587 File Offset: 0x00008787
		public unsafe IAttributesProvider provider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributeView.NativeFieldInfoPtr_provider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IAttributesProvider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributeView.NativeFieldInfoPtr_provider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000522 RID: 1314
		// (get) Token: 0x060011E4 RID: 4580 RVA: 0x000480C4 File Offset: 0x000462C4
		// (set) Token: 0x060011E5 RID: 4581 RVA: 0x0000A5A6 File Offset: 0x000087A6
		public unsafe IHasAttributes lastData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributeView.NativeFieldInfoPtr_lastData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IHasAttributes>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributeView.NativeFieldInfoPtr_lastData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000AD4 RID: 2772
		private static readonly IntPtr NativeFieldInfoPtr_attribute;

		// Token: 0x04000AD5 RID: 2773
		private static readonly IntPtr NativeFieldInfoPtr_view;

		// Token: 0x04000AD6 RID: 2774
		private static readonly IntPtr NativeFieldInfoPtr_provider;

		// Token: 0x04000AD7 RID: 2775
		private static readonly IntPtr NativeFieldInfoPtr_lastData;

		// Token: 0x04000AD8 RID: 2776
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Final_Void_0;

		// Token: 0x04000AD9 RID: 2777
		private static readonly IntPtr NativeMethodInfoPtr_start_Protected_Virtual_Void_0;

		// Token: 0x04000ADA RID: 2778
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04000ADB RID: 2779
		private static readonly IntPtr NativeMethodInfoPtr_GetView_Protected_Virtual_New_IAttributesProvider_0;

		// Token: 0x04000ADC RID: 2780
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_Void_0;

		// Token: 0x04000ADD RID: 2781
		private static readonly IntPtr NativeMethodInfoPtr_UpdateData_Private_Void_0;

		// Token: 0x04000ADE RID: 2782
		private static readonly IntPtr NativeMethodInfoPtr_OnAttributesChanged_Private_Void_0;

		// Token: 0x04000ADF RID: 2783
		private static readonly IntPtr NativeMethodInfoPtr_OnViewChanged_Protected_Virtual_New_Void_IHasAttributes_0;

		// Token: 0x04000AE0 RID: 2784
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x04000AE1 RID: 2785
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x04000AE2 RID: 2786
		private static readonly IntPtr NativeMethodInfoPtr__GetView_b__7_0_Private_Boolean_IAttributesProvider_0;
	}
}
